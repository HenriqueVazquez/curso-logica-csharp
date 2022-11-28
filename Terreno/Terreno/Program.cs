using System.Globalization;

namespace terreno {
    class Program {
        static void Main(string[] args) {
            double largura, comprimento, valorMetro, area, precoTerreno;
            CultureInfo CI = CultureInfo.InvariantCulture;

            largura = 0;
            comprimento = 0;
            valorMetro = 0;
            area = 0;
            precoTerreno = 0;

            Console.Write("Digite a largura do terreno: ");
            largura = double.Parse(Console.ReadLine().Replace(',', '.'), CI);
            

            Console.Write("Digite o comprimento do terreno: ");
            comprimento = double.Parse(Console.ReadLine().Replace(',', '.'), CI);

            Console.Write("Digite o valor do metro quadrado: ");
            valorMetro = double.Parse(Console.ReadLine().Replace(',', '.'), CI);

            area = largura * comprimento;
            precoTerreno = area * valorMetro;

            Console.WriteLine("Lagura do terreno: " + largura.ToString("F2", CI));
            Console.WriteLine("Comprimento do terreno: " + comprimento.ToString("F2", CI));

            Console.WriteLine("Valor do metro quadrado: " + valorMetro.ToString("F2", CI));
            Console.WriteLine("Area do terreno: " + area.ToString("F2", CI));

            Console.WriteLine("Preço do terreno: " + precoTerreno.ToString("F2", CI));

        }
    }
}
