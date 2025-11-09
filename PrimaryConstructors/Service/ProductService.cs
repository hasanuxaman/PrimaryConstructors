using PrimaryConstructors.DTOs;
using PrimaryConstructors.Interface;
using PrimaryConstructors.Models;

namespace PrimaryConstructors.Service
{
    public class ProductService(ILogger<ProductService> logger)
    : IProductService
    {
        public async Task<List<Product>> GetAllAsync()
        {
            logger.LogInformation("Getting all products");
            return  new  List<Product>() ;
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

        public Task<Product> CreateAsync(CreateProductRequest request)
        {
            throw new NotImplementedException();
        }
    }
}
