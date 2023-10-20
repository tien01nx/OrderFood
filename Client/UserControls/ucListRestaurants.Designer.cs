namespace Client.UserControls
{
    partial class ucListRestaurants
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
            components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ucListRestaurants));
            DevExpress.XtraEditors.Controls.EditorButtonImageOptions editorButtonImageOptions1 = new DevExpress.XtraEditors.Controls.EditorButtonImageOptions();
            DevExpress.Utils.SerializableAppearanceObject serializableAppearanceObject1 = new DevExpress.Utils.SerializableAppearanceObject();
            DevExpress.Utils.SerializableAppearanceObject serializableAppearanceObject2 = new DevExpress.Utils.SerializableAppearanceObject();
            DevExpress.Utils.SerializableAppearanceObject serializableAppearanceObject3 = new DevExpress.Utils.SerializableAppearanceObject();
            DevExpress.Utils.SerializableAppearanceObject serializableAppearanceObject4 = new DevExpress.Utils.SerializableAppearanceObject();
            openFileDialog = new OpenFileDialog();
            toolStrip1 = new ToolStrip();
            btnClose = new ToolStripButton();
            SubBtnAdd = new ToolStripButton();
            toolStripSeparator2 = new ToolStripSeparator();
            SubBtnEdit = new ToolStripButton();
            toolStripSeparator3 = new ToolStripSeparator();
            SubBtnDelete = new ToolStripButton();
            toolStripSeparator1 = new ToolStripSeparator();
            SubBtnDeleteAll = new ToolStripButton();
            toolStripSeparator4 = new ToolStripSeparator();
            SubBtnSearch = new ToolStripButton();
            toolStripSeparator5 = new ToolStripSeparator();
            SubBtnSelect = new ToolStripButton();
            toolStripSeparator6 = new ToolStripSeparator();
            SubBtnClear = new ToolStripButton();
            groupControl1 = new DevExpress.XtraEditors.GroupControl();
            Data = new DevExpress.XtraEditors.GroupControl();
            girdRestaurant = new DevExpress.XtraGrid.GridControl();
            gridlayout = new DevExpress.XtraGrid.Views.Grid.GridView();
            RestaurantName = new DevExpress.XtraGrid.Columns.GridColumn();
            PhoneNumber = new DevExpress.XtraGrid.Columns.GridColumn();
            Image = new DevExpress.XtraGrid.Columns.GridColumn();
            OpenTime = new DevExpress.XtraGrid.Columns.GridColumn();
            CloseTime = new DevExpress.XtraGrid.Columns.GridColumn();
            BankAccount = new DevExpress.XtraGrid.Columns.GridColumn();
            BankNumber = new DevExpress.XtraGrid.Columns.GridColumn();
            BankName = new DevExpress.XtraGrid.Columns.GridColumn();
            Chon = new DevExpress.XtraGrid.Columns.GridColumn();
            btnSubmitData = new DevExpress.XtraEditors.Repository.RepositoryItemButtonEdit();
            btnXoa = new DevExpress.XtraEditors.Repository.RepositoryItemButtonEdit();
            svgImage = new DevExpress.XtraEditors.Repository.RepositoryItemPictureEdit();
            groupControl2 = new DevExpress.XtraEditors.GroupControl();
            ckOpenTime = new DevExpress.XtraEditors.CheckEdit();
            cboFavoriteLevel = new DevExpress.XtraEditors.ComboBoxEdit();
            label2 = new Label();
            cboRestaurant = new DevExpress.XtraEditors.ComboBoxEdit();
            label1 = new Label();
            toastNotificationsManager1 = new DevExpress.XtraBars.ToastNotifications.ToastNotificationsManager(components);
            toolStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)groupControl1).BeginInit();
            groupControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)Data).BeginInit();
            Data.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)girdRestaurant).BeginInit();
            ((System.ComponentModel.ISupportInitialize)gridlayout).BeginInit();
            ((System.ComponentModel.ISupportInitialize)btnSubmitData).BeginInit();
            ((System.ComponentModel.ISupportInitialize)btnXoa).BeginInit();
            ((System.ComponentModel.ISupportInitialize)svgImage).BeginInit();
            ((System.ComponentModel.ISupportInitialize)groupControl2).BeginInit();
            groupControl2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)ckOpenTime.Properties).BeginInit();
            ((System.ComponentModel.ISupportInitialize)cboFavoriteLevel.Properties).BeginInit();
            ((System.ComponentModel.ISupportInitialize)cboRestaurant.Properties).BeginInit();
            ((System.ComponentModel.ISupportInitialize)toastNotificationsManager1).BeginInit();
            SuspendLayout();
            // 
            // openFileDialog
            // 
            openFileDialog.FileName = "openFileDialog1";
            // 
            // toolStrip1
            // 
            toolStrip1.ImageScalingSize = new Size(20, 20);
            toolStrip1.Items.AddRange(new ToolStripItem[] { btnClose, SubBtnAdd, toolStripSeparator2, SubBtnEdit, toolStripSeparator3, SubBtnDelete, toolStripSeparator1, SubBtnDeleteAll, toolStripSeparator4, SubBtnSearch, toolStripSeparator5, SubBtnSelect, toolStripSeparator6, SubBtnClear });
            toolStrip1.Location = new Point(2, 23);
            toolStrip1.Name = "toolStrip1";
            toolStrip1.Size = new Size(997, 27);
            toolStrip1.TabIndex = 0;
            toolStrip1.Text = "toolStrip1";
            // 
            // btnClose
            // 
            btnClose.Alignment = ToolStripItemAlignment.Right;
            btnClose.DisplayStyle = ToolStripItemDisplayStyle.Image;
            btnClose.Image = (Image)resources.GetObject("btnClose.Image");
            btnClose.ImageTransparentColor = Color.Magenta;
            btnClose.Name = "btnClose";
            btnClose.RightToLeft = RightToLeft.No;
            btnClose.Size = new Size(24, 24);
            btnClose.Text = "toolStripButton6";
            btnClose.Click += btnClose_Click;
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
            // toolStripSeparator2
            // 
            toolStripSeparator2.Name = "toolStripSeparator2";
            toolStripSeparator2.Size = new Size(6, 27);
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
            // 
            // groupControl1
            // 
            groupControl1.Controls.Add(Data);
            groupControl1.Controls.Add(groupControl2);
            groupControl1.Controls.Add(toolStrip1);
            groupControl1.Dock = DockStyle.Fill;
            groupControl1.Location = new Point(0, 0);
            groupControl1.Name = "groupControl1";
            groupControl1.Size = new Size(1001, 587);
            groupControl1.TabIndex = 1;
            groupControl1.Text = "DANH SÁCH NHÀ HÀNG";
            // 
            // Data
            // 
            Data.Controls.Add(girdRestaurant);
            Data.Dock = DockStyle.Fill;
            Data.Location = new Point(315, 50);
            Data.Name = "Data";
            Data.Size = new Size(684, 535);
            Data.TabIndex = 4;
            Data.Text = "Danh sách nhà hàng";
            // 
            // girdRestaurant
            // 
            girdRestaurant.Dock = DockStyle.Fill;
            girdRestaurant.Location = new Point(2, 23);
            girdRestaurant.MainView = gridlayout;
            girdRestaurant.Name = "girdRestaurant";
            girdRestaurant.RepositoryItems.AddRange(new DevExpress.XtraEditors.Repository.RepositoryItem[] { btnXoa, svgImage, btnSubmitData });
            girdRestaurant.Size = new Size(680, 510);
            girdRestaurant.TabIndex = 0;
            girdRestaurant.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] { gridlayout });
            // 
            // gridlayout
            // 
            gridlayout.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] { RestaurantName, PhoneNumber, Image, OpenTime, CloseTime, BankAccount, BankNumber, BankName, Chon });
            gridlayout.GridControl = girdRestaurant;
            gridlayout.Name = "gridlayout";
            gridlayout.OptionsEditForm.PopupEditFormWidth = 686;
            gridlayout.OptionsSelection.MultiSelect = true;
            gridlayout.OptionsSelection.MultiSelectMode = DevExpress.XtraGrid.Views.Grid.GridMultiSelectMode.CheckBoxRowSelect;
            gridlayout.OptionsView.RowAutoHeight = true;
            gridlayout.SortInfo.AddRange(new DevExpress.XtraGrid.Columns.GridColumnSortInfo[] { new DevExpress.XtraGrid.Columns.GridColumnSortInfo(PhoneNumber, DevExpress.Data.ColumnSortOrder.Ascending) });
            // 
            // RestaurantName
            // 
            RestaurantName.Caption = "Nhà hàng";
            RestaurantName.FieldName = "RestaurantName";
            RestaurantName.Name = "RestaurantName";
            RestaurantName.Visible = true;
            RestaurantName.VisibleIndex = 1;
            // 
            // PhoneNumber
            // 
            PhoneNumber.Caption = "Số điện thoại";
            PhoneNumber.FieldName = "PhoneNumber";
            PhoneNumber.Name = "PhoneNumber";
            PhoneNumber.Visible = true;
            PhoneNumber.VisibleIndex = 2;
            // 
            // Image
            // 
            Image.Caption = "Hình ảnh";
            Image.FieldName = "Image";
            Image.Name = "Image";
            Image.OptionsFilter.AllowFilter = false;
            Image.Visible = true;
            Image.VisibleIndex = 3;
            // 
            // OpenTime
            // 
            OpenTime.Caption = "Thời gian mở cửa";
            OpenTime.FieldName = "OpenTime";
            OpenTime.Name = "OpenTime";
            OpenTime.Visible = true;
            OpenTime.VisibleIndex = 4;
            // 
            // CloseTime
            // 
            CloseTime.Caption = "Thời gian đóng cửa";
            CloseTime.FieldName = "CloseTime";
            CloseTime.Name = "CloseTime";
            CloseTime.Visible = true;
            CloseTime.VisibleIndex = 5;
            // 
            // BankAccount
            // 
            BankAccount.Caption = "Số tài khoản";
            BankAccount.FieldName = "BankAccount";
            BankAccount.Name = "BankAccount";
            BankAccount.Visible = true;
            BankAccount.VisibleIndex = 6;
            // 
            // BankNumber
            // 
            BankNumber.Caption = "Chủ tài khoản";
            BankNumber.FieldName = "BankNumber";
            BankNumber.Name = "BankNumber";
            BankNumber.Visible = true;
            BankNumber.VisibleIndex = 7;
            // 
            // BankName
            // 
            BankName.Caption = "Tên ngân hàng";
            BankName.FieldName = "BankName";
            BankName.Name = "BankName";
            BankName.Visible = true;
            BankName.VisibleIndex = 8;
            // 
            // Chon
            // 
            Chon.Caption = "Chọn";
            Chon.ColumnEdit = btnSubmitData;
            Chon.FieldName = "Chon";
            Chon.Name = "Chon";
            Chon.Visible = true;
            Chon.VisibleIndex = 9;
            // 
            // btnSubmitData
            // 
            btnSubmitData.AutoHeight = false;
            btnSubmitData.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] { new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Plus) });
            btnSubmitData.Name = "btnSubmitData";
            btnSubmitData.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.HideTextEditor;
            btnSubmitData.Click += btnSubmitData_Click;
            // 
            // btnXoa
            // 
            btnXoa.AutoHeight = false;
            editorButtonImageOptions1.Image = (Image)resources.GetObject("editorButtonImageOptions1.Image");
            btnXoa.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] { new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Glyph, "", -1, true, true, false, editorButtonImageOptions1, new DevExpress.Utils.KeyShortcut(Keys.None), serializableAppearanceObject1, serializableAppearanceObject2, serializableAppearanceObject3, serializableAppearanceObject4, "", null, null, DevExpress.Utils.ToolTipAnchor.Default) });
            btnXoa.Name = "btnXoa";
            btnXoa.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.HideTextEditor;
            // 
            // svgImage
            // 
            svgImage.CustomHeight = 200;
            svgImage.Name = "svgImage";
            svgImage.SizeMode = DevExpress.XtraEditors.Controls.PictureSizeMode.Zoom;
            svgImage.SvgImageSize = new Size(100, 100);
            // 
            // groupControl2
            // 
            groupControl2.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Simple;
            groupControl2.Controls.Add(ckOpenTime);
            groupControl2.Controls.Add(cboFavoriteLevel);
            groupControl2.Controls.Add(label2);
            groupControl2.Controls.Add(cboRestaurant);
            groupControl2.Controls.Add(label1);
            groupControl2.Dock = DockStyle.Left;
            groupControl2.Location = new Point(2, 50);
            groupControl2.Margin = new Padding(3, 2, 3, 2);
            groupControl2.Name = "groupControl2";
            groupControl2.Size = new Size(313, 535);
            groupControl2.TabIndex = 3;
            groupControl2.Text = "Chức năng tìm kiếm";
            // 
            // ckOpenTime
            // 
            ckOpenTime.Location = new Point(5, 139);
            ckOpenTime.Name = "ckOpenTime";
            ckOpenTime.Properties.Appearance.Font = new Font("Tahoma", 8.5F, FontStyle.Bold, GraphicsUnit.Point);
            ckOpenTime.Properties.Appearance.Options.UseFont = true;
            ckOpenTime.Properties.Caption = "Mở cửa";
            ckOpenTime.Size = new Size(75, 20);
            ckOpenTime.TabIndex = 5;
            ckOpenTime.CheckedChanged += ckOpenTime_CheckedChanged;
            // 
            // cboFavoriteLevel
            // 
            cboFavoriteLevel.Location = new Point(4, 105);
            cboFavoriteLevel.Margin = new Padding(3, 2, 3, 2);
            cboFavoriteLevel.Name = "cboFavoriteLevel";
            cboFavoriteLevel.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] { new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo) });
            cboFavoriteLevel.Size = new Size(302, 20);
            cboFavoriteLevel.TabIndex = 3;
            cboFavoriteLevel.EditValueChanged += cboFavoriteLevel_EditValueChanged;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Tahoma", 8.25F, FontStyle.Bold, GraphicsUnit.Point);
            label2.Location = new Point(5, 85);
            label2.Name = "label2";
            label2.Size = new Size(59, 13);
            label2.TabIndex = 2;
            label2.Text = "Xếp hạng";
            // 
            // cboRestaurant
            // 
            cboRestaurant.Location = new Point(5, 58);
            cboRestaurant.Margin = new Padding(3, 2, 3, 2);
            cboRestaurant.Name = "cboRestaurant";
            cboRestaurant.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] { new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo) });
            cboRestaurant.Size = new Size(302, 20);
            cboRestaurant.TabIndex = 1;
            cboRestaurant.EditValueChanged += cboRestaurant_EditValueChanged;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Tahoma", 8.25F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(4, 36);
            label1.Name = "label1";
            label1.Size = new Size(59, 13);
            label1.TabIndex = 0;
            label1.Text = "Nhà hàng";
            // 
            // toastNotificationsManager1
            // 
            toastNotificationsManager1.ApplicationId = "69984411-3097-4cd3-abd8-0815051f5db2";
            // 
            // ucListRestaurants
            // 
            AutoScaleDimensions = new SizeF(6F, 13F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(groupControl1);
            Name = "ucListRestaurants";
            Size = new Size(1001, 587);
            Load += ucListRestaurants_Load;
            toolStrip1.ResumeLayout(false);
            toolStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)groupControl1).EndInit();
            groupControl1.ResumeLayout(false);
            groupControl1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)Data).EndInit();
            Data.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)girdRestaurant).EndInit();
            ((System.ComponentModel.ISupportInitialize)gridlayout).EndInit();
            ((System.ComponentModel.ISupportInitialize)btnSubmitData).EndInit();
            ((System.ComponentModel.ISupportInitialize)btnXoa).EndInit();
            ((System.ComponentModel.ISupportInitialize)svgImage).EndInit();
            ((System.ComponentModel.ISupportInitialize)groupControl2).EndInit();
            groupControl2.ResumeLayout(false);
            groupControl2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)ckOpenTime.Properties).EndInit();
            ((System.ComponentModel.ISupportInitialize)cboFavoriteLevel.Properties).EndInit();
            ((System.ComponentModel.ISupportInitialize)cboRestaurant.Properties).EndInit();
            ((System.ComponentModel.ISupportInitialize)toastNotificationsManager1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private OpenFileDialog openFileDialog;
        private ToolStripButton toolStripButton4;
        private ToolStrip toolStrip1;
        private ToolStripButton btnClose;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private DevExpress.XtraGrid.GridControl gridData;
        private DevExpress.XtraEditors.GroupControl groupControl1;
        private DevExpress.XtraEditors.GroupControl Data;
        private DevExpress.XtraGrid.GridControl girdRestaurant;
        private DevExpress.XtraGrid.Views.Grid.GridView gridlayout;
        private DevExpress.XtraEditors.GroupControl groupControl2;
        private DevExpress.XtraEditors.CheckEdit ckOpenTime;
        private DevExpress.XtraEditors.ComboBoxEdit cboFavoriteLevel;
        private Label label2;
        private DevExpress.XtraEditors.ComboBoxEdit cboRestaurant;
        private Label label1;
        private DevExpress.XtraEditors.Repository.RepositoryItemButtonEdit btnXoa;
        private DevExpress.XtraEditors.Repository.RepositoryItemPictureEdit svgImage;
        private DevExpress.XtraGrid.Columns.GridColumn RestaurantName;
        private DevExpress.XtraGrid.Columns.GridColumn PhoneNumber;
        private DevExpress.XtraGrid.Columns.GridColumn Image;
        private DevExpress.XtraGrid.Columns.GridColumn OpenTime;
        private DevExpress.XtraGrid.Columns.GridColumn CloseTime;
        private DevExpress.XtraGrid.Columns.GridColumn BankAccount;
        private DevExpress.XtraGrid.Columns.GridColumn BankNumber;
        private DevExpress.XtraGrid.Columns.GridColumn BankName;
        private DevExpress.XtraGrid.Columns.GridColumn Chon;
        private DevExpress.XtraEditors.Repository.RepositoryItemButtonEdit btnSubmitData;
        private ToolStripButton SubBtnAdd;
        private ToolStripSeparator toolStripSeparator2;
        private ToolStripButton SubBtnEdit;
        private ToolStripSeparator toolStripSeparator3;
        private ToolStripButton SubBtnDelete;
        private ToolStripSeparator toolStripSeparator1;
        private ToolStripButton SubBtnDeleteAll;
        private ToolStripSeparator toolStripSeparator4;
        private ToolStripButton SubBtnSearch;
        private ToolStripSeparator toolStripSeparator5;
        private ToolStripButton SubBtnSelect;
        private ToolStripSeparator toolStripSeparator6;
        private ToolStripButton SubBtnClear;
        private DevExpress.XtraBars.ToastNotifications.ToastNotificationsManager toastNotificationsManager1;
    }
}
