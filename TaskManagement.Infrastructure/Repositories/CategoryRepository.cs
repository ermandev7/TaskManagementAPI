using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TaskManagement.Application.Interfaces;
using TaskManagement.Domain.Entities;
using TaskManagement.Domain.Interfaces;
using TaskManagement.Infrastructure.Persistence.Context;

namespace TaskManagement.Infrastructure.Repositories
{
    public class CategoryRepository : ICategoryRepository
    {
        private readonly ApplicationDbContext _context;

        public CategoryRepository(ApplicationDbContext context)
        {
            _context = context;
        }

        public async Task<IEnumerable<Categories>> GetAllAsync()
        {
            var result = _context.Categories.Include(x => x.Tasks).ToList();
            return result;
        }

        public async Task<Categories> GetByIdAsync(int id)
        {

            var categorie = await _context.Categories.FindAsync(id);
            if (categorie == null) { 
                categorie = new Categories();
            }
            return categorie;
        }

        public async Task<Categories> AddAsync(Categories categories)
        {
            _context.Categories.Add(categories);
            await _context.SaveChangesAsync();
            return categories;
        }

        public async Task UpdateAsync(Categories categories)
        {
            _context.Categories.Update(categories);
            await _context.SaveChangesAsync();
        }

        public async Task DeleteAsync(Categories categories)
        {
            _context.Categories.Remove(categories);
            await _context.SaveChangesAsync();
        }
        public Task<Categories> GetByStrinAsync(string name)
        {
            throw new NotImplementedException();
        }
        public Task<Categories> GetByNameAsync(string name)
        {
            throw new NotImplementedException();
        }
    }
}
