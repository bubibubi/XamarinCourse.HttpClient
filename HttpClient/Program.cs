using System;
using System.Net;
using System.Net.Http;

namespace HttpClientTest
{
    class Program
    {
        static void Main(string[] args)
        {
            HttpClient client = new HttpClient();
            HttpResponseMessage response = client.GetAsync("http://www.google.com").Result;
            if (response.StatusCode == HttpStatusCode.OK)
            {
                string text = response.Content.ReadAsStringAsync().Result;
                Console.WriteLine(text);
            }
            else
            {
                Console.WriteLine("{0} - {1}", (int)response.StatusCode, response.ReasonPhrase);
            }

            Console.ReadLine();
        }
    }
}
