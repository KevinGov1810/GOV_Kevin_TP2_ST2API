using TP2.Deserialized_Classes;
using Newtonsoft.Json;

namespace TP2
{
    public class Http
    {
        public static async Task<Root> Retrieve(string url)
        {
            var client = new HttpClient();
            var request = new HttpRequestMessage
            {
                Method = HttpMethod.Get,
                RequestUri =
                    new Uri(url)
            };
            using (var response = await client.SendAsync(request))
            {
                response.EnsureSuccessStatusCode();
                var stringResult = await response.Content.ReadAsStringAsync();
                var obj = JsonConvert.DeserializeObject<Root>(stringResult);
                return obj ?? throw new HttpRequestException();
            }
        }
    }
}