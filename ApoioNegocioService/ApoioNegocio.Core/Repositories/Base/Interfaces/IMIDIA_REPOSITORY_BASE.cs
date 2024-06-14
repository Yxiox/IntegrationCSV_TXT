using System;
using System.Collections.Generic;
using System.Data;
using System.Threading.Tasks;
using ApoioNegocio.Core.Entities.Base;
using Dapper;
using FluentValidation;
using Microsoft.Extensions.Configuration;

namespace ApoioNegocio.Core.Repositories.Base.Interfaces;

public interface IMIDIA_REPOSITORY_BASE
{
    public Task<IEnumerable<MIDIA_BASE>> GetAllAsync(CancellationToken cancellationToken = default);
    public Task<MIDIA_BASE?> GetByIdAsync(string id, CancellationToken cancellationToken = default);
    public Task<int> InsertAsync(MIDIA_BASE entity, CancellationToken cancellationToken = default);
    public Task<int> UpdateAsync(MIDIA_BASE entity, CancellationToken cancellationToken = default);
    public Task<int> DeleteAsync(MIDIA_BASE entity, CancellationToken cancellationToken = default);
}
