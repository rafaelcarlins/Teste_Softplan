using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace SoftplanTest
{
    [TestClass]
    public class CalcularJurosTest
    {
        [TestMethod]
        public void CalcularJurosComValorValido()
        {
            decimal ValorInicial = 100;
            decimal juros = 0.01M;
            int Tempo = 5;

            CalcularJuros calcular = new CalcularJuros();
            calcular.CalculaJuros(ValorInicial, juros, Tempo);

        }
    }
}
