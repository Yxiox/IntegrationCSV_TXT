using Integration.API.Integration.API.Repositories.Base;
using Integration.API.Integration.API.Repositories.Interfaces;
using System.Data;

namespace Integration.API.Integration.API.Repositories;

public class TIPO_MIDIA_REPOSITORY : TIPO_MIDIA_REPOSITORY_BASE, ITIPO_MIDIA_REPOSITORY
{
    public TIPO_MIDIA_REPOSITORY(IDbConnection connection)
        : base(connection) { }
}
