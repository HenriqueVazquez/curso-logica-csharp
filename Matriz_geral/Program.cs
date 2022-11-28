using System.Globalization;

namespace Matriz_geral {
    class Program {
        static void Main(string[] args) {
            int i = 0, n = 0, j = 0, linhaEscolhida = 0, colunaEscolhida = 0;
            double somaPositivos = 0;
            CultureInfo CI = CultureInfo.InvariantCulture;

            do {
                Console.Write("Qual a ordem da matriz? ");
                n = int.Parse(Console.ReadLine());

            }
            while (n <= 0 || n > 10);

            double[,] mat = new double[n , n] ;




            for (i = 0; i < n; i++) {
                for (j = 0; j < n; j++) {
                    Console.Write("Elemento [" + i + "," + j + "]: ");
                    mat[i , j] = double.Parse(Console.ReadLine().Replace(',', '.'), CI);
                }
            }

            for (i = 0; i < n; i++) {
                for (j = 0; j < n; j++) {
                    if (mat[i , j] >= 0) {
                        somaPositivos = somaPositivos + mat[i , j];
                    }
                }
            }


            Console.WriteLine("\nSOMA DOS POSITIVOS: " + somaPositivos.ToString("F1", CI));
            Console.WriteLine();

            Console.WriteLine("Escolha uma linha: ");
            linhaEscolhida = int.Parse(Console.ReadLine());

            Console.Write("LINHA ESCOLHIDA: ");

            for (i = 0; i < n; i++) {
                Console.Write(mat[linhaEscolhida , i].ToString("F1", CI) + " ");
            }

            Console.Write("\n\nEscolha uma coluna: ");
            colunaEscolhida = int.Parse(Console.ReadLine());

            Console.Write("COLUNA ESCOLHIDA: ");
            for ( i = 0; i < n; i++) {
                Console.Write(mat[i ,colunaEscolhida].ToString("F1", CI) + " ");
            }
            Console.WriteLine();


            Console.Write("\n\nDIAGONAL PRINCIPAL: ");
            for (i = 0; i < n; i++)
                for ( i = 0; i < n; i++) {
                    Console.Write(mat[i ,i].ToString("F1", CI) + " ");
                }

            for ( i = 0; i < n; i++) {
                for ( j = 0; j < n; j++) {
                    if (mat[i,j] < 0) {
                        mat[i,j] = Math.Pow(mat[i,j], 2);
                    }
                }
            }

            Console.WriteLine("\n\nMATRIZ ALTERADA: " );

            for ( i = 0; i < n; i++) {
                for ( j = 0; j < n; j++) {
                    Console.Write(mat[i , j].ToString("F1", CI) + " ");
                }
                Console.WriteLine();
            }
        }
    }
}