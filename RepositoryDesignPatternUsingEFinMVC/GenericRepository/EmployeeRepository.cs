using RepositoryDesignPatternUsingEFinMVC.DAL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace RepositoryDesignPatternUsingEFinMVC.GenericRepository
{
    public class EmployeeRepository : GenericRepository<Employee>, IEmployeeRepository
    {
        public IEnumerable<Employee> GetEmployeesByDepartment(string Dept)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<Employee> GetEmployeesByGender(string Gender)
        {
            return _context.Employees.Where(emp => emp.Gender == Gender).ToList();
        }
    }
}