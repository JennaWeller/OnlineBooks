using Microsoft.AspNetCore.Http;


namespace OnlineBooks.Infrastructure
{
    public static class UrlExtensions
    {   //path for string
        public static string PathAndQuery(this HttpRequest request) =>
            request.QueryString.HasValue ? $"{request.Path}{request.QueryString}" : request.Path.ToString();
    }
}
