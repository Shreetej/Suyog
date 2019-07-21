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
    public partial class Home : Form
    {
        public string searchString = "";
        public Home()
        {
            InitializeComponent();
            dtp_date.Hide();
        }

        private void btn_add_Click(object sender, EventArgs e)
        {
            Form currentform = this;
            AddBill addBill = new AddBill();
            addBill.ShowDialog();
            currentform.Close();
        }

        private void btn_search_Click(object sender, EventArgs e)
        {
            searchString = tb_search.Text;
            DateTime dateTime = dtp_date.Value;

            BillsList billsList = new BillsList(searchString,cb_search.Text,dateTime);
            billsList.Show();
        }

        private void cb_search_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cb_search.Text.Equals("BillDate"))
            {
                tb_search.Hide();
                dtp_date.Show();
            }
            else
            {
                dtp_date.Hide();
                tb_search.Show();
            }
        }
    }
}
