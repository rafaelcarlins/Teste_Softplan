using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Softplan.Interfaces;

namespace Softplan.Controllers
{
    [Route("api")]
    [ApiController]
    public class CalcularJurosController : ControllerBase
    {

        private readonly ICalcularJuros _calcularJuros;
        private readonly ITaxaJuros _taxaJuros;

        public CalcularJurosController(ICalcularJuros calcularJuros, ITaxaJuros taxaJuros)
        {
            _calcularJuros = calcularJuros;
            _taxaJuros = taxaJuros;
        }

        
        [Route("calculajuros")]
        [HttpGet]
        public async Task<IActionResult> CalculaJuros(decimal ValorInicial, int Tempo)
        {

            decimal taxaJuros = await _taxaJuros.RetornoTaxaJuros();
            decimal result = (decimal.Round(_calcularJuros.CalculaJuros(ValorInicial, taxaJuros, Tempo),2));
            string ret = Convert.ToString(result);
            return Ok(ret);
        }

        [Route("showmethecode")]
        [HttpGet]

        public IActionResult ShowMeTheCode()
        {
            var link = "https://github.com/rafaelcarlins/Teste_Softplan";
            return Ok(link);
        }
    }
}
