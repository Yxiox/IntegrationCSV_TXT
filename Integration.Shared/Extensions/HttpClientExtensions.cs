using Integration.Shared.Api;
using System.Net.Http.Json;

namespace Integration.Shared.Extensions;
public static class HttpClientExtensions
{
    public static async Task<T?> FromJsonAsync<T>(this HttpClient httpClient, string resource, string id, string text, CancellationToken cancellationToken = default)
    {
        try
        {
            var response = await httpClient.GetFromJsonAsync<T>(ApiHelper.ById(resource, id), cancellationToken);
            return response;
        }
        catch (Exception ex)
        {
            if (text is not null) throw new Exception(text, ex);
            throw new Exception($"Não encontrado registro com id '{id}'", ex);
        }
    }
}
