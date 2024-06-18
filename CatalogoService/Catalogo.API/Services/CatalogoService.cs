using Catalogo.API.Consts;
using Catalogo.API.Dto;
using Catalogo.API.Entities;
using Catalogo.API.Entities.Base;
using Catalogo.API.Repositories.Interfaces;
using Integration.Shared.Extensions;
using System.Text;
using System.Xml;

namespace Catalogo.API.Services;

public class CatalogoService : ICatalogoService
{
    private readonly ICATALOGO_REPOSITORY _catalogo_repository;
    private readonly HttpClient _httpClient;

    public CatalogoService(ICATALOGO_REPOSITORY catalogo_repository)
    {
        _catalogo_repository = catalogo_repository;
        _httpClient = new HttpClient();
    }

    public async Task UpsertAsync(CATALOGO catalogo, bool isInsert, CancellationToken cancellationToken = default)
    {
        if (!isInsert)
        {
            var catalogoExistente = await _catalogo_repository.GetByIdAsync(catalogo.ID, cancellationToken);
            catalogoExistente.ThrowIfNull("catálogo não encontrado");
        }

        var genero = await _httpClient.FromJsonAsync<GENERO>(IntegrationAPI.GENERO, catalogo.ID_GENERO, cancellationToken);
        var categoria = await _httpClient.FromJsonAsync<CATEGORIA>(IntegrationAPI.CATEGORIA, catalogo.ID_CATEGORIA, cancellationToken);
        var classificacao = await _httpClient.FromJsonAsync<CLASSIFICACAO>(IntegrationAPI.CLASSIFICACAO, catalogo.ID_CLASSIFICACAO, cancellationToken);
        var midia = await _httpClient.FromJsonAsync<MIDIA>(IntegrationAPI.MIDIA, catalogo.ID_MIDIA, cancellationToken);
        var participante = await _httpClient.FromJsonAsync<PARTICIPANTES>(IntegrationAPI.PARTICIPANTES, catalogo.ID_PARTICIPANTE, cancellationToken);
        var tipoMidia = await _httpClient.FromJsonAsync<TIPO_MIDIA>(IntegrationAPI.TIPO_MIDIA, catalogo.ID_TIPO_MIDIA, cancellationToken);

        VerifyNull(genero, categoria, classificacao, midia, participante, tipoMidia);

        if (isInsert) await _catalogo_repository.InsertAsync(catalogo, cancellationToken);
        else await _catalogo_repository.UpdateAsync(catalogo, cancellationToken);
    }

    private static void VerifyNull(GENERO_BASE? genero,
                                   CATEGORIA_BASE? categoria,
                                   CLASSIFICACAO_BASE? classificacao,
                                   MIDIA_BASE? midia,
                                   PARTICIPANTES_BASE? participante,
                                   TIPO_MIDIA_BASE? tipoMidia)
    {
        genero.ThrowIfNull("Gênero não encontrado");
        categoria.ThrowIfNull("Categoria não encontrada");
        classificacao.ThrowIfNull("Classificação não encontrada");
        midia.ThrowIfNull("Mídia não encontrada");
        participante.ThrowIfNull("Participante não encontrado");
        tipoMidia.ThrowIfNull("Tipo Mídia não encontrado");
    }

    public async Task DeleteAsync(string id, CancellationToken cancellation = default)
    {
        var entity = await _catalogo_repository.GetByIdAsync(id, cancellation).ThrowIfNull("Catálogo não encontrado");
        await _catalogo_repository.DeleteAsync(entity!, cancellation);
    }

    public async Task<CatalogoDto?> GetByIdAsync(string id, CancellationToken cancellationToken = default)
    {
        var catalogo = await _catalogo_repository.GetByIdAsync(id, cancellationToken);
        return catalogo is null ? null : await ToDTOAsync(catalogo, cancellationToken);
    }

    public async Task<IEnumerable<CatalogoDto>> GetAllAsync(CancellationToken cancellationToken = default)
    {
        var catalogos = await _catalogo_repository.GetAllAsync(cancellationToken);

        return await Task.WhenAll(catalogos.Select(async catalogo => await ToDTOAsync(catalogo, cancellationToken)));
    }

    public async Task<string> GetNumberAsFullTextAsync(int number)
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

            XmlDocument doc = new();
            doc.LoadXml(result);

            XmlNamespaceManager nsmgr = new(doc.NameTable);
            nsmgr.AddNamespace("soap", "http://schemas.xmlsoap.org/soap/envelope/");
            nsmgr.AddNamespace("web", "http://www.dataaccess.com/webservicesserver/");

            XmlNode? resultNode = doc.SelectSingleNode("//soap:Body/web:NumberToWordsResponse/web:NumberToWordsResult", nsmgr);

            resultNode.ThrowIfNull("Não foi possível converter o número");
            return resultNode!.InnerText;
        }
    }

    private async Task<CatalogoDto> ToDTOAsync(CATALOGO catalogo, CancellationToken cancellationToken)
    {
        var genero = await _httpClient.FromJsonAsync<GENERO>(IntegrationAPI.GENERO, catalogo.ID_GENERO, cancellationToken);
        var categoria = await _httpClient.FromJsonAsync<CATEGORIA>(IntegrationAPI.CATEGORIA, catalogo.ID_CATEGORIA, cancellationToken);
        var classificacao = await _httpClient.FromJsonAsync<CLASSIFICACAO>(IntegrationAPI.CLASSIFICACAO, catalogo.ID_CLASSIFICACAO, cancellationToken);
        var midia = await _httpClient.FromJsonAsync<MIDIA>(IntegrationAPI.MIDIA, catalogo.ID_MIDIA, cancellationToken);
        var participante = await _httpClient.FromJsonAsync<PARTICIPANTES>(IntegrationAPI.PARTICIPANTES, catalogo.ID_PARTICIPANTE, cancellationToken);
        var tipoMidia = await _httpClient.FromJsonAsync<TIPO_MIDIA>(IntegrationAPI.TIPO_MIDIA, catalogo.ID_TIPO_MIDIA, cancellationToken);

        VerifyNull(genero, categoria, classificacao, midia, participante, tipoMidia);

        catalogo.PrecoExtenso = await GetNumberAsFullTextAsync(catalogo.PRECO);

        return new CatalogoDto()
        {
            Genero = genero!,
            Categoria = categoria!,
            Classificacao = classificacao!,
            Midia = midia!,
            Participantes = participante!,
            TipoMidia = tipoMidia!,
            Catalogo = catalogo,
        };
    }
}
