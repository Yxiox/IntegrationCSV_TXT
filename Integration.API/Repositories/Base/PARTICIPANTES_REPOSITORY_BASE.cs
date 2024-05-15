using System;
using System.Collections.Generic;
using System.Data;
using System.Threading.Tasks;
using Dapper;
using FluentValidation;
using Integration.API.Entities.Base;
using Integration.API.Repositories.Base.Interfaces;
using Microsoft.Extensions.Configuration;

// File Auto Generated. DOT NOT MODIFY
namespace Integration.API.Repositories.Base;

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
        var transaction = _connection.BeginTransaction();
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

                transaction.Commit();
                return affectedRows;
            }
        }
        catch (Exception)
        {
            transaction.Rollback();
            throw;
        }
    }

    public async Task<int> InsertAsync(
        PARTICIPANTES_BASE participantes,
        CancellationToken cancellationToken = default
    )
    {
        var transaction = _connection.BeginTransaction();
        try
        {
            object parameters = new
            {
                nomeParam = participantes.NOME,
                dataregistroParam = participantes.DATAREGISTRO,
                datainativacaoParam = participantes.DATAINATIVACAO,
            };
            var sql =
                @"					INSERT INTO participantes
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
            using (_connection)
            {
                CommandDefinition command =
                    new(sql, parameters, cancellationToken: cancellationToken);
                var affectedRows = await _connection.ExecuteAsync(command);

                transaction.Commit();
                return affectedRows;
            }
        }
        catch (Exception)
        {
            transaction.Rollback();
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
        int id,
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
        var transaction = _connection.BeginTransaction();
        try
        {
            object parameters = new
            {
                idParam = participantes.ID,
                nomeParam = participantes.NOME,
                dataregistroParam = participantes.DATAREGISTRO,
                datainativacaoParam = participantes.DATAINATIVACAO,
            };
            var sql =
                @"					UPDATE participantes SET
                    NOME = @nomeParam
                    ,DATAREGISTRO = @dataregistroParam
                    ,DATAINATIVACAO = @datainativacaoParam
                     WHERE ID = @idParam;
";
            using (_connection)
            {
                CommandDefinition command =
                    new(sql, parameters, cancellationToken: cancellationToken);
                var affectedRows = await _connection.ExecuteAsync(command);

                transaction.Commit();
                return affectedRows;
            }
        }
        catch (Exception)
        {
            transaction.Rollback();
            throw;
        }
    }
}
