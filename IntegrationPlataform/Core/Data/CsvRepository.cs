using Dapper;
using QuickKit.Cmd.Enums;
using QuickKit.Cmd;
using Core.Models;

namespace Core.Data;

internal class CsvRepository : Repository
{
    public async void CsvAdd(string gENERO, string cATEGORIA, string mIDIA, string tIPO_MIDIA, int cLASSIFICACAO, string pARTICIPANTE)
    {
        string query = $"INSERT INTO legado (genero, categoria,  midia, tipo_midia, classificacao, participante) VALUES ({gENERO},{cATEGORIA},{mIDIA},{tIPO_MIDIA},{cLASSIFICACAO},{pARTICIPANTE})";

    }

}
