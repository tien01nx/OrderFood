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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ucListRestaurants));
            DevExpress.XtraEditors.Controls.EditorButtonImageOptions editorButtonImageOptions1 = new DevExpress.XtraEditors.Controls.EditorButtonImageOptions();
            DevExpress.Utils.SerializableAppearanceObject serializableAppearanceObject1 = new DevExpress.Utils.SerializableAppearanceObject();
            DevExpress.Utils.SerializableAppearanceObject serializableAppearanceObject2 = new DevExpress.Utils.SerializableAppearanceObject();
            DevExpress.Utils.SerializableAppearanceObject serializableAppearanceObject3 = new DevExpress.Utils.SerializableAppearanceObject();
            DevExpress.Utils.SerializableAppearanceObject serializableAppearanceObject4 = new DevExpress.Utils.SerializableAppearanceObject();
            openFileDialog = new OpenFileDialog();
            btnUcProduct = new ToolStripButton();
            toolStrip1 = new ToolStrip();
            btnClose = new ToolStripButton();
            groupControl1 = new DevExpress.XtraEditors.GroupControl();
            Data = new DevExpress.XtraEditors.GroupControl();
            girdRestaurant = new DevExpress.XtraGrid.GridControl();
            gridView2 = new DevExpress.XtraGrid.Views.Grid.GridView();
            RestaurantName = new DevExpress.XtraGrid.Columns.GridColumn();
            PhoneNumber = new DevExpress.XtraGrid.Columns.GridColumn();
            ImageUrl = new DevExpress.XtraGrid.Columns.GridColumn();
            svgImage = new DevExpress.XtraEditors.Repository.RepositoryItemPictureEdit();
            OpenTime = new DevExpress.XtraGrid.Columns.GridColumn();
            CloseTime = new DevExpress.XtraGrid.Columns.GridColumn();
            BankAccount = new DevExpress.XtraGrid.Columns.GridColumn();
            BankNumber = new DevExpress.XtraGrid.Columns.GridColumn();
            BankName = new DevExpress.XtraGrid.Columns.GridColumn();
            FavoriteLevel = new DevExpress.XtraGrid.Columns.GridColumn();
            Notes = new DevExpress.XtraGrid.Columns.GridColumn();
            Xoa = new DevExpress.XtraGrid.Columns.GridColumn();
            btnXoa = new DevExpress.XtraEditors.Repository.RepositoryItemButtonEdit();
            groupControl2 = new DevExpress.XtraEditors.GroupControl();
            ckOpenTime = new DevExpress.XtraEditors.CheckEdit();
            cboFavoriteLevel = new DevExpress.XtraEditors.ComboBoxEdit();
            label2 = new Label();
            cboRestaurant = new DevExpress.XtraEditors.ComboBoxEdit();
            label1 = new Label();
            toolStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)groupControl1).BeginInit();
            groupControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)Data).BeginInit();
            Data.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)girdRestaurant).BeginInit();
            ((System.ComponentModel.ISupportInitialize)gridView2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)svgImage).BeginInit();
            ((System.ComponentModel.ISupportInitialize)btnXoa).BeginInit();
            ((System.ComponentModel.ISupportInitialize)groupControl2).BeginInit();
            groupControl2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)ckOpenTime.Properties).BeginInit();
            ((System.ComponentModel.ISupportInitialize)cboFavoriteLevel.Properties).BeginInit();
            ((System.ComponentModel.ISupportInitialize)cboRestaurant.Properties).BeginInit();
            SuspendLayout();
            // 
            // openFileDialog
            // 
            openFileDialog.FileName = "openFileDialog1";
            // 
            // btnUcProduct
            // 
            btnUcProduct.Image = (Image)resources.GetObject("btnUcProduct.Image");
            btnUcProduct.ImageTransparentColor = Color.Magenta;
            btnUcProduct.Name = "btnUcProduct";
            btnUcProduct.Size = new Size(114, 24);
            btnUcProduct.Text = "Thêm nhà hàng";
            // 
            // toolStrip1
            // 
            toolStrip1.ImageScalingSize = new Size(20, 20);
            toolStrip1.Items.AddRange(new ToolStripItem[] { btnUcProduct, btnClose });
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
            girdRestaurant.MainView = gridView2;
            girdRestaurant.Name = "girdRestaurant";
            girdRestaurant.RepositoryItems.AddRange(new DevExpress.XtraEditors.Repository.RepositoryItem[] { btnXoa, svgImage });
            girdRestaurant.Size = new Size(680, 510);
            girdRestaurant.TabIndex = 0;
            girdRestaurant.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] { gridView2 });
            // 
            // gridView2
            // 
            gridView2.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] { RestaurantName, PhoneNumber, ImageUrl, OpenTime, CloseTime, BankAccount, BankNumber, BankName, FavoriteLevel, Notes, Xoa });
            gridView2.GridControl = girdRestaurant;
            gridView2.Name = "gridView2";
            gridView2.OptionsView.RowAutoHeight = true;
            // 
            // RestaurantName
            // 
            RestaurantName.Caption = "RestaurantName";
            RestaurantName.FieldName = "RestaurantName";
            RestaurantName.Name = "RestaurantName";
            RestaurantName.Visible = true;
            RestaurantName.VisibleIndex = 8;
            RestaurantName.Width = 55;
            // 
            // PhoneNumber
            // 
            PhoneNumber.Caption = "PhoneNumber";
            PhoneNumber.FieldName = "PhoneNumber";
            PhoneNumber.Name = "PhoneNumber";
            PhoneNumber.Visible = true;
            PhoneNumber.VisibleIndex = 0;
            // 
            // ImageUrl
            // 
            ImageUrl.Caption = "ImageUrl";
            ImageUrl.ColumnEdit = svgImage;
            ImageUrl.FieldName = "Image";
            ImageUrl.MaxWidth = 125;
            ImageUrl.MinWidth = 140;
            ImageUrl.Name = "ImageUrl";
            ImageUrl.OptionsColumn.FixedWidth = true;
            ImageUrl.Visible = true;
            ImageUrl.VisibleIndex = 1;
            // 
            // svgImage
            // 
            svgImage.CustomHeight = 200;
            svgImage.Name = "svgImage";
            svgImage.SizeMode = DevExpress.XtraEditors.Controls.PictureSizeMode.Zoom;
            svgImage.SvgImageSize = new Size(100, 100);
            // 
            // OpenTime
            // 
            OpenTime.Caption = "OpenTime";
            OpenTime.DisplayFormat.FormatString = "hh:mm:ss";
            OpenTime.DisplayFormat.FormatType = DevExpress.Utils.FormatType.DateTime;
            OpenTime.FieldName = "OpenTime";
            OpenTime.Name = "OpenTime";
            OpenTime.Visible = true;
            OpenTime.VisibleIndex = 2;
            OpenTime.Width = 55;
            // 
            // CloseTime
            // 
            CloseTime.Caption = "CloseTime";
            CloseTime.DisplayFormat.FormatString = "hh:mm:ss";
            CloseTime.DisplayFormat.FormatType = DevExpress.Utils.FormatType.DateTime;
            CloseTime.FieldName = "CloseTime";
            CloseTime.Name = "CloseTime";
            CloseTime.Visible = true;
            CloseTime.VisibleIndex = 3;
            CloseTime.Width = 55;
            // 
            // BankAccount
            // 
            BankAccount.Caption = "BankAccount";
            BankAccount.FieldName = "BankAccount";
            BankAccount.Name = "BankAccount";
            BankAccount.Visible = true;
            BankAccount.VisibleIndex = 4;
            BankAccount.Width = 55;
            // 
            // BankNumber
            // 
            BankNumber.Caption = "BankNumber";
            BankNumber.FieldName = "BankNumber";
            BankNumber.Name = "BankNumber";
            BankNumber.Visible = true;
            BankNumber.VisibleIndex = 5;
            BankNumber.Width = 55;
            // 
            // BankName
            // 
            BankName.Caption = "BankName";
            BankName.FieldName = "BankName";
            BankName.Name = "BankName";
            BankName.Visible = true;
            BankName.VisibleIndex = 6;
            BankName.Width = 55;
            // 
            // FavoriteLevel
            // 
            FavoriteLevel.Caption = "FavoriteLevel";
            FavoriteLevel.FieldName = "FavoriteLevel";
            FavoriteLevel.Name = "FavoriteLevel";
            FavoriteLevel.Visible = true;
            FavoriteLevel.VisibleIndex = 7;
            FavoriteLevel.Width = 55;
            // 
            // Notes
            // 
            Notes.Caption = "Notes";
            Notes.FieldName = "Notes";
            Notes.Name = "Notes";
            Notes.Visible = true;
            Notes.VisibleIndex = 9;
            Notes.Width = 55;
            // 
            // Xoa
            // 
            Xoa.Caption = "Xoa";
            Xoa.ColumnEdit = btnXoa;
            Xoa.FieldName = "Xoa";
            Xoa.Name = "Xoa";
            Xoa.Visible = true;
            Xoa.VisibleIndex = 10;
            Xoa.Width = 67;
            // 
            // btnXoa
            // 
            btnXoa.AutoHeight = false;
            editorButtonImageOptions1.Image = (Image)resources.GetObject("editorButtonImageOptions1.Image");
            btnXoa.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] { new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Glyph, "", -1, true, true, false, editorButtonImageOptions1, new DevExpress.Utils.KeyShortcut(Keys.None), serializableAppearanceObject1, serializableAppearanceObject2, serializableAppearanceObject3, serializableAppearanceObject4, "", null, null, DevExpress.Utils.ToolTipAnchor.Default) });
            btnXoa.Name = "btnXoa";
            btnXoa.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.HideTextEditor;
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
            ((System.ComponentModel.ISupportInitialize)gridView2).EndInit();
            ((System.ComponentModel.ISupportInitialize)svgImage).EndInit();
            ((System.ComponentModel.ISupportInitialize)btnXoa).EndInit();
            ((System.ComponentModel.ISupportInitialize)groupControl2).EndInit();
            groupControl2.ResumeLayout(false);
            groupControl2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)ckOpenTime.Properties).EndInit();
            ((System.ComponentModel.ISupportInitialize)cboFavoriteLevel.Properties).EndInit();
            ((System.ComponentModel.ISupportInitialize)cboRestaurant.Properties).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private OpenFileDialog openFileDialog;
        private ToolStripButton toolStripButton4;
        private ToolStripButton btnUcProduct;
        private ToolStrip toolStrip1;
        private ToolStripButton btnClose;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private DevExpress.XtraGrid.GridControl gridData;
        private DevExpress.XtraEditors.GroupControl groupControl1;
        private DevExpress.XtraEditors.GroupControl Data;
        private DevExpress.XtraGrid.GridControl girdRestaurant;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView2;
        private DevExpress.XtraEditors.GroupControl groupControl2;
        private DevExpress.XtraEditors.CheckEdit ckOpenTime;
        private DevExpress.XtraEditors.ComboBoxEdit cboFavoriteLevel;
        private Label label2;
        private DevExpress.XtraEditors.ComboBoxEdit cboRestaurant;
        private Label label1;
        private DevExpress.XtraGrid.Columns.GridColumn RestaurantName;
        private DevExpress.XtraGrid.Columns.GridColumn PhoneNumber;
        private DevExpress.XtraGrid.Columns.GridColumn ImageUrl;
        private DevExpress.XtraGrid.Columns.GridColumn OpenTime;
        private DevExpress.XtraGrid.Columns.GridColumn CloseTime;
        private DevExpress.XtraGrid.Columns.GridColumn BankAccount;
        private DevExpress.XtraGrid.Columns.GridColumn BankNumber;
        private DevExpress.XtraGrid.Columns.GridColumn BankName;
        private DevExpress.XtraGrid.Columns.GridColumn FavoriteLevel;
        private DevExpress.XtraGrid.Columns.GridColumn Notes;
        private DevExpress.XtraGrid.Columns.GridColumn Xoa;
        private DevExpress.XtraEditors.Repository.RepositoryItemButtonEdit btnXoa;
        private DevExpress.XtraEditors.Repository.RepositoryItemPictureEdit svgImage;
    }
}
