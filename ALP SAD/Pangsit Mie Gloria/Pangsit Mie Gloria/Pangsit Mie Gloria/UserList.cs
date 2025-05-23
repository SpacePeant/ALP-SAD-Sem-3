using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Pangsit_Mie_Gloria
{
    public partial class UserList : Form
    {
        List<Users> listUsers;

        public UserList()
        {
            InitializeComponent();
        }

        private void UserList_Load(object sender, EventArgs e)
        {
            listUsers = Users.readUsers();
            DataTable dtUser = new DataTable();
            dtUser.Columns.Add("ID");
            dtUser.Columns.Add("Username");
            dtUser.Columns.Add("Full Name");
            dtUser.Columns.Add("User Role");

            foreach (Users u in listUsers)
            {
                dtUser.Rows.Add(u.Id_user, u.Name_user, u.Full_name_user, u.Role_user);
            }
            dgUser.DataSource = dtUser;

            DataGridViewButtonColumn button = new DataGridViewButtonColumn();
            button.Name = "Edit";
            button.HeaderText = "Action";
            button.Text = "Edit";
            button.UseColumnTextForButtonValue = true;

            dgUser.Columns.Add(button);

            dgUser.CellContentClick += dgRawMaterial_CellContentClick;
        }

        private void dgRawMaterial_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == dgUser.Columns["Edit"].Index && e.RowIndex >= 0)
            {
                string id = dgUser.Rows[e.RowIndex].Cells["ID"].Value.ToString();
                string userName = dgUser.Rows[e.RowIndex].Cells["Username"].Value.ToString();
                string fullName = dgUser.Rows[e.RowIndex].Cells["Full Name"].Value.ToString();
                string role = dgUser.Rows[e.RowIndex].Cells["User Role"].Value.ToString();

                UserUpdate frm = new UserUpdate();
                frm.Owner = this;
                frm.tbUserIdUpdate.Text = id;
                frm.tbUserNameUpdate.Text = userName;
                frm.tbUserFullNameUpdate.Text = fullName;
                frm.cbUserRoleUpdate.Text = role;

                frm.ShowDialog();
            }
        }
    }
}
