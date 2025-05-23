namespace Pangsit_Mie_Gloria
{
    partial class ExpenseCreate
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
            this.btnCreate = new System.Windows.Forms.Button();
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
            // btnCreate
            // 
            this.btnCreate.Location = new System.Drawing.Point(309, 284);
            this.btnCreate.Name = "btnCreate";
            this.btnCreate.Size = new System.Drawing.Size(93, 23);
            this.btnCreate.TabIndex = 19;
            this.btnCreate.Text = "Create";
            this.btnCreate.UseVisualStyleBackColor = true;
            this.btnCreate.Click += new System.EventHandler(this.btnCreate_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(83, 248);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(45, 16);
            this.label5.TabIndex = 18;
            this.label5.Text = "Date : ";
            // 
            // dtDateExpense
            // 
            this.dtDateExpense.Location = new System.Drawing.Point(136, 243);
            this.dtDateExpense.Name = "dtDateExpense";
            this.dtDateExpense.Size = new System.Drawing.Size(266, 22);
            this.dtDateExpense.TabIndex = 17;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(133, 209);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(28, 16);
            this.label4.TabIndex = 16;
            this.label4.Text = "Rp.";
            // 
            // tbTotalExpense
            // 
            this.tbTotalExpense.Location = new System.Drawing.Point(167, 209);
            this.tbTotalExpense.Name = "tbTotalExpense";
            this.tbTotalExpense.Size = new System.Drawing.Size(235, 22);
            this.tbTotalExpense.TabIndex = 15;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(27, 209);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(103, 16);
            this.label3.TabIndex = 14;
            this.label3.Text = "Total Expense : ";
            // 
            // cbTypeExpense
            // 
            this.cbTypeExpense.FormattingEnabled = true;
            this.cbTypeExpense.Location = new System.Drawing.Point(136, 29);
            this.cbTypeExpense.Name = "cbTypeExpense";
            this.cbTypeExpense.Size = new System.Drawing.Size(266, 24);
            this.cbTypeExpense.TabIndex = 13;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(19, 32);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(111, 16);
            this.label2.TabIndex = 12;
            this.label2.Text = "Type Expenses : ";
            // 
            // tbDescription
            // 
            this.tbDescription.Location = new System.Drawing.Point(136, 70);
            this.tbDescription.Multiline = true;
            this.tbDescription.Name = "tbDescription";
            this.tbDescription.Size = new System.Drawing.Size(266, 127);
            this.tbDescription.TabIndex = 11;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(46, 70);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(84, 16);
            this.label1.TabIndex = 10;
            this.label1.Text = "Description : ";
            // 
            // ExpenseCreate
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(421, 320);
            this.Controls.Add(this.btnCreate);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.dtDateExpense);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.tbTotalExpense);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.cbTypeExpense);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.tbDescription);
            this.Controls.Add(this.label1);
            this.Name = "ExpenseCreate";
            this.Text = "ExpenseCreate";
            this.Load += new System.EventHandler(this.ExpenseCreate_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnCreate;
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