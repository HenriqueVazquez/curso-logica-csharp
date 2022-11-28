using System.Globalization;

namespace Lanchonete {
    class Program {
        static void Main(string[] args) {
            int codigo, quantidade;
            double valorPago = 0;
            CultureInfo CI = CultureInfo.InvariantCulture;

            Console.Write("Codigo do produto comprado: ");
            codigo = int.Parse(Console.ReadLine());
            Console.Write("Quantidade comprada: ");
            quantidade = int.Parse(Console.ReadLine());

            switch (codigo) {
                case 1:
                    valorPago = 5.0 * quantidade;
                    break;
                case 2:
                    valorPago = 3.5 * quantidade;
                    break;
                case 3:
                    valorPago = 4.8 * quantidade;
                    break;
                case 4:
                    valorPago = 8.9 * quantidade;
                    break;
                case 5:
                    valorPago = 7.32 * quantidade;
                    break;
            }

            Console.WriteLine("Valor a pagar: R$ " + valorPago.ToString("F2", CI));
        }
    }
}
