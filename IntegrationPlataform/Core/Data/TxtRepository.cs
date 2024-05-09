using Core.Models;
using Dapper;
using QuickKit.Cmd;
using QuickKit.Cmd.Enums;
using System;

namespace Core.Data;

internal class TxtRepository : Repository
{
    public static Task<IEnumerable<DataModel>> ExportAll()
    {
        try
        {
            var sql = "SELECT * FROM monolito";
            using (var conn = Connect())
            {
                return conn.QueryAsync<DataModel>(sql);
            }
        }
        catch (Exception ex)
        {
            Consoler.WriteLine($"um erro ocorreu ao exportar os dados. Error: {ex.Message}",AlertType.Error);
            throw;
        }
    }
}
