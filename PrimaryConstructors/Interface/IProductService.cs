using PrimaryConstructors.DTOs;
using PrimaryConstructors.Models;

namespace PrimaryConstructors.Interface
{
    public interface IProductService
    {
        Task<List<Product>> GetAllAsync();
        Task<Product?> GetByIdAsync(int id);
        Task<Product> CreateAsync(CreateProductRequest request);
        Task<bool> UpdateAsync(int id, CreateProductRequest request);
        Task<bool> DeleteAsync(int id);
    }
}
