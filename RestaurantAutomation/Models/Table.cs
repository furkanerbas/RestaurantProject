using RestaurantAutomation.Core.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RestaurantAutomation.Models
{
    public class Table : IModel
    {
        public int Id { get; set; }
        public int SectionId { get; set; }
        public int TableId { get; set; }
        public bool IsFulled { get; set; }

    }
}
