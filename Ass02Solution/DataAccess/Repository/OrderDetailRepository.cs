using DataAccess.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Repository
{
    public class OrderDetailRepository : IOrderDetailRepository
    {

        public void Create(OrderDetail orderDetail)
        {
            AssSalesContext.Instance.Add(orderDetail);
            AssSalesContext.Instance.SaveChanges();
        }

        public void Delete(int id)
        {
            OrderDetail orderDetail = GetOrderDetail(id);
            AssSalesContext.Instance.Remove(orderDetail);
            AssSalesContext.Instance.SaveChanges();
        }

        public OrderDetail GetOrderDetail(int id)
        {
            return AssSalesContext.Instance.OrderDetails.ToList().FirstOrDefault(c => c.OrderId == id);
        }

        public List<OrderDetail> GetOrderDetails() => AssSalesContext.Instance.OrderDetails.ToList();

        public void Update()
        {
            AssSalesContext.Instance.SaveChanges();
        }
    }
}
