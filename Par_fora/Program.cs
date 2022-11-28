using System.Globalization;

namespace Validacao_de_notas {
    class Program {
        static void Main(string[] args) {
            int N, i, x;

            Console.Write("Quantos numeros voce vai digitar? ");
            N = int.Parse(Console.ReadLine());

            for (i = 1; i <= N; i++) {
                Console.Write("Digite um numero: ");
                x = int.Parse(Console.ReadLine());

                if (x == 0) {
                    Console.WriteLine("NULO" );
                }
                else if (x % 2 == 0) {
                    if (x < 0) {
                        Console.WriteLine("PAR NEGATIVO" );
                    }
                    else {
                        Console.WriteLine("PAR POSITIVO" );
                    }
                }
                else if (x < 0) {
                    Console.WriteLine("IMPAR NEGATIVO" );
                }
                else {
                    Console.WriteLine("IMPAR POSITIVO" );
                }
            }
        }
    }
}