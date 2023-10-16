﻿namespace Client.UserControls
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
            btnClose = new ToolStripButton();
            toolStripSeparator3 = new ToolStripSeparator();
            SubBtnDelete = new ToolStripButton();
            toolStripSeparator1 = new ToolStripSeparator();
            SubBtnEdit = new ToolStripButton();
            toolStripSeparator4 = new ToolStripSeparator();
            SubBtnSearch = new ToolStripButton();
            toolStripSeparator5 = new ToolStripSeparator();
            SubBtnDeleteAll = new ToolStripButton();
            openFileDialog = new OpenFileDialog();
            SubBtnAdd = new ToolStripButton();
            toolStrip1 = new ToolStrip();
            toolStripSeparator2 = new ToolStripSeparator();
            SubBtnSelect = new ToolStripButton();
            toolStripSeparator6 = new ToolStripSeparator();
            SubBtnClear = new ToolStripButton();
            groupControl1 = new DevExpress.XtraEditors.GroupControl();
            groupControl3 = new DevExpress.XtraEditors.GroupControl();
            gridCategories = new DevExpress.XtraGrid.GridControl();
            gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            Id = new DevExpress.XtraGrid.Columns.GridColumn();
            RestaurantId = new DevExpress.XtraGrid.Columns.GridColumn();
            CategoryName = new DevExpress.XtraGrid.Columns.GridColumn();
            Descriptions = new DevExpress.XtraGrid.Columns.GridColumn();
            gridView2 = new DevExpress.XtraGrid.Views.Grid.GridView();
            groupControl2 = new DevExpress.XtraEditors.GroupControl();
            txtCategoryName = new DevExpress.XtraEditors.TextEdit();
            labelControl2 = new DevExpress.XtraEditors.LabelControl();
            btnRestaurantname = new DevExpress.XtraEditors.ButtonEdit();
            labelControl1 = new DevExpress.XtraEditors.LabelControl();
            RestaurantName = new DevExpress.XtraGrid.Columns.GridColumn();
            toolStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)groupControl1).BeginInit();
            groupControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)groupControl3).BeginInit();
            groupControl3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)gridCategories).BeginInit();
            ((System.ComponentModel.ISupportInitialize)gridView1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)gridView2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)groupControl2).BeginInit();
            groupControl2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)txtCategoryName.Properties).BeginInit();
            ((System.ComponentModel.ISupportInitialize)btnRestaurantname.Properties).BeginInit();
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
            SubBtnDelete.Click += SubBtnDelete_Click;
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
            SubBtnEdit.Click += SubBtnEdit_Click;
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
            SubBtnAdd.Click += SubBtnAdd_Click;
            // 
            // toolStrip1
            // 
            toolStrip1.ImageScalingSize = new Size(20, 20);
            toolStrip1.Items.AddRange(new ToolStripItem[] { SubBtnAdd, toolStripSeparator2, btnClose, SubBtnEdit, toolStripSeparator3, SubBtnDelete, toolStripSeparator1, SubBtnDeleteAll, toolStripSeparator4, SubBtnSearch, toolStripSeparator5, SubBtnSelect, toolStripSeparator6, SubBtnClear });
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
            SubBtnSelect.Click += SubBtnSelect_Click;
            // 
            // toolStripSeparator6
            // 
            toolStripSeparator6.Name = "toolStripSeparator6";
            toolStripSeparator6.Size = new Size(6, 27);
            // 
            // SubBtnClear
            // 
            SubBtnClear.Image = (Image)resources.GetObject("SubBtnClear.Image");
            SubBtnClear.ImageTransparentColor = Color.Magenta;
            SubBtnClear.Name = "SubBtnClear";
            SubBtnClear.Size = new Size(78, 24);
            SubBtnClear.Text = "Làm mới";
            SubBtnClear.Click += SubBtnClear_Click;
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
            // groupControl3
            // 
            groupControl3.Controls.Add(gridCategories);
            groupControl3.Dock = DockStyle.Fill;
            groupControl3.Location = new Point(315, 50);
            groupControl3.Name = "groupControl3";
            groupControl3.Size = new Size(684, 535);
            groupControl3.TabIndex = 2;
            groupControl3.Text = "DANH SÁCH NHÀ HÀNG";
            // 
            // gridCategories
            // 
            gridCategories.Dock = DockStyle.Fill;
            gridCategories.EmbeddedNavigator.Margin = new Padding(3, 2, 3, 2);
            gridCategories.Location = new Point(2, 23);
            gridCategories.MainView = gridView1;
            gridCategories.Margin = new Padding(3, 2, 3, 2);
            gridCategories.Name = "gridCategories";
            gridCategories.Size = new Size(680, 510);
            gridCategories.TabIndex = 3;
            gridCategories.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] { gridView1, gridView2 });
            // 
            // gridView1
            // 
            gridView1.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] { Id, RestaurantId, CategoryName, Descriptions, RestaurantName });
            gridView1.DetailHeight = 284;
            gridView1.GridControl = gridCategories;
            gridView1.Name = "gridView1";
            gridView1.OptionsBehavior.Editable = false;
            gridView1.OptionsBehavior.ReadOnly = true;
            gridView1.OptionsEditForm.PopupEditFormWidth = 686;
            gridView1.OptionsSelection.MultiSelect = true;
            gridView1.OptionsSelection.MultiSelectMode = DevExpress.XtraGrid.Views.Grid.GridMultiSelectMode.CheckBoxRowSelect;
            gridView1.OptionsView.ShowGroupPanel = false;
            gridView1.OptionsView.ShowIndicator = false;
            gridView1.SortInfo.AddRange(new DevExpress.XtraGrid.Columns.GridColumnSortInfo[] { new DevExpress.XtraGrid.Columns.GridColumnSortInfo(CategoryName, DevExpress.Data.ColumnSortOrder.Ascending) });
            gridView1.RowCellClick += gridView1_RowCellClick;
            gridView1.CustomUnboundColumnData += gridView1_CustomUnboundColumnData;
            // 
            // Id
            // 
            Id.Caption = "Id";
            Id.FieldName = "Id";
            Id.Name = "Id";
            // 
            // RestaurantId
            // 
            RestaurantId.Caption = "RestaurantId";
            RestaurantId.FieldName = "RestaurantId";
            RestaurantId.Name = "RestaurantId";
            // 
            // CategoryName
            // 
            CategoryName.Caption = "Tên danh mục";
            CategoryName.FieldName = "CategoryName";
            CategoryName.Name = "CategoryName";
            CategoryName.Visible = true;
            CategoryName.VisibleIndex = 1;
            // 
            // Descriptions
            // 
            Descriptions.Caption = "Mô tả";
            Descriptions.FieldName = "Descriptions";
            Descriptions.Name = "Descriptions";
            Descriptions.Visible = true;
            Descriptions.VisibleIndex = 2;
            // 
            // gridView2
            // 
            gridView2.GridControl = gridCategories;
            gridView2.Name = "gridView2";
            // 
            // groupControl2
            // 
            groupControl2.Controls.Add(txtCategoryName);
            groupControl2.Controls.Add(labelControl2);
            groupControl2.Controls.Add(btnRestaurantname);
            groupControl2.Controls.Add(labelControl1);
            groupControl2.Dock = DockStyle.Left;
            groupControl2.Location = new Point(2, 50);
            groupControl2.Name = "groupControl2";
            groupControl2.Size = new Size(313, 535);
            groupControl2.TabIndex = 1;
            groupControl2.Text = "DANH SÁCH LỌC";
            // 
            // txtCategoryName
            // 
            txtCategoryName.Location = new Point(5, 101);
            txtCategoryName.Name = "txtCategoryName";
            txtCategoryName.Size = new Size(302, 20);
            txtCategoryName.TabIndex = 2;
            txtCategoryName.EditValueChanged += txtCategoryName_EditValueChanged;
            // 
            // labelControl2
            // 
            labelControl2.Appearance.Font = new Font("Tahoma", 8.25F, FontStyle.Bold, GraphicsUnit.Point);
            labelControl2.Appearance.Options.UseFont = true;
            labelControl2.Location = new Point(8, 78);
            labelControl2.Name = "labelControl2";
            labelControl2.Size = new Size(79, 13);
            labelControl2.TabIndex = 2;
            labelControl2.Text = "Tên danh mục";
            // 
            // btnRestaurantname
            // 
            btnRestaurantname.Location = new Point(5, 52);
            btnRestaurantname.Name = "btnRestaurantname";
            btnRestaurantname.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] { new DevExpress.XtraEditors.Controls.EditorButton() });
            btnRestaurantname.Size = new Size(302, 20);
            btnRestaurantname.TabIndex = 1;
            btnRestaurantname.EditValueChanged += btnRestaurantname_EditValueChanged;
            btnRestaurantname.Click += btnRestaurantname_Click;
            // 
            // labelControl1
            // 
            labelControl1.Appearance.Font = new Font("Tahoma", 8.25F, FontStyle.Bold, GraphicsUnit.Point);
            labelControl1.Appearance.Options.UseFont = true;
            labelControl1.Location = new Point(8, 31);
            labelControl1.Name = "labelControl1";
            labelControl1.Size = new Size(52, 13);
            labelControl1.TabIndex = 0;
            labelControl1.Text = "Nhà hàng";
            // 
            // RestaurantName
            // 
            RestaurantName.Caption = "Nhà hàng";
            RestaurantName.FieldName = "RestaurantName";
            RestaurantName.Name = "RestaurantName";
            RestaurantName.Visible = true;
            RestaurantName.VisibleIndex = 3;
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
            toolStrip1.ResumeLayout(false);
            toolStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)groupControl1).EndInit();
            groupControl1.ResumeLayout(false);
            groupControl1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)groupControl3).EndInit();
            groupControl3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)gridCategories).EndInit();
            ((System.ComponentModel.ISupportInitialize)gridView1).EndInit();
            ((System.ComponentModel.ISupportInitialize)gridView2).EndInit();
            ((System.ComponentModel.ISupportInitialize)groupControl2).EndInit();
            groupControl2.ResumeLayout(false);
            groupControl2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)txtCategoryName.Properties).EndInit();
            ((System.ComponentModel.ISupportInitialize)btnRestaurantname.Properties).EndInit();
            ResumeLayout(false);
        }

        #endregion

        protected ToolStripButton btnClose;
        private ToolStripSeparator toolStripSeparator3;
        private ToolStripButton SubBtnDelete;
        private ToolStripSeparator toolStripSeparator1;
        private ToolStripButton SubBtnEdit;
        private ToolStripSeparator toolStripSeparator4;
        private ToolStripButton SubBtnSearch;
        private ToolStripSeparator toolStripSeparator5;
        private ToolStripButton SubBtnDeleteAll;
        private OpenFileDialog openFileDialog;
        private ToolStripButton SubBtnAdd;
        private ToolStrip toolStrip1;
        private ToolStripSeparator toolStripSeparator2;
        private ToolStripButton SubBtnSelect;
        private DevExpress.XtraEditors.GroupControl groupControl1;
        private DevExpress.XtraEditors.GroupControl groupControl2;
        private DevExpress.XtraEditors.GroupControl groupControl3;
        private DevExpress.XtraGrid.GridControl gridCategories;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private DevExpress.XtraGrid.Columns.GridColumn Id;
        private DevExpress.XtraGrid.Columns.GridColumn RestaurantId;
        private DevExpress.XtraGrid.Columns.GridColumn CategoryName;
        private DevExpress.XtraGrid.Columns.GridColumn Descriptions;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraEditors.ButtonEdit btnRestaurantname;
        private DevExpress.XtraEditors.LabelControl labelControl2;
        private DevExpress.XtraEditors.TextEdit txtCategoryName;
        private ToolStripSeparator toolStripSeparator6;
        private ToolStripButton SubBtnClear;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView2;
        private DevExpress.XtraGrid.Columns.GridColumn RestaurantName;
    }
}