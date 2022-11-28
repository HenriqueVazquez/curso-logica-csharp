using System.Globalization;

namespace Experiencias {
    class Program {
        static void Main(string[] args) {
            int N = 0, i = 0, qte = 0, totalCobaias = 0, totalSapos = 0, totalCoelhos = 0, totalRatos = 0, tipoCobaiaCorreto = 0;
            double pratos = 0, psapos = 0, pcoelhos = 0;
            char tipoCobaia;
            CultureInfo CI = CultureInfo.InvariantCulture;

            Console.Write("Quantos casos de teste serao digitados? ");
            N = int.Parse(Console.ReadLine());

            while (N <= 0) {
                N = 0;
                Console.WriteLine("Digite um numero inteiro? ");
                N = int.Parse(Console.ReadLine());
            }

            for (i = 1; i <= N; i++) {

                do {
                    Console.Write("Quantidade de cobaias: ");
                    qte = int.Parse(Console.ReadLine());
                }
                while (qte <= 0);

                do {
                    Console.WriteLine("Digite o tipo de cobaia correto:" );
                    Console.WriteLine("R para rato");
                    Console.WriteLine("S para sapo");
                    Console.WriteLine("C para coelho");
                    Console.Write("Tipo de cobaia: ");

                    tipoCobaia = char.Parse(Console.ReadLine());


                    if (tipoCobaia == 's' || tipoCobaia == 'S') {
                        tipoCobaiaCorreto = 1;
                    }
                    else if (tipoCobaia == 'c' || tipoCobaia == 'C') {
                        tipoCobaiaCorreto = 1;
                    }
                    else if (tipoCobaia == 'r' || tipoCobaia == 'R') {
                        tipoCobaiaCorreto = 1;
                    }
                    else {
                        tipoCobaiaCorreto = 0;
                    }
                }
                while (tipoCobaiaCorreto == 0);

                if (tipoCobaia == 's' || tipoCobaia == 'S') {
                    totalSapos = totalSapos + qte;
                }

                else if (tipoCobaia == 'c' || tipoCobaia == 'C') {
                    totalCoelhos = totalCoelhos + qte;
                }
                else if (tipoCobaia == 'r' || tipoCobaia == 'R') {

                    totalRatos = totalRatos + qte;
                }
            }

            totalCobaias = totalRatos + totalSapos + totalCoelhos;

            pcoelhos = (double)totalCoelhos / totalCobaias * 100.0;
            pratos = (double)totalRatos / totalCobaias * 100.0;
            psapos = (double)totalSapos / totalCobaias * 100.0;

             Console.WriteLine("RELATORIO FINAL:");
             Console.WriteLine("Total: " + totalCobaias + " cobaias");
             Console.WriteLine("Total de coelhos: " + totalCoelhos);
             Console.WriteLine("Total de ratos: " + totalRatos);
             Console.WriteLine("Total de sapos: " + totalSapos);
             Console.WriteLine("Percentual de coelhos: " + pcoelhos.ToString("F2", CI));
             Console.WriteLine("Percentual de ratos: " + pratos.ToString("F2", CI));
             Console.WriteLine("Percentual de sapos: " + psapos.ToString("F2", CI));
        }
    }
}