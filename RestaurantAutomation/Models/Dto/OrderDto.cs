using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RestaurantAutomation.Models.Dto
{
    public class OrderDto
    {
        public int Id { get; set; }
        public int EmployeeId { get; set; }
        public string Product { get; set; }
        public int TableNumber { get; set; }
        public int Quantity { get; set; }
        public string Employee { get; set; }
    }
}
