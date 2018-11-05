using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Shop.Data;
using Shop.Models;

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
        [Route("index2")]
        public async Task<IActionResult> Index()
        {
            List<Order> orders = await _db.Orders
                                    .Include( order => order.Items)
                                    .ThenInclude( orderItems => orderItems.Product)
                                    .ToListAsync();
            List<IndexViewModel> viewModel = orders
                .Select(x => new IndexViewModel(x.Number, x.Items)).ToList();

            return View(viewModel);
        }
    }
}
