using Suyog.src.Model;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Suyog.src.Repository
{
    public class BillRepository : DbContext
    {
        public BillRepository() : base()
        {

        }

        public DbSet<Bill> Bills { get; set; }
        public DbSet<Material> Materials { get; set; }
    }
}
