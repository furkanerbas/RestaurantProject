using RestaurantAutomation.Core.DataAccess;
using RestaurantAutomation.Models;
using RestaurantAutomation.Models.Dto;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RestaurantAutomation.DataAccess.Abstract
{
    public interface IOrderRepository:IBaseRepository<Order>
    {
        List<OrderDto> GetOrderDtos();
        List<OrderDto> GetOrderDtosById(int id);

    }
}
