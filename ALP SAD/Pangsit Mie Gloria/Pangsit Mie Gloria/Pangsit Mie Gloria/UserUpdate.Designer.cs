namespace Pangsit_Mie_Gloria
{
    partial class UserUpdate
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
            this.tbUserFullNameUpdate = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.btnUserUpdate = new System.Windows.Forms.Button();
            this.cbUserRoleUpdate = new System.Windows.Forms.ComboBox();
            this.tbUserPassUpdate = new System.Windows.Forms.TextBox();
            this.tbUserNameUpdate = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.tbUserIdUpdate = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // tbUserFullNameUpdate
            // 
            this.tbUserFullNameUpdate.Location = new System.Drawing.Point(333, 157);
            this.tbUserFullNameUpdate.Name = "tbUserFullNameUpdate";
            this.tbUserFullNameUpdate.Size = new System.Drawing.Size(100, 22);
            this.tbUserFullNameUpdate.TabIndex = 17;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(256, 157);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(71, 16);
            this.label4.TabIndex = 16;
            this.label4.Text = "Full Name:";
            // 
            // btnUserUpdate
            // 
            this.btnUserUpdate.Location = new System.Drawing.Point(264, 313);
            this.btnUserUpdate.Name = "btnUserUpdate";
            this.btnUserUpdate.Size = new System.Drawing.Size(170, 23);
            this.btnUserUpdate.TabIndex = 15;
            this.btnUserUpdate.Text = "UPDATE USER";
            this.btnUserUpdate.UseVisualStyleBackColor = true;
            // 
            // cbUserRoleUpdate
            // 
            this.cbUserRoleUpdate.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbUserRoleUpdate.FormattingEnabled = true;
            this.cbUserRoleUpdate.Items.AddRange(new object[] {
            "Admin",
            "Cashier"});
            this.cbUserRoleUpdate.Location = new System.Drawing.Point(313, 241);
            this.cbUserRoleUpdate.Name = "cbUserRoleUpdate";
            this.cbUserRoleUpdate.Size = new System.Drawing.Size(121, 24);
            this.cbUserRoleUpdate.TabIndex = 14;
            // 
            // tbUserPassUpdate
            // 
            this.tbUserPassUpdate.Location = new System.Drawing.Point(334, 207);
            this.tbUserPassUpdate.Name = "tbUserPassUpdate";
            this.tbUserPassUpdate.Size = new System.Drawing.Size(100, 22);
            this.tbUserPassUpdate.TabIndex = 13;
            // 
            // tbUserNameUpdate
            // 
            this.tbUserNameUpdate.Location = new System.Drawing.Point(334, 103);
            this.tbUserNameUpdate.Name = "tbUserNameUpdate";
            this.tbUserNameUpdate.Size = new System.Drawing.Size(100, 22);
            this.tbUserNameUpdate.TabIndex = 12;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(257, 241);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(33, 16);
            this.label3.TabIndex = 11;
            this.label3.Text = "role:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(257, 210);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(69, 16);
            this.label2.TabIndex = 10;
            this.label2.Text = "password:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(257, 103);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(70, 16);
            this.label1.TabIndex = 9;
            this.label1.Text = "username:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(256, 72);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(55, 16);
            this.label5.TabIndex = 18;
            this.label5.Text = "User ID:";
            // 
            // tbUserIdUpdate
            // 
            this.tbUserIdUpdate.Location = new System.Drawing.Point(334, 72);
            this.tbUserIdUpdate.Name = "tbUserIdUpdate";
            this.tbUserIdUpdate.Size = new System.Drawing.Size(100, 22);
            this.tbUserIdUpdate.TabIndex = 19;
            // 
            // UserUpdate
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.tbUserIdUpdate);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.tbUserFullNameUpdate);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.btnUserUpdate);
            this.Controls.Add(this.cbUserRoleUpdate);
            this.Controls.Add(this.tbUserPassUpdate);
            this.Controls.Add(this.tbUserNameUpdate);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "UserUpdate";
            this.Text = "UserUpdate";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btnUserUpdate;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label5;
        public System.Windows.Forms.TextBox tbUserFullNameUpdate;
        public System.Windows.Forms.ComboBox cbUserRoleUpdate;
        public System.Windows.Forms.TextBox tbUserPassUpdate;
        public System.Windows.Forms.TextBox tbUserNameUpdate;
        public System.Windows.Forms.TextBox tbUserIdUpdate;
    }
}