using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TaskManagement.Application.Dto;
using TaskManagement.Domain.Entities;

namespace TaskManagement.Application.Interfaces
{
    public interface  ICategoryService
    {
        Task<IEnumerable<DtoCategories>> GetAllCategoriesAsync();
        Task<IEnumerable<DtoCategoriesTask>> GetAllCategoriesTaskAsync();
        Task<DtoCategories> GetCategoryByIdAsync(int id);
        Task<Categories> GetByNameAsync(string name);
        Task<Categories> CreateCategoryAsync(Categories category);
        Task UpdateCategoryAsync(Categories category);
        Task DeleteCategoryAsync(int id);
    }
}
