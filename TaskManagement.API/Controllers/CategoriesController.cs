using Microsoft.AspNetCore.Mvc;
using TaskManagement.Application.Dto;
using TaskManagement.Application.Interfaces;
using TaskManagement.Domain.Entities;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace TaskManagement.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CategoriesController : ControllerBase
    {
        public readonly ICategoryService _categoryService;
        public CategoriesController(ICategoryService categoryService)
        {
            _categoryService = categoryService;

        }
        // GET: api/<CategoriesController>
        [HttpGet]
        public async Task<IEnumerable<DtoCategories>> Get()
        {
            return await _categoryService.GetAllCategoriesAsync();
        }

        [HttpGet("CategoriaTask")]
        public async Task<IEnumerable<DtoCategoriesTask>> CategoriaTask()
        {
            return await _categoryService.GetAllCategoriesTaskAsync();
        }

        // GET api/<CategoriesController>/5
        [HttpGet("{id}")]
        public async Task<DtoCategories> Get(int id)
        {
            return await _categoryService.GetCategoryByIdAsync(id);
        }

        // POST api/<CategoriesController>
        [HttpPost]
        public void Post([FromBody] string value)
        {
        }

        // PUT api/<CategoriesController>/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] string value)
        {
        }

        // DELETE api/<CategoriesController>/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}
