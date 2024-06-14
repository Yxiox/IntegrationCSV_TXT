namespace Integration.Shared.Api;

public static class ApiHelper
{
    public static string ById(string url, string id) => $"{url}/{id}";
}
