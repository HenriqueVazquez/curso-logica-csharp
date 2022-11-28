using System.Globalization;

namespace Negativos_matriz {
    class Program {
        static void Main(string[] args) {
            int m, i, n, j, somaLinhas = 0;
            bool temNegativo = false;

            do {
                Console.Write("Qual a quantidade de linhas da matriz? ");
                m = int.Parse(Console.ReadLine());
            }
            while (m < 0 && m > 10);

            do {
                Console.Write("Qual a quantidade de colunas da matriz? ");
                n = int.Parse(Console.ReadLine());
            }
            while (n < 0 && n > 10);

            int[,] mat = new int[m, n];

            for (i = 0; i < m; i++) {
                for (j = 0; j < n; j++) {
                    Console.Write("Elemento [" + i + "," + j + "]: ");
                    mat[i, j] = int.Parse(Console.ReadLine());
                }

            }

            for (i = 0; i < m; i++) {
                for (j = 0; j < n; j++) {
                    if (mat[i, j] < 0) {
                        temNegativo = true;
                    }
                }
            }

            if (temNegativo == true) {
                Console.WriteLine("VALORES NEGATIVOS: ");
            }


            for (i = 0; i < m; i++) {
                for (j = 0; j < n; j++) {
                    if (mat[i, j] < 0) {
                        Console.WriteLine(mat[i, j]);
                    }
                }
            }
        }
    }
}