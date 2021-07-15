using System;
using System.IO;
using System.Threading;
using System.Windows.Forms;
using ScreenRecorderLib;


namespace Recordroid
{
    public partial class Form1 : MetroFramework.Forms.MetroForm
    {
        Form2 form2 = new Form2();
        private bool isRecording; //flag for recording status
        private int secondsElapsed;  //elapsed time in seconds after pressing record
        Recorder rec;

        RecorderOptions options = new RecorderOptions //all parameters for recorder
        {
            RecorderMode = RecorderMode.Video,
            IsHardwareEncodingEnabled = true, //Hardware encoding is enabled by default.
            AudioOptions = new AudioOptions
            {
                Bitrate = AudioBitrate.bitrate_192kbps,
                Channels = AudioChannels.Stereo,

            },
            VideoOptions = new VideoOptions
            {
                BitrateMode = BitrateControlMode.UnconstrainedVBR,
                Bitrate = 12000 * 1000,
                Framerate = 60,
                IsFixedFramerate = true,
                EncoderProfile = H264Profile.Main
            },
            MouseOptions = new MouseOptions
            {
                IsMousePointerEnabled = true,

            }
        };
        
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

            desktopAudioChkBox.Checked = true;
            copyLocationButton.Enabled = false;
            pauseButton.Enabled = false;

        }

        private void circularButton1_Click(object sender, EventArgs e)
        {
            if (isRecording)
            {
                rec.Stop(); //if already recording, stop
                label2.Text = "";
                label1.Text = "";
                settingsButton.Enabled = true;
                desktopAudioChkBox.Enabled = true;
                micAudioChkBox.Enabled = true;
                browseButton.Enabled = true;
                groupBox1.Enabled = true;
                copyLocationButton.Enabled = true;
                pauseButton.Enabled = false;
                progressTimer?.Stop();
                progressTimer = null;
                secondsElapsed = 0;
                return;

            }

            string timestamp = DateTime.Now.ToString("yyyy-MM-dd HH-mm-ss");
            string videoPath = Path.Combine(storePathTextBox.Text, "RecorDroid", timestamp, timestamp + ".mp4");//for video filename

            progressTimer = new System.Windows.Forms.Timer();
            progressTimer.Tick += progressTimer_Tick;
            progressTimer.Interval = 1000;
            progressTimer.Start();

            label1.Text = "Recording";
            settingsButton.Enabled = false;
            desktopAudioChkBox.Enabled = false;
            micAudioChkBox.Enabled = false;
            browseButton.Enabled = false;
            groupBox1.Enabled = false;
            pauseButton.Enabled = true;


            if (rec == null)
            {
                if (desktopAudioChkBox.Checked)
                {
                    options.AudioOptions.IsAudioEnabled = true;
                }
                else
                {
                    options.AudioOptions.IsAudioEnabled = false;
                }

                if (micAudioChkBox.Checked)
                {
                    
                    options.AudioOptions.IsInputDeviceEnabled = true;
                    options.AudioOptions.InputVolume = 0.75F;
                    options.AudioOptions.OutputVolume = 0.25F;
                }
                else
                {
                    options.AudioOptions.IsInputDeviceEnabled = false;
                }

                if(form2.hwEncodeChkBox.Checked)
                {
                    options.IsHardwareEncodingEnabled = true;
                }
                else
                {
                    options.IsHardwareEncodingEnabled = true;
                }

                if(form2.mouseCursorChkBox.Checked)
                {
                    options.MouseOptions.IsMousePointerEnabled = true;
                }
                else
                {
                    options.MouseOptions.IsMousePointerEnabled = false;
                }

                if(form2.mouseClickChkBox.Checked)
                {
                    options.MouseOptions.IsMouseClicksDetected = true;
                }
                else
                {
                    options.MouseOptions.IsMouseClicksDetected = false;
                }

                switch(Int16.Parse(form2.audioBitrateLabel.Text))
                {
                    case 96:
                        options.AudioOptions.Bitrate = AudioBitrate.bitrate_96kbps;
                        break;
                    case 128:
                        options.AudioOptions.Bitrate = AudioBitrate.bitrate_128kbps;
                        break;
                    case 160:
                        options.AudioOptions.Bitrate = AudioBitrate.bitrate_160kbps;
                        break;
                    case 192:
                        options.AudioOptions.Bitrate = AudioBitrate.bitrate_192kbps;
                        break;
                }

                options.VideoOptions.BitrateMode = BitrateControlMode.Quality;
                options.VideoOptions.Quality = Int16.Parse(form2.videoQualityLabel.Text);
                options.VideoOptions.Bitrate = Int16.Parse(form2.videoBitrateLabel.Text) * 1000;

                rec = Recorder.CreateRecorder(options); //create Recorder rec with options
                rec.OnRecordingComplete += rec_OnRecordingComplete;
                rec.OnRecordingFailed += rec_OnRecordingFailed;
                rec.OnStatusChanged += rec_OnStatusChanged;
            }

            rec.Record(videoPath); //main operation
            secondsElapsed = 0;
            isRecording = true;
        }

