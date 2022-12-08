using ConsolidationTool.Core.Dtos;
using ConsolidationTool.Repository.UnitOfWork;
using ConsolidationTool.Service.Interfaces;
using ConsolidationTool.Service.Interfaces.ProductManagement;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace ConsolidationTool.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CategoryController : ControllerBase
    {
        private readonly ICategoryServices _categoryServices;
        public CategoryController(ICategoryServices categoryServices)
        {
            _categoryServices = categoryServices;
        }

        [HttpGet("GetAll")]
        public async Task<IActionResult> GetAll()
        {
            var result = await _categoryServices.GetAllAsync();
            return Ok(result);
        }

        [HttpGet("GetByIdAsync")]
        public async Task<IActionResult> GetByIdAsync(int id)
        {
            return Ok(await _categoryServices.GetByIdAsync(id));
        }

        [HttpPost("AddOneCategory")]
        public async Task<IActionResult> AddOneCategory(CategoryDto input)
        {
            var result = await _categoryServices.AddOneAsync(input);
            return Ok(result);
        }
    }
}
