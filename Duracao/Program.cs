using System.Globalization;

namespace Medidas {
    class Program {
        static void Main(string[] args) {
            int duracao, segundos, horas, resto, minutos;

            Console.WriteLine("duração: ");
            Console.Write("Digite a duração em segundos: ");
            duracao = int.Parse(Console.ReadLine());


            horas = duracao / 3600;
            resto = duracao % 3600;

            minutos = resto / 60;
            segundos = resto % 60;

            Console.WriteLine(horas + ":" + minutos + ":" + segundos );
        }
    }
}