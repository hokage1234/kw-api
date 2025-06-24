using dkApi.Interfaces;
using dkApi.Models;
using System;

namespace dkApi.Services
{
    public class InvestmentService : IInvestmentService
    {

        public InvestmentService()
        {
        }

        public Investment CalculateInvestment(int purchasePrice, int growthMultiple)
        {

            var investment = new Investment()
            {
                PurchasePrice = purchasePrice,
                SellingPrice = purchasePrice * growthMultiple
            };

            return investment;
        }
    }
}