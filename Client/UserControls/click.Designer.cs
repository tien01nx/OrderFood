namespace Client.UserControls
{
    partial class click
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(click));
            groupControl1 = new DevExpress.XtraEditors.GroupControl();
            lbId = new Label();
            txtBankAccount = new TextBox();
            meNotes = new DevExpress.XtraEditors.MemoEdit();
            label10 = new Label();
            label9 = new Label();
            txtBankName = new DevExpress.XtraEditors.TextEdit();
            label8 = new Label();
            txtBankNumber = new DevExpress.XtraEditors.TextEdit();
            label7 = new Label();
            timeEnd = new DevExpress.XtraEditors.TimeEdit();
            label6 = new Label();
            timeStart = new DevExpress.XtraEditors.TimeEdit();
            label5 = new Label();
            label4 = new Label();
            peImage = new DevExpress.XtraEditors.PictureEdit();
            txtPhoneNumber = new DevExpress.XtraEditors.TextEdit();
            label2 = new Label();
            txtRestaurantName = new DevExpress.XtraEditors.TextEdit();
            label1 = new Label();
            groupControl2 = new DevExpress.XtraEditors.GroupControl();
            gridControl1 = new DevExpress.XtraGrid.GridControl();
            gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            RestaurantName = new DevExpress.XtraGrid.Columns.GridColumn();
            PhoneNumber = new DevExpress.XtraGrid.Columns.GridColumn();
            ImageUrl = new DevExpress.XtraGrid.Columns.GridColumn();
            OpenTime = new DevExpress.XtraGrid.Columns.GridColumn();
            CloseTime = new DevExpress.XtraGrid.Columns.GridColumn();
            BankAccount = new DevExpress.XtraGrid.Columns.GridColumn();
            BankNumber = new DevExpress.XtraGrid.Columns.GridColumn();
            BankName = new DevExpress.XtraGrid.Columns.GridColumn();
            FavoriteLevel = new DevExpress.XtraGrid.Columns.GridColumn();
            Notes = new DevExpress.XtraGrid.Columns.GridColumn();
            Xoa = new DevExpress.XtraGrid.Columns.GridColumn();
            BtnXoa = new DevExpress.XtraEditors.Repository.RepositoryItemButtonEdit();
            SubBtnAddRestaurant = new ToolStripButton();
            btnClose = new ToolStripButton();
            SubBtnClear = new ToolStrip();
            SubBtnDeleteRestaurant = new ToolStripButton();
            SubBtnSearch = new ToolStripButton();
            toolStripButton1 = new ToolStripButton();
            ((System.ComponentModel.ISupportInitialize)groupControl1).BeginInit();
            groupControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)meNotes.Properties).BeginInit();
            ((System.ComponentModel.ISupportInitialize)txtBankName.Properties).BeginInit();
            ((System.ComponentModel.ISupportInitialize)txtBankNumber.Properties).BeginInit();
            ((System.ComponentModel.ISupportInitialize)timeEnd.Properties).BeginInit();
            ((System.ComponentModel.ISupportInitialize)timeStart.Properties).BeginInit();
            ((System.ComponentModel.ISupportInitialize)peImage.Properties).BeginInit();
            ((System.ComponentModel.ISupportInitialize)txtPhoneNumber.Properties).BeginInit();
            ((System.ComponentModel.ISupportInitialize)txtRestaurantName.Properties).BeginInit();
            ((System.ComponentModel.ISupportInitialize)groupControl2).BeginInit();
            groupControl2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)gridControl1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)gridView1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)BtnXoa).BeginInit();
            SubBtnClear.SuspendLayout();
            SuspendLayout();
            // 
            // groupControl1
            // 
            groupControl1.Controls.Add(lbId);
            groupControl1.Controls.Add(txtBankAccount);
            groupControl1.Controls.Add(meNotes);
            groupControl1.Controls.Add(label10);
            groupControl1.Controls.Add(label9);
            groupControl1.Controls.Add(txtBankName);
            groupControl1.Controls.Add(label8);
            groupControl1.Controls.Add(txtBankNumber);
            groupControl1.Controls.Add(label7);
            groupControl1.Controls.Add(timeEnd);
            groupControl1.Controls.Add(label6);
            groupControl1.Controls.Add(timeStart);
            groupControl1.Controls.Add(label5);
            groupControl1.Controls.Add(label4);
            groupControl1.Controls.Add(peImage);
            groupControl1.Controls.Add(txtPhoneNumber);
            groupControl1.Controls.Add(label2);
            groupControl1.Controls.Add(txtRestaurantName);
            groupControl1.Controls.Add(label1);
            groupControl1.Dock = DockStyle.Left;
            groupControl1.Location = new Point(0, 27);
            groupControl1.Name = "groupControl1";
            groupControl1.Size = new Size(313, 560);
            groupControl1.TabIndex = 2;
            groupControl1.Text = "groupControl1";
            // 
            // lbId
            // 
            lbId.AutoSize = true;
            lbId.Location = new Point(218, 30);
            lbId.Name = "lbId";
            lbId.Size = new Size(17, 13);
            lbId.TabIndex = 41;
            lbId.Text = "Id";
            lbId.Visible = false;
            // 
            // txtBankAccount
            // 
            txtBankAccount.Location = new Point(6, 427);
            txtBankAccount.Name = "txtBankAccount";
            txtBankAccount.Size = new Size(302, 21);
            txtBankAccount.TabIndex = 40;
            // 
            // meNotes
            // 
            meNotes.Location = new Point(6, 468);
            meNotes.Margin = new Padding(3, 2, 3, 2);
            meNotes.Name = "meNotes";
            meNotes.Size = new Size(302, 62);
            meNotes.TabIndex = 39;
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Font = new Font("Tahoma", 8.25F, FontStyle.Bold, GraphicsUnit.Point);
            label10.Location = new Point(4, 451);
            label10.Name = "label10";
            label10.Size = new Size(84, 13);
            label10.TabIndex = 38;
            label10.Text = "Tên tài khoản";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Tahoma", 8.25F, FontStyle.Bold, GraphicsUnit.Point);
            label9.Location = new Point(5, 410);
            label9.Name = "label9";
            label9.Size = new Size(77, 13);
            label9.TabIndex = 37;
            label9.Text = "Số tài khoản";
            // 
            // txtBankName
            // 
            txtBankName.Location = new Point(5, 388);
            txtBankName.Margin = new Padding(3, 2, 3, 2);
            txtBankName.Name = "txtBankName";
            txtBankName.Size = new Size(303, 20);
            txtBankName.TabIndex = 36;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Tahoma", 8.25F, FontStyle.Bold, GraphicsUnit.Point);
            label8.Location = new Point(6, 369);
            label8.Name = "label8";
            label8.Size = new Size(90, 13);
            label8.TabIndex = 35;
            label8.Text = "Tên ngân hàng";
            // 
            // txtBankNumber
            // 
            txtBankNumber.Location = new Point(5, 348);
            txtBankNumber.Margin = new Padding(3, 2, 3, 2);
            txtBankNumber.Name = "txtBankNumber";
            txtBankNumber.Size = new Size(303, 20);
            txtBankNumber.TabIndex = 34;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Tahoma", 8.25F, FontStyle.Bold, GraphicsUnit.Point);
            label7.Location = new Point(6, 332);
            label7.Name = "label7";
            label7.Size = new Size(84, 13);
            label7.TabIndex = 33;
            label7.Text = "Chủ tài khoản";
            // 
            // timeEnd
            // 
            timeEnd.EditValue = new DateTime(2023, 10, 10, 0, 0, 0, 0);
            timeEnd.Location = new Point(141, 308);
            timeEnd.Margin = new Padding(3, 2, 3, 2);
            timeEnd.Name = "timeEnd";
            timeEnd.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] { new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo) });
            timeEnd.Properties.DisplayFormat.FormatString = "HH:mm";
            timeEnd.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.DateTime;
            timeEnd.Properties.EditFormat.FormatString = "HH:mm";
            timeEnd.Properties.EditFormat.FormatType = DevExpress.Utils.FormatType.DateTime;
            timeEnd.Properties.MaskSettings.Set("mask", "t");
            timeEnd.Size = new Size(87, 20);
            timeEnd.TabIndex = 32;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Tahoma", 8.25F, FontStyle.Bold, GraphicsUnit.Point);
            label6.Location = new Point(104, 310);
            label6.Name = "label6";
            label6.Size = new Size(30, 13);
            label6.TabIndex = 31;
            label6.Text = "Đến";
            // 
            // timeStart
            // 
            timeStart.EditValue = new DateTime(2023, 10, 10, 0, 0, 0, 0);
            timeStart.Location = new Point(6, 308);
            timeStart.Margin = new Padding(3, 2, 3, 2);
            timeStart.Name = "timeStart";
            timeStart.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] { new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo) });
            timeStart.Properties.DisplayFormat.FormatString = "HH:mm";
            timeStart.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.DateTime;
            timeStart.Properties.EditFormat.FormatString = "HH:mm";
            timeStart.Properties.EditFormat.FormatType = DevExpress.Utils.FormatType.DateTime;
            timeStart.Properties.MaskSettings.Set("mask", "t");
            timeStart.Size = new Size(86, 20);
            timeStart.TabIndex = 30;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Tahoma", 8.25F, FontStyle.Bold, GraphicsUnit.Point);
            label5.Location = new Point(6, 289);
            label5.Name = "label5";
            label5.Size = new Size(118, 13);
            label5.TabIndex = 29;
            label5.Text = "Thời gian hoạt động";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Tahoma", 8.25F, FontStyle.Bold, GraphicsUnit.Point);
            label4.Location = new Point(6, 105);
            label4.Name = "label4";
            label4.Size = new Size(68, 13);
            label4.TabIndex = 28;
            label4.Text = "Hình mô tả";
            // 
            // peImage
            // 
            peImage.Location = new Point(6, 124);
            peImage.Margin = new Padding(3, 2, 3, 2);
            peImage.Name = "peImage";
            peImage.Properties.ShowCameraMenuItem = DevExpress.XtraEditors.Controls.CameraMenuItemVisibility.Auto;
            peImage.Properties.SizeMode = DevExpress.XtraEditors.Controls.PictureSizeMode.Zoom;
            peImage.Size = new Size(302, 160);
            peImage.TabIndex = 27;
            peImage.MouseDown += peImage_MouseDown;
            // 
            // txtPhoneNumber
            // 
            txtPhoneNumber.Location = new Point(5, 83);
            txtPhoneNumber.Margin = new Padding(3, 2, 3, 2);
            txtPhoneNumber.Name = "txtPhoneNumber";
            txtPhoneNumber.Size = new Size(303, 20);
            txtPhoneNumber.TabIndex = 26;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Tahoma", 8.25F, FontStyle.Bold, GraphicsUnit.Point);
            label2.Location = new Point(5, 66);
            label2.Name = "label2";
            label2.Size = new Size(80, 13);
            label2.TabIndex = 25;
            label2.Text = "Số điện thoại";
            // 
            // txtRestaurantName
            // 
            txtRestaurantName.Location = new Point(5, 45);
            txtRestaurantName.Margin = new Padding(3, 2, 3, 2);
            txtRestaurantName.Name = "txtRestaurantName";
            txtRestaurantName.Size = new Size(303, 20);
            txtRestaurantName.TabIndex = 24;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Tahoma", 8.25F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(5, 30);
            label1.Name = "label1";
            label1.Size = new Size(59, 13);
            label1.TabIndex = 23;
            label1.Text = "Nhà hàng";
            // 
            // groupControl2
            // 
            groupControl2.Controls.Add(gridControl1);
            groupControl2.Dock = DockStyle.Fill;
            groupControl2.Location = new Point(313, 27);
            groupControl2.Name = "groupControl2";
            groupControl2.Size = new Size(688, 560);
            groupControl2.TabIndex = 3;
            groupControl2.Text = "groupControl2";
            // 
            // gridControl1
            // 
            gridControl1.Dock = DockStyle.Fill;
            gridControl1.Location = new Point(2, 23);
            gridControl1.MainView = gridView1;
            gridControl1.Name = "gridControl1";
            gridControl1.RepositoryItems.AddRange(new DevExpress.XtraEditors.Repository.RepositoryItem[] { BtnXoa });
            gridControl1.Size = new Size(684, 535);
            gridControl1.TabIndex = 0;
            gridControl1.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] { gridView1 });
            // 
            // gridView1
            // 
            gridView1.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] { RestaurantName, PhoneNumber, ImageUrl, OpenTime, CloseTime, BankAccount, BankNumber, BankName, FavoriteLevel, Notes, Xoa });
            gridView1.GridControl = gridControl1;
            gridView1.Name = "gridView1";
            gridView1.OptionsView.RowAutoHeight = true;
            // 
            // RestaurantName
            // 
            RestaurantName.Caption = "Tên nhà hàng";
            RestaurantName.FieldName = "RestaurantName";
            RestaurantName.Name = "RestaurantName";
            RestaurantName.Visible = true;
            RestaurantName.VisibleIndex = 0;
            // 
            // PhoneNumber
            // 
            PhoneNumber.Caption = "Số điện thoại";
            PhoneNumber.FieldName = "PhoneNumber";
            PhoneNumber.Name = "PhoneNumber";
            PhoneNumber.Visible = true;
            PhoneNumber.VisibleIndex = 1;
            // 
            // ImageUrl
            // 
            ImageUrl.Caption = "Ảnh";
            ImageUrl.FieldName = "Image";
            ImageUrl.Name = "ImageUrl";
            ImageUrl.Visible = true;
            ImageUrl.VisibleIndex = 2;
            // 
            // OpenTime
            // 
            OpenTime.Caption = "Mở cửa";
            OpenTime.FieldName = "OpenTime";
            OpenTime.Name = "OpenTime";
            OpenTime.Visible = true;
            OpenTime.VisibleIndex = 3;
            // 
            // CloseTime
            // 
            CloseTime.Caption = "Đóng cửa";
            CloseTime.FieldName = "CloseTime";
            CloseTime.Name = "CloseTime";
            CloseTime.Visible = true;
            CloseTime.VisibleIndex = 4;
            // 
            // BankAccount
            // 
            BankAccount.Caption = "Số tài khoản";
            BankAccount.FieldName = "BankAccount";
            BankAccount.Name = "BankAccount";
            BankAccount.Visible = true;
            BankAccount.VisibleIndex = 5;
            // 
            // BankNumber
            // 
            BankNumber.Caption = "Chủ tài khoản";
            BankNumber.FieldName = "BankNumber";
            BankNumber.Name = "BankNumber";
            BankNumber.Visible = true;
            BankNumber.VisibleIndex = 6;
            // 
            // BankName
            // 
            BankName.Caption = "Tên ngân hàng";
            BankName.FieldName = "BankName";
            BankName.Name = "BankName";
            BankName.Visible = true;
            BankName.VisibleIndex = 7;
            // 
            // FavoriteLevel
            // 
            FavoriteLevel.Caption = "Mức độ yêu thích";
            FavoriteLevel.FieldName = "FavoriteLevel";
            FavoriteLevel.Name = "FavoriteLevel";
            FavoriteLevel.Visible = true;
            FavoriteLevel.VisibleIndex = 8;
            // 
            // Notes
            // 
            Notes.Caption = "Ghi chú";
            Notes.FieldName = "Notes";
            Notes.Name = "Notes";
            Notes.Visible = true;
            Notes.VisibleIndex = 9;
            // 
            // Xoa
            // 
            Xoa.Caption = "Xoa";
            Xoa.ColumnEdit = BtnXoa;
            Xoa.MaxWidth = 35;
            Xoa.Name = "Xoa";
            Xoa.Visible = true;
            Xoa.VisibleIndex = 10;
            Xoa.Width = 25;
            // 
            // BtnXoa
            // 
            BtnXoa.AutoHeight = false;
            BtnXoa.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] { new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Delete) });
            BtnXoa.Name = "BtnXoa";
            BtnXoa.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.HideTextEditor;
            // 
            // SubBtnAddRestaurant
            // 
            SubBtnAddRestaurant.Image = (Image)resources.GetObject("SubBtnAddRestaurant.Image");
            SubBtnAddRestaurant.ImageTransparentColor = Color.Magenta;
            SubBtnAddRestaurant.Name = "SubBtnAddRestaurant";
            SubBtnAddRestaurant.Size = new Size(173, 24);
            SubBtnAddRestaurant.Text = "Thêm nhà hàng/  Cập nhật";
            SubBtnAddRestaurant.Click += SubBtnAddRestaurant_Click;
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
            // SubBtnClear
            // 
            SubBtnClear.ImageScalingSize = new Size(20, 20);
            SubBtnClear.Items.AddRange(new ToolStripItem[] { SubBtnAddRestaurant, btnClose, SubBtnDeleteRestaurant, SubBtnSearch, toolStripButton1 });
            SubBtnClear.Location = new Point(0, 0);
            SubBtnClear.Name = "SubBtnClear";
            SubBtnClear.Size = new Size(1001, 27);
            SubBtnClear.TabIndex = 1;
            SubBtnClear.Text = "Làm mới";
            // 
            // SubBtnDeleteRestaurant
            // 
            SubBtnDeleteRestaurant.Image = (Image)resources.GetObject("SubBtnDeleteRestaurant.Image");
            SubBtnDeleteRestaurant.ImageTransparentColor = Color.Magenta;
            SubBtnDeleteRestaurant.Name = "SubBtnDeleteRestaurant";
            SubBtnDeleteRestaurant.Size = new Size(104, 24);
            SubBtnDeleteRestaurant.Text = "Xóa nhà hàng";
            SubBtnDeleteRestaurant.Click += SubBtnDeleteRestaurant_Click;
            // 
            // SubBtnSearch
            // 
            SubBtnSearch.Image = (Image)resources.GetObject("SubBtnSearch.Image");
            SubBtnSearch.ImageTransparentColor = Color.Magenta;
            SubBtnSearch.Name = "SubBtnSearch";
            SubBtnSearch.Size = new Size(133, 24);
            SubBtnSearch.Text = "Tìm kiếm nhà hàng";
            SubBtnSearch.Click += SubBtnSearch_Click;
            // 
            // toolStripButton1
            // 
            toolStripButton1.Image = (Image)resources.GetObject("toolStripButton1.Image");
            toolStripButton1.ImageTransparentColor = Color.Magenta;
            toolStripButton1.Name = "toolStripButton1";
            toolStripButton1.Size = new Size(78, 24);
            toolStripButton1.Text = "Làm mới";
            toolStripButton1.Click += toolStripButton1_Click;
            // 
            // click
            // 
            AutoScaleDimensions = new SizeF(6F, 13F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(groupControl2);
            Controls.Add(groupControl1);
            Controls.Add(SubBtnClear);
            Name = "click";
            Size = new Size(1001, 587);
            Load += click_Load;
            ((System.ComponentModel.ISupportInitialize)groupControl1).EndInit();
            groupControl1.ResumeLayout(false);
            groupControl1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)meNotes.Properties).EndInit();
            ((System.ComponentModel.ISupportInitialize)txtBankName.Properties).EndInit();
            ((System.ComponentModel.ISupportInitialize)txtBankNumber.Properties).EndInit();
            ((System.ComponentModel.ISupportInitialize)timeEnd.Properties).EndInit();
            ((System.ComponentModel.ISupportInitialize)timeStart.Properties).EndInit();
            ((System.ComponentModel.ISupportInitialize)peImage.Properties).EndInit();
            ((System.ComponentModel.ISupportInitialize)txtPhoneNumber.Properties).EndInit();
            ((System.ComponentModel.ISupportInitialize)txtRestaurantName.Properties).EndInit();
            ((System.ComponentModel.ISupportInitialize)groupControl2).EndInit();
            groupControl2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)gridControl1).EndInit();
            ((System.ComponentModel.ISupportInitialize)gridView1).EndInit();
            ((System.ComponentModel.ISupportInitialize)BtnXoa).EndInit();
            SubBtnClear.ResumeLayout(false);
            SubBtnClear.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ToolStrip SubBtnClear;
        private ToolStripButton SubBtnAddRestaurant;
        private ToolStripButton btnClose;
        private DevExpress.XtraEditors.GroupControl groupControl1;
        private DevExpress.XtraEditors.GroupControl groupControl2;
        private DevExpress.XtraGrid.GridControl gridControl1;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
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
        private DevExpress.XtraEditors.Repository.RepositoryItemButtonEdit BtnXoa;
        private Label lbId;
        private TextBox txtBankAccount;
        private DevExpress.XtraEditors.MemoEdit meNotes;
        private Label label10;
        private Label label9;
        private DevExpress.XtraEditors.TextEdit txtBankName;
        private Label label8;
        private DevExpress.XtraEditors.TextEdit txtBankNumber;
        private Label label7;
        private DevExpress.XtraEditors.TimeEdit timeEnd;
        private Label label6;
        private DevExpress.XtraEditors.TimeEdit timeStart;
        private Label label5;
        private Label label4;
        private DevExpress.XtraEditors.PictureEdit peImage;
        private DevExpress.XtraEditors.TextEdit txtPhoneNumber;
        private Label label2;
        private DevExpress.XtraEditors.TextEdit txtRestaurantName;
        private Label label1;
        private ToolStripButton SubBtnDeleteRestaurant;
        private ToolStripButton SubBtnSearch;
        private ToolStripButton toolStripButton1;
    }
}
