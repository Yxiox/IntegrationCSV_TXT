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

public class CLASSIFICACAO_REPOSITORY_BASE : Repository, ICLASSIFICACAO_REPOSITORY_BASE
{
    private IDbConnection _connection;

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
        CLASSIFICACAO_BASE classificacao,
        CancellationToken cancellationToken = default
    )
    {
        try
        {
            object parameters = new
            {
                nomeParam = classificacao.NOME,
                dataregistroParam = classificacao.DATAREGISTRO,
                datainativacaoParam = classificacao.DATAINATIVACAO,
            };
            var sql =
                @"					INSERT INTO classificacao
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

    public async Task<IEnumerable<CLASSIFICACAO_BASE>> GetAllAsync(
        CancellationToken cancellationToken = default
    )
    {
        try
        {
            var sql = @"SELECT * FROM classificacao WHERE DATAINATIVACAO IS NULL";
            using (_connection = Create())
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
            using (_connection = Create())
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
            object parameters = new
            {
                idParam = classificacao.ID,
                nomeParam = classificacao.NOME,
                dataregistroParam = classificacao.DATAREGISTRO,
                datainativacaoParam = classificacao.DATAINATIVACAO,
            };
            var sql =
                @"					UPDATE classificacao SET
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
