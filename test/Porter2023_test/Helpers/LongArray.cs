namespace Porter2023_test.Helpers
{
    public static class LongArray
    {
        public static int[] ArrayUmMilhao => RetornaArrayUmMilhao();
        public static long ResultadoArrayUmMilhao => 500000500000;


        private static int[] RetornaArrayUmMilhao()
        {
            return File.ReadAllLines("../../../Data/ArrayUmMilhao.txt").Select(int.Parse).ToArray();
        }
    }
}
