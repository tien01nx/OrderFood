namespace Client
{
    partial class formdemo
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            Title = new Label();
            profile = new Label();
            imageProduct = new PictureBox();
            btnOrder = new Button();
            ((System.ComponentModel.ISupportInitialize)imageProduct).BeginInit();
            SuspendLayout();
            // 
            // Title
            // 
            Title.AutoSize = true;
            Title.Location = new Point(15, 22);
            Title.Name = "Title";
            Title.Size = new Size(38, 20);
            Title.TabIndex = 0;
            Title.Text = "Title";
            Title.Click += Title_Click;
            // 
            // profile
            // 
            profile.AutoSize = true;
            profile.Location = new Point(15, 61);
            profile.Name = "profile";
            profile.Size = new Size(85, 20);
            profile.TabIndex = 1;
            profile.Text = "Description";
            // 
            // imageProduct
            // 
            imageProduct.Location = new Point(15, 105);
            imageProduct.Name = "imageProduct";
            imageProduct.Size = new Size(179, 169);
            imageProduct.SizeMode = PictureBoxSizeMode.Zoom;
            imageProduct.TabIndex = 2;
            imageProduct.TabStop = false;
            // 
            // btnOrder
            // 
            btnOrder.Location = new Point(232, 61);
            btnOrder.Name = "btnOrder";
            btnOrder.Size = new Size(94, 29);
            btnOrder.TabIndex = 3;
            btnOrder.Text = "Order";
            btnOrder.UseVisualStyleBackColor = true;
            btnOrder.Click += btnOrder_Click;
            // 
            // formdemo
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(btnOrder);
            Controls.Add(imageProduct);
            Controls.Add(profile);
            Controls.Add(Title);
            Name = "formdemo";
            Size = new Size(345, 329);
            Load += formdemo_Load;
            ((System.ComponentModel.ISupportInitialize)imageProduct).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label Title;
        private Label profile;
        private PictureBox imageProduct;
        private Button btnOrder;
    }
}
