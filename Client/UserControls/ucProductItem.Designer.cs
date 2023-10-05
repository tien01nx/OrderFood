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
            lblProductName.Location = new Point(12, 7);
            lblProductName.Margin = new Padding(4, 2, 4, 2);
            lblProductName.Name = "lblProductName";
            lblProductName.Size = new Size(44, 16);
            lblProductName.TabIndex = 0;
            lblProductName.Text = "Name: ";
            // 
            // lblPrice
            // 
            lblPrice.Appearance.Font = new Font("Tahoma", 7.8F, FontStyle.Bold, GraphicsUnit.Point);
            lblPrice.Appearance.ForeColor = Color.Red;
            lblPrice.Appearance.Options.UseFont = true;
            lblPrice.Appearance.Options.UseForeColor = true;
            lblPrice.Location = new Point(12, 34);
            lblPrice.Margin = new Padding(4, 2, 4, 2);
            lblPrice.Name = "lblPrice";
            lblPrice.Size = new Size(41, 16);
            lblPrice.TabIndex = 1;
            lblPrice.Text = "Price: ";
            // 
            // labelControl6
            // 
            labelControl6.Location = new Point(12, 240);
            labelControl6.Margin = new Padding(4, 2, 4, 2);
            labelControl6.Name = "labelControl6";
            labelControl6.Size = new Size(47, 16);
            labelControl6.TabIndex = 5;
            labelControl6.Text = "Quantity";
            // 
            // chkIsChoose
            // 
            chkIsChoose.Location = new Point(254, 33);
            chkIsChoose.Margin = new Padding(4, 2, 4, 2);
            chkIsChoose.Name = "chkIsChoose";
            chkIsChoose.Properties.Appearance.BackColor = Color.Transparent;
            chkIsChoose.Properties.Appearance.Options.UseBackColor = true;
            chkIsChoose.Properties.Caption = "";
            chkIsChoose.Size = new Size(24, 24);
            chkIsChoose.TabIndex = 10;
            // 
            // pcProductImg
            // 
            pcProductImg.Location = new Point(13, 62);
            pcProductImg.Margin = new Padding(4, 2, 4, 2);
            pcProductImg.Name = "pcProductImg";
            pcProductImg.Size = new Size(261, 174);
            pcProductImg.SizeMode = PictureBoxSizeMode.Zoom;
            pcProductImg.TabIndex = 13;
            pcProductImg.TabStop = false;
            // 
            // spinQuantity
            // 
            spinQuantity.EditValue = new decimal(new int[] { 1, 0, 0, 0 });
            spinQuantity.Location = new Point(12, 261);
            spinQuantity.Margin = new Padding(4);
            spinQuantity.Name = "spinQuantity";
            spinQuantity.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] { new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo) });
            spinQuantity.Size = new Size(72, 24);
            spinQuantity.TabIndex = 14;
            // 
            // ucProductItem
            // 
            AutoScaleDimensions = new SizeF(7F, 16F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(spinQuantity);
            Controls.Add(pcProductImg);
            Controls.Add(chkIsChoose);
            Controls.Add(labelControl6);
            Controls.Add(lblPrice);
            Controls.Add(lblProductName);
            Margin = new Padding(4, 2, 4, 2);
            Name = "ucProductItem";
            Size = new Size(286, 297);
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
        private DevExpress.XtraEditors.CheckEdit chkIsChoose;
        private NumericUpDown spinEdit1;
        private PictureBox pcProductImg;
        private DevExpress.XtraEditors.SpinEdit spinQuantity;
    }
}
