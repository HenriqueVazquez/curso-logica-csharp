using System.Globalization;

namespace Comerciante {
    class Program {
        static void Main(string[] args) {
            int i = 0, n = 0, j = 0, lucroMenor10 = 0, lucroEntre10e20 = 0, lucroAcima20 = 0;
            double valorTotalCompra = 0, valorTotalVenda = 0, valorTotalLucro = 0;
            CultureInfo CI = CultureInfo.InvariantCulture;

            do {
                Console.Write("Serao digitados dados de quantos produtos? ");
                n = int.Parse(Console.ReadLine());
            }
            while (n < 0 && n > 10);

            double[] vetPrecoCompra = new double[n];
            double[] vetPrecoVenda = new double[n];
            double[] vetLucro = new double[n];
            string[] vetNome = new string[n];

            for (i = 0; i < n; i++) {
                Console.WriteLine("Produto: " + (i + 1) );
                Console.Write("Nome: ");
               vetNome[i] = Console.ReadLine();

                Console.Write("Preco de compra: ");
                vetPrecoCompra[i] = double.Parse(Console.ReadLine().Replace(',', '.'), CI);

                Console.Write("Preco de venda: ");
                vetPrecoVenda[i] = double.Parse(Console.ReadLine().Replace(',', '.'), CI);
                Console.WriteLine();
            }


            for (i = 0; i < n; i++) {
                vetLucro[i] = (double)((vetPrecoVenda[i] * 100) / vetPrecoCompra[i]) - 100;
            }

            for (i = 0; i < n; i++) {
                if (vetLucro[i] < 10) {
                    lucroMenor10 = lucroMenor10 + 1;
                }
                else {
                    if (vetLucro[i] >= 10 && vetLucro[i] < 20) {
                        lucroEntre10e20 = lucroEntre10e20 + 1;
                    }
                    else {

                        lucroAcima20 = lucroAcima20 + 1;

                    }
                }
            }

            for (i = 0; i < n; i++) {
                valorTotalCompra = valorTotalCompra + vetPrecoCompra[i];
                valorTotalVenda = valorTotalVenda + vetPrecoVenda[i];


            }
            valorTotalLucro = valorTotalVenda - valorTotalCompra;

            Console.WriteLine("RELATORIO: " );
            Console.WriteLine("Lucro abaixo de 10%: " + lucroMenor10 );
            Console.WriteLine("Lucro entre 10% e 20%: " + lucroEntre10e20 );
            Console.WriteLine("Lucro acima de 20%: " + lucroAcima20 );
            Console.WriteLine("Valor total de compra: " + valorTotalCompra.ToString("F2", CI));
            Console.WriteLine("Valor total de venda: " + valorTotalVenda.ToString("F2", CI));
            Console.WriteLine("Lucro total: " + valorTotalLucro.ToString("F2", CI));
        }
    }
}