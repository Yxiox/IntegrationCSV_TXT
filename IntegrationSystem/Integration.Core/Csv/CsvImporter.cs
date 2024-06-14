using Integration.Core;
using Integration.Core.Data;
using Integration.Core.Models;
using Microsoft.VisualBasic.FileIO;

namespace Integration.Core.Csv;

public class CsvImporter
{
    public static async Task Import()
    {
        using (TextFieldParser parser = new TextFieldParser($@"{FilePath.PATH}/testeCSV.csv"))
        {
            parser.TextFieldType = FieldType.Delimited;
            parser.SetDelimiters(",");
            Console.WriteLine($"\n-----HEADERS-----\n" + $"{parser.ReadLine()}");

            while (!parser.EndOfData)
            {
                string[] fields = parser.ReadFields();
                DataModel model =
                    new(fields[0], fields[1], fields[2], fields[3], fields[4], fields[5]);
                try
                {
                    await CsvRepository.InserirAsync(model);
                }
                catch (Exception)
                {
                    await Console.Out.WriteLineAsync(
                        "Erro ao inserir, favor conferir arquivo de importação!"
                    );
                    throw;
                }
            }
        }
    }
}
