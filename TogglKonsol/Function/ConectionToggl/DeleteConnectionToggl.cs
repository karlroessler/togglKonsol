using System;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;

namespace TogglKonsol
{
    class DeleteConnectionToggl : IDeleteConnectionToggl
    {
        public void Delete(string ApiToken, string url)
        {
            string userpass = ApiToken + ":api_token";
            string userpassB64 = Convert.ToBase64String(Encoding.Default.GetBytes(userpass.Trim()));
            HttpClient httpClient = new HttpClient();
            httpClient.DefaultRequestHeaders.Authorization = new AuthenticationHeaderValue("Basic", userpassB64);
            Task<HttpResponseMessage> task = httpClient.DeleteAsync(url);
            task.Wait();
            HttpResponseMessage result = task.Result;
            StreamContent content = result.Content as StreamContent;
            var readAsStringTask = content.ReadAsStringAsync();
            readAsStringTask.Wait();
            string contentStringResult = readAsStringTask.Result;
        }
    }
}
