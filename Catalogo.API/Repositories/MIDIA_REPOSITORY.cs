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

public class MIDIA_REPOSITORY : MIDIA_REPOSITORY_BASE, IMIDIA_REPOSITORY
{
    public MIDIA_REPOSITORY(IDbConnection connection)
        : base(connection) { }
}
