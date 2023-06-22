using Porter2023.Libraries;
using Porter2023_test.Helpers;
using Porter2023_test.Helpers.Classes;
using System.Text;

namespace Porter2023_test
{
    public class ComparadorObjetosUnitTest
    {
        [SetUp]
        public void Setup()
        {
        }

        [Test]
        public void RemoverDuplicados_ListaInteiros_ResultadoCorreto()
        {
            IList<int> inteiros = GeradorListaObjetos.GerarListaInteiros();

            inteiros = ComparadorObjetos<int>.RemoverDuplicados(inteiros);

            Assert.That(inteiros.Count,
                Is.EqualTo(GeradorListaObjetos.TamanhoItensUnicosInteiros));
        }

        [Test]
        public void RemoverDuplicados_ListaString_ResultadoCorreto()
        {
            IList<string> strings = GeradorListaObjetos.GerarListaStrings();

            strings = ComparadorObjetos<string>.RemoverDuplicados(strings);

            Assert.That(strings.Count,
                Is.EqualTo(GeradorListaObjetos.TamanhoItensUnicosStrings));
        }

        [Test]
        public void RemoverDuplicados_ListaPessoas_ResultadoCorreto()
        {
            IList<Pessoa> pessoas = GeradorListaObjetos.GerarListaPessoas();

            pessoas = ComparadorObjetos<Pessoa>.RemoverDuplicados(pessoas);

            Assert.That(pessoas.Count,
                Is.EqualTo(GeradorListaObjetos.TamanhoItensUnicosPessoas));
        }

        [Test]
        public void RemoverDuplicados_ListaDateTimes_ResultadoCorreto()
        {
            IList<DateTime> dateTimes = GeradorListaObjetos.GerarListaDateTimes();

            dateTimes = ComparadorObjetos<DateTime>.RemoverDuplicados(dateTimes);

            Assert.That(dateTimes.Count,
                Is.EqualTo(GeradorListaObjetos.TamanhoItensUnicosDateTimes));
        }

        [Test]
        public void RemoverDuplicados_ListaStringBuilder_ResultadoCorreto()
        {
            IList<StringBuilder> stringBuilders = GeradorListaObjetos.GerarListaStringBuilders();

            stringBuilders = ComparadorObjetos<StringBuilder>.RemoverDuplicados(stringBuilders);

            Assert.That(stringBuilders.Count,
                Is.EqualTo(GeradorListaObjetos.TamanhoItensUnicosStringBuilders));
        }

        [Test]
        public void RemoverDuplicados_ListaCamposPrivados_ResultadoIncorreto()
        {
            IList<CamposPrivados> camposPrivados = GeradorListaObjetos.GerarListaCamposPrivados();

            camposPrivados = ComparadorObjetos<CamposPrivados>.RemoverDuplicados(camposPrivados);

            Assert.That(camposPrivados.Count, 
                Is.Not.EqualTo(GeradorListaObjetos.TamanhoItensUnicosCamposPrivados));
        }

        [Test]
        public void RemoverDuplicados_ListaNula_ResultadoCorreto()
        {
            IList<object> listaNula = null;

            listaNula = ComparadorObjetos<object>.RemoverDuplicados(listaNula);

            Assert.That(listaNula.Count,
                Is.EqualTo(0));
        }
    }
}
