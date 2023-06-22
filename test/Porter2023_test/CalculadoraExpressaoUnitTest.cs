using Porter2023.Interfaces;
using Porter2023.Libraries;

namespace Porter2023_test
{
    internal class CalculadoraExpressaoUnitTest
    {
        private ICalculadoraExpressao _calculadoraExpressao;

        [SetUp]
        public void Setup()
        {
            _calculadoraExpressao = new CalculadoraExpressao();
        }

        [Test]
        [TestCase("50", "50")]
        [TestCase("17", "2 + 3 * 5")]
        [TestCase("16", "4 * 4")]
        [TestCase("5", "25 / 5")]
        [TestCase("2", "1 + 1")]
        [TestCase("0", "555 - 555")]
        [TestCase("100800", "21 * 8 * 6 * 100")]
        [TestCase("0", "21 / 8 / 6 / 100")]
        [TestCase("135", "21 +8 + 6 +100")]
        [TestCase("-93", "21-8-6-100")]
        public void CalcularExpressao_ExpressaoSimples_ResultadoCorreto(string resultado, string expresssao)
        {
            Assert.That(_calculadoraExpressao.Calcular(expresssao), Is.EqualTo(resultado));
        }


        [Test]
        [TestCase("ERRO: Divisão por zero!" , "2 + 3 - 5 - 8 / 5 * 15 * 0")]
        [TestCase("ERRO: Divisão por zero!", "5 / 0 + 3 - 5 - 8 / 5 * 15 * 5")]
        [TestCase("ERRO: Divisão por zero!", "10000 / 0")]
        public void CalcularExpressao_ExpressaoComZeros_ErroDivisaoPorZero(string resultado, string expresssao)
        {
            Assert.That(_calculadoraExpressao.Calcular(expresssao), Is.EqualTo(resultado));
        }

        [Test]
        [TestCase("ERRO: Expressão Inválida!", null)]
        [TestCase("ERRO: Expressão Inválida!", "-2 + 3")]
        [TestCase("ERRO: Expressão Inválida!", "-2 + -3")]
        [TestCase("ERRO: Expressão Inválida!", "(2 + 3) * 5")]
        [TestCase("ERRO: Expressão Inválida!", "/3")]
        [TestCase("ERRO: Expressão Inválida!", "1 ++ 3")]
        [TestCase("ERRO: Expressão Inválida!", "15 +")]
        [TestCase("ERRO: Expressão Inválida!", "")]
        [TestCase("ERRO: Expressão Inválida!", "+")]
        [TestCase("ERRO: Expressão Inválida!", "-")]
        [TestCase("ERRO: Expressão Inválida!", "/")]
        [TestCase("ERRO: Expressão Inválida!", "*")]
        [TestCase("ERRO: Expressão Inválida!", "a")]
        [TestCase("ERRO: Expressão Inválida!", "A")]
        [TestCase("ERRO: Expressão Inválida!", "A + B")]
        [TestCase("ERRO: Expressão Inválida!", "A + b")]
        [TestCase("ERRO: Expressão Inválida!", "E + 1")]
        [TestCase("ERRO: Expressão Inválida!", "a + 1")]
        [TestCase("ERRO: Expressão Inválida!", "a + B")]
        [TestCase("ERRO: Expressão Inválida!", "a * m")]
        public void CalcularExpressao_ExpressaInvalida_ErroExpressaoInvalida(string resultado, string expresssao)
        {
            Assert.That(_calculadoraExpressao.Calcular(expresssao), Is.EqualTo(resultado));
        }

    }
}

