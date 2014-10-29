using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Threading;
using System.Windows.Forms;

namespace EEG_Marker
{
    public partial class MainForm : Form, IActionDisplay
    {
        delegate void setActionTextCallback(string text);
        delegate void changeToActiveCallback();
        delegate void doneActionsCallback();
        public MainForm()
        {
            InitializeComponent();
        }

        private void btBrowse_Click(object sender, EventArgs e)
        {
            openFileDialog1.ShowDialog();
        }

        private void openFileDialog1_FileOk(object sender, CancelEventArgs e)
        {
            tBoxActionFile.Text = openFileDialog1.FileName;
        }

        private void btnStart_Click(object sender, EventArgs e)
        {
            btnStart.Enabled = false;
            IMarker marker = new SerialPortMarker(20);
            ActionReader reader = new ActionReader(tBoxActionFile.Text, this,marker);
            Thread oThread = new Thread(new ThreadStart(reader.executeActions));
            oThread.Start();
        }

        public void setActionText(string text)
        {
           
            if (this.lblAction.InvokeRequired)
            {
                setActionTextCallback d = new setActionTextCallback(setActionText);
                this.Invoke(d, new object[] { text });
            }
            else
            {
                lblAction.ForeColor = Color.Red;
                lblAction.Text = text;
            }
        }

        public void changeToActive()
        {
           
            if (this.lblAction.InvokeRequired)
            {
                changeToActiveCallback d = new changeToActiveCallback(changeToActive);
                this.Invoke(d);
            }
            else
            {
                lblAction.ForeColor = Color.Green;
            }
        }


        public void doneActions()
        {
            if (this.btnStart.InvokeRequired)
            {
                doneActionsCallback d = new doneActionsCallback(doneActions);
                this.Invoke(d);
            }
            else
            {
                btnStart.Enabled = true;
            }
        }
    }
}
