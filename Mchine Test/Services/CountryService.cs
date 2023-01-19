using Mchine_Test.ServicesInterface;
using Microsoft.AspNetCore.Mvc;
using static Mchine_Test.Services.CountryService;

namespace Mchine_Test.Services
{
    public class CountryService : ICountryService
    {
        public async Task<string> GetCountry()
        {

            using (StreamReader r = new StreamReader("Data/json.json"))
            {
                string json = r.ReadToEnd();
                return json;
            }

        }
    }

}
