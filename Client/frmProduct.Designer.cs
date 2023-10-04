namespace Client
{
    partial class frmProduct
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
            gridProduct = new DataGridView();
            ((System.ComponentModel.ISupportInitialize)gridProduct).BeginInit();
            SuspendLayout();
            // 
            // gridProduct
            // 
            gridProduct.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            gridProduct.Location = new Point(2, 1);
            gridProduct.Name = "gridProduct";
            gridProduct.RowTemplate.Height = 25;
            gridProduct.Size = new Size(685, 383);
            gridProduct.TabIndex = 0;
            // 
            // frmProduct
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(693, 387);
            Controls.Add(gridProduct);
            Name = "frmProduct";
            Text = "frmProduct";
            ((System.ComponentModel.ISupportInitialize)gridProduct).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private DataGridView gridProduct;
    }
}