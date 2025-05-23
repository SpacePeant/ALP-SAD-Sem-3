using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pangsit_Mie_Gloria
{
    internal class TypeExpenses
    {
        #region Field
        private int id_type_expense;
        private string name_type_expense;
        #endregion

        #region Const
        public TypeExpenses(int id_type_expense, string name_type_expense)
        {
            this.Id_type_expense = id_type_expense;
            this.Name_type_expense = name_type_expense;
        }
        #endregion

        #region Properties
        public int Id_type_expense { get => id_type_expense; set => id_type_expense = value; }
        public string Name_type_expense { get => name_type_expense; set => name_type_expense = value; }
        #endregion

        #region Method
        public static List<TypeExpenses> ListTypeExpenses()
        {
            string query = "select * from type_expenses;";
            MySqlDataReader hasil = Connection.query(query);
            List<TypeExpenses> listExpenses = new List<TypeExpenses>();
            while (hasil.Read())
            {
                TypeExpenses e = new TypeExpenses(hasil.GetInt32(0), hasil.GetString(1));
                listExpenses.Add(e);
            }
            return listExpenses;
        }

        public static TypeExpenses GetTypeExpenses(string kriteria, string nilaiKriteria)
        {
            string query = $"select * from type_expenses where {kriteria} = '{nilaiKriteria}';";
            MySqlDataReader hasil = Connection.query(query);
            hasil.Read();
            TypeExpenses typeExpenses = new TypeExpenses(hasil.GetInt32(0), hasil.GetString(1));
            return typeExpenses;
        }
        #endregion
    }
}
