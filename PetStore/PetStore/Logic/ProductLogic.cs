using PetStore.Data;
using PetStore.Logic;
using PetStore.Validators;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PetStore
{
    public class ProductLogic : IProductLogic
    {
        private readonly IProductRepository _productRepo;
        private readonly IOrderRepository _orderRepo;

        public ProductLogic(IProductRepository productRepository, IOrderRepository orderRepository)
        {
            _productRepo = productRepository;
            _orderRepo = orderRepository;
        }

        public void AddProduct(Product product)
        {
            var validator = new ProductValidator();
            if (validator.Validate(product).IsValid)
            {
                _productRepo.AddProduct(product);
            }
        }

        public List<Product> GetAllProducts()
        {
            return _productRepo.GetAllProducts();
        }

        public Product GetProductById(int id)
        {
            return _productRepo.GetProductById(id);
        }

        public void AddOrder(Order order)
        {
            _orderRepo.AddOrder(order);
        }

        public Order GetOrder(int id)
        {
            return _orderRepo.GetOrder(id);
        }
    }
}
