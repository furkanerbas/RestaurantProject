using RestaurantAutomation.Core.DataAccess;
using RestaurantAutomation.DataAccess.Abstract;
using RestaurantAutomation.Models;
using RestaurantAutomation.Models.Dto;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RestaurantAutomation.DataAccess.Concrete
{
    public class OrderRepository : BaseRepository<Order>, IOrderRepository
    {
        public List<OrderDto> GetOrderDtos()
        {
            using (var context = new SimpleDbContext())
            {
                var result = from o in context.Orders
                             join p in context.Products on o.ProductId equals p.Id
                             join t in context.Tables on o.TableId equals t.TableId
                             join e in context.Employees on o.EmployeeId equals e.Id
                             select new OrderDto()
                             {
                                 Id = o.Id,
                                 EmployeeId = o.EmployeeId,
                                 Product = p.ProductName,
                                 TableNumber = t.TableId,
                                 Quantity = o.Quantity,
                                 Employee = e.Name
                             };
                return result.ToList();
            }
        }
        public List<OrderDto> GetOrderDtosById(int id)
        {
            using (var context = new SimpleDbContext())
            {
                var result = from o in context.Orders where o.TableId == id
                             join p in context.Products on o.ProductId equals p.Id
                             join t in context.Tables on o.TableId equals t.Id
                             join e in context.Employees on o.EmployeeId equals e.Id
                             select new OrderDto()
                             {
                                 Id = o.Id,
                                 Product = p.ProductName,
                                 TableNumber = t.TableId,
                                 Quantity = o.Quantity,
                                 Employee = e.Name
                             };
                return result.ToList();
            }
        }
    }
}
