using System;
using System.Collections.Generic;
using System.Data;
using System.Threading.Tasks;
using Dapper;
using FluentValidation;
using Integration.API.Entities.Base;
using Integration.API.Repositories.Base.Interfaces;
using Integration.API.Repositories.Shared;
using Microsoft.Extensions.Configuration;

// File Auto Generated. DOT NOT MODIFY
namespace Integration.API.Repositories.Base;

public class MIDIA_REPOSITORY_BASE : Repository, IMIDIA_REPOSITORY_BASE
{
    private IDbConnection _connection;

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
        MIDIA_BASE midia,
        CancellationToken cancellationToken = default
    )
    {
        try
        {
            object parameters = new
            {
                nomeParam = midia.NOME,
                dataregistroParam = midia.DATAREGISTRO,
                datainativacaoParam = midia.DATAINATIVACAO,
            };
            var sql =
                @"					INSERT INTO midia
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

    public async Task<IEnumerable<MIDIA_BASE>> GetAllAsync(
        CancellationToken cancellationToken = default
    )
    {
        try
        {
            var sql = @"SELECT * FROM midia";
            using (_connection = Create())
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
            using (_connection = Create())
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
            object parameters = new
            {
                idParam = midia.ID,
                nomeParam = midia.NOME,
                dataregistroParam = midia.DATAREGISTRO,
                datainativacaoParam = midia.DATAINATIVACAO,
            };
            var sql =
                @"					UPDATE midia SET
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
