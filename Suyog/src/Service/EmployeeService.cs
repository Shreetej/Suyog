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
        private SuyogRepository suyogRepository;

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
            byte[] photo1 = null;
            if (photo != null) {
                photo1 = imageToByteArray(photo);
            }
            byte[] aadhar1 = null;
            if (aadharimg != null) {
                aadhar1 = imageToByteArray(aadharimg);
            }
            byte[] pancard1 = null;
            if (pancardimg != null)
            {
                pancard1 = imageToByteArray(pancardimg);
            }

            Employee employee = new Employee(employeeName, employeeAddress, dob.Date, doj.Date, mobile, aadhar, pancard, photo1, aadhar1, pancard1);
            suyogRepository = new SuyogRepository();
            employee = suyogRepository.Employees.Add(employee);
            suyogRepository.SaveChanges();
            return employee;
        }

        public void updateEmployee(Employee employee, Image photo, Image aadharimg, Image pancardimg)
        {
            byte[] photo1 = null;
            if (photo != null)
            {
                photo1 = imageToByteArray(photo);
            }
            byte[] aadhar1 = null;
            if (aadharimg != null)
            {
                aadhar1 = imageToByteArray(aadharimg);
            }
            byte[] pancard1 = null;
            if (pancardimg != null)
            {
                pancard1 = imageToByteArray(pancardimg);
            }
            suyogRepository = new SuyogRepository();
            Employee oldEmployee = suyogRepository.Employees.Find(employee.employeeId);
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
            suyogRepository.SaveChanges();

        }

        public void deleteEmployee(int empId)
        {
            suyogRepository = new SuyogRepository();
            var std = suyogRepository.Employees.Find(empId);
            suyogRepository.Employees.Remove(std);
            suyogRepository.SaveChanges();
        }

        public List<Employee> DisplayEmployees()
        {
            suyogRepository = new SuyogRepository();
            return suyogRepository.Employees.ToList();
        }

        public Employee displayEmployeeById(int id)
        {
            suyogRepository = new SuyogRepository();
            return suyogRepository.Employees.Find(id);
        }

        public List<EmployeeDto> displayEmployeeNames()
        {
            suyogRepository = new SuyogRepository();
            return suyogRepository.Employees.Select(x => new EmployeeDto()
            {
                employeeName = x.employeeName
            }).ToList();
        }
    }
}