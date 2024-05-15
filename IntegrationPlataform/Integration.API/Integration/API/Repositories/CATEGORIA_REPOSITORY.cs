using Integration.API.Integration.API.Repositories.Base;
using Integration.API.Integration.API.Repositories.Interfaces;
using System.Data;

namespace Integration.API.Integration.API.Repositories;

public class CATEGORIA_REPOSITORY : CATEGORIA_REPOSITORY_BASE, ICATEGORIA_REPOSITORY
{
    public CATEGORIA_REPOSITORY(IDbConnection connection)
        : base(connection) { }
}
