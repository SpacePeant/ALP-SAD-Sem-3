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
    public partial class RawMaterialList : Form
    {
        List<RawMaterials> listRawMaterials;
        public RawMaterialList()
        {
            InitializeComponent();
        }

        private void RawMaterialList_Load(object sender, EventArgs e)
        {
            listRawMaterials = RawMaterials.readRawMaterials();
            DataTable dtRaw = new DataTable();
            dtRaw.Columns.Add("ID");
            dtRaw.Columns.Add("Name");
            dtRaw.Columns.Add("Unit In Stock");
            dtRaw.Columns.Add("Unit");

            foreach(RawMaterials r in listRawMaterials)
            {
                dtRaw.Rows.Add(r.Id_raw_material, r.Name_raw_material, r.Unit_in_stock, r.Unit);
            }
            dgRawMaterial.DataSource = dtRaw;

            DataGridViewButtonColumn button = new DataGridViewButtonColumn();
            button.Name = "Edit";
            button.HeaderText = "Action";
            button.Text = "Edit";
            button.UseColumnTextForButtonValue = true;

            dgRawMaterial.Columns.Add(button);

            dgRawMaterial.CellContentClick += dgRawMaterial_CellContentClick;
        }

        private void dgRawMaterial_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == dgRawMaterial.Columns["Edit"].Index && e.RowIndex >= 0)
            {
                string id = dgRawMaterial.Rows[e.RowIndex].Cells["ID"].Value.ToString();
                string name = dgRawMaterial.Rows[e.RowIndex].Cells["Name"].Value.ToString();
                int unitInStock = Convert.ToInt32(dgRawMaterial.Rows[e.RowIndex].Cells["Unit In Stock"].Value);
                string unit = dgRawMaterial.Rows[e.RowIndex].Cells["Unit"].Value.ToString();

                RawMaterialUpdate frm = new RawMaterialUpdate();
                frm.Owner = this;
                frm.tbRawMaterialID.Text = id;
                frm.tbRawMaterialName.Text = name;
                frm.tbUnitInStock.Text = unitInStock.ToString();
                frm.cbUnit.Text = unit;

                frm.ShowDialog();
            }
        }
    }
}
