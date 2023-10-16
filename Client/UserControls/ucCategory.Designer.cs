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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ucCategory));
            groupControl1 = new DevExpress.XtraEditors.GroupControl();
            RestaurantId = new DevExpress.XtraEditors.LabelControl();
            Id = new DevExpress.XtraEditors.LabelControl();
            txtCategoryName = new DevExpress.XtraEditors.TextEdit();
            mdDescriptions = new DevExpress.XtraEditors.MemoEdit();
            btnRestaurantName = new DevExpress.XtraEditors.ButtonEdit();
            labelControl3 = new DevExpress.XtraEditors.LabelControl();
            labelControl2 = new DevExpress.XtraEditors.LabelControl();
            labelControl1 = new DevExpress.XtraEditors.LabelControl();
            toolStrip1 = new ToolStrip();
            SubbtnAdd = new ToolStripButton();
            SubBtnClose = new ToolStripButton();
            SubBtnClear = new ToolStripButton();
            ((System.ComponentModel.ISupportInitialize)groupControl1).BeginInit();
            groupControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)txtCategoryName.Properties).BeginInit();
            ((System.ComponentModel.ISupportInitialize)mdDescriptions.Properties).BeginInit();
            ((System.ComponentModel.ISupportInitialize)btnRestaurantName.Properties).BeginInit();
            toolStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // groupControl1
            // 
            groupControl1.Controls.Add(RestaurantId);
            groupControl1.Controls.Add(Id);
            groupControl1.Controls.Add(txtCategoryName);
            groupControl1.Controls.Add(mdDescriptions);
            groupControl1.Controls.Add(btnRestaurantName);
            groupControl1.Controls.Add(labelControl3);
            groupControl1.Controls.Add(labelControl2);
            groupControl1.Controls.Add(labelControl1);
            groupControl1.Controls.Add(toolStrip1);
            groupControl1.Dock = DockStyle.Fill;
            groupControl1.Location = new Point(0, 0);
            groupControl1.Name = "groupControl1";
            groupControl1.Size = new Size(1001, 587);
            groupControl1.TabIndex = 0;
            groupControl1.Text = "CHỨC NĂNG DANH MỤC";
            // 
            // RestaurantId
            // 
            RestaurantId.Location = new Point(325, 405);
            RestaurantId.Name = "RestaurantId";
            RestaurantId.Size = new Size(0, 13);
            RestaurantId.TabIndex = 13;
            // 
            // Id
            // 
            Id.Location = new Point(336, 386);
            Id.Name = "Id";
            Id.Size = new Size(0, 13);
            Id.TabIndex = 12;
            // 
            // txtCategoryName
            // 
            txtCategoryName.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            txtCategoryName.Location = new Point(445, 242);
            txtCategoryName.Name = "txtCategoryName";
            txtCategoryName.Size = new Size(220, 20);
            txtCategoryName.TabIndex = 11;
            // 
            // mdDescriptions
            // 
            mdDescriptions.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            mdDescriptions.Location = new Point(445, 289);
            mdDescriptions.Name = "mdDescriptions";
            mdDescriptions.Size = new Size(220, 96);
            mdDescriptions.TabIndex = 10;
            // 
            // btnRestaurantName
            // 
            btnRestaurantName.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            btnRestaurantName.Location = new Point(445, 201);
            btnRestaurantName.Name = "btnRestaurantName";
            btnRestaurantName.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] { new DevExpress.XtraEditors.Controls.EditorButton() });
            btnRestaurantName.Size = new Size(220, 20);
            btnRestaurantName.TabIndex = 9;
            btnRestaurantName.Click += btnRestaurantName_Click;
            // 
            // labelControl3
            // 
            labelControl3.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            labelControl3.Appearance.Font = new Font("Tahoma", 8.25F, FontStyle.Bold, GraphicsUnit.Point);
            labelControl3.Appearance.Options.UseFont = true;
            labelControl3.Location = new Point(337, 291);
            labelControl3.Name = "labelControl3";
            labelControl3.Size = new Size(38, 13);
            labelControl3.TabIndex = 8;
            labelControl3.Text = "Mô tả: ";
            // 
            // labelControl2
            // 
            labelControl2.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            labelControl2.Appearance.Font = new Font("Tahoma", 8.25F, FontStyle.Bold, GraphicsUnit.Point);
            labelControl2.Appearance.Options.UseFont = true;
            labelControl2.Location = new Point(336, 249);
            labelControl2.Name = "labelControl2";
            labelControl2.Size = new Size(85, 13);
            labelControl2.TabIndex = 7;
            labelControl2.Text = "Tên danh mục: ";
            // 
            // labelControl1
            // 
            labelControl1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            labelControl1.Appearance.Font = new Font("Tahoma", 8.25F, FontStyle.Bold, GraphicsUnit.Point);
            labelControl1.Appearance.Options.UseFont = true;
            labelControl1.Location = new Point(337, 208);
            labelControl1.Name = "labelControl1";
            labelControl1.Size = new Size(82, 13);
            labelControl1.TabIndex = 6;
            labelControl1.Text = "Tên nhà hàng: ";
            // 
            // toolStrip1
            // 
            toolStrip1.Items.AddRange(new ToolStripItem[] { SubbtnAdd, SubBtnClose, SubBtnClear });
            toolStrip1.Location = new Point(2, 23);
            toolStrip1.Name = "toolStrip1";
            toolStrip1.Size = new Size(997, 25);
            toolStrip1.TabIndex = 0;
            toolStrip1.Text = "toolStrip1";
            // 
            // SubbtnAdd
            // 
            SubbtnAdd.Image = (Image)resources.GetObject("SubbtnAdd.Image");
            SubbtnAdd.ImageTransparentColor = Color.Magenta;
            SubbtnAdd.Name = "SubbtnAdd";
            SubbtnAdd.Size = new Size(47, 22);
            SubbtnAdd.Text = "Lưu";
            SubbtnAdd.Click += SubbtnAdd_Click;
            // 
            // SubBtnClose
            // 
            SubBtnClose.Alignment = ToolStripItemAlignment.Right;
            SubBtnClose.Image = (Image)resources.GetObject("SubBtnClose.Image");
            SubBtnClose.ImageTransparentColor = Color.Magenta;
            SubBtnClose.Name = "SubBtnClose";
            SubBtnClose.Size = new Size(56, 22);
            SubBtnClose.Text = "Đóng";
            SubBtnClose.TextAlign = ContentAlignment.MiddleLeft;
            SubBtnClose.Click += SubBtnClose_Click;
            // 
            // SubBtnClear
            // 
            SubBtnClear.Image = (Image)resources.GetObject("SubBtnClear.Image");
            SubBtnClear.ImageTransparentColor = Color.Magenta;
            SubBtnClear.Name = "SubBtnClear";
            SubBtnClear.Size = new Size(74, 22);
            SubBtnClear.Text = "Làm mới";
            SubBtnClear.Click += SubBtnClear_Click;
            // 
            // ucCategory
            // 
            AutoScaleDimensions = new SizeF(6F, 13F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(groupControl1);
            Name = "ucCategory";
            Size = new Size(1001, 587);
            ((System.ComponentModel.ISupportInitialize)groupControl1).EndInit();
            groupControl1.ResumeLayout(false);
            groupControl1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)txtCategoryName.Properties).EndInit();
            ((System.ComponentModel.ISupportInitialize)mdDescriptions.Properties).EndInit();
            ((System.ComponentModel.ISupportInitialize)btnRestaurantName.Properties).EndInit();
            toolStrip1.ResumeLayout(false);
            toolStrip1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private DevExpress.XtraEditors.GroupControl groupControl1;
        private DevExpress.XtraEditors.TextEdit txtCategoryName;
        private DevExpress.XtraEditors.MemoEdit mdDescriptions;
        private DevExpress.XtraEditors.ButtonEdit btnRestaurantName;
        private DevExpress.XtraEditors.LabelControl labelControl3;
        private DevExpress.XtraEditors.LabelControl labelControl2;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private ToolStrip toolStrip1;
        private ToolStripButton SubbtnAdd;
        private ToolStripButton SubBtnClose;
        private ToolStripButton SubBtnClear;
        private DevExpress.XtraEditors.LabelControl Id;
        private DevExpress.XtraEditors.LabelControl RestaurantId;
    }
}
