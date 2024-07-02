using Integration.Core;
using Integration.Core.Data;
using Integration.Core.Models;
using Microsoft.VisualBasic.FileIO;

namespace Integration.Core.Csv;

public class CsvImporter
{
    public static async Task Import()
    {
        using (TextFieldParser parser = new TextFieldParser($@"{FilePath.PATH}/ImporterCsv.csv"))
        {
            parser.TextFieldType = FieldType.Delimited;
            parser.SetDelimiters(";");
            string[] headers = parser.ReadFields();

            Console.WriteLine($"\n-----HEADERS-----\n" + string.Join(",", headers));


            try
            {
                while (!parser.EndOfData)
                {
                    string[] fields = parser.ReadFields();

                    DataModel model = new DataModel
                    {
                        GENERO = fields[0],
                        CATEGORIA = fields[1],
                        MIDIA = fields[2],
                        TIPO_MIDIA = fields[3],
                        CLASSIFICACAO = fields[4],
                        PARTICIPANTE = fields[5]
                    };
                    await CsvRepository.InserirAsync(model);
                }
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
