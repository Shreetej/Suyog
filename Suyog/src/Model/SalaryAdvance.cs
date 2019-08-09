using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Suyog.src.Model
{
    public class SalaryAdvance
    {
        public SalaryAdvance() {}

        public SalaryAdvance(int employeeId, string employeeName, string month, int salary, int advance, DateTime date)
        {
            this.employeeId = employeeId;
            this.employeeName = employeeName;
            this.month = month;
            this.salary = salary;
            this.advance = advance;
            this.dateOfSalary = date;
        }

        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int id { get; set; }
        public int employeeId { get; set; }
        public string employeeName { get; set; }
        public string month { get; set; }
        public int salary { get; set; }
        public int advance { get; set; }
        public DateTime dateOfSalary { get; set; }

    }
}
