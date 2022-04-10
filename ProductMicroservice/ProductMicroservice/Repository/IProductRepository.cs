using ProductMicroservice.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace ProductMicroservice.Repository
{
    public interface IProductRepository
    {
        IEnumerable<ProductMicroservice.Models.Product> GetProducts();
        Product GetProductById(int productId);
        void InsertProduct(Product product);
        void DeleteProduct(int productId);
        void UpdateProduct(Product product);
        void Save();
    }
}
