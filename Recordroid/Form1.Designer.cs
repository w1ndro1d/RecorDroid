
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.radioButton7 = new System.Windows.Forms.RadioButton();
            this.radioButton6 = new System.Windows.Forms.RadioButton();
            this.radioButton5 = new System.Windows.Forms.RadioButton();
            this.radioButton4 = new System.Windows.Forms.RadioButton();
            this.radioButton3 = new System.Windows.Forms.RadioButton();
            this.radioButton2 = new System.Windows.Forms.RadioButton();
            this.radioButton1 = new System.Windows.Forms.RadioButton();
            this.recordButton = new Recordroid.CircularButton();
            this.pauseButton = new Recordroid.CircularButton();
            this.label1 = new System.Windows.Forms.Label();
            this.progressTimer = new System.Windows.Forms.Timer(this.components);
            this.label2 = new System.Windows.Forms.Label();
            this.settingsButton = new Recordroid.CircularButton();
            this.micAudioChkBox = new System.Windows.Forms.CheckBox();
            this.browseButton = new Recordroid.CircularButton();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // storePathTextBox
            // 
            this.storePathTextBox.Enabled = false;
            this.storePathTextBox.Location = new System.Drawing.Point(23, 63);
            this.storePathTextBox.Name = "storePathTextBox";
            this.storePathTextBox.Size = new System.Drawing.Size(328, 23);
            this.storePathTextBox.TabIndex = 4;
            this.storePathTextBox.Text = "Choose location to store recording";
            // 
            // desktopAudioChkBox
            // 
            this.desktopAudioChkBox.AutoSize = true;
            this.desktopAudioChkBox.Location = new System.Drawing.Point(24, 144);
            this.desktopAudioChkBox.Name = "desktopAudioChkBox";
            this.desktopAudioChkBox.Size = new System.Drawing.Size(141, 19);
            this.desktopAudioChkBox.TabIndex = 6;
            this.desktopAudioChkBox.Text = "Record desktop audio";
            this.desktopAudioChkBox.UseVisualStyleBackColor = true;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.radioButton7);
            this.groupBox1.Controls.Add(this.radioButton6);
            this.groupBox1.Controls.Add(this.radioButton5);
            this.groupBox1.Controls.Add(this.radioButton4);
            this.groupBox1.Controls.Add(this.radioButton3);
            this.groupBox1.Controls.Add(this.radioButton2);
            this.groupBox1.Controls.Add(this.radioButton1);
            this.groupBox1.Location = new System.Drawing.Point(23, 93);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(328, 37);
            this.groupBox1.TabIndex = 7;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Framerate";
            // 
            // radioButton7
            // 
            this.radioButton7.AutoSize = true;
            this.radioButton7.Location = new System.Drawing.Point(282, 15);
            this.radioButton7.Name = "radioButton7";
            this.radioButton7.Size = new System.Drawing.Size(43, 19);
            this.radioButton7.TabIndex = 6;
            this.radioButton7.TabStop = true;
            this.radioButton7.Text = "300";
            this.radioButton7.UseVisualStyleBackColor = true;
            // 
            // radioButton6
            // 
            this.radioButton6.AutoSize = true;
            this.radioButton6.Location = new System.Drawing.Point(232, 15);
            this.radioButton6.Name = "radioButton6";
            this.radioButton6.Size = new System.Drawing.Size(43, 19);
            this.radioButton6.TabIndex = 5;
            this.radioButton6.TabStop = true;
            this.radioButton6.Text = "144";
            this.radioButton6.UseVisualStyleBackColor = true;
            // 
            // radioButton5
            // 
            this.radioButton5.AutoSize = true;
            this.radioButton5.Location = new System.Drawing.Point(182, 15);
            this.radioButton5.Name = "radioButton5";
            this.radioButton5.Size = new System.Drawing.Size(43, 19);
            this.radioButton5.TabIndex = 4;
            this.radioButton5.TabStop = true;
            this.radioButton5.Text = "120";
            this.radioButton5.UseVisualStyleBackColor = true;
            // 
            // radioButton4
            // 
            this.radioButton4.AutoSize = true;
            this.radioButton4.Location = new System.Drawing.Point(138, 15);
            this.radioButton4.Name = "radioButton4";
            this.radioButton4.Size = new System.Drawing.Size(37, 19);
            this.radioButton4.TabIndex = 3;
            this.radioButton4.TabStop = true;
            this.radioButton4.Text = "90";
            this.radioButton4.UseVisualStyleBackColor = true;
            // 
            // radioButton3
            // 
            this.radioButton3.AutoSize = true;
            this.radioButton3.Location = new System.Drawing.Point(95, 15);
            this.radioButton3.Name = "radioButton3";
            this.radioButton3.Size = new System.Drawing.Size(37, 19);
            this.radioButton3.TabIndex = 2;
            this.radioButton3.TabStop = true;
            this.radioButton3.Text = "60";
            this.radioButton3.UseVisualStyleBackColor = true;
            // 
            // radioButton2
            // 
            this.radioButton2.AutoSize = true;
            this.radioButton2.Location = new System.Drawing.Point(52, 15);
            this.radioButton2.Name = "radioButton2";
            this.radioButton2.Size = new System.Drawing.Size(37, 19);
            this.radioButton2.TabIndex = 1;
            this.radioButton2.TabStop = true;
            this.radioButton2.Text = "30";
            this.radioButton2.UseVisualStyleBackColor = true;
            // 
            // radioButton1
            // 
            this.radioButton1.AutoSize = true;
            this.radioButton1.Location = new System.Drawing.Point(6, 15);
            this.radioButton1.Name = "radioButton1";
            this.radioButton1.Size = new System.Drawing.Size(40, 19);
            this.radioButton1.TabIndex = 0;
            this.radioButton1.TabStop = true;
            this.radioButton1.Text = "24 ";
            this.radioButton1.UseVisualStyleBackColor = true;
            // 
            // recordButton
            // 
            this.recordButton.BackColor = System.Drawing.Color.White;
            this.recordButton.Enabled = false;
            this.recordButton.FlatAppearance.BorderSize = 0;
            this.recordButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.recordButton.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.recordButton.Image = ((System.Drawing.Image)(resources.GetObject("recordButton.Image")));
            this.recordButton.Location = new System.Drawing.Point(163, 161);
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
            this.pauseButton.Location = new System.Drawing.Point(205, 161);
            this.pauseButton.Name = "pauseButton";
            this.pauseButton.Size = new System.Drawing.Size(36, 36);
            this.pauseButton.TabIndex = 9;
            this.pauseButton.UseVisualStyleBackColor = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(248, 174);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(0, 15);
            this.label1.TabIndex = 11;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(110, 174);
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
            this.settingsButton.Location = new System.Drawing.Point(357, 96);
            this.settingsButton.Name = "settingsButton";
            this.settingsButton.Size = new System.Drawing.Size(36, 36);
            this.settingsButton.TabIndex = 14;
            this.settingsButton.UseVisualStyleBackColor = false;
            this.settingsButton.Click += new System.EventHandler(this.circularButton3_Click);
            // 
            // micAudioChkBox
            // 
            this.micAudioChkBox.AutoSize = true;
            this.micAudioChkBox.Location = new System.Drawing.Point(232, 144);
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
            this.browseButton.Location = new System.Drawing.Point(357, 57);
            this.browseButton.Name = "browseButton";
            this.browseButton.Size = new System.Drawing.Size(36, 36);
            this.browseButton.TabIndex = 18;
            this.browseButton.UseVisualStyleBackColor = false;
            this.browseButton.Click += new System.EventHandler(this.browseButton_Click);
            // 
            // Form1
            // 
            this.ClientSize = new System.Drawing.Size(400, 202);
            this.Controls.Add(this.browseButton);
            this.Controls.Add(this.micAudioChkBox);
            this.Controls.Add(this.settingsButton);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pauseButton);
            this.Controls.Add(this.recordButton);
            this.Controls.Add(this.groupBox1);
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
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox storePathTextBox;
        private System.Windows.Forms.CheckBox desktopAudioChkBox;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton radioButton7;
        private System.Windows.Forms.RadioButton radioButton6;
        private System.Windows.Forms.RadioButton radioButton5;
        private System.Windows.Forms.RadioButton radioButton4;
        private System.Windows.Forms.RadioButton radioButton3;
        private System.Windows.Forms.RadioButton radioButton2;
        private System.Windows.Forms.RadioButton radioButton1;
        private CircularButton recordButton;
        private CircularButton pauseButton;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Timer progressTimer;
        private System.Windows.Forms.Label label2;
        private CircularButton settingsButton;
        private System.Windows.Forms.CheckBox micAudioChkBox;
        private CircularButton browseButton;
    }
}

