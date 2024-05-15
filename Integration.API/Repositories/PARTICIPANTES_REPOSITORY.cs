using Integration.API.Repositories.Base;
using Integration.API.Repositories.Interfaces;
using System.Data;

namespace Integration.API.Repositories;

public class PARTICIPANTES_REPOSITORY : PARTICIPANTES_REPOSITORY_BASE, IPARTICIPANTES_REPOSITORY
{
    public PARTICIPANTES_REPOSITORY(IDbConnection connection)
        : base(connection) { }
}
