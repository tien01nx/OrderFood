namespace Client.UserControls
{
    partial class ucListCategories
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ucListCategories));
            DevExpress.XtraGrid.GridLevelNode gridLevelNode1 = new DevExpress.XtraGrid.GridLevelNode();
            btnClose = new ToolStripButton();
            toolStripSeparator3 = new ToolStripSeparator();
            SubBtnDelete = new ToolStripButton();
            toolStripSeparator1 = new ToolStripSeparator();
            SubBtnEdit = new ToolStripButton();
            txtCategoryName = new DevExpress.XtraEditors.TextEdit();
            label3 = new Label();
            toolStripSeparator4 = new ToolStripSeparator();
            SubBtnSearch = new ToolStripButton();
            toolStripSeparator5 = new ToolStripSeparator();
            SubBtnDeleteAll = new ToolStripButton();
            openFileDialog = new OpenFileDialog();
            SubBtnAdd = new ToolStripButton();
            toolStrip1 = new ToolStrip();
            toolStripSeparator2 = new ToolStripSeparator();
            SubBtnSelect = new ToolStripButton();
            label1 = new Label();
            groupControl2 = new DevExpress.XtraEditors.GroupControl();
            btnRestaurant = new DevExpress.XtraEditors.ButtonEdit();
            gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            Id = new DevExpress.XtraGrid.Columns.GridColumn();
            RestaurantId = new DevExpress.XtraGrid.Columns.GridColumn();
            CategoryName = new DevExpress.XtraGrid.Columns.GridColumn();
            Descriptions = new DevExpress.XtraGrid.Columns.GridColumn();
            gridCategories = new DevExpress.XtraGrid.GridControl();
            groupControl3 = new DevExpress.XtraEditors.GroupControl();
            groupControl1 = new DevExpress.XtraEditors.GroupControl();
            ((System.ComponentModel.ISupportInitialize)txtCategoryName.Properties).BeginInit();
            toolStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)groupControl2).BeginInit();
            groupControl2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)btnRestaurant.Properties).BeginInit();
            ((System.ComponentModel.ISupportInitialize)gridView1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)gridCategories).BeginInit();
            ((System.ComponentModel.ISupportInitialize)groupControl3).BeginInit();
            groupControl3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)groupControl1).BeginInit();
            groupControl1.SuspendLayout();
            SuspendLayout();
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
            // 
            // toolStripSeparator1
            // 
            toolStripSeparator1.Name = "toolStripSeparator1";
            toolStripSeparator1.Size = new Size(6, 27);
            // 
            // SubBtnEdit
            // 
            SubBtnEdit.Image = (Image)resources.GetObject("SubBtnEdit.Image");
            SubBtnEdit.ImageTransparentColor = Color.Magenta;
            SubBtnEdit.Name = "SubBtnEdit";
            SubBtnEdit.Size = new Size(50, 24);
            SubBtnEdit.Text = "Sửa";
            // 
            // txtCategoryName
            // 
            txtCategoryName.Location = new Point(7, 87);
            txtCategoryName.Name = "txtCategoryName";
            txtCategoryName.Size = new Size(300, 20);
            txtCategoryName.TabIndex = 3;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Tahoma", 8.25F, FontStyle.Bold, GraphicsUnit.Point);
            label3.Location = new Point(5, 70);
            label3.Name = "label3";
            label3.Size = new Size(86, 13);
            label3.TabIndex = 2;
            label3.Text = "Tên danh mục";
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
            // SubBtnDeleteAll
            // 
            SubBtnDeleteAll.Image = (Image)resources.GetObject("SubBtnDeleteAll.Image");
            SubBtnDeleteAll.ImageTransparentColor = Color.Magenta;
            SubBtnDeleteAll.Name = "SubBtnDeleteAll";
            SubBtnDeleteAll.Size = new Size(83, 24);
            SubBtnDeleteAll.Text = "Xóa tất cả";
            // 
            // openFileDialog
            // 
            openFileDialog.FileName = "openFileDialog1";
            // 
            // SubBtnAdd
            // 
            SubBtnAdd.Image = (Image)resources.GetObject("SubBtnAdd.Image");
            SubBtnAdd.ImageTransparentColor = Color.Magenta;
            SubBtnAdd.Name = "SubBtnAdd";
            SubBtnAdd.Size = new Size(61, 24);
            SubBtnAdd.Text = "Thêm";
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
            // toolStripSeparator2
            // 
            toolStripSeparator2.Name = "toolStripSeparator2";
            toolStripSeparator2.Size = new Size(6, 27);
            // 
            // SubBtnSelect
            // 
            SubBtnSelect.Image = (Image)resources.GetObject("SubBtnSelect.Image");
            SubBtnSelect.ImageTransparentColor = Color.Magenta;
            SubBtnSelect.Name = "SubBtnSelect";
            SubBtnSelect.Size = new Size(60, 24);
            SubBtnSelect.Text = "Chọn";
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
            // groupControl2
            // 
            groupControl2.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Simple;
            groupControl2.Controls.Add(btnRestaurant);
            groupControl2.Controls.Add(txtCategoryName);
            groupControl2.Controls.Add(label3);
            groupControl2.Controls.Add(label1);
            groupControl2.Dock = DockStyle.Left;
            groupControl2.Location = new Point(2, 50);
            groupControl2.Margin = new Padding(3, 2, 3, 2);
            groupControl2.Name = "groupControl2";
            groupControl2.Size = new Size(313, 535);
            groupControl2.TabIndex = 2;
            groupControl2.Text = "THÔNG TIN DANH MỤC";
            // 
            // btnRestaurant
            // 
            btnRestaurant.Location = new Point(7, 47);
            btnRestaurant.Name = "btnRestaurant";
            btnRestaurant.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] { new DevExpress.XtraEditors.Controls.EditorButton() });
            btnRestaurant.Size = new Size(300, 20);
            btnRestaurant.TabIndex = 8;
            btnRestaurant.Click += btnRestaurant_Click;
            // 
            // gridView1
            // 
            gridView1.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] { Id, RestaurantId, CategoryName, Descriptions });
            gridView1.DetailHeight = 284;
            gridView1.GridControl = gridCategories;
            gridView1.Name = "gridView1";
            gridView1.OptionsBehavior.Editable = false;
            gridView1.OptionsBehavior.ReadOnly = true;
            gridView1.OptionsEditForm.PopupEditFormWidth = 686;
            gridView1.OptionsView.ShowGroupPanel = false;
            gridView1.OptionsView.ShowIndicator = false;
            gridView1.SortInfo.AddRange(new DevExpress.XtraGrid.Columns.GridColumnSortInfo[] { new DevExpress.XtraGrid.Columns.GridColumnSortInfo(CategoryName, DevExpress.Data.ColumnSortOrder.Ascending) });
            // 
            // Id
            // 
            Id.Caption = "Id";
            Id.FieldName = "Id";
            Id.Name = "Id";
            Id.Visible = true;
            Id.VisibleIndex = 0;
            // 
            // RestaurantId
            // 
            RestaurantId.Caption = "RestaurantId";
            RestaurantId.FieldName = "RestaurantId";
            RestaurantId.Name = "RestaurantId";
            RestaurantId.Visible = true;
            RestaurantId.VisibleIndex = 1;
            // 
            // CategoryName
            // 
            CategoryName.Caption = "CategoryName";
            CategoryName.FieldName = "CategoryName";
            CategoryName.Name = "CategoryName";
            CategoryName.Visible = true;
            CategoryName.VisibleIndex = 2;
            // 
            // Descriptions
            // 
            Descriptions.Caption = "Descriptions";
            Descriptions.FieldName = "Descriptions";
            Descriptions.Name = "Descriptions";
            Descriptions.Visible = true;
            Descriptions.VisibleIndex = 3;
            // 
            // gridCategories
            // 
            gridCategories.Dock = DockStyle.Fill;
            gridCategories.EmbeddedNavigator.Margin = new Padding(3, 2, 3, 2);
            gridLevelNode1.RelationName = "Level1";
            gridCategories.LevelTree.Nodes.AddRange(new DevExpress.XtraGrid.GridLevelNode[] { gridLevelNode1 });
            gridCategories.Location = new Point(2, 23);
            gridCategories.MainView = gridView1;
            gridCategories.Margin = new Padding(3, 2, 3, 2);
            gridCategories.Name = "gridCategories";
            gridCategories.Size = new Size(680, 510);
            gridCategories.TabIndex = 2;
            gridCategories.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] { gridView1 });
            // 
            // groupControl3
            // 
            groupControl3.Controls.Add(gridCategories);
            groupControl3.Dock = DockStyle.Fill;
            groupControl3.Location = new Point(315, 50);
            groupControl3.Margin = new Padding(3, 2, 3, 2);
            groupControl3.Name = "groupControl3";
            groupControl3.Size = new Size(684, 535);
            groupControl3.TabIndex = 3;
            groupControl3.Text = "DANH SÁCH DANH MỤC";
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
            groupControl1.Text = "CHỨC NĂNG DANH MỤC";
            // 
            // ucListCategories
            // 
            AutoScaleDimensions = new SizeF(6F, 13F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(groupControl1);
            Cursor = Cursors.No;
            Name = "ucListCategories";
            Size = new Size(1001, 587);
            Load += ucListCategories_Load;
            ((System.ComponentModel.ISupportInitialize)txtCategoryName.Properties).EndInit();
            toolStrip1.ResumeLayout(false);
            toolStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)groupControl2).EndInit();
            groupControl2.ResumeLayout(false);
            groupControl2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)btnRestaurant.Properties).EndInit();
            ((System.ComponentModel.ISupportInitialize)gridView1).EndInit();
            ((System.ComponentModel.ISupportInitialize)gridCategories).EndInit();
            ((System.ComponentModel.ISupportInitialize)groupControl3).EndInit();
            groupControl3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)groupControl1).EndInit();
            groupControl1.ResumeLayout(false);
            groupControl1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        protected ToolStripButton btnClose;
        private ToolStripSeparator toolStripSeparator3;
        private ToolStripButton SubBtnDelete;
        private ToolStripSeparator toolStripSeparator1;
        private ToolStripButton SubBtnEdit;
        private DevExpress.XtraEditors.TextEdit txtCategoryName;
        private Label label3;
        private ToolStripSeparator toolStripSeparator4;
        private ToolStripButton SubBtnSearch;
        private ToolStripSeparator toolStripSeparator5;
        private ToolStripButton SubBtnDeleteAll;
        private OpenFileDialog openFileDialog;
        private ToolStripButton SubBtnAdd;
        private ToolStrip toolStrip1;
        private ToolStripSeparator toolStripSeparator2;
        private ToolStripButton SubBtnSelect;
        private Label label1;
        private DevExpress.XtraEditors.GroupControl groupControl2;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private DevExpress.XtraGrid.GridControl gridCategories;
        private DevExpress.XtraEditors.GroupControl groupControl3;
        private DevExpress.XtraEditors.GroupControl groupControl1;
        private DevExpress.XtraEditors.ButtonEdit btnRestaurant;
        private DevExpress.XtraGrid.Columns.GridColumn Id;
        private DevExpress.XtraGrid.Columns.GridColumn RestaurantId;
        private DevExpress.XtraGrid.Columns.GridColumn CategoryName;
        private DevExpress.XtraGrid.Columns.GridColumn Descriptions;
    }
}
