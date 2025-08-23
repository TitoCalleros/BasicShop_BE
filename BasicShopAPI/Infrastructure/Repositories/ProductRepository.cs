using BasicShopAPI.Domain.Contracts;
using BasicShopAPI.Domain.Entities;
using BasicShopAPI.Domain.Interfaces;
using BasicShopAPI.Infrastructure.Persistence;
using Microsoft.EntityFrameworkCore;

namespace BasicShopAPI.Infrastructure.Repositories
{
    public class ProductRepository : IProductRepository
    {
        private readonly ApplicationDbContext _context;

        #region Constructor

        public ProductRepository(ApplicationDbContext context)
        {
            this._context = context;
        }

        #endregion

        public async Task Add(Product product)
        {
            _context.Products.Add(product);
            await _context.SaveChangesAsync();
        }

        public async Task Delete(Guid id)
        {
            await _context.Products.Where(x => x.Id == id).ExecuteDeleteAsync();
        }

        public async Task<List<Product>> GetAll()
        {
            return await _context.Products.AsNoTracking().ToListAsync();
        }

        public async Task<Product?> GetById(Guid id)
        {
            return await _context.Products.FirstOrDefaultAsync(x => x.Id == id);
        }

        public async Task Update(Product product)
        {
            _context.Update<Product>(product);
            await _context.SaveChangesAsync();
        }

        public async Task<(IReadOnlyList<Product> Items, int TotalCount)> GetPaged(ProductFilter filter)
        {
            var page = Math.Max(1, filter.Page);
            var size = Math.Clamp(filter.PageSize, 1, 200);

            IQueryable<Product> q = _context.Products.AsNoTracking();

            // Search (inside Name and Description)
            if (!string.IsNullOrWhiteSpace(filter.Search))
            {
                var s = filter.Search.Trim().ToLower();
                q = q.Where(p =>
                    EF.Functions.Like(p.Name.ToLower(), $"%{s}%") ||
                    EF.Functions.Like((p.Description ?? "").ToLower(), $"%{s}%"));
            }

            // Sort
            q = (filter.Sort?.ToLower()) switch
            {
                "name:asc" => q.OrderBy(p => p.Name),
                "name:desc" => q.OrderByDescending(p => p.Name),
                "price:asc" => q.OrderBy(p => p.Price),
                "price:desc" => q.OrderByDescending(p => p.Price),
                "stock:asc" => q.OrderBy(p => p.Stock),
                "stock:desc" => q.OrderByDescending(p => p.Stock),
                _ => q.OrderBy(p => p.Id) 
            };

            var total = await q.CountAsync();

            var items = await q.Skip((page - 1) * size)
                               .Take(size)
                               .ToListAsync();

            return (items, total);
        }
    }
}
