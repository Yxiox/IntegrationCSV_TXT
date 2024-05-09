using Core.Data;
using CsvHelper.Configuration;

namespace Core.Csv
{
    public class CsvMap : ClassMap<datamodel>
    {
        public CsvMap()
        {
            Map(m => m.GENERO).Name("GENERO");
            Map(m => m.CATEGORIA).Name("CATEGORIA");
            Map(m => m.MIDIA).Name("MIDIA");
            Map(m => m.TIPO_MIDIA).Name("TIPO_MIDIA");
            Map(m => m.CLASSIFICACAO).Name("CLASSIFICACAO");
            Map(m => m.PARTICIPANTE).Name("PARTICIPANTE");
        }
    }
}
