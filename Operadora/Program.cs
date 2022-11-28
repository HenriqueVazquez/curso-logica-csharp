using System.Globalization;

namespace Operadora {
    class Program {
        static void Main(string[] args) {
            int minutos;
            double valor = 50;
            CultureInfo CI = CultureInfo.InvariantCulture;

            Console.Write("Digite a quantidade de minutos: ");
            minutos = int.Parse(Console.ReadLine()); 

            if (minutos > 100) {
                valor = (minutos - 100) * 2 + 50;

            }

            Console.WriteLine("Valor a pagar:  " + valor.ToString("F2", CI));
        }
    }
}