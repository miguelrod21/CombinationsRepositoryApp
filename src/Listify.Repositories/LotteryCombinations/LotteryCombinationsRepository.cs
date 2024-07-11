using Listify.Repositories.LotteryCombinations.Dtos;
using OfficeOpenXml;
using OfficeOpenXml.FormulaParsing.Excel.Functions.RefAndLookup;
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

        public void SaveCombinationsFormattedExcelFile(List<CombinationDto> combinations)
        {
            using (var package = new ExcelPackage())
            {
                // Agregar una hoja al archivo
                var worksheet = package.Workbook.Worksheets.Add("Combinaciones");

                // Escribir las combinaciones en la hoja de Excel
                int column = 1;


                int maximRow = 1048576; // Límite máximo de filas en una hoja de Excel
                int row = 1;

                foreach (var combination in combinations)
                {
                    // Cambiar a una nueva columna si se supera el límite de filas
                    if (row > maximRow)
                    {
                        row = 1;
                        column++;
                    }

                    // Escribir la combinación en la celda
                    worksheet.Cells[row, column].Value = string.Concat(
                            combination.N1, " ",
                            combination.N2, " ",
                            combination.N3, " ",
                            combination.N4, " ",
                            combination.N5, " ",
                            combination.N6);

                    // Avanzar a la siguiente fila para la siguiente combinación
                    row++;
                }
                var nombreArchivo = "Combinaciones.xlsx";
                var fileInfo = new FileInfo(nombreArchivo);
                package.SaveAs(fileInfo);
            }
        }


    }
}

