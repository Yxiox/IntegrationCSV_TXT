using Catalogo.API.Entities;
using Catalogo.API.Entities.Base;
using Dapper;

namespace Catalogo.API.Repositories.Base.Interfaces;

public interface ICATALOGO_REPOSITORY_BASE
{
    public Task<IEnumerable<CATALOGO>> GetAllAsync(
        CancellationToken cancellationToken = default
    );
    public Task<CATALOGO?> GetByIdAsync(
        string id,
        CancellationToken cancellationToken = default
    );
    public Task<int> InsertAsync(
        CATALOGO entity,
        CancellationToken cancellationToken = default
    );
    public Task<int> UpdateAsync(
        CATALOGO entity,
        CancellationToken cancellationToken = default
    );
    public Task<int> DeleteAsync(
        CATALOGO entity,
        CancellationToken cancellationToken = default
    );
}
