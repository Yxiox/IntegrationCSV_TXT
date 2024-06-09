namespace Integration.Shared.Consts;
public class IntegrationAPI
{
    public const string BASE_URL = "https://localhost:7283";
    public const string CATEGORIA = $"{BASE_URL}/categoria";
    public const string CLASSIFICACAO = $"{BASE_URL}/classificacao";
    public const string GENERO = $"{BASE_URL}/genero";
    public const string MIDIA = $"{BASE_URL}/midia";
    public const string PARTICIPANTES = $"{BASE_URL}/participante";
    public const string TIPO_MIDIA = $"{BASE_URL}/tipoMidia";

    public static string ById(string url, string id) => $"{url}/{id}";
}
