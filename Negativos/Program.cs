using System.Globalization;

namespace Negativos {
    class Program {
        static void Main(string[] args) {
            int n, i;

            bool temNegativo = false;

            do {
                Console.Write("Quantos numeros voce vai digitar? ");
                n = int.Parse(Console.ReadLine());
            }
            while (n < 0 && n > 10);
            int[] vet = new int[n];

            for (i = 0; i < n; i++) {
                Console.Write("Digite um numero: ");
                vet[i] = int.Parse(Console.ReadLine());
            }

            for (i = 0; i < n; i++) {
                if (vet[i] < 0) {
                    temNegativo = true;
                }
            }
            Console.WriteLine();
            if (temNegativo == true) {
                Console.WriteLine("Numeros negativos: " );
            }
            else {
                Console.WriteLine("Não digitou numeros negativos: " );
            }

            for (i = 0; i < n; i++) {
                if (vet[i] < 0) {
                    Console.WriteLine(vet[i]);
                }
            }
        }
    }
}