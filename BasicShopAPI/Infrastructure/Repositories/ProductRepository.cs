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
    }
}
