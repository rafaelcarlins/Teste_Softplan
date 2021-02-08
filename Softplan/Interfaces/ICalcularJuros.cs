using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Softplan.Interfaces
{
    public interface ICalcularJuros
    {
        decimal CalculaJuros(decimal ValorInicial, decimal juros, int Tempo);
    }
}
