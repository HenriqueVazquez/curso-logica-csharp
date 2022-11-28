using System.Globalization;

namespace MediaIdade {
    class Program {
        static void Main(string[] args) {
            int idade, soma, cont;
            double media;
            CultureInfo CI = CultureInfo.InvariantCulture;

            soma = 0;
            cont = 0;
            Console.WriteLine("Digite as idades: ");
            idade = int.Parse(Console.ReadLine());

            while (idade >= 0) {
                soma = soma + idade;
                cont = cont + 1;
                idade = int.Parse(Console.ReadLine());
            }
            if (cont == 0) {
                Console.WriteLine("IMPOSSIVEL CALCULAR");
            }
            else {
                media = (double)soma / cont;

                Console.WriteLine("MEDIA = " + media.ToString("F2", CI));
            }
        }
    }
}