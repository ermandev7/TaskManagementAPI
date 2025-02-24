using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TaskManagement.Domain.Entities;

namespace TaskManagement.Domain.Interfaces
{
    public interface ICategoryRepository
    {
        Task<IEnumerable<Categories>> GetAllAsync();
        Task<Categories> GetByIdAsync(int id);
        Task<Categories> GetByNameAsync(string name);
        Task<Categories> AddAsync(Categories categories);
        Task UpdateAsync(Categories categories);
        Task DeleteAsync(Categories categories);
    }
}
