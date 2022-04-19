using Microsoft.AspNetCore.Mvc;
using RestaurantAutomation.DataAccess.Abstract;
using RestaurantAutomation.DataAccess.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RestaurantAutomation.Controllers
{
    public class TableController : Controller
    {
        private ITableRepository _tableRepository;

        public TableController()
        {
            _tableRepository = new TableRepository();
        }

        public IActionResult Index()
        {
            ViewBag.tables = _tableRepository.GetAll();
            return View();
        }
    }
}
