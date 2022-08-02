using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PetStore.Data
{
    public class OrderRepository : IOrderRepository
    {
        private readonly ProductContext _dbContext;

        public OrderRepository()
        {
            _dbContext = new ProductContext();
        }

        public Order GetOrder(int id)
        {
            return _dbContext.Orders.Include(x=>x.Products).SingleOrDefault(x=>x.OrderId == id);
        }

        public void AddOrder(Order order)
        {
            _dbContext.Orders.Add(order);
            _dbContext.SaveChanges();
        }
    }
}
