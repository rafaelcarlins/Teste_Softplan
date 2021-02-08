using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Softplan;
using Softplan.Business;

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
            decimal ValorEsperado = 105.10M;
            CalcularJuros calcular = new CalcularJuros();
            var ValorRetornado = calcular.CalculaJuros(ValorInicial, juros, Tempo);

            Assert.AreEqual(ValorEsperado, ValorRetornado,  "OK");

        }
        [TestMethod]
        public void CalcularJurosComValorZerado()
        {
            decimal ValorInicial = 0;
            decimal juros = 0.01M;
            int Tempo = 5;
            decimal ValorEsperado = 0;
            CalcularJuros calcular = new CalcularJuros();
            var ValorRetornado = calcular.CalculaJuros(ValorInicial, juros, Tempo);
            
            Assert.AreEqual(ValorEsperado, ValorRetornado, "OK");

        }

        [TestMethod]
        public void CalcularJurosComMesInvalido()
        {
            decimal ValorInicial = 100;
            decimal juros = 0.01M;
            int Tempo = -5;
            decimal ValorEsperado = 0;
            CalcularJuros calcular = new CalcularJuros();
            var ValorRetornado = calcular.CalculaJuros(ValorInicial, juros, Tempo);

            Assert.AreEqual(ValorEsperado, ValorRetornado, "OK");

        }
    }
}
