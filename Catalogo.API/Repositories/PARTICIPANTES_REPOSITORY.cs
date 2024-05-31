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

public class PARTICIPANTES_REPOSITORY : PARTICIPANTES_REPOSITORY_BASE, IPARTICIPANTES_REPOSITORY
{
    public PARTICIPANTES_REPOSITORY(IDbConnection connection)
        : base(connection) { }
}
