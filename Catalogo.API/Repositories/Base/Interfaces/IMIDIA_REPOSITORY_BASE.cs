using System;
using System.Collections.Generic;
using System.Data;
using System.Threading.Tasks;
using CATALOGO.API.Entities.Base;
using Dapper;
using FluentValidation;
using Microsoft.Extensions.Configuration;

namespace CATALOGO.API.Repositories.Base.Interfaces;

public interface IMIDIA_REPOSITORY_BASE
{
    public Task<IEnumerable<MIDIA_BASE>> GetAllAsync(CancellationToken cancellationToken = default);
    public Task<MIDIA_BASE?> GetByIdAsync(int id, CancellationToken cancellationToken = default);
    public Task<int> InsertAsync(MIDIA_BASE entity, CancellationToken cancellationToken = default);
    public Task<int> UpdateAsync(MIDIA_BASE entity, CancellationToken cancellationToken = default);
    public Task<int> DeleteAsync(MIDIA_BASE entity, CancellationToken cancellationToken = default);
}
