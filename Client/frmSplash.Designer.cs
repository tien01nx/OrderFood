namespace Client
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
            components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmSplash));
            pictureBox1 = new PictureBox();
            labelControl1 = new DevExpress.XtraEditors.LabelControl();
            panel1 = new Panel();
            panelSlide = new Panel();
            timer1 = new System.Windows.Forms.Timer(components);
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // pictureBox1
            // 
            pictureBox1.Anchor = AnchorStyles.Top;
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(539, 211);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(205, 204);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // labelControl1
            // 
            labelControl1.Anchor = AnchorStyles.Top;
            labelControl1.Appearance.Font = new Font("Tahoma", 13.8F, FontStyle.Bold, GraphicsUnit.Point);
            labelControl1.Appearance.Options.UseFont = true;
            labelControl1.Location = new Point(465, 462);
            labelControl1.Name = "labelControl1";
            labelControl1.Size = new Size(353, 28);
            labelControl1.TabIndex = 1;
            labelControl1.Text = "Chào mừng bạn đến với lunch ";
            // 
            // panel1
            // 
            panel1.Anchor = AnchorStyles.Top;
            panel1.BackColor = Color.FromArgb(31, 39, 46);
            panel1.Location = new Point(465, 521);
            panel1.Name = "panel1";
            panel1.Size = new Size(353, 16);
            panel1.TabIndex = 2;
            // 
            // panelSlide
            // 
            panelSlide.Anchor = AnchorStyles.Top;
            panelSlide.BackColor = Color.Yellow;
            panelSlide.Location = new Point(734, 521);
            panelSlide.Name = "panelSlide";
            panelSlide.Size = new Size(84, 16);
            panelSlide.TabIndex = 3;
            // 
            // timer1
            // 
            timer1.Interval = 10;
            timer1.Tick += timer1_Tick;
            // 
            // frmSplash
            // 
            AutoScaleMode = AutoScaleMode.None;
            ClientSize = new Size(1283, 645);
            Controls.Add(panelSlide);
            Controls.Add(panel1);
            Controls.Add(labelControl1);
            Controls.Add(pictureBox1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "frmSplash";
            Text = "frmSplash";
            Load += frmSplash_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox pictureBox1;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private Panel panel1;
        private Panel panelSlide;
        private System.Windows.Forms.Timer timer1;
    }
}