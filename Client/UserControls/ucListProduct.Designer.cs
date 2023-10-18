namespace Client.UserControls
{
    partial class ucListProduct
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ucListProduct));
            groupControl1 = new DevExpress.XtraEditors.GroupControl();
            groupControl3 = new DevExpress.XtraEditors.GroupControl();
            gridListProduct = new DevExpress.XtraGrid.GridControl();
            gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            Id = new DevExpress.XtraGrid.Columns.GridColumn();
            ProductName = new DevExpress.XtraGrid.Columns.GridColumn();
            Description = new DevExpress.XtraGrid.Columns.GridColumn();
            ImageProduct = new DevExpress.XtraGrid.Columns.GridColumn();
            Photo = new DevExpress.XtraEditors.Repository.RepositoryItemPictureEdit();
            Price = new DevExpress.XtraGrid.Columns.GridColumn();
            RestaurantName = new DevExpress.XtraGrid.Columns.GridColumn();
            CategoryName = new DevExpress.XtraGrid.Columns.GridColumn();
            groupControl2 = new DevExpress.XtraEditors.GroupControl();
            btnCategoryName = new DevExpress.XtraEditors.ButtonEdit();
            btnRestaurantname = new DevExpress.XtraEditors.ButtonEdit();
            label7 = new Label();
            txtProductName = new DevExpress.XtraEditors.TextEdit();
            label3 = new Label();
            label1 = new Label();
            toolStrip1 = new ToolStrip();
            SubBtnAdd = new ToolStripButton();
            toolStripSeparator2 = new ToolStripSeparator();
            btnClose = new ToolStripButton();
            SubBtnEdit = new ToolStripButton();
            toolStripSeparator3 = new ToolStripSeparator();
            SubBtnDelete = new ToolStripButton();
            toolStripSeparator1 = new ToolStripSeparator();
            SubBtnDeleteAll = new ToolStripButton();
            toolStripSeparator4 = new ToolStripSeparator();
            SubBtnSearch = new ToolStripButton();
            toolStripSeparator5 = new ToolStripSeparator();
            SubBtnSelect = new ToolStripButton();
            openFileDialog = new OpenFileDialog();
            ((System.ComponentModel.ISupportInitialize)groupControl1).BeginInit();
            groupControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)groupControl3).BeginInit();
            groupControl3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)gridListProduct).BeginInit();
            ((System.ComponentModel.ISupportInitialize)gridView1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)Photo).BeginInit();
            ((System.ComponentModel.ISupportInitialize)groupControl2).BeginInit();
            groupControl2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)btnCategoryName.Properties).BeginInit();
            ((System.ComponentModel.ISupportInitialize)btnRestaurantname.Properties).BeginInit();
            ((System.ComponentModel.ISupportInitialize)txtProductName.Properties).BeginInit();
            toolStrip1.SuspendLayout();
            SuspendLayout();
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
            groupControl1.TabIndex = 0;
            groupControl1.Text = "CHỨC NĂNG SẢN PHẨM";
            // 
            // groupControl3
            // 
            groupControl3.Controls.Add(gridListProduct);
            groupControl3.Dock = DockStyle.Fill;
            groupControl3.Location = new Point(315, 50);
            groupControl3.Margin = new Padding(3, 2, 3, 2);
            groupControl3.Name = "groupControl3";
            groupControl3.Size = new Size(684, 535);
            groupControl3.TabIndex = 3;
            groupControl3.Text = "DANH SÁCH SẢN PHẨM";
            // 
            // gridListProduct
            // 
            gridListProduct.Dock = DockStyle.Fill;
            gridListProduct.Location = new Point(2, 23);
            gridListProduct.MainView = gridView1;
            gridListProduct.Name = "gridListProduct";
            gridListProduct.RepositoryItems.AddRange(new DevExpress.XtraEditors.Repository.RepositoryItem[] { Photo });
            gridListProduct.Size = new Size(680, 510);
            gridListProduct.TabIndex = 0;
            gridListProduct.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] { gridView1 });
            // 
            // gridView1
            // 
            gridView1.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] { Id, ProductName, Description, ImageProduct, Price, RestaurantName, CategoryName });
            gridView1.GridControl = gridListProduct;
            gridView1.Name = "gridView1";
            gridView1.OptionsSelection.MultiSelect = true;
            gridView1.OptionsSelection.MultiSelectMode = DevExpress.XtraGrid.Views.Grid.GridMultiSelectMode.CheckBoxRowSelect;
            gridView1.OptionsView.RowAutoHeight = true;
            gridView1.OptionsView.ShowAutoFilterRow = true;
            // 
            // Id
            // 
            Id.Caption = "Id";
            Id.FieldName = "Id";
            Id.Name = "Id";
            Id.OptionsEditForm.Visible = DevExpress.Utils.DefaultBoolean.True;
            Id.Visible = true;
            Id.VisibleIndex = 1;
            // 
            // ProductName
            // 
            ProductName.Caption = "Tên sản phẩm";
            ProductName.FieldName = "ProductName";
            ProductName.Name = "ProductName";
            ProductName.Visible = true;
            ProductName.VisibleIndex = 2;
            // 
            // Description
            // 
            Description.Caption = "Mô tả";
            Description.FieldName = "Description";
            Description.Name = "Description";
            Description.Visible = true;
            Description.VisibleIndex = 3;
            // 
            // ImageProduct
            // 
            ImageProduct.Caption = "Hình ảnh";
            ImageProduct.ColumnEdit = Photo;
            ImageProduct.FieldName = "ImageProduct";
            ImageProduct.Name = "ImageProduct";
            ImageProduct.Visible = true;
            ImageProduct.VisibleIndex = 4;
            // 
            // Photo
            // 
            Photo.Name = "Photo";
            Photo.SizeMode = DevExpress.XtraEditors.Controls.PictureSizeMode.Zoom;
            // 
            // Price
            // 
            Price.Caption = "Giá";
            Price.FieldName = "Price";
            Price.Name = "Price";
            Price.Visible = true;
            Price.VisibleIndex = 5;
            // 
            // RestaurantName
            // 
            RestaurantName.Caption = "Nhà hàng";
            RestaurantName.FieldName = "RestaurantName";
            RestaurantName.Name = "RestaurantName";
            RestaurantName.Visible = true;
            RestaurantName.VisibleIndex = 6;
            // 
            // CategoryName
            // 
            CategoryName.Caption = "Thể loại";
            CategoryName.FieldName = "CategoryName";
            CategoryName.Name = "CategoryName";
            CategoryName.Visible = true;
            CategoryName.VisibleIndex = 7;
            // 
            // groupControl2
            // 
            groupControl2.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Simple;
            groupControl2.Controls.Add(btnCategoryName);
            groupControl2.Controls.Add(btnRestaurantname);
            groupControl2.Controls.Add(label7);
            groupControl2.Controls.Add(txtProductName);
            groupControl2.Controls.Add(label3);
            groupControl2.Controls.Add(label1);
            groupControl2.Dock = DockStyle.Left;
            groupControl2.Location = new Point(2, 50);
            groupControl2.Margin = new Padding(3, 2, 3, 2);
            groupControl2.Name = "groupControl2";
            groupControl2.Size = new Size(313, 535);
            groupControl2.TabIndex = 2;
            groupControl2.Text = "THÔNG TIN SẢN PHẨM";
            // 
            // btnCategoryName
            // 
            btnCategoryName.Location = new Point(4, 133);
            btnCategoryName.Name = "btnCategoryName";
            btnCategoryName.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] { new DevExpress.XtraEditors.Controls.EditorButton() });
            btnCategoryName.Size = new Size(302, 20);
            btnCategoryName.TabIndex = 11;
            btnCategoryName.EditValueChanged += btnCategoryName_EditValueChanged;
            btnCategoryName.Click += btnCategoryName_Click;
            // 
            // btnRestaurantname
            // 
            btnRestaurantname.Location = new Point(4, 47);
            btnRestaurantname.Name = "btnRestaurantname";
            btnRestaurantname.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] { new DevExpress.XtraEditors.Controls.EditorButton() });
            btnRestaurantname.Size = new Size(302, 20);
            btnRestaurantname.TabIndex = 1;
            btnRestaurantname.EditValueChanged += btnRestaurantname_EditValueChanged;
            btnRestaurantname.Click += btnRestaurantname_Click;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Tahoma", 8.25F, FontStyle.Bold, GraphicsUnit.Point);
            label7.Location = new Point(5, 113);
            label7.Name = "label7";
            label7.Size = new Size(88, 13);
            label7.TabIndex = 10;
            label7.Text = "Loại danh mục";
            // 
            // txtProductName
            // 
            txtProductName.Location = new Point(7, 87);
            txtProductName.Name = "txtProductName";
            txtProductName.Size = new Size(300, 20);
            txtProductName.TabIndex = 2;
            txtProductName.EditValueChanged += txtProductName_EditValueChanged;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Tahoma", 8.25F, FontStyle.Bold, GraphicsUnit.Point);
            label3.Location = new Point(5, 70);
            label3.Name = "label3";
            label3.Size = new Size(86, 13);
            label3.TabIndex = 2;
            label3.Text = "Tên sản phẩm";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Tahoma", 8.25F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(4, 30);
            label1.Name = "label1";
            label1.Size = new Size(59, 13);
            label1.TabIndex = 0;
            label1.Text = "Nhà hàng";
            // 
            // toolStrip1
            // 
            toolStrip1.ImageScalingSize = new Size(20, 20);
            toolStrip1.Items.AddRange(new ToolStripItem[] { SubBtnAdd, toolStripSeparator2, btnClose, SubBtnEdit, toolStripSeparator3, SubBtnDelete, toolStripSeparator1, SubBtnDeleteAll, toolStripSeparator4, SubBtnSearch, toolStripSeparator5, SubBtnSelect });
            toolStrip1.Location = new Point(2, 23);
            toolStrip1.Name = "toolStrip1";
            toolStrip1.Size = new Size(997, 27);
            toolStrip1.TabIndex = 0;
            toolStrip1.Text = "toolStrip1";
            // 
            // SubBtnAdd
            // 
            SubBtnAdd.Image = (Image)resources.GetObject("SubBtnAdd.Image");
            SubBtnAdd.ImageTransparentColor = Color.Magenta;
            SubBtnAdd.Name = "SubBtnAdd";
            SubBtnAdd.Size = new Size(61, 24);
            SubBtnAdd.Text = "Thêm";
            SubBtnAdd.Click += btnUcProduct_Click;
            // 
            // toolStripSeparator2
            // 
            toolStripSeparator2.Name = "toolStripSeparator2";
            toolStripSeparator2.Size = new Size(6, 27);
            // 
            // btnClose
            // 
            btnClose.Alignment = ToolStripItemAlignment.Right;
            btnClose.Image = (Image)resources.GetObject("btnClose.Image");
            btnClose.ImageTransparentColor = Color.Magenta;
            btnClose.Name = "btnClose";
            btnClose.RightToLeft = RightToLeft.No;
            btnClose.Size = new Size(60, 24);
            btnClose.Text = "Đóng";
            btnClose.Click += btnClose_Click;
            // 
            // SubBtnEdit
            // 
            SubBtnEdit.Image = (Image)resources.GetObject("SubBtnEdit.Image");
            SubBtnEdit.ImageTransparentColor = Color.Magenta;
            SubBtnEdit.Name = "SubBtnEdit";
            SubBtnEdit.Size = new Size(50, 24);
            SubBtnEdit.Text = "Sửa";
            SubBtnEdit.Click += SubBtnEdit_Click;
            // 
            // toolStripSeparator3
            // 
            toolStripSeparator3.Name = "toolStripSeparator3";
            toolStripSeparator3.Size = new Size(6, 27);
            // 
            // SubBtnDelete
            // 
            SubBtnDelete.Image = (Image)resources.GetObject("SubBtnDelete.Image");
            SubBtnDelete.ImageTransparentColor = Color.Magenta;
            SubBtnDelete.Name = "SubBtnDelete";
            SubBtnDelete.Size = new Size(51, 24);
            SubBtnDelete.Text = "Xóa";
            SubBtnDelete.Click += SubBtnDelete_Click;
            // 
            // toolStripSeparator1
            // 
            toolStripSeparator1.Name = "toolStripSeparator1";
            toolStripSeparator1.Size = new Size(6, 27);
            // 
            // SubBtnDeleteAll
            // 
            SubBtnDeleteAll.Image = (Image)resources.GetObject("SubBtnDeleteAll.Image");
            SubBtnDeleteAll.ImageTransparentColor = Color.Magenta;
            SubBtnDeleteAll.Name = "SubBtnDeleteAll";
            SubBtnDeleteAll.Size = new Size(83, 24);
            SubBtnDeleteAll.Text = "Xóa tất cả";
            // 
            // toolStripSeparator4
            // 
            toolStripSeparator4.Name = "toolStripSeparator4";
            toolStripSeparator4.Size = new Size(6, 27);
            // 
            // SubBtnSearch
            // 
            SubBtnSearch.Image = (Image)resources.GetObject("SubBtnSearch.Image");
            SubBtnSearch.ImageTransparentColor = Color.Magenta;
            SubBtnSearch.Name = "SubBtnSearch";
            SubBtnSearch.Size = new Size(80, 24);
            SubBtnSearch.Text = "Tìm kiếm";
            // 
            // toolStripSeparator5
            // 
            toolStripSeparator5.Name = "toolStripSeparator5";
            toolStripSeparator5.Size = new Size(6, 27);
            // 
            // SubBtnSelect
            // 
            SubBtnSelect.Image = (Image)resources.GetObject("SubBtnSelect.Image");
            SubBtnSelect.ImageTransparentColor = Color.Magenta;
            SubBtnSelect.Name = "SubBtnSelect";
            SubBtnSelect.Size = new Size(60, 24);
            SubBtnSelect.Text = "Chọn";
            SubBtnSelect.Click += SubBtnSelect_Click;
            // 
            // openFileDialog
            // 
            openFileDialog.FileName = "openFileDialog1";
            // 
            // ucListProduct
            // 
            AutoScaleDimensions = new SizeF(6F, 13F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(groupControl1);
            Name = "ucListProduct";
            Size = new Size(1001, 587);
            Load += ucListProduct_Load;
            ((System.ComponentModel.ISupportInitialize)groupControl1).EndInit();
            groupControl1.ResumeLayout(false);
            groupControl1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)groupControl3).EndInit();
            groupControl3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)gridListProduct).EndInit();
            ((System.ComponentModel.ISupportInitialize)gridView1).EndInit();
            ((System.ComponentModel.ISupportInitialize)Photo).EndInit();
            ((System.ComponentModel.ISupportInitialize)groupControl2).EndInit();
            groupControl2.ResumeLayout(false);
            groupControl2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)btnCategoryName.Properties).EndInit();
            ((System.ComponentModel.ISupportInitialize)btnRestaurantname.Properties).EndInit();
            ((System.ComponentModel.ISupportInitialize)txtProductName.Properties).EndInit();
            toolStrip1.ResumeLayout(false);
            toolStrip1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private DevExpress.XtraEditors.GroupControl groupControl1;
        private ToolStrip toolStrip1;
        private ToolStripButton SubBtnAdd;
        private ToolStripButton SubBtnSearch;
        private DevExpress.XtraEditors.GroupControl groupControl2;
        private DevExpress.XtraEditors.ComboBoxEdit cboRestaurant;
        private Label label1;
        private DevExpress.XtraEditors.GroupControl groupControl3;
        private Label label3;
        private DevExpress.XtraEditors.TextEdit txtProductName;
        private DevExpress.XtraEditors.ComboBoxEdit comboBoxEdit1;
        private Label label7;
        private OpenFileDialog openFileDialog;
        private DevExpress.XtraGrid.GridControl gridData;
        //private DevExpress.XtraGrid.Views.Grid.GridView gridProduct;
        private ToolStripButton SubBtnEdit;
        private ToolStripSeparator toolStripSeparator1;
        private ToolStripButton SubBtnDelete;
        private ToolStripButton SubBtnDeleteAll;
        private ToolStripButton SubBtnSelect;
        private ToolStripSeparator toolStripSeparator2;
        private ToolStripSeparator toolStripSeparator3;
        protected ToolStripButton btnClose;
        private ToolStripSeparator toolStripSeparator4;
        private ToolStripSeparator toolStripSeparator5;
        private DevExpress.XtraEditors.ButtonEdit btnCategoryName;
        private DevExpress.XtraEditors.ButtonEdit btnRestaurantname;
        private DevExpress.XtraGrid.GridControl gridListProduct;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private DevExpress.XtraGrid.Columns.GridColumn Id;
        private DevExpress.XtraGrid.Columns.GridColumn ProductName;
        private DevExpress.XtraGrid.Columns.GridColumn Description;
        private DevExpress.XtraGrid.Columns.GridColumn ImageProduct;
        private DevExpress.XtraGrid.Columns.GridColumn Price;
        private DevExpress.XtraGrid.Columns.GridColumn RestaurantName;
        private DevExpress.XtraGrid.Columns.GridColumn CategoryName;
        private DevExpress.XtraEditors.Repository.RepositoryItemPictureEdit Photo;
    }
}
