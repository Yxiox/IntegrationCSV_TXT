using CsvHelper.Configuration;
using static Org.BouncyCastle.Math.EC.ECCurve;
using System.Globalization;
using CsvHelper;
using Core.Data;
using Core.Models;

namespace Core.Csv;

public class CsvImporter
{
    public void Import()
    {
        var config = new CsvConfiguration(CultureInfo.CurrentCulture)
        {
            HasHeaderRecord = true,
            HeaderValidated = null
        };

        using (var reader = new StreamReader(@"C:\Users\mateus.oliveira7\Downloads\testeTXT2.csv"))
        using (var csv = new CsvReader(reader, config))
        {
            var midias = csv.GetRecords<DataModel>();
            foreach (var midia in midias)
            {
                
            }
        }
    }
}
