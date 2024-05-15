using System;
using System.Collections.Generic;
using System.Data;
using System.Threading.Tasks;
using Dapper;
using FluentValidation;
using Integration.API.Integration.API.Entities.Base;
using Microsoft.Extensions.Configuration;

namespace Integration.API.Integration.API.Repositories.Base.Interfaces;

public interface IMIDIA_REPOSITORY_BASE
{
    public Task<IEnumerable<MIDIA_BASE>> GetAllAsync(CancellationToken cancellationToken = default);
    public Task<MIDIA_BASE?> GetByIdAsync(int id, CancellationToken cancellationToken = default);
    public Task<int> InsertAsync(MIDIA_BASE entity, CancellationToken cancellationToken = default);
    public Task<int> UpdateAsync(MIDIA_BASE entity, CancellationToken cancellationToken = default);
    public Task<int> DeleteAsync(MIDIA_BASE entity, CancellationToken cancellationToken = default);
}
