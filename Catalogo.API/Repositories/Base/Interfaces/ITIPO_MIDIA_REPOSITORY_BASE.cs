using System;
using System.Collections.Generic;
using System.Data;
using System.Threading.Tasks;
using CATALOGO.API.Entities.Base;
using Dapper;
using FluentValidation;
using Microsoft.Extensions.Configuration;

namespace CATALOGO.API.Repositories.Base.Interfaces;

public interface ITIPO_MIDIA_REPOSITORY_BASE
{
    public Task<IEnumerable<TIPO_MIDIA_BASE>> GetAllAsync(
        CancellationToken cancellationToken = default
    );
    public Task<TIPO_MIDIA_BASE?> GetByIdAsync(
        int id,
        CancellationToken cancellationToken = default
    );
    public Task<int> InsertAsync(
        TIPO_MIDIA_BASE entity,
        CancellationToken cancellationToken = default
    );
    public Task<int> UpdateAsync(
        TIPO_MIDIA_BASE entity,
        CancellationToken cancellationToken = default
    );
    public Task<int> DeleteAsync(
        TIPO_MIDIA_BASE entity,
        CancellationToken cancellationToken = default
    );
}
