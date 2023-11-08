using System;
using Xunit;
using BDD_TesteUnitario;

namespace TesteBDD_TesteUnitario
{
    public class UnitTest1

    {
        public Calculadora construirClasse()
        {
            string data = "08/11/2023";
            Calculadora calc = new Calculadora("08/11/2023");

            return calc;
        }

        [Theory]
        [InlineData(1, 2, 3)]
        [InlineData(4, 5, 9)]
        public void TesteSomar(int val1, int val2, int resultado)
        {
            Calculadora calc = construirClasse();

            int resultadoCalculadora = calc.Somar(val1, val2);

            Assert.Equal(resultado, resultadoCalculadora);

        }

        [Theory]
        [InlineData(5, 2, 3)]
        [InlineData(18, 5, 13)]
        public void TesteSubtrair(int val1, int val2, int resultado)
        {
            Calculadora calc = construirClasse();

            int resultadoCalculadora = calc.Subtrair(val1, val2);

            Assert.Equal(resultado, resultadoCalculadora);

        }

        [Theory]
        [InlineData(5, 2, 10)]
        [InlineData(2, 2, 4)]
        public void TesteMultiplicar(int val1, int val2, int resultado)
        {
            Calculadora calc = construirClasse();

            int resultadoCalculadora = calc.Multiplicar(val1, val2);

            Assert.Equal(resultado, resultadoCalculadora);

        }

        [Theory]
        [InlineData(20, 2, 10)]
        [InlineData(16, 4, 4)]
        public void TesteDividir(int val1, int val2, int resultado)
        {
            Calculadora calc = construirClasse();

            int resultadoCalculadora = calc.Dividir(val1, val2);

            Assert.Equal(resultado, resultadoCalculadora);

        }

        [Fact]
        public void TestarDivisaoPorZero()
        {
            Calculadora calc = construirClasse();
            Assert.Throws<DivideByZeroException>(
                () => calc.Dividir(3, 0)
                );
        }


        [Fact]
        public void TestarHistorico()
        {
            Calculadora calc = construirClasse();

            calc.Somar(1, 2);            
            calc.Subtrair(5, 3);
            calc.Multiplicar(6, 50);
            calc.Dividir(50, 10);

            var lista = calc.historico();

            Assert.NotEmpty(lista);
            Assert.Equal(3, lista.Count);
        }
    }
}
