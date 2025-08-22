using BasicShopAPI.Application.CQRS.Queries.Products;
using BasicShopAPI.Domain.Entities;
using BasicShopAPI.Domain.Interfaces;

namespace BasicShopAPI.Application.CQRS.Handlers.Products
{
    public class GetAllProductsHandler(IProductRepository repo)
    {
        private readonly IProductRepository _repo = repo;

        public async Task<IEnumerable<Product>> Handle(GetAllProductsQuery query)
        {
            return await _repo.GetAll();
        }
    }
}
