using Ecommerce.Models;

namespace Ecommerce.Repositories.Interfaces;

public interface IProductRepository
{
    Task<List<Product>> GetAllProducts();
    Task<Product> GetProductById(int id);
    Task<Product> AddProduct(Product product);
    Task<Product> UpdateProduct(Product product, int id);
    Task<bool> DeleteProduct(int id);
}