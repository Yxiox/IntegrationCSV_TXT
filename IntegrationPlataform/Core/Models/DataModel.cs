namespace Core.Models;

internal class DataModel
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
}
