using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pangsit_Mie_Gloria
{
    internal class Users
    {
        private int id_user;
        private string name_user;
        private string full_name_user;
        private string pass_user;
        private string role_user;
        private string status_del;

        public int Id_user { get => id_user; set => id_user = value; }
        public string Name_user { get => name_user; set => name_user = value; }
        public string Full_name_user { get => full_name_user; set => full_name_user = value; }
        public string Pass_user { get => pass_user; set => pass_user = value; }
        public string Role_user { get => role_user; set => role_user = value; }
        public string Status_del { get => status_del; set => status_del = value; }

        public Users(int id_user, string name_user, string full_name_user, string pass_user, string role_user, string status_del)
        {
            this.Id_user = id_user;
            this.Name_user = name_user;
            this.Full_name_user = full_name_user;
            this.Pass_user = pass_user;
            this.Role_user = role_user;
            this.Status_del = status_del;
        }

        public static void createUsers(Users u)
        {
            string query = $"insert into users values ( null , '{u.Name_user}', '{u.Full_name_user}' , '{u.Pass_user}' , '{u.Role_user}', '{u.Status_del}')";
            int hasil = Connection.dml(query);
            if (hasil != 1)
            {
                throw new Exception("Failed to Create User!");
            }
        }

        public static void updateUsers(Users u)
        {
            string query = $"update users set id_user = '{u.Id_user}', name_user = '{u.Name_user}' , pass_user = '{u.Pass_user}', role_user = '{u.Role_user}', status_del = '{u.Status_del}'";
            int hasil = Connection.dml(query);
            if (hasil != 1)
            {
                throw new Exception("Failed to Users");
            }
        }

        public static List<Users> readUsers()
        {
            string query = $"select * from users";
            MySqlDataReader hasil = Connection.query(query);
            List<Users> listUsers = new List<Users>();
            while (hasil.Read())
            {
                Users u = new Users(hasil.GetInt32(0), hasil.GetString(1), hasil.GetString(2), hasil.GetString(3), hasil.GetString(4), hasil.GetString(5));
                listUsers.Add(u);
            }
            return listUsers;

        }

    }
}
