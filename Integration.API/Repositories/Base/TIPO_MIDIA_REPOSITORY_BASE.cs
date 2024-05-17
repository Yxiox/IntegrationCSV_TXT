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

public class TIPO_MIDIA_REPOSITORY_BASE : ITIPO_MIDIA_REPOSITORY_BASE
{
    private readonly IDbConnection _connection;

    public TIPO_MIDIA_REPOSITORY_BASE(IDbConnection connection)
    {
        _connection = connection;
    }

    public async Task<int> DeleteAsync(
        TIPO_MIDIA_BASE tipo_midia,
        CancellationToken cancellationToken = default
    )
    {
        if (_connection.State == ConnectionState.Closed)
            _connection.Open();
        var transaction = _connection.BeginTransaction();
        try
        {
            object parameters = new { idParam = tipo_midia.ID };
            var sql =
                @"DELETE FROM tipo_midia
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
        TIPO_MIDIA_BASE tipo_midia,
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
                nomeParam = tipo_midia.NOME,
                dataregistroParam = tipo_midia.DATAREGISTRO,
                datainativacaoParam = tipo_midia.DATAINATIVACAO,
            };
            var sql =
                @"					INSERT INTO tipo_midia
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

    public async Task<IEnumerable<TIPO_MIDIA_BASE>> GetAllAsync(
        CancellationToken cancellationToken = default
    )
    {
        try
        {
            var sql = @"SELECT * FROM tipo_midia";
            using (_connection)
            {
                CommandDefinition command = new(sql, cancellationToken: cancellationToken);
                return await _connection.QueryAsync<TIPO_MIDIA_BASE>(command);
            }
        }
        catch (Exception)
        {
            throw;
        }
    }

    public async Task<TIPO_MIDIA_BASE?> GetByIdAsync(
        string id,
        CancellationToken cancellationToken = default
    )
    {
        try
        {
            object parameters = new { idParam = id };
            var sql = @"SELECT * FROM tipo_midia WHERE ID = @idParam";
            using (_connection)
            {
                CommandDefinition command =
                    new(sql, parameters, cancellationToken: cancellationToken);
                return await _connection.QuerySingleOrDefaultAsync<TIPO_MIDIA_BASE>(command);
            }
        }
        catch (Exception)
        {
            throw;
        }
    }

    public async Task<int> UpdateAsync(
        TIPO_MIDIA_BASE tipo_midia,
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
                idParam = tipo_midia.ID,
                nomeParam = tipo_midia.NOME,
                dataregistroParam = tipo_midia.DATAREGISTRO,
                datainativacaoParam = tipo_midia.DATAINATIVACAO,
            };
            var sql =
                @"					UPDATE tipo_midia SET
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
