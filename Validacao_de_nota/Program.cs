using System.Globalization;

namespace Validacao_de_notas {
    class Program {
        static void Main(string[] args) {
            double nota1, nota2, media;
            CultureInfo CI = CultureInfo.InvariantCulture;

            Console.Write("Digite a primeira nota: ");
            nota1 = double.Parse(Console.ReadLine().Replace(',', '.'), CI);

            while (nota1 < 0 || nota1 > 10) {
                Console.Write("Valor invalido! Tente novamente: ");
                nota1 = double.Parse(Console.ReadLine().Replace(',', '.'), CI);
            }

            Console.Write("Digite a segunda nota: ");
            nota2 = double.Parse(Console.ReadLine().Replace(',', '.'), CI);
            

            while (nota2 < 0 || nota2 > 10) {
                Console.Write("Valor invalido! Tente novamente: ");
                nota2 = double.Parse(Console.ReadLine().Replace(',', '.'), CI);
            }

            media = (double)(nota1 + nota2) / 2;
            Console.WriteLine("MEDIA = " + media.ToString("F2", CI));
        }
    }
}