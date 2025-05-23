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
    public partial class ExpenseUpdate : Form
    {
        List<TypeExpenses> listTypeExpense;
        int idExpenseUpdate = 1;
        Expenses ex;
        public ExpenseUpdate()
        {
            InitializeComponent();
        }

        private void ExpenseUpdate_Load(object sender, EventArgs e)
        {
            ex = Expenses.ListExpenses("id_expense", idExpenseUpdate.ToString())[0];

            listTypeExpense = TypeExpenses.ListTypeExpenses();
            cbTypeExpense.DataSource = listTypeExpense;
            cbTypeExpense.DisplayMember = "Name_type_expense";
            cbTypeExpense.ValueMember = "Id_type_expense";

            cbTypeExpense.SelectedValue = ex.Id_type_expense;
            tbDescription.Text = ex.Description_expense;
            tbTotalExpense.Text = ex.Total_expense.ToString();
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            try
            {
                //MessageBox.Show(DateTime.Parse(dtDateExpense.Value.ToString()).ToString());
                Expenses ex = new Expenses(idExpenseUpdate, ((TypeExpenses)cbTypeExpense.SelectedItem).Id_type_expense,
                tbDescription.Text, float.Parse(tbTotalExpense.Text), DateTime.Parse(dtDateExpense.Value.ToString()));
                Expenses.UpdateExpense(ex);

                MessageBox.Show("Update Expense Success!");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
