using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Threading.Tasks;

namespace Tarea2._1.Controller
{
    public class ControllerCountry
    {
        public async static Task<List<Models.Country>> GetCounties()
        {
            try
            {
                using (HttpClient client = new HttpClient())
                {
                    HttpResponseMessage responseMessage = await client.GetAsync("https://restcountries.com/v3.1/all");

                    if (responseMessage != null && responseMessage.IsSuccessStatusCode)
                    {
                        var result = await responseMessage.Content.ReadAsStringAsync();
                        return JsonConvert.DeserializeObject<List<Models.Country>>(result);
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            return null;
        }
    }
}
