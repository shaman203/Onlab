using EEG_Marker;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace EEG_Marker
{
    public partial class Form1 : Form
    {
        VideoRecorder recorder;
        delegate void setActionImageCallback(Bitmap frame);
        public Form1()
        {
            InitializeComponent();
            recorder = new VideoRecorder(frameHandler);
            recorder.startRecording();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            recorder.startSaving("test.avi");
        }

        public void frameHandler(Bitmap frame)
        {
            if (this.pictureBox1.InvokeRequired)
            {
                setActionImageCallback d = new setActionImageCallback(frameHandler);
                this.Invoke(d, new object[] { frame });
            }
            else
            {
                pictureBox1.Image = frame;
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            recorder.stopSaving();
        }

        private void Form1_FormClosed(object sender, FormClosedEventArgs e)
        {
            recorder.stopRecording();
        }
    }
}
