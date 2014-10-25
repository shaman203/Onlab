using AForge.Video.DirectShow;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EEGSampler
{
    public partial class WebCamForm : Form
    {
        public WebCamForm()
        {
            InitializeComponent();
        }

        //Create webcam object
        CamRecorder recorder;

        private void Form1_Load(object sender, EventArgs e)
        {
            recorder = new CamRecorder();
            recorder.setPictureBox(pictureBoxVideo);
            //Start recording
            recorder.Start();


        }



        private void Form1_FormClosed(object sender, FormClosedEventArgs e)
        {
            //Stop and free the webcam object if application is closing
            recorder.Stop();
        }

    }
}
