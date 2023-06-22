using Porter2023.Libraries;
using Porter2023_test.Helpers;
using Porter2023_test.Helpers.Classes;
using System.Text;

namespace Porter2023_test
{
    public class ComparadorObjetosUnitTest
    {
        private int _quantidadeItensUnicos;
        [SetUp]
        public void Setup()
        {
        }

        [Test]
        public void RemoverDuplicados_ListaInteiros_ResultadoCorreto()
        {
            IList<int> inteiros = GeradorListaObjetos<int>
                .GerarListaDuplicados(out _quantidadeItensUnicos);

            inteiros = ComparadorObjetos<int>.RemoverDuplicados(inteiros);

            Assert.That(inteiros.Count, Is.EqualTo(_quantidadeItensUnicos));
        }

        [Test]
        public void RemoverDuplicados_ListaString_ResultadoCorreto()
        {
            IList<string> strings = GeradorListaObjetos<string>
                .GerarListaDuplicados(out _quantidadeItensUnicos);

            strings = ComparadorObjetos<string>.RemoverDuplicados(strings);

            Assert.That(strings.Count, Is.EqualTo(_quantidadeItensUnicos));
        }

        [Test]
        public void RemoverDuplicados_ListaPessoas_ResultadoCorreto()
        {
            IList<Pessoa> pessoas = GeradorListaObjetos<Pessoa>
                .GerarListaDuplicados(out _quantidadeItensUnicos);

            pessoas = ComparadorObjetos<Pessoa>.RemoverDuplicados(pessoas);

            Assert.That(pessoas.Count, Is.EqualTo(_quantidadeItensUnicos));
        }

        [Test]
        public void RemoverDuplicados_ListaDateTimes_ResultadoCorreto()
        {
            IList<DateTime> dateTimes = GeradorListaObjetos<DateTime>
                .GerarListaDuplicados(out _quantidadeItensUnicos);

            dateTimes = ComparadorObjetos<DateTime>.RemoverDuplicados(dateTimes);

            Assert.That(dateTimes.Count, Is.EqualTo(_quantidadeItensUnicos));
        }

        [Test]
        public void RemoverDuplicados_ListaStringBuilder_ResultadoCorreto()
        {
            IList<StringBuilder> stringBuilders = GeradorListaObjetos<StringBuilder>
                .GerarListaDuplicados(out _quantidadeItensUnicos);

            stringBuilders = ComparadorObjetos<StringBuilder>.RemoverDuplicados(stringBuilders);

            Assert.That(stringBuilders.Count, Is.EqualTo(_quantidadeItensUnicos));
        }

        [Test]
        public void RemoverDuplicados_ListaCamposPrivados_ResultadoIncorreto()
        {
            IList<CamposPrivados> camposPrivados = GeradorListaObjetos<CamposPrivados>
                .GerarListaDuplicados(out _quantidadeItensUnicos);

            camposPrivados = ComparadorObjetos<CamposPrivados>.RemoverDuplicados(camposPrivados);

            Assert.That(camposPrivados.Count, Is.Not.EqualTo(_quantidadeItensUnicos));
        }

        [Test]
        public void RemoverDuplicados_ListaNula_ResultadoCorreto()
        {
            IList<object> listaNula = null;

            listaNula = ComparadorObjetos<object>.RemoverDuplicados(listaNula);
            
            Assert.That(listaNula.Count, Is.EqualTo(0));
        }
    }
}
