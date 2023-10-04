namespace Client.UserControls
{
    partial class ucListBank
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ucListBank));
            toolStripButton4 = new ToolStripButton();
            btnSwitchToBank = new ToolStripButton();
            toolStrip1 = new ToolStrip();
            closeUcBank = new ToolStripButton();
            pictureBox1 = new PictureBox();
            label8 = new Label();
            textEdit1 = new DevExpress.XtraEditors.TextEdit();
            label1 = new Label();
            groupControl3 = new DevExpress.XtraEditors.GroupControl();
            gridData = new DevExpress.XtraGrid.GridControl();
            gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            groupControl2 = new DevExpress.XtraEditors.GroupControl();
            groupControl1 = new DevExpress.XtraEditors.GroupControl();
            toolStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)textEdit1.Properties).BeginInit();
            ((System.ComponentModel.ISupportInitialize)groupControl3).BeginInit();
            groupControl3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)gridData).BeginInit();
            ((System.ComponentModel.ISupportInitialize)gridView1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)groupControl2).BeginInit();
            groupControl2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)groupControl1).BeginInit();
            groupControl1.SuspendLayout();
            SuspendLayout();
            // 
            // toolStripButton4
            // 
            toolStripButton4.Image = (Image)resources.GetObject("toolStripButton4.Image");
            toolStripButton4.ImageTransparentColor = Color.Magenta;
            toolStripButton4.Name = "toolStripButton4";
            toolStripButton4.Size = new Size(94, 24);
            toolStripButton4.Text = "Tìm kiếm";
            // 
            // btnSwitchToBank
            // 
            btnSwitchToBank.Image = (Image)resources.GetObject("btnSwitchToBank.Image");
            btnSwitchToBank.ImageTransparentColor = Color.Magenta;
            btnSwitchToBank.Name = "btnSwitchToBank";
            btnSwitchToBank.Size = new Size(114, 24);
            btnSwitchToBank.Text = "Thêm số thẻ";
            btnSwitchToBank.Click += btnSwitchToBank_Click;
            // 
            // toolStrip1
            // 
            toolStrip1.ImageScalingSize = new Size(20, 20);
            toolStrip1.Items.AddRange(new ToolStripItem[] { btnSwitchToBank, toolStripButton4, closeUcBank });
            toolStrip1.Location = new Point(2, 28);
            toolStrip1.Name = "toolStrip1";
            toolStrip1.Size = new Size(1164, 27);
            toolStrip1.TabIndex = 0;
            toolStrip1.Text = "toolStrip1";
            // 
            // closeUcBank
            // 
            closeUcBank.Alignment = ToolStripItemAlignment.Right;
            closeUcBank.DisplayStyle = ToolStripItemDisplayStyle.Image;
            closeUcBank.Image = (Image)resources.GetObject("closeUcBank.Image");
            closeUcBank.ImageTransparentColor = Color.Magenta;
            closeUcBank.Name = "closeUcBank";
            closeUcBank.Size = new Size(29, 24);
            closeUcBank.Text = "toolStripButton6";
            closeUcBank.Click += closeUcBank_Click;
            // 
            // pictureBox1
            // 
            pictureBox1.Location = new Point(9, 139);
            pictureBox1.Margin = new Padding(4);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(349, 166);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 15;
            pictureBox1.TabStop = false;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Tahoma", 8.25F, FontStyle.Bold, GraphicsUnit.Point);
            label8.Location = new Point(9, 108);
            label8.Margin = new Padding(4, 0, 4, 0);
            label8.Name = "label8";
            label8.Size = new Size(66, 17);
            label8.TabIndex = 14;
            label8.Text = "QR code";
            // 
            // textEdit1
            // 
            textEdit1.Location = new Point(9, 73);
            textEdit1.Margin = new Padding(4);
            textEdit1.Name = "textEdit1";
            textEdit1.Size = new Size(350, 22);
            textEdit1.TabIndex = 3;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Tahoma", 8.25F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(5, 44);
            label1.Margin = new Padding(4, 0, 4, 0);
            label1.Name = "label1";
            label1.Size = new Size(112, 17);
            label1.TabIndex = 0;
            label1.Text = "Tên ngân hàng";
            // 
            // groupControl3
            // 
            groupControl3.Controls.Add(gridData);
            groupControl3.Dock = DockStyle.Fill;
            groupControl3.Location = new Point(367, 55);
            groupControl3.Margin = new Padding(4, 2, 4, 2);
            groupControl3.Name = "groupControl3";
            groupControl3.Size = new Size(799, 665);
            groupControl3.TabIndex = 3;
            groupControl3.Text = "Danh sách ngân hàng bạn đang có";
            // 
            // gridData
            // 
            gridData.Dock = DockStyle.Fill;
            gridData.EmbeddedNavigator.Margin = new Padding(4, 2, 4, 2);
            gridData.Location = new Point(2, 28);
            gridData.MainView = gridView1;
            gridData.Margin = new Padding(4, 2, 4, 2);
            gridData.Name = "gridData";
            gridData.Size = new Size(795, 635);
            gridData.TabIndex = 0;
            gridData.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] { gridView1 });
            gridData.Click += gridData_Click;
            // 
            // gridView1
            // 
            gridView1.GridControl = gridData;
            gridView1.Name = "gridView1";
            gridView1.OptionsEditForm.PopupEditFormWidth = 686;
            gridView1.OptionsView.ShowGroupPanel = false;
            gridView1.OptionsView.ShowIndicator = false;
            // 
            // groupControl2
            // 
            groupControl2.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Simple;
            groupControl2.Controls.Add(pictureBox1);
            groupControl2.Controls.Add(label8);
            groupControl2.Controls.Add(textEdit1);
            groupControl2.Controls.Add(label1);
            groupControl2.Dock = DockStyle.Left;
            groupControl2.Location = new Point(2, 55);
            groupControl2.Margin = new Padding(4, 2, 4, 2);
            groupControl2.Name = "groupControl2";
            groupControl2.Size = new Size(365, 665);
            groupControl2.TabIndex = 2;
            groupControl2.Text = "Thông tin thẻ ngân hàng";
            // 
            // groupControl1
            // 
            groupControl1.Controls.Add(groupControl3);
            groupControl1.Controls.Add(groupControl2);
            groupControl1.Controls.Add(toolStrip1);
            groupControl1.Dock = DockStyle.Fill;
            groupControl1.Location = new Point(0, 0);
            groupControl1.Margin = new Padding(4);
            groupControl1.Name = "groupControl1";
            groupControl1.Size = new Size(1168, 722);
            groupControl1.TabIndex = 1;
            groupControl1.Text = "DANH SÁCH BANK";
            // 
            // ucListBank
            // 
            AutoScaleDimensions = new SizeF(7F, 16F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(groupControl1);
            Margin = new Padding(4, 2, 4, 2);
            Name = "ucListBank";
            Size = new Size(1168, 722);
            toolStrip1.ResumeLayout(false);
            toolStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)textEdit1.Properties).EndInit();
            ((System.ComponentModel.ISupportInitialize)groupControl3).EndInit();
            groupControl3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)gridData).EndInit();
            ((System.ComponentModel.ISupportInitialize)gridView1).EndInit();
            ((System.ComponentModel.ISupportInitialize)groupControl2).EndInit();
            groupControl2.ResumeLayout(false);
            groupControl2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)groupControl1).EndInit();
            groupControl1.ResumeLayout(false);
            groupControl1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion
        private ToolStripButton toolStripButton4;
        private ToolStripButton btnSwitchToBank;
        private ToolStrip toolStrip1;
        private PictureBox pictureBox1;
        private Label label8;
        private DevExpress.XtraEditors.TextEdit textEdit1;
        private Label label1;
        private DevExpress.XtraEditors.GroupControl groupControl3;
        private DevExpress.XtraEditors.GroupControl groupControl2;
        private DevExpress.XtraEditors.GroupControl groupControl1;
        private DevExpress.XtraGrid.GridControl gridData;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private ToolStripButton closeUcBank;
    }
}
