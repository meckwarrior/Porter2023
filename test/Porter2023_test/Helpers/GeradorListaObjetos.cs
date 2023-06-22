using Porter2023_test.Helpers.Classes;
using System.Text;

namespace Porter2023_test.Helpers
{
    internal static class GeradorListaObjetos<T>
    {
          internal static IList<T> GerarListaDuplicados(out int quantidadeUnicos)
        {
            quantidadeUnicos = 0;
            return typeof(T).Name switch
            {
                "Int32" => (IList<T>)GerarListaInteirosDuplicados(out quantidadeUnicos),
                "String" => (IList<T>)GerarListaStringsDuplicados(out quantidadeUnicos),
                "DateTime" => (IList<T>)GerarListaDateTimesDuplicados(out quantidadeUnicos),
                "StringBuilder" => (IList<T>)GerarListaStringBuildersDuplicados(out quantidadeUnicos),
                "Pessoa" => (IList<T>)GerarListaPessoasDuplicados(out quantidadeUnicos),
                "CamposPrivados" => (IList<T>)GerarListaCamposPrivadosDuplicados(out quantidadeUnicos),
                _ => new List<T>(),
            };
        }


        private static IList<int> GerarListaInteirosDuplicados(out int quantidadeUnicos)
        {
            quantidadeUnicos = 9;
            IList<int> listaInteiros = new List<int>
            {
                8,
                1,
                11,
                2, 
                3,
                3,
                5, 
                7,
                7,
                8, 
                9, 
                10,
                8,
                8,
                11,
                11
            };

            return listaInteiros;
        }


        private static IList<string> GerarListaStringsDuplicados(out int quantidadeUnicos)
        {
            quantidadeUnicos = 4;
            IList<string> nomes = new List<string>
            {
                "Ana",
                "Ana",
                "Ana Carolina",
                "Ana",
                "Ana Paula",
                "Ana",
                "Ana Maria"
            };

            return nomes;
        }

        private static IList<DateTime> GerarListaDateTimesDuplicados(out int quantidadeUnicos)
        {
            quantidadeUnicos = 5;
            IList<DateTime> listaDateTime = new List<DateTime>
            {
                new DateTime(),
                new DateTime(),
                new DateTime(2023,10,10,15,10,0),
                new DateTime(2023,10,10),
                new DateTime(204564654654654654),
                new DateTime(204564654654654654),
                new DateTime(204564654454654654)
            };

            return listaDateTime;
        }

        private static IList<StringBuilder> GerarListaStringBuildersDuplicados(out int quantidadeUnicos)
        {
            quantidadeUnicos = 4;
            IList<StringBuilder> listaStringBuilder = new List<StringBuilder>
            {
                new StringBuilder("Nome"),
                new StringBuilder("Nome"),
                new StringBuilder("Número"),
                new StringBuilder("Casa"),
                new StringBuilder("Nome"),
                new StringBuilder(5),
                new StringBuilder(5),
                new StringBuilder("Número")
            };

            return listaStringBuilder;
        }

        private static IList<Pessoa> GerarListaPessoasDuplicados(out int quantidadeUnicos)
        {
            quantidadeUnicos = 20;
            IList<Pessoa> pessoas = new List<Pessoa>();

            for (int i = 0; i < 20; i++)
            {
                int ticks = (int)DateTime.Now.Ticks;
                string id = i.ToString();
                pessoas.Add(new Pessoa(id, "José_" + id, ticks % 100));
                pessoas.Add(new Pessoa(id, "José_" + id, ticks % 100));
            }

            return pessoas;
        }

        private static IList<CamposPrivados> GerarListaCamposPrivadosDuplicados(out int quantidadeUnicos)
        {
            quantidadeUnicos = 10;
            IList<CamposPrivados> camposPrivados = new List<CamposPrivados>();

            for (int i = 0; i < 10; i++)
            {
                string id = i.ToString();

                camposPrivados.Add(new CamposPrivados(i, "Fulana_" + id));
                camposPrivados.Add(new CamposPrivados(i, "Fulana_" + id));
            }

            return camposPrivados;
        }
    }
}
