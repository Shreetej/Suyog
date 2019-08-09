using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Suyog.src.Dto
{
    public class AdvanceDto
    {
        public int id { get; set; }
        public int employeeId { get; set; }
        public string employeeName { get; set; }
        public string month { get; set; }
        public int advance { get; set; }
        public DateTime dateOfSalary { get; set; }

    }
}
