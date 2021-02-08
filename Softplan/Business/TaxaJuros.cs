
using Softplan.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Softplan.Business
{
    public class TaxaJuros :ITaxaJuros
    {
        public async Task<decimal> RetornoTaxaJuros()
        {
            return  0.01M;
        }
    }
}
