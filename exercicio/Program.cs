using System;

namespace exercicio {
    class Program {
        static void Main(string[] args) {
            Console.WriteLine("PROGRAMA PARA INFORMAR SE O NÚMERO É PAR OU IMPAR");
            Console.WriteLine();
            Console.WriteLine("---------------------------------------------------");

            int n = 0;
            int r = 0;

            Console.WriteLine("Digite um numero qualquer:");
            n = int.Parse(Console.ReadLine());
            Console.WriteLine();
            r = n % 2;
            if (r == 1) {
                Console.WriteLine("O numero digitado é (IMPAR)");
            }
            else {
                Console.WriteLine("O numero digitado é (PAR)");
               
                
            }
            Console.WriteLine();
            Console.WriteLine("*****FIM DO PROGRAMA*****");
            Console.WriteLine(Console.ReadKey());


        }

    }

}
