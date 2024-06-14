using System;
using System.Collections.Generic;
using System.Data;
using System.Threading.Tasks;
using ApoioNegocio.Core.Entities.Base;
using Dapper;
using FluentValidation;
using Microsoft.Extensions.Configuration;

namespace ApoioNegocio.Core.Repositories.Base.Interfaces;

public interface ICLASSIFICACAO_REPOSITORY_BASE
{
    public Task<IEnumerable<CLASSIFICACAO_BASE>> GetAllAsync(
        CancellationToken cancellationToken = default
    );
    public Task<CLASSIFICACAO_BASE?> GetByIdAsync(
        string id,
        CancellationToken cancellationToken = default
    );
    public Task<int> InsertAsync(
        CLASSIFICACAO_BASE entity,
        CancellationToken cancellationToken = default
    );
    public Task<int> UpdateAsync(
        CLASSIFICACAO_BASE entity,
        CancellationToken cancellationToken = default
    );
    public Task<int> DeleteAsync(
        CLASSIFICACAO_BASE entity,
        CancellationToken cancellationToken = default
    );
}
