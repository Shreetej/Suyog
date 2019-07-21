
using MySql.Data.Entity;
using Suyog.src.Model;
using System.Data.Entity;

namespace Suyog.src.Repository
{
    [DbConfigurationType(typeof(MySqlEFConfiguration))]
    public class BillRepository : DbContext
    {   
        public BillRepository() : base("MyContext")
        {

        }

        public DbSet<Bill> Bills { get; set; }
        public DbSet<Material> Materials { get; set; }
        //public DbSet<Employee> Employees { get; set; }

    }
}
