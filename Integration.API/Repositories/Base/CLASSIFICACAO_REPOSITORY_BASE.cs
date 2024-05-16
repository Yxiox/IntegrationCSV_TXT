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
        if (_connection.State == ConnectionState.Closed)
            _connection.Open();
        var transaction = _connection.BeginTransaction();
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
        CLASSIFICACAO_BASE classificacao,
        CancellationToken cancellationToken = default
    )
    {
        if (_connection.State == ConnectionState.Closed)
            _connection.Open();
        var transaction = _connection.BeginTransaction();
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
        int id,
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
        if (_connection.State == ConnectionState.Closed)
            _connection.Open();
        var transaction = _connection.BeginTransaction();
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
