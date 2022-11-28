
namespace Acima_diagonal {
    class Program {
        static void Main(string[] args) {
            int i = 0, n = 0, j = 0, somaDiagonalPrincipal = 0, controleSoma = 0;

            do {
                Console.Write("Qual a quantidade de colunas da matriz? ");
                n = int.Parse(Console.ReadLine());
            }
            while (n < 0 && n > 10);

            int[,] mat = new int[n, n];

            for (i = 0; i < n; i++) {
                for (j = 0; j < n; j++) {
                    Console.Write("Elemento [" + i + "," + j + "]: ");
                    mat[i, j] = int.Parse(Console.ReadLine());
                }
            }

            for (i = 0; i < n; i++) {
                for (j = i + 1; j < n; j++) {
                    somaDiagonalPrincipal = somaDiagonalPrincipal + mat[i, j];
                }
            }
            Console.WriteLine("SOMA DOS ELEMENTOS ACIMA DA DIAGONAL PRINCIPAL = " + somaDiagonalPrincipal);
        }
    }
}