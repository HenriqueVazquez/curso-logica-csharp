using System.Globalization;

namespace Retangulo {
    class Program {
        static void Main(string[] args) {
            double precoProduto, quantidade, pagamento, troco;
            CultureInfo CI = CultureInfo.InvariantCulture;

            Console.WriteLine("Caixa:");

            Console.Write("Preco unitário do produto: ");
            precoProduto = double.Parse(Console.ReadLine().Replace(',', '.'), CI);
            Console.Write("Quantidade comprada: ");
            quantidade = double.Parse(Console.ReadLine().Replace(',', '.'), CI);
            Console.Write("Dinheiro recebido: ");
            pagamento = double.Parse(Console.ReadLine().Replace(',', '.'), CI);

            troco = pagamento - precoProduto * quantidade;

            Console.WriteLine("troco = R$ " + troco.ToString("F2", CI));
        }
    }
}