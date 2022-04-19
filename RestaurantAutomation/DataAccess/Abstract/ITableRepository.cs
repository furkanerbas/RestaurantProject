using RestaurantAutomation.Core.DataAccess;
using RestaurantAutomation.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RestaurantAutomation.DataAccess.Abstract
{
    public interface ITableRepository : IBaseRepository<Table>
    {
    }
}
