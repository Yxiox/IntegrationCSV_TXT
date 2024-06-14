using System.Data;

namespace Catalogo.API.Repositories.Base.Shared;

public interface IRepository
{
    IDbTransaction BeginTransaction();
    void Commit();
    void Rollback();
}
