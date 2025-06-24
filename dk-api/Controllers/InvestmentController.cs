using dkApi.Interfaces;
using dkApi.Models;
using Microsoft.AspNetCore.Mvc;

namespace dkApi.Controllers
{
    [ApiController]
    [Route("investment")]
    public class InvestmentController : ControllerBase
    {
        public IInvestmentService _investmentService;

        public InvestmentController(IInvestmentService investmentService)
        {
            _investmentService = investmentService;
        }

        [HttpGet("calculate")]
        public Investment CalculateInvestment(int purchasePrice, int multiplier)
        {
            var result = _investmentService.CalculateInvestment(purchasePrice, multiplier);
            return result;
        }
    }
}