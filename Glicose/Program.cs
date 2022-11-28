using System.Globalization;

namespace Troco_verificado {
    class Program {
        static void Main(string[] args) {
            double glicose;
            string classificacao;
            CultureInfo CI = CultureInfo.InvariantCulture;

            Console.Write("Digite a medida da glicose: ");
             glicose = double.Parse(Console.ReadLine().Replace(',', '.'), CI);

            if (glicose <= 100) {
                classificacao = "Normal";
            }
            else if (glicose <= 140) {
                classificacao = "Elevado";
            }
            else {
                classificacao = "Diabetes";
            }
            Console.WriteLine("Classificacao: " + classificacao );
        }
    }
}