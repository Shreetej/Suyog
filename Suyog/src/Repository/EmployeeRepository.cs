using MySql.Data.Entity;
using Suyog.src.Model;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Suyog.src.Repository
{
    [DbConfigurationType(typeof(MySqlEFConfiguration))]
    class EmployeeRepository : DbContext
    {
        public EmployeeRepository() : base("MyContext")
        {

        }

        public DbSet<Employee> employees { get; set; }
    }
}
