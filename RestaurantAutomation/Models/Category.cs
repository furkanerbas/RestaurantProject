using RestaurantAutomation.Core.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RestaurantAutomation.Models
{
    public class Category : IModel
    {
        public int Id { get; set; }
        public string  CategoryName { get; set; }
    }
}
