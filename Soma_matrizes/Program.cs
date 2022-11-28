namespace Soma_matrizes {
    class Program {
        static void Main(string[] args) {
            int m = 0, i = 0, n = 0, j = 0;


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

            int[,] matA = new int[m, n];
            int[,] matB = new int[m, n];
            int[,] matSoma = new int[m, n];

            Console.WriteLine("Digite os valores da matriz A: ");

            for (i = 0; i < m; i++) {
                for (j = 0; j < n; j++) {
                    Console.Write("Elemento [" + i + "," + j + "]: ");
                    matA[i, j] = int.Parse(Console.ReadLine());
                }
            }

            Console.WriteLine("Digite os valores da matriz B: ");

            for (i = 0; i < m; i++) {
                for (j = 0; j < n; j++) {
                    Console.Write("Elemento [" + i + "," + j + "]: ");
                    matB[i, j] = int.Parse(Console.ReadLine());

                }
            }

            for (i = 0; i < m; i++) {
                for (j = 0; j < n; j++) {
                    matSoma[i, j] = matA[i, j] + matB[i, j];
                }

            }

            Console.WriteLine("MATRIZ SOMA: ");

            for (i = 0; i < m; i++) {
                for (j = 0; j < n; j++) {
                    Console.Write(matSoma[i, j] + " ");
                }
                Console.WriteLine();
            }

        }
    }
}