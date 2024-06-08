using Catalogo.API.Entities;
using Catalogo.API.Entities.Base;
using Catalogo.API.Properties.Dto;

namespace Catalogo.API.Services
{
    public interface ICatalogoService
    {
        Task DeleteAsync(string id, CancellationToken cancellation = default);
        Task<IEnumerable<CatalogoDto>> GetAllAsync(CancellationToken cancellation = default);
        Task<CatalogoDto?> GetByIdAsync(string id, CancellationToken cancellation = default);
        Task UpsertAsync(CATALOGO catalogo, bool isInsert, CancellationToken cancellationToken = default);
    }
}