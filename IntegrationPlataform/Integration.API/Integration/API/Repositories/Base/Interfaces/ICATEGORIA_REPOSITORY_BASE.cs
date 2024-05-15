using System;
using System.Collections.Generic;
using System.Data;
using System.Threading.Tasks;
using Dapper;
using FluentValidation;
using Integration.API.Integration.API.Entities.Base;
using Microsoft.Extensions.Configuration;

namespace Integration.API.Integration.API.Repositories.Base.Interfaces;

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
