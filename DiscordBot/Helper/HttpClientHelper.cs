using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Text;

namespace DiscordBot.Helper
{
    public class HttpClientHelper
    {
        public static string SendBasePostRequest(string url, StringContent content)
        {
            using (var client = new HttpClient())
            {
                var response = client.PostAsync(url, content).Result;
                var responseString = response.Content.ReadAsStringAsync().ToString();

                return responseString;
            }
        }

        public static string SendBasePostRequestAuthorization(string url, StringContent content, string accessToken)
        {
            using (var client = new HttpClient())
            {
                client.DefaultRequestHeaders.Add("Authorization", "Bearer " + accessToken);
                client.DefaultRequestHeaders.Add("Notion-Version", "2021-08-16");

                var response = client.PostAsync(url, content).Result;
                var responseString = response.Content.ReadAsStringAsync().Result;

                return responseString;
            }
        }
    }
}
