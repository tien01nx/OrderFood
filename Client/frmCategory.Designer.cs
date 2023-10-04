namespace Client
{
    partial class frmCategory
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
            gridCategory = new DataGridView();
            ((System.ComponentModel.ISupportInitialize)gridCategory).BeginInit();
            SuspendLayout();
            // 
            // gridCategory
            // 
            gridCategory.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            gridCategory.Dock = DockStyle.Fill;
            gridCategory.Location = new Point(0, 0);
            gridCategory.Margin = new Padding(3, 2, 3, 2);
            gridCategory.Name = "gridCategory";
            gridCategory.RowHeadersWidth = 51;
            gridCategory.RowTemplate.Height = 29;
            gridCategory.Size = new Size(727, 391);
            gridCategory.TabIndex = 0;
            gridCategory.CellContentClick += gridCategory_CellContentClick;
            // 
            // frmCategory
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(727, 391);
            Controls.Add(gridCategory);
            Margin = new Padding(3, 2, 3, 2);
            Name = "frmCategory";
            Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)gridCategory).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private DataGridView gridCategory;
    }
}