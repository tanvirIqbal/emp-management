using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EmployeeManagement.Models
{
    public class EmployeeRepository : IEmployeeRepository
    {
        List<Employee> _employees;
        public EmployeeRepository()
        {
            _employees = new List<Employee>()
            {
                new Employee(){Id=1,Name="Mary",Department= Dept.HR,Email="mary@email.com"},
                new Employee(){Id=2,Name="John",Department= Dept.IT,Email="john@email.com"},
                new Employee(){Id=3,Name="Sam",Department= Dept.Payroll,Email="sam@email.com"}
            };
        }
        public Employee Add(Employee employee)
        {
            employee.Id = _employees.Max(e => e.Id) + 1;
            _employees.Add(employee);
            return employee;
        }
        public Employee GetEmployee(int Id)
        {
            return _employees.FirstOrDefault(x => x.Id == Id);
        }

        public IEnumerable<Employee> GetEmployees()
        {
            return _employees;
        }
    }
}
