namespace Examples
{
    partial class Form1
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
            this.saveDialog = new System.Windows.Forms.SaveFileDialog();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnStereo = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.txtTouchTone = new System.Windows.Forms.TextBox();
            this.btnTouchTones = new System.Windows.Forms.Button();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.btnMinuetInG = new System.Windows.Forms.Button();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.btnPushIt = new System.Windows.Forms.Button();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.btnMemoryStream = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.groupBox5.SuspendLayout();
            this.SuspendLayout();
            // 
            // saveDialog
            // 
            this.saveDialog.DefaultExt = "wav";
            this.saveDialog.Filter = "Wave Files (*.wav)|*.wav|All Files (*.*)|*.*";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnStereo);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(176, 55);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Stereo Example";
            // 
            // btnStereo
            // 
            this.btnStereo.Location = new System.Drawing.Point(7, 20);
            this.btnStereo.Name = "btnStereo";
            this.btnStereo.Size = new System.Drawing.Size(159, 23);
            this.btnStereo.TabIndex = 0;
            this.btnStereo.Text = "Generate Left-To-Right Fade";
            this.btnStereo.UseVisualStyleBackColor = true;
            this.btnStereo.Click += new System.EventHandler(this.btnStereo_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.txtTouchTone);
            this.groupBox2.Controls.Add(this.btnTouchTones);
            this.groupBox2.Location = new System.Drawing.Point(12, 73);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(176, 79);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Touch Tone Example";
            // 
            // txtTouchTone
            // 
            this.txtTouchTone.Location = new System.Drawing.Point(7, 19);
            this.txtTouchTone.Name = "txtTouchTone";
            this.txtTouchTone.Size = new System.Drawing.Size(159, 20);
            this.txtTouchTone.TabIndex = 1;
            this.txtTouchTone.Text = "1-800-MATTRES";
            // 
            // btnTouchTones
            // 
            this.btnTouchTones.Location = new System.Drawing.Point(7, 45);
            this.btnTouchTones.Name = "btnTouchTones";
            this.btnTouchTones.Size = new System.Drawing.Size(159, 23);
            this.btnTouchTones.TabIndex = 0;
            this.btnTouchTones.Text = "Generate Touch Tones";
            this.btnTouchTones.UseVisualStyleBackColor = true;
            this.btnTouchTones.Click += new System.EventHandler(this.btnTouchTones_Click);
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.btnMinuetInG);
            this.groupBox3.Location = new System.Drawing.Point(13, 158);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(176, 55);
            this.groupBox3.TabIndex = 2;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Minuet In G";
            // 
            // btnMinuetInG
            // 
            this.btnMinuetInG.Location = new System.Drawing.Point(7, 20);
            this.btnMinuetInG.Name = "btnMinuetInG";
            this.btnMinuetInG.Size = new System.Drawing.Size(159, 23);
            this.btnMinuetInG.TabIndex = 0;
            this.btnMinuetInG.Text = "Generate Minuet in G";
            this.btnMinuetInG.UseVisualStyleBackColor = true;
            this.btnMinuetInG.Click += new System.EventHandler(this.btnMinuetInG_Click);
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.btnPushIt);
            this.groupBox4.Location = new System.Drawing.Point(13, 219);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(176, 55);
            this.groupBox4.TabIndex = 3;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Push It";
            // 
            // btnPushIt
            // 
            this.btnPushIt.Location = new System.Drawing.Point(7, 20);
            this.btnPushIt.Name = "btnPushIt";
            this.btnPushIt.Size = new System.Drawing.Size(159, 23);
            this.btnPushIt.TabIndex = 0;
            this.btnPushIt.Text = "Generate Push It";
            this.btnPushIt.UseVisualStyleBackColor = true;
            this.btnPushIt.Click += new System.EventHandler(this.btnPushIt_Click);
            // 
            // groupBox5
            // 
            this.groupBox5.Controls.Add(this.btnMemoryStream);
            this.groupBox5.Location = new System.Drawing.Point(13, 280);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Size = new System.Drawing.Size(176, 55);
            this.groupBox5.TabIndex = 4;
            this.groupBox5.TabStop = false;
            this.groupBox5.Text = "Memory Stream Example";
            // 
            // btnMemoryStream
            // 
            this.btnMemoryStream.Location = new System.Drawing.Point(7, 20);
            this.btnMemoryStream.Name = "btnMemoryStream";
            this.btnMemoryStream.Size = new System.Drawing.Size(159, 23);
            this.btnMemoryStream.TabIndex = 0;
            this.btnMemoryStream.Text = "Play 3 Stooges Song";
            this.btnMemoryStream.UseVisualStyleBackColor = true;
            this.btnMemoryStream.Click += new System.EventHandler(this.btnMemoryStream_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(201, 349);
            this.Controls.Add(this.groupBox5);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "Form1";
            this.Text = "Wave File Examples";
            this.groupBox1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox4.ResumeLayout(false);
            this.groupBox5.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.SaveFileDialog saveDialog;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnStereo;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TextBox txtTouchTone;
        private System.Windows.Forms.Button btnTouchTones;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Button btnMinuetInG;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.Button btnPushIt;
        private System.Windows.Forms.GroupBox groupBox5;
        private System.Windows.Forms.Button btnMemoryStream;
    }
}

