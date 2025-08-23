using BasicShopAPI.Domain.Contracts;
using BasicShopAPI.Domain.Entities;

namespace BasicShopAPI.Domain.Interfaces
{
    public interface IProductRepository
    {

        Task<Product?> GetById(Guid id);
        Task<List<Product>> GetAll();
        Task Add(Product product);
        Task Update(Product product);
        Task Delete(Guid id);
        Task<(IReadOnlyList<Product> Items, int TotalCount)> GetPaged(ProductFilter filter);
    }
}
