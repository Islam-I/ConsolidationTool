using ConsolidationTool.Core.Dtos;
using ConsolidationTool.Service.Interfaces.ProductManagement;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace ConsolidationTool.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class PropertyController : ControllerBase
    {
        private readonly IPropertyServices _propertyServices;
        public PropertyController(IPropertyServices propertyServices)
        {
            _propertyServices = propertyServices;
        }

        [HttpGet("GetAll")]
        public async Task<IActionResult> GetAll()
        {
            var result = await _propertyServices.GetAllAsync();
            return Ok(result);
        }

        [HttpGet("GetByIdAsync")]
        public async Task<IActionResult> GetByIdAsync(int id)
        {
            return Ok(await _propertyServices.GetByIdAsync(id));
        }

        [HttpPost("AddOneProperty")]
        public async Task<IActionResult> AddOneProperty(PropertyDto input)
        {
            var result = await _propertyServices.AddOneAsync(input);
            return Ok(result);
        }


    }
}
