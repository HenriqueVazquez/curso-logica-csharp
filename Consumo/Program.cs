using System.Globalization;

namespace Consumo {
    class Program {
        static void Main(string[] args) {
            double distancia, combustivelGasto, consumo;
            CultureInfo CI = CultureInfo.InvariantCulture;

            Console.WriteLine("Calculo de consumo:");
            Console.Write("Distancia percorrida: ");
            distancia = double.Parse(Console.ReadLine().Replace(',', '.'), CI); 
            Console.Write("Combustível gasto: ");
            combustivelGasto = double.Parse(Console.ReadLine().Replace(',', '.'), CI); 

            consumo = distancia / combustivelGasto;

            Console.WriteLine("O consumo medio = " + consumo.ToString("F3", CI));
        }
    }
}