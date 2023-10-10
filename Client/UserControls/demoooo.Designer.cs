namespace Client.UserControls
{
    partial class demoooo
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(demoooo));
            label1 = new Label();
            Data = new DevExpress.XtraEditors.GroupControl();
            gridRestaurant = new DevExpress.XtraGrid.GridControl();
            gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            groupControl1 = new DevExpress.XtraEditors.GroupControl();
            groupControl2 = new DevExpress.XtraEditors.GroupControl();
            meNotes = new DevExpress.XtraEditors.MemoEdit();
            txtBankNumber = new DevExpress.XtraEditors.TextEdit();
            label10 = new Label();
            label9 = new Label();
            txtBankName = new DevExpress.XtraEditors.TextEdit();
            label8 = new Label();
            txtBankAccount = new DevExpress.XtraEditors.TextEdit();
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
            txtRestaurant = new DevExpress.XtraEditors.TextEdit();
            toolStrip1 = new ToolStrip();
            SubBtnAddRestaurant = new ToolStripButton();
            btnClose = new ToolStripButton();
            SubBtnEditRestaurant = new ToolStripButton();
            SubBtnDeleteRestaurant = new ToolStripButton();
            openFileDialog = new OpenFileDialog();
            ((System.ComponentModel.ISupportInitialize)Data).BeginInit();
            Data.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)gridRestaurant).BeginInit();
            ((System.ComponentModel.ISupportInitialize)gridView1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)groupControl1).BeginInit();
            groupControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)groupControl2).BeginInit();
            groupControl2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)meNotes.Properties).BeginInit();
            ((System.ComponentModel.ISupportInitialize)txtBankNumber.Properties).BeginInit();
            ((System.ComponentModel.ISupportInitialize)txtBankName.Properties).BeginInit();
            ((System.ComponentModel.ISupportInitialize)txtBankAccount.Properties).BeginInit();
            ((System.ComponentModel.ISupportInitialize)timeEnd.Properties).BeginInit();
            ((System.ComponentModel.ISupportInitialize)timeStart.Properties).BeginInit();
            ((System.ComponentModel.ISupportInitialize)peImage.Properties).BeginInit();
            ((System.ComponentModel.ISupportInitialize)txtPhoneNumber.Properties).BeginInit();
            ((System.ComponentModel.ISupportInitialize)txtRestaurant.Properties).BeginInit();
            toolStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Tahoma", 8.25F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(5, 33);
            label1.Margin = new Padding(4, 0, 4, 0);
            label1.Name = "label1";
            label1.Size = new Size(75, 17);
            label1.TabIndex = 0;
            label1.Text = "Nhà hàng";
            // 
            // Data
            // 
            Data.Controls.Add(gridRestaurant);
            Data.Dock = DockStyle.Fill;
            Data.Location = new Point(367, 55);
            Data.Margin = new Padding(4);
            Data.Name = "Data";
            Data.Size = new Size(799, 665);
            Data.TabIndex = 4;
            Data.Text = "Danh sách nhà hàng";
            // 
            // gridRestaurant
            // 
            gridRestaurant.Dock = DockStyle.Fill;
            gridRestaurant.Location = new Point(2, 28);
            gridRestaurant.MainView = gridView1;
            gridRestaurant.Name = "gridRestaurant";
            gridRestaurant.Size = new Size(795, 635);
            gridRestaurant.TabIndex = 0;
            gridRestaurant.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] { gridView1 });
            // 
            // gridView1
            // 
            gridView1.GridControl = gridRestaurant;
            gridView1.Name = "gridView1";
            // 
            // groupControl1
            // 
            groupControl1.Controls.Add(Data);
            groupControl1.Controls.Add(groupControl2);
            groupControl1.Controls.Add(toolStrip1);
            groupControl1.Dock = DockStyle.Fill;
            groupControl1.Location = new Point(0, 0);
            groupControl1.Margin = new Padding(4);
            groupControl1.Name = "groupControl1";
            groupControl1.Size = new Size(1168, 722);
            groupControl1.TabIndex = 2;
            groupControl1.Text = "DANH SÁCH NHÀ HÀNG";
            // 
            // groupControl2
            // 
            groupControl2.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Simple;
            groupControl2.Controls.Add(meNotes);
            groupControl2.Controls.Add(txtBankNumber);
            groupControl2.Controls.Add(label10);
            groupControl2.Controls.Add(label9);
            groupControl2.Controls.Add(txtBankName);
            groupControl2.Controls.Add(label8);
            groupControl2.Controls.Add(txtBankAccount);
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
            groupControl2.Controls.Add(txtRestaurant);
            groupControl2.Controls.Add(label1);
            groupControl2.Dock = DockStyle.Left;
            groupControl2.Location = new Point(2, 55);
            groupControl2.Margin = new Padding(4, 2, 4, 2);
            groupControl2.Name = "groupControl2";
            groupControl2.Size = new Size(365, 665);
            groupControl2.TabIndex = 3;
            groupControl2.Text = "Chức năng tìm kiếm";
            // 
            // meNotes
            // 
            meNotes.Location = new Point(6, 572);
            meNotes.Name = "meNotes";
            meNotes.Size = new Size(352, 76);
            meNotes.TabIndex = 18;
            // 
            // txtBankNumber
            // 
            txtBankNumber.Location = new Point(5, 523);
            txtBankNumber.Name = "txtBankNumber";
            txtBankNumber.Size = new Size(353, 22);
            txtBankNumber.TabIndex = 17;
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Font = new Font("Tahoma", 8.25F, FontStyle.Bold, GraphicsUnit.Point);
            label10.Location = new Point(4, 552);
            label10.Margin = new Padding(4, 0, 4, 0);
            label10.Name = "label10";
            label10.Size = new Size(102, 17);
            label10.TabIndex = 16;
            label10.Text = "Tên tài khoản";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Tahoma", 8.25F, FontStyle.Bold, GraphicsUnit.Point);
            label9.Location = new Point(5, 501);
            label9.Margin = new Padding(4, 0, 4, 0);
            label9.Name = "label9";
            label9.Size = new Size(94, 17);
            label9.TabIndex = 15;
            label9.Text = "Số tài khoản";
            // 
            // txtBankName
            // 
            txtBankName.Location = new Point(5, 474);
            txtBankName.Name = "txtBankName";
            txtBankName.Size = new Size(353, 22);
            txtBankName.TabIndex = 14;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Tahoma", 8.25F, FontStyle.Bold, GraphicsUnit.Point);
            label8.Location = new Point(6, 451);
            label8.Margin = new Padding(4, 0, 4, 0);
            label8.Name = "label8";
            label8.Size = new Size(112, 17);
            label8.TabIndex = 13;
            label8.Text = "Tên ngân hàng";
            label8.Click += label8_Click;
            // 
            // txtBankAccount
            // 
            txtBankAccount.Location = new Point(5, 425);
            txtBankAccount.Name = "txtBankAccount";
            txtBankAccount.Size = new Size(353, 22);
            txtBankAccount.TabIndex = 12;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Tahoma", 8.25F, FontStyle.Bold, GraphicsUnit.Point);
            label7.Location = new Point(6, 405);
            label7.Margin = new Padding(4, 0, 4, 0);
            label7.Name = "label7";
            label7.Size = new Size(104, 17);
            label7.TabIndex = 11;
            label7.Text = "Chủ tài khoản";
            // 
            // timeEnd
            // 
            timeEnd.EditValue = new DateTime(2023, 10, 10, 0, 0, 0, 0);
            timeEnd.Location = new Point(163, 375);
            timeEnd.Name = "timeEnd";
            timeEnd.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] { new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo) });
            timeEnd.Size = new Size(101, 24);
            timeEnd.TabIndex = 10;
            timeEnd.EditValueChanged += timeEdit2_EditValueChanged;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Tahoma", 8.25F, FontStyle.Bold, GraphicsUnit.Point);
            label6.Location = new Point(120, 378);
            label6.Margin = new Padding(4, 0, 4, 0);
            label6.Name = "label6";
            label6.Size = new Size(36, 17);
            label6.TabIndex = 9;
            label6.Text = "Đến";
            // 
            // timeStart
            // 
            timeStart.EditValue = new DateTime(2023, 10, 10, 0, 0, 0, 0);
            timeStart.Location = new Point(6, 375);
            timeStart.Name = "timeStart";
            timeStart.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] { new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo) });
            timeStart.Size = new Size(100, 24);
            timeStart.TabIndex = 8;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Tahoma", 8.25F, FontStyle.Bold, GraphicsUnit.Point);
            label5.Location = new Point(6, 352);
            label5.Margin = new Padding(4, 0, 4, 0);
            label5.Name = "label5";
            label5.Size = new Size(147, 17);
            label5.TabIndex = 7;
            label5.Text = "Thời gian hoạt động";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Tahoma", 8.25F, FontStyle.Bold, GraphicsUnit.Point);
            label4.Location = new Point(6, 126);
            label4.Margin = new Padding(4, 0, 4, 0);
            label4.Name = "label4";
            label4.Size = new Size(84, 17);
            label4.TabIndex = 6;
            label4.Text = "Hình mô tả";
            // 
            // peImage
            // 
            peImage.Location = new Point(6, 149);
            peImage.Name = "peImage";
            peImage.Properties.ShowCameraMenuItem = DevExpress.XtraEditors.Controls.CameraMenuItemVisibility.Auto;
            peImage.Size = new Size(352, 197);
            peImage.TabIndex = 5;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Tahoma", 8.25F, FontStyle.Bold, GraphicsUnit.Point);
            label3.Location = new Point(6, 133);
            label3.Margin = new Padding(4, 0, 4, 0);
            label3.Name = "label3";
            label3.Size = new Size(0, 17);
            label3.TabIndex = 4;
            // 
            // txtPhoneNumber
            // 
            txtPhoneNumber.Location = new Point(5, 99);
            txtPhoneNumber.Name = "txtPhoneNumber";
            txtPhoneNumber.Size = new Size(353, 22);
            txtPhoneNumber.TabIndex = 3;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Tahoma", 8.25F, FontStyle.Bold, GraphicsUnit.Point);
            label2.Location = new Point(5, 78);
            label2.Margin = new Padding(4, 0, 4, 0);
            label2.Name = "label2";
            label2.Size = new Size(98, 17);
            label2.TabIndex = 2;
            label2.Text = "Số điện thoại";
            // 
            // txtRestaurant
            // 
            txtRestaurant.Location = new Point(5, 53);
            txtRestaurant.Name = "txtRestaurant";
            txtRestaurant.Size = new Size(353, 22);
            txtRestaurant.TabIndex = 1;
            // 
            // toolStrip1
            // 
            toolStrip1.ImageScalingSize = new Size(20, 20);
            toolStrip1.Items.AddRange(new ToolStripItem[] { SubBtnAddRestaurant, btnClose, SubBtnEditRestaurant, SubBtnDeleteRestaurant });
            toolStrip1.Location = new Point(2, 28);
            toolStrip1.Name = "toolStrip1";
            toolStrip1.Size = new Size(1164, 27);
            toolStrip1.TabIndex = 0;
            toolStrip1.Text = "toolStrip1";
            // 
            // SubBtnAddRestaurant
            // 
            SubBtnAddRestaurant.Image = (Image)resources.GetObject("SubBtnAddRestaurant.Image");
            SubBtnAddRestaurant.ImageTransparentColor = Color.Magenta;
            SubBtnAddRestaurant.Name = "SubBtnAddRestaurant";
            SubBtnAddRestaurant.Size = new Size(135, 24);
            SubBtnAddRestaurant.Text = "Thêm nhà hàng";
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
            btnClose.Size = new Size(29, 24);
            btnClose.Text = "toolStripButton6";
            // 
            // SubBtnEditRestaurant
            // 
            SubBtnEditRestaurant.Image = (Image)resources.GetObject("SubBtnEditRestaurant.Image");
            SubBtnEditRestaurant.ImageTransparentColor = Color.Magenta;
            SubBtnEditRestaurant.Name = "SubBtnEditRestaurant";
            SubBtnEditRestaurant.Size = new Size(123, 24);
            SubBtnEditRestaurant.Text = "Sửa nhà hàng";
            // 
            // SubBtnDeleteRestaurant
            // 
            SubBtnDeleteRestaurant.Image = (Image)resources.GetObject("SubBtnDeleteRestaurant.Image");
            SubBtnDeleteRestaurant.ImageTransparentColor = Color.Magenta;
            SubBtnDeleteRestaurant.Name = "SubBtnDeleteRestaurant";
            SubBtnDeleteRestaurant.Size = new Size(124, 24);
            SubBtnDeleteRestaurant.Text = "Xóa nhà hàng";
            // 
            // openFileDialog
            // 
            openFileDialog.FileName = "openFileDialog1";
            // 
            // demoooo
            // 
            AutoScaleDimensions = new SizeF(7F, 16F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(groupControl1);
            Margin = new Padding(4);
            Name = "demoooo";
            Size = new Size(1168, 722);
            ((System.ComponentModel.ISupportInitialize)Data).EndInit();
            Data.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)gridRestaurant).EndInit();
            ((System.ComponentModel.ISupportInitialize)gridView1).EndInit();
            ((System.ComponentModel.ISupportInitialize)groupControl1).EndInit();
            groupControl1.ResumeLayout(false);
            groupControl1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)groupControl2).EndInit();
            groupControl2.ResumeLayout(false);
            groupControl2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)meNotes.Properties).EndInit();
            ((System.ComponentModel.ISupportInitialize)txtBankNumber.Properties).EndInit();
            ((System.ComponentModel.ISupportInitialize)txtBankName.Properties).EndInit();
            ((System.ComponentModel.ISupportInitialize)txtBankAccount.Properties).EndInit();
            ((System.ComponentModel.ISupportInitialize)timeEnd.Properties).EndInit();
            ((System.ComponentModel.ISupportInitialize)timeStart.Properties).EndInit();
            ((System.ComponentModel.ISupportInitialize)peImage.Properties).EndInit();
            ((System.ComponentModel.ISupportInitialize)txtPhoneNumber.Properties).EndInit();
            ((System.ComponentModel.ISupportInitialize)txtRestaurant.Properties).EndInit();
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
        private DevExpress.XtraEditors.TextEdit txtRestaurant;
        private Label label3;
        private Label label4;
        private DevExpress.XtraEditors.PictureEdit peImage;
        private Label label5;
        private Label label6;
        private DevExpress.XtraEditors.TimeEdit timeStart;
        private DevExpress.XtraEditors.TimeEdit timeEnd;
        private Label label7;
        private DevExpress.XtraEditors.TextEdit txtBankAccount;
        private Label label8;
        private Label label9;
        private DevExpress.XtraEditors.TextEdit txtBankName;
        private DevExpress.XtraEditors.TextEdit txtBankNumber;
        private Label label10;
        private DevExpress.XtraEditors.MemoEdit meNotes;
        private DevExpress.XtraGrid.GridControl gridRestaurant;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private ToolStripButton SubBtnEditRestaurant;
        private ToolStripButton SubBtnDeleteRestaurant;
    }
}
