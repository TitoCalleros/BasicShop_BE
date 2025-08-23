using BasicShopAPI.Domain.Contracts;
using System.ComponentModel.DataAnnotations;

namespace BasicShopAPI.API.DTOs.Products
{
    public class ProductQueryParams
    {
        [Range(1, int.MaxValue)]
        public int Page { get; init; } = 1;

        [Range(1, 50)]
        public int PageSize { get; init; } = 50;

        public string? Search { get; init; }
                
        public ProductSort? Sort { get; init; }
    }
}
