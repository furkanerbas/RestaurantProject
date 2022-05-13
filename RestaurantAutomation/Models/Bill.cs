using RestaurantAutomation.Core.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RestaurantAutomation.Models
{
    public class Bill : IModel
    {
        public int Id { get; set; }
        public int OrderId { get; set; }
        public decimal SubTotal { get; set; }
        public decimal Discount { get; set; }
        public decimal Total { get; set; }
        public DateTime Date { get; set; }
    }
}
