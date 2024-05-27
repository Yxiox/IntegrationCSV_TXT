using Dapper;
using Integration.API.Entities.Base;
using Integration.API.Repositories.Base.Interfaces;
using Integration.API.Repositories.Shared;
using System.Data;

// File Auto Generated. DOT NOT MODIFY
namespace Integration.API.Repositories.Base;

public class CATEGORIA_REPOSITORY_BASE : Repository, ICATEGORIA_REPOSITORY_BASE
{
    private IDbConnection _connection;

    public async Task<int> DeleteAsync(
        CATEGORIA_BASE categoria,
        CancellationToken cancellationToken = default
    )
    {
        try
        {
            object parameters = new { idParam = categoria.ID };
            var sql =
                @"DELETE FROM categoria
WHERE ID = @idParam
";
            using (_connection = Create())
            {
                CommandDefinition command =
                    new(sql, parameters, cancellationToken: cancellationToken);
                var affectedRows = await _connection.ExecuteAsync(command);

                return affectedRows;
            }
        }
        catch (Exception)
        {
            throw;
        }
    }

    public async Task<int> InsertAsync(
        CATEGORIA_BASE categoria,
        CancellationToken cancellationToken = default
    )
    {
        try
        {
            object parameters = new
            {
                nomeParam = categoria.NOME,
                dataregistroParam = categoria.DATAREGISTRO,
                datainativacaoParam = categoria.DATAINATIVACAO,
            };
            var sql =
                @"					INSERT INTO categoria
					(
					NOME
					,DATAREGISTRO
					,DATAINATIVACAO
					)
					VALUES
					(
					@nomeParam
					,@dataregistroParam
					,@datainativacaoParam
					)
";
            using (_connection = Create())
            {
                CommandDefinition command =
                    new(sql, parameters, cancellationToken: cancellationToken);
                var affectedRows = await _connection.ExecuteAsync(command);

                return affectedRows;
            }
        }
        catch (Exception)
        {
            throw;
        }
    }

    public async Task<IEnumerable<CATEGORIA_BASE>> GetAllAsync(
        CancellationToken cancellationToken = default
    )
    {
        try
        {
            var sql = @"SELECT * FROM categoria";
            using (_connection = Create())
            {
                CommandDefinition command = new(sql, cancellationToken: cancellationToken);
                return await _connection.QueryAsync<CATEGORIA_BASE>(command);
            }
        }
        catch (Exception)
        {
            throw;
        }
    }

    public async Task<CATEGORIA_BASE?> GetByIdAsync(
        string id,
        CancellationToken cancellationToken = default
    )
    {
        try
        {
            object parameters = new { idParam = id };
            var sql = @"SELECT * FROM categoria WHERE ID = @idParam";
            using (_connection = Create())
            {
                CommandDefinition command =
                    new(sql, parameters, cancellationToken: cancellationToken);
                return await _connection.QuerySingleOrDefaultAsync<CATEGORIA_BASE>(command);
            }
        }
        catch (Exception)
        {
            throw;
        }
    }

    public async Task<int> UpdateAsync(
        CATEGORIA_BASE categoria,
        CancellationToken cancellationToken = default
    )
    {
        try
        {
            object parameters = new
            {
                idParam = categoria.ID,
                nomeParam = categoria.NOME,
                dataregistroParam = categoria.DATAREGISTRO,
                datainativacaoParam = categoria.DATAINATIVACAO,
            };
            var sql =
                @"					UPDATE categoria SET
                    NOME = @nomeParam
                    ,DATAREGISTRO = @dataregistroParam
                    ,DATAINATIVACAO = @datainativacaoParam
                     WHERE ID = @idParam;
";
            using (_connection = Create())
            {
                CommandDefinition command =
                    new(sql, parameters, cancellationToken: cancellationToken);
                var affectedRows = await _connection.ExecuteAsync(command);

                return affectedRows;
            }
        }
        catch (Exception)
        {
            throw;
        }
    }
}
