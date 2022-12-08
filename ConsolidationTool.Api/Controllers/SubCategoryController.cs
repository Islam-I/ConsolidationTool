using ConsolidationTool.Core.Dtos;
using ConsolidationTool.Service.Interfaces.ProductManagement;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace ConsolidationTool.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class SubCategoryController : ControllerBase
    {
        private readonly ISubCategoryServices _subCategoryServices;
        public SubCategoryController(ISubCategoryServices categoryServices)
        {
            _subCategoryServices = categoryServices;
        }

        [HttpGet("GetAll")]
        public async Task<IActionResult> GetAll()
        {
            var result = await _subCategoryServices.GetAllAsync();
            return Ok(result);
        }

        [HttpGet("GetByIdAsync")]
        public async Task<IActionResult> GetByIdAsync(int id)
        {
            return Ok(await _subCategoryServices.GetByIdAsync(id));
        }

        [HttpPost("AddOneCategory")]
        public async Task<IActionResult> AddOneSubCategory(SubCategoryDto input)
        {
            var result = await _subCategoryServices.AddOneAsync(input);
            return Ok(result);
        }
    }
}
