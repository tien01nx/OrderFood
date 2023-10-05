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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ucOrder));
            closeUcOrder = new ToolStripButton();
            SubBtnSearch = new ToolStripButton();
            SubBtnOrder = new ToolStripButton();
            groupControl1 = new DevExpress.XtraEditors.GroupControl();
            groupControl2 = new DevExpress.XtraEditors.GroupControl();
            groupControl4 = new DevExpress.XtraEditors.GroupControl();
            groupControl6 = new DevExpress.XtraEditors.GroupControl();
            gridDataProduct = new DevExpress.XtraGrid.GridControl();
            layoutView1 = new DevExpress.XtraGrid.Views.Layout.LayoutView();
            layoutViewCard1 = new DevExpress.XtraGrid.Views.Layout.LayoutViewCard();
            groupControl5 = new DevExpress.XtraEditors.GroupControl();
            lblRestaurant = new DevExpress.XtraEditors.LabelControl();
            dtOrderDate = new DevExpress.XtraEditors.DateEdit();
            labelControl1 = new DevExpress.XtraEditors.LabelControl();
            groupControl3 = new DevExpress.XtraEditors.GroupControl();
            gridDataUser = new DevExpress.XtraGrid.GridControl();
            gridView2 = new DevExpress.XtraGrid.Views.Grid.GridView();
            toolStrip1 = new ToolStrip();
            SubBtnDelete = new ToolStripButton();
            ((System.ComponentModel.ISupportInitialize)groupControl1).BeginInit();
            groupControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)groupControl2).BeginInit();
            groupControl2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)groupControl4).BeginInit();
            groupControl4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)groupControl6).BeginInit();
            groupControl6.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)gridDataProduct).BeginInit();
            ((System.ComponentModel.ISupportInitialize)layoutView1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)layoutViewCard1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)groupControl5).BeginInit();
            groupControl5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dtOrderDate.Properties).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dtOrderDate.Properties.CalendarTimeProperties).BeginInit();
            ((System.ComponentModel.ISupportInitialize)groupControl3).BeginInit();
            groupControl3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)gridDataUser).BeginInit();
            ((System.ComponentModel.ISupportInitialize)gridView2).BeginInit();
            toolStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // closeUcOrder
            // 
            closeUcOrder.Alignment = ToolStripItemAlignment.Right;
            closeUcOrder.DisplayStyle = ToolStripItemDisplayStyle.Image;
            closeUcOrder.Image = (Image)resources.GetObject("closeUcOrder.Image");
            closeUcOrder.ImageTransparentColor = Color.Magenta;
            closeUcOrder.Name = "closeUcOrder";
            closeUcOrder.Size = new Size(24, 24);
            closeUcOrder.Text = "Đơn hàng của tôi";
            closeUcOrder.Click += closeUcOrder_Click;
            // 
            // SubBtnSearch
            // 
            SubBtnSearch.Image = (Image)resources.GetObject("SubBtnSearch.Image");
            SubBtnSearch.ImageTransparentColor = Color.Magenta;
            SubBtnSearch.Name = "SubBtnSearch";
            SubBtnSearch.Size = new Size(134, 24);
            SubBtnSearch.Text = "Tìm kiếm đơn hàng";
            SubBtnSearch.Click += SubBtnSearch_Click;
            // 
            // SubBtnOrder
            // 
            SubBtnOrder.Image = (Image)resources.GetObject("SubBtnOrder.Image");
            SubBtnOrder.ImageTransparentColor = Color.Magenta;
            SubBtnOrder.Name = "SubBtnOrder";
            SubBtnOrder.Size = new Size(81, 24);
            SubBtnOrder.Text = "Đặt Hàng";
            // 
            // groupControl1
            // 
            groupControl1.Controls.Add(groupControl2);
            groupControl1.Controls.Add(toolStrip1);
            groupControl1.Dock = DockStyle.Fill;
            groupControl1.Location = new Point(0, 0);
            groupControl1.Margin = new Padding(3, 2, 3, 2);
            groupControl1.Name = "groupControl1";
            groupControl1.Size = new Size(1001, 587);
            groupControl1.TabIndex = 1;
            groupControl1.Text = "DANH SÁCH ĐẶT HÀNG";
            // 
            // groupControl2
            // 
            groupControl2.Controls.Add(groupControl4);
            groupControl2.Controls.Add(groupControl3);
            groupControl2.Dock = DockStyle.Fill;
            groupControl2.Location = new Point(2, 50);
            groupControl2.Name = "groupControl2";
            groupControl2.ShowCaption = false;
            groupControl2.Size = new Size(997, 535);
            groupControl2.TabIndex = 1;
            groupControl2.Text = "groupControl2";
            // 
            // groupControl4
            // 
            groupControl4.Controls.Add(groupControl6);
            groupControl4.Controls.Add(groupControl5);
            groupControl4.Dock = DockStyle.Fill;
            groupControl4.Location = new Point(2, 2);
            groupControl4.Name = "groupControl4";
            groupControl4.Size = new Size(993, 355);
            groupControl4.TabIndex = 1;
            groupControl4.Text = "DANH SÁCH SẢN PHẨM";
            // 
            // groupControl6
            // 
            groupControl6.Controls.Add(gridDataProduct);
            groupControl6.Dock = DockStyle.Fill;
            groupControl6.Location = new Point(2, 53);
            groupControl6.Name = "groupControl6";
            groupControl6.Size = new Size(989, 300);
            groupControl6.TabIndex = 1;
            groupControl6.Text = "DANH SÁCH SẢN PHẨM";
            // 
            // gridDataProduct
            // 
            gridDataProduct.Dock = DockStyle.Fill;
            gridDataProduct.Location = new Point(2, 23);
            gridDataProduct.MainView = layoutView1;
            gridDataProduct.Name = "gridDataProduct";
            gridDataProduct.Size = new Size(985, 275);
            gridDataProduct.TabIndex = 0;
            gridDataProduct.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] { layoutView1 });
            gridDataProduct.Click += gridDataProduct_Click;
            // 
            // layoutView1
            // 
            layoutView1.GridControl = gridDataProduct;
            layoutView1.Name = "layoutView1";
            layoutView1.TemplateCard = layoutViewCard1;
            // 
            // layoutViewCard1
            // 
            layoutViewCard1.HeaderButtonsLocation = DevExpress.Utils.GroupElementLocation.AfterText;
            layoutViewCard1.Name = "layoutViewCard1";
            // 
            // groupControl5
            // 
            groupControl5.Controls.Add(lblRestaurant);
            groupControl5.Controls.Add(dtOrderDate);
            groupControl5.Controls.Add(labelControl1);
            groupControl5.Dock = DockStyle.Top;
            groupControl5.Location = new Point(2, 23);
            groupControl5.Name = "groupControl5";
            groupControl5.ShowCaption = false;
            groupControl5.Size = new Size(989, 30);
            groupControl5.TabIndex = 0;
            groupControl5.Text = "groupControl5";
            // 
            // lblRestaurant
            // 
            lblRestaurant.Appearance.Font = new Font("Tahoma", 8.25F, FontStyle.Bold, GraphicsUnit.Point);
            lblRestaurant.Appearance.Options.UseFont = true;
            lblRestaurant.Location = new Point(243, 6);
            lblRestaurant.Name = "lblRestaurant";
            lblRestaurant.Size = new Size(52, 13);
            lblRestaurant.TabIndex = 2;
            lblRestaurant.Text = "Nhà hàng";
            // 
            // dtOrderDate
            // 
            dtOrderDate.EditValue = null;
            dtOrderDate.Location = new Point(72, 3);
            dtOrderDate.Name = "dtOrderDate";
            dtOrderDate.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] { new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo) });
            dtOrderDate.Properties.CalendarTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] { new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo) });
            dtOrderDate.Size = new Size(128, 20);
            dtOrderDate.TabIndex = 1;
            // 
            // labelControl1
            // 
            labelControl1.Appearance.Font = new Font("Tahoma", 8.25F, FontStyle.Bold, GraphicsUnit.Point);
            labelControl1.Appearance.Options.UseFont = true;
            labelControl1.Location = new Point(15, 7);
            labelControl1.Name = "labelControl1";
            labelControl1.Size = new Size(51, 13);
            labelControl1.TabIndex = 0;
            labelControl1.Text = "Thời gian";
            // 
            // groupControl3
            // 
            groupControl3.Controls.Add(gridDataUser);
            groupControl3.Dock = DockStyle.Bottom;
            groupControl3.Location = new Point(2, 357);
            groupControl3.Name = "groupControl3";
            groupControl3.Size = new Size(993, 176);
            groupControl3.TabIndex = 0;
            groupControl3.Text = "DANH SÁCH ĐÃ ĐẶT";
            // 
            // gridDataUser
            // 
            gridDataUser.Dock = DockStyle.Fill;
            gridDataUser.Location = new Point(2, 23);
            gridDataUser.MainView = gridView2;
            gridDataUser.Name = "gridDataUser";
            gridDataUser.Size = new Size(989, 151);
            gridDataUser.TabIndex = 0;
            gridDataUser.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] { gridView2 });
            // 
            // gridView2
            // 
            gridView2.GridControl = gridDataUser;
            gridView2.Name = "gridView2";
            gridView2.OptionsBehavior.Editable = false;
            gridView2.OptionsView.ShowGroupPanel = false;
            gridView2.OptionsView.ShowIndicator = false;
            // 
            // toolStrip1
            // 
            toolStrip1.ImageScalingSize = new Size(20, 20);
            toolStrip1.Items.AddRange(new ToolStripItem[] { SubBtnOrder, SubBtnSearch, closeUcOrder, SubBtnDelete });
            toolStrip1.Location = new Point(2, 23);
            toolStrip1.Name = "toolStrip1";
            toolStrip1.Size = new Size(997, 27);
            toolStrip1.TabIndex = 0;
            toolStrip1.Text = "toolStrip1";
            // 
            // SubBtnDelete
            // 
            SubBtnDelete.Image = (Image)resources.GetObject("SubBtnDelete.Image");
            SubBtnDelete.ImageTransparentColor = Color.Magenta;
            SubBtnDelete.Name = "SubBtnDelete";
            SubBtnDelete.Size = new Size(105, 24);
            SubBtnDelete.Text = "Xóa đơn hàng";
            SubBtnDelete.Click += SubBtnDelete_Click;
            // 
            // ucOrder
            // 
            AutoScaleDimensions = new SizeF(6F, 13F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(groupControl1);
            Margin = new Padding(3, 2, 3, 2);
            Name = "ucOrder";
            Size = new Size(1001, 587);
            Load += ucOrder_Load;
            ((System.ComponentModel.ISupportInitialize)groupControl1).EndInit();
            groupControl1.ResumeLayout(false);
            groupControl1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)groupControl2).EndInit();
            groupControl2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)groupControl4).EndInit();
            groupControl4.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)groupControl6).EndInit();
            groupControl6.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)gridDataProduct).EndInit();
            ((System.ComponentModel.ISupportInitialize)layoutView1).EndInit();
            ((System.ComponentModel.ISupportInitialize)layoutViewCard1).EndInit();
            ((System.ComponentModel.ISupportInitialize)groupControl5).EndInit();
            groupControl5.ResumeLayout(false);
            groupControl5.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dtOrderDate.Properties.CalendarTimeProperties).EndInit();
            ((System.ComponentModel.ISupportInitialize)dtOrderDate.Properties).EndInit();
            ((System.ComponentModel.ISupportInitialize)groupControl3).EndInit();
            groupControl3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)gridDataUser).EndInit();
            ((System.ComponentModel.ISupportInitialize)gridView2).EndInit();
            toolStrip1.ResumeLayout(false);
            toolStrip1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion
        private ToolStripButton closeUcOrder;
        private ToolStripButton SubBtnSearch;
        private ToolStripButton SubBtnOrder;
        private DevExpress.XtraEditors.GroupControl groupControl1;
        private ToolStrip toolStrip1;
        private ToolStripButton SubBtnDelete;
        private DevExpress.XtraEditors.GroupControl groupControl2;
        private DevExpress.XtraEditors.GroupControl groupControl4;
        private DevExpress.XtraEditors.GroupControl groupControl3;
        private DevExpress.XtraGrid.GridControl gridDataUser;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView2;
        private DevExpress.XtraEditors.GroupControl groupControl6;
        private DevExpress.XtraEditors.GroupControl groupControl5;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraEditors.DateEdit dtOrderDate;
        private DevExpress.XtraEditors.LabelControl lblRestaurant;
        private DevExpress.XtraGrid.GridControl gridDataProduct;
        private DevExpress.XtraGrid.Views.Layout.LayoutView layoutView1;
        private DevExpress.XtraGrid.Views.Layout.LayoutViewCard layoutViewCard1;
    }
}
