
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
            this.recordPathTextBox = new System.Windows.Forms.TextBox();
            this.copyLocationButton = new Recordroid.CircularButton();
            this.crossButton = new Recordroid.CircularButton();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.minButton = new Recordroid.CircularButton();
            this.notifyIcon1 = new System.Windows.Forms.NotifyIcon(this.components);
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.recorDroidToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.startRecordingToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pauseRecordingToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.preferencesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.fpsTrackBar)).BeginInit();
            this.contextMenuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // storePathTextBox
            // 
            this.storePathTextBox.Enabled = false;
            this.storePathTextBox.Location = new System.Drawing.Point(23, 63);
            this.storePathTextBox.Name = "storePathTextBox";
            this.storePathTextBox.ReadOnly = true;
            this.storePathTextBox.Size = new System.Drawing.Size(328, 23);
            this.storePathTextBox.TabIndex = 4;
            this.storePathTextBox.Text = "Choose location to save recording...";
            // 
            // desktopAudioChkBox
            // 
            this.desktopAudioChkBox.AutoSize = true;
            this.desktopAudioChkBox.Location = new System.Drawing.Point(24, 177);
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
            this.recordButton.Image = global::Recordroid.Properties.Resources.record_4_32x32;
            this.recordButton.Location = new System.Drawing.Point(166, 212);
            this.recordButton.Name = "recordButton";
            this.recordButton.Size = new System.Drawing.Size(36, 36);
            this.recordButton.TabIndex = 8;
            this.toolTip1.SetToolTip(this.recordButton, "Start/End recording");
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
            this.pauseButton.Image = global::Recordroid.Properties.Resources.pause_2_32x32;
            this.pauseButton.Location = new System.Drawing.Point(202, 212);
            this.pauseButton.Name = "pauseButton";
            this.pauseButton.Size = new System.Drawing.Size(36, 36);
            this.pauseButton.TabIndex = 9;
            this.toolTip1.SetToolTip(this.pauseButton, "Pause/Resume recording");
            this.pauseButton.UseVisualStyleBackColor = false;
            this.pauseButton.Click += new System.EventHandler(this.pauseButton_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(245, 225);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(0, 15);
            this.label1.TabIndex = 11;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(113, 225);
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
            this.settingsButton.Image = global::Recordroid.Properties.Resources.settings_32x32;
            this.settingsButton.Location = new System.Drawing.Point(319, 10);
            this.settingsButton.Name = "settingsButton";
            this.settingsButton.Size = new System.Drawing.Size(36, 36);
            this.settingsButton.TabIndex = 14;
            this.toolTip1.SetToolTip(this.settingsButton, "Preferences");
            this.settingsButton.UseVisualStyleBackColor = false;
            this.settingsButton.Click += new System.EventHandler(this.circularButton3_Click);
            // 
            // micAudioChkBox
            // 
            this.micAudioChkBox.AutoSize = true;
            this.micAudioChkBox.Location = new System.Drawing.Point(232, 177);
            this.micAudioChkBox.Name = "micAudioChkBox";
            this.micAudioChkBox.Size = new System.Drawing.Size(119, 19);
            this.micAudioChkBox.TabIndex = 17;
            this.micAudioChkBox.Text = "Record mic audio";
            this.toolTip1.SetToolTip(this.micAudioChkBox, "Default input device will be used");
            this.micAudioChkBox.UseVisualStyleBackColor = true;
            // 
            // browseButton
            // 
            this.browseButton.BackColor = System.Drawing.Color.White;
            this.browseButton.FlatAppearance.BorderSize = 0;
            this.browseButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.browseButton.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.browseButton.Image = global::Recordroid.Properties.Resources.download_32x32_2_26x26;
            this.browseButton.Location = new System.Drawing.Point(361, 59);
            this.browseButton.Name = "browseButton";
            this.browseButton.Size = new System.Drawing.Size(28, 28);
            this.browseButton.TabIndex = 18;
            this.toolTip1.SetToolTip(this.browseButton, "Browse directory");
            this.browseButton.UseVisualStyleBackColor = false;
            this.browseButton.Click += new System.EventHandler(this.browseButton_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.fpsTrackBar);
            this.groupBox1.Location = new System.Drawing.Point(23, 121);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(328, 51);
            this.groupBox1.TabIndex = 19;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Frames per second (FPS)";
            this.toolTip1.SetToolTip(this.groupBox1, resources.GetString("groupBox1.ToolTip"));
            // 
            // fpsTrackBar
            // 
            this.fpsTrackBar.Dock = System.Windows.Forms.DockStyle.Fill;
            this.fpsTrackBar.LargeChange = 2;
            this.fpsTrackBar.Location = new System.Drawing.Point(3, 19);
            this.fpsTrackBar.Maximum = 6;
            this.fpsTrackBar.Minimum = 1;
            this.fpsTrackBar.Name = "fpsTrackBar";
            this.fpsTrackBar.Size = new System.Drawing.Size(322, 29);
            this.fpsTrackBar.TabIndex = 16;
            this.fpsTrackBar.Value = 3;
            this.fpsTrackBar.Scroll += new System.EventHandler(this.fpsTrackBar_Scroll);
            // 
            // fpsLabel
            // 
            this.fpsLabel.AutoSize = true;
            this.fpsLabel.Location = new System.Drawing.Point(361, 143);
            this.fpsLabel.Name = "fpsLabel";
            this.fpsLabel.Size = new System.Drawing.Size(19, 15);
            this.fpsLabel.TabIndex = 18;
            this.fpsLabel.Text = "60";
            // 
            // recordPathTextBox
            // 
            this.recordPathTextBox.Location = new System.Drawing.Point(23, 92);
            this.recordPathTextBox.Name = "recordPathTextBox";
            this.recordPathTextBox.ReadOnly = true;
            this.recordPathTextBox.Size = new System.Drawing.Size(328, 23);
            this.recordPathTextBox.TabIndex = 20;
            this.recordPathTextBox.Text = "Recording will be saved as...";
            // 
            // copyLocationButton
            // 
            this.copyLocationButton.BackColor = System.Drawing.Color.White;
            this.copyLocationButton.FlatAppearance.BorderSize = 0;
            this.copyLocationButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.copyLocationButton.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.copyLocationButton.Image = global::Recordroid.Properties.Resources.bfa_copy_flat_circle_white_on_orange_gradient_512x512_32x32_1_26x26;
            this.copyLocationButton.Location = new System.Drawing.Point(361, 88);
            this.copyLocationButton.Name = "copyLocationButton";
            this.copyLocationButton.Size = new System.Drawing.Size(28, 28);
            this.copyLocationButton.TabIndex = 21;
            this.toolTip1.SetToolTip(this.copyLocationButton, "Copy to clipboard");
            this.copyLocationButton.UseVisualStyleBackColor = false;
            this.copyLocationButton.Click += new System.EventHandler(this.copyLocationButton_Click);
            // 
            // crossButton
            // 
            this.crossButton.BackColor = System.Drawing.Color.White;
            this.crossButton.FlatAppearance.BorderSize = 0;
            this.crossButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.crossButton.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.crossButton.Image = global::Recordroid.Properties.Resources.cross_32x32;
            this.crossButton.Location = new System.Drawing.Point(353, 10);
            this.crossButton.Name = "crossButton";
            this.crossButton.Size = new System.Drawing.Size(36, 36);
            this.crossButton.TabIndex = 22;
            this.toolTip1.SetToolTip(this.crossButton, "Exit");
            this.crossButton.UseVisualStyleBackColor = false;
            this.crossButton.Click += new System.EventHandler(this.crossButton_Click);
            // 
            // minButton
            // 
            this.minButton.BackColor = System.Drawing.Color.White;
            this.minButton.FlatAppearance.BorderSize = 0;
            this.minButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.minButton.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.minButton.Image = global::Recordroid.Properties.Resources.min_32x321;
            this.minButton.Location = new System.Drawing.Point(284, 11);
            this.minButton.Name = "minButton";
            this.minButton.Size = new System.Drawing.Size(34, 34);
            this.minButton.TabIndex = 23;
            this.toolTip1.SetToolTip(this.minButton, "Minimize to tray");
            this.minButton.UseVisualStyleBackColor = false;
            this.minButton.Click += new System.EventHandler(this.minButton_Click);
            // 
            // notifyIcon1
            // 
            this.notifyIcon1.ContextMenuStrip = this.contextMenuStrip1;
            this.notifyIcon1.Icon = ((System.Drawing.Icon)(resources.GetObject("notifyIcon1.Icon")));
            this.notifyIcon1.Text = "notifyIcon1";
            this.notifyIcon1.DoubleClick += new System.EventHandler(this.notifyIcon1_DoubleClick);
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.recorDroidToolStripMenuItem,
            this.toolStripSeparator2,
            this.startRecordingToolStripMenuItem,
            this.pauseRecordingToolStripMenuItem,
            this.preferencesToolStripMenuItem,
            this.toolStripSeparator1,
            this.exitToolStripMenuItem});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(160, 126);
            // 
            // recorDroidToolStripMenuItem
            // 
            this.recorDroidToolStripMenuItem.Name = "recorDroidToolStripMenuItem";
            this.recorDroidToolStripMenuItem.Size = new System.Drawing.Size(159, 22);
            this.recorDroidToolStripMenuItem.Text = "RecorDroid";
            this.recorDroidToolStripMenuItem.Click += new System.EventHandler(this.recorDroidToolStripMenuItem_Click);
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(156, 6);
            // 
            // startRecordingToolStripMenuItem
            // 
            this.startRecordingToolStripMenuItem.Enabled = false;
            this.startRecordingToolStripMenuItem.Name = "startRecordingToolStripMenuItem";
            this.startRecordingToolStripMenuItem.Size = new System.Drawing.Size(159, 22);
            this.startRecordingToolStripMenuItem.Text = "Start recording";
            this.startRecordingToolStripMenuItem.Click += new System.EventHandler(this.startRecordingToolStripMenuItem_Click);
            // 
            // pauseRecordingToolStripMenuItem
            // 
            this.pauseRecordingToolStripMenuItem.Enabled = false;
            this.pauseRecordingToolStripMenuItem.Name = "pauseRecordingToolStripMenuItem";
            this.pauseRecordingToolStripMenuItem.Size = new System.Drawing.Size(159, 22);
            this.pauseRecordingToolStripMenuItem.Text = "Pause recording";
            this.pauseRecordingToolStripMenuItem.Click += new System.EventHandler(this.pauseRecordingToolStripMenuItem_Click);
            // 
            // preferencesToolStripMenuItem
            // 
            this.preferencesToolStripMenuItem.Name = "preferencesToolStripMenuItem";
            this.preferencesToolStripMenuItem.Size = new System.Drawing.Size(159, 22);
            this.preferencesToolStripMenuItem.Text = "Preferences";
            this.preferencesToolStripMenuItem.Click += new System.EventHandler(this.preferencesToolStripMenuItem_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(156, 6);
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(159, 22);
            this.exitToolStripMenuItem.Text = "Exit";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.exitToolStripMenuItem_Click);
            // 
            // Form1
            // 
            this.ClientSize = new System.Drawing.Size(395, 258);
            this.ControlBox = false;
            this.Controls.Add(this.minButton);
            this.Controls.Add(this.crossButton);
            this.Controls.Add(this.copyLocationButton);
            this.Controls.Add(this.recordPathTextBox);
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
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.Opacity = 0.95D;
            this.Resizable = false;
            this.Style = MetroFramework.MetroColorStyle.Orange;
            this.Text = "RecorDroid";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
            this.Load += new System.EventHandler(this.Form1_Load);
            this.Resize += new System.EventHandler(this.Form1_Resize);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.fpsTrackBar)).EndInit();
            this.contextMenuStrip1.ResumeLayout(false);
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
        private System.Windows.Forms.TextBox recordPathTextBox;
        private CircularButton copyLocationButton;
        private CircularButton crossButton;
        private System.Windows.Forms.ToolTip toolTip1;
        private System.Windows.Forms.NotifyIcon notifyIcon1;
        private CircularButton minButton;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem startRecordingToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem pauseRecordingToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem preferencesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem recorDroidToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
    }
}

