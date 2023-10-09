﻿namespace Client.UserControls
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
            DevExpress.XtraGrid.GridLevelNode gridLevelNode1 = new DevExpress.XtraGrid.GridLevelNode();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ucOrder));
            gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            gridDataUser = new DevExpress.XtraGrid.GridControl();
            gridView2 = new DevExpress.XtraGrid.Views.Grid.GridView();
            TitleProduct = new DevExpress.XtraGrid.Columns.GridColumn();
            TotalQuantity = new DevExpress.XtraGrid.Columns.GridColumn();
            PriceProduct = new DevExpress.XtraGrid.Columns.GridColumn();
            Delete = new DevExpress.XtraGrid.Columns.GridColumn();
            btnDelete = new DevExpress.XtraEditors.Repository.RepositoryItemButtonEdit();
            RestaurantName = new DevExpress.XtraGrid.Columns.GridColumn();
            repositoryItemButtonEdit1 = new DevExpress.XtraEditors.Repository.RepositoryItemButtonEdit();
            closeUcOrder = new ToolStripButton();
            SubBtnOrder = new ToolStripButton();
            groupControl1 = new DevExpress.XtraEditors.GroupControl();
            groupControl2 = new DevExpress.XtraEditors.GroupControl();
            groupControl4 = new DevExpress.XtraEditors.GroupControl();
            groupControl6 = new DevExpress.XtraEditors.GroupControl();
            ludRestaurant = new DevExpress.XtraEditors.LookUpEdit();
            lblRestaurant = new DevExpress.XtraEditors.LabelControl();
            gridDataProduct = new DevExpress.XtraGrid.GridControl();
            layoutView = new DevExpress.XtraGrid.Views.Layout.LayoutView();
            IsSelected = new DevExpress.XtraGrid.Columns.LayoutViewColumn();
            checkOrder = new DevExpress.XtraEditors.Repository.RepositoryItemCheckEdit();
            layoutViewField_IsSelected = new DevExpress.XtraGrid.Views.Layout.LayoutViewField();
            ProductName = new DevExpress.XtraGrid.Columns.LayoutViewColumn();
            layoutViewField_Title = new DevExpress.XtraGrid.Views.Layout.LayoutViewField();
            Price = new DevExpress.XtraGrid.Columns.LayoutViewColumn();
            layoutViewField_Price = new DevExpress.XtraGrid.Views.Layout.LayoutViewField();
            Quantity = new DevExpress.XtraGrid.Columns.LayoutViewColumn();
            spdtQuantity = new DevExpress.XtraEditors.Repository.RepositoryItemSpinEdit();
            layoutViewField_Quantity = new DevExpress.XtraGrid.Views.Layout.LayoutViewField();
            Images = new DevExpress.XtraGrid.Columns.LayoutViewColumn();
            svgImage = new DevExpress.XtraEditors.Repository.RepositoryItemPictureEdit();
            layoutViewField_Image = new DevExpress.XtraGrid.Views.Layout.LayoutViewField();
            layoutViewCard1 = new DevExpress.XtraGrid.Views.Layout.LayoutViewCard();
            groupControl5 = new DevExpress.XtraEditors.GroupControl();
            dtOrderDate = new DevExpress.XtraEditors.DateEdit();
            labelControl1 = new DevExpress.XtraEditors.LabelControl();
            groupControl3 = new DevExpress.XtraEditors.GroupControl();
            toolStrip1 = new ToolStrip();
            SubBtnDelete = new ToolStripButton();
            ((System.ComponentModel.ISupportInitialize)gridView1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)gridDataUser).BeginInit();
            ((System.ComponentModel.ISupportInitialize)gridView2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)btnDelete).BeginInit();
            ((System.ComponentModel.ISupportInitialize)repositoryItemButtonEdit1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)groupControl1).BeginInit();
            groupControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)groupControl2).BeginInit();
            groupControl2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)groupControl4).BeginInit();
            groupControl4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)groupControl6).BeginInit();
            groupControl6.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)ludRestaurant.Properties).BeginInit();
            ((System.ComponentModel.ISupportInitialize)gridDataProduct).BeginInit();
            ((System.ComponentModel.ISupportInitialize)layoutView).BeginInit();
            ((System.ComponentModel.ISupportInitialize)checkOrder).BeginInit();
            ((System.ComponentModel.ISupportInitialize)layoutViewField_IsSelected).BeginInit();
            ((System.ComponentModel.ISupportInitialize)layoutViewField_Title).BeginInit();
            ((System.ComponentModel.ISupportInitialize)layoutViewField_Price).BeginInit();
            ((System.ComponentModel.ISupportInitialize)spdtQuantity).BeginInit();
            ((System.ComponentModel.ISupportInitialize)layoutViewField_Quantity).BeginInit();
            ((System.ComponentModel.ISupportInitialize)svgImage).BeginInit();
            ((System.ComponentModel.ISupportInitialize)layoutViewField_Image).BeginInit();
            ((System.ComponentModel.ISupportInitialize)layoutViewCard1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)groupControl5).BeginInit();
            groupControl5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dtOrderDate.Properties).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dtOrderDate.Properties.CalendarTimeProperties).BeginInit();
            ((System.ComponentModel.ISupportInitialize)groupControl3).BeginInit();
            groupControl3.SuspendLayout();
            toolStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // gridView1
            // 
            gridView1.GridControl = gridDataUser;
            gridView1.Name = "gridView1";
            // 
            // gridDataUser
            // 
            gridDataUser.Dock = DockStyle.Fill;
            gridDataUser.EmbeddedNavigator.Margin = new Padding(4);
            gridLevelNode1.LevelTemplate = gridView1;
            gridLevelNode1.RelationName = "Level1";
            gridDataUser.LevelTree.Nodes.AddRange(new DevExpress.XtraGrid.GridLevelNode[] { gridLevelNode1 });
            gridDataUser.Location = new Point(2, 28);
            gridDataUser.MainView = gridView2;
            gridDataUser.Margin = new Padding(4);
            gridDataUser.Name = "gridDataUser";
            gridDataUser.RepositoryItems.AddRange(new DevExpress.XtraEditors.Repository.RepositoryItem[] { btnDelete, repositoryItemButtonEdit1 });
            gridDataUser.Size = new Size(1156, 206);
            gridDataUser.TabIndex = 0;
            gridDataUser.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] { gridView2, gridView1 });
            // 
            // gridView2
            // 
            gridView2.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] { TitleProduct, TotalQuantity, PriceProduct, Delete, RestaurantName });
            gridView2.DetailHeight = 431;
            gridView2.GridControl = gridDataUser;
            gridView2.Name = "gridView2";
            gridView2.OptionsBehavior.Editable = false;
            gridView2.OptionsEditForm.PopupEditFormWidth = 933;
            gridView2.OptionsFind.AlwaysVisible = true;
            gridView2.OptionsView.ShowFooter = true;
            gridView2.OptionsView.ShowGroupPanel = false;
            gridView2.OptionsView.ShowIndicator = false;
            // 
            // TitleProduct
            // 
            TitleProduct.Caption = "Sản phẩm";
            TitleProduct.FieldName = "ProductName";
            TitleProduct.MinWidth = 24;
            TitleProduct.Name = "TitleProduct";
            TitleProduct.Visible = true;
            TitleProduct.VisibleIndex = 0;
            TitleProduct.Width = 94;
            // 
            // TotalQuantity
            // 
            TotalQuantity.Caption = "Số lượng";
            TotalQuantity.FieldName = "TotalQuantity";
            TotalQuantity.MinWidth = 24;
            TotalQuantity.Name = "TotalQuantity";
            TotalQuantity.Summary.AddRange(new DevExpress.XtraGrid.GridSummaryItem[] { new DevExpress.XtraGrid.GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Sum, "TotalQuantity", "SUM={0:0.##}") });
            TotalQuantity.Visible = true;
            TotalQuantity.VisibleIndex = 2;
            TotalQuantity.Width = 94;
            // 
            // PriceProduct
            // 
            PriceProduct.Caption = "Thành tiền";
            PriceProduct.FieldName = "TotalPrice";
            PriceProduct.MinWidth = 24;
            PriceProduct.Name = "PriceProduct";
            PriceProduct.Summary.AddRange(new DevExpress.XtraGrid.GridSummaryItem[] { new DevExpress.XtraGrid.GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Sum, "TotalPrice", "SUM={0:0.##}") });
            PriceProduct.Visible = true;
            PriceProduct.VisibleIndex = 1;
            PriceProduct.Width = 94;
            // 
            // Delete
            // 
            Delete.Caption = "Delete";
            Delete.ColumnEdit = btnDelete;
            Delete.MinWidth = 24;
            Delete.Name = "Delete";
            Delete.Visible = true;
            Delete.VisibleIndex = 3;
            Delete.Width = 94;
            // 
            // btnDelete
            // 
            btnDelete.AutoHeight = false;
            btnDelete.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] { new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Delete) });
            btnDelete.Name = "btnDelete";
            btnDelete.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.HideTextEditor;
            btnDelete.Click += btnDelete_Click;
            // 
            // RestaurantName
            // 
            RestaurantName.Caption = "Nhà hàng";
            RestaurantName.FieldName = "RestaurantName";
            RestaurantName.MinWidth = 25;
            RestaurantName.Name = "RestaurantName";
            RestaurantName.Visible = true;
            RestaurantName.VisibleIndex = 4;
            RestaurantName.Width = 87;
            // 
            // repositoryItemButtonEdit1
            // 
            repositoryItemButtonEdit1.AutoHeight = false;
            repositoryItemButtonEdit1.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] { new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Delete) });
            repositoryItemButtonEdit1.Name = "repositoryItemButtonEdit1";
            repositoryItemButtonEdit1.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.HideTextEditor;
            repositoryItemButtonEdit1.Click += repositoryItemButtonEdit1_Click;
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
            // SubBtnOrder
            // 
            SubBtnOrder.Image = (Image)resources.GetObject("SubBtnOrder.Image");
            SubBtnOrder.ImageTransparentColor = Color.Magenta;
            SubBtnOrder.Name = "SubBtnOrder";
            SubBtnOrder.Size = new Size(97, 24);
            SubBtnOrder.Text = "Đặt Hàng";
            SubBtnOrder.Click += SubBtnOrder_Click;
            // 
            // groupControl1
            // 
            groupControl1.Controls.Add(groupControl2);
            groupControl1.Controls.Add(toolStrip1);
            groupControl1.Dock = DockStyle.Fill;
            groupControl1.Location = new Point(0, 0);
            groupControl1.Margin = new Padding(4, 2, 4, 2);
            groupControl1.Name = "groupControl1";
            groupControl1.Size = new Size(1168, 722);
            groupControl1.TabIndex = 1;
            groupControl1.Text = "ĐƠN ĐẶT HÀNG";
            // 
            // groupControl2
            // 
            groupControl2.Controls.Add(groupControl4);
            groupControl2.Controls.Add(groupControl3);
            groupControl2.Dock = DockStyle.Fill;
            groupControl2.Location = new Point(2, 55);
            groupControl2.Margin = new Padding(4);
            groupControl2.Name = "groupControl2";
            groupControl2.ShowCaption = false;
            groupControl2.Size = new Size(1164, 665);
            groupControl2.TabIndex = 1;
            groupControl2.Text = "groupControl2";
            // 
            // groupControl4
            // 
            groupControl4.Controls.Add(groupControl6);
            groupControl4.Controls.Add(groupControl5);
            groupControl4.Dock = DockStyle.Fill;
            groupControl4.Location = new Point(2, 2);
            groupControl4.Margin = new Padding(4);
            groupControl4.Name = "groupControl4";
            groupControl4.Size = new Size(1160, 425);
            groupControl4.TabIndex = 1;
            groupControl4.Text = "THÔNG TIN ĐƠN HÀNG";
            // 
            // groupControl6
            // 
            groupControl6.Controls.Add(ludRestaurant);
            groupControl6.Controls.Add(lblRestaurant);
            groupControl6.Controls.Add(gridDataProduct);
            groupControl6.Dock = DockStyle.Fill;
            groupControl6.Location = new Point(2, 65);
            groupControl6.Margin = new Padding(4);
            groupControl6.Name = "groupControl6";
            groupControl6.Size = new Size(1156, 358);
            groupControl6.TabIndex = 1;
            groupControl6.Text = "DANH SÁCH CÁC MÓN ĂN";
            // 
            // ludRestaurant
            // 
            ludRestaurant.Location = new Point(660, 42);
            ludRestaurant.Margin = new Padding(4, 2, 4, 2);
            ludRestaurant.Name = "ludRestaurant";
            ludRestaurant.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] { new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo) });
            ludRestaurant.Properties.NullText = "Chọn nhà hàng";
            ludRestaurant.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.Standard;
            ludRestaurant.Size = new Size(204, 22);
            ludRestaurant.TabIndex = 3;
            ludRestaurant.EditValueChanged += ludRestaurant_EditValueChanged;
            // 
            // lblRestaurant
            // 
            lblRestaurant.Appearance.Font = new Font("Tahoma", 8.25F, FontStyle.Bold, GraphicsUnit.Point);
            lblRestaurant.Appearance.Options.UseFont = true;
            lblRestaurant.Location = new Point(574, 46);
            lblRestaurant.Margin = new Padding(4);
            lblRestaurant.Name = "lblRestaurant";
            lblRestaurant.Size = new Size(67, 17);
            lblRestaurant.TabIndex = 2;
            lblRestaurant.Text = "Nhà hàng";
            lblRestaurant.Click += lblRestaurant_Click;
            // 
            // gridDataProduct
            // 
            gridDataProduct.Dock = DockStyle.Fill;
            gridDataProduct.EmbeddedNavigator.Margin = new Padding(4);
            gridDataProduct.Font = new Font("Tahoma", 7.8F, FontStyle.Bold, GraphicsUnit.Point);
            gridDataProduct.Location = new Point(2, 28);
            gridDataProduct.MainView = layoutView;
            gridDataProduct.Margin = new Padding(4);
            gridDataProduct.Name = "gridDataProduct";
            gridDataProduct.RepositoryItems.AddRange(new DevExpress.XtraEditors.Repository.RepositoryItem[] { spdtQuantity, svgImage, checkOrder });
            gridDataProduct.Size = new Size(1152, 328);
            gridDataProduct.TabIndex = 0;
            gridDataProduct.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] { layoutView });
            // 
            // layoutView
            // 
            layoutView.CardMinSize = new Size(229, 263);
            layoutView.Columns.AddRange(new DevExpress.XtraGrid.Columns.LayoutViewColumn[] { IsSelected, ProductName, Price, Quantity, Images });
            layoutView.DetailHeight = 431;
            layoutView.GridControl = gridDataProduct;
            layoutView.Name = "layoutView";
            layoutView.OptionsFind.AlwaysVisible = true;
            layoutView.OptionsView.ShowHeaderPanel = false;
            layoutView.OptionsView.ViewMode = DevExpress.XtraGrid.Views.Layout.LayoutViewMode.MultiRow;
            layoutView.SortInfo.AddRange(new DevExpress.XtraGrid.Columns.GridColumnSortInfo[] { new DevExpress.XtraGrid.Columns.GridColumnSortInfo(ProductName, DevExpress.Data.ColumnSortOrder.Ascending) });
            layoutView.TemplateCard = layoutViewCard1;
            // 
            // IsSelected
            // 
            IsSelected.Caption = "IsSelected";
            IsSelected.ColumnEdit = checkOrder;
            IsSelected.FieldName = "IsSelected";
            IsSelected.LayoutViewField = layoutViewField_IsSelected;
            IsSelected.MinWidth = 24;
            IsSelected.Name = "IsSelected";
            IsSelected.Width = 94;
            // 
            // checkOrder
            // 
            checkOrder.AutoHeight = false;
            checkOrder.Name = "checkOrder";
            checkOrder.CheckedChanged += checkOrder_CheckedChanged;
            checkOrder.Click += checkOrder_Click;
            // 
            // layoutViewField_IsSelected
            // 
            layoutViewField_IsSelected.EditorPreferredWidth = 136;
            layoutViewField_IsSelected.Location = new Point(0, 0);
            layoutViewField_IsSelected.Name = "layoutViewField_IsSelected";
            layoutViewField_IsSelected.Size = new Size(216, 24);
            layoutViewField_IsSelected.TextSize = new Size(87, 16);
            // 
            // ProductName
            // 
            ProductName.AppearanceCell.Font = new Font("Tahoma", 7.8F, FontStyle.Bold, GraphicsUnit.Point);
            ProductName.AppearanceCell.Options.UseFont = true;
            ProductName.Caption = "Tên sản phẩm";
            ProductName.FieldName = "ProductName";
            ProductName.LayoutViewField = layoutViewField_Title;
            ProductName.MinWidth = 24;
            ProductName.Name = "ProductName";
            ProductName.Width = 94;
            // 
            // layoutViewField_Title
            // 
            layoutViewField_Title.EditorPreferredWidth = 136;
            layoutViewField_Title.Location = new Point(0, 24);
            layoutViewField_Title.Name = "layoutViewField_Title";
            layoutViewField_Title.Size = new Size(216, 24);
            layoutViewField_Title.TextSize = new Size(87, 16);
            // 
            // Price
            // 
            Price.AppearanceCell.Font = new Font("Tahoma", 7.8F, FontStyle.Bold, GraphicsUnit.Point);
            Price.AppearanceCell.ForeColor = Color.Red;
            Price.AppearanceCell.Options.UseFont = true;
            Price.AppearanceCell.Options.UseForeColor = true;
            Price.Caption = "Price";
            Price.FieldName = "Price";
            Price.LayoutViewField = layoutViewField_Price;
            Price.MinWidth = 24;
            Price.Name = "Price";
            Price.OptionsColumn.AllowEdit = false;
            Price.Width = 94;
            // 
            // layoutViewField_Price
            // 
            layoutViewField_Price.EditorPreferredWidth = 136;
            layoutViewField_Price.Location = new Point(0, 48);
            layoutViewField_Price.Name = "layoutViewField_Price";
            layoutViewField_Price.Size = new Size(216, 24);
            layoutViewField_Price.TextSize = new Size(87, 16);
            // 
            // Quantity
            // 
            Quantity.AppearanceCell.BackColor = Color.White;
            Quantity.AppearanceCell.Font = new Font("Tahoma", 7.8F, FontStyle.Bold, GraphicsUnit.Point);
            Quantity.AppearanceCell.ForeColor = Color.Lime;
            Quantity.AppearanceCell.Options.UseBackColor = true;
            Quantity.AppearanceCell.Options.UseFont = true;
            Quantity.AppearanceCell.Options.UseForeColor = true;
            Quantity.Caption = "Số lượng";
            Quantity.ColumnEdit = spdtQuantity;
            Quantity.FieldName = "Quantity";
            Quantity.LayoutViewField = layoutViewField_Quantity;
            Quantity.MinWidth = 24;
            Quantity.Name = "Quantity";
            Quantity.Width = 94;
            // 
            // spdtQuantity
            // 
            spdtQuantity.AutoHeight = false;
            spdtQuantity.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] { new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo) });
            spdtQuantity.EditValueChangedDelay = 1;
            spdtQuantity.MaxValue = new decimal(new int[] { 100, 0, 0, 0 });
            spdtQuantity.MinValue = new decimal(new int[] { 1, 0, 0, 0 });
            spdtQuantity.Name = "spdtQuantity";
            spdtQuantity.NullText = "1";
            spdtQuantity.NullValuePrompt = "1";
            spdtQuantity.EditValueChanged += spdtPrice_EditValueChanged;
            // 
            // layoutViewField_Quantity
            // 
            layoutViewField_Quantity.EditorPreferredWidth = 136;
            layoutViewField_Quantity.Location = new Point(0, 72);
            layoutViewField_Quantity.Name = "layoutViewField_Quantity";
            layoutViewField_Quantity.Size = new Size(216, 24);
            layoutViewField_Quantity.TextSize = new Size(87, 16);
            // 
            // Images
            // 
            Images.Caption = "Hình ảnh";
            Images.ColumnEdit = svgImage;
            Images.FieldName = "Image";
            Images.LayoutViewField = layoutViewField_Image;
            Images.MinWidth = 24;
            Images.Name = "Images";
            Images.OptionsColumn.FixedWidth = true;
            Images.Width = 94;
            // 
            // svgImage
            // 
            svgImage.CustomHeight = 100;
            svgImage.Name = "svgImage";
            svgImage.ShowMenu = false;
            svgImage.SizeMode = DevExpress.XtraEditors.Controls.PictureSizeMode.Zoom;
            svgImage.SvgImageSize = new Size(100, 100);
            // 
            // layoutViewField_Image
            // 
            layoutViewField_Image.EditorPreferredWidth = 136;
            layoutViewField_Image.Location = new Point(0, 96);
            layoutViewField_Image.Name = "layoutViewField_Image";
            layoutViewField_Image.Size = new Size(216, 110);
            layoutViewField_Image.StartNewLine = true;
            layoutViewField_Image.TextSize = new Size(87, 16);
            // 
            // layoutViewCard1
            // 
            layoutViewCard1.CustomizationFormText = "TemplateCard";
            layoutViewCard1.HeaderButtonsLocation = DevExpress.Utils.GroupElementLocation.AfterText;
            layoutViewCard1.Items.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[] { layoutViewField_IsSelected, layoutViewField_Title, layoutViewField_Price, layoutViewField_Quantity, layoutViewField_Image });
            layoutViewCard1.Name = "layoutViewTemplateCard";
            layoutViewCard1.OptionsItemText.TextToControlDistance = 5;
            layoutViewCard1.Text = "TemplateCard";
            // 
            // groupControl5
            // 
            groupControl5.Controls.Add(dtOrderDate);
            groupControl5.Controls.Add(labelControl1);
            groupControl5.Dock = DockStyle.Top;
            groupControl5.Location = new Point(2, 28);
            groupControl5.Margin = new Padding(4);
            groupControl5.Name = "groupControl5";
            groupControl5.ShowCaption = false;
            groupControl5.Size = new Size(1156, 37);
            groupControl5.TabIndex = 0;
            groupControl5.Text = "groupControl5";
            // 
            // dtOrderDate
            // 
            dtOrderDate.EditValue = null;
            dtOrderDate.Location = new Point(84, 4);
            dtOrderDate.Margin = new Padding(4);
            dtOrderDate.Name = "dtOrderDate";
            dtOrderDate.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] { new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo) });
            dtOrderDate.Properties.CalendarTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] { new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo) });
            dtOrderDate.Size = new Size(149, 22);
            dtOrderDate.TabIndex = 1;
            dtOrderDate.EditValueChanged += dtOrderDate_EditValueChanged;
            // 
            // labelControl1
            // 
            labelControl1.Appearance.Font = new Font("Tahoma", 8.25F, FontStyle.Bold, GraphicsUnit.Point);
            labelControl1.Appearance.Options.UseFont = true;
            labelControl1.Location = new Point(18, 9);
            labelControl1.Margin = new Padding(4);
            labelControl1.Name = "labelControl1";
            labelControl1.Size = new Size(63, 17);
            labelControl1.TabIndex = 0;
            labelControl1.Text = "Ngày đặt";
            // 
            // groupControl3
            // 
            groupControl3.Controls.Add(gridDataUser);
            groupControl3.Dock = DockStyle.Bottom;
            groupControl3.Location = new Point(2, 427);
            groupControl3.Margin = new Padding(4);
            groupControl3.Name = "groupControl3";
            groupControl3.Size = new Size(1160, 236);
            groupControl3.TabIndex = 0;
            groupControl3.Text = "CÁC MÓN ĂN ĐÃ ĐẶT";
            // 
            // toolStrip1
            // 
            toolStrip1.ImageScalingSize = new Size(20, 20);
            toolStrip1.Items.AddRange(new ToolStripItem[] { SubBtnOrder, closeUcOrder, SubBtnDelete });
            toolStrip1.Location = new Point(2, 28);
            toolStrip1.Name = "toolStrip1";
            toolStrip1.Size = new Size(1164, 27);
            toolStrip1.TabIndex = 0;
            toolStrip1.Text = "toolStrip1";
            // 
            // SubBtnDelete
            // 
            SubBtnDelete.Image = (Image)resources.GetObject("SubBtnDelete.Image");
            SubBtnDelete.ImageTransparentColor = Color.Magenta;
            SubBtnDelete.Name = "SubBtnDelete";
            SubBtnDelete.Size = new Size(126, 24);
            SubBtnDelete.Text = "Xóa đơn hàng";
            SubBtnDelete.Click += SubBtnDelete_Click;
            // 
            // ucOrder
            // 
            AutoScaleDimensions = new SizeF(7F, 16F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(groupControl1);
            Margin = new Padding(4, 2, 4, 2);
            Name = "ucOrder";
            Size = new Size(1168, 722);
            Load += ucOrder_Load;
            ((System.ComponentModel.ISupportInitialize)gridView1).EndInit();
            ((System.ComponentModel.ISupportInitialize)gridDataUser).EndInit();
            ((System.ComponentModel.ISupportInitialize)gridView2).EndInit();
            ((System.ComponentModel.ISupportInitialize)btnDelete).EndInit();
            ((System.ComponentModel.ISupportInitialize)repositoryItemButtonEdit1).EndInit();
            ((System.ComponentModel.ISupportInitialize)groupControl1).EndInit();
            groupControl1.ResumeLayout(false);
            groupControl1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)groupControl2).EndInit();
            groupControl2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)groupControl4).EndInit();
            groupControl4.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)groupControl6).EndInit();
            groupControl6.ResumeLayout(false);
            groupControl6.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)ludRestaurant.Properties).EndInit();
            ((System.ComponentModel.ISupportInitialize)gridDataProduct).EndInit();
            ((System.ComponentModel.ISupportInitialize)layoutView).EndInit();
            ((System.ComponentModel.ISupportInitialize)checkOrder).EndInit();
            ((System.ComponentModel.ISupportInitialize)layoutViewField_IsSelected).EndInit();
            ((System.ComponentModel.ISupportInitialize)layoutViewField_Title).EndInit();
            ((System.ComponentModel.ISupportInitialize)layoutViewField_Price).EndInit();
            ((System.ComponentModel.ISupportInitialize)spdtQuantity).EndInit();
            ((System.ComponentModel.ISupportInitialize)layoutViewField_Quantity).EndInit();
            ((System.ComponentModel.ISupportInitialize)svgImage).EndInit();
            ((System.ComponentModel.ISupportInitialize)layoutViewField_Image).EndInit();
            ((System.ComponentModel.ISupportInitialize)layoutViewCard1).EndInit();
            ((System.ComponentModel.ISupportInitialize)groupControl5).EndInit();
            groupControl5.ResumeLayout(false);
            groupControl5.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dtOrderDate.Properties.CalendarTimeProperties).EndInit();
            ((System.ComponentModel.ISupportInitialize)dtOrderDate.Properties).EndInit();
            ((System.ComponentModel.ISupportInitialize)groupControl3).EndInit();
            groupControl3.ResumeLayout(false);
            toolStrip1.ResumeLayout(false);
            toolStrip1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion
        private ToolStripButton closeUcOrder;
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
        private DevExpress.XtraEditors.Repository.RepositoryItemSpinEdit spdtQuantity;
        private DevExpress.XtraEditors.Repository.RepositoryItemPictureEdit svgImage;
        private DevExpress.XtraEditors.Repository.RepositoryItemCheckEdit checkOrder;
        private DevExpress.XtraGrid.Columns.GridColumn TitleProduct;
        private DevExpress.XtraGrid.Columns.GridColumn PriceProduct;
        private DevExpress.XtraGrid.Columns.GridColumn TotalQuantity;
        private DevExpress.XtraGrid.Views.Layout.LayoutView layoutView;
        private DevExpress.XtraGrid.Columns.LayoutViewColumn IsSelected;
        private DevExpress.XtraGrid.Columns.LayoutViewColumn ProductName;
        private DevExpress.XtraGrid.Columns.LayoutViewColumn Price;
        private DevExpress.XtraGrid.Columns.LayoutViewColumn Quantity;
        private DevExpress.XtraGrid.Columns.LayoutViewColumn Images;
        private DevExpress.XtraGrid.Columns.GridColumn Delete;
        private DevExpress.XtraEditors.Repository.RepositoryItemButtonEdit btnDelete;
        private DevExpress.XtraGrid.Views.Layout.LayoutViewField layoutViewField_IsSelected;
        private DevExpress.XtraGrid.Views.Layout.LayoutViewField layoutViewField_Title;
        private DevExpress.XtraGrid.Views.Layout.LayoutViewField layoutViewField_Price;
        private DevExpress.XtraGrid.Views.Layout.LayoutViewField layoutViewField_Quantity;
        private DevExpress.XtraGrid.Views.Layout.LayoutViewField layoutViewField_Image;
        private DevExpress.XtraGrid.Views.Layout.LayoutViewCard layoutViewCard1;
        private DevExpress.XtraGrid.Columns.GridColumn Editbutton;
        private DevExpress.XtraEditors.Repository.RepositoryItemButtonEdit repositoryItemButtonEdit1;
        private DevExpress.XtraEditors.LookUpEdit ludRestaurant;
        private DevExpress.XtraGrid.Columns.GridColumn RestaurantName;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
    }
}
