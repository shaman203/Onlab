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
    public partial class CamForm : Form
    {
        delegate void setActionImageCallback(Bitmap frame);
        public CamForm()
        {
            InitializeComponent();
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
    }
}
