using System.Drawing;

namespace Taxasil.test
{
    public class TaxasTeste
    {

        [Fact]
        public void testarTaxasTrue_Fact()
        {
            double valor = 1000;
            double CalcularTaxas = Taxas.CalcularTaxas(valor);
            Assert.Equal(1100, CalcularTaxas);
        }
        [Fact]
        public void testarTaxasFalse_Fact()
        {
            double valor = 1000;
            double CalcularTaxas = Taxas.CalcularTaxas(valor);
            Assert.NotEqual(1106, CalcularTaxas);
        }

        [Theory]
        [InlineData(1000, 1100)]
        [InlineData(2000, 2200)]
        [InlineData(800, 856)]
        [InlineData(4000, 4600)]
        public void testarTaxasTrue_Theory(double valor, double TaxasdoLula)
            {
            double resultado = Taxas.CalcularTaxas(valor);
            Assert.Equal(resultado, TaxasdoLula);
            }

        [Theory]
        [InlineData(-105425200, -115254201)]
        [InlineData(-2052400, -255205400)]
        [InlineData(-452545800, -860)]
        [InlineData(-435153135000, -555424000)]
        public void testarTaxasFalse_Theory(double valor, double TaxasdoLula)
        {
            double resultado = Taxas.CalcularTaxas(valor);
            Assert.NotEqual(resultado, TaxasdoLula);
        }

    }
}
