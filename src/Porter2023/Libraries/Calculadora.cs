using System.Runtime.CompilerServices;

namespace Porter2023.Libraries
{
    public class Calculadora
    {
        private const char Multiplicacao = '*';
        private const char Divisao = '/';
        private const char Soma = '+';
        private const char Subtracao = '-';

        public static long SomarArray(int[] numeros)
        {
            if(numeros == null || numeros.Length == 0) 
                return 0;

            if (numeros.Length == 1)
                return numeros[0];

            long soma = 0;

            for (int i = 0; i < numeros.Length; i++)
            {
                soma += numeros[i];
            }

            return soma;
        }

        public static string CalcularExpressao(string expressao)
        {
            expressao = expressao.Replace(" ", "");

            expressao = ResolverOperacoes(expressao, Multiplicacao);
            expressao = ResolverOperacoes(expressao, Divisao);

            if (expressao.StartsWith("E"))
                return expressao;

            expressao = ResolverOperacoes(expressao, Soma);
            expressao = ResolverOperacoes(expressao, Subtracao);

            return expressao;
        }

        private static string ResolverOperacoes(string expressao, char operacao)
        {
            if(operacao == Subtracao)
                while (expressao.IndexOf(operacao) != -1 && expressao.Split(operacao)[0] != "")
                    expressao = ResolverTrechos(expressao, operacao);
            else
                while (expressao.IndexOf(operacao) != -1)
                    expressao = ResolverTrechos(expressao, operacao);

            return expressao;
        }

        private static string ResolverTrechos(string expressao, char operacao)
        {
            int indiceOperacao = expressao.IndexOf(operacao);
            int indicePosterior = 0, indiceAnterior = 0;

            if (indiceOperacao != -1)
            {
                for (int i = indiceOperacao + 1; i < expressao.Length; i++)
                {
                    if (expressao[i] == Soma 
                        || expressao[i] == Subtracao 
                        || expressao[i] == Multiplicacao 
                        || expressao[i] == Divisao)
                    {
                        indicePosterior = i;
                        break;
                    }

                    indicePosterior = i+1;
                }

                for (int i = indiceOperacao - 1; i > -1; i--)
                {
                    if (expressao[i] == Soma 
                        || expressao[i] == Subtracao 
                        || expressao[i] == Multiplicacao 
                        || expressao[i] == Divisao)
                    {
                        indiceAnterior = i+1;
                        break;
                    }

                    indiceAnterior = i;
                }
            }

            string calculo = expressao[indiceAnterior..indicePosterior];
            string resultado = CalcularMiniExpressao(calculo, operacao);
            
            if(resultado.StartsWith("E"))
                return resultado;

            expressao = expressao.Remove(indiceAnterior, indicePosterior - indiceAnterior);
            expressao = expressao.Insert(indiceAnterior, resultado);

            return expressao;
        }

        private static string CalcularMiniExpressao(string expressao, char operacao)
        {
            string[] valores = expressao.Split(operacao);

            int a = Convert.ToInt32(valores[0]);
            int b = Convert.ToInt32(valores[1]);

            return operacao switch
            {
                Soma => Somar(a, b).ToString(),
                Subtracao => Subitrair(a, b).ToString(),
                Multiplicacao => Multiplicar(a, b).ToString(),
                Divisao => b != 0 ? Dividir(a, b).ToString() : "ERRO: Divisão por zero!",
                _ => "",
            };
        }

        private static long Somar(int a, int b)
        {
            return a + b;
        }

        private static long Subitrair(int a, int b)
        {
            return a - b;
        }

        private static long Multiplicar(int a, int b)
        {
            return a * b;
        }
        private static long Dividir(int a, int b)
        {
            return a / b;
        }
    }
}
