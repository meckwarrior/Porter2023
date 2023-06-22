using Porter2023.Libraries;
using Porter2023_test.Helpers;

namespace Porter2023_test
{
    public class CalculadoraUnitTest
    {
        [SetUp]
        public void Setup()
        {
        }

        [Test]
        [TestCase(0, null)]
        [TestCase(0, new int[] { })]
        [TestCase (1000, new int[] {1000})]
        [TestCase(4, new int[] { 1, 1, 1, 1 })]
        [TestCase(4294967294, new int[] {2147483647, 2147483647 })]
        [TestCase(0, new int[] { 0, 0, 0, 0, 0, 0, 0, 0, 0, 0})]
        [TestCase(55, new int[] { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 })]
        [TestCase(0, new int[] { 1, 2, 3, 4, 5, -5, -4, -3, -2, -1})]
        [TestCase(-55, new int[] { -1, -2, -3, -4, -5, -6, -7, -8, -9, -10 })]
        [TestCase(-18416, new int[] { -17355, 11231, -30351, 12992, 50, 999, 18, 4000})]
        [TestCase(3576072, new int[] {9033, 37819, 23837, 35025, 44740, 37135, 25257, 6637, 10372,
            18373, 38579, 27737, 39614, 18625, 4135, 44387, 21866, 27593, 13073, 41605, 40065, 37093,
            30788, 19736, 33051, 46042, 49162, 12430, 24468, 4054, 28867, 45829, 8320, 40664, 30521,
            26790, 47334, 30169, 3547, 17647, 17355, 25027, 20871, 18013, 9881, 43473, 17560, 24623, 
            3881, 25120, 33693, 34211, 11231, 46013, 4451, 20946, 5012, 32636, 49796, 24708, 34659, 
            45356, 15465, 33438, 5126, 33090, 15792, 16421, 30351, 17206, 12992, 48335, 43695, 8174, 
            32135, 1580, 32379, 30423, 4083, 43936, 43728, 40462, 28124, 38862, 20727, 27636, 10193, 
            16294, 39955, 8352, 35670, 40495, 41640, 47872, 23147, 23100, 24282, 31047, 36631, 16274, 
            16286, 49794, 3227, 19757, 45666, 27317, 49545, 24432, 30923, 16860, 17313, 38073, 9213, 
            33389, 26623, 10263, 11394, 1644, 32392, 48263, 17698, 17535, 47185, 15507, 24780, 48818,
            16005, 15359, 31719, 21405, 28335, 43986, 23676, 4091, 37952 })]
        public void SomarArray_NumerosSimples_ResultadoCorreto(long resultado, int[] arrayNumeros) 
        {
            Assert.That(Calculadora.SomarArray(arrayNumeros), Is.EqualTo(resultado));
        }

        [Test]
        public void SomarArray_ArrayTamanhoUmMillhao_ResultadoCorreto()
        {
            long resultado = LongArray.ResultadoArrayUmMilhao;
            int[] arrayNumeros = LongArray.ArrayUmMilhao;

            Assert.That(Calculadora.SomarArray(arrayNumeros), Is.EqualTo(resultado));
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
            Assert.That(Calculadora.CalcularExpressao(expresssao), Is.EqualTo(resultado));
        }


        [Test]
        [TestCase("ERRO: Divisão por zero!" , "2 + 3 - 5 - 8 / 5 * 15 * 0")]
        [TestCase("ERRO: Divisão por zero!", "5 / 0 + 3 - 5 - 8 / 5 * 15 * 5")]
        [TestCase("ERRO: Divisão por zero!", "10000 / 0")]
        public void CalcularExpressao_ExpressaoComZeros_ErroDivisaoPorZero(string resultado, string expresssao)
        {
            Assert.That(Calculadora.CalcularExpressao(expresssao), Is.EqualTo(resultado));
        }

        [Test]
        [TestCase("ERRO: Expressão Inválida!", null)]
        [TestCase("ERRO: Expressão Inválida!", "-2 + 3")]
        [TestCase("ERRO: Expressão Inválida!", "-2 + 3")]
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
            Assert.That(Calculadora.CalcularExpressao(expresssao), Is.EqualTo(resultado));
        }

    }
}

