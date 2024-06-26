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
        if (_connection.State == ConnectionState.Closed)
            _connection.Open();
        var transaction = _connection.BeginTransaction();
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
        GENERO_BASE genero,
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
        if (_connection.State == ConnectionState.Closed)
            _connection.Open();
        var transaction = _connection.BeginTransaction();
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
