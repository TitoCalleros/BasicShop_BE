using BasicShopAPI.Application.CQRS.Queries.Products;
using BasicShopAPI.Domain.Contracts;
using BasicShopAPI.Domain.Entities;
using BasicShopAPI.Domain.Interfaces;

namespace BasicShopAPI.Application.CQRS.Handlers.Products
{
    public class GetFilteredProductsHandler(IProductRepository repo)
    {
        private readonly IProductRepository _repo = repo;

        public async Task<QueryPagedResult<Product>> Handle(GetFilteredProductsQuery query)
        {
            var filter = new ProductFilter
            {
                Page = query.Page,
                PageSize = query.PageSize,
                Search = query.Search,
                Sort = query.Sort,
            };

            var (items, total) = await _repo.GetPaged(filter);

            return new QueryPagedResult<Product>
            {
                Items = items,
                Page = filter.Page,
                PageSize = filter.PageSize,
                TotalCount = total
            };
        }
    }
}
