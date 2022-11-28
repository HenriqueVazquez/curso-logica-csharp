using System.Globalization;

namespace Soma {
    class Program {
        static void Main(string[] args) {
            int x, y, soma;

            Console.WriteLine("Some dois numeros: ");

            Console.Write("Digite x: ");
            x = int.Parse(Console.ReadLine());
            Console.Write("Digite y: ");
            y = int.Parse(Console.ReadLine());

            soma = x + y;

            Console.WriteLine("Soma = " + soma);
        }
    }
}