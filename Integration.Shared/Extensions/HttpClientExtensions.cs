using Integration.Shared.Api;
using System.Net.Http.Json;

namespace Integration.Shared.Extensions;
public static class HttpClientExtensions
{
    public static async Task<T?> FromJsonAsync<T>(this HttpClient httpClient, string resource, string id, CancellationToken cancellationToken = default)
    {
        return await httpClient.GetFromJsonAsync<T>(ApiHelper.ById(resource, id), cancellationToken);
    }
}
