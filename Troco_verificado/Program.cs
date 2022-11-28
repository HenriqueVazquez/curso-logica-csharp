using System.Globalization;

namespace Troco_verificado {
    class Program {
        static void Main(string[] args) {
            double preco, dinheiro, troco, resto;
            int quantidade;
            CultureInfo CI = CultureInfo.InvariantCulture;

            Console.Write("Preco unitario do produto: ");
            preco = double.Parse(Console.ReadLine().Replace(',', '.'), CI);
            Console.Write("Quantidade comprada: ");
            quantidade = int.Parse(Console.ReadLine());
            Console.Write("Dinheiro recebido: ");
            dinheiro = double.Parse(Console.ReadLine().Replace(',', '.'), CI);

            if (dinheiro >= (preco * quantidade)) {
                troco = (double)dinheiro - preco * quantidade;

                Console.WriteLine("TROCO = " + troco.ToString("F2", CI));
            }
            else {
                resto = preco * quantidade - dinheiro;

                Console.WriteLine("DINHEIRO INSUFICIENTE. FALTAM " + resto.ToString("F2", CI) + " REAIS");
            }
        }
    }
}