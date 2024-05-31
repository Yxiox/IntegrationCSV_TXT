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

public class MIDIA_REPOSITORY_BASE : IMIDIA_REPOSITORY_BASE
{
    private readonly IDbConnection _connection;

    public MIDIA_REPOSITORY_BASE(IDbConnection connection)
    {
        _connection = connection;
    }

    public async Task<int> DeleteAsync(
        MIDIA_BASE midia,
        CancellationToken cancellationToken = default
    )
    {
        try
        {
            object parameters = new { idParam = midia.ID };
            var sql =
                @"DELETE FROM midia
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
        MIDIA_BASE midia,
        CancellationToken cancellationToken = default
    )
    {
        try
        {
            object parameters = new { idregistroParam = midia.ID_REGISTRO, };
            var sql =
                @"					INSERT INTO midia
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

    public async Task<IEnumerable<MIDIA_BASE>> GetAllAsync(
        CancellationToken cancellationToken = default
    )
    {
        try
        {
            var sql = @"SELECT * FROM midia";
            using (_connection)
            {
                CommandDefinition command = new(sql, cancellationToken: cancellationToken);
                return await _connection.QueryAsync<MIDIA_BASE>(command);
            }
        }
        catch (Exception)
        {
            throw;
        }
    }

    public async Task<MIDIA_BASE?> GetByIdAsync(
        string id,
        CancellationToken cancellationToken = default
    )
    {
        try
        {
            object parameters = new { idParam = id };
            var sql = @"SELECT * FROM midia WHERE ID = @idParam";
            using (_connection)
            {
                CommandDefinition command =
                    new(sql, parameters, cancellationToken: cancellationToken);
                return await _connection.QuerySingleOrDefaultAsync<MIDIA_BASE>(command);
            }
        }
        catch (Exception)
        {
            throw;
        }
    }

    public async Task<int> UpdateAsync(
        MIDIA_BASE midia,
        CancellationToken cancellationToken = default
    )
    {
        try
        {
            object parameters = new { idParam = midia.ID, idregistroParam = midia.ID_REGISTRO, };
            var sql =
                @"					UPDATE midia SET
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
