using System;
using System.Collections.Generic;
using System.Data;
using System.Threading.Tasks;
using CATALOGO.API.Entities.Base;
using CATALOGO.API.Repositories.Base.Interfaces;
using Dapper;
using FluentValidation;
using Microsoft.Extensions.Configuration;

// File Auto Generated. DOT NOT MODIFY
namespace CATALOGO.API.Repositories.Base;

public class GENERO_REPOSITORY_BASE : IGENERO_REPOSITORY_BASE
{
    private readonly IDbConnection _connection;

    public GENERO_REPOSITORY_BASE(IDbConnection connection)
    {
        _connection = connection;
    }

    public async Task<int> DeleteAsync(
        GENERO_BASE genero,
        CancellationToken cancellationToken = default
    )
    {
        try
        {
            object parameters = new { idParam = genero.ID };
            var sql =
                @"DELETE FROM genero
WHERE ID = @idParam
";
            using (_connection)
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
        GENERO_BASE genero,
        CancellationToken cancellationToken = default
    )
    {
        try
        {
            object parameters = new { idregistroParam = genero.ID_REGISTRO, };
            var sql =
                @"					INSERT INTO genero
					(
					ID_REGISTRO
					)
					VALUES
					(
					@idregistroParam
					)
";
            using (_connection)
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

    public async Task<IEnumerable<GENERO_BASE>> GetAllAsync(
        CancellationToken cancellationToken = default
    )
    {
        try
        {
            var sql = @"SELECT * FROM genero";
            using (_connection)
            {
                CommandDefinition command = new(sql, cancellationToken: cancellationToken);
                return await _connection.QueryAsync<GENERO_BASE>(command);
            }
        }
        catch (Exception)
        {
            throw;
        }
    }

    public async Task<GENERO_BASE?> GetByIdAsync(
        string id,
        CancellationToken cancellationToken = default
    )
    {
        try
        {
            object parameters = new { idParam = id };
            var sql = @"SELECT * FROM genero WHERE ID = @idParam";
            using (_connection)
            {
                CommandDefinition command =
                    new(sql, parameters, cancellationToken: cancellationToken);
                return await _connection.QuerySingleOrDefaultAsync<GENERO_BASE>(command);
            }
        }
        catch (Exception)
        {
            throw;
        }
    }

    public async Task<int> UpdateAsync(
        GENERO_BASE genero,
        CancellationToken cancellationToken = default
    )
    {
        try
        {
            object parameters = new { idParam = genero.ID, idregistroParam = genero.ID_REGISTRO, };
            var sql =
                @"					UPDATE genero SET
                    ID_REGISTRO = @idregistroParam
                     WHERE ID = @idParam;
";
            using (_connection)
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
