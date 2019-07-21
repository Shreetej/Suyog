using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Suyog.src.Model
{
    class Employee
    {
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int employeeId { get; set; }
        public string employeeName { get; set; }
        public string employeeAddress { get; set; }
        public DateTime dob { get; set; }
        public DateTime doj { get; set; }
        public string mobile { get; set; }
        public string aadhar { get; set; }
        public string pancard { get; set; }

        public Employee() { }

        public Employee(string employeeName, string employeeAddress, DateTime dob, DateTime doj, string mobile, string aadhar, string pancard)
        {
            this.employeeName = employeeName;
            this.employeeAddress = employeeAddress;
            this.dob = dob;
            this.doj = doj;
            this.mobile = mobile;
            this.aadhar = aadhar;
            this.pancard = pancard;
        }
    }
}
