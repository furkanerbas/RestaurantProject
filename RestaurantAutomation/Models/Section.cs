using RestaurantAutomation.Core.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RestaurantAutomation.Models
{
    public class Section : IModel
    {
        public int Id { get; set; }
        public string  SectionName { get; set; }
    }
}
