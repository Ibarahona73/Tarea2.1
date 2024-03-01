using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
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
            List<Models.Country> countries = new List<Models.Country>();

            try
            {
                using (HttpClient client = new HttpClient())
                {
                    HttpResponseMessage responseMessage = await client.GetAsync(Controller.Apirest.ACountries);

                    if (responseMessage != null && responseMessage.IsSuccessStatusCode)
                    {
                        var result = await responseMessage.Content.ReadAsStringAsync();
                        countries = JsonConvert.DeserializeObject<List<Models.Country>>(result);
                    }
                    else
                    {
                        throw new Exception("La solicitud HTTP no fue exitosa.");
                    }
                }
                return countries;
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error: {ex}");
                throw;
            }
        }
    }

}