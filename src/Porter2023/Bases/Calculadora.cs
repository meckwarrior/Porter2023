namespace Porter2023.Bases
{
    public abstract class Calculadora
    {
        protected static long Somar(int a, int b)
        {
            return a + b;
        }

        protected static long Subitrair(int a, int b)
        {
            return a - b;
        }

        protected static long Multiplicar(int a, int b)
        {
            return a * b;
        }
        protected static long Dividir(int a, int b)
        {
            return a / b;
        }
    }
}
