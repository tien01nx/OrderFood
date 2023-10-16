namespace Client.UserControls
{
    partial class ucRestaurant
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ucRestaurant));
            groupControl1 = new DevExpress.XtraEditors.GroupControl();
            groupControl2 = new DevExpress.XtraEditors.GroupControl();
            Id = new DevExpress.XtraEditors.LabelControl();
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
            toolStrip1 = new ToolStrip();
            SubbtnAdd = new ToolStripButton();
            SubBtnClose = new ToolStripButton();
            SubBtnClear = new ToolStripButton();
            barAndDockingController1 = new DevExpress.XtraBars.BarAndDockingController(components);
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
            ((System.ComponentModel.ISupportInitialize)barAndDockingController1).BeginInit();
            SuspendLayout();
            // 
            // groupControl1
            // 
            groupControl1.Controls.Add(groupControl2);
            groupControl1.Controls.Add(toolStrip1);
            groupControl1.Dock = DockStyle.Fill;
            groupControl1.Location = new Point(0, 0);
            groupControl1.Name = "groupControl1";
            groupControl1.Size = new Size(1001, 587);
            groupControl1.TabIndex = 1;
            groupControl1.Text = "CHỨC NĂNG DANH MỤC";
            // 
            // groupControl2
            // 
            groupControl2.Controls.Add(Id);
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
            groupControl2.Controls.Add(txtPhoneNumber);
            groupControl2.Controls.Add(label2);
            groupControl2.Controls.Add(txtRestaurantName);
            groupControl2.Controls.Add(label1);
            groupControl2.Dock = DockStyle.Fill;
            groupControl2.Location = new Point(2, 48);
            groupControl2.Name = "groupControl2";
            groupControl2.Size = new Size(997, 537);
            groupControl2.TabIndex = 1;
            groupControl2.Text = "CÁC TRƯỜNG THÔNG TIN";
            // 
            // Id
            // 
            Id.Location = new Point(263, 143);
            Id.Name = "Id";
            Id.Size = new Size(10, 13);
            Id.TabIndex = 77;
            Id.Text = "Id";
            Id.Visible = false;
            // 
            // txtBankAccount
            // 
            txtBankAccount.Location = new Point(383, 415);
            txtBankAccount.Name = "txtBankAccount";
            txtBankAccount.Size = new Size(302, 21);
            txtBankAccount.TabIndex = 76;
            // 
            // meNotes
            // 
            meNotes.Location = new Point(383, 456);
            meNotes.Margin = new Padding(3, 2, 3, 2);
            meNotes.Name = "meNotes";
            meNotes.Size = new Size(302, 62);
            meNotes.TabIndex = 75;
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Font = new Font("Tahoma", 8.25F, FontStyle.Bold, GraphicsUnit.Point);
            label10.Location = new Point(262, 458);
            label10.Name = "label10";
            label10.Size = new Size(48, 13);
            label10.TabIndex = 74;
            label10.Text = "Ghi chú";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Tahoma", 8.25F, FontStyle.Bold, GraphicsUnit.Point);
            label9.Location = new Point(262, 418);
            label9.Name = "label9";
            label9.Size = new Size(77, 13);
            label9.TabIndex = 73;
            label9.Text = "Số tài khoản";
            // 
            // txtBankName
            // 
            txtBankName.Location = new Point(382, 376);
            txtBankName.Margin = new Padding(3, 2, 3, 2);
            txtBankName.Name = "txtBankName";
            txtBankName.Size = new Size(303, 20);
            txtBankName.TabIndex = 72;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Tahoma", 8.25F, FontStyle.Bold, GraphicsUnit.Point);
            label8.Location = new Point(262, 379);
            label8.Name = "label8";
            label8.Size = new Size(90, 13);
            label8.TabIndex = 71;
            label8.Text = "Tên ngân hàng";
            // 
            // txtBankNumber
            // 
            txtBankNumber.Location = new Point(382, 336);
            txtBankNumber.Margin = new Padding(3, 2, 3, 2);
            txtBankNumber.Name = "txtBankNumber";
            txtBankNumber.Size = new Size(303, 20);
            txtBankNumber.TabIndex = 70;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Tahoma", 8.25F, FontStyle.Bold, GraphicsUnit.Point);
            label7.Location = new Point(262, 339);
            label7.Name = "label7";
            label7.Size = new Size(84, 13);
            label7.TabIndex = 69;
            label7.Text = "Chủ tài khoản";
            // 
            // timeEnd
            // 
            timeEnd.EditValue = new DateTime(2023, 10, 10, 0, 0, 0, 0);
            timeEnd.Location = new Point(518, 296);
            timeEnd.Margin = new Padding(3, 2, 3, 2);
            timeEnd.Name = "timeEnd";
            timeEnd.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] { new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo) });
            timeEnd.Properties.DisplayFormat.FormatString = "HH:mm";
            timeEnd.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.DateTime;
            timeEnd.Properties.EditFormat.FormatString = "HH:mm";
            timeEnd.Properties.EditFormat.FormatType = DevExpress.Utils.FormatType.DateTime;
            timeEnd.Properties.MaskSettings.Set("mask", "t");
            timeEnd.Size = new Size(87, 20);
            timeEnd.TabIndex = 68;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Tahoma", 8.25F, FontStyle.Bold, GraphicsUnit.Point);
            label6.Location = new Point(482, 299);
            label6.Name = "label6";
            label6.Size = new Size(30, 13);
            label6.TabIndex = 67;
            label6.Text = "Đến";
            // 
            // timeStart
            // 
            timeStart.EditValue = new DateTime(2023, 10, 10, 0, 0, 0, 0);
            timeStart.Location = new Point(383, 296);
            timeStart.Margin = new Padding(3, 2, 3, 2);
            timeStart.Name = "timeStart";
            timeStart.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] { new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo) });
            timeStart.Properties.DisplayFormat.FormatString = "HH:mm";
            timeStart.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.DateTime;
            timeStart.Properties.EditFormat.FormatString = "HH:mm";
            timeStart.Properties.EditFormat.FormatType = DevExpress.Utils.FormatType.DateTime;
            timeStart.Properties.MaskSettings.Set("mask", "t");
            timeStart.Size = new Size(86, 20);
            timeStart.TabIndex = 66;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Tahoma", 8.25F, FontStyle.Bold, GraphicsUnit.Point);
            label5.Location = new Point(262, 299);
            label5.Name = "label5";
            label5.Size = new Size(118, 13);
            label5.TabIndex = 65;
            label5.Text = "Thời gian hoạt động";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Tahoma", 8.25F, FontStyle.Bold, GraphicsUnit.Point);
            label4.Location = new Point(262, 112);
            label4.Name = "label4";
            label4.Size = new Size(68, 13);
            label4.TabIndex = 64;
            label4.Text = "Hình mô tả";
            // 
            // peImage
            // 
            peImage.Location = new Point(383, 112);
            peImage.Margin = new Padding(3, 2, 3, 2);
            peImage.Name = "peImage";
            peImage.Properties.ShowCameraMenuItem = DevExpress.XtraEditors.Controls.CameraMenuItemVisibility.Auto;
            peImage.Properties.SizeMode = DevExpress.XtraEditors.Controls.PictureSizeMode.Zoom;
            peImage.Size = new Size(302, 160);
            peImage.TabIndex = 63;
            peImage.EditValueChanged += peImage_EditValueChanged;
            peImage.MouseDown += peImage_MouseDown;
            // 
            // txtPhoneNumber
            // 
            txtPhoneNumber.Location = new Point(382, 71);
            txtPhoneNumber.Margin = new Padding(3, 2, 3, 2);
            txtPhoneNumber.Name = "txtPhoneNumber";
            txtPhoneNumber.Size = new Size(303, 20);
            txtPhoneNumber.TabIndex = 62;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Tahoma", 8.25F, FontStyle.Bold, GraphicsUnit.Point);
            label2.Location = new Point(262, 78);
            label2.Name = "label2";
            label2.Size = new Size(80, 13);
            label2.TabIndex = 61;
            label2.Text = "Số điện thoại";
            // 
            // txtRestaurantName
            // 
            txtRestaurantName.Location = new Point(382, 33);
            txtRestaurantName.Margin = new Padding(3, 2, 3, 2);
            txtRestaurantName.Name = "txtRestaurantName";
            txtRestaurantName.Size = new Size(303, 20);
            txtRestaurantName.TabIndex = 60;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Tahoma", 8.25F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(262, 40);
            label1.Name = "label1";
            label1.Size = new Size(59, 13);
            label1.TabIndex = 59;
            label1.Text = "Nhà hàng";
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
            // barAndDockingController1
            // 
            barAndDockingController1.PropertiesBar.AllowLinkLighting = false;
            // 
            // ucRestaurant
            // 
            AutoScaleDimensions = new SizeF(6F, 13F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(groupControl1);
            Name = "ucRestaurant";
            Size = new Size(1001, 587);
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
            ((System.ComponentModel.ISupportInitialize)barAndDockingController1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private DevExpress.XtraEditors.GroupControl groupControl1;
        private ToolStrip toolStrip1;
        private ToolStripButton SubbtnAdd;
        private ToolStripButton SubBtnClose;
        private ToolStripButton SubBtnClear;
        private DevExpress.XtraEditors.GroupControl groupControl2;
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
        private DevExpress.XtraBars.BarAndDockingController barAndDockingController1;
        private DevExpress.XtraEditors.LabelControl Id;
    }
}
