using BasicShopAPI.Domain.Entities;
using Microsoft.EntityFrameworkCore;

namespace BasicShopAPI.Infrastructure.Persistence
{
    public class ApplicationDbContext: DbContext
    {

        #region Properties

        public DbSet<Product> Products { get; set; }

        #endregion

        #region Constructor

        public ApplicationDbContext(DbContextOptions options): base(options)
        {            
        }

        #endregion
    }
}
