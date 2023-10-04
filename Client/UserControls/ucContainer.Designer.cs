namespace Client
{
    partial class ucContainer
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
            panelControl1 = new DevExpress.XtraEditors.PanelControl();
            flowLayout = new FlowLayoutPanel();
            panelControl2 = new DevExpress.XtraEditors.PanelControl();
            gridData = new DevExpress.XtraGrid.GridControl();
            gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            stackPanel1 = new DevExpress.Utils.Layout.StackPanel();
            labelControl1 = new DevExpress.XtraEditors.LabelControl();
            dateEdit = new DevExpress.XtraEditors.DateEdit();
            layoutControlItem5 = new DevExpress.XtraLayout.LayoutControlItem();
            ((System.ComponentModel.ISupportInitialize)panelControl1).BeginInit();
            panelControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)panelControl2).BeginInit();
            panelControl2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)gridData).BeginInit();
            ((System.ComponentModel.ISupportInitialize)gridView1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)stackPanel1).BeginInit();
            stackPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dateEdit.Properties.CalendarTimeProperties).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dateEdit.Properties).BeginInit();
            ((System.ComponentModel.ISupportInitialize)layoutControlItem5).BeginInit();
            SuspendLayout();
            // 
            // panelControl1
            // 
            panelControl1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left;
            panelControl1.Controls.Add(flowLayout);
            panelControl1.Location = new Point(3, 3);
            panelControl1.Name = "panelControl1";
            panelControl1.Size = new Size(315, 538);
            panelControl1.TabIndex = 0;
            // 
            // flowLayout
            // 
            flowLayout.AutoScroll = true;
            flowLayout.Dock = DockStyle.Left;
            flowLayout.Location = new Point(2, 2);
            flowLayout.Name = "flowLayout";
            flowLayout.Size = new Size(308, 534);
            flowLayout.TabIndex = 0;
            // 
            // panelControl2
            // 
            panelControl2.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            panelControl2.Controls.Add(gridData);
            panelControl2.Controls.Add(stackPanel1);
            panelControl2.Location = new Point(324, 0);
            panelControl2.Name = "panelControl2";
            panelControl2.Size = new Size(704, 541);
            panelControl2.TabIndex = 1;
            // 
            // gridData
            // 
            gridData.Dock = DockStyle.Fill;
            gridData.Location = new Point(2, 56);
            gridData.MainView = gridView1;
            gridData.Name = "gridData";
            gridData.Size = new Size(700, 483);
            gridData.TabIndex = 1;
            gridData.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] { gridView1 });
            gridData.Click += gridData_Click;
            // 
            // gridView1
            // 
            gridView1.GridControl = gridData;
            gridView1.Name = "gridView1";
            // 
            // stackPanel1
            // 
            stackPanel1.Controls.Add(labelControl1);
            stackPanel1.Controls.Add(dateEdit);
            stackPanel1.Dock = DockStyle.Top;
            stackPanel1.Location = new Point(2, 2);
            stackPanel1.Name = "stackPanel1";
            stackPanel1.Size = new Size(700, 54);
            stackPanel1.TabIndex = 0;
            // 
            // labelControl1
            // 
            labelControl1.Location = new Point(3, 19);
            labelControl1.Name = "labelControl1";
            labelControl1.Size = new Size(53, 16);
            labelControl1.TabIndex = 0;
            labelControl1.Text = "Thời gian";
            // 
            // dateEdit
            // 
            dateEdit.EditValue = null;
            dateEdit.Location = new Point(62, 16);
            dateEdit.Name = "dateEdit";
            dateEdit.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] { new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo) });
            dateEdit.Properties.CalendarTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] { new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo) });
            dateEdit.Size = new Size(156, 22);
            dateEdit.TabIndex = 1;
            // 
            // layoutControlItem5
            // 
            layoutControlItem5.Location = new Point(0, 55);
            layoutControlItem5.Name = "layoutControlItem5";
            layoutControlItem5.Size = new Size(688, 25);
            layoutControlItem5.TextSize = new Size(50, 20);
            // 
            // ucContainer
            // 
            AutoScaleDimensions = new SizeF(7F, 16F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(panelControl2);
            Controls.Add(panelControl1);
            Margin = new Padding(3, 2, 3, 2);
            Name = "ucContainer";
            Size = new Size(1028, 544);
            Load += ucContaine_Load;
            ((System.ComponentModel.ISupportInitialize)panelControl1).EndInit();
            panelControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)panelControl2).EndInit();
            panelControl2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)gridData).EndInit();
            ((System.ComponentModel.ISupportInitialize)gridView1).EndInit();
            ((System.ComponentModel.ISupportInitialize)stackPanel1).EndInit();
            stackPanel1.ResumeLayout(false);
            stackPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dateEdit.Properties.CalendarTimeProperties).EndInit();
            ((System.ComponentModel.ISupportInitialize)dateEdit.Properties).EndInit();
            ((System.ComponentModel.ISupportInitialize)layoutControlItem5).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private DevExpress.XtraEditors.PanelControl panelControl1;
        private DevExpress.XtraEditors.PanelControl panelControl2;
        private FlowLayoutPanel flowLayout;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem5;
        private DevExpress.Utils.Layout.StackPanel stackPanel1;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraEditors.DateEdit dateEdit;
        private DevExpress.XtraGrid.GridControl gridData;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
    }
}
