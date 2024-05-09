using CsvHelper.Configuration;
using static Org.BouncyCastle.Math.EC.ECCurve;
using System.Globalization;
using CsvHelper;
using Core.Data;

namespace Core.Csv
{
    public class CsvImporter
    {
        public void Import()
        {
            var config = new CsvConfiguration(CultureInfo.InvariantCulture)
            {
                HasHeaderRecord = true
                //HeaderValidated = null
            };

            using (var reader = new StreamReader(@"C:\\Users\\mateus.oliveira7\\Downloads\\testeTXT2.csv"))
            using (var csv = new CsvReader(reader, CultureInfo.CurrentCulture))
            {
                var midias = csv.GetRecords<CsvRepository>();
                foreach (var midia in midias)
                {
                    Console.WriteLine(midia.GENERO);
                }
            }
        }
    }
}
