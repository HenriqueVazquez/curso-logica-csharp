using System.Globalization;

namespace Retangulo {
    class Program {
        static void Main(string[] args) {
            string nome;
            double valorHora, pagamento;
            int horasTrabalhadas;
            CultureInfo CI = CultureInfo.InvariantCulture;

            Console.Write("Nome: ");            
             nome = Console.ReadLine();
            Console.Write("Valor por hora: ");
            valorHora = double.Parse(Console.ReadLine().Replace(',', '.'), CI);
            Console.Write("Horas trabalhadas: ");
            horasTrabalhadas = int.Parse(Console.ReadLine());

            pagamento = (double)valorHora * horasTrabalhadas;

            Console.WriteLine("O pagamento para " + nome + " deve ser R$ " + pagamento.ToString("F2", CI));
        }
    }
}