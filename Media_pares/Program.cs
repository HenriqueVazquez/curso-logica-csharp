using System.Globalization;

namespace Media_pares {
    class Program {
        static void Main(string[] args) {
            int somaVetor = 0;
            double mediaPares = 0;
            int i = 0, n = 0, contPar = 0;
            bool temPar = false;
            CultureInfo CI = CultureInfo.InvariantCulture;

            do {
                Console.Write("Quantos numeros voce vai digitar? ");
                n = int.Parse(Console.ReadLine());
            }
            while (n < 0 && n > 10);

            int[] vetNumeros = new int[n];


            for (i = 0; i < n; i++) {
                Console.Write((i + 1) + "- Digite um numero: ");
                vetNumeros[i] = int.Parse(Console.ReadLine());
            }

            for (i = 0; i < n; i++) {
                if (vetNumeros[i] % 2 == 0) {
                    somaVetor = somaVetor + vetNumeros[i];
                    temPar = true;
                    contPar = contPar + 1;
                }
            }



            if (temPar != true) {

                Console.WriteLine("NENHUM NUMERO PAR" );
            }
            else {
                mediaPares = (double)somaVetor / contPar;

                Console.WriteLine("MEDIA DOS PARES = " + mediaPares.ToString("F1", CI));
            }
        }
    }
}