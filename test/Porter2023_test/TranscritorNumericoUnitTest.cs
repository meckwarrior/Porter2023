using Porter2023.Libraries;

namespace Porter2023_test
{
    public class TranscritorNumericoUnitTest
    {
        private TranscritorNumerico _subject;

        [SetUp]
        public void Setup()
        {
            _subject = new TranscritorNumerico();
        }

        [Test]
        [TestCase(0, "zero")]
        [TestCase(1, "um")]
        [TestCase(2, "dois")]
        [TestCase(3, "três")]
        [TestCase(4, "quatro")]
        [TestCase(5, "cinco")]
        [TestCase(6, "seis")]
        [TestCase(7, "sete")]
        [TestCase(8, "oito")]
        [TestCase(9, "nove")]
        [TestCase(10, "dez")]
        [TestCase(11, "onze")]
        [TestCase(12, "doze")]
        [TestCase(13, "treze")]
        [TestCase(14, "quatorze")]
        [TestCase(15, "quinze")]
        [TestCase(16, "dezesseis")]
        [TestCase(17, "dezessete")]
        [TestCase(18, "dezoito")]
        [TestCase(19, "dezenove")]
        [TestCase(20, "vinte")]
        [TestCase(30, "trinta")]
        [TestCase(40, "quarenta")]
        [TestCase(50, "cinquenta")]
        [TestCase(60, "sessenta")]
        [TestCase(70, "setenta")]
        [TestCase(80, "oitenta")]
        [TestCase(90, "noventa")]
        [TestCase(100, "cem")]
        [TestCase(200, "duzentos")]
        [TestCase(300, "trezentos")]
        [TestCase(400, "quatrocentos")]
        [TestCase(500, "quinhentos")]
        [TestCase(600, "seiscentos")]
        [TestCase(700, "setecentos")]
        [TestCase(800, "oitocentos")]
        [TestCase(900, "novecentos")]
        [TestCase(1000, "um mil")]
        [TestCase(2000, "dois mil")]
        [TestCase(3000, "três mil")]
        [TestCase(4000, "quatro mil")]
        [TestCase(5000, "cinco mil")]
        [TestCase(6000, "seis mil")]
        [TestCase(7000, "sete mil")]
        [TestCase(8000, "oito mil")]
        [TestCase(9000, "nove mil")]
        [TestCase(10000, "dez mil")]
        [TestCase(100000, "cem mil")]
        [TestCase(1000000, "um milhão")]
        [TestCase(1000000000, "um bilhão")]
        [TestCase(99, "noventa e nove")]
        [TestCase(101, "cento e um")]
        [TestCase(111, "cento e onze")]
        [TestCase(154, "cento e cinquenta e quatro")]
        [TestCase(200, "duzentos")]
        [TestCase(1001, "um mil e um")]
        [TestCase(1100, "um mil e cem")]
        [TestCase(1111, "um mil e cento e onze")]
        [TestCase(10001, "dez mil e um")]
        [TestCase(11111, "onze mil e cento e onze")]
        [TestCase(200000, "duzentos mil")]
        [TestCase(111111, "cento e onze mil e cento e onze")]
        [TestCase(1111111, "um milhão e cento e onze mil e cento e onze")]
        [TestCase(2000000, "dois milhões")]
        [TestCase(2100000, "dois milhões e cem mil")]
        [TestCase(27149000, "vinte e sete milhões e cento e quarenta e nove mil")]
        [TestCase(100000000, "cem milhões")]
        [TestCase(153000000, "cento e cinquenta e três milhões")]
        [TestCase(1111111111, "um bilhão e cento e onze milhões e cento e onze mil e cento e onze")]
        [TestCase(2000000000, "dois bilhões")]
        [TestCase(2000000002, "dois bilhões e dois")]
        [TestCase(2001000000, "dois bilhões e um milhão")]
        public void TranscreverInteiro_NumeroPositivo_TextoCorreto(int numero, string textoNumero)
        {
            Assert.That(_subject.TranscreverInteiro(numero), Is.EqualTo(textoNumero));
        }

        [Test]
        [TestCase(-1, "menos um")]
        [TestCase(-88, "menos oitenta e oito")]
        [TestCase(-100, "menos cem")]
        [TestCase(-2000000000, "menos dois bilhões")]
        public void TranscreverInteiro_NumeroNegativo_TextoCorreto(int numero, string textoNumero)
        {
            Assert.That(_subject.TranscreverInteiro(numero), Is.EqualTo(textoNumero));
        }
    }
}