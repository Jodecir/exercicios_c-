    using System;

    namespace Colecoes
    {
        internal static class Program
        {
        private static void Main(string[] args)
        {
            if (args == null)
                throw new ArgumentNullException(nameof(args));

                int[] arrayInteiros = new int[3];
                int[,] matriz = new int[4, 2] {
                    {8, 8},
                    {2, 4},
                    {8, 9},
                    {1, 8},
                };

            arrayInteiros[0] = 10;
            arrayInteiros[1] = 20;
            arrayInteiros[2] = 30;

            System.Console.WriteLine("Percorrendo Matriz com For:");
            for (int i = 0; i < matriz.GetLength(0); i++)
            {
                for (int j = 0; j < matriz.GetLength(1); j++)
                {
                    System.Console.WriteLine(matriz[i, j]);
                }
            }

            System.Console.WriteLine("Percorrendo Array com For:");
            for (int i = 0; i < arrayInteiros.Length; i++)
            {
                System.Console.WriteLine(arrayInteiros[i]);
            }

            System.Console.WriteLine("Percorrendo Array com Foreach:");
            foreach (int item in arrayInteiros)
            {
                System.Console.WriteLine(item);
            }
        }
    }
}
