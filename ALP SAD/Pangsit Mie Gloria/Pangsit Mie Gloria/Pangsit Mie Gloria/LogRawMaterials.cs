using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pangsit_Mie_Gloria
{
    internal class LogRawMaterials
    {
        private string id_log_raw;
        private string id_raw_material;
        private string name_log_raw;
        private int quantity_log;
        private int initial_stock;
        private int final_stock;
        private DateTime date_log;

        public LogRawMaterials(string id_log_raw, string id_raw_material, string name_log_raw, int quantity_log, int initial_stock, int final_stock, DateTime date_log)
        {
            this.Id_log_raw = id_log_raw;
            this.Id_raw_material = id_raw_material;
            this.Name_log_raw = name_log_raw;
            this.Quantity_log = quantity_log;
            this.Initial_stock = initial_stock;
            this.Final_stock = final_stock;
            this.Date_log = date_log;
        }

        public string Id_log_raw { get => id_log_raw; set => id_log_raw = value; }
        public string Id_raw_material { get => id_raw_material; set => id_raw_material = value; }
        public string Name_log_raw { get => name_log_raw; set => name_log_raw = value; }
        public int Quantity_log { get => quantity_log; set => quantity_log = value; }
        public int Initial_stock { get => initial_stock; set => initial_stock = value; }
        public int Final_stock { get => final_stock; set => final_stock = value; }
        public DateTime Date_log { get => date_log; set => date_log = value; }
    }
}
