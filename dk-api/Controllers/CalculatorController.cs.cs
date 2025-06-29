using dk_api.Interfaces;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;

namespace dk_api.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class CalculatorController : ControllerBase
    {
        private readonly ICalculatorService _calculatorService;

        public CalculatorController(ICalculatorService calculatorService)
        {
            _calculatorService = calculatorService;
        }

        [HttpGet("add")]
        public IActionResult Add(int a, int b) =>
            Ok(_calculatorService.Add(a, b));

        [HttpGet("subtract")]
        public IActionResult Subtract(int a, int b) =>
            Ok(_calculatorService.Subtract(a, b));

        [HttpGet("multiply")]
        public IActionResult Multiply(int a, int b) =>
            Ok(_calculatorService.Multiply(a, b));

        [HttpGet("divide")]
        public IActionResult Divide(int a, int b)
        {
            try
            {
                return Ok(_calculatorService.Divide(a, b));
            }
            catch (DivideByZeroException ex)
            {
                return BadRequest(ex.Message);
            }
        }

    }
}
