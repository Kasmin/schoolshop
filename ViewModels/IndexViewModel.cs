using System.Collections.Generic;
using System.Linq;

namespace Shop.Models
{
    public class IndexViewModel
    {
        public string OrderNumber { get; set; }
        public List<OrderItem> OrderItems { get; set; }
        public decimal OrderSum { get; set; }

        public IndexViewModel(string orderNumber, List<OrderItem> orderItems)
        {
            OrderSum = orderItems.Select(x => x.Product.Price * x.Count).Sum();
            OrderItems = orderItems;
            OrderNumber = orderNumber;
        }
    }
}
