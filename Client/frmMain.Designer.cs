namespace Client
{
    partial class frmMain
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

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            menuStrip1 = new MenuStrip();
            menuToolStripMenuItem = new ToolStripMenuItem();
            restaurantToolStripMenuItem = new ToolStripMenuItem();
            productToolStripMenuItem = new ToolStripMenuItem();
            categoryToolStripMenuItem = new ToolStripMenuItem();
            productToolStripMenuItem1 = new ToolStripMenuItem();
            đơnHàngToolStripMenuItem = new ToolStripMenuItem();
            btnDanhsachdonhang = new ToolStripMenuItem();
            đặtHàngToolStripMenuItem = new ToolStripMenuItem();
            sảnPhẩmToolStripMenuItem = new ToolStripMenuItem();
            danhSáchSảnPhẩmToolStripMenuItem = new ToolStripMenuItem();
            thẻToolStripMenuItem = new ToolStripMenuItem();
            danhSáchThẻToolStripMenuItem = new ToolStripMenuItem();
            Root = new DevExpress.XtraLayout.LayoutControlGroup();
            layoutControlGroup1 = new DevExpress.XtraLayout.LayoutControlGroup();
            layoutControlGroup2 = new DevExpress.XtraLayout.LayoutControlGroup();
            pnParent = new DevExpress.XtraEditors.PanelControl();
            menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)Root).BeginInit();
            ((System.ComponentModel.ISupportInitialize)layoutControlGroup1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)layoutControlGroup2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pnParent).BeginInit();
            SuspendLayout();
            // 
            // menuStrip1
            // 
            menuStrip1.ImageScalingSize = new Size(20, 20);
            menuStrip1.Items.AddRange(new ToolStripItem[] { menuToolStripMenuItem, đơnHàngToolStripMenuItem, sảnPhẩmToolStripMenuItem, thẻToolStripMenuItem });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(1283, 28);
            menuStrip1.TabIndex = 0;
            menuStrip1.Text = "menuStrip1";
            // 
            // menuToolStripMenuItem
            // 
            menuToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { restaurantToolStripMenuItem, productToolStripMenuItem, categoryToolStripMenuItem, productToolStripMenuItem1 });
            menuToolStripMenuItem.Name = "menuToolStripMenuItem";
            menuToolStripMenuItem.Size = new Size(60, 24);
            menuToolStripMenuItem.Text = "Menu";
            menuToolStripMenuItem.Click += menuToolStripMenuItem_Click;
            // 
            // restaurantToolStripMenuItem
            // 
            restaurantToolStripMenuItem.Name = "restaurantToolStripMenuItem";
            restaurantToolStripMenuItem.Size = new Size(168, 26);
            restaurantToolStripMenuItem.Text = "Restaurant";
            // 
            // productToolStripMenuItem
            // 
            productToolStripMenuItem.Name = "productToolStripMenuItem";
            productToolStripMenuItem.Size = new Size(168, 26);
            productToolStripMenuItem.Text = "Order Food";
            // 
            // categoryToolStripMenuItem
            // 
            categoryToolStripMenuItem.Name = "categoryToolStripMenuItem";
            categoryToolStripMenuItem.Size = new Size(168, 26);
            categoryToolStripMenuItem.Text = "Category";
            // 
            // productToolStripMenuItem1
            // 
            productToolStripMenuItem1.Name = "productToolStripMenuItem1";
            productToolStripMenuItem1.Size = new Size(168, 26);
            productToolStripMenuItem1.Text = "Product";
            // 
            // đơnHàngToolStripMenuItem
            // 
            đơnHàngToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { btnDanhsachdonhang, đặtHàngToolStripMenuItem });
            đơnHàngToolStripMenuItem.Name = "đơnHàngToolStripMenuItem";
            đơnHàngToolStripMenuItem.Size = new Size(88, 24);
            đơnHàngToolStripMenuItem.Text = "Đơn hàng";
            // 
            // btnDanhsachdonhang
            // 
            btnDanhsachdonhang.Name = "btnDanhsachdonhang";
            btnDanhsachdonhang.Size = new Size(227, 26);
            btnDanhsachdonhang.Text = "Danh sách đơn hàng";
            btnDanhsachdonhang.Click += btnDanhsachdonhang_Click;
            // 
            // đặtHàngToolStripMenuItem
            // 
            đặtHàngToolStripMenuItem.Name = "đặtHàngToolStripMenuItem";
            đặtHàngToolStripMenuItem.Size = new Size(227, 26);
            đặtHàngToolStripMenuItem.Text = "Đặt hàng";
            // 
            // sảnPhẩmToolStripMenuItem
            // 
            sảnPhẩmToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { danhSáchSảnPhẩmToolStripMenuItem });
            sảnPhẩmToolStripMenuItem.Name = "sảnPhẩmToolStripMenuItem";
            sảnPhẩmToolStripMenuItem.Size = new Size(89, 24);
            sảnPhẩmToolStripMenuItem.Text = "Sản phẩm";
            // 
            // danhSáchSảnPhẩmToolStripMenuItem
            // 
            danhSáchSảnPhẩmToolStripMenuItem.Name = "danhSáchSảnPhẩmToolStripMenuItem";
            danhSáchSảnPhẩmToolStripMenuItem.Size = new Size(228, 26);
            danhSáchSảnPhẩmToolStripMenuItem.Text = "Danh sách sản phẩm";
            danhSáchSảnPhẩmToolStripMenuItem.Click += danhSáchSảnPhẩmToolStripMenuItem_Click;
            // 
            // thẻToolStripMenuItem
            // 
            thẻToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { danhSáchThẻToolStripMenuItem });
            thẻToolStripMenuItem.Name = "thẻToolStripMenuItem";
            thẻToolStripMenuItem.Size = new Size(47, 24);
            thẻToolStripMenuItem.Text = "Thẻ";
            // 
            // danhSáchThẻToolStripMenuItem
            // 
            danhSáchThẻToolStripMenuItem.Name = "danhSáchThẻToolStripMenuItem";
            danhSáchThẻToolStripMenuItem.Size = new Size(224, 26);
            danhSáchThẻToolStripMenuItem.Text = "Danh sách thẻ";
            danhSáchThẻToolStripMenuItem.Click += danhSáchThẻToolStripMenuItem_Click;
            // 
            // Root
            // 
            Root.EnableIndentsWithoutBorders = DevExpress.Utils.DefaultBoolean.True;
            Root.GroupBordersVisible = false;
            Root.Location = new Point(0, 0);
            Root.Name = "Root";
            Root.Size = new Size(318, 684);
            Root.TextVisible = false;
            // 
            // layoutControlGroup1
            // 
            layoutControlGroup1.EnableIndentsWithoutBorders = DevExpress.Utils.DefaultBoolean.True;
            layoutControlGroup1.GroupBordersVisible = false;
            layoutControlGroup1.Location = new Point(0, 0);
            layoutControlGroup1.Name = "Root";
            layoutControlGroup1.Size = new Size(318, 684);
            layoutControlGroup1.TextVisible = false;
            // 
            // layoutControlGroup2
            // 
            layoutControlGroup2.EnableIndentsWithoutBorders = DevExpress.Utils.DefaultBoolean.True;
            layoutControlGroup2.GroupBordersVisible = false;
            layoutControlGroup2.Location = new Point(0, 0);
            layoutControlGroup2.Name = "Root";
            layoutControlGroup2.Size = new Size(318, 684);
            layoutControlGroup2.TextVisible = false;
            // 
            // pnParent
            // 
            pnParent.Dock = DockStyle.Fill;
            pnParent.Location = new Point(0, 28);
            pnParent.Margin = new Padding(4, 2, 4, 2);
            pnParent.Name = "pnParent";
            pnParent.Size = new Size(1283, 617);
            pnParent.TabIndex = 1;
            // 
            // frmMain
            // 
            AutoScaleDimensions = new SizeF(7F, 16F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1283, 645);
            Controls.Add(pnParent);
            Controls.Add(menuStrip1);
            MainMenuStrip = menuStrip1;
            Margin = new Padding(4, 2, 4, 2);
            Name = "frmMain";
            Text = "frmMain";
            Load += frmMain_Load;
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)Root).EndInit();
            ((System.ComponentModel.ISupportInitialize)layoutControlGroup1).EndInit();
            ((System.ComponentModel.ISupportInitialize)layoutControlGroup2).EndInit();
            ((System.ComponentModel.ISupportInitialize)pnParent).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private MenuStrip menuStrip1;
        private ToolStripMenuItem menuToolStripMenuItem;
        private ToolStripMenuItem restaurantToolStripMenuItem;
        private ToolStripMenuItem productToolStripMenuItem;
        private ToolStripMenuItem categoryToolStripMenuItem;
        private ToolStripMenuItem productToolStripMenuItem1;
        private DevExpress.XtraLayout.LayoutControlGroup Root;
        private DevExpress.XtraLayout.LayoutControlGroup layoutControlGroup1;
        private DevExpress.XtraLayout.LayoutControlGroup layoutControlGroup2;
        private DevExpress.XtraEditors.PanelControl pnParent;
        private ToolStripMenuItem đơnHàngToolStripMenuItem;
        private ToolStripMenuItem btnDanhsachdonhang;
        private ToolStripMenuItem đặtHàngToolStripMenuItem;
        private ToolStripMenuItem sảnPhẩmToolStripMenuItem;
        private ToolStripMenuItem danhSáchSảnPhẩmToolStripMenuItem;
        private ToolStripMenuItem thẻToolStripMenuItem;
        private ToolStripMenuItem danhSáchThẻToolStripMenuItem;
    }
}