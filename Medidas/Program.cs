using System.Globalization;

namespace Medidas {
    class Program {
        static void Main(string[] args) {
            double A, B, C, areaQuadrado, areaTriangulo, areaTrapezio;
            CultureInfo CI = CultureInfo.InvariantCulture;

            Console.Write("Digite a medida A: ");
            A = double.Parse(Console.ReadLine().Replace(',', '.'), CI); 
            Console.Write("Digite a medida B: ");
            B = double.Parse(Console.ReadLine().Replace(',', '.'), CI); 
            Console.Write("Digite a medida C: ");
            C = double.Parse(Console.ReadLine().Replace(',', '.'), CI); 

            areaQuadrado = A * A;
            areaTriangulo = (A * B) / 2;
            areaTrapezio = (A + B) / 2 * C;
            
            Console.WriteLine("QUADRADO = " + areaQuadrado.ToString("F4", CI));
            Console.WriteLine("TRIANGULO = " + areaTriangulo.ToString("F4", CI));
            Console.WriteLine("TRAPEZIO = " + areaTrapezio.ToString("F4", CI));
        }
    }
}