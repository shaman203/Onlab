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
    public partial class MainForm : Form
    {
        WebCamForm webCamForm;
        public MainForm()
        {
            InitializeComponent();
            //webCamForm = new WebCamForm();
            //webCamForm.Show();
        }
    }
}
