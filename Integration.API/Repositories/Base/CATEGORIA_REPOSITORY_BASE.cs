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

public class CATEGORIA_REPOSITORY_BASE : ICATEGORIA_REPOSITORY_BASE
{
    private readonly IDbConnection _connection;

    public CATEGORIA_REPOSITORY_BASE(IDbConnection connection)
    {
        _connection = connection;
    }

    public async Task<int> DeleteAsync(
        CATEGORIA_BASE categoria,
        CancellationToken cancellationToken = default
    )
    {
        if (_connection.State == ConnectionState.Closed)
            _connection.Open();
        var transaction = _connection.BeginTransaction();
        try
        {
            object parameters = new { idParam = categoria.ID };
            var sql =
                @"DELETE FROM categoria
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
        CATEGORIA_BASE categoria,
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
                nomeParam = categoria.NOME,
                dataregistroParam = categoria.DATAREGISTRO,
                datainativacaoParam = categoria.DATAINATIVACAO,
            };
            var sql =
                @"					INSERT INTO categoria
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

    public async Task<IEnumerable<CATEGORIA_BASE>> GetAllAsync(
        CancellationToken cancellationToken = default
    )
    {
        try
        {
            var sql = @"SELECT * FROM categoria";
            using (_connection)
            {
                CommandDefinition command = new(sql, cancellationToken: cancellationToken);
                return await _connection.QueryAsync<CATEGORIA_BASE>(command);
            }
        }
        catch (Exception)
        {
            throw;
        }
    }

    public async Task<CATEGORIA_BASE?> GetByIdAsync(
        string id,
        CancellationToken cancellationToken = default
    )
    {
        try
        {
            object parameters = new { idParam = id };
            var sql = @"SELECT * FROM categoria WHERE ID = @idParam";
            using (_connection)
            {
                CommandDefinition command =
                    new(sql, parameters, cancellationToken: cancellationToken);
                return await _connection.QuerySingleOrDefaultAsync<CATEGORIA_BASE>(command);
            }
        }
        catch (Exception)
        {
            throw;
        }
    }

    public async Task<int> UpdateAsync(
        CATEGORIA_BASE categoria,
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
                idParam = categoria.ID,
                nomeParam = categoria.NOME,
                dataregistroParam = categoria.DATAREGISTRO,
                datainativacaoParam = categoria.DATAINATIVACAO,
            };
            var sql =
                @"					UPDATE categoria SET
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
