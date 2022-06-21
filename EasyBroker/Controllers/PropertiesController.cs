using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;

namespace EasyBroker.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class PropertiesController : ControllerBase
    {
      


        public PropertiesController()
        {
        }

      

        [HttpGet(Name = "GetPropertiesTitle")]
        public async Task<IEnumerable<string>> GetAsync()
        {
            try { 
            var serviceProvider = new ServiceCollection().AddHttpClient().BuildServiceProvider();

            var httpClientFactory = serviceProvider.GetService<IHttpClientFactory>();

            var client = httpClientFactory.CreateClient();
            List<string> titles = new List<string>();
            client.BaseAddress = new Uri("https://api.stagingeb.com");
            client.DefaultRequestHeaders.Add("X-Authorization", "l7u502p8v46ba3ppgvj5y2aad50lb9");
            var httpRequest = await client.GetAsync("/v1/properties");
           var properties = JsonConvert.DeserializeObject<Properties>(await httpRequest.Content.ReadAsStringAsync());
            
            return properties.content.Select(x=>x.title).ToList();
            }
            catch (Exception ex)
            {
               return null;
            }
        }
    }
}