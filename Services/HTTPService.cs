using System.Net;
using System.Net.Http;
using System.Threading.Tasks;

namespace StackoverflowReviewApp.Services
{
    public class HTTPService
    {
        protected readonly int MAX_PAGE_SIZE = 100;
        private HttpClient client;

        public HTTPService()
        {
            HttpClientHandler handler = new HttpClientHandler()
            {
                AutomaticDecompression = DecompressionMethods.GZip | DecompressionMethods.Deflate
            };
            client = new HttpClient(handler);
        }

        protected async Task<T> Get<T>(string path) where T : class
        {
            HttpResponseMessage response = await client.GetAsync(path);
            if (response.IsSuccessStatusCode)
            {
                return await response.Content.ReadAsAsync<T>();
            }
            return null;
        }
    }
}
