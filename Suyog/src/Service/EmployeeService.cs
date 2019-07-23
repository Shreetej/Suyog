using Suyog.src.Model;
using Suyog.src.Repository;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Suyog.src.Service
{
    class EmployeeService
    {
        private EmployeeRepository employeeRepository;

        public byte[] imageToByteArray(System.Drawing.Image imageIn)
        {
            MemoryStream ms = new MemoryStream();
            imageIn.Save(ms, System.Drawing.Imaging.ImageFormat.Jpeg);
            return ms.ToArray();
        }

        public Image byteArrayToImage(byte[] byteArrayIn)
        {
            MemoryStream ms = new MemoryStream(byteArrayIn);
            Image returnImage = Image.FromStream(ms);
            return returnImage;
        }

        public Employee addEmployee(string employeeName, string employeeAddress, DateTime dob, DateTime doj, string mobile, string aadhar, string pancard, Image photo, Image aadharimg, Image pancardimg)
        {
            byte[] photo1 = imageToByteArray(photo);
            byte[] aadhar1 = imageToByteArray(aadharimg);
            byte[] pancard1 = imageToByteArray(pancardimg);
            Employee employee = new Employee(employeeName, employeeAddress, dob.Date, doj.Date, mobile, aadhar, pancard, photo1, aadhar1, pancard1);
            employeeRepository = new EmployeeRepository();
            return employeeRepository.employees.Add(employee);
        }

        public Employee updateEmployee()
        {
            return null;
        }

        public void deleteEmployee(Employee employee)
        {
            var std = employeeRepository.employees.Find(employee.employeeId);
            employeeRepository.employees.Remove(std);
            employeeRepository.SaveChanges();           
        }

        public List<Employee> DisplayEmployees()
        {
            return employeeRepository.employees.ToList();
        }

        public Employee displayEmployeeById(int id)
        {
            return employeeRepository.employees.Find(id);
        }
    }
}
