using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pangsit_Mie_Gloria
{
    internal class Categories
    {
        private string id_category;
        private string name_category;

        public Categories(string id_category, string name_category)
        {
            this.Id_category = id_category;
            this.Name_category = name_category;
        }

        public string Id_category { get => id_category; set => id_category = value; }
        public string Name_category { get => name_category; set => name_category = value; }
    }
}
