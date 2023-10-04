namespace Client.UserControls
{
    partial class ucOrder
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ucOrder));
            closeUcOrder = new ToolStripButton();
            toolStripButton2 = new ToolStripButton();
            toolStripButton1 = new ToolStripButton();
            SubBtnOrder = new ToolStripButton();
            groupControl2 = new DevExpress.XtraEditors.GroupControl();
            flowLayout = new FlowLayoutPanel();
            jsonDataSource1 = new DevExpress.DataAccess.Json.JsonDataSource(components);
            groupControl3 = new DevExpress.XtraEditors.GroupControl();
            groupControl1 = new DevExpress.XtraEditors.GroupControl();
            toolStrip1 = new ToolStrip();
            groupControl4 = new DevExpress.XtraEditors.GroupControl();
            dtOrderDate = new DevExpress.XtraEditors.DateEdit();
            labelControl1 = new DevExpress.XtraEditors.LabelControl();
            gridDataUser = new DevExpress.XtraGrid.GridControl();
            gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            ((System.ComponentModel.ISupportInitialize)groupControl2).BeginInit();
            groupControl2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)groupControl3).BeginInit();
            groupControl3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)groupControl1).BeginInit();
            groupControl1.SuspendLayout();
            toolStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)groupControl4).BeginInit();
            groupControl4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dtOrderDate.Properties.CalendarTimeProperties).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dtOrderDate.Properties).BeginInit();
            ((System.ComponentModel.ISupportInitialize)gridDataUser).BeginInit();
            ((System.ComponentModel.ISupportInitialize)gridView1).BeginInit();
            SuspendLayout();
            // 
            // closeUcOrder
            // 
            closeUcOrder.Alignment = ToolStripItemAlignment.Right;
            closeUcOrder.DisplayStyle = ToolStripItemDisplayStyle.Image;
            closeUcOrder.Image = (Image)resources.GetObject("closeUcOrder.Image");
            closeUcOrder.ImageTransparentColor = Color.Magenta;
            closeUcOrder.Name = "closeUcOrder";
            closeUcOrder.Size = new Size(29, 24);
            closeUcOrder.Text = "Đơn hàng của tôi";
            closeUcOrder.Click += closeUcOrder_Click;
            // 
            // toolStripButton2
            // 
            toolStripButton2.Image = (Image)resources.GetObject("toolStripButton2.Image");
            toolStripButton2.ImageTransparentColor = Color.Magenta;
            toolStripButton2.Name = "toolStripButton2";
            toolStripButton2.Size = new Size(161, 24);
            toolStripButton2.Text = "Tìm kiếm đơn hàng";
            // 
            // toolStripButton1
            // 
            toolStripButton1.Image = (Image)resources.GetObject("toolStripButton1.Image");
            toolStripButton1.ImageTransparentColor = Color.Magenta;
            toolStripButton1.Name = "toolStripButton1";
            toolStripButton1.Size = new Size(125, 24);
            toolStripButton1.Text = "Sửa đơn hàng";
            // 
            // SubBtnOrder
            // 
            SubBtnOrder.Image = (Image)resources.GetObject("SubBtnOrder.Image");
            SubBtnOrder.ImageTransparentColor = Color.Magenta;
            SubBtnOrder.Name = "SubBtnOrder";
            SubBtnOrder.Size = new Size(97, 24);
            SubBtnOrder.Text = "Đặt Hàng";
            // 
            // groupControl2
            // 
            groupControl2.Controls.Add(flowLayout);
            groupControl2.Dock = DockStyle.Left;
            groupControl2.Location = new Point(2, 55);
            groupControl2.Margin = new Padding(4, 2, 4, 2);
            groupControl2.Name = "groupControl2";
            groupControl2.Size = new Size(365, 665);
            groupControl2.TabIndex = 1;
            groupControl2.Text = "Danh sách sản phẩm";
            // 
            // flowLayout
            // 
            flowLayout.AutoScroll = true;
            flowLayout.Dock = DockStyle.Fill;
            flowLayout.Location = new Point(2, 28);
            flowLayout.Name = "flowLayout";
            flowLayout.Size = new Size(361, 635);
            flowLayout.TabIndex = 0;
            // 
            // jsonDataSource1
            // 
            jsonDataSource1.Name = "jsonDataSource1";
            // 
            // groupControl3
            // 
            groupControl3.Controls.Add(gridDataUser);
            groupControl3.Controls.Add(groupControl4);
            groupControl3.Dock = DockStyle.Fill;
            groupControl3.Location = new Point(367, 55);
            groupControl3.Margin = new Padding(4, 2, 4, 2);
            groupControl3.Name = "groupControl3";
            groupControl3.Size = new Size(799, 665);
            groupControl3.TabIndex = 2;
            groupControl3.Text = "Danh sách đơn hàng";
            // 
            // groupControl1
            // 
            groupControl1.Controls.Add(groupControl3);
            groupControl1.Controls.Add(groupControl2);
            groupControl1.Controls.Add(toolStrip1);
            groupControl1.Dock = DockStyle.Fill;
            groupControl1.Location = new Point(0, 0);
            groupControl1.Margin = new Padding(4, 2, 4, 2);
            groupControl1.Name = "groupControl1";
            groupControl1.Size = new Size(1168, 722);
            groupControl1.TabIndex = 1;
            groupControl1.Text = "DANH SÁCH ĐƠN HÀNG";
            // 
            // toolStrip1
            // 
            toolStrip1.ImageScalingSize = new Size(20, 20);
            toolStrip1.Items.AddRange(new ToolStripItem[] { SubBtnOrder, toolStripButton1, toolStripButton2, closeUcOrder });
            toolStrip1.Location = new Point(2, 28);
            toolStrip1.Name = "toolStrip1";
            toolStrip1.Size = new Size(1164, 27);
            toolStrip1.TabIndex = 0;
            toolStrip1.Text = "toolStrip1";
            // 
            // groupControl4
            // 
            groupControl4.Controls.Add(labelControl1);
            groupControl4.Controls.Add(dtOrderDate);
            groupControl4.Dock = DockStyle.Top;
            groupControl4.Location = new Point(2, 28);
            groupControl4.Name = "groupControl4";
            groupControl4.ShowCaption = false;
            groupControl4.Size = new Size(795, 41);
            groupControl4.TabIndex = 0;
            // 
            // dtOrderDate
            // 
            dtOrderDate.EditValue = null;
            dtOrderDate.Location = new Point(79, 9);
            dtOrderDate.Name = "dtOrderDate";
            dtOrderDate.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] { new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo) });
            dtOrderDate.Properties.CalendarTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] { new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo) });
            dtOrderDate.Size = new Size(146, 22);
            dtOrderDate.TabIndex = 0;
            // 
            // labelControl1
            // 
            labelControl1.Appearance.Font = new Font("Tahoma", 7.8F, FontStyle.Bold, GraphicsUnit.Point);
            labelControl1.Appearance.Options.UseFont = true;
            labelControl1.Location = new Point(7, 15);
            labelControl1.Name = "labelControl1";
            labelControl1.Size = new Size(57, 16);
            labelControl1.TabIndex = 1;
            labelControl1.Text = "Thời gian";
            // 
            // gridDataUser
            // 
            gridDataUser.Dock = DockStyle.Fill;
            gridDataUser.Location = new Point(2, 69);
            gridDataUser.MainView = gridView1;
            gridDataUser.Name = "gridDataUser";
            gridDataUser.Size = new Size(795, 594);
            gridDataUser.TabIndex = 1;
            gridDataUser.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] { gridView1 });
            // 
            // gridView1
            // 
            gridView1.GridControl = gridDataUser;
            gridView1.Name = "gridView1";
            gridView1.OptionsBehavior.CacheValuesOnRowUpdating = DevExpress.Data.CacheRowValuesMode.Disabled;
            gridView1.OptionsBehavior.Editable = false;
            gridView1.OptionsView.ShowGroupPanel = false;
            gridView1.OptionsView.ShowIndicator = false;
            // 
            // ucOrder
            // 
            AutoScaleDimensions = new SizeF(7F, 16F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(groupControl1);
            Name = "ucOrder";
            Size = new Size(1168, 722);
            Load += ucOrder_Load;
            ((System.ComponentModel.ISupportInitialize)groupControl2).EndInit();
            groupControl2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)groupControl3).EndInit();
            groupControl3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)groupControl1).EndInit();
            groupControl1.ResumeLayout(false);
            groupControl1.PerformLayout();
            toolStrip1.ResumeLayout(false);
            toolStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)groupControl4).EndInit();
            groupControl4.ResumeLayout(false);
            groupControl4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dtOrderDate.Properties.CalendarTimeProperties).EndInit();
            ((System.ComponentModel.ISupportInitialize)dtOrderDate.Properties).EndInit();
            ((System.ComponentModel.ISupportInitialize)gridDataUser).EndInit();
            ((System.ComponentModel.ISupportInitialize)gridView1).EndInit();
            ResumeLayout(false);
        }

        #endregion
        private ToolStripButton closeUcOrder;
        private ToolStripButton toolStripButton2;
        private ToolStripButton toolStripButton1;
        private ToolStripButton SubBtnOrder;
        private DevExpress.XtraEditors.GroupControl groupControl2;
        private DevExpress.XtraEditors.GroupControl groupControl3;
        private DevExpress.XtraEditors.GroupControl groupControl1;
        private ToolStrip toolStrip1;
        private DevExpress.DataAccess.Json.JsonDataSource jsonDataSource1;
        private FlowLayoutPanel flowLayout;
        private DevExpress.XtraEditors.GroupControl groupControl4;
        private DevExpress.XtraEditors.DateEdit dtOrderDate;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraGrid.GridControl gridDataUser;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
    }
}
