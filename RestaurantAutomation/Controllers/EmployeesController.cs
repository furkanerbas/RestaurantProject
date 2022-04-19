using Microsoft.AspNetCore.Mvc;
using RestaurantAutomation.DataAccess.Abstract;
using RestaurantAutomation.DataAccess.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RestaurantAutomation.Controllers
{
    public class EmployeesController : Controller
    {
        private IEmployeeRepository _employeeRepository;

        public EmployeesController()
        {
            _employeeRepository = new EmployeeRepository();
        }

        public IActionResult Index()
        {
            ViewBag.employees = _employeeRepository.GetAll();
            return View();
        }
        public IActionResult Add()
        {
            return View();
        }
    }
}
