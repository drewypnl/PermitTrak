namespace PermitTrak
{
    partial class frmSplash
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmSplash));
            this.PicVIMain = new System.Windows.Forms.PictureBox();
            this.picRobot = new System.Windows.Forms.PictureBox();
            this.picHelixorter = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.PicVIMain)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picRobot)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picHelixorter)).BeginInit();
            this.SuspendLayout();
            // 
            // PicVIMain
            // 
            this.PicVIMain.Cursor = System.Windows.Forms.Cursors.Default;
            this.PicVIMain.Image = ((System.Drawing.Image)(resources.GetObject("PicVIMain.Image")));
            this.PicVIMain.InitialImage = ((System.Drawing.Image)(resources.GetObject("PicVIMain.InitialImage")));
            this.PicVIMain.Location = new System.Drawing.Point(12, 12);
            this.PicVIMain.Name = "PicVIMain";
            this.PicVIMain.Size = new System.Drawing.Size(431, 58);
            this.PicVIMain.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.PicVIMain.TabIndex = 0;
            this.PicVIMain.TabStop = false;
            // 
            // picRobot
            // 
            this.picRobot.Cursor = System.Windows.Forms.Cursors.Default;
            this.picRobot.Image = ((System.Drawing.Image)(resources.GetObject("picRobot.Image")));
            this.picRobot.InitialImage = ((System.Drawing.Image)(resources.GetObject("picRobot.InitialImage")));
            this.picRobot.Location = new System.Drawing.Point(12, 76);
            this.picRobot.Name = "picRobot";
            this.picRobot.Size = new System.Drawing.Size(200, 125);
            this.picRobot.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picRobot.TabIndex = 1;
            this.picRobot.TabStop = false;
            // 
            // picHelixorter
            // 
            this.picHelixorter.Cursor = System.Windows.Forms.Cursors.Default;
            this.picHelixorter.Image = ((System.Drawing.Image)(resources.GetObject("picHelixorter.Image")));
            this.picHelixorter.InitialImage = ((System.Drawing.Image)(resources.GetObject("picHelixorter.InitialImage")));
            this.picHelixorter.Location = new System.Drawing.Point(250, 76);
            this.picHelixorter.Name = "picHelixorter";
            this.picHelixorter.Size = new System.Drawing.Size(193, 125);
            this.picHelixorter.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picHelixorter.TabIndex = 2;
            this.picHelixorter.TabStop = false;
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 213);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(431, 20);
            this.label1.TabIndex = 3;
            this.label1.Text = "Copyright 2013: Vanderlande Industries, T3IB Heathrow";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label2
            // 
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(9, 242);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(434, 17);
            this.label2.TabIndex = 4;
            this.label2.Text = "For Information Please Contact steve.drew@vanderlande.com";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Interval = 5000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // frmSplash
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(456, 273);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.picHelixorter);
            this.Controls.Add(this.picRobot);
            this.Controls.Add(this.PicVIMain);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmSplash";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "PermitTrak";
            ((System.ComponentModel.ISupportInitialize)(this.PicVIMain)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picRobot)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picHelixorter)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox PicVIMain;
        private System.Windows.Forms.PictureBox picRobot;
        private System.Windows.Forms.PictureBox picHelixorter;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Timer timer1;
    }
}

