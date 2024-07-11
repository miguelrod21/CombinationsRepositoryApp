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
        public List<CombinationDto>? GetAllChecked()
        {
            List<CombinationDto>? checkCombinations = new();
            checkCombinations = _repository.GetAllChecked();
            return checkCombinations;
        }
        public List<CombinationDto>? GetAll()
        {
            List<CombinationDto>? combinations = new();
            combinations = _repository.GetAll();

            if (combinations != null)
                return combinations;

            combinations = new List<CombinationDto>();
            int[] numeros = new int[49];
            for (int i = 0; i < 49; i++)
            {
                numeros[i] = i + 1;
            }

            GenerarCombinaciones(numeros, 6, new int[6], 0, 0, combinations);
            if (combinations != null)
                _repository.SaveCombinationsFormattedExcelFile(combinations);
            return combinations;
        }
        private void GenerarCombinaciones(int[] numeros, int k, int[] combinacionActual, int inicio, int index, List<CombinationDto> combinations)
        {
            if (index == k)
            {
                combinations.Add(new CombinationDto
                {
                    N1 = combinacionActual[0],
                    N2 = combinacionActual[1],
                    N3 = combinacionActual[2],
                    N4 = combinacionActual[3],
                    N5 = combinacionActual[4],
                    N6 = combinacionActual[5]
                });
                return;
            }

            for (int i = inicio; i <= numeros.Length - k + index; i++)
            {
                combinacionActual[index] = numeros[i];
                GenerarCombinaciones(numeros, k, combinacionActual, i + 1, index + 1, combinations);
            }
        }
        public List<CombinationDto> CalcularCombinaciones()
        {
            List<CombinationDto> combinaciones = new List<CombinationDto>();
            int[] numeros = new int[49];
            for (int i = 0; i < 49; i++)
            {
                numeros[i] = i + 1;
            }
            int[] combinacionActual = new int[6];
            int index = 0;
            int inicio = 0;

            while (index >= 0)
            {
                if (index == 6)
                {
                    combinaciones.Add(new CombinationDto
                    {
                        N1 = combinacionActual[0],
                        N2 = combinacionActual[1],
                        N3 = combinacionActual[2],
                        N4 = combinacionActual[3],
                        N5 = combinacionActual[4],
                        N6 = combinacionActual[5]
                    });
                    index--;
                    inicio++;
                }
                else if (inicio >= 49)
                {
                    index--;
                    if (index >= 0)
                    {
                        inicio = combinacionActual[index] + 1;
                    }
                }
                else
                {
                    combinacionActual[index] = numeros[inicio];
                    index++;
                    inicio++;
                }
            }

            return combinaciones;
        }

       
    }
}
