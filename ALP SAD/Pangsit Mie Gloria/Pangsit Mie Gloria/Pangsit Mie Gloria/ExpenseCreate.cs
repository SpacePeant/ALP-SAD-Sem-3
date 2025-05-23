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
    public partial class ExpenseCreate : Form
    {
        List<TypeExpenses> listTypeExpense;
        public ExpenseCreate()
        {
            InitializeComponent();
        }

        private void ExpenseCreate_Load(object sender, EventArgs e)
        {
            listTypeExpense = TypeExpenses.ListTypeExpenses();
            cbTypeExpense.DataSource = listTypeExpense;
            cbTypeExpense.DisplayMember = "Name_type_expense";
        }

        private void btnCreate_Click(object sender, EventArgs e)
        {
            try
            {
                //MessageBox.Show(DateTime.Parse(dtDateExpense.Value.ToString()).ToString());
                Expenses ex = new Expenses(0, ((TypeExpenses)cbTypeExpense.SelectedItem).Id_type_expense,
                tbDescription.Text, float.Parse(tbTotalExpense.Text), DateTime.Parse(dtDateExpense.Value.ToString()));
                Expenses.CreateExpenses(ex);

                MessageBox.Show("Create Expense Success!");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
