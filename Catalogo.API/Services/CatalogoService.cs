using Catalogo.API.Entities;
using Catalogo.API.Entities.Base;
using Catalogo.API.Properties.Dto;
using Catalogo.API.Repositories.Interfaces;
using Integration.API.Repositories.Interfaces;
using Integration.Shared.Exceptions;
using Integration.Shared.Extensions;
using System.Text;
using System.Xml;

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

    public async Task<CatalogoDto?> GetByIdAsync(string id, CancellationToken cancellation = default)
    {
        var catalogo = await _catalogo_repository.GetByIdAsync(id, cancellation);
        return catalogo is null ? null : await ToDTO(catalogo);
    }

    public async Task<IEnumerable<CatalogoDto>> GetAllAsync(CancellationToken cancellation = default)
    {
        var catalogos = await _catalogo_repository.GetAllAsync(cancellation);

        return await Task.WhenAll(catalogos.Select(async catalogo => await ToDTO(catalogo)));
    }

    public async Task<string> GetNumberAsFullText(int number)
    {
        string url = "https://www.dataaccess.com/webservicesserver/numberconversion.wso";

        var soapEnvelope =
                    @$"<?xml version=""1.0"" encoding=""utf-8""?>
            <soap:Envelope xmlns:soap=""http://schemas.xmlsoap.org/soap/envelope/"">
              <soap:Body>
                <NumberToWords xmlns=""http://www.dataaccess.com/webservicesserver/"">
                  <ubiNum>{number}</ubiNum>
                </NumberToWords>
              </soap:Body>
            </soap:Envelope>";

        var content = new StringContent(soapEnvelope, Encoding.UTF8, "text/xml");

        using (var httpClient = new HttpClient())
        {
            var response = await httpClient.PostAsync(url, content);
            string result = await response.Content.ReadAsStringAsync();

            XmlDocument doc = new XmlDocument();
            doc.LoadXml(result);

            // Namespace Manager para lidar com os namespaces do XML
            XmlNamespaceManager nsmgr = new XmlNamespaceManager(doc.NameTable);
            nsmgr.AddNamespace("soap", "http://schemas.xmlsoap.org/soap/envelope/");
            nsmgr.AddNamespace("web", "http://www.dataaccess.com/webservicesserver/");

            // Selecionar o nó desejado usando XPath
            XmlNode? resultNode = doc.SelectSingleNode("//soap:Body/web:NumberToWordsResponse/web:NumberToWordsResult", nsmgr);

            if (resultNode is not null)
            {
                return resultNode.InnerText;
            }
            else
            {
                throw new NotFoundException("Não foi possível converter o número");
            }
        }
    }

    private async Task<CatalogoDto> ToDTO(CATALOGO_BASE catalogo)
    {
        var numberFullText = await GetNumberAsFullText(catalogo.PRECO);

        return new CatalogoDto()
        {
            Catalogo = catalogo,
            PrecoExtenso = numberFullText
        };
    }
}
