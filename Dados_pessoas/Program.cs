using System.Globalization;

namespace Dados_pessoas {
    class Program {
        static void Main(string[] args) {
            int i = 0, n = 0, j = 0, totalHomens = 0, totalMulher = 0;
            double menorAltura = 0, maiorAltura = 0, somaAlturaMulheres = 0, mediaAlturaMulheres = 0;
            CultureInfo CI = CultureInfo.InvariantCulture;
            bool temMulher = false;

            do {
                Console.Write("Quantas pessoas voce vai digitar? ");
                n = int.Parse(Console.ReadLine());
            }
            while (n < 0 && n > 10);

            double[] vetAltura = new double[n];
            char[] vetGenero = new char[n];


            for (i = 0; i < n; i++) {
                Console.Write("Altura da " + (i + 1) + "a pessoa: ");
                vetAltura[i] = double.Parse(Console.ReadLine().Replace(',', '.'), CI);

                do {
                    Console.Write("Genero da " + (i + 1) + "a pessoa: ");
                    vetGenero[i] = char.Parse(Console.ReadLine());

                }
                while ((vetGenero[i] != 'F' && vetGenero[i] != 'f') && (vetGenero[i] != 'm' && vetGenero[i] != 'M'));
                Console.WriteLine();
            }

            menorAltura = vetAltura[0];
            menorAltura = vetAltura[0];
            for (i = 0; i < n; i++) {
                for (j = 0; j < n; j++) {
                    if (vetAltura[i] <= vetAltura[j] && vetAltura[i] <= menorAltura) {
                        menorAltura = vetAltura[i];
                    }
                }
            }

            for (i = 0; i < n; i++) {
                for (j = 0; j < n; j++) {
                    if (vetAltura[i] >= vetAltura[j] && vetAltura[i] >= maiorAltura) {
                        maiorAltura = vetAltura[i];
                    }
                }
            }


            for (i = 0; i < n; i++) {
                if (vetGenero[i] == 'F' || vetGenero[i] == 'f') {
                    somaAlturaMulheres = somaAlturaMulheres + vetAltura[i];
                    temMulher = true;
                    totalMulher = totalMulher + 1;
                }
                else if (vetGenero[i] == 'M' || vetGenero[i] == 'm') {
                    totalHomens = totalHomens + 1;
                }
            }

            Console.WriteLine("Menor altura = " + menorAltura.ToString("F2", CI));
            Console.WriteLine("Maior altura = " + maiorAltura.ToString("F2", CI));

            if (temMulher == true) {
                mediaAlturaMulheres = (double)somaAlturaMulheres / totalMulher;
                Console.WriteLine("Media das alturas das mulheres = " + mediaAlturaMulheres.ToString("F2", CI));
            }
            else {
                Console.WriteLine("Não foi possivel calcular media, mão há mulheres informadas");
            }
            Console.WriteLine("Numero de homens = " + totalHomens);
        }
    }
}