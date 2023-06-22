using Porter2023_test.Helpers.Classes;
using System.Text;

namespace Porter2023_test.Helpers
{
    internal static class GeradorListaObjetos
    {
        public const int TamanhoItensUnicosInteiros = 9;
        public const int TamanhoItensUnicosStrings = 4;
        public const int TamanhoItensUnicosDateTimes = 5;
        public const int TamanhoItensUnicosStringBuilders = 4;
        public const int TamanhoItensUnicosPessoas = 20;
        public const int TamanhoItensUnicosCamposPrivados = 10;

        internal static IList<int> GerarListaInteiros()
        {
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


        internal static IList<string> GerarListaStrings()
        {
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

        internal static IList<DateTime> GerarListaDateTimes()
        {
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

        internal static IList<StringBuilder> GerarListaStringBuilders()
        {
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

        internal static IList<Pessoa> GerarListaPessoas()
        {
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

        internal static IList<CamposPrivados> GerarListaCamposPrivados()
        { 
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
