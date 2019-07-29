using MySql.Data.Entity;
using Suyog.src.Model;
using System.Data.Entity;

namespace Suyog.src.Repository
{
    [DbConfigurationType(typeof(MySqlEFConfiguration))]
    public class EmployeeRepository : DbContext
    {
        public EmployeeRepository() : base("MyContext")
        {

        }

        public DbSet<Employee> Employees { get; set; }
    }
}
