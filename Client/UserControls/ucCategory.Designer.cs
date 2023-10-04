namespace Client
{
    partial class ucCategory
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
            btnAdd = new DevExpress.XtraEditors.SimpleButton();
            lbl = new DevExpress.XtraEditors.LabelControl();
            txtName = new TextBox();
            btnEdit = new DevExpress.XtraEditors.SimpleButton();
            btnDelete = new DevExpress.XtraEditors.SimpleButton();
            btnSearch = new DevExpress.XtraEditors.SimpleButton();
            SuspendLayout();
            // 
            // btnAdd
            // 
            btnAdd.Location = new Point(35, 61);
            btnAdd.Margin = new Padding(3, 2, 3, 2);
            btnAdd.Name = "btnAdd";
            btnAdd.Size = new Size(52, 16);
            btnAdd.TabIndex = 16;
            btnAdd.Text = "Add";
            btnAdd.Click += btnAdd_Click;
            // 
            // lbl
            // 
            lbl.Appearance.Font = new Font("Tahoma", 7.8F, FontStyle.Bold, GraphicsUnit.Point);
            lbl.Appearance.Options.UseFont = true;
            lbl.Location = new Point(37, 25);
            lbl.Margin = new Padding(3, 2, 3, 2);
            lbl.Name = "lbl";
            lbl.Size = new Size(34, 12);
            lbl.TabIndex = 12;
            lbl.Text = "Name: ";
            // 
            // txtName
            // 
            txtName.Location = new Point(79, 15);
            txtName.Name = "txtName";
            txtName.Size = new Size(111, 21);
            txtName.TabIndex = 17;
            // 
            // btnEdit
            // 
            btnEdit.Location = new Point(138, 61);
            btnEdit.Margin = new Padding(3, 2, 3, 2);
            btnEdit.Name = "btnEdit";
            btnEdit.Size = new Size(52, 16);
            btnEdit.TabIndex = 18;
            btnEdit.Text = "Edit";
            btnEdit.Click += btnEdit_Click;
            // 
            // btnDelete
            // 
            btnDelete.Location = new Point(35, 97);
            btnDelete.Margin = new Padding(3, 2, 3, 2);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(52, 16);
            btnDelete.TabIndex = 19;
            btnDelete.Text = "Delete";
            btnDelete.Click += btnDelete_Click;
            // 
            // btnSearch
            // 
            btnSearch.Location = new Point(138, 97);
            btnSearch.Margin = new Padding(3, 2, 3, 2);
            btnSearch.Name = "btnSearch";
            btnSearch.Size = new Size(52, 16);
            btnSearch.TabIndex = 20;
            btnSearch.Text = "Search";
            btnSearch.Click += btnSearch_Click;
            // 
            // ucCategory
            // 
            AutoScaleDimensions = new SizeF(6F, 13F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(btnSearch);
            Controls.Add(btnDelete);
            Controls.Add(btnEdit);
            Controls.Add(txtName);
            Controls.Add(btnAdd);
            Controls.Add(lbl);
            Name = "ucCategory";
            Size = new Size(247, 129);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private DevExpress.XtraEditors.SimpleButton btnAdd;
        private DevExpress.XtraEditors.LabelControl lbl;
        private TextBox txtName;
        private DevExpress.XtraEditors.SimpleButton btnEdit;
        private DevExpress.XtraEditors.SimpleButton btnDelete;
        private DevExpress.XtraEditors.SimpleButton btnSearch;
    }
}
