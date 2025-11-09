using Microsoft.EntityFrameworkCore;
using PrimaryConstructors.DTOs;
using PrimaryConstructors.Interface;
using PrimaryConstructors.Models;

namespace PrimaryConstructors.Service
{
    public class ProductService(ILogger<ProductService> logger, ApplicationDbContext context)
    : IProductService
    {

       
        public async Task<List<Product>> GetAllAsync()
        {
            logger.LogInformation("Getting all products");
            var products = await context.Products.ToListAsync();

            return products;
        }

        public Task<bool> DeleteAsync(int id)
        {
            throw new NotImplementedException();
        }

       

        public Task<Product?> GetByIdAsync(int id)
        {
            throw new NotImplementedException();
        }

        public Task<bool> UpdateAsync(int id, CreateProductRequest request)
        {
            throw new NotImplementedException();
        }

        public async Task<Product> CreateAsync(CreateProductRequest request)
        {
            var product = new Product(
                0, 
                request.Name,
                request.Description,
                request.Price
            );

            context.Products.Add(product);
            await context.SaveChangesAsync();

            return product;
        }
    }
}
