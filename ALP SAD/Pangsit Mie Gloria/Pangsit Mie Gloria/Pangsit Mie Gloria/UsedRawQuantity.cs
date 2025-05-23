using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pangsit_Mie_Gloria
{
    internal class UsedRawQuantity
    {
        private string id_product;
        private int id_raw_material;
        private int quantity;

        public UsedRawQuantity(string id_product, int id_raw_material, int quantity)
        {
            this.Id_product = id_product;
            this.Id_raw_material = id_raw_material;
            this.Quantity = quantity;
        }

        public string Id_product { get => id_product; set => id_product = value; }
        public int Id_raw_material { get => id_raw_material; set => id_raw_material = value; }
        public int Quantity { get => quantity; set => quantity = value; }
    }
}
