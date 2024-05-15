using Integration.API.Integration.API.Repositories.Base;
using Integration.API.Integration.API.Repositories.Interfaces;
using System.Data;

namespace Integration.API.Integration.API.Repositories;

public class GENERO_REPOSITORY : GENERO_REPOSITORY_BASE, IGENERO_REPOSITORY
{
    public GENERO_REPOSITORY(IDbConnection connection)
        : base(connection) { }
}
