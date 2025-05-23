using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pangsit_Mie_Gloria
{
    internal class SellingTransactions
    {
        private string id_selling_transaction;
        private string id_user;
        private float total_selling_transaction;
        private DateTime date_selling_transaction;
        private string payment_method_selling_transaction;

        public SellingTransactions(string id_selling_transaction, string id_user, float total_selling_transaction, DateTime date_selling_transaction, string payment_method_selling_transaction)
        {
            this.Id_selling_transaction = id_selling_transaction;
            this.Id_user = id_user;
            this.Total_selling_transaction = total_selling_transaction;
            this.Date_selling_transaction = date_selling_transaction;
            this.Payment_method_selling_transaction = payment_method_selling_transaction;
        }

        public string Id_selling_transaction { get => id_selling_transaction; set => id_selling_transaction = value; }
        public string Id_user { get => id_user; set => id_user = value; }
        public float Total_selling_transaction { get => total_selling_transaction; set => total_selling_transaction = value; }
        public DateTime Date_selling_transaction { get => date_selling_transaction; set => date_selling_transaction = value; }
        public string Payment_method_selling_transaction { get => payment_method_selling_transaction; set => payment_method_selling_transaction = value; }
    }
}
