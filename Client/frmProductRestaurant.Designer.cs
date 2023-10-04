namespace Client
{
    partial class frmProductRestaurant
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
            panel2 = new Panel();
            grilUserOrder = new DevExpress.XtraGrid.GridControl();
            gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            flowLayoutPanel1 = new FlowLayoutPanel();
            labelControl1 = new DevExpress.XtraEditors.LabelControl();
            Time = new Label();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)grilUserOrder).BeginInit();
            ((System.ComponentModel.ISupportInitialize)gridView1).BeginInit();
            SuspendLayout();
            // 
            // panel2
            // 
            panel2.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            panel2.Controls.Add(Time);
            panel2.Controls.Add(labelControl1);
            panel2.Controls.Add(grilUserOrder);
            panel2.Location = new Point(423, 21);
            panel2.Name = "panel2";
            panel2.Size = new Size(609, 460);
            panel2.TabIndex = 1;
            // 
            // grilUserOrder
            // 
            grilUserOrder.Location = new Point(3, 32);
            grilUserOrder.MainView = gridView1;
            grilUserOrder.Name = "grilUserOrder";
            grilUserOrder.Size = new Size(603, 425);
            grilUserOrder.TabIndex = 0;
            grilUserOrder.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] { gridView1 });
            // 
            // gridView1
            // 
            gridView1.GridControl = grilUserOrder;
            gridView1.Name = "gridView1";
            // 
            // flowLayoutPanel1
            // 
            flowLayoutPanel1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left;
            flowLayoutPanel1.AutoScroll = true;
            flowLayoutPanel1.Location = new Point(12, 21);
            flowLayoutPanel1.Name = "flowLayoutPanel1";
            flowLayoutPanel1.Size = new Size(367, 460);
            flowLayoutPanel1.TabIndex = 2;
            // 
            // labelControl1
            // 
            labelControl1.Location = new Point(3, 10);
            labelControl1.Name = "labelControl1";
            labelControl1.Size = new Size(267, 16);
            labelControl1.TabIndex = 1;
            labelControl1.Text = "List of users who ordered items during the day";
            // 
            // Time
            // 
            Time.AutoSize = true;
            Time.Location = new Point(276, 7);
            Time.Name = "Time";
            Time.Size = new Size(0, 20);
            Time.TabIndex = 2;
            // 
            // frmProductRestaurant
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1044, 490);
            Controls.Add(flowLayoutPanel1);
            Controls.Add(panel2);
            Name = "frmProductRestaurant";
            Text = "frmProductRestaurant";
            Load += frmProductRestaurant_Load;
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)grilUserOrder).EndInit();
            ((System.ComponentModel.ISupportInitialize)gridView1).EndInit();
            ResumeLayout(false);
        }

        #endregion
        private Panel panel2;
        private FlowLayoutPanel flowLayoutPanel1;
        private DevExpress.XtraGrid.GridControl grilUserOrder;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private Label Time;
    }
}