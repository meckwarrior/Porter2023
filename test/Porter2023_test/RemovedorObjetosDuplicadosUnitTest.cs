using Porter2023.Interfaces;
using Porter2023.Libraries;
using Porter2023_test.Helpers;
using Porter2023_test.Helpers.Classes;
using System.Text;

namespace Porter2023_test
{
    internal class RemovedorObjetosDuplicadosUnitTest
    {
        private int _quantidadeItensUnicos;
        private IRemovedorObjetosDuplicados<int> _removedorInteirosDuplicados;
        private IRemovedorObjetosDuplicados<string> _removedorStringsDuplicados;
        private IRemovedorObjetosDuplicados<DateTime> _removedorDateTimesDuplicados;
        private IRemovedorObjetosDuplicados<StringBuilder> _removedorStringBuildersDuplicados;
        private IRemovedorObjetosDuplicados<Pessoa> _removedorPessoasDuplicados;
        private IRemovedorObjetosDuplicados<CamposPrivados> _removedorCamposPrivadosDuplicados;

        [SetUp]
        public void Setup()
        {
            _removedorInteirosDuplicados = new RemovedorObjetosDuplicados<int>();
            _removedorStringsDuplicados = new RemovedorObjetosDuplicados<string>();
            _removedorDateTimesDuplicados = new RemovedorObjetosDuplicados<DateTime>();
            _removedorStringBuildersDuplicados  = new RemovedorObjetosDuplicados<StringBuilder> ();
            _removedorPessoasDuplicados = new RemovedorObjetosDuplicados<Pessoa>();
            _removedorCamposPrivadosDuplicados = new RemovedorObjetosDuplicados<CamposPrivados>();
        }

        [Test]
        public void RemoverDuplicados_ListaInteiros_ResultadoCorreto()
        {
            IList<int> inteiros = GeradorListaObjetos<int>
                .GerarListaDuplicados(out _quantidadeItensUnicos);

            inteiros = _removedorInteirosDuplicados.Remover(inteiros);

            Assert.That(inteiros.Count, Is.EqualTo(_quantidadeItensUnicos));
        }

        [Test]
        public void RemoverDuplicados_ListaString_ResultadoCorreto()
        {
            IList<string> strings = GeradorListaObjetos<string>
                .GerarListaDuplicados(out _quantidadeItensUnicos);

            strings = _removedorStringsDuplicados.Remover(strings);

            Assert.That(strings.Count, Is.EqualTo(_quantidadeItensUnicos));
        }

        
        [Test]
        public void RemoverDuplicados_ListaDateTimes_ResultadoCorreto()
        {
            IList<DateTime> dateTimes = GeradorListaObjetos<DateTime>
                .GerarListaDuplicados(out _quantidadeItensUnicos);

            dateTimes = _removedorDateTimesDuplicados.Remover(dateTimes);

            Assert.That(dateTimes.Count, Is.EqualTo(_quantidadeItensUnicos));
        }

        [Test]
        public void RemoverDuplicados_ListaStringBuilder_ResultadoCorreto()
        {
            IList<StringBuilder> stringBuilders = GeradorListaObjetos<StringBuilder>
                .GerarListaDuplicados(out _quantidadeItensUnicos);

            stringBuilders = _removedorStringBuildersDuplicados.Remover(stringBuilders);

            Assert.That(stringBuilders.Count, Is.EqualTo(_quantidadeItensUnicos));
        }

        [Test]
        public void RemoverDuplicados_ListaPessoas_ResultadoCorreto()
        {
            IList<Pessoa> pessoas = GeradorListaObjetos<Pessoa>
                .GerarListaDuplicados(out _quantidadeItensUnicos);

            pessoas = _removedorPessoasDuplicados.Remover(pessoas);

            Assert.That(pessoas.Count, Is.EqualTo(_quantidadeItensUnicos));
        }

        [Test]
        public void RemoverDuplicados_ListaNula_ResultadoCorreto()
        {
            IList<string> listaNula = null;

            listaNula = _removedorStringsDuplicados.Remover(listaNula);

            Assert.That(listaNula.Count, Is.EqualTo(0));
        }

        [Test]
        public void RemoverDuplicados_ListaCamposPrivados_ResultadoIncorreto()
        {
            IList<CamposPrivados> camposPrivados = GeradorListaObjetos<CamposPrivados>
                .GerarListaDuplicados(out _quantidadeItensUnicos);

            camposPrivados = _removedorCamposPrivadosDuplicados.Remover(camposPrivados);

            Assert.That(camposPrivados.Count, Is.Not.EqualTo(_quantidadeItensUnicos));
        }

        
    }
}
