using System.Globalization;

namespace Cada_linha{
    class Program {
        static void Main(string[] args) {
            int i, maior = 0, n, j;

            do {
                Console.Write("Qual a quantidade de colunas da matriz? ");
                n = int.Parse(Console.ReadLine());
            }
            while (n < 0 && n > 10);

            int[,] mat = new int[n, n];
            int[] maiorDaLinha = new int[n];


            for (i = 0; i < n; i++) {
                for (j = 0; j < n; j++) {
                    Console.Write("Elemento [" + i + "," + j + "]: ");
                    mat[i, j] = int.Parse(Console.ReadLine());
                }
            }

            for (i = 0; i < n; i++) {
                maior = mat[i, 0];

                for (j = 0; j < n; j++) {
                    if (maior < mat[i, j]) {
                        maior = mat[i, j];
                    }
                }
                maiorDaLinha[i] = maior;
            }

            Console.WriteLine();

            Console.WriteLine("MAIOR ELEMENTO DE CADA LINHA:");
            for (i = 0; i < n; i++) {
                Console.WriteLine(maiorDaLinha[i]);
            }
        }
    }
}