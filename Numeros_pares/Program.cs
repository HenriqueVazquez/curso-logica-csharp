using System.Globalization;

namespace Numeros_pares {
    class Program {
        static void Main(string[] args) {
            int i = 0, n = 0, somaPares;
            somaPares=0;


            do {
                Console.Write("Quantos numeros voce vai digitar? ");
                n = int.Parse(Console.ReadLine());
            }
            while (n < 0 && n > 10);

            int[] vetNumero = new int[n];


            for (i = 0; i < n; i++) {
                Console.Write("Digite um numero: ");
                vetNumero[i] = int.Parse(Console.ReadLine());

            }

            Console.WriteLine();
            Console.WriteLine("Numeros Pares: ");
            for (i = 0; i < n; i++) {
                if (vetNumero[i] % 2 == 0) {
                    Console.Write(vetNumero[i] + " ");
                    somaPares = somaPares + 1;
                }
            }

            Console.WriteLine(" ");
            Console.WriteLine("QUANTIDADE DE PARES = " + somaPares);
        }
    }
}