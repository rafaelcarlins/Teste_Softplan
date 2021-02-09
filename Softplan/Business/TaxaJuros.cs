
using Newtonsoft.Json;
using Softplan.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Threading.Tasks;

namespace Softplan.Business
{
    public class TaxaJuros :ITaxaJuros
    {
        HttpClient client = new HttpClient();

        public TaxaJuros()
        {
            client.BaseAddress = new Uri("https://localhost:44395/");//localhost

            client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));

        }

        public async Task<decimal> RetornoTaxaJuros()
        {
            HttpResponseMessage response = await client.GetAsync("/api/taxajuros");//endereço para acessar
            if (response.IsSuccessStatusCode)
            {
                var dados = await response.Content.ReadAsStringAsync();
                decimal ret = JsonConvert.DeserializeObject<decimal>(dados);
                return ret;
            }
            return 0;
        }
    }
}
