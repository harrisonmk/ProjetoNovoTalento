using NovoTalento;

namespace TestNovoTalento
{
    public class UnitTest1
    {



        public Calculadora construirClasse()
        {
            string data = "02/02/2020";
            Calculadora calc = new Calculadora("02/02/2020");

            return calc;
        }


        [Theory]
        [InlineData(1,2,3)]
        public void TestSomar(int a,int b,int resultado)
        {
            Calculadora calc = construirClasse();

            int resultadoCalculadora = calc.somar(a, b);


            Assert.Equal(resultado, resultadoCalculadora);

        }

        [Theory]
        [InlineData(6, 2, 4)]
        public void TestSubtrair(int a, int b, int resultado)
        {
            Calculadora calc = construirClasse();

            int resultadoCalculadora = calc.subtrair(a, b);


            Assert.Equal(resultado, resultadoCalculadora);

        }


        [Theory]
        [InlineData(1, 2, 2)]
        public void TestMultiplicar(int a, int b, int resultado)
        {
            Calculadora calc = construirClasse();

            int resultadoCalculadora = calc.multiplicar(a, b);


            Assert.Equal(resultado, resultadoCalculadora);

        }


        [Theory]
        [InlineData(6, 2, 3)]
        public void TestDividir(int a, int b, int resultado)
        {
            Calculadora calc = construirClasse();

            int resultadoCalculadora = calc.dividir(a, b);


            Assert.Equal(resultado, resultadoCalculadora);

        }

        [Fact]
        public void TestarDivisaoPorZero()
        {
            Calculadora calc = construirClasse();

            Assert.Throws<DivideByZeroException>(
                () => calc.dividir(3, 0));
        }
    }
}