using System;
using System.Collections.Generic;
using System.Data;
using System.Threading.Tasks;
using ApoioNegocio.Core.Entities.Base;
using ApoioNegocio.Core.Repositories.Base.Interfaces;
using ApoioNegocio.Core.Repositories.Shared;
using Dapper;
using FluentValidation;
using Microsoft.Extensions.Configuration;

// File Auto Generated. DOT NOT MODIFY
namespace ApoioNegocio.Core.Repositories.Base;

public class GENERO_REPOSITORY_BASE : Repository, IGENERO_REPOSITORY_BASE
{
    private IDbConnection _connection;

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
        GENERO_BASE genero,
        CancellationToken cancellationToken = default
    )
    {
        try
        {
            object parameters = new
            {
                nomeParam = genero.NOME,
                dataregistroParam = genero.DATAREGISTRO,
                datainativacaoParam = genero.DATAINATIVACAO,
            };
            var sql =
                @"					INSERT INTO genero
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

    public async Task<IEnumerable<GENERO_BASE>> GetAllAsync(
        CancellationToken cancellationToken = default
    )
    {
        try
        {
            var sql = @"SELECT * FROM genero WHERE DATAINATIVACAO IS NULL";
            using (_connection = Create())
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
            using (_connection = Create())
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
            object parameters = new
            {
                idParam = genero.ID,
                nomeParam = genero.NOME,
                dataregistroParam = genero.DATAREGISTRO,
                datainativacaoParam = genero.DATAINATIVACAO,
            };
            var sql =
                @"					UPDATE genero SET
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
