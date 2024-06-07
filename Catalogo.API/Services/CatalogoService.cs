using Catalogo.API.Entities;
using Catalogo.API.Entities.Base;
using Catalogo.API.Repositories.Interfaces;
using Integration.API.Repositories.Interfaces;
using Integration.Shared.Extensions;
using System.Net;
using System.Xml.Linq;

namespace Catalogo.API.Services;

public class CatalogoService : ICatalogoService
{
    private readonly ICATALOGO_REPOSITORY _catalogo_repository;
    private readonly IGENERO_REPOSITORY _genero_repository;
    private readonly ICATEGORIA_REPOSITORY _categoria_repository;
    private readonly ICLASSIFICACAO_REPOSITORY _classificacao_repository;
    private readonly IMIDIA_REPOSITORY _midia_repository;
    private readonly IPARTICIPANTES_REPOSITORY _participantes_repository;
    private readonly ITIPO_MIDIA_REPOSITORY _tipo_midia_repository;

    public CatalogoService(ICATALOGO_REPOSITORY catalogo_repository,
                           IGENERO_REPOSITORY genero_repository,
                           ICATEGORIA_REPOSITORY categoria_repository,
                           ICLASSIFICACAO_REPOSITORY classificacao_repository,
                           IMIDIA_REPOSITORY midia_repository,
                           IPARTICIPANTES_REPOSITORY participantes_repository,
                           ITIPO_MIDIA_REPOSITORY tipo_midia_repository)
    {
        _catalogo_repository = catalogo_repository;
        _genero_repository = genero_repository;
        _categoria_repository = categoria_repository;
        _classificacao_repository = classificacao_repository;
        _midia_repository = midia_repository;
        _participantes_repository = participantes_repository;
        _tipo_midia_repository = tipo_midia_repository;
    }

    public async Task UpsertAsync(CATALOGO catalogo, bool isInsert, CancellationToken cancellationToken = default)
    {
        if (!isInsert)
        {
            var catalogoExistente = await _catalogo_repository.GetByIdAsync(catalogo.ID, cancellationToken);
            catalogoExistente.ThrowIfNull("catálogo não encontrado");
        }
        var genero = await _genero_repository.GetByIdAsync(catalogo.ID_GENERO, cancellationToken);
        var categoria = await _categoria_repository.GetByIdAsync(catalogo.ID_CATEGORIA, cancellationToken);
        var classificacao = await _classificacao_repository.GetByIdAsync(catalogo.ID_CLASSIFICACAO, cancellationToken);
        var midia = await _midia_repository.GetByIdAsync(catalogo.ID_MIDIA, cancellationToken);
        var participante = await _participantes_repository.GetByIdAsync(catalogo.ID_PARTICIPANTE, cancellationToken);
        var tipoMidia = await _tipo_midia_repository.GetByIdAsync(catalogo.ID_TIPO_MIDIA, cancellationToken);

        genero.ThrowIfNull("Gênero não encontrado");
        categoria.ThrowIfNull("Categoria não encontrada");
        classificacao.ThrowIfNull("Classificação não encontrada");
        midia.ThrowIfNull("Mídia não encontrada");
        participante.ThrowIfNull("Participante não encontrado");
        tipoMidia.ThrowIfNull("Tipo Mídia não encontrado");

        if (isInsert) await _catalogo_repository.InsertAsync(catalogo, cancellationToken);
        else await _catalogo_repository.UpdateAsync(catalogo, cancellationToken);
    }

    public async Task DeleteAsync(string id, CancellationToken cancellation = default)
    {
        var entity = await _catalogo_repository.GetByIdAsync(id, cancellation).ThrowIfNull("Catálogo não encontrado");
        await _catalogo_repository.DeleteAsync(entity!, cancellation);
    }

    public async Task<CATALOGO_BASE?> GetByIdAsync(string id, CancellationToken cancellation = default)
    {
        var r = GetNumberAsFullText(45);
        return await _catalogo_repository.GetByIdAsync(id, cancellation);
    }

    public async Task<IEnumerable<CATALOGO_BASE>> GetAllAsync(CancellationToken cancellation = default)
    {
        return await _catalogo_repository.GetAllAsync(cancellation);
    }

    public string GetNumberAsFullText(int number)
    {
        WebRequest request = WebRequest.Create("https://www.dataaccess.com/webservicesserver/numberconversion.wso");

        WebResponse response = request.GetResponse();
        using (var sr = new System.IO.StreamReader(response.GetResponseStream()))
        {
            XDocument xmlDoc = new XDocument();
            xmlDoc = XDocument.Parse(sr.ReadToEnd());
        }

        return response.ToString();
    }
}
