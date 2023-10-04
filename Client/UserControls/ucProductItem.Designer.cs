namespace Client
{
    partial class ucProductItem
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
            lblProductName = new DevExpress.XtraEditors.LabelControl();
            lblPrice = new DevExpress.XtraEditors.LabelControl();
            labelControl6 = new DevExpress.XtraEditors.LabelControl();
            btnOrder = new DevExpress.XtraEditors.SimpleButton();
            chkIsChoose = new DevExpress.XtraEditors.CheckEdit();
            pcProductImg = new PictureBox();
            spinQuantity = new DevExpress.XtraEditors.SpinEdit();
            ((System.ComponentModel.ISupportInitialize)chkIsChoose.Properties).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pcProductImg).BeginInit();
            ((System.ComponentModel.ISupportInitialize)spinQuantity.Properties).BeginInit();
            SuspendLayout();
            // 
            // lblProductName
            // 
            lblProductName.Appearance.Font = new Font("Tahoma", 7.8F, FontStyle.Bold, GraphicsUnit.Point);
            lblProductName.Appearance.Options.UseFont = true;
            lblProductName.Location = new Point(10, 6);
            lblProductName.Margin = new Padding(3, 2, 3, 2);
            lblProductName.Name = "lblProductName";
            lblProductName.Size = new Size(34, 12);
            lblProductName.TabIndex = 0;
            lblProductName.Text = "Name: ";
            // 
            // lblPrice
            // 
            lblPrice.Appearance.Font = new Font("Tahoma", 7.8F, FontStyle.Bold, GraphicsUnit.Point);
            lblPrice.Appearance.ForeColor = Color.Red;
            lblPrice.Appearance.Options.UseFont = true;
            lblPrice.Appearance.Options.UseForeColor = true;
            lblPrice.Location = new Point(10, 28);
            lblPrice.Margin = new Padding(3, 2, 3, 2);
            lblPrice.Name = "lblPrice";
            lblPrice.Size = new Size(32, 12);
            lblPrice.TabIndex = 1;
            lblPrice.Text = "Price: ";
            lblPrice.Click += labelControl2_Click;
            // 
            // labelControl6
            // 
            labelControl6.Location = new Point(10, 195);
            labelControl6.Margin = new Padding(3, 2, 3, 2);
            labelControl6.Name = "labelControl6";
            labelControl6.Size = new Size(42, 13);
            labelControl6.TabIndex = 5;
            labelControl6.Text = "Quantity";
            // 
            // btnOrder
            // 
            btnOrder.Location = new Point(173, 213);
            btnOrder.Margin = new Padding(3, 2, 3, 2);
            btnOrder.Name = "btnOrder";
            btnOrder.Size = new Size(61, 19);
            btnOrder.TabIndex = 9;
            btnOrder.Text = "Order";
            // 
            // chkIsChoose
            // 
            chkIsChoose.Location = new Point(218, 27);
            chkIsChoose.Margin = new Padding(3, 2, 3, 2);
            chkIsChoose.Name = "chkIsChoose";
            chkIsChoose.Properties.Caption = "";
            chkIsChoose.Size = new Size(21, 20);
            chkIsChoose.TabIndex = 10;
            // 
            // pcProductImg
            // 
            pcProductImg.Location = new Point(11, 50);
            pcProductImg.Margin = new Padding(3, 2, 3, 2);
            pcProductImg.Name = "pcProductImg";
            pcProductImg.Size = new Size(224, 141);
            pcProductImg.SizeMode = PictureBoxSizeMode.Zoom;
            pcProductImg.TabIndex = 13;
            pcProductImg.TabStop = false;
            // 
            // spinQuantity
            // 
            spinQuantity.EditValue = new decimal(new int[] { 1, 0, 0, 0 });
            spinQuantity.Location = new Point(10, 212);
            spinQuantity.Name = "spinQuantity";
            spinQuantity.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] { new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo) });
            spinQuantity.Size = new Size(62, 20);
            spinQuantity.TabIndex = 14;
            // 
            // ucProductItem
            // 
            AutoScaleDimensions = new SizeF(6F, 13F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(spinQuantity);
            Controls.Add(pcProductImg);
            Controls.Add(chkIsChoose);
            Controls.Add(btnOrder);
            Controls.Add(labelControl6);
            Controls.Add(lblPrice);
            Controls.Add(lblProductName);
            Margin = new Padding(3, 2, 3, 2);
            Name = "ucProductItem";
            Size = new Size(245, 241);
            ((System.ComponentModel.ISupportInitialize)chkIsChoose.Properties).EndInit();
            ((System.ComponentModel.ISupportInitialize)pcProductImg).EndInit();
            ((System.ComponentModel.ISupportInitialize)spinQuantity.Properties).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DevExpress.XtraEditors.LabelControl lblProductName;
        private DevExpress.XtraEditors.LabelControl lblPrice;
        private DevExpress.XtraEditors.LabelControl labelControl6;
        private DevExpress.XtraEditors.SimpleButton btnOrder;
        private DevExpress.XtraEditors.CheckEdit chkIsChoose;
        private NumericUpDown spinEdit1;
        private PictureBox pcProductImg;
        private DevExpress.XtraEditors.SpinEdit spinQuantity;
    }
}
