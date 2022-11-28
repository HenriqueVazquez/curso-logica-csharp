using System.Globalization;

namespace Validacao_de_notas {
    class Program {
        static void Main(string[] args) {
            int x, y, soma, i, troca;


            Console.WriteLine("Digite dois numeros ou dua vezes o zero para finalizar: " );
            x = int.Parse(Console.ReadLine());
            y = int.Parse(Console.ReadLine());

            while (x != 0 || y != 0) {
                i = 0;
                soma = 0;

                if (x > y) {
                    troca = x;
                    x = y;
                    y = troca;
                }
                for (i = x + 1; i <= y - 1; i++) {
                    if (i % 2 != 0) {
                        soma = soma + i;
                    }
                }

                Console.WriteLine("Soma dos impare = " + soma );
                soma = 0;
                Console.WriteLine("Digite dois numeros (ou dua vezes o zero para finalizar): " );
                x = int.Parse(Console.ReadLine());
                y = int.Parse(Console.ReadLine());
            }
            
        }
    }
}