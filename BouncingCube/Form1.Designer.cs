namespace BouncingCube
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
            this.components = new System.ComponentModel.Container();
            this.outputPic = new System.Windows.Forms.PictureBox();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.outputPic)).BeginInit();
            this.SuspendLayout();
            // 
            // outputPic
            // 
            this.outputPic.Location = new System.Drawing.Point(1, 2);
            this.outputPic.Name = "outputPic";
            this.outputPic.Size = new System.Drawing.Size(799, 446);
            this.outputPic.TabIndex = 0;
            this.outputPic.TabStop = false;
            this.outputPic.Click += new System.EventHandler(this.outputPic_Click);
            this.outputPic.Paint += new System.Windows.Forms.PaintEventHandler(this.outputPic_Paint);
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Interval = 25;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.outputPic);
            this.Name = "Form1";
            this.Text = "BouncingBox";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.outputPic)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox outputPic;
        private System.Windows.Forms.Timer timer1;
    }
}

