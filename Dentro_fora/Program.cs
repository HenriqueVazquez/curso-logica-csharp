using System.Globalization;

namespace Dentro_fora {
    class Program {
        static void Main(string[] args) {
            int x = 0, n = 0, dentro = 0, fora = 0, i = 0;



            do {
                Console.Write("Quantos numeros voce vai digitar? ");
                n = int.Parse(Console.ReadLine());

                for (i = 1; i <= n; i++) {
                    Console.Write("Digite um numero: ");
                   x = int.Parse(Console.ReadLine());

                    if (x >= 10 && x <= 20) {
                        dentro = dentro + 1;
                    }
                    else {
                        fora = fora + 1;
                    }
                }

                Console.WriteLine(dentro + " DENTRO" );
                Console.WriteLine(fora + " FORA" );
            }
            while (x == 0);

        }
    }
}