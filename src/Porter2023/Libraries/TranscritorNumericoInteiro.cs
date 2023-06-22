using Porter2023.Bases;
using Porter2023.Interfaces;
using System.Text;

namespace Porter2023.Libraries
{
    public class TranscritorNumericoInteiro : TranscritorNumerico, ITranscritorNumericoInteiro
    {
        /// <summary>
        /// Transcreve um número inteiro por extenso.
        /// </summary>
        /// <param name="numero">Número inteiro</param>
        /// <returns>Uma string com o número transcrito.</returns>
        public string Transcrever(int numero)
        {
            if (numero == 0)
                return "zero";

            if (numero < 0)
                return "menos " + RecomporTexto(DecomporParaTexto(numero * -1));

            return RecomporTexto(DecomporParaTexto(numero));
        }
        
        private IList<string> DecomporParaTexto(int numero)
        {
            List<string> textos = new List<string>();
            int indiceMilhar = 10;

            while (numero > 0)
            {
                int indice = 0;
                int centena = numero % 1000;

                TratarDezenaEspecial(textos, ref numero, ref indice);

                for (; indice < 3; indice++)
                {
                    int _numero = numero % 10;
                    AdicionarTextoValido(textos, TranscreverNumeros(indice, indice == 2 ? centena : _numero));
                    numero /= 10;
                }

                AdicionarTextoValido(textos, TranscreverNumeros(indiceMilhar, numero));
                indiceMilhar++;
            }
            return textos;
        }

        private void TratarDezenaEspecial(List<string> textos, ref int numero, ref int indice)
        {
            if ((numero / 10) % 10 == 1) //Verificando se a dezena é um
            {
                AdicionarTextoValido(textos, TranscreverNumeros(-1, numero % 10));

                numero /= 100;
                indice = 2;
            }
        }

        private string RecomporTexto(IList<string> textos)
        {
            StringBuilder textoFinal = new StringBuilder();

            for (int i = textos.Count - 1; i > 0; i--)
            {
                if (textos[i - 1].StartsWith(' '))
                {
                    textoFinal.Append(textos[i]);
                    textoFinal.Append(textos[i - 1]);
                    i--;
                }
                else
                    textoFinal.Append(textos[i]);

                if (i > 0)
                    textoFinal.Append(" e ");
            }

            textoFinal.Append(textos[0].StartsWith(' ') ? "" : textos[0]);

            return textoFinal.ToString();
        }

        private void AdicionarTextoValido(List<string> textos, string texto)
        {
            if (!string.IsNullOrEmpty(texto))
                textos.Add(texto);
        }
    }
}
