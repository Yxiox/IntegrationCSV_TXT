using Integration.API.Repositories.Base;
using Integration.API.Repositories.Interfaces;
using System.Data;

namespace Integration.API.Repositories;

public class MIDIA_REPOSITORY : MIDIA_REPOSITORY_BASE, IMIDIA_REPOSITORY
{
    public MIDIA_REPOSITORY(IDbConnection connection)
        : base(connection) { }
}
