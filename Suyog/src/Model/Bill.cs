using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Suyog.src.Model
{
    public class Bill
    {
        public int BillNo { get; set; }
        public string TruckNo { get; set; }
        public string InvoiceNo { get; set; }
        public DateTime BillDate { get; set; }
        public string SenderName { get; set; }
        public string ReceiverName { get; set; }
        public string FromLocation { get; set; }
        public string ToLocation { get; set; }
        public int TotalQty { get; set; }
        public float TotalWt { get; set; }
        public Material Material { get; set; }
    }
}
