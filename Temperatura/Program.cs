using System.Globalization;

namespace Temperatura {
    class Program {
        static void Main(string[] args) {
            double temperatura, temperaturaConvertida = 0;
            char unidadeMedida, unidadeMedidaResposta;
            string unidadeResposta;
            CultureInfo CI = CultureInfo.InvariantCulture;

            Console.Write("Voce vai digitar a temperatura em qual escala (C/F)? ");
            unidadeMedida = char.Parse(Console.ReadLine()); 

            if (unidadeMedida == 'F' || unidadeMedida == 'f') {
                Console.Write("Digite a temperatura em Fahrenheit: ");
                temperatura = double.Parse(Console.ReadLine().Replace(',', '.'), CI);
                temperaturaConvertida = (5.0 / 9.0) * (temperatura - 32.0);
                unidadeResposta = "celsius";
                unidadeMedidaResposta = 'C';

            }
            else if (unidadeMedida == 'C' || unidadeMedida == 'c') {
                Console.Write("Digite a temperatura em Celsius: ");
                temperatura = double.Parse(Console.ReadLine().Replace(',', '.'), CI);
                temperaturaConvertida = temperatura * 1.8 + 32;
                unidadeResposta = "fahrenheit";
                unidadeMedidaResposta = 'F';
            }
            else {
                unidadeResposta = "Conversão impossivel para unidade informada";
                unidadeMedidaResposta = 'z'; 

            }


            if (unidadeResposta == "Conversão impossivel para unidade informada") {
                Console.WriteLine(unidadeResposta);
            }
            else {

                Console.WriteLine("Temperatura equivalente em " + unidadeResposta + " : " + temperaturaConvertida.ToString("F2", CI) + "°" + unidadeMedidaResposta);
            }
        }
    }
}