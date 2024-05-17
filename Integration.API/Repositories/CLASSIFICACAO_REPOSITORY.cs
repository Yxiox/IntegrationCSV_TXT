using System;
using System.Collections.Generic;
using System.Data;
using System.Threading.Tasks;
using Dapper;
using FluentValidation;
using Integration.API.Repositories.Base;
using Integration.API.Repositories.Base.Interfaces;
using Integration.API.Repositories.Interfaces;
using Microsoft.Extensions.Configuration;

namespace Integration.API.Repositories;

public class CLASSIFICACAO_REPOSITORY : CLASSIFICACAO_REPOSITORY_BASE, ICLASSIFICACAO_REPOSITORY
{
    public CLASSIFICACAO_REPOSITORY(IDbConnection connection)
        : base(connection) { }
}
