﻿using ConsolidationTool.Core.Dtos;
using ConsolidationTool.Service.Interfaces;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace ConsolidationTool.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CustomerController : ControllerBase
    {
        private readonly ICustomerService _customerService;
        public CustomerController(ICustomerService customerService)
        {
            _customerService = customerService;
        }
        [HttpGet("GetAll")]
        public async Task<IActionResult> GetAll()
        {
            var result = await _customerService.GetAll();
            return Ok(result);
        }
        [HttpPost("AddOneCustomer")]
        public async Task<IActionResult> AddOneEmployee(CustomerInputDto input)
        {
            var result = await _customerService.AddOne(input);
            return Ok(result);
        }
    }
}
