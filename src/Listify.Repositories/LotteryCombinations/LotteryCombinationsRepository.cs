using Listify.Repositories.LotteryCombinations.Dtos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;

namespace Listify.Repositories.LotteryCombinations
{
    public class LotteryCombinationsRepository : ILotteryCombinationsRepository
    {
        private readonly string CombinationsPath = "..\\repo\\combinations.txt";
        private readonly string CheckedCombinationsPath = "..\\repo\\checked-combinations.txt";
        public LotteryCombinationsRepository()
        {
        }

        public List<CombinationDto>? GetAll()
        {
            if (File.Exists(CombinationsPath))
            {
                string data = File.ReadAllText(CombinationsPath);
                var deserialized = JsonSerializer.Deserialize<List<CombinationDto>>(data);
                if (deserialized == null) return null;
                return deserialized.ToList();
            }
            return null;
        }
        public List<CombinationDto>? GetAllChecked()
        {
            if (File.Exists(CheckedCombinationsPath))
            {
                string data = File.ReadAllText(CheckedCombinationsPath);
                var deserialized = JsonSerializer.Deserialize<List<CombinationDto>>(data);
                if (deserialized == null) return null;
                return deserialized.ToList();
            }
            return null;
        }
        public void SaveCombinations(List<CombinationDto> combinations)
        {
            var data = JsonSerializer.Serialize(combinations);
            File.WriteAllText(CombinationsPath, data);
        }

        private void SaveCombinationsFormattedFile(List<CombinationDto> combinations)
        {
            using (StreamWriter writer = new StreamWriter(CombinationsPath))
            {
                for (int i = 0; i < combinations.Count; i++)
                {
                    CombinationDto combination = combinations[i];
                    string line = $"Combinacion {i + 1}: {combination.N1} {combination.N2} {combination.N3} {combination.N4} {combination.N5} {combination.N6}";
                    writer.WriteLine(line);
                }
            }
        }

        private void SaveCombinationsFormattedExcelFile(List<CombinationDto> combinations)
        {
            using (StreamWriter writer = new StreamWriter(CombinationsPath))
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

