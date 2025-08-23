using System.Text.Json.Serialization;

namespace BasicShopAPI.Domain.Contracts
{
    public sealed class ProductFilter
    {
        public int Page { get; init; } = 1;
        public int PageSize { get; init; } = 20;

        public string? Search { get; init; }
                
        public ProductSort? Sort { get; init; }
    }
}
