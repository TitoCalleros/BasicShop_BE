using BasicShopAPI.Application.CQRS.Queries.Products;
using BasicShopAPI.Domain.Entities;
using BasicShopAPI.Domain.Interfaces;

namespace BasicShopAPI.Application.CQRS.Handlers.Products
{
    public class GetProductByIdHandler
    {
        private readonly IProductRepository _repo;

        public GetProductByIdHandler(IProductRepository repo)
        {
            this._repo = repo;
        }

        public async Task<Product?> Handle(GetProductByIdQuery query)
        {
            return await _repo.GetById(query.id);
        }
    }
}
