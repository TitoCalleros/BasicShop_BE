namespace BasicShopAPI.API.DTOs.Common
{
    public record PagedResultDTO<T>(
        IReadOnlyList<T> Items,
        int Page,
        int PageSize,
        int TotalCount,
        int TotalPages
    );
}
