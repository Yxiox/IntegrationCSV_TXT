using System.Text;
using CsvHelper.Configuration.Attributes;

namespace Integration.Core.Models;

public class DataModel
{
    public int ID { get; set; }
    public string GENERO { get; set; }
    public string CATEGORIA { get; set; }
    public string MIDIA { get; set; }
    public string TIPO_MIDIA { get; set; }
    public string CLASSIFICACAO { get; set; }
    public string PARTICIPANTE { get; set; }

    public DataModel(
        string gENERO,
        string cATEGORIA,
        string mIDIA,
        string tIPO_MIDIA,
        string cLASSIFICACAO,
        string pARTICIPANTE
    )
    {
        GENERO = gENERO;
        CATEGORIA = cATEGORIA;
        MIDIA = mIDIA;
        TIPO_MIDIA = tIPO_MIDIA;
        CLASSIFICACAO = cLASSIFICACAO;
        PARTICIPANTE = pARTICIPANTE;
    }

    public DataModel() { }

    public override string? ToString()
    {
        StringBuilder sb = new();
        sb.AppendLine($"{nameof(ID)} - {ID}");
        sb.AppendLine($"{nameof(GENERO)} - {GENERO}");
        sb.AppendLine($"{nameof(CATEGORIA)} - {CATEGORIA}");
        sb.AppendLine($"{nameof(MIDIA)} - {MIDIA}");
        sb.AppendLine($"{nameof(TIPO_MIDIA)} - {TIPO_MIDIA}");
        sb.AppendLine($"{nameof(CLASSIFICACAO)} - {CLASSIFICACAO}");
        sb.AppendLine($"{nameof(PARTICIPANTE)} - {PARTICIPANTE}");

        return sb.ToString();
    }
}
