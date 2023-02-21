using Catalog.API.Data;
using Catalog.API.Entities;
using Microsoft.EntityFrameworkCore;

namespace Catalog.API.Repositories
{
    public class ProductRepository : IProductRepository
    {
        private readonly CatalogDbContext _context;

        public ProductRepository(CatalogDbContext context)
        {
            _context = context ?? throw new ArgumentNullException(nameof(context));
        }

        public async Task<IEnumerable<Product>> GetProducts()
        {
            return await _context
                            .Products
                          .ToListAsync();
        }
        public async Task<Product> GetProduct(string id)
        {
            return await _context
                           .Products
                           .FirstOrDefaultAsync(x => x.Id == Convert.ToInt32(id));
        }

        public async Task<IEnumerable<Product>> GetProductByName(string name)
        {
            return await _context
                            .Products
                            .Where(x => x.Name == name)
                            .ToListAsync();
        }

        public async Task<IEnumerable<Product>> GetProductByCategory(string categoryName)
        {

            return await _context
                            .Products
                            .Where(x => x.Category == categoryName)
                            .ToListAsync();
        }

        public async Task CreateProduct(Product product)
        {
            await _context.Products.AddAsync(product);
        }

        public async Task<bool> UpdateProduct(Product product)
        {
            var updateResult = _context.Products.Attach(product);
            updateResult.State = EntityState.Modified;
            await _context.SaveChangesAsync();
            return true;
        }

        public async Task<bool> DeleteProduct(string id)
        {
            Product Product = await _context.Products.FindAsync(id);
            if (Product != null)
            {
                _context.Products.Remove(Product);
                await _context.SaveChangesAsync();
                return true;
            }
            return false;
        }
    }
}
