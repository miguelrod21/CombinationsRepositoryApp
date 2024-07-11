using Listify.Repositories.LotteryCombinations.Dtos;

namespace Listify.Repositories.LotteryCombinations
{
    public interface ILotteryCombinationsRepository
    {
        List<CombinationDto>? GetAll();
        List<CombinationDto>? GetAllChecked();
        void SaveCombinations(List<CombinationDto> combinations);
        void SaveCombinationsFormattedExcelFile(List<CombinationDto> combinations);
    }
}