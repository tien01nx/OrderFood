namespace Client.UserControls
{
    partial class ucRestaurants
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ucRestaurants));
            repositoryItemButtonEdit1 = new DevExpress.XtraEditors.Repository.RepositoryItemButtonEdit();
            label1 = new Label();
            Data = new DevExpress.XtraEditors.GroupControl();
            girdRestaurant = new DevExpress.XtraGrid.GridControl();
            gridViewRestaurant = new DevExpress.XtraGrid.Views.Grid.GridView();
            RestaurantName = new DevExpress.XtraGrid.Columns.GridColumn();
            PhoneNumber = new DevExpress.XtraGrid.Columns.GridColumn();
            Image = new DevExpress.XtraGrid.Columns.GridColumn();
            OpenTime = new DevExpress.XtraGrid.Columns.GridColumn();
            CloseTime = new DevExpress.XtraGrid.Columns.GridColumn();
            BankAccount = new DevExpress.XtraGrid.Columns.GridColumn();
            BankNumber = new DevExpress.XtraGrid.Columns.GridColumn();
            BankName = new DevExpress.XtraGrid.Columns.GridColumn();
            Id = new DevExpress.XtraGrid.Columns.GridColumn();
            Xoa = new DevExpress.XtraGrid.Columns.GridColumn();
            clickXoa = new DevExpress.XtraEditors.Repository.RepositoryItemButtonEdit();
            groupControl1 = new DevExpress.XtraEditors.GroupControl();
            groupControl2 = new DevExpress.XtraEditors.GroupControl();
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
            label3 = new Label();
            txtPhoneNumber = new DevExpress.XtraEditors.TextEdit();
            label2 = new Label();
            txtRestaurantName = new DevExpress.XtraEditors.TextEdit();
            toolStrip1 = new ToolStrip();
            SubBtnAddRestaurant = new ToolStripButton();
            btnClose = new ToolStripButton();
            SubBtnDeleteRestaurant = new ToolStripButton();
            SubBtnClear = new ToolStripButton();
            openFileDialog = new OpenFileDialog();
            ((System.ComponentModel.ISupportInitialize)repositoryItemButtonEdit1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)Data).BeginInit();
            Data.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)girdRestaurant).BeginInit();
            ((System.ComponentModel.ISupportInitialize)gridViewRestaurant).BeginInit();
            ((System.ComponentModel.ISupportInitialize)clickXoa).BeginInit();
            ((System.ComponentModel.ISupportInitialize)groupControl1).BeginInit();
            groupControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)groupControl2).BeginInit();
            groupControl2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)meNotes.Properties).BeginInit();
            ((System.ComponentModel.ISupportInitialize)txtBankName.Properties).BeginInit();
            ((System.ComponentModel.ISupportInitialize)txtBankNumber.Properties).BeginInit();
            ((System.ComponentModel.ISupportInitialize)timeEnd.Properties).BeginInit();
            ((System.ComponentModel.ISupportInitialize)timeStart.Properties).BeginInit();
            ((System.ComponentModel.ISupportInitialize)peImage.Properties).BeginInit();
            ((System.ComponentModel.ISupportInitialize)txtPhoneNumber.Properties).BeginInit();
            ((System.ComponentModel.ISupportInitialize)txtRestaurantName.Properties).BeginInit();
            toolStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // repositoryItemButtonEdit1
            // 
            repositoryItemButtonEdit1.Name = "repositoryItemButtonEdit1";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Tahoma", 8.25F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(4, 27);
            label1.Name = "label1";
            label1.Size = new Size(59, 13);
            label1.TabIndex = 0;
            label1.Text = "Nhà hàng";
            // 
            // Data
            // 
            Data.Controls.Add(girdRestaurant);
            Data.Dock = DockStyle.Fill;
            Data.Location = new Point(315, 50);
            Data.Name = "Data";
            Data.ShowCaption = false;
            Data.Size = new Size(684, 535);
            Data.TabIndex = 4;
            Data.Text = "Danh sách nhà hàng";
            // 
            // girdRestaurant
            // 
            girdRestaurant.Dock = DockStyle.Fill;
            girdRestaurant.Location = new Point(2, 2);
            girdRestaurant.MainView = gridViewRestaurant;
            girdRestaurant.Name = "girdRestaurant";
            girdRestaurant.RepositoryItems.AddRange(new DevExpress.XtraEditors.Repository.RepositoryItem[] { clickXoa });
            girdRestaurant.Size = new Size(680, 531);
            girdRestaurant.TabIndex = 1;
            girdRestaurant.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] { gridViewRestaurant });
            // 
            // gridViewRestaurant
            // 
            gridViewRestaurant.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] { RestaurantName, PhoneNumber, Image, OpenTime, CloseTime, BankAccount, BankNumber, BankName, Id, Xoa });
            gridViewRestaurant.GridControl = girdRestaurant;
            gridViewRestaurant.Name = "gridViewRestaurant";
            gridViewRestaurant.OptionsBehavior.Editable = false;
            gridViewRestaurant.OptionsEditForm.PopupEditFormWidth = 686;
            gridViewRestaurant.OptionsView.RowAutoHeight = true;
            gridViewRestaurant.RowCellClick += gridViewRestaurant_RowCellClick;
            // 
            // RestaurantName
            // 
            RestaurantName.Caption = "Nhà hàng";
            RestaurantName.FieldName = "RestaurantName";
            RestaurantName.Name = "RestaurantName";
            RestaurantName.Visible = true;
            RestaurantName.VisibleIndex = 0;
            RestaurantName.Width = 80;
            // 
            // PhoneNumber
            // 
            PhoneNumber.Caption = "Số điện thoại";
            PhoneNumber.FieldName = "PhoneNumber";
            PhoneNumber.Name = "PhoneNumber";
            PhoneNumber.Visible = true;
            PhoneNumber.VisibleIndex = 1;
            PhoneNumber.Width = 80;
            // 
            // Image
            // 
            Image.Caption = "Hình ảnh";
            Image.FieldName = "Image";
            Image.Name = "Image";
            Image.Visible = true;
            Image.VisibleIndex = 2;
            // 
            // OpenTime
            // 
            OpenTime.Caption = "Thời gian mở cửa";
            OpenTime.FieldName = "OpenTime";
            OpenTime.Name = "OpenTime";
            OpenTime.Visible = true;
            OpenTime.VisibleIndex = 3;
            OpenTime.Width = 80;
            // 
            // CloseTime
            // 
            CloseTime.Caption = "Thời gian đóng cửa";
            CloseTime.DisplayFormat.FormatString = "HH:mm";
            CloseTime.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Custom;
            CloseTime.FieldName = "CloseTime";
            CloseTime.Name = "CloseTime";
            CloseTime.Visible = true;
            CloseTime.VisibleIndex = 4;
            CloseTime.Width = 80;
            // 
            // BankAccount
            // 
            BankAccount.Caption = "Số tài khoản";
            BankAccount.FieldName = "BankAccount";
            BankAccount.Name = "BankAccount";
            BankAccount.Visible = true;
            BankAccount.VisibleIndex = 5;
            BankAccount.Width = 80;
            // 
            // BankNumber
            // 
            BankNumber.Caption = "Chủ tài khoản";
            BankNumber.FieldName = "BankNumber";
            BankNumber.Name = "BankNumber";
            BankNumber.Visible = true;
            BankNumber.VisibleIndex = 6;
            BankNumber.Width = 80;
            // 
            // BankName
            // 
            BankName.Caption = "Tên ngân hàng";
            BankName.FieldName = "BankName";
            BankName.Name = "BankName";
            BankName.Visible = true;
            BankName.VisibleIndex = 7;
            BankName.Width = 80;
            // 
            // Id
            // 
            Id.Caption = "Id";
            Id.FieldName = "Id";
            Id.Name = "Id";
            // 
            // Xoa
            // 
            Xoa.Caption = "Xóa";
            Xoa.ColumnEdit = clickXoa;
            Xoa.Name = "Xoa";
            Xoa.Visible = true;
            Xoa.VisibleIndex = 8;
            // 
            // clickXoa
            // 
            clickXoa.AutoHeight = false;
            clickXoa.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] { new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Delete) });
            clickXoa.Name = "clickXoa";
            clickXoa.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.HideTextEditor;
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
            groupControl1.TabIndex = 2;
            groupControl1.Text = "DANH SÁCH NHÀ HÀNG";
            // 
            // groupControl2
            // 
            groupControl2.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Simple;
            groupControl2.Controls.Add(lbId);
            groupControl2.Controls.Add(txtBankAccount);
            groupControl2.Controls.Add(meNotes);
            groupControl2.Controls.Add(label10);
            groupControl2.Controls.Add(label9);
            groupControl2.Controls.Add(txtBankName);
            groupControl2.Controls.Add(label8);
            groupControl2.Controls.Add(txtBankNumber);
            groupControl2.Controls.Add(label7);
            groupControl2.Controls.Add(timeEnd);
            groupControl2.Controls.Add(label6);
            groupControl2.Controls.Add(timeStart);
            groupControl2.Controls.Add(label5);
            groupControl2.Controls.Add(label4);
            groupControl2.Controls.Add(peImage);
            groupControl2.Controls.Add(label3);
            groupControl2.Controls.Add(txtPhoneNumber);
            groupControl2.Controls.Add(label2);
            groupControl2.Controls.Add(txtRestaurantName);
            groupControl2.Controls.Add(label1);
            groupControl2.Dock = DockStyle.Left;
            groupControl2.Location = new Point(2, 50);
            groupControl2.Margin = new Padding(3, 2, 3, 2);
            groupControl2.Name = "groupControl2";
            groupControl2.Size = new Size(313, 535);
            groupControl2.TabIndex = 3;
            groupControl2.Text = "Chức năng tìm kiếm";
            // 
            // lbId
            // 
            lbId.AutoSize = true;
            lbId.Location = new Point(217, 27);
            lbId.Name = "lbId";
            lbId.Size = new Size(17, 13);
            lbId.TabIndex = 22;
            lbId.Text = "Id";
            lbId.Visible = false;
            // 
            // txtBankAccount
            // 
            txtBankAccount.Location = new Point(5, 424);
            txtBankAccount.Name = "txtBankAccount";
            txtBankAccount.Size = new Size(302, 21);
            txtBankAccount.TabIndex = 21;
            txtBankAccount.KeyPress += txtBankAccount_KeyPress;
            // 
            // meNotes
            // 
            meNotes.Location = new Point(5, 465);
            meNotes.Margin = new Padding(3, 2, 3, 2);
            meNotes.Name = "meNotes";
            meNotes.Size = new Size(302, 62);
            meNotes.TabIndex = 18;
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Font = new Font("Tahoma", 8.25F, FontStyle.Bold, GraphicsUnit.Point);
            label10.Location = new Point(3, 448);
            label10.Name = "label10";
            label10.Size = new Size(84, 13);
            label10.TabIndex = 16;
            label10.Text = "Tên tài khoản";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Tahoma", 8.25F, FontStyle.Bold, GraphicsUnit.Point);
            label9.Location = new Point(4, 407);
            label9.Name = "label9";
            label9.Size = new Size(77, 13);
            label9.TabIndex = 15;
            label9.Text = "Số tài khoản";
            // 
            // txtBankName
            // 
            txtBankName.Location = new Point(4, 385);
            txtBankName.Margin = new Padding(3, 2, 3, 2);
            txtBankName.Name = "txtBankName";
            txtBankName.Size = new Size(303, 20);
            txtBankName.TabIndex = 14;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Tahoma", 8.25F, FontStyle.Bold, GraphicsUnit.Point);
            label8.Location = new Point(5, 366);
            label8.Name = "label8";
            label8.Size = new Size(90, 13);
            label8.TabIndex = 13;
            label8.Text = "Tên ngân hàng";
            // 
            // txtBankNumber
            // 
            txtBankNumber.Location = new Point(4, 345);
            txtBankNumber.Margin = new Padding(3, 2, 3, 2);
            txtBankNumber.Name = "txtBankNumber";
            txtBankNumber.Size = new Size(303, 20);
            txtBankNumber.TabIndex = 12;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Tahoma", 8.25F, FontStyle.Bold, GraphicsUnit.Point);
            label7.Location = new Point(5, 329);
            label7.Name = "label7";
            label7.Size = new Size(84, 13);
            label7.TabIndex = 11;
            label7.Text = "Chủ tài khoản";
            // 
            // timeEnd
            // 
            timeEnd.EditValue = new DateTime(2023, 10, 10, 0, 0, 0, 0);
            timeEnd.Location = new Point(140, 305);
            timeEnd.Margin = new Padding(3, 2, 3, 2);
            timeEnd.Name = "timeEnd";
            timeEnd.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] { new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo) });
            timeEnd.Properties.DisplayFormat.FormatString = "HH:mm";
            timeEnd.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.DateTime;
            timeEnd.Properties.EditFormat.FormatString = "HH:mm";
            timeEnd.Properties.EditFormat.FormatType = DevExpress.Utils.FormatType.DateTime;
            timeEnd.Properties.MaskSettings.Set("mask", "t");
            timeEnd.Size = new Size(87, 20);
            timeEnd.TabIndex = 10;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Tahoma", 8.25F, FontStyle.Bold, GraphicsUnit.Point);
            label6.Location = new Point(103, 307);
            label6.Name = "label6";
            label6.Size = new Size(30, 13);
            label6.TabIndex = 9;
            label6.Text = "Đến";
            // 
            // timeStart
            // 
            timeStart.EditValue = new DateTime(2023, 10, 10, 0, 0, 0, 0);
            timeStart.Location = new Point(5, 305);
            timeStart.Margin = new Padding(3, 2, 3, 2);
            timeStart.Name = "timeStart";
            timeStart.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] { new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo) });
            timeStart.Properties.DisplayFormat.FormatString = "HH:mm";
            timeStart.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.DateTime;
            timeStart.Properties.EditFormat.FormatString = "HH:mm";
            timeStart.Properties.EditFormat.FormatType = DevExpress.Utils.FormatType.DateTime;
            timeStart.Properties.MaskSettings.Set("mask", "t");
            timeStart.Size = new Size(86, 20);
            timeStart.TabIndex = 8;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Tahoma", 8.25F, FontStyle.Bold, GraphicsUnit.Point);
            label5.Location = new Point(5, 286);
            label5.Name = "label5";
            label5.Size = new Size(118, 13);
            label5.TabIndex = 7;
            label5.Text = "Thời gian hoạt động";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Tahoma", 8.25F, FontStyle.Bold, GraphicsUnit.Point);
            label4.Location = new Point(5, 102);
            label4.Name = "label4";
            label4.Size = new Size(68, 13);
            label4.TabIndex = 6;
            label4.Text = "Hình mô tả";
            // 
            // peImage
            // 
            peImage.Location = new Point(5, 121);
            peImage.Margin = new Padding(3, 2, 3, 2);
            peImage.Name = "peImage";
            peImage.Properties.ShowCameraMenuItem = DevExpress.XtraEditors.Controls.CameraMenuItemVisibility.Auto;
            peImage.Properties.SizeMode = DevExpress.XtraEditors.Controls.PictureSizeMode.Zoom;
            peImage.Size = new Size(302, 160);
            peImage.TabIndex = 5;
            peImage.MouseDown += peImage_MouseDown;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Tahoma", 8.25F, FontStyle.Bold, GraphicsUnit.Point);
            label3.Location = new Point(5, 108);
            label3.Name = "label3";
            label3.Size = new Size(0, 13);
            label3.TabIndex = 4;
            // 
            // txtPhoneNumber
            // 
            txtPhoneNumber.Location = new Point(4, 80);
            txtPhoneNumber.Margin = new Padding(3, 2, 3, 2);
            txtPhoneNumber.Name = "txtPhoneNumber";
            txtPhoneNumber.Size = new Size(303, 20);
            txtPhoneNumber.TabIndex = 3;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Tahoma", 8.25F, FontStyle.Bold, GraphicsUnit.Point);
            label2.Location = new Point(4, 63);
            label2.Name = "label2";
            label2.Size = new Size(80, 13);
            label2.TabIndex = 2;
            label2.Text = "Số điện thoại";
            // 
            // txtRestaurantName
            // 
            txtRestaurantName.Location = new Point(4, 42);
            txtRestaurantName.Margin = new Padding(3, 2, 3, 2);
            txtRestaurantName.Name = "txtRestaurantName";
            txtRestaurantName.Size = new Size(303, 20);
            txtRestaurantName.TabIndex = 1;
            // 
            // toolStrip1
            // 
            toolStrip1.ImageScalingSize = new Size(20, 20);
            toolStrip1.Items.AddRange(new ToolStripItem[] { SubBtnAddRestaurant, btnClose, SubBtnDeleteRestaurant, SubBtnClear });
            toolStrip1.Location = new Point(2, 23);
            toolStrip1.Name = "toolStrip1";
            toolStrip1.Size = new Size(997, 27);
            toolStrip1.TabIndex = 0;
            toolStrip1.Text = "toolStrip1";
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
            // SubBtnDeleteRestaurant
            // 
            SubBtnDeleteRestaurant.Image = (Image)resources.GetObject("SubBtnDeleteRestaurant.Image");
            SubBtnDeleteRestaurant.ImageTransparentColor = Color.Magenta;
            SubBtnDeleteRestaurant.Name = "SubBtnDeleteRestaurant";
            SubBtnDeleteRestaurant.Size = new Size(104, 24);
            SubBtnDeleteRestaurant.Text = "Xóa nhà hàng";
            SubBtnDeleteRestaurant.Click += SubBtnDeleteRestaurant_Click;
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
            // openFileDialog
            // 
            openFileDialog.FileName = "openFileDialog1";
            // 
            // ucRestaurants
            // 
            AutoScaleDimensions = new SizeF(6F, 13F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(groupControl1);
            Name = "ucRestaurants";
            Size = new Size(1001, 587);
            Load += ucRestaurants_Load;
            ((System.ComponentModel.ISupportInitialize)repositoryItemButtonEdit1).EndInit();
            ((System.ComponentModel.ISupportInitialize)Data).EndInit();
            Data.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)girdRestaurant).EndInit();
            ((System.ComponentModel.ISupportInitialize)gridViewRestaurant).EndInit();
            ((System.ComponentModel.ISupportInitialize)clickXoa).EndInit();
            ((System.ComponentModel.ISupportInitialize)groupControl1).EndInit();
            groupControl1.ResumeLayout(false);
            groupControl1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)groupControl2).EndInit();
            groupControl2.ResumeLayout(false);
            groupControl2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)meNotes.Properties).EndInit();
            ((System.ComponentModel.ISupportInitialize)txtBankName.Properties).EndInit();
            ((System.ComponentModel.ISupportInitialize)txtBankNumber.Properties).EndInit();
            ((System.ComponentModel.ISupportInitialize)timeEnd.Properties).EndInit();
            ((System.ComponentModel.ISupportInitialize)timeStart.Properties).EndInit();
            ((System.ComponentModel.ISupportInitialize)peImage.Properties).EndInit();
            ((System.ComponentModel.ISupportInitialize)txtPhoneNumber.Properties).EndInit();
            ((System.ComponentModel.ISupportInitialize)txtRestaurantName.Properties).EndInit();
            toolStrip1.ResumeLayout(false);
            toolStrip1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion
        private Label label1;
        private DevExpress.XtraEditors.GroupControl Data;
        private DevExpress.XtraEditors.GroupControl groupControl1;
        private DevExpress.XtraEditors.GroupControl groupControl2;
        private ToolStrip toolStrip1;
        private ToolStripButton SubBtnAddRestaurant;
        private ToolStripButton btnClose;
        private OpenFileDialog openFileDialog;
        private DevExpress.XtraEditors.TextEdit txtPhoneNumber;
        private Label label2;
        private DevExpress.XtraEditors.TextEdit txtRestaurantName;
        private Label label3;
        private Label label4;
        private DevExpress.XtraEditors.PictureEdit peImage;
        private Label label5;
        private Label label6;
        private DevExpress.XtraEditors.TimeEdit timeStart;
        private DevExpress.XtraEditors.TimeEdit timeEnd;
        private Label label7;
        private DevExpress.XtraEditors.TextEdit txtBankNumber;
        private Label label8;
        private Label label9;
        private DevExpress.XtraEditors.TextEdit txtBankName;
        private Label label10;
        private DevExpress.XtraEditors.MemoEdit meNotes;
        private ToolStripButton SubBtnDeleteRestaurant;
        private TextBox txtBankAccount;
        private DevExpress.XtraGrid.GridControl girdRestaurant;
        private DevExpress.XtraGrid.Views.Grid.GridView gridViewRestaurant;
        private DevExpress.XtraGrid.Columns.GridColumn RestaurantName;
        private DevExpress.XtraGrid.Columns.GridColumn PhoneNumber;
        private DevExpress.XtraGrid.Columns.GridColumn Image;
        private DevExpress.XtraGrid.Columns.GridColumn OpenTime;
        private DevExpress.XtraGrid.Columns.GridColumn CloseTime;
        private DevExpress.XtraGrid.Columns.GridColumn BankAccount;
        private DevExpress.XtraGrid.Columns.GridColumn BankNumber;
        private DevExpress.XtraGrid.Columns.GridColumn BankName;
        private DevExpress.XtraGrid.Columns.GridColumn Id;
        private Label lbId;
        private ToolStripButton SubBtnClear;
        private DevExpress.XtraEditors.Repository.RepositoryItemButtonEdit repositoryItemButtonEdit1;
        private DevExpress.XtraGrid.Columns.GridColumn Xoa;
        private DevExpress.XtraEditors.Repository.RepositoryItemButtonEdit clickXoa;
    }
}
