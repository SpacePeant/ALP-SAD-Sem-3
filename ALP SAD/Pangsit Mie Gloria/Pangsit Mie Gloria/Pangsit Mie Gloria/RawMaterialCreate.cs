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
    public partial class RawMaterialCreate : Form
    {
        public RawMaterialCreate()
        {
            InitializeComponent();
        }

        private void btnCreateRaw_Click(object sender, EventArgs e)
        {
            try
            {
                RawMaterials rawMaterials = new RawMaterials(0, tbRawMaterialName.Text, Convert.ToInt32(tbUnitInStock.Text), cbUnit.Text);
                RawMaterials.createRawMaterials(rawMaterials);
                MessageBox.Show("Raw Materials has been created succesfully");
                this.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
