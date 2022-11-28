using System.Globalization;

namespace Pares_Consecutivos {
    class Program {
        static void Main(string[] args) {
            int X, soma;

            Console.Write("Digite um numero inteiro: ");
            X  = int.Parse(Console.ReadLine());

            while (X != 0) {

                if (X % 2 != 0) {
                    X = X + 1;
                }

                soma = 5 * X + 20;
                Console.WriteLine("SOMA = " + soma );

                Console.Write("Digite um numero inteiro: ");
                X = int.Parse(Console.ReadLine());

            }
        }
    }
}