using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pangsit_Mie_Gloria
{
    internal class RawMaterials
    {
        private int id_raw_material;
        private string name_raw_material;
        private int unit_in_stock;
        private string unit;

        public RawMaterials(int id_raw_material, string name_raw_material, int unit_in_stock, string unit)
        {
            this.Id_raw_material = id_raw_material;
            this.Name_raw_material = name_raw_material;
            this.Unit_in_stock = unit_in_stock;
            this.Unit = unit;
        }


        public int Id_raw_material { get => id_raw_material; set => id_raw_material = value; }
        public string Name_raw_material { get => name_raw_material; set => name_raw_material = value; }
        public int Unit_in_stock { get => unit_in_stock; set => unit_in_stock = value; }
        public string Unit { get => unit; set => unit = value; }

        public static string generateId()
        {
            string queryOffset = "select count(*) from raw_materials";
            MySqlDataReader reader = Connection.query(queryOffset);
            reader.Read();
            int offsetValue = reader.GetInt32(0);

            // Jika tidak ada data dalam tabel raw_materials
            if (offsetValue == 0)
            {
                return "1";
            }

            // Ambil ID terakhir dalam tabel raw_materials
            string query = $"select id_raw_material from raw_materials order by id_raw_material desc limit 1";
            MySqlDataReader hasil = Connection.query(query);

            string lastId;
            if (hasil.Read())
            {
                lastId = hasil.GetString(0);
            }
            else
            {
                lastId = "0";
            }

            // Konversi lastId menjadi integer, tambahkan 1 untuk ID baru
            int convertId = int.Parse(lastId) + 1;
            return convertId.ToString();
        }


        public static void createRawMaterials(RawMaterials r)
        {
            string query = $"insert into raw_materials values ('{generateId()}' , '{r.Name_raw_material}', '{r.Unit_in_stock}' , '{r.Unit}')";
            int hasil = Connection.dml(query);
            if (hasil != 1)
            {
                throw new Exception("Failed to Insert Raw Materials");
            }
        }

        public static void updateRawMaterials(RawMaterials r)
        {
            string query = $"update raw_materials set name_raw_material = '{r.Name_raw_material}', unit_in_stock = '{r.Unit_in_stock}' , unit = '{r.Unit}'";
            int hasil = Connection.dml(query);
            if (hasil != 1)
            {
                throw new Exception("Failed to Update Raw Materials");
            }
        }

        public static List<RawMaterials> readRawMaterials()
        {
            string query = $"select * from raw_materials";
            MySqlDataReader hasil = Connection.query(query);
            List<RawMaterials> listRawMaterials = new List<RawMaterials>();
            while(hasil.Read())
            {
                RawMaterials r = new RawMaterials(hasil.GetInt32(0), hasil.GetString(1), hasil.GetInt32(2), hasil.GetString(3));
                listRawMaterials.Add(r);
            }
            return listRawMaterials;

        }

    }
}
