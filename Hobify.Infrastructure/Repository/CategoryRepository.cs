using Hobify.Core.Entity;
using Hobify.Core.Interface.Repository;
using Hobify.Infrastructure.Data;
using Microsoft.EntityFrameworkCore;

namespace Hobify.Infrastructure.Repository
{
    public class CategoryRepository : ICategoryRepository
    {
        private readonly ApplicationDbContext _context;

        public CategoryRepository(ApplicationDbContext context)
        {
               _context = context;
        }
        public async Task<Category> CreateAsync(Category category)
        {
            await _context.Categories.AddAsync(category);
            await _context.SaveChangesAsync();
            return category;
        }

       

        public async Task<IEnumerable<Category>> GetAllAsync()
        {
            await _context.Categories.ToListAsync();
            return _context.Categories;

        }

        public async Task<Category> GetByIdAsync(Guid id)
        {
           return await _context.Categories.FindAsync(id);

        }

        public async Task<Category> UpdateAsync(Category category)
        {
            _context.Categories.Update(category);
            await _context.SaveChangesAsync();
            return category;
        }

        public async Task<Category> DeleteAsync(Guid id)
        {
            var category = await _context.Categories.FindAsync(id);
            _context.Categories.Remove(category);
            await _context.SaveChangesAsync();
            return category;
        }
    }
}
