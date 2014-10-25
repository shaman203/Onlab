namespace EEGSampler
{
    partial class MainForm
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
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.startCaputerBtn = new System.Windows.Forms.Button();
            this.actionLabel = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.labelCamStatus = new System.Windows.Forms.Label();
            this.labelEmotivStatus = new System.Windows.Forms.Label();
            this.labelActionFile = new System.Windows.Forms.Label();
            this.textBoxSessionName = new System.Windows.Forms.TextBox();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // startCaputerBtn
            // 
            this.startCaputerBtn.Location = new System.Drawing.Point(203, 351);
            this.startCaputerBtn.Name = "startCaputerBtn";
            this.startCaputerBtn.Size = new System.Drawing.Size(75, 23);
            this.startCaputerBtn.TabIndex = 1;
            this.startCaputerBtn.Text = "Start";
            this.startCaputerBtn.UseVisualStyleBackColor = true;
            // 
            // actionLabel
            // 
            this.actionLabel.AutoSize = true;
            this.actionLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 45F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.actionLabel.Location = new System.Drawing.Point(155, 138);
            this.actionLabel.Name = "actionLabel";
            this.actionLabel.Size = new System.Drawing.Size(161, 69);
            this.actionLabel.TabIndex = 2;
            this.actionLabel.Text = "Blink";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(3, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(83, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Webcam Status";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(3, 42);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(72, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Emotiv Status";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(3, 65);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(91, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "Loaded action file";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.labelActionFile);
            this.panel1.Controls.Add(this.labelEmotivStatus);
            this.panel1.Controls.Add(this.labelCamStatus);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Location = new System.Drawing.Point(12, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(200, 100);
            this.panel1.TabIndex = 6;
            // 
            // labelCamStatus
            // 
            this.labelCamStatus.AutoSize = true;
            this.labelCamStatus.Location = new System.Drawing.Point(100, 19);
            this.labelCamStatus.Name = "labelCamStatus";
            this.labelCamStatus.Size = new System.Drawing.Size(21, 13);
            this.labelCamStatus.TabIndex = 6;
            this.labelCamStatus.Text = "Off";
            // 
            // labelEmotivStatus
            // 
            this.labelEmotivStatus.AutoSize = true;
            this.labelEmotivStatus.Location = new System.Drawing.Point(100, 42);
            this.labelEmotivStatus.Name = "labelEmotivStatus";
            this.labelEmotivStatus.Size = new System.Drawing.Size(21, 13);
            this.labelEmotivStatus.TabIndex = 7;
            this.labelEmotivStatus.Text = "Off";
            // 
            // labelActionFile
            // 
            this.labelActionFile.AutoSize = true;
            this.labelActionFile.Location = new System.Drawing.Point(100, 65);
            this.labelActionFile.Name = "labelActionFile";
            this.labelActionFile.Size = new System.Drawing.Size(31, 13);
            this.labelActionFile.TabIndex = 8;
            this.labelActionFile.Text = "none";
            // 
            // textBoxSessionName
            // 
            this.textBoxSessionName.Location = new System.Drawing.Point(167, 322);
            this.textBoxSessionName.Name = "textBoxSessionName";
            this.textBoxSessionName.Size = new System.Drawing.Size(146, 20);
            this.textBoxSessionName.TabIndex = 7;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(483, 386);
            this.Controls.Add(this.textBoxSessionName);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.actionLabel);
            this.Controls.Add(this.startCaputerBtn);
            this.Name = "MainForm";
            this.Text = "EEG Sampler";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.Button startCaputerBtn;
        private System.Windows.Forms.Label actionLabel;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label labelActionFile;
        private System.Windows.Forms.Label labelEmotivStatus;
        private System.Windows.Forms.Label labelCamStatus;
        private System.Windows.Forms.TextBox textBoxSessionName;
    }
}

