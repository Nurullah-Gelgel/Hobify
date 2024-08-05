using Hobify.Core.Entity;
using Hobify.Core.Interface.Repository;
using Hobify.Infrastructure.Data;
using Microsoft.EntityFrameworkCore;

namespace Hobify.Infrastructure.Repository
{
    public class SubCategoryRepository : ISubCategoryRepository
    {
        private readonly ApplicationDbContext _context;

        public SubCategoryRepository(ApplicationDbContext context)
        {
            _context = context;
        }
        public async Task<SubCategory> CreateAsync(SubCategory subCategory)
        {
            await _context.SubCategories.AddAsync(subCategory);
            await _context.SaveChangesAsync();  
            return subCategory;
        }

        public async Task<IEnumerable<SubCategory>> GetAllAsync()
        {
            return await _context.SubCategories.ToListAsync();
        }

        public async Task<SubCategory> GetByIdAsync(Guid id)
        {
           return await _context.SubCategories.FindAsync(id);
            
        }

        public async Task<SubCategory> UpdateAsync(SubCategory subCategory)
        {
            _context.SubCategories.Update(subCategory);
            await _context.SaveChangesAsync();
            return subCategory;
        }

        public async Task<SubCategory> DeleteAsync(Guid id)
        {
            var subCategory = _context.SubCategories.Find(id);
            if (subCategory == null)
            {
                return null;
            }
            _context.SubCategories.Remove(subCategory);
            await _context.SaveChangesAsync();
            return subCategory;
        }

    }
}
