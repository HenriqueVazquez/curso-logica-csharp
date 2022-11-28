using System.Globalization;

namespace Quadrante {
    class Program {
        static void Main(string[] args) {
            int x, y;
            string q;

            Console.Write("Digite os valores das coordenadas x:  ");
            x = int.Parse(Console.ReadLine());
            Console.Write("Digite os valores das coordenadas y:  ");
            y = int.Parse(Console.ReadLine());

            while (x != 0 || y != 0) {
                if (x > 0 && y > 0) {
                    q = "Q1";
                }
                else if (x < 0 && y > 0) {
                    q = "Q2";
                }
                else if (x < 0 && y < 0) {
                    q = "Q3";
                }
                else if (x > 0 && y < 0) {
                    q = "Q4";
                }
                else if (x == 0 && y == 0) {
                    q = "Origem";
                }
                else if (x == 0) {
                    q = "Eixo y";
                }
                else {
                    q = "Eixo x";
                }

                Console.WriteLine("QUADRANTE " + q );
                Console.Write("Digite os valores das coordenadas x:  ");
                x = int.Parse(Console.ReadLine());
                Console.Write("Digite os valores das coordenadas y:  ");
                y = int.Parse(Console.ReadLine());
            }
        }

    }
}