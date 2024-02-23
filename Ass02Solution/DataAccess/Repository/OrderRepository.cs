using AutoMapper.Execution;
using DataAccess.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Repository
{
    public class OrderRepository : IOrderRepository
    {

        public void Create(Order order)
        {
            AssSalesContext.Instance.Add(order);
            AssSalesContext.Instance.SaveChanges();
        }

        public void Delete(int id)
        {
            Order order = GetOrder(id);
            AssSalesContext.Instance.Remove(order);
            AssSalesContext.Instance.SaveChanges();
        }

        public Order GetOrder(int id)
        {
            return AssSalesContext.Instance.Orders.ToList().FirstOrDefault(c => c.OrderId == id);
        }

        public List<Order> GetOrders() => AssSalesContext.Instance.Orders.ToList();

        public void Update()
        {
            AssSalesContext.Instance.SaveChanges();
        }
    }
}
