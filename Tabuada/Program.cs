using System.Globalization;

namespace Validacao_de_notas {
    class Program {
        static void Main(string[] args) {
            int n, i;

            Console.Write("Deseja a tabuada para qual valor ou digite 0 para sair? ");
             n  = int.Parse(Console.ReadLine());

            while (n != 0) {
                for (i = 1; i <= 10; i++) {
                    Console.WriteLine(n + " X " + i + " = " + (n * i) );
                }
                Console.Write("Deseja a tabuada para qual valor ou digite 0 para sair? ");
               n = int.Parse(Console.ReadLine());
            }
        }
    }
}