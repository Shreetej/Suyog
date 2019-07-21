using Suyog.src.Model;
using Suyog.src.Repository;
using System;
using System.Collections;
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

        public Bill DisplayBillbyId(int billid)
        {
            return billRepository.Bills.Find(billid);
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

        public List<Bill> DisplayBills(string search, string searchtype, DateTime dateTime)
        {
            if (string.IsNullOrEmpty(search))
            {
                return billRepository.Bills.ToList<Bill>();
            }
            else
            {
                switch (searchtype)
                {
                    case "BillNo":
                        int billNo = int.Parse(search);
                        List<Bill> list = new List<Bill>();
                        list.Add(DisplayBillbyId(billNo));
                        return list;

                    case "TruckNo":
                        return billRepository.Bills.Where(s => s.TruckNo.Equals(search)).ToList<Bill>();

                    case "InvoiceNo":
                        return billRepository.Bills.Where(s => s.InvoiceNo.Equals(search)).ToList<Bill>();

                    case "BillDate":
                        return billRepository.Bills.Where(s => s.BillDate.Date.Equals(dateTime.Date)).ToList<Bill>();

                    case "SenderName":
                        return billRepository.Bills.Where(s => s.SenderName.Equals(search)).ToList<Bill>();

                    case "ReceiverName":
                        return billRepository.Bills.Where(s => s.ReceiverName.Equals(search)).ToList<Bill>();

                    case "FromLocation":
                        return billRepository.Bills.Where(s => s.FromLocation.Equals(search)).ToList<Bill>();

                    case "ToLocation":
                        return billRepository.Bills.Where(s => s.ToLocation.Equals(search)).ToList<Bill>();
                }
                return null;
            }
          
        }
    }
}
