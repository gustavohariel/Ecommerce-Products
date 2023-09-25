using Ecommerce.Data;
using Ecommerce.Models;
using Ecommerce.Repositories.Interfaces;
using Microsoft.EntityFrameworkCore;

namespace Ecommerce.Repositories;

public class ProductRepository : IProductRepository
{
    private readonly EcommerceDbContext _ecommerceDbContext;

    public ProductRepository(EcommerceDbContext ecommerceDbContext)
    {
        _ecommerceDbContext = ecommerceDbContext;
    }
    
    public async Task<List<Product>> GetAllProducts()
    {
        return await _ecommerceDbContext.Products.ToListAsync();
    }

    public async Task<Product> GetProductById(int id)
    {
        return await _ecommerceDbContext.Products.FirstOrDefaultAsync(x => x.Id == id);
    }

    public async Task<Product> AddProduct(Product product)
    {
        await _ecommerceDbContext.Products.AddAsync(product);
        await _ecommerceDbContext.SaveChangesAsync();

        return product;
    }

    public async Task<Product> UpdateProduct(Product product, int id)
    {
        Product findProductById = await GetProductById(id);

        if (findProductById == null)
            throw new Exception("Product not found");

        _ecommerceDbContext.Entry(findProductById).CurrentValues.SetValues(product);

        _ecommerceDbContext.Products.Update(findProductById);
        await _ecommerceDbContext.SaveChangesAsync();


        return findProductById;
    }

    public async Task<bool> DeleteProduct(int id)
    {
        Product findProductById = await GetProductById(id);

        if (findProductById == null)
            throw new Exception("Product not found");

        _ecommerceDbContext.Products.Remove(findProductById);
        await _ecommerceDbContext.SaveChangesAsync();
        return true;
    }
}