using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace EmployeeManagement.Controllers
{
    [Route("[controller]/[action]")]
    public class EmployeesController : Controller
    {
        //public IActionResult Index()
        //{
        //    return View();
        //}
        public string List()
        {
            return "List() of EmployeesController";
        }

        public string Details()
        {
            return "Details() of EmployeesController";
        }
    }
}