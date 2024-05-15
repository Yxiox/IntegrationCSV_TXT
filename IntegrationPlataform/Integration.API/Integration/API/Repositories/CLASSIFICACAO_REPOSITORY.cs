using Integration.API.Integration.API.Repositories.Base;
using Integration.API.Integration.API.Repositories.Interfaces;
using System.Data;

namespace Integration.API.Integration.API.Repositories;

public class CLASSIFICACAO_REPOSITORY : CLASSIFICACAO_REPOSITORY_BASE, ICLASSIFICACAO_REPOSITORY
{
    public CLASSIFICACAO_REPOSITORY(IDbConnection connection)
        : base(connection) { }
}
