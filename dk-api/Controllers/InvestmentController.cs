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

        [HttpGet("calculate-investment")]
        public Investment CalculateInvestment(int purchasePrice, int multiplier)
        {
            var result = _investmentService.CalculateInvestment(purchasePrice, multiplier);
            return result;
        }

        [HttpGet("calculate-byleco")]
        public Abcd CalculateByleco(int cochcesz)
        {
            var result = _investmentService.CalculateAbcd(cochcesz);
            return result;
        }

    }
}