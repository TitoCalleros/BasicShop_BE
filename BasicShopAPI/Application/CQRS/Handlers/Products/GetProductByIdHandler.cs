using BasicShopAPI.Application.CQRS.Queries.Products;
using BasicShopAPI.Domain.Entities;
using BasicShopAPI.Domain.Interfaces;

namespace BasicShopAPI.Application.CQRS.Handlers.Products
{
    public class GetProductByIdHandler(IProductRepository repo)
    {
        private readonly IProductRepository _repo = repo;

        public async Task<Product?> Handle(GetProductByIdQuery query)
        {
            return await _repo.GetById(query.Id);
        }
    }
}
