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

public class PARTICIPANTES_REPOSITORY_BASE : IPARTICIPANTES_REPOSITORY_BASE
{
    private readonly IDbConnection _connection;

    public PARTICIPANTES_REPOSITORY_BASE(IDbConnection connection)
    {
        _connection = connection;
    }

    public async Task<int> DeleteAsync(
        PARTICIPANTES_BASE participantes,
        CancellationToken cancellationToken = default
    )
    {
        try
        {
            object parameters = new { idParam = participantes.ID };
            var sql =
                @"DELETE FROM participantes
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
        PARTICIPANTES_BASE participantes,
        CancellationToken cancellationToken = default
    )
    {
        try
        {
            object parameters = new { idregistroParam = participantes.ID_REGISTRO, };
            var sql =
                @"					INSERT INTO participantes
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

    public async Task<IEnumerable<PARTICIPANTES_BASE>> GetAllAsync(
        CancellationToken cancellationToken = default
    )
    {
        try
        {
            var sql = @"SELECT * FROM participantes";
            using (_connection)
            {
                CommandDefinition command = new(sql, cancellationToken: cancellationToken);
                return await _connection.QueryAsync<PARTICIPANTES_BASE>(command);
            }
        }
        catch (Exception)
        {
            throw;
        }
    }

    public async Task<PARTICIPANTES_BASE?> GetByIdAsync(
        string id,
        CancellationToken cancellationToken = default
    )
    {
        try
        {
            object parameters = new { idParam = id };
            var sql = @"SELECT * FROM participantes WHERE ID = @idParam";
            using (_connection)
            {
                CommandDefinition command =
                    new(sql, parameters, cancellationToken: cancellationToken);
                return await _connection.QuerySingleOrDefaultAsync<PARTICIPANTES_BASE>(command);
            }
        }
        catch (Exception)
        {
            throw;
        }
    }

    public async Task<int> UpdateAsync(
        PARTICIPANTES_BASE participantes,
        CancellationToken cancellationToken = default
    )
    {
        try
        {
            object parameters = new
            {
                idParam = participantes.ID,
                idregistroParam = participantes.ID_REGISTRO,
            };
            var sql =
                @"					UPDATE participantes SET
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
