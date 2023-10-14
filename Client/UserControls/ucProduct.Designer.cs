namespace Client.UserControls
{
    partial class ucProduct
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ucProduct));
            DevExpress.XtraGrid.GridLevelNode gridLevelNode1 = new DevExpress.XtraGrid.GridLevelNode();
            openFileDialog = new OpenFileDialog();
            toolStripButton5 = new ToolStripButton();
            toolStripButton4 = new ToolStripButton();
            toolStripButton3 = new ToolStripButton();
            toolStripButton2 = new ToolStripButton();
            pictureBox1 = new PictureBox();
            label8 = new Label();
            cboCategoryName = new DevExpress.XtraEditors.ComboBoxEdit();
            label7 = new Label();
            spinEdit1 = new DevExpress.XtraEditors.SpinEdit();
            label5 = new Label();
            toolStripButton1 = new ToolStripButton();
            toolStrip1 = new ToolStrip();
            closeucProduct = new ToolStripButton();
            label4 = new Label();
            memoEdit1 = new DevExpress.XtraEditors.MemoEdit();
            label3 = new Label();
            label1 = new Label();
            groupControl2 = new DevExpress.XtraEditors.GroupControl();
            btnRestaurant = new DevExpress.XtraEditors.ButtonEdit();
            textEdit1 = new DevExpress.XtraEditors.TextEdit();
            girdProduct = new DevExpress.XtraGrid.Views.Grid.GridView();
            Id = new DevExpress.XtraGrid.Columns.GridColumn();
            ProductName = new DevExpress.XtraGrid.Columns.GridColumn();
            Description = new DevExpress.XtraGrid.Columns.GridColumn();
            Images = new DevExpress.XtraGrid.Columns.GridColumn();
            PictureEdit = new DevExpress.XtraEditors.Repository.RepositoryItemPictureEdit();
            Price = new DevExpress.XtraGrid.Columns.GridColumn();
            gridData = new DevExpress.XtraGrid.GridControl();
            groupControl3 = new DevExpress.XtraEditors.GroupControl();
            groupControl1 = new DevExpress.XtraEditors.GroupControl();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)cboCategoryName.Properties).BeginInit();
            ((System.ComponentModel.ISupportInitialize)spinEdit1.Properties).BeginInit();
            toolStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)memoEdit1.Properties).BeginInit();
            ((System.ComponentModel.ISupportInitialize)groupControl2).BeginInit();
            groupControl2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)btnRestaurant.Properties).BeginInit();
            ((System.ComponentModel.ISupportInitialize)textEdit1.Properties).BeginInit();
            ((System.ComponentModel.ISupportInitialize)girdProduct).BeginInit();
            ((System.ComponentModel.ISupportInitialize)PictureEdit).BeginInit();
            ((System.ComponentModel.ISupportInitialize)gridData).BeginInit();
            ((System.ComponentModel.ISupportInitialize)groupControl3).BeginInit();
            groupControl3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)groupControl1).BeginInit();
            groupControl1.SuspendLayout();
            SuspendLayout();
            // 
            // openFileDialog
            // 
            openFileDialog.FileName = "openFileDialog1";
            // 
            // toolStripButton5
            // 
            toolStripButton5.Image = (Image)resources.GetObject("toolStripButton5.Image");
            toolStripButton5.ImageTransparentColor = Color.Magenta;
            toolStripButton5.Name = "toolStripButton5";
            toolStripButton5.Size = new Size(126, 24);
            toolStripButton5.Text = "Xóa hết sản phẩm";
            // 
            // toolStripButton4
            // 
            toolStripButton4.Image = (Image)resources.GetObject("toolStripButton4.Image");
            toolStripButton4.ImageTransparentColor = Color.Magenta;
            toolStripButton4.Name = "toolStripButton4";
            toolStripButton4.Size = new Size(135, 24);
            toolStripButton4.Text = "Tìm kiếm sản phẩm";
            // 
            // toolStripButton3
            // 
            toolStripButton3.Image = (Image)resources.GetObject("toolStripButton3.Image");
            toolStripButton3.ImageTransparentColor = Color.Magenta;
            toolStripButton3.Name = "toolStripButton3";
            toolStripButton3.Size = new Size(106, 24);
            toolStripButton3.Text = "Xóa sản phẩm";
            // 
            // toolStripButton2
            // 
            toolStripButton2.Image = (Image)resources.GetObject("toolStripButton2.Image");
            toolStripButton2.ImageTransparentColor = Color.Magenta;
            toolStripButton2.Name = "toolStripButton2";
            toolStripButton2.Size = new Size(105, 24);
            toolStripButton2.Text = "Sửa sản phẩm";
            // 
            // pictureBox1
            // 
            pictureBox1.BorderStyle = BorderStyle.FixedSingle;
            pictureBox1.Location = new Point(7, 308);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(299, 135);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 15;
            pictureBox1.TabStop = false;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Tahoma", 8.25F, FontStyle.Bold, GraphicsUnit.Point);
            label8.Location = new Point(5, 291);
            label8.Name = "label8";
            label8.Size = new Size(111, 13);
            label8.TabIndex = 14;
            label8.Text = "Hình ảnh minh họa";
            // 
            // cboCategoryName
            // 
            cboCategoryName.Location = new Point(5, 267);
            cboCategoryName.Margin = new Padding(3, 2, 3, 2);
            cboCategoryName.Name = "cboCategoryName";
            cboCategoryName.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] { new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo) });
            cboCategoryName.Size = new Size(302, 20);
            cboCategoryName.TabIndex = 11;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Tahoma", 8.25F, FontStyle.Bold, GraphicsUnit.Point);
            label7.Location = new Point(4, 249);
            label7.Name = "label7";
            label7.Size = new Size(88, 13);
            label7.TabIndex = 10;
            label7.Text = "Loại sản phẩm";
            // 
            // spinEdit1
            // 
            spinEdit1.EditValue = new decimal(new int[] { 0, 0, 0, 0 });
            spinEdit1.Location = new Point(47, 109);
            spinEdit1.Name = "spinEdit1";
            spinEdit1.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] { new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo) });
            spinEdit1.Size = new Size(72, 20);
            spinEdit1.TabIndex = 7;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Tahoma", 8.25F, FontStyle.Bold, GraphicsUnit.Point);
            label5.ForeColor = Color.Red;
            label5.Location = new Point(5, 112);
            label5.Name = "label5";
            label5.Size = new Size(35, 13);
            label5.TabIndex = 6;
            label5.Text = "Price";
            // 
            // toolStripButton1
            // 
            toolStripButton1.Image = (Image)resources.GetObject("toolStripButton1.Image");
            toolStripButton1.ImageTransparentColor = Color.Magenta;
            toolStripButton1.Name = "toolStripButton1";
            toolStripButton1.Size = new Size(116, 24);
            toolStripButton1.Text = "Thêm sản phẩm";
            // 
            // toolStrip1
            // 
            toolStrip1.ImageScalingSize = new Size(20, 20);
            toolStrip1.Items.AddRange(new ToolStripItem[] { toolStripButton1, toolStripButton2, toolStripButton3, toolStripButton4, toolStripButton5, closeucProduct });
            toolStrip1.Location = new Point(2, 23);
            toolStrip1.Name = "toolStrip1";
            toolStrip1.Size = new Size(997, 27);
            toolStrip1.TabIndex = 0;
            toolStrip1.Text = "toolStrip1";
            // 
            // closeucProduct
            // 
            closeucProduct.Alignment = ToolStripItemAlignment.Right;
            closeucProduct.DisplayStyle = ToolStripItemDisplayStyle.Image;
            closeucProduct.Image = (Image)resources.GetObject("closeucProduct.Image");
            closeucProduct.ImageTransparentColor = Color.Magenta;
            closeucProduct.Name = "closeucProduct";
            closeucProduct.RightToLeft = RightToLeft.No;
            closeucProduct.Size = new Size(24, 24);
            closeucProduct.Text = "toolStripButton6";
            closeucProduct.Click += closeucProduct_Click;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Tahoma", 8.25F, FontStyle.Bold, GraphicsUnit.Point);
            label4.Location = new Point(5, 133);
            label4.Name = "label4";
            label4.Size = new Size(97, 13);
            label4.TabIndex = 5;
            label4.Text = "Mô tả sản phẩm";
            // 
            // memoEdit1
            // 
            memoEdit1.Location = new Point(4, 149);
            memoEdit1.Name = "memoEdit1";
            memoEdit1.Size = new Size(303, 96);
            memoEdit1.TabIndex = 4;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Tahoma", 8.25F, FontStyle.Bold, GraphicsUnit.Point);
            label3.Location = new Point(4, 69);
            label3.Name = "label3";
            label3.Size = new Size(86, 13);
            label3.TabIndex = 2;
            label3.Text = "Tên sản phẩm";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Tahoma", 8.25F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(4, 26);
            label1.Name = "label1";
            label1.Size = new Size(59, 13);
            label1.TabIndex = 0;
            label1.Text = "Nhà hàng";
            // 
            // groupControl2
            // 
            groupControl2.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Simple;
            groupControl2.Controls.Add(btnRestaurant);
            groupControl2.Controls.Add(pictureBox1);
            groupControl2.Controls.Add(label8);
            groupControl2.Controls.Add(cboCategoryName);
            groupControl2.Controls.Add(label7);
            groupControl2.Controls.Add(spinEdit1);
            groupControl2.Controls.Add(label5);
            groupControl2.Controls.Add(label4);
            groupControl2.Controls.Add(memoEdit1);
            groupControl2.Controls.Add(textEdit1);
            groupControl2.Controls.Add(label3);
            groupControl2.Controls.Add(label1);
            groupControl2.Dock = DockStyle.Left;
            groupControl2.Location = new Point(2, 50);
            groupControl2.Margin = new Padding(3, 2, 3, 2);
            groupControl2.Name = "groupControl2";
            groupControl2.Size = new Size(313, 535);
            groupControl2.TabIndex = 2;
            groupControl2.Text = "Thông tin sản phẩm";
            // 
            // btnRestaurant
            // 
            btnRestaurant.EditValue = "Hihi";
            btnRestaurant.Location = new Point(4, 45);
            btnRestaurant.Name = "btnRestaurant";
            btnRestaurant.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] { new DevExpress.XtraEditors.Controls.EditorButton() });
            btnRestaurant.Size = new Size(302, 20);
            btnRestaurant.TabIndex = 18;
            btnRestaurant.EditValueChanged += btnRestaurant_EditValueChanged;
            btnRestaurant.Click += btnRestaurant_Click;
            // 
            // textEdit1
            // 
            textEdit1.Location = new Point(7, 86);
            textEdit1.Name = "textEdit1";
            textEdit1.Size = new Size(300, 20);
            textEdit1.TabIndex = 3;
            // 
            // girdProduct
            // 
            girdProduct.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] { Id, ProductName, Description, Images, Price });
            girdProduct.DetailHeight = 284;
            girdProduct.GridControl = gridData;
            girdProduct.Name = "girdProduct";
            girdProduct.OptionsBehavior.Editable = false;
            girdProduct.OptionsBehavior.ReadOnly = true;
            girdProduct.OptionsEditForm.PopupEditFormWidth = 588;
            girdProduct.OptionsView.RowAutoHeight = true;
            girdProduct.OptionsView.ShowGroupPanel = false;
            girdProduct.OptionsView.ShowIndicator = false;
            // 
            // Id
            // 
            Id.Caption = "Id";
            Id.FieldName = "Id";
            Id.Name = "Id";
            Id.Visible = true;
            Id.VisibleIndex = 4;
            // 
            // ProductName
            // 
            ProductName.Caption = "Tên sản phẩm";
            ProductName.FieldName = "ProductName";
            ProductName.Name = "ProductName";
            ProductName.Visible = true;
            ProductName.VisibleIndex = 0;
            // 
            // Description
            // 
            Description.Caption = "Mô tả";
            Description.FieldName = "Description";
            Description.Name = "Description";
            Description.Visible = true;
            Description.VisibleIndex = 1;
            // 
            // Images
            // 
            Images.Caption = "Hình ảnh";
            Images.ColumnEdit = PictureEdit;
            Images.FieldName = "ImageProduct";
            Images.MaxWidth = 140;
            Images.Name = "Images";
            Images.Visible = true;
            Images.VisibleIndex = 2;
            Images.Width = 30;
            // 
            // PictureEdit
            // 
            PictureEdit.Name = "PictureEdit";
            PictureEdit.SizeMode = DevExpress.XtraEditors.Controls.PictureSizeMode.Zoom;
            // 
            // Price
            // 
            Price.Caption = "Giá bán";
            Price.FieldName = "Price";
            Price.Name = "Price";
            Price.Visible = true;
            Price.VisibleIndex = 3;
            // 
            // gridData
            // 
            gridData.Dock = DockStyle.Fill;
            gridData.EmbeddedNavigator.Margin = new Padding(3, 2, 3, 2);
            gridLevelNode1.RelationName = "Level1";
            gridData.LevelTree.Nodes.AddRange(new DevExpress.XtraGrid.GridLevelNode[] { gridLevelNode1 });
            gridData.Location = new Point(2, 23);
            gridData.MainView = girdProduct;
            gridData.Margin = new Padding(3, 2, 3, 2);
            gridData.Name = "gridData";
            gridData.RepositoryItems.AddRange(new DevExpress.XtraEditors.Repository.RepositoryItem[] { PictureEdit });
            gridData.Size = new Size(680, 510);
            gridData.TabIndex = 2;
            gridData.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] { girdProduct });
            // 
            // groupControl3
            // 
            groupControl3.Controls.Add(gridData);
            groupControl3.Dock = DockStyle.Fill;
            groupControl3.Location = new Point(315, 50);
            groupControl3.Margin = new Padding(3, 2, 3, 2);
            groupControl3.Name = "groupControl3";
            groupControl3.Size = new Size(684, 535);
            groupControl3.TabIndex = 3;
            groupControl3.Text = "Danh sách sản phẩm";
            // 
            // groupControl1
            // 
            groupControl1.Controls.Add(groupControl3);
            groupControl1.Controls.Add(groupControl2);
            groupControl1.Controls.Add(toolStrip1);
            groupControl1.Dock = DockStyle.Fill;
            groupControl1.Location = new Point(0, 0);
            groupControl1.Name = "groupControl1";
            groupControl1.Size = new Size(1001, 587);
            groupControl1.TabIndex = 1;
            groupControl1.Text = "DANH SÁCH CHỨC NĂNG PRODUCT";
            // 
            // ucProduct
            // 
            AutoScaleDimensions = new SizeF(6F, 13F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(groupControl1);
            Margin = new Padding(3, 2, 3, 2);
            Name = "ucProduct";
            Size = new Size(1001, 587);
            Load += ucProduct_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)cboCategoryName.Properties).EndInit();
            ((System.ComponentModel.ISupportInitialize)spinEdit1.Properties).EndInit();
            toolStrip1.ResumeLayout(false);
            toolStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)memoEdit1.Properties).EndInit();
            ((System.ComponentModel.ISupportInitialize)groupControl2).EndInit();
            groupControl2.ResumeLayout(false);
            groupControl2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)btnRestaurant.Properties).EndInit();
            ((System.ComponentModel.ISupportInitialize)textEdit1.Properties).EndInit();
            ((System.ComponentModel.ISupportInitialize)girdProduct).EndInit();
            ((System.ComponentModel.ISupportInitialize)PictureEdit).EndInit();
            ((System.ComponentModel.ISupportInitialize)gridData).EndInit();
            ((System.ComponentModel.ISupportInitialize)groupControl3).EndInit();
            groupControl3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)groupControl1).EndInit();
            groupControl1.ResumeLayout(false);
            groupControl1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private OpenFileDialog openFileDialog;
        private ToolStripButton toolStripButton5;
        private ToolStripButton toolStripButton4;
        private ToolStripButton toolStripButton3;
        private ToolStripButton toolStripButton2;
        private PictureBox pictureBox1;
        private Label label8;
        private DevExpress.XtraEditors.ComboBoxEdit cboCategoryName;
        private Label label7;
        private DevExpress.XtraEditors.SpinEdit spinEdit1;
        private Label label5;
        private ToolStripButton toolStripButton1;
        private ToolStrip toolStrip1;
        private ToolStripButton closeucProduct;
        private Label label4;
        private DevExpress.XtraEditors.MemoEdit memoEdit1;
        private Label label3;
        private Label label1;
        private DevExpress.XtraEditors.GroupControl groupControl2;
        private DevExpress.XtraEditors.TextEdit textEdit1;
        private DevExpress.XtraGrid.Views.Grid.GridView girdProduct;
        private DevExpress.XtraGrid.GridControl gridData;
        private DevExpress.XtraEditors.GroupControl groupControl3;
        private DevExpress.XtraEditors.GroupControl groupControl1;
        private DevExpress.XtraGrid.Columns.GridColumn Id;
        private DevExpress.XtraGrid.Columns.GridColumn ProductName;
        private DevExpress.XtraGrid.Columns.GridColumn Description;
        private DevExpress.XtraGrid.Columns.GridColumn Images;
        private DevExpress.XtraEditors.Repository.RepositoryItemPictureEdit PictureEdit;
        private DevExpress.XtraGrid.Columns.GridColumn Price;
        private DevExpress.XtraEditors.ButtonEdit btnRestaurant;
    }
}
