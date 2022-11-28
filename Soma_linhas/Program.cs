using System.Globalization;

namespace Soma_linhas {
    class Program {
        static void Main(string[] args) {
            int m, i, n, j;
            double somaLinhas = 0;
            CultureInfo CI = CultureInfo.InvariantCulture;

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
            double[,] mat = new double[m, n] ;
            double[] vetor = new double[m];

            for (i = 0; i < m; i++) {
                for (j = 0; j < n; j++) {
                    Console.WriteLine("Digite os elementos da " + (i + 1) + "a linha:" );
                    mat[i , j] = double.Parse(Console.ReadLine().Replace(',', '.'), CI);
                }
            }

            for (i = 0; i < m; i++) {
                somaLinhas = 0;

                for (j = 0; j < n; j++) {
                    somaLinhas = somaLinhas + mat[i, j];
                }
                vetor[i] = somaLinhas;
            }

            Console.WriteLine("VETOR GERADO:");

            for (i = 0; i < m; i++) {
                Console.WriteLine(vetor[i].ToString("F1", CI));
            }
        }
    }
}
 