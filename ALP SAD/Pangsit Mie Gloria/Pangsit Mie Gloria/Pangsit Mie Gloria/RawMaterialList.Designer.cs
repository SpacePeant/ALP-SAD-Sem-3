namespace Pangsit_Mie_Gloria
{
    partial class RawMaterialList
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
            this.dgRawMaterial = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dgRawMaterial)).BeginInit();
            this.SuspendLayout();
            // 
            // dgRawMaterial
            // 
            this.dgRawMaterial.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgRawMaterial.Location = new System.Drawing.Point(81, 75);
            this.dgRawMaterial.Name = "dgRawMaterial";
            this.dgRawMaterial.RowHeadersWidth = 51;
            this.dgRawMaterial.RowTemplate.Height = 24;
            this.dgRawMaterial.Size = new System.Drawing.Size(706, 331);
            this.dgRawMaterial.TabIndex = 0;
            // 
            // RawMaterialList
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1902, 1033);
            this.Controls.Add(this.dgRawMaterial);
            this.Name = "RawMaterialList";
            this.Text = "RawMaterialList";
            this.Load += new System.EventHandler(this.RawMaterialList_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgRawMaterial)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgRawMaterial;
    }
}