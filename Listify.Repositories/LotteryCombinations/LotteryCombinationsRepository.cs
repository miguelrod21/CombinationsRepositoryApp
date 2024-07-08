using Listify.Repositories.LotteryCombinations.Dtos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Listify.Repositories.LotteryCombinations
{
    public class LotteryCombinationsRepository : ILotteryCombinationsRepository
    {
        public LotteryCombinationsRepository()
        {
        }

        public List<CombinationDto> GetAll()
        {
            //List<CombinationDto> resut = new();
            //for (int i = 0; i < 6; i++)
            //{
            //    CombinationDto comb = new CombinationDto
            //    {
            //        N1 = new Random().Next(1, 50),
            //        N2 = new Random().Next(1, 50),
            //        N3 = new Random().Next(1, 50),
            //        N4 = new Random().Next(1, 50),
            //        N5 = new Random().Next(1, 50),
            //        N6 = new Random().Next(1, 50)

            //    };
            //    resut.Add(comb);
            //}
            List<CombinationDto> combinaciones = new List<CombinationDto>();
            int[] numeros = new int[49];
            for (int i = 0; i < 49; i++)
            {
                numeros[i] = i + 1; // Llena el array con números del 1 al 49
            }

            // Generar todas las combinaciones posibles
            GenerarCombinaciones(numeros, 6, new int[6], 0, 0, combinaciones);

            return combinaciones;
        }
        private void GenerarCombinaciones(int[] numeros, int k, int[] combinacionActual, int inicio, int index, List<CombinationDto> combinaciones)
        {
            if (index == k)
            {
                // Se ha completado una combinación de 6 números, agregarla a la lista de combinaciones
                combinaciones.Add(new CombinationDto
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
                GenerarCombinaciones(numeros, k, combinacionActual, i + 1, index + 1, combinaciones);
            }
        }
        public List<CombinationDto> CalcularCombinaciones()
        {
            List<CombinationDto> combinaciones = new List<CombinationDto>();
            int[] numeros = new int[49];
            for (int i = 0; i < 49; i++)
            {
                numeros[i] = i + 1; // Llena el array con números del 1 al 49
            }

            // Utiliza un array auxiliar para almacenar la combinación actual
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

        //public List<CombinationDto> CalcularCombinaciones1()
        //{
        //    List<CombinationDto> combinaciones = new List<CombinationDto>();
        //    int[] numeros = new int[49];
        //    for (int i = 0; i < 49; i++)
        //    {
        //        numeros[i] = i + 1; // Llena el array con números del 1 al 49
        //    }

        //    // Algoritmo para generar combinaciones
        //    int[] indices = new int[6]; // Array para almacenar los índices de los números seleccionados

        //    for (int i = 0; (indices[0] = i++) < 44;)
        //        for (int j = 1; (indices[1] = i++) < 45;)
        //            for (int i = 2; (indices[2] = i++) < 46;)
        //                for (int i = 3; (indices[3] = i++) < 47;)
        //                    for (int i = 4; (indices[4] = i++) < 48;)
        //                        for (int i = 5; (indices[5] = i++) < 49;)
        //                        {
        //                            combinaciones.Add(new CombinationDto
        //                            {
        //                                N1 = numeros[indices[0]],
        //                                N2 = numeros[indices[1]],
        //                                N3 = numeros[indices[2]],
        //                                N4 = numeros[indices[3]],
        //                                N5 = numeros[indices[4]],
        //                                N6 = numeros[indices[5]]
        //                            });
        //                        }

        //    return combinaciones;
        //}
    }
}

