using System;
using System.Collections.Generic;
using System.Data;
using System.Threading.Tasks;
using ApoioNegocio.Core.Entities.Base;
using Dapper;
using FluentValidation;
using Microsoft.Extensions.Configuration;

namespace ApoioNegocio.Core.Repositories.Base.Interfaces;

public interface IPARTICIPANTES_REPOSITORY_BASE
{
    public Task<IEnumerable<PARTICIPANTES_BASE>> GetAllAsync(
        CancellationToken cancellationToken = default
    );
    public Task<PARTICIPANTES_BASE?> GetByIdAsync(
        string id,
        CancellationToken cancellationToken = default
    );
    public Task<int> InsertAsync(
        PARTICIPANTES_BASE entity,
        CancellationToken cancellationToken = default
    );
    public Task<int> UpdateAsync(
        PARTICIPANTES_BASE entity,
        CancellationToken cancellationToken = default
    );
    public Task<int> DeleteAsync(
        PARTICIPANTES_BASE entity,
        CancellationToken cancellationToken = default
    );
}
