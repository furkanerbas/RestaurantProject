using Microsoft.AspNetCore.Mvc;
using RestaurantAutomation.DataAccess.Abstract;
using RestaurantAutomation.DataAccess.Concrete;
using RestaurantAutomation.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RestaurantAutomation.Controllers
{
    public class OrderController : Controller
    {
        private IOrderRepository _orderRepository;
        private IProductRepository _productRepository;
        private ITableRepository _tableRepository;
        private IEmployeeRepository _employeeRepository;

        public OrderController()
        {
            _orderRepository = new OrderRepository();
            _productRepository = new ProductRepository();
            _tableRepository = new TableRepository();
            _employeeRepository = new EmployeeRepository();
        }

        public IActionResult Index()
        {
            ViewBag.orders = _orderRepository.GetOrderDtos();
            return View();
        }
        public IActionResult TableOrders(int id)
        {
            ViewBag.orders = _orderRepository.GetOrderDtosById(id);
            return View();
        }

        public IActionResult Add(int id)
        {
            ViewBag.products = _productRepository.GetAll();
            ViewBag.tables = _tableRepository.GetAll();
            ViewBag.tableNumber = id;
            ViewBag.employees = _employeeRepository.GetAll();
            return View();
        }
        public IActionResult Save(Order order)
        {
            this._orderRepository.Add(order);
            return RedirectToAction("Index");
        }
    }
}
