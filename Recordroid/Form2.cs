using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Recordroid
{
    public partial class Form2 : MetroFramework.Forms.MetroForm
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            hwEncodeChkBox.Checked = true; //hardware encoding is enabled by default
            mouseCursorChkBox.Checked = true;
        }

        private void audioTrackBar_Scroll(object sender, EventArgs e)
        {
           switch(audioTrackBar.Value)
            {
                case 1:
                    audioBitrateLabel.Text = "96";
                    break;
                case 2:
                    audioBitrateLabel.Text = "128";
                    break;
                case 3:
                    audioBitrateLabel.Text = "160";
                    break;
                case 4:
                    audioBitrateLabel.Text = "192";
                    break;
            }

        }

        private void videoTrackBar_Scroll(object sender, EventArgs e)
        {
            videoBitrateLabel.Text = videoTrackBar.Value.ToString();
        }

        private void doneButton_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void videoQualityTrackBar_Scroll(object sender, EventArgs e)
        {
            videoQualityLabel.Text = videoQualityTrackBar.Value.ToString();
        }
    }
}
