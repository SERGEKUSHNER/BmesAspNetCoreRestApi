using BmesAspNetCoreRestApi.Database;
using BmesAspNetCoreRestApi.Models.Products;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BmesAspNetCoreRestApi.Repositories.Implementation
{
    public class ProductRepository : IProductRepository
    {
        private BmesDbContext _context;

        public ProductRepository(BmesDbContext context)
        {
            _context = context;
        }

        public Product FindProductById(long id)
        {
            var product = _context.Products.Find(id);
            return product;
        }

        public IEnumerable<Product> GetAllProducts()
        {
            var products = _context.Products
                .Include(p => p.Category)
                .Include(p => p.Brand);
            return products;
        }

        public void SaveProduct(Product product)
        {
            _context.Products.Add(product);
            _context.SaveChanges();
        }

        public void UpdateProduct(Product product)
        {
            _context.Products.Update(product);
            _context.SaveChanges();
        }

        public void DeleteProduct(Product product)
        {
            _context.Products.Remove(product);
            _context.SaveChanges();
        }
    }
}
