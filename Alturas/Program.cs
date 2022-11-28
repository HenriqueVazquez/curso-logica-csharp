using System.Globalization;

namespace Alturas {
    class Program {
        static void Main(string[] args) {
            int i = 0, n = 0, somaMaiorIdade = 0;
            double somaAltura = 0, mediaAltura = 0, porcentagemMenorIdade = 0;
            CultureInfo CI = CultureInfo.InvariantCulture;

            do {
                Console.Write("Quantas pessoas serao digitadas? ");
                n = int.Parse(Console.ReadLine());
            }
            while (n < 0 && n > 10);

            double[] vetAltura = new double[n];
            int[] vetIdade = new int[n];
            string[] vetNome = new string[n];


            for (i = 0; i < n; i++) {
                Console.WriteLine("Dados da " + (i + 1) + "a pessoa: ");
                Console.Write("Nome: ");
                vetNome[i] = Console.ReadLine();

                Console.Write("Idade: ");
                vetIdade[i] = int.Parse(Console.ReadLine());

                Console.Write("Altura: ");
                vetAltura[i] = double.Parse(Console.ReadLine().Replace(',', '.'), CI);
                Console.WriteLine(" ");
            }

            for (i = 0; i < n; i++) {
                somaAltura = somaAltura + vetAltura[i];
            }

            mediaAltura = somaAltura / n;

            Console.WriteLine("Altura média: " + mediaAltura.ToString("F2", CI));


            for (i = 0; i < n; i++) {
                if (vetIdade[i] < 16) {
                    somaMaiorIdade = somaMaiorIdade + 1;
                }
            }

            porcentagemMenorIdade = (double)(somaMaiorIdade * 100) / n;

            Console.WriteLine("Pessoas com menos de 16 anos: " + porcentagemMenorIdade.ToString("F1", CI) + "%");


            for (i = 0; i < n; i++) {
                if (vetIdade[i] < 16) {
                    Console.WriteLine(vetNome[i]);
                }
            }
        }
    }
}