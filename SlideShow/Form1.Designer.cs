namespace SlideShow
{
    partial class SlideShow
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SlideShow));
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.thumb1 = new System.Windows.Forms.PictureBox();
            this.thumb2 = new System.Windows.Forms.PictureBox();
            this.thumb3 = new System.Windows.Forms.PictureBox();
            this.thumb4 = new System.Windows.Forms.PictureBox();
            this.thumb5 = new System.Windows.Forms.PictureBox();
            this.picShow = new System.Windows.Forms.PictureBox();
            this.flowLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.thumb1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.thumb2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.thumb3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.thumb4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.thumb5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picShow)).BeginInit();
            this.SuspendLayout();
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Interval = 2000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.Controls.Add(this.thumb1);
            this.flowLayoutPanel1.Controls.Add(this.thumb2);
            this.flowLayoutPanel1.Controls.Add(this.thumb3);
            this.flowLayoutPanel1.Controls.Add(this.thumb4);
            this.flowLayoutPanel1.Controls.Add(this.thumb5);
            this.flowLayoutPanel1.Location = new System.Drawing.Point(262, 459);
            this.flowLayoutPanel1.Margin = new System.Windows.Forms.Padding(4);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(696, 70);
            this.flowLayoutPanel1.TabIndex = 1;
            // 
            // thumb1
            // 
            this.thumb1.Image = ((System.Drawing.Image)(resources.GetObject("thumb1.Image")));
            this.thumb1.Location = new System.Drawing.Point(4, 4);
            this.thumb1.Margin = new System.Windows.Forms.Padding(4);
            this.thumb1.Name = "thumb1";
            this.thumb1.Size = new System.Drawing.Size(120, 62);
            this.thumb1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.thumb1.TabIndex = 0;
            this.thumb1.TabStop = false;
            // 
            // thumb2
            // 
            this.thumb2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.thumb2.Image = ((System.Drawing.Image)(resources.GetObject("thumb2.Image")));
            this.thumb2.Location = new System.Drawing.Point(132, 4);
            this.thumb2.Margin = new System.Windows.Forms.Padding(4);
            this.thumb2.Name = "thumb2";
            this.thumb2.Size = new System.Drawing.Size(133, 62);
            this.thumb2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.thumb2.TabIndex = 1;
            this.thumb2.TabStop = false;
            // 
            // thumb3
            // 
            this.thumb3.Image = ((System.Drawing.Image)(resources.GetObject("thumb3.Image")));
            this.thumb3.Location = new System.Drawing.Point(273, 4);
            this.thumb3.Margin = new System.Windows.Forms.Padding(4);
            this.thumb3.Name = "thumb3";
            this.thumb3.Size = new System.Drawing.Size(133, 62);
            this.thumb3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.thumb3.TabIndex = 2;
            this.thumb3.TabStop = false;
            // 
            // thumb4
            // 
            this.thumb4.Image = ((System.Drawing.Image)(resources.GetObject("thumb4.Image")));
            this.thumb4.Location = new System.Drawing.Point(414, 4);
            this.thumb4.Margin = new System.Windows.Forms.Padding(4);
            this.thumb4.Name = "thumb4";
            this.thumb4.Size = new System.Drawing.Size(133, 62);
            this.thumb4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.thumb4.TabIndex = 3;
            this.thumb4.TabStop = false;
            // 
            // thumb5
            // 
            this.thumb5.Image = ((System.Drawing.Image)(resources.GetObject("thumb5.Image")));
            this.thumb5.Location = new System.Drawing.Point(555, 4);
            this.thumb5.Margin = new System.Windows.Forms.Padding(4);
            this.thumb5.Name = "thumb5";
            this.thumb5.Size = new System.Drawing.Size(133, 62);
            this.thumb5.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.thumb5.TabIndex = 4;
            this.thumb5.TabStop = false;
            // 
            // picShow
            // 
            this.picShow.Image = ((System.Drawing.Image)(resources.GetObject("picShow.Image")));
            this.picShow.Location = new System.Drawing.Point(39, 15);
            this.picShow.Margin = new System.Windows.Forms.Padding(4);
            this.picShow.Name = "picShow";
            this.picShow.Size = new System.Drawing.Size(1120, 436);
            this.picShow.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picShow.TabIndex = 2;
            this.picShow.TabStop = false;
            // 
            // SlideShow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1277, 566);
            this.Controls.Add(this.picShow);
            this.Controls.Add(this.flowLayoutPanel1);
            this.Cursor = System.Windows.Forms.Cursors.SizeAll;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "SlideShow";
            this.Text = "Slide Show";
            this.flowLayoutPanel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.thumb1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.thumb2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.thumb3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.thumb4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.thumb5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picShow)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.PictureBox thumb1;
        private System.Windows.Forms.PictureBox thumb2;
        private System.Windows.Forms.PictureBox thumb3;
        private System.Windows.Forms.PictureBox picShow;
        private System.Windows.Forms.PictureBox thumb4;
        private System.Windows.Forms.PictureBox thumb5;
    }
}

