using Xunit;
using FluentAssertions;

namespace DescontoApp.UnitTest
{
    public class DescontoTest
    {
        [Fact]
        public void Valor_total_acima_de_1000_reais_deve_ter_desconto_de_10_porcento()
        {
            //Arrange
            var desconto = new Desconto();
            var total = 1001;
            var comDesconto = total * 0.1m;


            //Act
            var valor = desconto.porValor(total);

            //Assert
            valor.Should().Be(comDesconto);
        }

        [Fact]
        public void Valor_total_de_1000_reais_nao_deve_dar_desconto()
        {
            //Arrange
            var desconto = new Desconto();
            var total = 1000;
            var comDesconto = 0;


            //Act
            var valor = desconto.porValor(total);

            //Assert
            valor.Should().Be(comDesconto);
        }

        [Fact]
        public void Valor_total_de_500_reais_nao_deve_dar_desconto()
        {
            //Arrange
            var desconto = new Desconto();
            var total = 500;
            var comDesconto = 0;


            //Act
            var valor = desconto.porValor(total);

            //Assert
            valor.Should().Be(comDesconto);
        }

        [Fact]
        public void Valor_total_negativo_de_500_reais_nao_deve_dar_desconto()
        {
            //Arrange
            var desconto = new Desconto();
            var total = -500;
            var comDesconto = 0;


            //Act
            var valor = desconto.porValor(total);

            //Assert
            valor.Should().Be(comDesconto);
        }
    }
}
