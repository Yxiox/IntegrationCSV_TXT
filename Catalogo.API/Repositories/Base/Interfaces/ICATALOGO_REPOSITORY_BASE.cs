using Catalogo.API.Entities.Base;
using Dapper;

namespace Catalogo.API.Repositories.Base.Interfaces;

public interface ICATALOGO_REPOSITORY_BASE
{
    public Task<IEnumerable<CATALOGO_BASE>> GetAllAsync(
        CancellationToken cancellationToken = default
    );
    public Task<CATALOGO_BASE?> GetByIdAsync(
        string id,
        CancellationToken cancellationToken = default
    );
    public Task<int> InsertAsync(
        CATALOGO_BASE entity,
        CancellationToken cancellationToken = default
    );
    public Task<int> UpdateAsync(
        CATALOGO_BASE entity,
        CancellationToken cancellationToken = default
    );
    public Task<int> DeleteAsync(
        CATALOGO_BASE entity,
        CancellationToken cancellationToken = default
    );
}
