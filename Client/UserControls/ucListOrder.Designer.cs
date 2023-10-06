namespace Client.UserControls
{
    partial class ucListOrder
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ucListOrder));
            groupControl1 = new DevExpress.XtraEditors.GroupControl();
            groupControl3 = new DevExpress.XtraEditors.GroupControl();
            gridData = new DevExpress.XtraGrid.GridControl();
            gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            groupControl4 = new DevExpress.XtraEditors.GroupControl();
            dtOrderDate = new DevExpress.XtraEditors.DateEdit();
            labelControl1 = new DevExpress.XtraEditors.LabelControl();
            groupControl2 = new DevExpress.XtraEditors.GroupControl();
            txtTile = new DevExpress.XtraEditors.TextEdit();
            label4 = new Label();
            txtUserName = new DevExpress.XtraEditors.TextEdit();
            label3 = new Label();
            cboRestaurant = new DevExpress.XtraEditors.ComboBoxEdit();
            label1 = new Label();
            toolStrip1 = new ToolStrip();
            SubBtnOrder = new ToolStripButton();
            SubBtnSearch = new ToolStripButton();
            closeUcListOrder = new ToolStripButton();
            ((System.ComponentModel.ISupportInitialize)groupControl1).BeginInit();
            groupControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)groupControl3).BeginInit();
            groupControl3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)gridData).BeginInit();
            ((System.ComponentModel.ISupportInitialize)gridView1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)groupControl4).BeginInit();
            groupControl4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dtOrderDate.Properties).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dtOrderDate.Properties.CalendarTimeProperties).BeginInit();
            ((System.ComponentModel.ISupportInitialize)groupControl2).BeginInit();
            groupControl2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)txtTile.Properties).BeginInit();
            ((System.ComponentModel.ISupportInitialize)txtUserName.Properties).BeginInit();
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
            groupControl1.Margin = new Padding(4, 2, 4, 2);
            groupControl1.Name = "groupControl1";
            groupControl1.Size = new Size(1168, 722);
            groupControl1.TabIndex = 0;
            groupControl1.Text = "DANH SÁCH ĐƠN HÀNG";
            // 
            // groupControl3
            // 
            groupControl3.Controls.Add(gridData);
            groupControl3.Controls.Add(groupControl4);
            groupControl3.Dock = DockStyle.Fill;
            groupControl3.Location = new Point(367, 55);
            groupControl3.Margin = new Padding(4, 2, 4, 2);
            groupControl3.Name = "groupControl3";
            groupControl3.Size = new Size(799, 665);
            groupControl3.TabIndex = 2;
            groupControl3.Text = "Danh sách đơn hàng";
            // 
            // gridData
            // 
            gridData.Dock = DockStyle.Fill;
            gridData.EmbeddedNavigator.Margin = new Padding(4, 2, 4, 2);
            gridData.Location = new Point(2, 86);
            gridData.MainView = gridView1;
            gridData.Margin = new Padding(4, 2, 4, 2);
            gridData.Name = "gridData";
            gridData.Size = new Size(795, 577);
            gridData.TabIndex = 1;
            gridData.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] { gridView1 });
            // 
            // gridView1
            // 
            gridView1.GridControl = gridData;
            gridView1.Name = "gridView1";
            gridView1.OptionsBehavior.Editable = false;
            gridView1.OptionsView.ShowGroupPanel = false;
            gridView1.OptionsView.ShowIndicator = false;
            // 
            // groupControl4
            // 
            groupControl4.Controls.Add(dtOrderDate);
            groupControl4.Controls.Add(labelControl1);
            groupControl4.Dock = DockStyle.Top;
            groupControl4.Location = new Point(2, 28);
            groupControl4.Margin = new Padding(4, 2, 4, 2);
            groupControl4.Name = "groupControl4";
            groupControl4.ShowCaption = false;
            groupControl4.Size = new Size(795, 58);
            groupControl4.TabIndex = 0;
            groupControl4.Text = "groupControl4";
            // 
            // dtOrderDate
            // 
            dtOrderDate.EditValue = null;
            dtOrderDate.Location = new Point(72, 14);
            dtOrderDate.Margin = new Padding(4, 2, 4, 2);
            dtOrderDate.Name = "dtOrderDate";
            dtOrderDate.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] { new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo) });
            dtOrderDate.Properties.CalendarTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] { new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo) });
            dtOrderDate.Size = new Size(156, 22);
            dtOrderDate.TabIndex = 1;
            dtOrderDate.EditValueChanged += dtOrderDate_EditValueChanged;
            // 
            // labelControl1
            // 
            labelControl1.Appearance.Font = new Font("Tahoma", 7.8F, FontStyle.Bold, GraphicsUnit.Point);
            labelControl1.Appearance.Options.UseFont = true;
            labelControl1.Location = new Point(9, 16);
            labelControl1.Margin = new Padding(4, 2, 4, 2);
            labelControl1.Name = "labelControl1";
            labelControl1.Size = new Size(57, 16);
            labelControl1.TabIndex = 0;
            labelControl1.Text = "Thời gian";
            // 
            // groupControl2
            // 
            groupControl2.Controls.Add(txtTile);
            groupControl2.Controls.Add(label4);
            groupControl2.Controls.Add(txtUserName);
            groupControl2.Controls.Add(label3);
            groupControl2.Controls.Add(cboRestaurant);
            groupControl2.Controls.Add(label1);
            groupControl2.Dock = DockStyle.Left;
            groupControl2.Location = new Point(2, 55);
            groupControl2.Margin = new Padding(4, 2, 4, 2);
            groupControl2.Name = "groupControl2";
            groupControl2.Size = new Size(365, 665);
            groupControl2.TabIndex = 1;
            groupControl2.Text = "Danh sách sản phẩm";
            // 
            // txtTile
            // 
            txtTile.Location = new Point(79, 108);
            txtTile.Margin = new Padding(4, 2, 4, 2);
            txtTile.Name = "txtTile";
            txtTile.Size = new Size(279, 22);
            txtTile.TabIndex = 5;
            txtTile.EditValueChanged += txtTile_EditValueChanged;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(6, 111);
            label4.Margin = new Padding(4, 0, 4, 0);
            label4.Name = "label4";
            label4.Size = new Size(65, 16);
            label4.TabIndex = 4;
            label4.Text = "Sản phẩm";
            // 
            // txtUserName
            // 
            txtUserName.Location = new Point(79, 76);
            txtUserName.Margin = new Padding(4, 2, 4, 2);
            txtUserName.Name = "txtUserName";
            txtUserName.Size = new Size(279, 22);
            txtUserName.TabIndex = 3;
            txtUserName.EditValueChanged += txtUserName_EditValueChanged;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(6, 79);
            label3.Margin = new Padding(4, 0, 4, 0);
            label3.Name = "label3";
            label3.Size = new Size(66, 16);
            label3.TabIndex = 2;
            label3.Text = "UserName";
            // 
            // cboRestaurant
            // 
            cboRestaurant.Location = new Point(79, 41);
            cboRestaurant.Margin = new Padding(4, 2, 4, 2);
            cboRestaurant.Name = "cboRestaurant";
            cboRestaurant.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] { new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo) });
            cboRestaurant.Size = new Size(279, 22);
            cboRestaurant.TabIndex = 1;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(5, 44);
            label1.Margin = new Padding(4, 0, 4, 0);
            label1.Name = "label1";
            label1.Size = new Size(61, 16);
            label1.TabIndex = 0;
            label1.Text = "Nhà hàng";
            // 
            // toolStrip1
            // 
            toolStrip1.ImageScalingSize = new Size(20, 20);
            toolStrip1.Items.AddRange(new ToolStripItem[] { SubBtnOrder, SubBtnSearch, closeUcListOrder });
            toolStrip1.Location = new Point(2, 28);
            toolStrip1.Name = "toolStrip1";
            toolStrip1.Size = new Size(1164, 27);
            toolStrip1.TabIndex = 0;
            toolStrip1.Text = "toolStrip1";
            // 
            // SubBtnOrder
            // 
            SubBtnOrder.Image = (Image)resources.GetObject("SubBtnOrder.Image");
            SubBtnOrder.ImageTransparentColor = Color.Magenta;
            SubBtnOrder.Name = "SubBtnOrder";
            SubBtnOrder.Size = new Size(97, 24);
            SubBtnOrder.Text = "Đặt Hàng";
            SubBtnOrder.Click += SubBtnOrder_Click;
            // 
            // SubBtnSearch
            // 
            SubBtnSearch.Image = (Image)resources.GetObject("SubBtnSearch.Image");
            SubBtnSearch.ImageTransparentColor = Color.Magenta;
            SubBtnSearch.Name = "SubBtnSearch";
            SubBtnSearch.Size = new Size(161, 24);
            SubBtnSearch.Text = "Tìm kiếm đơn hàng";
            SubBtnSearch.Click += SubBtnSearch_Click;
            // 
            // closeUcListOrder
            // 
            closeUcListOrder.Alignment = ToolStripItemAlignment.Right;
            closeUcListOrder.DisplayStyle = ToolStripItemDisplayStyle.Image;
            closeUcListOrder.Image = (Image)resources.GetObject("closeUcListOrder.Image");
            closeUcListOrder.ImageTransparentColor = Color.Magenta;
            closeUcListOrder.Name = "closeUcListOrder";
            closeUcListOrder.Size = new Size(29, 24);
            closeUcListOrder.Text = "Đơn hàng của tôi";
            closeUcListOrder.Click += closeUcListOrder_Click;
            // 
            // ucListOrder
            // 
            AutoScaleDimensions = new SizeF(7F, 16F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(groupControl1);
            Margin = new Padding(4, 2, 4, 2);
            Name = "ucListOrder";
            Size = new Size(1168, 722);
            Load += ucListOrder_Load;
            ((System.ComponentModel.ISupportInitialize)groupControl1).EndInit();
            groupControl1.ResumeLayout(false);
            groupControl1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)groupControl3).EndInit();
            groupControl3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)gridData).EndInit();
            ((System.ComponentModel.ISupportInitialize)gridView1).EndInit();
            ((System.ComponentModel.ISupportInitialize)groupControl4).EndInit();
            groupControl4.ResumeLayout(false);
            groupControl4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dtOrderDate.Properties.CalendarTimeProperties).EndInit();
            ((System.ComponentModel.ISupportInitialize)dtOrderDate.Properties).EndInit();
            ((System.ComponentModel.ISupportInitialize)groupControl2).EndInit();
            groupControl2.ResumeLayout(false);
            groupControl2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)txtTile.Properties).EndInit();
            ((System.ComponentModel.ISupportInitialize)txtUserName.Properties).EndInit();
            ((System.ComponentModel.ISupportInitialize)cboRestaurant.Properties).EndInit();
            toolStrip1.ResumeLayout(false);
            toolStrip1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private DevExpress.XtraEditors.GroupControl groupControl1;
        private ToolStrip toolStrip1;
        private ToolStripButton SubBtnOrder;
        private DevExpress.XtraEditors.GroupControl groupControl2;
        private DevExpress.XtraEditors.GroupControl groupControl3;
        private Label label1;
        private DevExpress.XtraEditors.ComboBoxEdit cboRestaurant;
        private ToolStripButton SubBtnSearch;
        private ToolStripButton closeUcListOrder;
        private Label label3;
        private DevExpress.XtraEditors.TextEdit txtUserName;
        private DevExpress.XtraEditors.TextEdit txtTile;
        private Label label4;
        private DevExpress.XtraEditors.GroupControl groupControl4;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraEditors.DateEdit dtOrderDate;
        private DevExpress.XtraGrid.GridControl gridData;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
    }
}
