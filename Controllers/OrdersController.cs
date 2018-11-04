using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Shop.Data;
using Shop.Models;
using Shop.ViewModels;

// For more information on enabling MVC for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace Shop.Controllers
{
    public class OrdersController : Controller
    {
        private readonly ShopContext _db;

        public OrdersController(ShopContext db)
        {
            _db = db;
        }
        // GET: /<controller>/
        public IActionResult Index()
        {
            List<Order> orders = _db.Orders
                                    .Include( order => order.Items)
                                    .ThenInclude( orderItems => orderItems.Product)
                                    .ToList();

           // var orderSum = 0;
          //  var viewModel = new IndexViewModel { OrderList = orders, OrderSum = orderSum };

            return View(orders);
        }
    }
}
