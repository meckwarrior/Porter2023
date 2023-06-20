using System.Text;

namespace Porter2023.Libraries
{
    public class TranscritorNumerico
    {
        public string TranscreverInteiro(int numero)
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


                if ((numero / 10) % 10 == 1)
                {
                    AdicionarTextoValido(textos,Transcrever(-1, numero % 10));

                    numero /= 100;
                    indice = 2;
                }

                for (; indice < 3; indice++)
                {
                    int _numero = numero % 10;
                    AdicionarTextoValido(textos, Transcrever(indice, indice == 2 ? centena : _numero));
                    numero /= 10;
                }

                AdicionarTextoValido(textos, Transcrever(indiceMilhar, numero));
                indiceMilhar++;
            }

            return textos;
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

        private string Transcrever(int indice, int numero)
        {
            string texto = "";

            switch (indice)
            {
                case 0: return TranscreverUnidade(numero);
                case 1: return TranscreverDezena(numero);
                case -1: return TranscreverDezenaEspecial(numero);
                case 2: return TranscreverCentena(numero);
                case 10: return TranscreverMilhar(numero);
                case 11: return TranscreverMilhao(numero);
                case 12: return TranscreverBilhao(numero);
            }

            return texto;
        }

        private string TranscreverUnidade(int numero)
        {
            return numero switch
            {
                1 => "um",
                2 => "dois",
                3 => "três",
                4 => "quatro",
                5 => "cinco",
                6 => "seis",
                7 => "sete",
                8 => "oito",
                9 => "nove",
                _ => "",
            };
        }

        private string TranscreverDezena(int numero)
        {
            return numero switch
            {
                2 => "vinte",
                3 => "trinta",
                4 => "quarenta",
                5 => "cinquenta",
                6 => "sessenta",
                7 => "setenta",
                8 => "oitenta",
                9 => "noventa",
                _ => "",
            };
        }

        private string TranscreverDezenaEspecial(int numero)
        {
            return numero switch
            {
                0 => "dez",
                1 => "onze",
                2 => "doze",
                3 => "treze",
                4 => "quatorze",
                5 => "quinze",
                6 => "dezesseis",
                7 => "dezessete",
                8 => "dezoito",
                9 => "dezenove",
                _ => "",
            };
        }

        private string TranscreverCentena(int numero)
        {
            if (numero == 100)
                return "cem";

            numero /= 100;

            return numero switch
            {
                1 => "cento",
                2 => "duzentos",
                3 => "trezentos",
                4 => "quatrocentos",
                5 => "quinhentos",
                6 => "seiscentos",
                7 => "setecentos",
                8 => "oitocentos",
                9 => "novecentos",
                _ => "",
            };
        }

        private string TranscreverMilhar(int numero)
        {
            return numero % 1000 == 0 ? "" : " mil";
        }

        private string TranscreverMilhao(int numero)
        {
            if (numero % 1000 == 0)
                return "";

            return numero % 1000 > 1 ? " milhões" : " milhão";
        }

        private string TranscreverBilhao(int numero)
        {
            if (numero % 1000 == 0)
                return "";

            return numero % 1000 > 1 ? " bilhões" : " bilhão";
        }

    }
}
