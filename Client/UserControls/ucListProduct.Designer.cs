﻿namespace Client.UserControls
{
    partial class ucListProduct
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
            DevExpress.XtraGrid.GridLevelNode gridLevelNode1 = new DevExpress.XtraGrid.GridLevelNode();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ucListProduct));
            groupControl1 = new DevExpress.XtraEditors.GroupControl();
            groupControl3 = new DevExpress.XtraEditors.GroupControl();
            gridData = new DevExpress.XtraGrid.GridControl();
            gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            groupControl2 = new DevExpress.XtraEditors.GroupControl();
            pictureBox1 = new PictureBox();
            label8 = new Label();
            comboBoxEdit1 = new DevExpress.XtraEditors.ComboBoxEdit();
            label7 = new Label();
            spinEdit1 = new DevExpress.XtraEditors.SpinEdit();
            label5 = new Label();
            label4 = new Label();
            memoEdit1 = new DevExpress.XtraEditors.MemoEdit();
            textEdit1 = new DevExpress.XtraEditors.TextEdit();
            label3 = new Label();
            cboRestaurant = new DevExpress.XtraEditors.ComboBoxEdit();
            label1 = new Label();
            toolStrip1 = new ToolStrip();
            SubBtnAdd = new ToolStripButton();
            toolStripSeparator2 = new ToolStripSeparator();
            btnClose = new ToolStripButton();
            SubBtnEdit = new ToolStripButton();
            toolStripSeparator3 = new ToolStripSeparator();
            SubBtnDelete = new ToolStripButton();
            toolStripSeparator1 = new ToolStripSeparator();
            SubBtnDeleteAll = new ToolStripButton();
            toolStripSeparator4 = new ToolStripSeparator();
            SubBtnSearch = new ToolStripButton();
            toolStripSeparator5 = new ToolStripSeparator();
            SubBtnSelect = new ToolStripButton();
            openFileDialog = new OpenFileDialog();
            ((System.ComponentModel.ISupportInitialize)groupControl1).BeginInit();
            groupControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)groupControl3).BeginInit();
            groupControl3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)gridData).BeginInit();
            ((System.ComponentModel.ISupportInitialize)gridView1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)groupControl2).BeginInit();
            groupControl2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)comboBoxEdit1.Properties).BeginInit();
            ((System.ComponentModel.ISupportInitialize)spinEdit1.Properties).BeginInit();
            ((System.ComponentModel.ISupportInitialize)memoEdit1.Properties).BeginInit();
            ((System.ComponentModel.ISupportInitialize)textEdit1.Properties).BeginInit();
            ((System.ComponentModel.ISupportInitialize)cboRestaurant.Properties).BeginInit();
            toolStrip1.SuspendLayout();
            SuspendLayout();
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
            groupControl1.TabIndex = 0;
            groupControl1.Text = "CHỨC NĂNG SẢN PHẨM";
            // 
            // groupControl3
            // 
            groupControl3.Controls.Add(gridData);
            groupControl3.Dock = DockStyle.Fill;
            groupControl3.Location = new Point(315, 50);
            groupControl3.Margin = new Padding(3, 2, 3, 2);
            groupControl3.Name = "groupControl3";
            groupControl3.Size = new Size(684, 535);
            groupControl3.TabIndex = 3;
            groupControl3.Text = "DANH SÁCH SẢN PHẨM";
            // 
            // gridData
            // 
            gridData.Dock = DockStyle.Fill;
            gridData.EmbeddedNavigator.Margin = new Padding(3, 2, 3, 2);
            gridLevelNode1.RelationName = "Level1";
            gridData.LevelTree.Nodes.AddRange(new DevExpress.XtraGrid.GridLevelNode[] { gridLevelNode1 });
            gridData.Location = new Point(2, 23);
            gridData.MainView = gridView1;
            gridData.Margin = new Padding(3, 2, 3, 2);
            gridData.Name = "gridData";
            gridData.Size = new Size(680, 510);
            gridData.TabIndex = 2;
            gridData.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] { gridView1 });
            // 
            // gridView1
            // 
            gridView1.DetailHeight = 284;
            gridView1.GridControl = gridData;
            gridView1.Name = "gridView1";
            gridView1.OptionsBehavior.Editable = false;
            gridView1.OptionsBehavior.ReadOnly = true;
            gridView1.OptionsEditForm.PopupEditFormWidth = 686;
            gridView1.OptionsView.ShowGroupPanel = false;
            gridView1.OptionsView.ShowIndicator = false;
            // 
            // groupControl2
            // 
            groupControl2.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Simple;
            groupControl2.Controls.Add(pictureBox1);
            groupControl2.Controls.Add(label8);
            groupControl2.Controls.Add(comboBoxEdit1);
            groupControl2.Controls.Add(label7);
            groupControl2.Controls.Add(spinEdit1);
            groupControl2.Controls.Add(label5);
            groupControl2.Controls.Add(label4);
            groupControl2.Controls.Add(memoEdit1);
            groupControl2.Controls.Add(textEdit1);
            groupControl2.Controls.Add(label3);
            groupControl2.Controls.Add(cboRestaurant);
            groupControl2.Controls.Add(label1);
            groupControl2.Dock = DockStyle.Left;
            groupControl2.Location = new Point(2, 50);
            groupControl2.Margin = new Padding(3, 2, 3, 2);
            groupControl2.Name = "groupControl2";
            groupControl2.Size = new Size(313, 535);
            groupControl2.TabIndex = 2;
            groupControl2.Text = "THÔNG TIN SẢN PHẨM";
            // 
            // pictureBox1
            // 
            pictureBox1.BorderStyle = BorderStyle.FixedSingle;
            pictureBox1.Location = new Point(8, 322);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(299, 179);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 15;
            pictureBox1.TabStop = false;
            pictureBox1.Click += pictureBox1_Click;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Tahoma", 8.25F, FontStyle.Bold, GraphicsUnit.Point);
            label8.Location = new Point(8, 299);
            label8.Name = "label8";
            label8.Size = new Size(111, 13);
            label8.TabIndex = 14;
            label8.Text = "Hình ảnh minh họa";
            // 
            // comboBoxEdit1
            // 
            comboBoxEdit1.Location = new Point(8, 274);
            comboBoxEdit1.Margin = new Padding(3, 2, 3, 2);
            comboBoxEdit1.Name = "comboBoxEdit1";
            comboBoxEdit1.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] { new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo) });
            comboBoxEdit1.Size = new Size(302, 20);
            comboBoxEdit1.TabIndex = 11;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Tahoma", 8.25F, FontStyle.Bold, GraphicsUnit.Point);
            label7.Location = new Point(7, 255);
            label7.Name = "label7";
            label7.Size = new Size(88, 13);
            label7.TabIndex = 10;
            label7.Text = "Loại danh mục";
            // 
            // spinEdit1
            // 
            spinEdit1.EditValue = new decimal(new int[] { 0, 0, 0, 0 });
            spinEdit1.Location = new Point(48, 110);
            spinEdit1.Name = "spinEdit1";
            spinEdit1.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] { new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo) });
            spinEdit1.Size = new Size(72, 20);
            spinEdit1.TabIndex = 7;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Tahoma", 8.25F, FontStyle.Bold, GraphicsUnit.Point);
            label5.ForeColor = Color.Red;
            label5.Location = new Point(7, 113);
            label5.Name = "label5";
            label5.Size = new Size(35, 13);
            label5.TabIndex = 6;
            label5.Text = "Price";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Tahoma", 8.25F, FontStyle.Bold, GraphicsUnit.Point);
            label4.Location = new Point(7, 137);
            label4.Name = "label4";
            label4.Size = new Size(97, 13);
            label4.TabIndex = 5;
            label4.Text = "Mô tả sản phẩm";
            // 
            // memoEdit1
            // 
            memoEdit1.Location = new Point(7, 155);
            memoEdit1.Name = "memoEdit1";
            memoEdit1.Size = new Size(300, 96);
            memoEdit1.TabIndex = 4;
            // 
            // textEdit1
            // 
            textEdit1.Location = new Point(7, 87);
            textEdit1.Name = "textEdit1";
            textEdit1.Size = new Size(300, 20);
            textEdit1.TabIndex = 3;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Tahoma", 8.25F, FontStyle.Bold, GraphicsUnit.Point);
            label3.Location = new Point(5, 70);
            label3.Name = "label3";
            label3.Size = new Size(86, 13);
            label3.TabIndex = 2;
            label3.Text = "Tên sản phẩm";
            // 
            // cboRestaurant
            // 
            cboRestaurant.Location = new Point(5, 46);
            cboRestaurant.Margin = new Padding(3, 2, 3, 2);
            cboRestaurant.Name = "cboRestaurant";
            cboRestaurant.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] { new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo) });
            cboRestaurant.ShowToolTips = false;
            cboRestaurant.Size = new Size(302, 20);
            cboRestaurant.TabIndex = 1;
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
            // SubBtnAdd
            // 
            SubBtnAdd.Image = (Image)resources.GetObject("SubBtnAdd.Image");
            SubBtnAdd.ImageTransparentColor = Color.Magenta;
            SubBtnAdd.Name = "SubBtnAdd";
            SubBtnAdd.Size = new Size(61, 24);
            SubBtnAdd.Text = "Thêm";
            SubBtnAdd.Click += btnUcProduct_Click;
            // 
            // toolStripSeparator2
            // 
            toolStripSeparator2.Name = "toolStripSeparator2";
            toolStripSeparator2.Size = new Size(6, 27);
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
            btnClose.Click += btnClose_Click;
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
            // openFileDialog
            // 
            openFileDialog.FileName = "openFileDialog1";
            // 
            // ucListProduct
            // 
            AutoScaleDimensions = new SizeF(6F, 13F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(groupControl1);
            Name = "ucListProduct";
            Size = new Size(1001, 587);
            ((System.ComponentModel.ISupportInitialize)groupControl1).EndInit();
            groupControl1.ResumeLayout(false);
            groupControl1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)groupControl3).EndInit();
            groupControl3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)gridData).EndInit();
            ((System.ComponentModel.ISupportInitialize)gridView1).EndInit();
            ((System.ComponentModel.ISupportInitialize)groupControl2).EndInit();
            groupControl2.ResumeLayout(false);
            groupControl2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)comboBoxEdit1.Properties).EndInit();
            ((System.ComponentModel.ISupportInitialize)spinEdit1.Properties).EndInit();
            ((System.ComponentModel.ISupportInitialize)memoEdit1.Properties).EndInit();
            ((System.ComponentModel.ISupportInitialize)textEdit1.Properties).EndInit();
            ((System.ComponentModel.ISupportInitialize)cboRestaurant.Properties).EndInit();
            toolStrip1.ResumeLayout(false);
            toolStrip1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private DevExpress.XtraEditors.GroupControl groupControl1;
        private ToolStrip toolStrip1;
        private ToolStripButton SubBtnAdd;
        private ToolStripButton SubBtnSearch;
        private DevExpress.XtraEditors.GroupControl groupControl2;
        private DevExpress.XtraEditors.ComboBoxEdit cboRestaurant;
        private Label label1;
        private DevExpress.XtraEditors.GroupControl groupControl3;
        private Label label3;
        private DevExpress.XtraEditors.SpinEdit spinEdit1;
        private Label label5;
        private Label label4;
        private DevExpress.XtraEditors.MemoEdit memoEdit1;
        private DevExpress.XtraEditors.TextEdit textEdit1;
        private DevExpress.XtraEditors.ComboBoxEdit comboBoxEdit1;
        private Label label7;
        private OpenFileDialog openFileDialog;
        private Label label8;
        private PictureBox pictureBox1;
        private DevExpress.XtraGrid.GridControl gridData;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private ToolStripButton SubBtnEdit;
        private ToolStripSeparator toolStripSeparator1;
        private ToolStripButton SubBtnDelete;
        private ToolStripButton SubBtnDeleteAll;
        private ToolStripButton SubBtnSelect;
        private ToolStripSeparator toolStripSeparator2;
        private ToolStripSeparator toolStripSeparator3;
        protected ToolStripButton btnClose;
        private ToolStripSeparator toolStripSeparator4;
        private ToolStripSeparator toolStripSeparator5;
    }
}
