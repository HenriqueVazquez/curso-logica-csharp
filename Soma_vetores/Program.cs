using System.Globalization;

namespace Soma_vetores {
    class Program {
        static void Main(string[] args) {
            int i = 0, n = 0, j = 0;

            do {
                Console.Write("Quantos valores vai ter cada vetor? ");
                n = int.Parse(Console.ReadLine());
            }
            while (n < 0 && n > 10);

            int[] vetNumeroA = new int[n];
            int[] vetNumeroB = new int[n];
            int[] vetNumeroC = new int[n];

            Console.WriteLine("Digite os valores do vetor A: ");
            for (i = 0; i < n; i++) {
                vetNumeroA[i] = int.Parse(Console.ReadLine());
            }

            Console.WriteLine("Digite os valores do vetor B: ");
            for (i = 0; i < n; i++) {
                vetNumeroB[i] = int.Parse(Console.ReadLine());
            }

            for (i = 0; i < n; i++) {
                vetNumeroC[i] = vetNumeroA[i] + vetNumeroB[i];
            }


            Console.WriteLine("VETOR RESULTANTE:");
            for (i = 0; i < n; i++) {
                Console.WriteLine(vetNumeroC[i]);
            }
        }
    }
}