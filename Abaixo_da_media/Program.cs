using System.Globalization;

namespace Abaixo_da_media {
    class Program {
        static void Main(string[] args) {
            CultureInfo CI = CultureInfo.InvariantCulture;
            double mediaVetor = 0, somaVetor = 0;
            int i, n;
            bool abaixoMedia = false;

            do {
                Console.Write("Quantos numeros voce vai digitar? ");
                n = int.Parse(Console.ReadLine());
            }
            while (n < 0 && n > 10);

            double[] vetNumeros = new double[n];



            for (i = 0; i < n; i++) {
                Console.Write("Digite um numero: ");
                vetNumeros[i] = double.Parse(Console.ReadLine().Replace(',', '.'), CI);
            }

            for (i = 0; i < n; i++) {
                somaVetor = somaVetor + vetNumeros[i];
            }
            Console.WriteLine();

           mediaVetor = (double)somaVetor / n;

            Console.WriteLine("MEDIA DO VETOR = " + mediaVetor.ToString("F3", CI));

            for (i = 0; i < n; i++) {
                if (vetNumeros[i] < mediaVetor) {
                    abaixoMedia = true;
                }
            }

            if (abaixoMedia == true) {
                Console.WriteLine("ELEMENTOS ABAIXO DA MEDIA: " );
            }
            
            for (i = 0; i < n; i++) {
                if (vetNumeros[i] < mediaVetor) {
                    Console.WriteLine(vetNumeros[i].ToString("F1", CI));
                }
            }
        }
    }
}