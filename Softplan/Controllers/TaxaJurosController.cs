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
    public class TaxaJurosController : ControllerBase
    {


        private readonly ITaxaJuros _taxaJuros;

        public TaxaJurosController(ITaxaJuros taxaJuros)
        {
            _taxaJuros = taxaJuros;
        }


        [Route("taxajuros")]
        [HttpGet]

        public async Task<IActionResult> ObterTaxaJuros()
        {
            decimal result = await _taxaJuros.RetornoTaxaJuros();
            return Ok(result);
        }

        
        

    }
}
