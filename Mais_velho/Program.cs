using System.Globalization;

namespace Mais_velho {
    class Program {
        static void Main(string[] args) {
            int i = 0, n = 0, j = 0, posicaoMaisVelho = 0;

            do {
                Console.Write("Quantas pessoas voce vai digitar? ");
                n = int.Parse(Console.ReadLine());
            }
            while (n < 0 && n > 10);
            int[] vetIdade = new int[n];
            string[] vetNome = new string[n];

            for (i = 0; i < n; i++) {
                Console.WriteLine("Dados da " + (i + 1) + "a pessoa: " );
                Console.Write("Nome: ");
               vetNome[i] = Console.ReadLine();

                Console.Write("Idade: ");
                vetIdade[i] = int.Parse(Console.ReadLine());
                Console.WriteLine();
            }

            for (i = 0; i < n; i++) {
                for (j = 0; j < n; j++) {
                    if (vetIdade[i] >= vetIdade[j] && vetIdade[i] >= vetIdade[posicaoMaisVelho]) {
                        posicaoMaisVelho = i;
                    }
                }
            }
            Console.WriteLine("PESSOA MAIS VELHA: " + vetNome[posicaoMaisVelho] );
        }
    }
}