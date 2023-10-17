namespace Client.UserControls
{
    partial class ucListUser
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ucListUser));
            ckUnlock = new DevExpress.XtraEditors.CheckEdit();
            label2 = new Label();
            gridlayout = new DevExpress.XtraGrid.Views.Grid.GridView();
            Id = new DevExpress.XtraGrid.Columns.GridColumn();
            UserName = new DevExpress.XtraGrid.Columns.GridColumn();
            PhoneNumber = new DevExpress.XtraGrid.Columns.GridColumn();
            FullName = new DevExpress.XtraGrid.Columns.GridColumn();
            Gender = new DevExpress.XtraGrid.Columns.GridColumn();
            Birthday = new DevExpress.XtraGrid.Columns.GridColumn();
            Avatar = new DevExpress.XtraGrid.Columns.GridColumn();
            Address = new DevExpress.XtraGrid.Columns.GridColumn();
            ApartmentNumber = new DevExpress.XtraGrid.Columns.GridColumn();
            LockoutEnd = new DevExpress.XtraGrid.Columns.GridColumn();
            gridListUser = new DevExpress.XtraGrid.GridControl();
            label1 = new Label();
            Data = new DevExpress.XtraEditors.GroupControl();
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
            groupControl2 = new DevExpress.XtraEditors.GroupControl();
            dateBirthday = new DevExpress.XtraEditors.DateEdit();
            txtSearch = new DevExpress.XtraEditors.TextEdit();
            groupControl1 = new DevExpress.XtraEditors.GroupControl();
            ((System.ComponentModel.ISupportInitialize)ckUnlock.Properties).BeginInit();
            ((System.ComponentModel.ISupportInitialize)gridlayout).BeginInit();
            ((System.ComponentModel.ISupportInitialize)gridListUser).BeginInit();
            ((System.ComponentModel.ISupportInitialize)Data).BeginInit();
            Data.SuspendLayout();
            toolStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)groupControl2).BeginInit();
            groupControl2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dateBirthday.Properties).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dateBirthday.Properties.CalendarTimeProperties).BeginInit();
            ((System.ComponentModel.ISupportInitialize)txtSearch.Properties).BeginInit();
            ((System.ComponentModel.ISupportInitialize)groupControl1).BeginInit();
            groupControl1.SuspendLayout();
            SuspendLayout();
            // 
            // ckUnlock
            // 
            ckUnlock.Location = new Point(5, 137);
            ckUnlock.Name = "ckUnlock";
            ckUnlock.Properties.Appearance.Font = new Font("Tahoma", 8.5F, FontStyle.Bold, GraphicsUnit.Point);
            ckUnlock.Properties.Appearance.Options.UseFont = true;
            ckUnlock.Properties.Caption = "Khóa";
            ckUnlock.Size = new Size(75, 20);
            ckUnlock.TabIndex = 5;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Tahoma", 8.25F, FontStyle.Bold, GraphicsUnit.Point);
            label2.Location = new Point(5, 85);
            label2.Name = "label2";
            label2.Size = new Size(61, 13);
            label2.TabIndex = 2;
            label2.Text = "Ngày sinh";
            // 
            // gridlayout
            // 
            gridlayout.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] { Id, UserName, PhoneNumber, FullName, Gender, Birthday, Avatar, Address, ApartmentNumber, LockoutEnd });
            gridlayout.GridControl = gridListUser;
            gridlayout.Name = "gridlayout";
            gridlayout.OptionsEditForm.PopupEditFormWidth = 686;
            gridlayout.OptionsView.RowAutoHeight = true;
            // 
            // Id
            // 
            Id.Caption = "Id";
            Id.FieldName = "Id";
            Id.Name = "Id";
            // 
            // UserName
            // 
            UserName.Caption = "UserName";
            UserName.FieldName = "UserName";
            UserName.Name = "UserName";
            UserName.Visible = true;
            UserName.VisibleIndex = 1;
            // 
            // PhoneNumber
            // 
            PhoneNumber.Caption = "Số điện thoại";
            PhoneNumber.FieldName = "PhoneNumber";
            PhoneNumber.Name = "PhoneNumber";
            PhoneNumber.Visible = true;
            PhoneNumber.VisibleIndex = 2;
            // 
            // FullName
            // 
            FullName.Caption = "Họ Tên";
            FullName.FieldName = "FullName";
            FullName.Name = "FullName";
            FullName.Visible = true;
            FullName.VisibleIndex = 3;
            // 
            // Gender
            // 
            Gender.Caption = "Giới tính";
            Gender.FieldName = "Gender";
            Gender.Name = "Gender";
            Gender.Visible = true;
            Gender.VisibleIndex = 4;
            // 
            // Birthday
            // 
            Birthday.Caption = "Ngày sinh";
            Birthday.FieldName = "Birthday";
            Birthday.Name = "Birthday";
            Birthday.Visible = true;
            Birthday.VisibleIndex = 5;
            // 
            // Avatar
            // 
            Avatar.Caption = "Avatar";
            Avatar.FieldName = "Avatar";
            Avatar.Name = "Avatar";
            Avatar.Visible = true;
            Avatar.VisibleIndex = 6;
            // 
            // Address
            // 
            Address.Caption = "Địa chỉ";
            Address.FieldName = "Address";
            Address.Name = "Address";
            Address.Visible = true;
            Address.VisibleIndex = 7;
            // 
            // ApartmentNumber
            // 
            ApartmentNumber.Caption = "Số nhà";
            ApartmentNumber.FieldName = "ApartmentNumber";
            ApartmentNumber.Name = "ApartmentNumber";
            ApartmentNumber.Visible = true;
            ApartmentNumber.VisibleIndex = 8;
            // 
            // LockoutEnd
            // 
            LockoutEnd.Caption = "Trạng thái";
            LockoutEnd.FieldName = "LockoutEnd";
            LockoutEnd.Name = "LockoutEnd";
            LockoutEnd.Visible = true;
            LockoutEnd.VisibleIndex = 0;
            // 
            // gridListUser
            // 
            gridListUser.Dock = DockStyle.Fill;
            gridListUser.Location = new Point(2, 23);
            gridListUser.MainView = gridlayout;
            gridListUser.Name = "gridListUser";
            gridListUser.Size = new Size(680, 510);
            gridListUser.TabIndex = 0;
            gridListUser.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] { gridlayout });
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Tahoma", 8.25F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(4, 36);
            label1.Name = "label1";
            label1.Size = new Size(55, 13);
            label1.TabIndex = 0;
            label1.Text = "Nội dung";
            // 
            // Data
            // 
            Data.Controls.Add(gridListUser);
            Data.Dock = DockStyle.Fill;
            Data.Location = new Point(315, 50);
            Data.Name = "Data";
            Data.Size = new Size(684, 535);
            Data.TabIndex = 4;
            Data.Text = "Danh sách nhà hàng";
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
            // 
            // SubBtnAdd
            // 
            SubBtnAdd.Image = (Image)resources.GetObject("SubBtnAdd.Image");
            SubBtnAdd.ImageTransparentColor = Color.Magenta;
            SubBtnAdd.Name = "SubBtnAdd";
            SubBtnAdd.Size = new Size(61, 24);
            SubBtnAdd.Text = "Thêm";
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
            // groupControl2
            // 
            groupControl2.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Simple;
            groupControl2.Controls.Add(dateBirthday);
            groupControl2.Controls.Add(txtSearch);
            groupControl2.Controls.Add(ckUnlock);
            groupControl2.Controls.Add(label2);
            groupControl2.Controls.Add(label1);
            groupControl2.Dock = DockStyle.Left;
            groupControl2.Location = new Point(2, 50);
            groupControl2.Margin = new Padding(3, 2, 3, 2);
            groupControl2.Name = "groupControl2";
            groupControl2.Size = new Size(313, 535);
            groupControl2.TabIndex = 3;
            groupControl2.Text = "Chức năng tìm kiếm";
            // 
            // dateBirthday
            // 
            dateBirthday.EditValue = null;
            dateBirthday.Location = new Point(5, 111);
            dateBirthday.Name = "dateBirthday";
            dateBirthday.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] { new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo) });
            dateBirthday.Properties.CalendarTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] { new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo) });
            dateBirthday.Size = new Size(100, 20);
            dateBirthday.TabIndex = 7;
            dateBirthday.EditValueChanged += dateBirthday_EditValueChanged;
            // 
            // txtSearch
            // 
            txtSearch.Location = new Point(4, 58);
            txtSearch.Name = "txtSearch";
            txtSearch.Size = new Size(302, 20);
            txtSearch.TabIndex = 6;
            txtSearch.EditValueChanged += txtSearch_EditValueChanged;
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
            // ucListUser
            // 
            AutoScaleDimensions = new SizeF(6F, 13F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(groupControl1);
            Name = "ucListUser";
            Size = new Size(1001, 587);
            ((System.ComponentModel.ISupportInitialize)ckUnlock.Properties).EndInit();
            ((System.ComponentModel.ISupportInitialize)gridlayout).EndInit();
            ((System.ComponentModel.ISupportInitialize)gridListUser).EndInit();
            ((System.ComponentModel.ISupportInitialize)Data).EndInit();
            Data.ResumeLayout(false);
            toolStrip1.ResumeLayout(false);
            toolStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)groupControl2).EndInit();
            groupControl2.ResumeLayout(false);
            groupControl2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dateBirthday.Properties.CalendarTimeProperties).EndInit();
            ((System.ComponentModel.ISupportInitialize)dateBirthday.Properties).EndInit();
            ((System.ComponentModel.ISupportInitialize)txtSearch.Properties).EndInit();
            ((System.ComponentModel.ISupportInitialize)groupControl1).EndInit();
            groupControl1.ResumeLayout(false);
            groupControl1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion
        private DevExpress.XtraEditors.CheckEdit ckUnlock;
        private Label label2;
        private DevExpress.XtraGrid.Views.Grid.GridView gridlayout;
        private DevExpress.XtraGrid.GridControl gridListUser;
        private Label label1;
        private DevExpress.XtraEditors.GroupControl Data;
        private OpenFileDialog openFileDialog;
        private ToolStrip toolStrip1;
        private ToolStripButton btnClose;
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
        private DevExpress.XtraEditors.GroupControl groupControl2;
        private DevExpress.XtraEditors.GroupControl groupControl1;
        private DevExpress.XtraGrid.Columns.GridColumn Id;
        private DevExpress.XtraGrid.Columns.GridColumn UserName;
        private DevExpress.XtraGrid.Columns.GridColumn PhoneNumber;
        private DevExpress.XtraGrid.Columns.GridColumn FullName;
        private DevExpress.XtraGrid.Columns.GridColumn Gender;
        private DevExpress.XtraGrid.Columns.GridColumn Birthday;
        private DevExpress.XtraGrid.Columns.GridColumn Avatar;
        private DevExpress.XtraGrid.Columns.GridColumn Address;
        private DevExpress.XtraGrid.Columns.GridColumn ApartmentNumber;
        private DevExpress.XtraGrid.Columns.GridColumn LockoutEnd;
        private DevExpress.XtraEditors.TextEdit txtSearch;
        private DevExpress.XtraEditors.DateEdit dateBirthday;
    }
}