        private void progressTimer_Tick(object sender, EventArgs e)
        {
            secondsElapsed++; //increase secondsElapsed with every tick of timer(after 1000ms)
            UpdateProgress();
        }

        private void UpdateProgress() //visual illustration of time elapsed in recording to user
        {
            label2.Text= TimeSpan.FromSeconds(secondsElapsed).ToString();
        }

        private void rec_OnRecordingFailed(object sender, RecordingFailedEventArgs e)
        {
            BeginInvoke(((Action)(() =>
            {
                label1.Text = "Error:"+e.Error;
                isRecording = false;
                CleanupResources();
            })));
        }

        private void rec_OnRecordingComplete(object sender, RecordingCompleteEventArgs e)
        {
            BeginInvoke(((Action)(() =>
            {
                string filePath = e.FilePath;
                recordPathTextBox.Text = filePath;
                label1.Text = "Finished Recording!";
                recordButton.Enabled = true;
                isRecording = false;
                CleanupResources();
            })));
        }

        private void rec_OnStatusChanged(object sender, RecordingStatusEventArgs e)
        {
            BeginInvoke(((Action)(() =>
            {
                switch (e.Status)
                {
                    case RecorderStatus.Paused:
                        if (progressTimer != null)
                            progressTimer.Enabled = false;
                        label1.Text = "Paused";
                        break;
                    case RecorderStatus.Recording:
                        if (progressTimer != null)
                            progressTimer.Enabled = true;
                        label1.Text = "Recording";
                        break;
                    default:
                        break;
                }
            })));
        }

        private void CleanupResources()
        {
            progressTimer?.Stop();
            progressTimer = null;
            secondsElapsed = 0;
            rec?.Dispose();
            rec = null;

        }

        private void browseButton_Click(object sender, EventArgs e)
        {
            FolderBrowserDialog fbd = new FolderBrowserDialog();
            if (fbd.ShowDialog() == DialogResult.OK)
            {
                storePathTextBox.Text = fbd.SelectedPath;
                recordButton.Enabled = true;
                

            }
        }

        private void circularButton3_Click(object sender, EventArgs e)
        {
            form2.ShowDialog();
            
        }

        private void fpsTrackBar_Scroll(object sender, EventArgs e)
        {
            switch (fpsTrackBar.Value)
            {
                case 1:
                    fpsLabel.Text = "24";
                    break;
                case 2:
                    fpsLabel.Text = "30";
                    break;
                case 3:
                    fpsLabel.Text = "60";
                    break;
                case 4:
                    fpsLabel.Text = "90";
                    break;
                case 5:
                    fpsLabel.Text = "120";
                    break;
                case 6:
                    fpsLabel.Text = "144";
                    break;
                case 7:
                    fpsLabel.Text = "300";
                    break;
            }
        }

        private void copyLocationButton_Click(object sender, EventArgs e)
        {
            Clipboard.SetText(recordPathTextBox.Text);
        }

        private void pauseButton_Click(object sender, EventArgs e)
        {
            if (rec.Status == RecorderStatus.Paused)
            {
                rec.Resume();
                return;
            }
            rec.Pause();

        }
    }
    
}
