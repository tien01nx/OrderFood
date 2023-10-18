namespace Client.UserControls
{
    partial class ucUser
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ucUser));
            SubBtnClear = new ToolStripButton();
            SubbtnAdd = new ToolStripButton();
            RestaurantId = new DevExpress.XtraEditors.LabelControl();
            CategoryId = new DevExpress.XtraEditors.LabelControl();
            id = new DevExpress.XtraEditors.LabelControl();
            label8 = new Label();
            label7 = new Label();
            toolStrip1 = new ToolStrip();
            SubBtnClose = new ToolStripButton();
            label4 = new Label();
            txtUserName = new DevExpress.XtraEditors.TextEdit();
            label3 = new Label();
            label1 = new Label();
            groupControl1 = new DevExpress.XtraEditors.GroupControl();
            groupControl2 = new DevExpress.XtraEditors.GroupControl();
            txtPhoneNumber = new DevExpress.XtraEditors.TextEdit();
            label9 = new Label();
            mdApartmentNumber = new DevExpress.XtraEditors.MemoEdit();
            txtAddress = new DevExpress.XtraEditors.TextEdit();
            dateBirthday = new DevExpress.XtraEditors.DateEdit();
            label2 = new Label();
            ckNu = new DevExpress.XtraEditors.CheckEdit();
            ckNam = new DevExpress.XtraEditors.CheckEdit();
            txtFullName = new DevExpress.XtraEditors.TextEdit();
            txtEmail = new DevExpress.XtraEditors.TextEdit();
            label5 = new Label();
            label6 = new Label();
            txtPassword = new DevExpress.XtraEditors.TextEdit();
            toolStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)txtUserName.Properties).BeginInit();
            ((System.ComponentModel.ISupportInitialize)groupControl1).BeginInit();
            groupControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)groupControl2).BeginInit();
            groupControl2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)txtPhoneNumber.Properties).BeginInit();
            ((System.ComponentModel.ISupportInitialize)mdApartmentNumber.Properties).BeginInit();
            ((System.ComponentModel.ISupportInitialize)txtAddress.Properties).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dateBirthday.Properties.CalendarTimeProperties).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dateBirthday.Properties).BeginInit();
            ((System.ComponentModel.ISupportInitialize)ckNu.Properties).BeginInit();
            ((System.ComponentModel.ISupportInitialize)ckNam.Properties).BeginInit();
            ((System.ComponentModel.ISupportInitialize)txtFullName.Properties).BeginInit();
            ((System.ComponentModel.ISupportInitialize)txtEmail.Properties).BeginInit();
            ((System.ComponentModel.ISupportInitialize)txtPassword.Properties).BeginInit();
            SuspendLayout();
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
            // SubbtnAdd
            // 
            SubbtnAdd.Image = (Image)resources.GetObject("SubbtnAdd.Image");
            SubbtnAdd.ImageTransparentColor = Color.Magenta;
            SubbtnAdd.Name = "SubbtnAdd";
            SubbtnAdd.Size = new Size(47, 22);
            SubbtnAdd.Text = "Lưu";
            SubbtnAdd.Click += SubbtnAdd_Click;
            // 
            // RestaurantId
            // 
            RestaurantId.Location = new Point(317, 319);
            RestaurantId.Name = "RestaurantId";
            RestaurantId.Size = new Size(0, 13);
            RestaurantId.TabIndex = 22;
            RestaurantId.Visible = false;
            // 
            // CategoryId
            // 
            CategoryId.Location = new Point(295, 300);
            CategoryId.Name = "CategoryId";
            CategoryId.Size = new Size(0, 13);
            CategoryId.TabIndex = 21;
            CategoryId.Visible = false;
            // 
            // id
            // 
            id.Location = new Point(295, 271);
            id.Name = "id";
            id.Size = new Size(0, 13);
            id.TabIndex = 20;
            id.Visible = false;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Tahoma", 8.25F, FontStyle.Bold, GraphicsUnit.Point);
            label8.Location = new Point(287, 367);
            label8.Name = "label8";
            label8.Size = new Size(45, 13);
            label8.TabIndex = 14;
            label8.Text = "Số nhà";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Tahoma", 8.25F, FontStyle.Bold, GraphicsUnit.Point);
            label7.Location = new Point(287, 319);
            label7.Name = "label7";
            label7.Size = new Size(45, 13);
            label7.TabIndex = 10;
            label7.Text = "Địa chỉ";
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
            // SubBtnClose
            // 
            SubBtnClose.Alignment = ToolStripItemAlignment.Right;
            SubBtnClose.Image = (Image)resources.GetObject("SubBtnClose.Image");
            SubBtnClose.ImageTransparentColor = Color.Magenta;
            SubBtnClose.Name = "SubBtnClose";
            SubBtnClose.Size = new Size(56, 22);
            SubBtnClose.Text = "Đóng";
            SubBtnClose.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Tahoma", 8.25F, FontStyle.Bold, GraphicsUnit.Point);
            label4.Location = new Point(287, 247);
            label4.Name = "label4";
            label4.Size = new Size(53, 13);
            label4.TabIndex = 5;
            label4.Text = "Giới tính";
            // 
            // txtUserName
            // 
            txtUserName.Location = new Point(406, 70);
            txtUserName.Name = "txtUserName";
            txtUserName.Size = new Size(300, 20);
            txtUserName.TabIndex = 3;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Tahoma", 8.25F, FontStyle.Bold, GraphicsUnit.Point);
            label3.Location = new Point(287, 111);
            label3.Name = "label3";
            label3.Size = new Size(37, 13);
            label3.TabIndex = 2;
            label3.Text = "Email";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Tahoma", 8.25F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(287, 77);
            label1.Name = "label1";
            label1.Size = new Size(65, 13);
            label1.TabIndex = 0;
            label1.Text = "UserName";
            // 
            // groupControl1
            // 
            groupControl1.Controls.Add(groupControl2);
            groupControl1.Controls.Add(toolStrip1);
            groupControl1.Dock = DockStyle.Fill;
            groupControl1.Location = new Point(0, 0);
            groupControl1.Name = "groupControl1";
            groupControl1.Size = new Size(1001, 587);
            groupControl1.TabIndex = 2;
            groupControl1.Text = "CHỨC NĂNG NGƯỜI DÙNG";
            // 
            // groupControl2
            // 
            groupControl2.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Simple;
            groupControl2.Controls.Add(txtPhoneNumber);
            groupControl2.Controls.Add(label9);
            groupControl2.Controls.Add(txtPassword);
            groupControl2.Controls.Add(label6);
            groupControl2.Controls.Add(mdApartmentNumber);
            groupControl2.Controls.Add(txtAddress);
            groupControl2.Controls.Add(dateBirthday);
            groupControl2.Controls.Add(label2);
            groupControl2.Controls.Add(ckNu);
            groupControl2.Controls.Add(ckNam);
            groupControl2.Controls.Add(txtFullName);
            groupControl2.Controls.Add(txtEmail);
            groupControl2.Controls.Add(RestaurantId);
            groupControl2.Controls.Add(CategoryId);
            groupControl2.Controls.Add(id);
            groupControl2.Controls.Add(label8);
            groupControl2.Controls.Add(label7);
            groupControl2.Controls.Add(label5);
            groupControl2.Controls.Add(label4);
            groupControl2.Controls.Add(txtUserName);
            groupControl2.Controls.Add(label3);
            groupControl2.Controls.Add(label1);
            groupControl2.Dock = DockStyle.Fill;
            groupControl2.Location = new Point(2, 48);
            groupControl2.Margin = new Padding(3, 2, 3, 2);
            groupControl2.Name = "groupControl2";
            groupControl2.Size = new Size(997, 537);
            groupControl2.TabIndex = 3;
            groupControl2.Text = "THÔNG TIN NGƯỜI DÙNG";
            // 
            // txtPhoneNumber
            // 
            txtPhoneNumber.Location = new Point(406, 217);
            txtPhoneNumber.Name = "txtPhoneNumber";
            txtPhoneNumber.Size = new Size(300, 20);
            txtPhoneNumber.TabIndex = 38;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Tahoma", 8.25F, FontStyle.Bold, GraphicsUnit.Point);
            label9.ForeColor = Color.FromArgb(40, 40, 40);
            label9.Location = new Point(287, 220);
            label9.Name = "label9";
            label9.Size = new Size(80, 13);
            label9.TabIndex = 37;
            label9.Text = "Số điện thoại";
            // 
            // mdApartmentNumber
            // 
            mdApartmentNumber.Location = new Point(411, 354);
            mdApartmentNumber.Name = "mdApartmentNumber";
            mdApartmentNumber.Size = new Size(300, 70);
            mdApartmentNumber.TabIndex = 34;
            // 
            // txtAddress
            // 
            txtAddress.Location = new Point(411, 316);
            txtAddress.Name = "txtAddress";
            txtAddress.Size = new Size(300, 20);
            txtAddress.TabIndex = 33;
            // 
            // dateBirthday
            // 
            dateBirthday.EditValue = null;
            dateBirthday.Location = new Point(413, 277);
            dateBirthday.Name = "dateBirthday";
            dateBirthday.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] { new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo) });
            dateBirthday.Properties.CalendarTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] { new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo) });
            dateBirthday.Size = new Size(119, 20);
            dateBirthday.TabIndex = 32;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Tahoma", 8.25F, FontStyle.Bold, GraphicsUnit.Point);
            label2.Location = new Point(287, 284);
            label2.Name = "label2";
            label2.Size = new Size(61, 13);
            label2.TabIndex = 31;
            label2.Text = "Ngày sinh";
            // 
            // ckNu
            // 
            ckNu.Location = new Point(571, 244);
            ckNu.Name = "ckNu";
            ckNu.Properties.Caption = "Nữ";
            ckNu.Size = new Size(75, 20);
            ckNu.TabIndex = 30;
            // 
            // ckNam
            // 
            ckNam.Location = new Point(438, 244);
            ckNam.Name = "ckNam";
            ckNam.Properties.Caption = "Nam";
            ckNam.Size = new Size(75, 20);
            ckNam.TabIndex = 29;
            // 
            // txtFullName
            // 
            txtFullName.Location = new Point(406, 178);
            txtFullName.Name = "txtFullName";
            txtFullName.Size = new Size(300, 20);
            txtFullName.TabIndex = 28;
            // 
            // txtEmail
            // 
            txtEmail.Location = new Point(406, 104);
            txtEmail.Name = "txtEmail";
            txtEmail.Size = new Size(300, 20);
            txtEmail.TabIndex = 27;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Tahoma", 8.25F, FontStyle.Bold, GraphicsUnit.Point);
            label5.ForeColor = Color.FromArgb(40, 40, 40);
            label5.Location = new Point(287, 185);
            label5.Name = "label5";
            label5.Size = new Size(63, 13);
            label5.TabIndex = 6;
            label5.Text = "Ho và Tên";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Tahoma", 8.25F, FontStyle.Bold, GraphicsUnit.Point);
            label6.Location = new Point(287, 141);
            label6.Name = "label6";
            label6.Size = new Size(61, 13);
            label6.TabIndex = 35;
            label6.Text = "Password";
            // 
            // txtPassword
            // 
            txtPassword.Location = new Point(406, 134);
            txtPassword.Name = "txtPassword";
            txtPassword.Properties.PasswordChar = '*';
            txtPassword.Properties.UseSystemPasswordChar = true;
            txtPassword.Size = new Size(300, 20);
            txtPassword.TabIndex = 36;
            // 
            // ucUser
            // 
            AutoScaleDimensions = new SizeF(6F, 13F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(groupControl1);
            Name = "ucUser";
            Size = new Size(1001, 587);
            toolStrip1.ResumeLayout(false);
            toolStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)txtUserName.Properties).EndInit();
            ((System.ComponentModel.ISupportInitialize)groupControl1).EndInit();
            groupControl1.ResumeLayout(false);
            groupControl1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)groupControl2).EndInit();
            groupControl2.ResumeLayout(false);
            groupControl2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)txtPhoneNumber.Properties).EndInit();
            ((System.ComponentModel.ISupportInitialize)mdApartmentNumber.Properties).EndInit();
            ((System.ComponentModel.ISupportInitialize)txtAddress.Properties).EndInit();
            ((System.ComponentModel.ISupportInitialize)dateBirthday.Properties.CalendarTimeProperties).EndInit();
            ((System.ComponentModel.ISupportInitialize)dateBirthday.Properties).EndInit();
            ((System.ComponentModel.ISupportInitialize)ckNu.Properties).EndInit();
            ((System.ComponentModel.ISupportInitialize)ckNam.Properties).EndInit();
            ((System.ComponentModel.ISupportInitialize)txtFullName.Properties).EndInit();
            ((System.ComponentModel.ISupportInitialize)txtEmail.Properties).EndInit();
            ((System.ComponentModel.ISupportInitialize)txtPassword.Properties).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private ToolStripButton SubBtnClear;
        private ToolStripButton SubbtnAdd;
        private DevExpress.XtraEditors.LabelControl RestaurantId;
        private DevExpress.XtraEditors.LabelControl CategoryId;
        private DevExpress.XtraEditors.LabelControl id;
        private Label label8;
        private Label label7;
        private ToolStrip toolStrip1;
        private ToolStripButton SubBtnClose;
        private Label label4;
        private DevExpress.XtraEditors.TextEdit txtUserName;
        private Label label3;
        private Label label1;
        private DevExpress.XtraEditors.GroupControl groupControl1;
        private DevExpress.XtraEditors.GroupControl groupControl2;
        private Label label5;
        private DevExpress.XtraEditors.TextEdit textEdit1;
        private DevExpress.XtraEditors.TextEdit txtFullName;
        private DevExpress.XtraEditors.CheckEdit ckNam;
        private DevExpress.XtraEditors.CheckEdit ckNu;
        private Label label2;
        private DevExpress.XtraEditors.DateEdit dateBirthday;
        private DevExpress.XtraEditors.TextEdit txtAddress;
        private DevExpress.XtraEditors.MemoEdit memoEdit1;
        private Label label6;
        private DevExpress.XtraEditors.TextEdit txtPassword;
        private DevExpress.XtraEditors.TextEdit txtEmail;
        private DevExpress.XtraEditors.MemoEdit mdApartmentNumber;
        private Label label9;
        private DevExpress.XtraEditors.TextEdit txtPhoneNumber;
    }
}
