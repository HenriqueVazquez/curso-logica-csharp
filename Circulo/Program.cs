using System.Globalization;

namespace Retangulo {
    class Program {
        static void Main(string[] args) {
            double raio, area, pi = 3.14159;
            CultureInfo CI = CultureInfo.InvariantCulture;

            Console.WriteLine("Area de um criculo:");

            Console.Write("Informe o raio: ");
            raio = double.Parse(Console.ReadLine().Replace(',', '.'), CI); 


            area = pi * Math.Pow(raio, 2);

            Console.WriteLine("Area = " + area.ToString("F3", CI));
        }
    }
}