
namespace Recordroid
{
    partial class Form2
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.hwEncodeChkBox = new System.Windows.Forms.CheckBox();
            this.audioTrackBar = new System.Windows.Forms.TrackBar();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.audioBitrateLabel = new System.Windows.Forms.Label();
            this.videoBitrateLabel = new System.Windows.Forms.Label();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.videoTrackBar = new System.Windows.Forms.TrackBar();
            this.mouseCursorChkBox = new System.Windows.Forms.CheckBox();
            this.mouseClickChkBox = new System.Windows.Forms.CheckBox();
            this.doneButton = new Recordroid.CircularButton();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.videoQualityTrackBar = new System.Windows.Forms.TrackBar();
            this.videoQualityLabel = new System.Windows.Forms.Label();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.audioTrackBar)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.videoTrackBar)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.videoQualityTrackBar)).BeginInit();
            this.SuspendLayout();
            // 
            // hwEncodeChkBox
            // 
            this.hwEncodeChkBox.AutoSize = true;
            this.hwEncodeChkBox.Location = new System.Drawing.Point(23, 63);
            this.hwEncodeChkBox.Name = "hwEncodeChkBox";
            this.hwEncodeChkBox.Size = new System.Drawing.Size(166, 19);
            this.hwEncodeChkBox.TabIndex = 14;
            this.hwEncodeChkBox.Text = "Enable hardware encoding";
            this.toolTip1.SetToolTip(this.hwEncodeChkBox, "Reduce CPU load by using dedicated GPU. Turn this off if your video turns out lag" +
        "gy.");
            this.hwEncodeChkBox.UseVisualStyleBackColor = true;
            // 
            // audioTrackBar
            // 
            this.audioTrackBar.Dock = System.Windows.Forms.DockStyle.Fill;
            this.audioTrackBar.LargeChange = 3;
            this.audioTrackBar.Location = new System.Drawing.Point(3, 19);
            this.audioTrackBar.Maximum = 4;
            this.audioTrackBar.Minimum = 1;
            this.audioTrackBar.Name = "audioTrackBar";
            this.audioTrackBar.Size = new System.Drawing.Size(366, 29);
            this.audioTrackBar.TabIndex = 16;
            this.audioTrackBar.Value = 4;
            this.audioTrackBar.Scroll += new System.EventHandler(this.audioTrackBar_Scroll);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.audioTrackBar);
            this.groupBox2.Location = new System.Drawing.Point(23, 88);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(372, 51);
            this.groupBox2.TabIndex = 17;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Audio bitrate (kbit/s)";
            this.toolTip1.SetToolTip(this.groupBox2, "High audio bitrate means better sound quality. 192kbit/s is recommended.");
            // 
            // audioBitrateLabel
            // 
            this.audioBitrateLabel.AutoSize = true;
            this.audioBitrateLabel.Location = new System.Drawing.Point(401, 108);
            this.audioBitrateLabel.Name = "audioBitrateLabel";
            this.audioBitrateLabel.Size = new System.Drawing.Size(25, 15);
            this.audioBitrateLabel.TabIndex = 17;
            this.audioBitrateLabel.Text = "192";
            // 
            // videoBitrateLabel
            // 
            this.videoBitrateLabel.AutoSize = true;
            this.videoBitrateLabel.Location = new System.Drawing.Point(401, 217);
            this.videoBitrateLabel.Name = "videoBitrateLabel";
            this.videoBitrateLabel.Size = new System.Drawing.Size(19, 15);
            this.videoBitrateLabel.TabIndex = 18;
            this.videoBitrateLabel.Text = "12";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.videoTrackBar);
            this.groupBox3.Location = new System.Drawing.Point(23, 196);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(372, 51);
            this.groupBox3.TabIndex = 19;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Video bitrate (Mbit/s)";
            this.toolTip1.SetToolTip(this.groupBox3, "For 30fps recording:\r\n720p:5Mbit/s\r\n1080p:8Mbit/s\r\n2K+:16Mbit/s+\r\n\r\nFor 60fps rec" +
        "ording:\r\n720p:8Mbit/s\r\n1080p:12Mbit/s\r\n2K+:25Mbit/s+\r\n");
            // 
            // videoTrackBar
            // 
            this.videoTrackBar.Dock = System.Windows.Forms.DockStyle.Fill;
            this.videoTrackBar.LargeChange = 3;
            this.videoTrackBar.Location = new System.Drawing.Point(3, 19);
            this.videoTrackBar.Maximum = 70;
            this.videoTrackBar.Minimum = 5;
            this.videoTrackBar.Name = "videoTrackBar";
            this.videoTrackBar.Size = new System.Drawing.Size(366, 29);
            this.videoTrackBar.TabIndex = 16;
            this.videoTrackBar.Value = 12;
            this.videoTrackBar.Scroll += new System.EventHandler(this.videoTrackBar_Scroll);
            // 
            // mouseCursorChkBox
            // 
            this.mouseCursorChkBox.AutoSize = true;
            this.mouseCursorChkBox.Location = new System.Drawing.Point(23, 253);
            this.mouseCursorChkBox.Name = "mouseCursorChkBox";
            this.mouseCursorChkBox.Size = new System.Drawing.Size(138, 19);
            this.mouseCursorChkBox.TabIndex = 20;
            this.mouseCursorChkBox.Text = "Record mouse cursor";
            this.mouseCursorChkBox.UseVisualStyleBackColor = true;
            // 
            // mouseClickChkBox
            // 
            this.mouseClickChkBox.AutoSize = true;
            this.mouseClickChkBox.Location = new System.Drawing.Point(23, 278);
            this.mouseClickChkBox.Name = "mouseClickChkBox";
            this.mouseClickChkBox.Size = new System.Drawing.Size(129, 19);
            this.mouseClickChkBox.TabIndex = 21;
            this.mouseClickChkBox.Text = "Record mouse click";
            this.mouseClickChkBox.UseVisualStyleBackColor = true;
            // 
            // doneButton
            // 
            this.doneButton.BackColor = System.Drawing.Color.White;
            this.doneButton.FlatAppearance.BorderSize = 0;
            this.doneButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.doneButton.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.doneButton.Image = global::Recordroid.Properties.Resources.check_tick_icon_14152_32x32;
            this.doneButton.Location = new System.Drawing.Point(385, 18);
            this.doneButton.Name = "doneButton";
            this.doneButton.Size = new System.Drawing.Size(36, 36);
            this.doneButton.TabIndex = 22;
            this.toolTip1.SetToolTip(this.doneButton, "Apply");
            this.doneButton.UseVisualStyleBackColor = false;
            this.doneButton.Click += new System.EventHandler(this.doneButton_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.videoQualityTrackBar);
            this.groupBox1.Location = new System.Drawing.Point(23, 142);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(372, 51);
            this.groupBox1.TabIndex = 20;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Video quality (higher is better)";
            this.toolTip1.SetToolTip(this.groupBox1, "Select desired video quality. 1 is lowest quality and 100 is near source quality." +
        "\r\n1 quality produces the lowest file size while 100 quality results a large file" +
        ".");
            // 
            // videoQualityTrackBar
            // 
            this.videoQualityTrackBar.Dock = System.Windows.Forms.DockStyle.Fill;
            this.videoQualityTrackBar.LargeChange = 3;
            this.videoQualityTrackBar.Location = new System.Drawing.Point(3, 19);
            this.videoQualityTrackBar.Maximum = 100;
            this.videoQualityTrackBar.Minimum = 1;
            this.videoQualityTrackBar.Name = "videoQualityTrackBar";
            this.videoQualityTrackBar.Size = new System.Drawing.Size(366, 29);
            this.videoQualityTrackBar.TabIndex = 16;
            this.videoQualityTrackBar.Value = 70;
            this.videoQualityTrackBar.Scroll += new System.EventHandler(this.videoQualityTrackBar_Scroll);
            // 
            // videoQualityLabel
            // 
            this.videoQualityLabel.AutoSize = true;
            this.videoQualityLabel.Location = new System.Drawing.Point(401, 163);
            this.videoQualityLabel.Name = "videoQualityLabel";
            this.videoQualityLabel.Size = new System.Drawing.Size(19, 15);
            this.videoQualityLabel.TabIndex = 23;
            this.videoQualityLabel.Text = "70";
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BorderStyle = MetroFramework.Forms.MetroFormBorderStyle.FixedSingle;
            this.ClientSize = new System.Drawing.Size(436, 307);
            this.ControlBox = false;
            this.Controls.Add(this.videoQualityLabel);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.doneButton);
            this.Controls.Add(this.mouseClickChkBox);
            this.Controls.Add(this.mouseCursorChkBox);
            this.Controls.Add(this.videoBitrateLabel);
            this.Controls.Add(this.audioBitrateLabel);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.hwEncodeChkBox);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Form2";
            this.Opacity = 0.9D;
            this.Resizable = false;
            this.ShadowType = MetroFramework.Forms.MetroFormShadowType.None;
            this.ShowInTaskbar = false;
            this.Style = MetroFramework.MetroColorStyle.Orange;
            this.Text = "Preferences";
            this.TopMost = true;
            this.Load += new System.EventHandler(this.Form2_Load);
            ((System.ComponentModel.ISupportInitialize)(this.audioTrackBar)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.videoTrackBar)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.videoQualityTrackBar)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        public System.Windows.Forms.CheckBox hwEncodeChkBox;
        public System.Windows.Forms.TrackBar audioTrackBar;
        public System.Windows.Forms.GroupBox groupBox2;
        public System.Windows.Forms.Label audioBitrateLabel;
        public System.Windows.Forms.Label videoBitrateLabel;
        public System.Windows.Forms.GroupBox groupBox3;
        public System.Windows.Forms.TrackBar videoTrackBar;
        public System.Windows.Forms.CheckBox mouseCursorChkBox;
        public System.Windows.Forms.CheckBox mouseClickChkBox;
        private CircularButton doneButton;
        public System.Windows.Forms.GroupBox groupBox1;
        public System.Windows.Forms.TrackBar videoQualityTrackBar;
        public System.Windows.Forms.Label videoQualityLabel;
        private System.Windows.Forms.ToolTip toolTip1;
    }
}