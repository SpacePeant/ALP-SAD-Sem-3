namespace Pangsit_Mie_Gloria
{
    partial class RawMaterialCreate
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.tbRawMaterialName = new System.Windows.Forms.TextBox();
            this.cbUnit = new System.Windows.Forms.ComboBox();
            this.tbUnitInStock = new System.Windows.Forms.TextBox();
            this.btnCreateRaw = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 40);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(128, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "Raw Material Name:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(38, 118);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(33, 16);
            this.label2.TabIndex = 1;
            this.label2.Text = "Unit:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(25, 77);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(80, 16);
            this.label3.TabIndex = 2;
            this.label3.Text = "Unit In Stock";
            // 
            // tbRawMaterialName
            // 
            this.tbRawMaterialName.Location = new System.Drawing.Point(167, 40);
            this.tbRawMaterialName.Name = "tbRawMaterialName";
            this.tbRawMaterialName.Size = new System.Drawing.Size(100, 22);
            this.tbRawMaterialName.TabIndex = 3;
            // 
            // cbUnit
            // 
            this.cbUnit.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbUnit.FormattingEnabled = true;
            this.cbUnit.Items.AddRange(new object[] {
            "kg",
            "pcs",
            "gr"});
            this.cbUnit.Location = new System.Drawing.Point(167, 115);
            this.cbUnit.Name = "cbUnit";
            this.cbUnit.Size = new System.Drawing.Size(121, 24);
            this.cbUnit.TabIndex = 4;
            // 
            // tbUnitInStock
            // 
            this.tbUnitInStock.Location = new System.Drawing.Point(167, 77);
            this.tbUnitInStock.Name = "tbUnitInStock";
            this.tbUnitInStock.Size = new System.Drawing.Size(100, 22);
            this.tbUnitInStock.TabIndex = 5;
            // 
            // btnCreateRaw
            // 
            this.btnCreateRaw.Location = new System.Drawing.Point(167, 157);
            this.btnCreateRaw.Name = "btnCreateRaw";
            this.btnCreateRaw.Size = new System.Drawing.Size(75, 23);
            this.btnCreateRaw.TabIndex = 6;
            this.btnCreateRaw.Text = "CREATE";
            this.btnCreateRaw.UseVisualStyleBackColor = true;
            this.btnCreateRaw.Click += new System.EventHandler(this.btnCreateRaw_Click);
            // 
            // RawMaterialCreate
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1902, 1033);
            this.Controls.Add(this.btnCreateRaw);
            this.Controls.Add(this.tbUnitInStock);
            this.Controls.Add(this.cbUnit);
            this.Controls.Add(this.tbRawMaterialName);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "RawMaterialCreate";
            this.Text = "RawMaterialCreate";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox tbRawMaterialName;
        private System.Windows.Forms.ComboBox cbUnit;
        private System.Windows.Forms.TextBox tbUnitInStock;
        private System.Windows.Forms.Button btnCreateRaw;
    }
}