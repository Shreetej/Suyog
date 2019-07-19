using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Suyog.src.Model
{
    public class Bill
    {
        
        public Bill() { }

        public Bill(int billno, string truckno, string invoiceno, DateTime billDate, string sender, string receiver, string from, string to, int qty, float wt, List<Material> material)
        {
            BillNo = billno;
            TruckNo = truckno;
            InvoiceNo = invoiceno;
            BillDate = billDate;
            SenderName= sender;
            ReceiverName = receiver;
            FromLocation= from;
            ToLocation= to;
            TotalQty = qty;
            TotalWt= wt;
            materials = material;
        }

        [Key]
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
        public List<Material> materials { get; set; }
    }
}
