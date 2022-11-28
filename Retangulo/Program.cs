using System.Globalization;

namespace Retangulo {
    class Program {
        static void Main(string[] args) {
            double baseRetangulo = 0, altura = 0, area = 0, perimetro = 0, diagonal = 0;
            CultureInfo CI = CultureInfo.InvariantCulture;

            Console.Write("Digite a base do retangulo: ");
            baseRetangulo = double.Parse(Console.ReadLine().Replace(',', '.'), CI); ;
            Console.Write("Digite altura do retangulo: ");
            altura = double.Parse(Console.ReadLine().Replace(',', '.'), CI); ;


            area = baseRetangulo * altura;
            perimetro = 2 * (baseRetangulo + altura);
            diagonal = Math.Sqrt(Math.Pow(baseRetangulo, 2) + Math.Pow(altura, 2));

            Console.WriteLine("Area: " + area.ToString("F4", CI));
            Console.WriteLine("Perimetro: " + perimetro.ToString("F4", CI));
            Console.WriteLine("Diagonal: " + diagonal.ToString("F4", CI));
        }
    }
}
