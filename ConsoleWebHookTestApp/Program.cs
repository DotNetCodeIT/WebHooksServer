using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleWebHookTestApp
{
    class Program
    {
        static void Main(string[] args)
        {

            do
            {
                Console.WriteLine("Inserisci il tuo nome:");
                string nome = Console.ReadLine();
                using (HttpClient client = new HttpClient())
                {
                    string baseUrl = "https://azurefunct1.azurewebsites.net";
                    string requestUrl = "api/TestHttpTrigger?code=8xhDzFXic3fxvTb0UgqEa0vBtESCh9indEmgDSdbab39/AoxSQr1oQ==";
                    string jsonData = $"{{name:'{nome}'}}";

                    client.BaseAddress = new Uri(baseUrl);

                    HttpContent content = new StringContent(jsonData, Encoding.UTF8, "application/json");
                    HttpResponseMessage result = client.PostAsync(requestUrl, content).Result;

                    if (result.IsSuccessStatusCode)
                    {
                        Console.WriteLine(result.Content.ReadAsStringAsync().Result);
                    }
                    else
                    {
                        Console.WriteLine("Error: {0}", result.StatusCode);
                    }
                }
                Console.WriteLine("Scrivi exit per uscire");
            } while (Console.ReadLine() != "exit");




        }
    }
}