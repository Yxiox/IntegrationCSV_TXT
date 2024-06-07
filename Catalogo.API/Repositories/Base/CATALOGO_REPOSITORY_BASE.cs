using Catalogo.API.Entities.Base;
using Catalogo.API.Repositories.Base.Interfaces;
using Catalogo.API.Repositories.Base.Shared;
using Dapper;

// File Auto Generated. DOT NOT MODIFY
namespace Catalogo.API.Repositories.Base;

public class CATALOGO_REPOSITORY_BASE : Repository, ICATALOGO_REPOSITORY_BASE
{
    public async Task<int> DeleteAsync(
        CATALOGO_BASE catalogo,
        CancellationToken cancellationToken = default
    )
    {
        try
        {
            object parameters = new { idParam = catalogo.ID };
            var sql =
                @"DELETE FROM catalogo
WHERE ID = @idParam
";
            using var conn = Open();
            CommandDefinition command = new(sql, parameters, cancellationToken: cancellationToken);
            var affectedRows = await conn.ExecuteAsync(command);

            return affectedRows;
        }
        catch (Exception)
        {
            throw;
        }
    }

    public async Task<int> InsertAsync(
        CATALOGO_BASE catalogo,
        CancellationToken cancellationToken = default
    )
    {
        try
        {
            object parameters = new
            {
                idgeneroParam = catalogo.ID_GENERO,
                idmidiaParam = catalogo.ID_MIDIA,
                idcategoriaParam = catalogo.ID_CATEGORIA,
                idtipomidiaParam = catalogo.ID_TIPO_MIDIA,
                idclassificacaoParam = catalogo.ID_CLASSIFICACAO,
                idparticipanteParam = catalogo.ID_PARTICIPANTE,
                precoParam = catalogo.PRECO,
                caminhoParam = catalogo.CAMINHO,
            };
            var sql =
                @"					INSERT INTO catalogo
					(
                    ID
					,ID_GENERO
					,ID_MIDIA
					,ID_CATEGORIA
					,ID_TIPO_MIDIA
					,ID_CLASSIFICACAO
					,ID_PARTICIPANTE
					,PRECO
					,CAMINHO
					)
					VALUES
					(
                    (SELECT UUID() FROM DUAL)
					,@idgeneroParam
					,@idmidiaParam
					,@idcategoriaParam
					,@idtipomidiaParam
					,@idclassificacaoParam
					,@idparticipanteParam
					,@precoParam
					,@caminhoParam
					)
";
            using var conn = Open();
            CommandDefinition command = new(sql, parameters, cancellationToken: cancellationToken);
            var affectedRows = await conn.ExecuteAsync(command);

            return affectedRows;
        }
        catch (Exception)
        {
            throw;
        }
    }

    public async Task<IEnumerable<CATALOGO_BASE>> GetAllAsync(
        CancellationToken cancellationToken = default
    )
    {
        try
        {
            var sql = @"SELECT * FROM catalogo";
            using var conn = Open();
            CommandDefinition command = new(sql, cancellationToken: cancellationToken);
            return await conn.QueryAsync<CATALOGO_BASE>(command);
        }
        catch (Exception)
        {
            throw;
        }
    }

    public async Task<CATALOGO_BASE?> GetByIdAsync(
        string id,
        CancellationToken cancellationToken = default
    )
    {
        try
        {
            object parameters = new { idParam = id };
            var sql = @"SELECT * FROM catalogo WHERE ID = @idParam";
            using var conn = Open();
            CommandDefinition command = new(sql, parameters, cancellationToken: cancellationToken);
            return await conn.QuerySingleOrDefaultAsync<CATALOGO_BASE>(command);
        }
        catch (Exception)
        {
            throw;
        }
    }

    public async Task<int> UpdateAsync(
        CATALOGO_BASE catalogo,
        CancellationToken cancellationToken = default
    )
    {
        try
        {
            object parameters = new
            {
                idParam = catalogo.ID,
                idgeneroParam = catalogo.ID_GENERO,
                idmidiaParam = catalogo.ID_MIDIA,
                idcategoriaParam = catalogo.ID_CATEGORIA,
                idtipomidiaParam = catalogo.ID_TIPO_MIDIA,
                idclassificacaoParam = catalogo.ID_CLASSIFICACAO,
                idparticipanteParam = catalogo.ID_PARTICIPANTE,
                precoParam = catalogo.PRECO,
                caminhoParam = catalogo.CAMINHO,
            };
            var sql =
                @"					UPDATE catalogo SET
                    ID_GENERO = @idgeneroParam
                    ,ID_MIDIA = @idmidiaParam
                    ,ID_CATEGORIA = @idcategoriaParam
                    ,ID_TIPO_MIDIA = @idtipomidiaParam
                    ,ID_CLASSIFICACAO = @idclassificacaoParam
                    ,ID_PARTICIPANTE = @idparticipanteParam
                    ,PRECO = @precoParam
                    ,CAMINHO = @caminhoParam
                     WHERE ID = @idParam;
";
            using var conn = Open();
            CommandDefinition command = new(sql, parameters, cancellationToken: cancellationToken);
            var affectedRows = await conn.ExecuteAsync(command);

            return affectedRows;
        }
        catch (Exception)
        {
            throw;
        }
    }
}
