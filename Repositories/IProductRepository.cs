using Latiendita.Models;

namespace Latiendita.Repositories
{
    public interface IProductRepository
    {
        Task<IEnumerable<Product>> GetProductsAsync();
        Task<Product?> GetProductByIdAsync(int id);
        Task AddProductAsync(Product product);
        Task UpdateProductAsync(int id, Product product);
        Task DeleteProductAsync(int id);
        Task<IEnumerable<Product>> SearchAsync(string query);
        Task<Product> GetByIdAsync(int productId);
        Task UpdateProductStockAsync(Product product);
    }
}
