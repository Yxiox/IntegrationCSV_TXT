using MySql.Data.MySqlClient;
using System.Data;

namespace ApoioNegocio.Core.Repositories.Shared;

public abstract class Repository
{
    protected static IDbConnection Create()
    {
        return new MySqlConnection("server=localhost;database=apoionegocio;uid=root;pwd=root");
    }
}
