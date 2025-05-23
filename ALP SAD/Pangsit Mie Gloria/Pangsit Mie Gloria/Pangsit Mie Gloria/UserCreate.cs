using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Globalization;



namespace Pangsit_Mie_Gloria
{
    public partial class UserCreate : Form
    {
        public UserCreate()
        {
            InitializeComponent();
        }

        private void btnUserCreate_Click(object sender, EventArgs e)
        {
            try
            {
                //MessageBox.Show(ToTitleCase("alvin fernando"));
                string role = " ";
                if (cbUserRole.Text == "Admin")
                {
                    role = "A";
                }
                else if (cbUserRole.Text == "Cashier")
                {
                    role = "C";
                }
                Users users = new Users(0, tbUserName.Text, ToTitleCase(tbFullNameUser.Text), tbUserPass.Text, role, "F");
                Users.createUsers(users);
                MessageBox.Show("User has been created succesfully");
                this.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private string ToTitleCase(string text)
        {
            TextInfo textInfo = CultureInfo.CurrentCulture.TextInfo;
             return textInfo.ToTitleCase(text.ToLower());
        }

    }
}
