using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Http;

namespace Shop.Models
{
    public class IndexViewModel
    {
        // public int OrderNumber { get; set; }
        public List<Order> OrderList { get; set; }
        //public List<OrderItem> OrderItems { get; set; }
        public decimal OrderSum { get; set; }
    }
}
