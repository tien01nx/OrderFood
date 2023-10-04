namespace Client.UserControls
{
    partial class ucRestaurant
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
            groupControl1 = new DevExpress.XtraEditors.GroupControl();
            dateEdit2 = new DevExpress.XtraEditors.DateEdit();
            label5 = new Label();
            dateEdit1 = new DevExpress.XtraEditors.DateEdit();
            label4 = new Label();
            svgImageBox1 = new DevExpress.XtraEditors.SvgImageBox();
            textEdit2 = new DevExpress.XtraEditors.TextEdit();
            label3 = new Label();
            btnDelete = new DevExpress.XtraEditors.SimpleButton();
            btnSearch = new DevExpress.XtraEditors.SimpleButton();
            btnEdit = new DevExpress.XtraEditors.SimpleButton();
            btnAdd = new DevExpress.XtraEditors.SimpleButton();
            label2 = new Label();
            monthEdit1 = new DevExpress.XtraScheduler.UI.MonthEdit();
            textEdit1 = new DevExpress.XtraEditors.TextEdit();
            label1 = new Label();
            ((System.ComponentModel.ISupportInitialize)groupControl1).BeginInit();
            groupControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dateEdit2.Properties.CalendarTimeProperties).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dateEdit2.Properties).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dateEdit1.Properties.CalendarTimeProperties).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dateEdit1.Properties).BeginInit();
            ((System.ComponentModel.ISupportInitialize)svgImageBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)textEdit2.Properties).BeginInit();
            ((System.ComponentModel.ISupportInitialize)monthEdit1.Properties).BeginInit();
            ((System.ComponentModel.ISupportInitialize)textEdit1.Properties).BeginInit();
            SuspendLayout();
            // 
            // groupControl1
            // 
            groupControl1.Controls.Add(dateEdit2);
            groupControl1.Controls.Add(label5);
            groupControl1.Controls.Add(dateEdit1);
            groupControl1.Controls.Add(label4);
            groupControl1.Controls.Add(svgImageBox1);
            groupControl1.Controls.Add(textEdit2);
            groupControl1.Controls.Add(label3);
            groupControl1.Controls.Add(btnDelete);
            groupControl1.Controls.Add(btnSearch);
            groupControl1.Controls.Add(btnEdit);
            groupControl1.Controls.Add(btnAdd);
            groupControl1.Controls.Add(label2);
            groupControl1.Controls.Add(monthEdit1);
            groupControl1.Controls.Add(textEdit1);
            groupControl1.Controls.Add(label1);
            groupControl1.Dock = DockStyle.Fill;
            groupControl1.Location = new Point(0, 0);
            groupControl1.Name = "groupControl1";
            groupControl1.Size = new Size(287, 506);
            groupControl1.TabIndex = 0;
            groupControl1.Text = "Restaurant";
            // 
            // dateEdit2
            // 
            dateEdit2.EditValue = null;
            dateEdit2.Location = new Point(150, 381);
            dateEdit2.Name = "dateEdit2";
            dateEdit2.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] { new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo) });
            dateEdit2.Size = new Size(84, 22);
            dateEdit2.TabIndex = 51;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(26, 387);
            label5.Name = "label5";
            label5.Size = new Size(67, 16);
            label5.TabIndex = 50;
            label5.Text = "Close time";
            // 
            // dateEdit1
            // 
            dateEdit1.EditValue = null;
            dateEdit1.Location = new Point(150, 353);
            dateEdit1.Name = "dateEdit1";
            dateEdit1.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] { new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo) });
            dateEdit1.Properties.CalendarTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] { new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo) });
            dateEdit1.Size = new Size(84, 22);
            dateEdit1.TabIndex = 49;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(26, 359);
            label4.Name = "label4";
            label4.Size = new Size(70, 16);
            label4.TabIndex = 48;
            label4.Text = "Open Time";
            // 
            // svgImageBox1
            // 
            svgImageBox1.Location = new Point(25, 201);
            svgImageBox1.Name = "svgImageBox1";
            svgImageBox1.Size = new Size(209, 150);
            svgImageBox1.TabIndex = 47;
            svgImageBox1.Text = "svgImageBox1";
            // 
            // textEdit2
            // 
            textEdit2.Location = new Point(25, 161);
            textEdit2.Name = "textEdit2";
            textEdit2.Size = new Size(209, 22);
            textEdit2.TabIndex = 46;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Tahoma", 7.8F, FontStyle.Bold, GraphicsUnit.Point);
            label3.Location = new Point(26, 142);
            label3.Margin = new Padding(4, 0, 4, 0);
            label3.Name = "label3";
            label3.Size = new Size(100, 16);
            label3.TabIndex = 45;
            label3.Text = "Phone Number";
            // 
            // btnDelete
            // 
            btnDelete.Location = new Point(25, 465);
            btnDelete.Margin = new Padding(4, 2, 4, 2);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(71, 23);
            btnDelete.TabIndex = 44;
            btnDelete.Text = "Delete";
            // 
            // btnSearch
            // 
            btnSearch.Location = new Point(163, 465);
            btnSearch.Margin = new Padding(4, 2, 4, 2);
            btnSearch.Name = "btnSearch";
            btnSearch.Size = new Size(71, 23);
            btnSearch.TabIndex = 43;
            btnSearch.Text = "Search";
            // 
            // btnEdit
            // 
            btnEdit.Location = new Point(163, 423);
            btnEdit.Margin = new Padding(4, 2, 4, 2);
            btnEdit.Name = "btnEdit";
            btnEdit.Size = new Size(71, 23);
            btnEdit.TabIndex = 42;
            btnEdit.Text = "Edit";
            // 
            // btnAdd
            // 
            btnAdd.Location = new Point(25, 423);
            btnAdd.Margin = new Padding(4, 2, 4, 2);
            btnAdd.Name = "btnAdd";
            btnAdd.Size = new Size(71, 23);
            btnAdd.TabIndex = 41;
            btnAdd.Text = "Add";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Tahoma", 7.8F, FontStyle.Bold, GraphicsUnit.Point);
            label2.Location = new Point(25, 84);
            label2.Margin = new Padding(4, 0, 4, 0);
            label2.Name = "label2";
            label2.Size = new Size(80, 16);
            label2.TabIndex = 33;
            label2.Text = "Description";
            // 
            // monthEdit1
            // 
            monthEdit1.Location = new Point(25, 110);
            monthEdit1.Name = "monthEdit1";
            monthEdit1.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] { new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo) });
            monthEdit1.Size = new Size(209, 22);
            monthEdit1.TabIndex = 31;
            // 
            // textEdit1
            // 
            textEdit1.Location = new Point(25, 59);
            textEdit1.Name = "textEdit1";
            textEdit1.Size = new Size(209, 22);
            textEdit1.TabIndex = 30;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Tahoma", 7.8F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(25, 37);
            label1.Margin = new Padding(4, 0, 4, 0);
            label1.Name = "label1";
            label1.Size = new Size(120, 16);
            label1.TabIndex = 29;
            label1.Text = "Restaurant Name";
            // 
            // ucRestaurant
            // 
            AutoScaleDimensions = new SizeF(7F, 16F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(groupControl1);
            Name = "ucRestaurant";
            Size = new Size(287, 506);
            ((System.ComponentModel.ISupportInitialize)groupControl1).EndInit();
            groupControl1.ResumeLayout(false);
            groupControl1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dateEdit2.Properties.CalendarTimeProperties).EndInit();
            ((System.ComponentModel.ISupportInitialize)dateEdit2.Properties).EndInit();
            ((System.ComponentModel.ISupportInitialize)dateEdit1.Properties.CalendarTimeProperties).EndInit();
            ((System.ComponentModel.ISupportInitialize)dateEdit1.Properties).EndInit();
            ((System.ComponentModel.ISupportInitialize)svgImageBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)textEdit2.Properties).EndInit();
            ((System.ComponentModel.ISupportInitialize)monthEdit1.Properties).EndInit();
            ((System.ComponentModel.ISupportInitialize)textEdit1.Properties).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private DevExpress.XtraEditors.GroupControl groupControl1;
        private DevExpress.XtraEditors.SimpleButton btnDelete;
        private DevExpress.XtraEditors.SimpleButton btnSearch;
        private DevExpress.XtraEditors.SimpleButton btnEdit;
        private DevExpress.XtraEditors.SimpleButton btnAdd;
        private Label label2;
        private DevExpress.XtraScheduler.UI.MonthEdit monthEdit1;
        private DevExpress.XtraEditors.TextEdit textEdit1;
        private Label label1;
        private Label label3;
        private DevExpress.XtraEditors.TextEdit textEdit2;
        private DevExpress.XtraEditors.SvgImageBox svgImageBox1;
        private Label label4;
        private DevExpress.XtraEditors.DateEdit dateEdit1;
        private DevExpress.XtraEditors.DateEdit dateEdit2;
        private Label label5;
    }
}
