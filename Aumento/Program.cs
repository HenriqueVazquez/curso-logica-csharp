using System.Globalization;

namespace Aumento {
    class Program {
        static void Main(string[] args) {
            double salario, salarioAtualizado, aumento, porcentagem = 0;
            CultureInfo CI = CultureInfo.InvariantCulture;

            Console.WriteLine("Calcular ajuste do funcionario");

            Console.Write("Digite o salrio do funcionario: ");
            salario = double.Parse(Console.ReadLine().Replace(',', '.'), CI);

            if (salario <= 1000) {
                porcentagem = 0.20;
            }
            else if
            (salario <= 3000) {
                porcentagem = 0.15;
            }
            else if (
                salario <= 8000) {
                porcentagem = 0.10;
            }
            else {
                Console.Write("Calcule novamente");
            }

            aumento = salario * porcentagem;
            salarioAtualizado = salario + aumento;

            Console.WriteLine("Novo salario = " + salarioAtualizado.ToString("F2", CI));
            Console.WriteLine("Aumento = " + aumento.ToString("F2", CI));
            Console.WriteLine("Porcentagem = " + porcentagem * 100 + " %");
        }
    }
}