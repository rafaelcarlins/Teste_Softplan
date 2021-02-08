using Softplan.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Softplan.Business
{
    public class CalcularJuros : ICalcularJuros
    {
        public decimal CalculaJuros(decimal ValorInicial, decimal juros, int Tempo)
        {
            

            var Valor = ValorInicial * (1 + juros) ;
            
            var Val = Math.Pow(decimal.ToDouble(Valor), 5);

            decimal ValorFinal = Convert.ToDecimal(Math.Truncate(Val) / 100000000);//Após pesquisas informarem que para utilizar o método POW é necessário ser realizada a divisão
            ValorFinal = (decimal.Round(ValorFinal, 2));

            return ValorFinal;

                   
        }
        
    }
}
