using System;
using System.Collections.Generic;
using System.Data;
using System.Threading.Tasks;
using CATALOGO.API.Entities.Base;
using Dapper;
using FluentValidation;
using Microsoft.Extensions.Configuration;

namespace CATALOGO.API.Repositories.Base.Interfaces;

public interface ICATEGORIA_REPOSITORY_BASE
{
    public Task<IEnumerable<CATEGORIA_BASE>> GetAllAsync(
        CancellationToken cancellationToken = default
    );
    public Task<CATEGORIA_BASE?> GetByIdAsync(
        int id,
        CancellationToken cancellationToken = default
    );
    public Task<int> InsertAsync(
        CATEGORIA_BASE entity,
        CancellationToken cancellationToken = default
    );
    public Task<int> UpdateAsync(
        CATEGORIA_BASE entity,
        CancellationToken cancellationToken = default
    );
    public Task<int> DeleteAsync(
        CATEGORIA_BASE entity,
        CancellationToken cancellationToken = default
    );
}
