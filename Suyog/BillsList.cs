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
    public partial class BillsList : Form
    {
        private string search;
        private string searchtype;
        private DateTime dateTime;

        public BillsList(string search, string searchtype, DateTime dateTime)
        {
            InitializeComponent();
            this.search = search;
            this.searchtype = searchtype;
            this.dateTime = dateTime;
        }

        private void BillsList_Load(object sender, EventArgs e)
        { 
            BillService billService = new BillService();
            var list = billService.DisplayBills(search,searchtype,dateTime);
            var bindingList = new BindingList<Bill>(list);
            var source = new BindingSource(bindingList, null);
            dg_billList.DataSource = source;
        }

    }
}
