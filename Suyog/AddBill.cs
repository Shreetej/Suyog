using Suyog.src.Model;
using Suyog.src.Service;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Suyog
{
    public partial class AddBill : Form
    {
        private BillService billService;
        public AddBill()
        {
            InitializeComponent();
            dg_materials.Columns.Add("materialType", "Material Type");
            dg_materials.Columns.Add("Quantity", "Quantity");
            dg_materials.Columns.Add("Units", "Units");
        }

        private void Label2_Click(object sender, EventArgs e)
        {

        }

        private void TextBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void btn_add_Click(object sender, EventArgs e)
        {
            try {
                //DataGridViewColumnCollection data = new DataGridViewColumnCollection();
                //dg_materials.Columns[0].Name = "Material Type";
                //dg_materials.Columns[1].Name = "Quantity";
                //dg_materials.Columns[2].Name = "Units";

                dg_materials.Rows.Add(cb_materialType.Text, tb_qty.Text, tb_units.Text);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }
        private void btn_save_Click(object sender, EventArgs e)
        {
            try
            {
                int totalwt, totalqty = 0, totalunits = 0;
                List<Material> materials = new List<Material>();
                foreach (DataGridViewRow rows in dg_materials.Rows)
                {
                    Material material = new Material(rows.Cells[0].Value.ToString(),int.Parse(rows.Cells[1].Value.ToString()), int.Parse(rows.Cells[2].Value.ToString()));
                    materials.Add(material);
                    totalqty = totalqty + material.Qty;
                    totalunits = totalunits + material.Units;
                }
                totalwt = totalunits * totalqty;
                billService = new BillService();
                Bill bill = billService.addBill(int.Parse(tb_billNo.Text), cb_truckno.Text, tb_invoiceNo.Text, billDate.Value, cb_sender.Text, cb_reciever.Text, tb_from.Text, tb_to.Text, totalqty, totalwt, materials);
                MessageBox.Show("Bill Added Sucessfully.");
                clearAllControls();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btn_back_Click(object sender, EventArgs e)
        {
            Form std = this;
            Home home = new Home();
            std.Close();
        }

        private void clearAllControls()
        {
            tb_billNo.Clear();
            cb_truckno.Items.Clear();
            tb_invoiceNo.Clear();
            cb_sender.Items.Clear();
            cb_reciever.Items.Clear();
            tb_from.Clear();
            tb_to.Clear();
            cb_materialType.Items.Clear();
            tb_qty.Clear();
            tb_units.Clear();
            dg_materials.Rows.Clear();
        }
    }
}
