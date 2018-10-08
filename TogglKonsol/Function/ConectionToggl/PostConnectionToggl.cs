using System;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;

namespace TogglKonsol
{
    class PostConnectionToggl : IPostConnectionToggl
    {
        public void Post(string apiToken, string url, string json)
        {
            string userpass = apiToken + ":api_token";
            string userpassB64 = Convert.ToBase64String(Encoding.Default.GetBytes(userpass.Trim()));
            json = "{\"project\":{\"name\":\"An awesome project von Karl\",\"wid\":2875373,\"is_private\":true,\"template_id\":131984410}}";
            HttpClient httpClient = new HttpClient();
            httpClient.DefaultRequestHeaders.Authorization = new AuthenticationHeaderValue("Basic", userpassB64);
            StringContent stringContent = new StringContent(json);
            stringContent.Headers.ContentType = new MediaTypeHeaderValue("application/json");
            Task<HttpResponseMessage> task = httpClient.PostAsync(url, stringContent);
            task.Wait();
            HttpResponseMessage result = task.Result;
            StreamContent content = result.Content as StreamContent;
            var readAsStringTask = content.ReadAsStringAsync();
            readAsStringTask.Wait();
            string contentStringResult = readAsStringTask.Result;
        }
    }
}
