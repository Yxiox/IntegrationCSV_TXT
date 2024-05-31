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

public class CLASSIFICACAO_REPOSITORY_BASE : ICLASSIFICACAO_REPOSITORY_BASE
{
    private readonly IDbConnection _connection;

    public CLASSIFICACAO_REPOSITORY_BASE(IDbConnection connection)
    {
        _connection = connection;
    }

    public async Task<int> DeleteAsync(
        CLASSIFICACAO_BASE classificacao,
        CancellationToken cancellationToken = default
    )
    {
        try
        {
            object parameters = new { idParam = classificacao.ID };
            var sql =
                @"DELETE FROM classificacao
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
        CLASSIFICACAO_BASE classificacao,
        CancellationToken cancellationToken = default
    )
    {
        try
        {
            object parameters = new { };
            var sql =
                @"					INSERT INTO classificacao
					(
					)
					VALUES
					(
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

    public async Task<IEnumerable<CLASSIFICACAO_BASE>> GetAllAsync(
        CancellationToken cancellationToken = default
    )
    {
        try
        {
            var sql = @"SELECT * FROM classificacao";
            using (_connection)
            {
                CommandDefinition command = new(sql, cancellationToken: cancellationToken);
                return await _connection.QueryAsync<CLASSIFICACAO_BASE>(command);
            }
        }
        catch (Exception)
        {
            throw;
        }
    }

    public async Task<CLASSIFICACAO_BASE?> GetByIdAsync(
        string id,
        CancellationToken cancellationToken = default
    )
    {
        try
        {
            object parameters = new { idParam = id };
            var sql = @"SELECT * FROM classificacao WHERE ID = @idParam";
            using (_connection)
            {
                CommandDefinition command =
                    new(sql, parameters, cancellationToken: cancellationToken);
                return await _connection.QuerySingleOrDefaultAsync<CLASSIFICACAO_BASE>(command);
            }
        }
        catch (Exception)
        {
            throw;
        }
    }

    public async Task<int> UpdateAsync(
        CLASSIFICACAO_BASE classificacao,
        CancellationToken cancellationToken = default
    )
    {
        try
        {
            object parameters = new { idParam = classificacao.ID, };
            var sql =
                @"					UPDATE classificacao SET
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
