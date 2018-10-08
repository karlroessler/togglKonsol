using System;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;

namespace TogglKonsol
{
    public class GetConnectionToggl : IGetConnectionToggl
    {
        public string Get(string ApiToken, string url)
        {
            string userpass = ApiToken + ":api_token";
            string userpassB64 = Convert.ToBase64String(Encoding.Default.GetBytes(userpass.Trim()));
            string authHeader = "Basic " + userpassB64;
            HttpClient httpClient = new HttpClient();
            httpClient.DefaultRequestHeaders.Authorization = new AuthenticationHeaderValue("Basic", userpassB64);
            Task<HttpResponseMessage> task = httpClient.GetAsync(url);
            task.Wait();
            HttpResponseMessage result = task.Result;
            StreamContent content = result.Content as StreamContent;
            var readAsStringTask = content.ReadAsStringAsync();
            readAsStringTask.Wait();
            string contentStringResult = readAsStringTask.Result;
            return contentStringResult;
        }
    }
}
