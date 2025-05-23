using Microsoft.SqlServer.Server;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pangsit_Mie_Gloria
{
    internal class Expenses
    {
        #region Field
        private int id_expense;
        private int id_type_expense;
        private string description_expense;
        private float total_expense;
        private DateTime date_expense;
        #endregion

        #region Const
        public Expenses(int id_expense, int id_type_expense, string description_expense, float total_expense, DateTime date_expense)
        {
            this.Id_expense = id_expense;
            this.Id_type_expense = id_type_expense;
            this.Description_expense = description_expense;
            this.Total_expense = total_expense;
            this.Date_expense = date_expense;
        }
        #endregion

        #region Properties
        public int Id_expense { get => id_expense; set => id_expense = value; }
        public int Id_type_expense { get => id_type_expense; set => id_type_expense = value; }
        public string Description_expense { get => description_expense; set => description_expense = value; }
        public float Total_expense { get => total_expense; set => total_expense = value; }
        public DateTime Date_expense { get => date_expense; set => date_expense = value; }
        #endregion

        #region Method
        public static void CreateExpenses(Expenses e)
        {
            string query = $"insert into expenses values (null, '{e.Id_type_expense}', '{e.Description_expense}', '{e.Total_expense}', '{e.Date_expense.ToString("yyyy-MM-dd")}')";
            int hasil = Connection.dml(query);
            if (hasil != 1)
            {
                throw new Exception("Create Expenses Failed");
            }
        }

        public static List<Expenses> ListExpenses(string kriteria, string nilaiKriteria)
        {
            string query = "";
            if (kriteria == "")
            {
                query = "select * from expenses;";
            }
            else
            {
                query = $"select * from expenses where {kriteria} like '%{nilaiKriteria}%'";
            }
            MySqlDataReader hasil = Connection.query(query);
            List<Expenses> listExpenses = new List<Expenses>();
            while (hasil.Read())
            {
                Expenses e = new Expenses(hasil.GetInt32(0), hasil.GetInt32(1), hasil.GetString(2), hasil.GetFloat(3), (DateTime)hasil.GetValue(4));
                listExpenses.Add(e);
            }
            return listExpenses;
        }

        public static void UpdateExpense(Expenses e)
        {
            string query = "";
            query = $"update expenses set id_type_expense = '{e.Id_type_expense}', description_expense='{e.Description_expense}', total_expense = '{e.Total_expense}', date_expense='{e.Date_expense.ToString("yyyy-MM-dd")}' where id_expense = '{e.Id_expense}'";
            int hasil = Connection.dml(query);
            if (hasil != 1)
            {
                throw new Exception("Update Expenses Success");
            }
        }

        public static void DeleteExpenses(int expensesID)
        {
            string query = $"delete from expenses where id_expenses = '{expensesID}'";
            int hasil = Connection.dml(query);
            if (hasil != 1)
            {
                throw new Exception("Delete Expense Failed");
            }
        }
        #endregion
    }
}
