using System.Globalization;

namespace Notas {
    class Program {
        static void Main(string[] args) {
            double nota1, nota2, notaFinal;
            CultureInfo CI = CultureInfo.InvariantCulture;


            Console.Write("Digite a primeira nota: ");
            nota1 = double.Parse(Console.ReadLine().Replace(',', '.'), CI);
            Console.Write("Digite a segunda nota: ");
            nota2 = double.Parse(Console.ReadLine().Replace(',', '.'), CI);

            notaFinal = nota1 + nota2;

           
            Console.WriteLine("NOTA FINAL = " + notaFinal.ToString("F1", CI));
           
            if (notaFinal < 60.0) {
                Console.WriteLine("REPROVADO" );
            }
            else {
                Console.WriteLine("APROVADO" );
            }
        }
    }
}