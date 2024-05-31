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

public class GENERO_REPOSITORY : GENERO_REPOSITORY_BASE, IGENERO_REPOSITORY
{
    public GENERO_REPOSITORY(IDbConnection connection)
        : base(connection) { }
}
