using Catalogo.API.Entities;
using Catalogo.API.Entities.Base;

namespace Catalogo.API.Services
{
    public interface ICatalogoService
    {
        Task DeleteAsync(string id, CancellationToken cancellation = default);
        Task<IEnumerable<CATALOGO_BASE>> GetAllAsync(CancellationToken cancellation = default);
        Task<CATALOGO_BASE?> GetByIdAsync(string id, CancellationToken cancellation = default);
        Task UpsertAsync(CATALOGO catalogo, bool isInsert, CancellationToken cancellationToken = default);
    }
}