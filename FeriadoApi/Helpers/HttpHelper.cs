using System.Net.Http.Headers;
using System.Text;

namespace FeriadoApi.Helpers
{
    public static class HttpHelper
    {
        public static async Task<HttpResponseMessage> SendRequestRaw(string path, HttpMethod method, AuthenticationHeaderValue authentication = null, string content = null, string queryString = null)
        {
            using (var client = new HttpClient())
            {
                if (authentication != null)
                    client.DefaultRequestHeaders.Authorization = authentication;

                var builder = new UriBuilder(path);

                if (queryString != null)
                    builder.Query += queryString;

                var httpRequest = new HttpRequestMessage
                {
                    Method = method,
                    RequestUri = new Uri(builder.ToString())
                };

                if (content != null)
                    httpRequest.Content = new StringContent(content, Encoding.UTF8, "application/json");

                var resultado = await client.SendAsync(httpRequest);

                return resultado;
            }
        }
    }
}