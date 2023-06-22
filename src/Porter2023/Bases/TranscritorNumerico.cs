namespace Porter2023.Bases
{
    public abstract class TranscritorNumerico
    {
        protected string TranscreverNumeros(int indice, int numero)
        {
            string texto = "";

            return indice switch
            {
                0 => TranscreverUnidade(numero),
                1 => TranscreverDezena(numero),
                -1 => TranscreverDezenaEspecial(numero),
                2 => TranscreverCentena(numero),
                10 => TranscreverMilhar(numero),
                11 => TranscreverMilhao(numero),
                12 => TranscreverBilhao(numero),
                _ => texto,
            };
        }

        protected string TranscreverUnidade(int numero)
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

        protected string TranscreverDezena(int numero)
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

        protected string TranscreverDezenaEspecial(int numero)
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

        protected string TranscreverCentena(int numero)
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

        protected string TranscreverMilhar(int numero)
        {
            return numero % 1000 == 0 ? "" : " mil";
        }

        protected string TranscreverMilhao(int numero)
        {
            if (numero % 1000 == 0)
                return "";

            return numero % 1000 > 1 ? " milhões" : " milhão";
        }

        protected string TranscreverBilhao(int numero)
        {
            if (numero % 1000 == 0)
                return "";

            return numero % 1000 > 1 ? " bilhões" : " bilhão";
        }

    }
}
