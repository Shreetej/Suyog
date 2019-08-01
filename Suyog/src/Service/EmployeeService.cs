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
    public class EmployeeService
    {
        private EmployeeRepository employeeRepository;

        public static byte[] imageToByteArray(System.Drawing.Image imageIn)
        {
            byte[] data = new byte[0];
            using (MemoryStream ms = new MemoryStream())
            {
                var img = new Bitmap(imageIn);
                img.Save(ms, System.Drawing.Imaging.ImageFormat.Jpeg);
                data = ms.ToArray();
            };
            return data;
        }

        public static Image byteArrayToImage(byte[] byteArrayIn)
        {
            Image returnImage;
            using (MemoryStream ms = new MemoryStream(byteArrayIn))
            {
                returnImage = Image.FromStream(ms);
            }
            return returnImage;
        }

        public Employee addEmployee(string employeeName, string employeeAddress, DateTime dob, DateTime doj, string mobile, string aadhar, string pancard, Image photo, Image aadharimg, Image pancardimg)
        {

            byte[] photo1 = imageToByteArray(photo);
            byte[] aadhar1 =  imageToByteArray(aadharimg);
            byte[] pancard1 = imageToByteArray(pancardimg);
            
            Employee employee = new Employee(employeeName, employeeAddress, dob.Date, doj.Date, mobile, aadhar, pancard, photo1, aadhar1, pancard1);
            employeeRepository = new EmployeeRepository();
            employee = employeeRepository.Employees.Add(employee);
            employeeRepository.SaveChanges();
            return employee;
        }

        public void updateEmployee(Employee employee, Image photo, Image aadharimg, Image pancardimg)
        {
            byte[] photo1 = imageToByteArray(photo);
            byte[] aadhar1 = imageToByteArray(aadharimg);
            byte[] pancard1 = imageToByteArray(pancardimg);

            employeeRepository = new EmployeeRepository();
            Employee oldEmployee = employeeRepository.Employees.Find(employee.employeeId);
            oldEmployee.employeeName = employee.employeeName;
            oldEmployee.employeeAddress = employee.employeeAddress;
            oldEmployee.dob = employee.dob;
            oldEmployee.doj = employee.doj;
            oldEmployee.mobile = employee.mobile;
            oldEmployee.aadhar = employee.aadhar;
            oldEmployee.pancard = employee.pancard;
            oldEmployee.photo = photo1;
            oldEmployee.aadharimg = aadhar1;
            oldEmployee.pancardimg = pancard1;
            employeeRepository.SaveChanges();
            
        }

        public void deleteEmployee(int empId)
        {
            employeeRepository = new EmployeeRepository();
            var std = employeeRepository.Employees.Find(empId);
            employeeRepository.Employees.Remove(std);
            employeeRepository.SaveChanges();           
        }

        public List<Employee> DisplayEmployees()
        {
            employeeRepository = new EmployeeRepository();
            return employeeRepository.Employees.ToList();
        }

        public Employee displayEmployeeById(int id)
        {
            employeeRepository = new EmployeeRepository();
            return employeeRepository.Employees.Find(id);
        }
    }
}
