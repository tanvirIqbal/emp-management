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
                new Employee(){Id=1,Name="Mary",Deparement="HR",Email="mary@email.com"},
                new Employee(){Id=1,Name="John",Deparement="IT",Email="john@email.com"},
                new Employee(){Id=1,Name="Sam",Deparement="IT",Email="sam@email.com"}
            };
        }
        public Employee GetEmployee(int Id)
        {
            return _employees.FirstOrDefault(x => x.Id == Id);
        }
    }
}
