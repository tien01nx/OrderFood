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
            đơnHàngToolStripMenuItem = new ToolStripMenuItem();
            btnDanhsachdonhang = new ToolStripMenuItem();
            đặtHàngToolStripMenuItem = new ToolStripMenuItem();
            sảnPhẩmToolStripMenuItem = new ToolStripMenuItem();
            danhSáchSảnPhẩmToolStripMenuItem = new ToolStripMenuItem();
            Root = new DevExpress.XtraLayout.LayoutControlGroup();
            layoutControlGroup1 = new DevExpress.XtraLayout.LayoutControlGroup();
            layoutControlGroup2 = new DevExpress.XtraLayout.LayoutControlGroup();
            pnParent = new DevExpress.XtraEditors.PanelControl();
            thôngTinNgườiDùngToolStripMenuItem = new ToolStripMenuItem();
            thôngTinQuyềnToolStripMenuItem = new ToolStripMenuItem();
            qLQuyềnToolStripMenuItem = new ToolStripMenuItem();
            thôngTinQuyềnToolStripMenuItem1 = new ToolStripMenuItem();
            phânQuyềnToolStripMenuItem = new ToolStripMenuItem();
            khơiToolStripMenuItem = new ToolStripMenuItem();
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
            menuStrip1.Items.AddRange(new ToolStripItem[] { menuToolStripMenuItem, đơnHàngToolStripMenuItem, sảnPhẩmToolStripMenuItem });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(1283, 28);
            menuStrip1.TabIndex = 0;
            menuStrip1.Text = "menuStrip1";
            // 
            // menuToolStripMenuItem
            // 
            menuToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { restaurantToolStripMenuItem, productToolStripMenuItem, categoryToolStripMenuItem, qLQuyềnToolStripMenuItem });
            menuToolStripMenuItem.Name = "menuToolStripMenuItem";
            menuToolStripMenuItem.Size = new Size(97, 24);
            menuToolStripMenuItem.Text = "HỆ THỐNG";
            menuToolStripMenuItem.Click += menuToolStripMenuItem_Click;
            // 
            // restaurantToolStripMenuItem
            // 
            restaurantToolStripMenuItem.Name = "restaurantToolStripMenuItem";
            restaurantToolStripMenuItem.Size = new Size(224, 26);
            restaurantToolStripMenuItem.Text = "QL Nhà Hàng";
            // 
            // productToolStripMenuItem
            // 
            productToolStripMenuItem.Name = "productToolStripMenuItem";
            productToolStripMenuItem.Size = new Size(224, 26);
            productToolStripMenuItem.Text = "QL Sản Phẩm";
            // 
            // categoryToolStripMenuItem
            // 
            categoryToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { thôngTinNgườiDùngToolStripMenuItem, thôngTinQuyềnToolStripMenuItem });
            categoryToolStripMenuItem.Name = "categoryToolStripMenuItem";
            categoryToolStripMenuItem.Size = new Size(224, 26);
            categoryToolStripMenuItem.Text = "QL Người Dùng";
            // 
            // đơnHàngToolStripMenuItem
            // 
            đơnHàngToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { btnDanhsachdonhang, đặtHàngToolStripMenuItem, khơiToolStripMenuItem });
            đơnHàngToolStripMenuItem.Name = "đơnHàngToolStripMenuItem";
            đơnHàngToolStripMenuItem.Size = new Size(102, 24);
            đơnHàngToolStripMenuItem.Text = "ĐƠN HÀNG";
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
            sảnPhẩmToolStripMenuItem.Size = new Size(173, 24);
            sảnPhẩmToolStripMenuItem.Text = "THỐNG KÊ - BÁO CÁO";
            // 
            // danhSáchSảnPhẩmToolStripMenuItem
            // 
            danhSáchSảnPhẩmToolStripMenuItem.Name = "danhSáchSảnPhẩmToolStripMenuItem";
            danhSáchSảnPhẩmToolStripMenuItem.Size = new Size(228, 26);
            danhSáchSảnPhẩmToolStripMenuItem.Text = "Danh sách sản phẩm";
            danhSáchSảnPhẩmToolStripMenuItem.Click += danhSáchSảnPhẩmToolStripMenuItem_Click;
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
            // thôngTinNgườiDùngToolStripMenuItem
            // 
            thôngTinNgườiDùngToolStripMenuItem.Name = "thôngTinNgườiDùngToolStripMenuItem";
            thôngTinNgườiDùngToolStripMenuItem.Size = new Size(244, 26);
            thôngTinNgườiDùngToolStripMenuItem.Text = "Thông Tin Người Dùng";
            // 
            // thôngTinQuyềnToolStripMenuItem
            // 
            thôngTinQuyềnToolStripMenuItem.Name = "thôngTinQuyềnToolStripMenuItem";
            thôngTinQuyềnToolStripMenuItem.Size = new Size(244, 26);
            thôngTinQuyềnToolStripMenuItem.Text = "Thông Tin Ngân Hàng";
            // 
            // qLQuyềnToolStripMenuItem
            // 
            qLQuyềnToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { thôngTinQuyềnToolStripMenuItem1, phânQuyềnToolStripMenuItem });
            qLQuyềnToolStripMenuItem.Name = "qLQuyềnToolStripMenuItem";
            qLQuyềnToolStripMenuItem.Size = new Size(224, 26);
            qLQuyềnToolStripMenuItem.Text = "QL Quyền";
            // 
            // thôngTinQuyềnToolStripMenuItem1
            // 
            thôngTinQuyềnToolStripMenuItem1.Name = "thôngTinQuyềnToolStripMenuItem1";
            thôngTinQuyềnToolStripMenuItem1.Size = new Size(224, 26);
            thôngTinQuyềnToolStripMenuItem1.Text = "Thông Tin Quyền";
            // 
            // phânQuyềnToolStripMenuItem
            // 
            phânQuyềnToolStripMenuItem.Name = "phânQuyềnToolStripMenuItem";
            phânQuyềnToolStripMenuItem.Size = new Size(224, 26);
            phânQuyềnToolStripMenuItem.Text = "Phân Quyền";
            // 
            // khơiToolStripMenuItem
            // 
            khơiToolStripMenuItem.Name = "khơiToolStripMenuItem";
            khơiToolStripMenuItem.Size = new Size(290, 26);
            khơiToolStripMenuItem.Text = "Cấu Hình Thông Tin Đặt Hàng";
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
            WindowState = FormWindowState.Maximized;
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
        private DevExpress.XtraLayout.LayoutControlGroup Root;
        private DevExpress.XtraLayout.LayoutControlGroup layoutControlGroup1;
        private DevExpress.XtraLayout.LayoutControlGroup layoutControlGroup2;
        private DevExpress.XtraEditors.PanelControl pnParent;
        private ToolStripMenuItem đơnHàngToolStripMenuItem;
        private ToolStripMenuItem btnDanhsachdonhang;
        private ToolStripMenuItem đặtHàngToolStripMenuItem;
        private ToolStripMenuItem sảnPhẩmToolStripMenuItem;
        private ToolStripMenuItem danhSáchSảnPhẩmToolStripMenuItem;
        private ToolStripMenuItem thôngTinNgườiDùngToolStripMenuItem;
        private ToolStripMenuItem thôngTinQuyềnToolStripMenuItem;
        private ToolStripMenuItem qLQuyềnToolStripMenuItem;
        private ToolStripMenuItem thôngTinQuyềnToolStripMenuItem1;
        private ToolStripMenuItem phânQuyềnToolStripMenuItem;
        private ToolStripMenuItem khơiToolStripMenuItem;
    }
}