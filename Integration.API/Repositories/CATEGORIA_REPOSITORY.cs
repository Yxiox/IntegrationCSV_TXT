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

public class CATEGORIA_REPOSITORY : CATEGORIA_REPOSITORY_BASE, ICATEGORIA_REPOSITORY
{
    public CATEGORIA_REPOSITORY(IDbConnection connection)
        : base(connection) { }
}
