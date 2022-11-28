using System.Globalization;

namespace Aprovados {
    class Program {
        static void Main(string[] args) {
            CultureInfo CI = CultureInfo.InvariantCulture;
            int i = 0, n = 0;
            bool temAprovado = false;

            do {
                Console.Write("Quantas pessoas voce vai digitar? ");
                n = int.Parse(Console.ReadLine());
            }
            while (n < 0 && n > 10);

            double[] mediasNotas = new double[n];
            double[] vetNota1 = new double[n];
            double[] vetNota2 = new double[n];
            string[] aprovados = new string[n];
            string[] vetNome = new string[n];


            for (i = 0; i < n; i++) {
                Console.WriteLine("Digite nome, primeira e segunda nota do " + (i + 1) + "o aluno: ");
                vetNome[i] = Console.ReadLine();
                vetNota1[i] = double.Parse(Console.ReadLine().Replace(',', '.'), CI);
                vetNota2[i] = double.Parse(Console.ReadLine().Replace(',', '.'), CI);

            }



            for (i = 0; i < n; i++) {
                mediasNotas[i] = (double)(vetNota1[i] + vetNota2[i]) / 2;
            }

            for (i = 0; i < n; i++) {
                if (mediasNotas[i] >= 6) {
                    temAprovado = true;
                    aprovados[i] = vetNome[i];
                }
            }

            Console.WriteLine();
            if (temAprovado == true) {
                Console.WriteLine("Alunos aprovados: ");
                for (i = 0; i < n; i++) {
                    if (mediasNotas[i] >= 6) {
                        Console.WriteLine(aprovados[i]);
                    }

                }
            }
        }
    }
}