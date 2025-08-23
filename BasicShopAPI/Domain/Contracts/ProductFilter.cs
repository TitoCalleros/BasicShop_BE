namespace BasicShopAPI.Domain.Contracts
{
    public sealed class ProductFilter
    {
        public int Page { get; init; } = 1;
        public int PageSize { get; init; } = 20;

        public string? Search { get; init; }

        // Admite "name:asc", "name:desc", "price:asc", "price:desc", "stock:asc", "stock:desc"
        // Default: "id:asc"
        public string? Sort { get; init; }
    }
}
