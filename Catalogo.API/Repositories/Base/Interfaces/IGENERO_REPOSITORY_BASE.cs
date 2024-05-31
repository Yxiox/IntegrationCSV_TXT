using System;
using System.Collections.Generic;
using System.Data;
using System.Threading.Tasks;
using CATALOGO.API.Entities.Base;
using Dapper;
using FluentValidation;
using Microsoft.Extensions.Configuration;

namespace CATALOGO.API.Repositories.Base.Interfaces;

public interface IGENERO_REPOSITORY_BASE
{
    public Task<IEnumerable<GENERO_BASE>> GetAllAsync(
        CancellationToken cancellationToken = default
    );
    public Task<GENERO_BASE?> GetByIdAsync(int id, CancellationToken cancellationToken = default);
    public Task<int> InsertAsync(GENERO_BASE entity, CancellationToken cancellationToken = default);
    public Task<int> UpdateAsync(GENERO_BASE entity, CancellationToken cancellationToken = default);
    public Task<int> DeleteAsync(GENERO_BASE entity, CancellationToken cancellationToken = default);
}
