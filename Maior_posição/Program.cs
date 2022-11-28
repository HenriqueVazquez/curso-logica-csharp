using System.Globalization;

namespace Media_ponderada {
    class Program {
        static void Main(string[] args) {
            int i = 0, n = 0, j = 0, posicao = 0;
            double maiorNumero = 0;
            CultureInfo CI = CultureInfo.InvariantCulture;

            do {
                Console.Write("Quantos numeros voce vai digitar? ");
                n = int.Parse(Console.ReadLine());
            }
            while (n < 0 && n > 10);

            double[] vetNumero = new double[n];

            for (i = 0; i < n; i++) {
                Console.Write("Digite um numero: ");
                 vetNumero[i] = double.Parse(Console.ReadLine().Replace(',', '.'), CI);                
            }

            for (i = 0; i < n; i++) {
                for (j = 0; j < n; j++) {
                    if (vetNumero[i] >= vetNumero[j] && vetNumero[i] >= maiorNumero) {
                        maiorNumero = vetNumero[i];
                        posicao = i;
                    }
                }
            }

            Console.WriteLine("MAIOR VALOR = " + maiorNumero.ToString("F1", CI));
            Console.WriteLine();
            Console.WriteLine("POSICAO DO MAIOR VALOR = " + posicao );
        }
    }
}