using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Softplan.Interfaces
{
    public interface ITaxaJuros
    {
        Task<decimal> RetornoTaxaJuros();
    }
}
