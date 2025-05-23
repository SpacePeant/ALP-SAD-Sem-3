using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pangsit_Mie_Gloria
{
    internal class Products
    {
        private string id_product;
        private string id_category;
        private string name_product;
        private float price_product;
        private string picture_product;
        private string status_del;

        public Products(string id_product, string id_category, string name_product, float price_product, string picture_product, string status_del)
        {
            this.Id_product = id_product;
            this.Id_category = id_category;
            this.Name_product = name_product;
            this.Price_product = price_product;
            this.Picture_product = picture_product;
            this.Status_del = status_del;
        }

        public string Id_product { get => id_product; set => id_product = value; }
        public string Id_category { get => id_category; set => id_category = value; }
        public string Name_product { get => name_product; set => name_product = value; }
        public float Price_product { get => price_product; set => price_product = value; }
        public string Picture_product { get => picture_product; set => picture_product = value; }
        public string Status_del { get => status_del; set => status_del = value; }
    }
}
