using System.Globalization;

namespace Idades {
    class Program {
        static void Main(string[] args) {
            CultureInfo CI = CultureInfo.InvariantCulture;
            double mediaIdade;
            int idade1, idade2;
            string nome1, nome2;

            Console.WriteLine("Dados da primeira pessoa: ");
            Console.Write("Nome: ");
            nome1 = Console.ReadLine();
            Console.Write("idade: ");
            idade1 = int.Parse(Console.ReadLine()); ;
            Console.WriteLine("Dados da segunda pessoa:" );
            Console.Write("Nome: ");
            nome2 = Console.ReadLine();
            Console.Write("idade: ");
            idade2 = int.Parse(Console.ReadLine()); ;


            mediaIdade = (double)(idade1 + idade2) / 2.0;

            Console.WriteLine("A idade media de " + nome1 + " e " + nome2 + " e de " + mediaIdade.ToString("F1", CI) + " anos!" );

        }
    }
}