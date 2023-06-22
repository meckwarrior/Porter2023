﻿using Porter2023.Interfaces;

namespace Porter2023.Libraries
{
    public class SomadorArray : ISomadorArray
    {
        public long Somar(int[] numeros)
        {
            if (numeros == null || numeros.Length == 0)
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
    }
}
