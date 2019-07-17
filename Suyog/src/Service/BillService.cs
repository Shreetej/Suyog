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
            return null;//billRepository.;
        }
    }
}
