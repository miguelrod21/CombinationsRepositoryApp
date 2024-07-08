using Listify.Repositories.LotteryCombinations.Dtos;

namespace Listify.Integration.Lottery
{
    public interface ILotteryService
    {
        List<CombinationDto>? GetAll();
        List<CombinationDto>? GetAllChecked();
    }
}