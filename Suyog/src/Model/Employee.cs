using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Suyog.src.Model
{
    public class Employee
    {
        
        public Employee() { }

        public Employee(string employeeName, string employeeAddress, DateTime dob, DateTime doj, string mobile, string aadhar, string pancard, byte[] photo, byte[] aadharimg, byte[] pancardimg)
        {
            this.employeeName = employeeName;
            this.employeeAddress = employeeAddress;
            this.dob = dob;
            this.doj = doj;
            this.mobile = mobile;
            this.aadhar = aadhar;
            this.pancard = pancard;
            this.photo = photo;
            this.aadharimg = aadharimg;
            this.pancardimg = pancardimg;
            
        }

        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int employeeId { get; set; }
        public string employeeName { get; set; }
        public string employeeAddress { get; set; }
        public DateTime dob { get; set; }
        public DateTime doj { get; set; }
        public string mobile { get; set; }
        public string aadhar { get; set; }
        public string pancard { get; set; }
        public byte[] photo { get; set; }
        public byte[] aadharimg { get; set; }
        public byte[] pancardimg { get; set; }

    }
}
