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
    public partial class searchForm : Form
    {
        public string searchString = "";
        public searchForm()
        {
            InitializeComponent();
            dtp_date.Hide();
        }

        private void cb_search_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void btn_search_Click(object sender, EventArgs e)
        {
            searchString = tb_search.Text;
            DateTime dateTime = dtp_date.Value;
            panel_billList.Controls.Clear();
            BillsList billsList = new BillsList(searchString, cb_search.Text, dateTime);
            billsList.TopLevel = false;
            panel_billList.Controls.Add(billsList);
            billsList.Dock = DockStyle.Fill;
            billsList.Show();
        }

        private void cb_search_SelectedIndexChanged_1(object sender, EventArgs e)
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
