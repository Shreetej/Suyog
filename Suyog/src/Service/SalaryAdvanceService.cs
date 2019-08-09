using Suyog.src.Dto;
using Suyog.src.Model;
using Suyog.src.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Suyog.src.Service
{
    public class SalaryAdvanceService
    {
        private SalaryAdvance salaryAdvance;
        private SuyogRepository repository;

        public SalaryAdvanceService()
        {
        }
        public void addSalary(int employeeId, string employeeName, string mon, int salary, DateTime date )
        {
            repository = new SuyogRepository();
            salaryAdvance = new SalaryAdvance(employeeId,employeeName,mon,salary,0,date);
            repository.SalaryAdvances.Add(salaryAdvance);
            repository.SaveChanges();
        }

        public void addAdvance(int employeeId, string employeeName, string mon, int advance, DateTime date)
        {
            repository = new SuyogRepository();
            salaryAdvance = new SalaryAdvance(employeeId, employeeName, mon, 0, advance, date);
            repository.SalaryAdvances.Add(salaryAdvance);
            repository.SaveChanges();
        }

        public void deleteSalaryAdvance(int id)
        {
            repository = new SuyogRepository();
            salaryAdvance = repository.SalaryAdvances.Find(id);
            repository.SalaryAdvances.Remove(salaryAdvance);
        }

        public List<SalaryDto> GetSalary(Employee emp)
        {
            repository = new SuyogRepository();
            List<SalaryDto> list = new List<SalaryDto>();
            list = repository.SalaryAdvances
                .Where(x => x.advance == 0 && x.employeeId == emp.employeeId)
                .Select(x => new SalaryDto {
                    id = x.id,
                    employeeId = x.employeeId,
                    employeeName = x.employeeName,
                    month = x.month,
                    salary = x.salary,
                    dateOfSalary = x.dateOfSalary
                }).ToList();
            return list;
        }

        public List<AdvanceDto> GetAdvance(Employee emp)
        {
            repository = new SuyogRepository();
            List<AdvanceDto> list = new List<AdvanceDto>();
            list = repository.SalaryAdvances
                .Where(x => x.salary == 0 && x.employeeId == emp.employeeId)
                .Select(x => new AdvanceDto
                {
                    id = x.id,
                    employeeId = x.employeeId,
                    employeeName = x.employeeName,
                    month = x.month,
                    advance = x.advance,
                    dateOfSalary = x.dateOfSalary
                }).ToList();
            return list;
        }
    }
}
