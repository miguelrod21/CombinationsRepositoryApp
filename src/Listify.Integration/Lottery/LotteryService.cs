using Listify.Repositories.LotteryCombinations;
using Listify.Repositories.LotteryCombinations.Dtos;
using System.Text.Json;

namespace Listify.Integration.Lottery
{
    public class LotteryService : ILotteryService
    {
        private readonly ILotteryCombinationsRepository _repository;

        public LotteryService(ILotteryCombinationsRepository repository)
        {
            _repository = repository;
        }

        public List<CombinationDto> GetAll()
        {
            string path = "../repo/combinations.txt";
            if (File.Exists(path))
            {
                string data = File.ReadAllText(path);
                var deserialized = JsonSerializer.Deserialize<List<CombinationDto>>(data);
                return deserialized.ToList();
            }
            else
            {
                var combinations = _repository.GetAll();
                //SaveCombinationsFormattedFile(combinations, path);
                SaveCombinationsFile(combinations, path);
                return combinations;
            }
        }

        private void SaveCombinationsFile(List<CombinationDto> combinations, string path)
        {
            var data = JsonSerializer.Serialize(combinations);
            File.WriteAllText(path, data);
        }

        private void SaveCombinationsFormattedFile(List<CombinationDto> combinations, string path)
        {
            using (StreamWriter writer = new StreamWriter(path))
            {
                for (int i = 0; i < combinations.Count; i++)
                {
                    CombinationDto combination = combinations[i];
                    string line = $"Combinacion {i + 1}: {combination.N1} {combination.N2} {combination.N3} {combination.N4} {combination.N5} {combination.N6}";
                    writer.WriteLine(line);
                }
            }
        }

        private void SaveCombinationsFormattedExcelFile(List<CombinationDto> combinations, string path)
        {
            using (StreamWriter writer = new StreamWriter(path))
            {
                for (int i = 0; i < combinations.Count; i++)
                {
                    CombinationDto combination = combinations[i];
                    string line = $"Combinacion {i + 1};{combination.N1};{combination.N2};{combination.N3};{combination.N4};{combination.N5};{combination.N6};";
                    writer.WriteLine(line);
                }
            }
        }
    }
}
