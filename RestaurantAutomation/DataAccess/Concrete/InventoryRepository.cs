using RestaurantAutomation.Core.DataAccess;
using RestaurantAutomation.DataAccess.Abstract;
using RestaurantAutomation.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RestaurantAutomation.DataAccess.Concrete
{
    public class InventoryRepository : BaseRepository<Inventory>, IInvertoryRepository
    {
       
    }
}
