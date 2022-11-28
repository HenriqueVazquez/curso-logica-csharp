using System.Globalization;

namespace Soma_vetor {
    class Program {
        static void Main(string[] args) {
            double soma, media;
            int i, n;
            CultureInfo CI = CultureInfo.InvariantCulture;

            soma = 0;

            do {
                Console.Write("Quantos numeros voce vai digitar? ");
                n = int.Parse(Console.ReadLine());
            }
            while (n < 0 && n > 10);

            double[] vet = new double[n];

            for (i = 0; i < n; i++) {
                Console.Write("Digite um numero para somar: ");
                vet[i] = double.Parse(Console.ReadLine().Replace(',', '.'), CI);
            }

            Console.Write("VALORES = ");
            for (i = 0; i < n; i++) {
                Console.Write(vet[i].ToString("F1", CI) + " ");


            }

            for (i = 0; i < n; i++) {
                soma = soma + vet[i];
            }

            media = (double)soma / n;

            Console.WriteLine(" ");
            Console.WriteLine("SOMA = " + soma.ToString("F2", CI));
            Console.WriteLine("Media = " + media.ToString("F2", CI));
        }
    }
}