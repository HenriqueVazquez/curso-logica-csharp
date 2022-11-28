using System.Globalization;

namespace Baskara {
    class Program {
        static void Main(string[] args) {
            double a, b, c, x1, x2, delta;
            CultureInfo CI = CultureInfo.InvariantCulture;


            Console.Write("Coeficiente a: ");
            a = double.Parse(Console.ReadLine().Replace(',', '.'), CI);
            Console.Write("Coeficiente b: ");
            b = double.Parse(Console.ReadLine().Replace(',', '.'), CI);
            Console.Write("Coeficiente c: ");
            c = double.Parse(Console.ReadLine().Replace(',', '.'), CI);

            delta = Math.Pow(b, 2) - 4 * a * c;

            if (a == 0 || delta < 0) {
                Console.WriteLine("Esta equacao nao possui raizes reais");
            }
            else {

                x1 = (-b + Math.Sqrt(delta)) / (2 * a);
                x2 = (-b - Math.Sqrt(delta)) / (2 * a);
                Console.WriteLine("X1 = " + x1.ToString("F4", CI));
                Console.WriteLine("X2 = " + x2.ToString("F4", CI));
            }
        }
    }
}