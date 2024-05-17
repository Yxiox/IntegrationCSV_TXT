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

public class GENERO_REPOSITORY : GENERO_REPOSITORY_BASE, IGENERO_REPOSITORY
{
    public GENERO_REPOSITORY(IDbConnection connection)
        : base(connection) { }
}
