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
            svgProductImage = new DevExpress.XtraEditors.PictureEdit();
            RestaurantId = new DevExpress.XtraEditors.LabelControl();
            CategoryId = new DevExpress.XtraEditors.LabelControl();
            id = new DevExpress.XtraEditors.LabelControl();
            btnCategoryName = new DevExpress.XtraEditors.ButtonEdit();
            btnRestaurant = new DevExpress.XtraEditors.ButtonEdit();
            label8 = new Label();
            label7 = new Label();
            toolStrip1 = new ToolStrip();
            SubBtnClose = new ToolStripButton();
            spPrice = new DevExpress.XtraEditors.SpinEdit();
            label4 = new Label();
            mdDescription = new DevExpress.XtraEditors.MemoEdit();
            txtProductName = new DevExpress.XtraEditors.TextEdit();
            label3 = new Label();
            label1 = new Label();
            groupControl1 = new DevExpress.XtraEditors.GroupControl();
            groupControl2 = new DevExpress.XtraEditors.GroupControl();
            label5 = new Label();
            ((System.ComponentModel.ISupportInitialize)svgProductImage.Properties).BeginInit();
            ((System.ComponentModel.ISupportInitialize)btnCategoryName.Properties).BeginInit();
            ((System.ComponentModel.ISupportInitialize)btnRestaurant.Properties).BeginInit();
            toolStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)spPrice.Properties).BeginInit();
            ((System.ComponentModel.ISupportInitialize)mdDescription.Properties).BeginInit();
            ((System.ComponentModel.ISupportInitialize)txtProductName.Properties).BeginInit();
            ((System.ComponentModel.ISupportInitialize)groupControl1).BeginInit();
            groupControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)groupControl2).BeginInit();
            groupControl2.SuspendLayout();
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
            // svgProductImage
            // 
            svgProductImage.Location = new Point(406, 337);
            svgProductImage.Name = "svgProductImage";
            svgProductImage.Properties.ShowCameraMenuItem = DevExpress.XtraEditors.Controls.CameraMenuItemVisibility.Auto;
            svgProductImage.Properties.SizeMode = DevExpress.XtraEditors.Controls.PictureSizeMode.Zoom;
            svgProductImage.Size = new Size(303, 155);
            svgProductImage.TabIndex = 26;
            // 
            // RestaurantId
            // 
            RestaurantId.Location = new Point(312, 251);
            RestaurantId.Name = "RestaurantId";
            RestaurantId.Size = new Size(0, 13);
            RestaurantId.TabIndex = 22;
            RestaurantId.Visible = false;
            // 
            // CategoryId
            // 
            CategoryId.Location = new Point(290, 232);
            CategoryId.Name = "CategoryId";
            CategoryId.Size = new Size(0, 13);
            CategoryId.TabIndex = 21;
            CategoryId.Visible = false;
            // 
            // id
            // 
            id.Location = new Point(290, 203);
            id.Name = "id";
            id.Size = new Size(0, 13);
            id.TabIndex = 20;
            id.Visible = false;
            // 
            // btnCategoryName
            // 
            btnCategoryName.Location = new Point(406, 289);
            btnCategoryName.Name = "btnCategoryName";
            btnCategoryName.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] { new DevExpress.XtraEditors.Controls.EditorButton() });
            btnCategoryName.Size = new Size(303, 20);
            btnCategoryName.TabIndex = 19;
            // 
            // btnRestaurant
            // 
            btnRestaurant.EditValue = "Chọn nhà hàng";
            btnRestaurant.Location = new Point(406, 74);
            btnRestaurant.Name = "btnRestaurant";
            btnRestaurant.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] { new DevExpress.XtraEditors.Controls.EditorButton() });
            btnRestaurant.Size = new Size(302, 20);
            btnRestaurant.TabIndex = 18;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Tahoma", 8.25F, FontStyle.Bold, GraphicsUnit.Point);
            label8.Location = new Point(287, 337);
            label8.Name = "label8";
            label8.Size = new Size(111, 13);
            label8.TabIndex = 14;
            label8.Text = "Hình ảnh minh họa";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Tahoma", 8.25F, FontStyle.Bold, GraphicsUnit.Point);
            label7.Location = new Point(287, 292);
            label7.Name = "label7";
            label7.Size = new Size(88, 13);
            label7.TabIndex = 10;
            label7.Text = "Loại sản phẩm";
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
            // spPrice
            // 
            spPrice.EditValue = new decimal(new int[] { 2000, 0, 0, 0 });
            spPrice.Location = new Point(406, 141);
            spPrice.Name = "spPrice";
            spPrice.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] { new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo) });
            spPrice.Size = new Size(72, 20);
            spPrice.TabIndex = 7;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Tahoma", 8.25F, FontStyle.Bold, GraphicsUnit.Point);
            label4.Location = new Point(287, 179);
            label4.Name = "label4";
            label4.Size = new Size(97, 13);
            label4.TabIndex = 5;
            label4.Text = "Mô tả sản phẩm";
            // 
            // mdDescription
            // 
            mdDescription.Location = new Point(406, 178);
            mdDescription.Name = "mdDescription";
            mdDescription.Size = new Size(303, 96);
            mdDescription.TabIndex = 4;
            // 
            // txtProductName
            // 
            txtProductName.Location = new Point(406, 108);
            txtProductName.Name = "txtProductName";
            txtProductName.Size = new Size(300, 20);
            txtProductName.TabIndex = 3;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Tahoma", 8.25F, FontStyle.Bold, GraphicsUnit.Point);
            label3.Location = new Point(287, 111);
            label3.Name = "label3";
            label3.Size = new Size(86, 13);
            label3.TabIndex = 2;
            label3.Text = "Tên sản phẩm";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Tahoma", 8.25F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(287, 77);
            label1.Name = "label1";
            label1.Size = new Size(59, 13);
            label1.TabIndex = 0;
            label1.Text = "Nhà hàng";
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
            groupControl2.Controls.Add(svgProductImage);
            groupControl2.Controls.Add(RestaurantId);
            groupControl2.Controls.Add(CategoryId);
            groupControl2.Controls.Add(id);
            groupControl2.Controls.Add(btnCategoryName);
            groupControl2.Controls.Add(btnRestaurant);
            groupControl2.Controls.Add(label8);
            groupControl2.Controls.Add(label7);
            groupControl2.Controls.Add(spPrice);
            groupControl2.Controls.Add(label5);
            groupControl2.Controls.Add(label4);
            groupControl2.Controls.Add(mdDescription);
            groupControl2.Controls.Add(txtProductName);
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
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Tahoma", 8.25F, FontStyle.Bold, GraphicsUnit.Point);
            label5.ForeColor = Color.Red;
            label5.Location = new Point(287, 148);
            label5.Name = "label5";
            label5.Size = new Size(35, 13);
            label5.TabIndex = 6;
            label5.Text = "Price";
            // 
            // ucUser
            // 
            AutoScaleDimensions = new SizeF(6F, 13F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(groupControl1);
            Name = "ucUser";
            Size = new Size(1001, 587);
            ((System.ComponentModel.ISupportInitialize)svgProductImage.Properties).EndInit();
            ((System.ComponentModel.ISupportInitialize)btnCategoryName.Properties).EndInit();
            ((System.ComponentModel.ISupportInitialize)btnRestaurant.Properties).EndInit();
            toolStrip1.ResumeLayout(false);
            toolStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)spPrice.Properties).EndInit();
            ((System.ComponentModel.ISupportInitialize)mdDescription.Properties).EndInit();
            ((System.ComponentModel.ISupportInitialize)txtProductName.Properties).EndInit();
            ((System.ComponentModel.ISupportInitialize)groupControl1).EndInit();
            groupControl1.ResumeLayout(false);
            groupControl1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)groupControl2).EndInit();
            groupControl2.ResumeLayout(false);
            groupControl2.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private ToolStripButton SubBtnClear;
        private ToolStripButton SubbtnAdd;
        private DevExpress.XtraEditors.PictureEdit svgProductImage;
        private DevExpress.XtraEditors.LabelControl RestaurantId;
        private DevExpress.XtraEditors.LabelControl CategoryId;
        private DevExpress.XtraEditors.LabelControl id;
        private DevExpress.XtraEditors.ButtonEdit btnCategoryName;
        private DevExpress.XtraEditors.ButtonEdit btnRestaurant;
        private Label label8;
        private Label label7;
        private ToolStrip toolStrip1;
        private ToolStripButton SubBtnClose;
        private DevExpress.XtraEditors.SpinEdit spPrice;
        private Label label4;
        private DevExpress.XtraEditors.MemoEdit mdDescription;
        private DevExpress.XtraEditors.TextEdit txtProductName;
        private Label label3;
        private Label label1;
        private DevExpress.XtraEditors.GroupControl groupControl1;
        private DevExpress.XtraEditors.GroupControl groupControl2;
        private Label label5;
    }
}
