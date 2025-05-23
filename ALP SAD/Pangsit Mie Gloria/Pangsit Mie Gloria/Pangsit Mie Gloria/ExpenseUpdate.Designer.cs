namespace Pangsit_Mie_Gloria
{
    partial class ExpenseUpdate
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
            this.btnUpdate = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.dtDateExpense = new System.Windows.Forms.DateTimePicker();
            this.label4 = new System.Windows.Forms.Label();
            this.tbTotalExpense = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.cbTypeExpense = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.tbDescription = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnUpdate
            // 
            this.btnUpdate.Location = new System.Drawing.Point(317, 286);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(93, 23);
            this.btnUpdate.TabIndex = 29;
            this.btnUpdate.Text = "Update";
            this.btnUpdate.UseVisualStyleBackColor = true;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(91, 250);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(45, 16);
            this.label5.TabIndex = 28;
            this.label5.Text = "Date : ";
            // 
            // dtDateExpense
            // 
            this.dtDateExpense.Location = new System.Drawing.Point(144, 245);
            this.dtDateExpense.Name = "dtDateExpense";
            this.dtDateExpense.Size = new System.Drawing.Size(266, 22);
            this.dtDateExpense.TabIndex = 27;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(141, 211);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(28, 16);
            this.label4.TabIndex = 26;
            this.label4.Text = "Rp.";
            // 
            // tbTotalExpense
            // 
            this.tbTotalExpense.Location = new System.Drawing.Point(175, 211);
            this.tbTotalExpense.Name = "tbTotalExpense";
            this.tbTotalExpense.Size = new System.Drawing.Size(235, 22);
            this.tbTotalExpense.TabIndex = 25;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(35, 211);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(103, 16);
            this.label3.TabIndex = 24;
            this.label3.Text = "Total Expense : ";
            // 
            // cbTypeExpense
            // 
            this.cbTypeExpense.FormattingEnabled = true;
            this.cbTypeExpense.Location = new System.Drawing.Point(144, 31);
            this.cbTypeExpense.Name = "cbTypeExpense";
            this.cbTypeExpense.Size = new System.Drawing.Size(266, 24);
            this.cbTypeExpense.TabIndex = 23;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(27, 34);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(111, 16);
            this.label2.TabIndex = 22;
            this.label2.Text = "Type Expenses : ";
            // 
            // tbDescription
            // 
            this.tbDescription.Location = new System.Drawing.Point(144, 72);
            this.tbDescription.Multiline = true;
            this.tbDescription.Name = "tbDescription";
            this.tbDescription.Size = new System.Drawing.Size(266, 127);
            this.tbDescription.TabIndex = 21;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(54, 72);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(84, 16);
            this.label1.TabIndex = 20;
            this.label1.Text = "Description : ";
            // 
            // ExpenseUpdate
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(440, 343);
            this.Controls.Add(this.btnUpdate);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.dtDateExpense);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.tbTotalExpense);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.cbTypeExpense);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.tbDescription);
            this.Controls.Add(this.label1);
            this.Name = "ExpenseUpdate";
            this.Text = "ExpenseUpdate";
            this.Load += new System.EventHandler(this.ExpenseUpdate_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.DateTimePicker dtDateExpense;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox tbTotalExpense;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox cbTypeExpense;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox tbDescription;
        private System.Windows.Forms.Label label1;
    }
}