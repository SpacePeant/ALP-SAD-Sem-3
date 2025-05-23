namespace Pangsit_Mie_Gloria
{
    partial class RawMaterialUpdate
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
            this.btnUpdateRaw = new System.Windows.Forms.Button();
            this.tbUnitInStock = new System.Windows.Forms.TextBox();
            this.cbUnit = new System.Windows.Forms.ComboBox();
            this.tbRawMaterialName = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.tbRawMaterialID = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // btnUpdateRaw
            // 
            this.btnUpdateRaw.Location = new System.Drawing.Point(170, 175);
            this.btnUpdateRaw.Name = "btnUpdateRaw";
            this.btnUpdateRaw.Size = new System.Drawing.Size(75, 23);
            this.btnUpdateRaw.TabIndex = 13;
            this.btnUpdateRaw.Text = "UPDATE";
            this.btnUpdateRaw.UseVisualStyleBackColor = true;
            // 
            // tbUnitInStock
            // 
            this.tbUnitInStock.Location = new System.Drawing.Point(170, 95);
            this.tbUnitInStock.Name = "tbUnitInStock";
            this.tbUnitInStock.Size = new System.Drawing.Size(100, 22);
            this.tbUnitInStock.TabIndex = 12;
            // 
            // cbUnit
            // 
            this.cbUnit.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbUnit.FormattingEnabled = true;
            this.cbUnit.Items.AddRange(new object[] {
            "kg",
            "pcs",
            "gr"});
            this.cbUnit.Location = new System.Drawing.Point(170, 133);
            this.cbUnit.Name = "cbUnit";
            this.cbUnit.Size = new System.Drawing.Size(121, 24);
            this.cbUnit.TabIndex = 11;
            // 
            // tbRawMaterialName
            // 
            this.tbRawMaterialName.Location = new System.Drawing.Point(170, 58);
            this.tbRawMaterialName.Name = "tbRawMaterialName";
            this.tbRawMaterialName.Size = new System.Drawing.Size(100, 22);
            this.tbRawMaterialName.TabIndex = 10;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(28, 95);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(80, 16);
            this.label3.TabIndex = 9;
            this.label3.Text = "Unit In Stock";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(41, 136);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(33, 16);
            this.label2.TabIndex = 8;
            this.label2.Text = "Unit:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(16, 58);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(128, 16);
            this.label1.TabIndex = 7;
            this.label1.Text = "Raw Material Name:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.label4.Location = new System.Drawing.Point(12, 29);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(104, 16);
            this.label4.TabIndex = 14;
            this.label4.Text = "Raw Material ID:";
            // 
            // tbRawMaterialID
            // 
            this.tbRawMaterialID.Location = new System.Drawing.Point(170, 23);
            this.tbRawMaterialID.Name = "tbRawMaterialID";
            this.tbRawMaterialID.Size = new System.Drawing.Size(100, 22);
            this.tbRawMaterialID.TabIndex = 15;
            // 
            // RawMaterialUpdate
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.tbRawMaterialID);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.btnUpdateRaw);
            this.Controls.Add(this.tbUnitInStock);
            this.Controls.Add(this.cbUnit);
            this.Controls.Add(this.tbRawMaterialName);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "RawMaterialUpdate";
            this.Text = "RawMaterialUpdate";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnUpdateRaw;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        public System.Windows.Forms.TextBox tbUnitInStock;
        public System.Windows.Forms.ComboBox cbUnit;
        public System.Windows.Forms.TextBox tbRawMaterialName;
        private System.Windows.Forms.Label label4;
        public System.Windows.Forms.TextBox tbRawMaterialID;
    }
}