using System;
namespace Shop.ViewModels
{
    public class OrderItemViewModel
    {
        public string ProductName { get; set; }
        public decimal ProductPrice { get; set; }
        public int ProductCount { get; set; }
        // public decimal ProductSum { get; set; }
    }
}
