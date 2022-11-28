using System.Globalization;

namespace Troco_verificado {
    class Program {
        static void Main(string[] args) {
            int x, y;
            string ordem;

            Console.Write("Digite o primeiro numero:  ");
            x = int.Parse(Console.ReadLine());
            Console.Write("Digite o primeiro numero:  ");
            y = int.Parse(Console.ReadLine());

            while (x != y) {
                if (x > y) {
                    ordem = "Decrescente";
                }
                else {
                    ordem = "Crescente";
                }
                Console.WriteLine("A ordem de " + x + " e " + y + " eh: " + ordem);

                Console.Write("Digite o primeiro numero:  ");
                x = int.Parse(Console.ReadLine());
                Console.Write("Digite o primeiro numero:  ");
                y = int.Parse(Console.ReadLine());
            }
            Console.WriteLine("FIM");
        }
    }
}