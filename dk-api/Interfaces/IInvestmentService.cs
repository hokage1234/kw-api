using dkApi.Models;

namespace dkApi.Interfaces
{
    public interface IInvestmentService
    {
        Investment CalculateInvestment(int purchasePrice, int growthMultiple);
        Abcd CalculateAbcd(int cochcesz);
    }
}
