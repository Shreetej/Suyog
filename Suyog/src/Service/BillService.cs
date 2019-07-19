using Suyog.src.Model;
using Suyog.src.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Suyog.src.Service
{
    public class BillService
    {
        private BillRepository billRepository;

        public BillService()
        {
            billRepository = new BillRepository();
        }

        public Bill DisplayBills(int billId)
        {
            return billRepository.Bills.Find(billId);
        }

        public Bill addBill(int billno, string truckno, string invoiceno, DateTime billDate, string sender, string receiver, string from, string to, int qty, float wt, List<Material> material)
        {
            Bill bill = billRepository.Bills.Add(new Bill(billno, truckno, invoiceno, billDate, sender, receiver, from, to, qty, wt, material));
            billRepository.SaveChanges();
            return bill;
        }

        public void updateBill(Bill bill)
        {
            Bill oldbill = billRepository.Bills.Find(bill.BillNo);
            oldbill.TruckNo = bill.TruckNo;
            oldbill.InvoiceNo = bill.InvoiceNo;
            oldbill.BillDate = bill.BillDate;
            oldbill.SenderName = bill.SenderName;
            oldbill.ReceiverName = bill.ReceiverName;
            oldbill.ToLocation = bill.ToLocation;
            oldbill.FromLocation = bill.FromLocation;
            oldbill.TotalQty = bill.TotalQty;
            oldbill.TotalWt = bill.TotalWt;
            oldbill.materials = bill.materials;
            billRepository.SaveChanges();
        }

        public void removeBill(Bill bill)
        {
            var std = billRepository.Bills.First<Bill>();
            billRepository.Bills.Remove(bill);
            billRepository.SaveChanges();
        }

        public List<Bill> displayBills()
        {
            return billRepository.Bills.ToList<Bill>();
        } 
    }
}
