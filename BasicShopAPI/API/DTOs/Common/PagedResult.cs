namespace BasicShopAPI.API.DTOs.Common
{
    public record PagedResult<T>(
        IReadOnlyList<T> Items,
        int Page,
        int PageSize,
        int TotalCount,
        int TotalPages
    )
    { 
        public static PagedResult<T> Create(IReadOnlyList<T> items, int page, int PageSize, int totalCount)
        {
            var totalPages = (int)Math.Ceiling(totalCount / (double)PageSize);
            return new PagedResult<T>(items, page, PageSize, totalCount, Math.Max(totalPages, 1));
        }
    }
}
