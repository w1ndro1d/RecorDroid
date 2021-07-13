using System;
using System.IO;
using System.Threading;
using System.Windows.Forms;
using ScreenRecorderLib;


namespace Recordroid
{
    public partial class Form1 : MetroFramework.Forms.MetroForm
    {
        private bool isRecording; //flag for recording status
        private int secondsElapsed;  //elapsed time in seconds after pressing record
        Recorder rec;

        RecorderOptions options = new RecorderOptions //all parameters for recorder
        {
            RecorderMode = RecorderMode.Video,
            IsHardwareEncodingEnabled = true, //Hardware encoding is enabled by default.
            AudioOptions = new AudioOptions
            {
                Bitrate = AudioBitrate.bitrate_128kbps,
                Channels = AudioChannels.Stereo,
                IsAudioEnabled = true
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
            radioButton3.Checked = true; //default FPS is 60
            checkBox2.Checked = true; //record desktop audio by default
            checkBox3.Checked = true; //hardware encoding is enabled by default
        }

        private void circularButton1_Click(object sender, EventArgs e)
        {
            if (isRecording)
            {
                rec.Stop(); //if already recording, stop
                secondsElapsed = 0; //and reset secondsElapsed
                circularButton1.Enabled = false; //we don't want user to click it twice
                label2.Text = "";
                label1.Text = "";
                return; //no need of proceeding further if already recording
            }

            string timestamp = DateTime.Now.ToString("yyyy-MM-dd HH-mm-ss");
            string videoPath = Path.Combine(textBox1.Text, "RecorDroid", timestamp, timestamp + ".mp4");//for video filename

            progressTimer.Tick += progressTimer_Tick;
            progressTimer.Interval = 1000;
            progressTimer.Start();
            label1.Text = "Recording";

            if (rec == null)
            {
                rec = Recorder.CreateRecorder(options); //create Recorder rec with options
                rec.OnRecordingComplete += rec_OnRecordingComplete;
                rec.OnRecordingFailed += rec_OnRecordingFailed;
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
                textBox1.Text = filePath;
                label1.Text = "Finished Recording!";
                circularButton1.Enabled = true;
                isRecording = false;
                CleanupResources();
            })));
        }


        private void CleanupResources()
        {
            progressTimer.Stop();
            progressTimer = null;
            secondsElapsed = 0;
            rec = null;

        }

        private void button1_Click(object sender, EventArgs e)
        {
            FolderBrowserDialog fbd = new FolderBrowserDialog();
            if (fbd.ShowDialog() == DialogResult.OK)
            {
                textBox1.Text = fbd.SelectedPath;
                circularButton1.Enabled = true;
                circularButton2.Enabled = true;

            }
        }
    }
    
}
