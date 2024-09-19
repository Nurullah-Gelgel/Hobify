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

        public async Task<SubCategory> GetByNameAsync(string name)
        {
            return await _context.SubCategories.FirstOrDefaultAsync(x => x.name == name);
        }



        public async Task<Category> GetCategoryBySubCategoryNameAsync(string subCategoryName)
        {
            // SubCategory'yi adıyla bul
            var subCategory = await _context.SubCategories
                                            .Include(sc => sc.category) // Category'yi dahil et
                                            .FirstOrDefaultAsync(sc => sc.name == subCategoryName);

            // Eğer SubCategory bulunursa, ilişkili Category'yi döndür
            return subCategory?.category;
        }
    }
}
