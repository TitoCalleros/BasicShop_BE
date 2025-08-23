using BasicShopAPI.Domain.Contracts;

namespace BasicShopAPI.Application.CQRS.Queries.Products
{
    public record GetFilteredProductsQuery(int Page = 1, int PageSize = 10, string? Search = null, ProductSort? Sort = ProductSort.NameAsc, string? Gender = null);
}
