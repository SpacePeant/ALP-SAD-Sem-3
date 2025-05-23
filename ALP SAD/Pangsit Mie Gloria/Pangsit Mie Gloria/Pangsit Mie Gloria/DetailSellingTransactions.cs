using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pangsit_Mie_Gloria
{
    internal class DetailSellingTransactions
    {
        private string id_selling_transaction;
        private string id_product;
        private int quantity;
        private float subtotal;

        public DetailSellingTransactions(string id_selling_transaction, string id_product, int quantity, float subtotal)
        {
            this.Id_selling_transaction = id_selling_transaction;
            this.Id_product = id_product;
            this.Quantity = quantity;
            this.Subtotal = subtotal;
        }

        public string Id_selling_transaction { get => id_selling_transaction; set => id_selling_transaction = value; }
        public string Id_product { get => id_product; set => id_product = value; }
        public int Quantity { get => quantity; set => quantity = value; }
        public float Subtotal { get => subtotal; set => subtotal = value; }
    }
}
