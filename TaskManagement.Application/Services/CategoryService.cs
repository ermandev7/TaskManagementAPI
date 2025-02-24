using AutoMapper;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TaskManagement.Application.Dto;
using TaskManagement.Application.Interfaces;
using TaskManagement.Domain.Entities;
using TaskManagement.Domain.Interfaces;

namespace TaskManagement.Application.Services
{
    public class CategoryService : ICategoryService
    {
        private readonly ICategoryRepository _categoryRepository;
        private readonly IMapper _mapper;

        public CategoryService(ICategoryRepository categoryRepository, IMapper mapper)
        {
            _categoryRepository = categoryRepository;
            _mapper = mapper;
        }

        public async Task<IEnumerable<DtoCategories>> GetAllCategoriesAsync()
        {
            var result = await _categoryRepository.GetAllAsync();
            return _mapper.Map<IEnumerable<DtoCategories>>(result);
        }

        public async Task<IEnumerable<DtoCategoriesTask>> GetAllCategoriesTaskAsync()
        {
            var result = await _categoryRepository.GetAllAsync();
            return _mapper.Map<IEnumerable<DtoCategoriesTask>>(result);
        }

        public async Task<DtoCategories> GetCategoryByIdAsync(int id)
        {
            var result = await _categoryRepository.GetByIdAsync(id);
            return _mapper.Map<DtoCategories>(result);
        }

        public async Task<Categories> CreateCategoryAsync(Categories categories)
        {
            return await _categoryRepository.AddAsync(categories);
        }

        public async Task UpdateCategoryAsync(Categories categories)
        {
            await _categoryRepository.UpdateAsync(categories);
        }

        public async Task DeleteCategoryAsync(int id)
        {
            var category = await _categoryRepository.GetByIdAsync(id);
            if (category != null)
            {
                await _categoryRepository.DeleteAsync(category);
            }
        }

        public Task<Categories> GetByNameAsync(string name)
        {
            throw new NotImplementedException();
        }
    }
}
