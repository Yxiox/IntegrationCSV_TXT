using System;
using System.Collections.Generic;
using System.Data;
using System.Threading.Tasks;
using CATALOGO.API.Repositories.Base;
using CATALOGO.API.Repositories.Base.Interfaces;
using CATALOGO.API.Repositories.Interfaces;
using Dapper;
using FluentValidation;
using Microsoft.Extensions.Configuration;

namespace CATALOGO.API.Repositories;

public class CLASSIFICACAO_REPOSITORY : CLASSIFICACAO_REPOSITORY_BASE, ICLASSIFICACAO_REPOSITORY
{
    public CLASSIFICACAO_REPOSITORY(IDbConnection connection)
        : base(connection) { }
}
