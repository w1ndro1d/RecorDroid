
namespace Recordroid
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.storePathTextBox = new System.Windows.Forms.TextBox();
            this.desktopAudioChkBox = new System.Windows.Forms.CheckBox();
            this.recordButton = new Recordroid.CircularButton();
            this.pauseButton = new Recordroid.CircularButton();
            this.label1 = new System.Windows.Forms.Label();
            this.progressTimer = new System.Windows.Forms.Timer(this.components);
            this.label2 = new System.Windows.Forms.Label();
            this.settingsButton = new Recordroid.CircularButton();
            this.micAudioChkBox = new System.Windows.Forms.CheckBox();
            this.browseButton = new Recordroid.CircularButton();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.fpsTrackBar = new System.Windows.Forms.TrackBar();
            this.fpsLabel = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.fpsTrackBar)).BeginInit();
            this.SuspendLayout();
            // 
            // storePathTextBox
            // 
            this.storePathTextBox.Enabled = false;
            this.storePathTextBox.Location = new System.Drawing.Point(23, 63);
            this.storePathTextBox.Name = "storePathTextBox";
            this.storePathTextBox.Size = new System.Drawing.Size(328, 23);
            this.storePathTextBox.TabIndex = 4;
            this.storePathTextBox.Text = "Choose location to save recording";
            // 
            // desktopAudioChkBox
            // 
            this.desktopAudioChkBox.AutoSize = true;
            this.desktopAudioChkBox.Location = new System.Drawing.Point(24, 153);
            this.desktopAudioChkBox.Name = "desktopAudioChkBox";
            this.desktopAudioChkBox.Size = new System.Drawing.Size(141, 19);
            this.desktopAudioChkBox.TabIndex = 6;
            this.desktopAudioChkBox.Text = "Record desktop audio";
            this.desktopAudioChkBox.UseVisualStyleBackColor = true;
            // 
            // recordButton
            // 
            this.recordButton.BackColor = System.Drawing.Color.White;
            this.recordButton.Enabled = false;
            this.recordButton.FlatAppearance.BorderSize = 0;
            this.recordButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.recordButton.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.recordButton.Image = ((System.Drawing.Image)(resources.GetObject("recordButton.Image")));
            this.recordButton.Location = new System.Drawing.Point(163, 182);
            this.recordButton.Name = "recordButton";
            this.recordButton.Size = new System.Drawing.Size(36, 36);
            this.recordButton.TabIndex = 8;
            this.recordButton.UseVisualStyleBackColor = false;
            this.recordButton.Click += new System.EventHandler(this.circularButton1_Click);
            // 
            // pauseButton
            // 
            this.pauseButton.BackColor = System.Drawing.Color.White;
            this.pauseButton.Enabled = false;
            this.pauseButton.FlatAppearance.BorderSize = 0;
            this.pauseButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.pauseButton.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.pauseButton.Image = ((System.Drawing.Image)(resources.GetObject("pauseButton.Image")));
            this.pauseButton.Location = new System.Drawing.Point(205, 182);
            this.pauseButton.Name = "pauseButton";
            this.pauseButton.Size = new System.Drawing.Size(36, 36);
            this.pauseButton.TabIndex = 9;
            this.pauseButton.UseVisualStyleBackColor = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(248, 195);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(0, 15);
            this.label1.TabIndex = 11;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(110, 195);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(0, 15);
            this.label2.TabIndex = 12;
            // 
            // settingsButton
            // 
            this.settingsButton.BackColor = System.Drawing.Color.White;
            this.settingsButton.FlatAppearance.BorderSize = 0;
            this.settingsButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.settingsButton.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.settingsButton.Image = ((System.Drawing.Image)(resources.GetObject("settingsButton.Image")));
            this.settingsButton.Location = new System.Drawing.Point(2, 182);
            this.settingsButton.Name = "settingsButton";
            this.settingsButton.Size = new System.Drawing.Size(36, 36);
            this.settingsButton.TabIndex = 14;
            this.settingsButton.UseVisualStyleBackColor = false;
            this.settingsButton.Click += new System.EventHandler(this.circularButton3_Click);
            // 
            // micAudioChkBox
            // 
            this.micAudioChkBox.AutoSize = true;
            this.micAudioChkBox.Location = new System.Drawing.Point(232, 153);
            this.micAudioChkBox.Name = "micAudioChkBox";
            this.micAudioChkBox.Size = new System.Drawing.Size(119, 19);
            this.micAudioChkBox.TabIndex = 17;
            this.micAudioChkBox.Text = "Record mic audio";
            this.micAudioChkBox.UseVisualStyleBackColor = true;
            // 
            // browseButton
            // 
            this.browseButton.BackColor = System.Drawing.Color.White;
            this.browseButton.FlatAppearance.BorderSize = 0;
            this.browseButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.browseButton.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.browseButton.Image = ((System.Drawing.Image)(resources.GetObject("browseButton.Image")));
            this.browseButton.Location = new System.Drawing.Point(357, 55);
            this.browseButton.Name = "browseButton";
            this.browseButton.Size = new System.Drawing.Size(36, 36);
            this.browseButton.TabIndex = 18;
            this.browseButton.UseVisualStyleBackColor = false;
            this.browseButton.Click += new System.EventHandler(this.browseButton_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.fpsTrackBar);
            this.groupBox1.Location = new System.Drawing.Point(23, 94);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(328, 51);
            this.groupBox1.TabIndex = 19;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Frames per second (FPS)";
            // 
            // fpsTrackBar
            // 
            this.fpsTrackBar.Dock = System.Windows.Forms.DockStyle.Fill;
            this.fpsTrackBar.LargeChange = 3;
            this.fpsTrackBar.Location = new System.Drawing.Point(3, 19);
            this.fpsTrackBar.Maximum = 7;
            this.fpsTrackBar.Minimum = 1;
            this.fpsTrackBar.Name = "fpsTrackBar";
            this.fpsTrackBar.Size = new System.Drawing.Size(322, 29);
            this.fpsTrackBar.TabIndex = 16;
            this.fpsTrackBar.Value = 2;
            this.fpsTrackBar.Scroll += new System.EventHandler(this.fpsTrackBar_Scroll);
            // 
            // fpsLabel
            // 
            this.fpsLabel.AutoSize = true;
            this.fpsLabel.Location = new System.Drawing.Point(361, 115);
            this.fpsLabel.Name = "fpsLabel";
            this.fpsLabel.Size = new System.Drawing.Size(19, 15);
            this.fpsLabel.TabIndex = 18;
            this.fpsLabel.Text = "30";
            // 
            // Form1
            // 
            this.ClientSize = new System.Drawing.Size(400, 221);
            this.Controls.Add(this.fpsLabel);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.browseButton);
            this.Controls.Add(this.micAudioChkBox);
            this.Controls.Add(this.settingsButton);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pauseButton);
            this.Controls.Add(this.recordButton);
            this.Controls.Add(this.desktopAudioChkBox);
            this.Controls.Add(this.storePathTextBox);
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.Opacity = 0.95D;
            this.Resizable = false;
            this.Style = MetroFramework.MetroColorStyle.Orange;
            this.Text = "RecorDroid";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.fpsTrackBar)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox storePathTextBox;
        private System.Windows.Forms.CheckBox desktopAudioChkBox;
        private CircularButton recordButton;
        private CircularButton pauseButton;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Timer progressTimer;
        private System.Windows.Forms.Label label2;
        private CircularButton settingsButton;
        private System.Windows.Forms.CheckBox micAudioChkBox;
        private CircularButton browseButton;
        public System.Windows.Forms.GroupBox groupBox1;
        public System.Windows.Forms.TrackBar fpsTrackBar;
        public System.Windows.Forms.Label fpsLabel;
    }
}

