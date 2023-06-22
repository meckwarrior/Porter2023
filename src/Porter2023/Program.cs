// See https://aka.ms/new-console-template for more information
using Porter2023.Libraries;

int[] numeros = { 2147483647, 2147483647 };
string expressao = "2 * 6";
//Console.WriteLine(Calculadora.SomarArray(numeros));
//Console.WriteLine(Calculadora.CalcularExpressao(expressao));

IList<string> nomes = new List<string>();
nomes.Add("Ana");
nomes.Add("Ana");
nomes.Add("Ana Carolina");
nomes.Add("Ana");
nomes.Add("Ana Paula");
nomes.Add("Ana");
nomes.Add("Ana Maria");

nomes = ComparadorObjetos<string>.RemoverDuplicados(nomes);

foreach (string nome in nomes)
    Console.WriteLine(nome);