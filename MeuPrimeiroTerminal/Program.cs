using System;

namespace MeuPrimeiroTerminal
{       class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Qual time ganhou a ultima copa?");
            string[] times = new string[4];
            times[0] = "brasil";
            times[1] = "franca";
            times[2] = "mexico";
            times[3] = "alemanha";
            
            for(int i  = 0; i < 4; i++)
            {                 
                Console.WriteLine(times[i]);                                    
            }

            Console.WriteLine("Digite: ");

            string opcaoDoUsuario = Console.ReadLine();
            bool ehVencedor = EhVencedor(opcaoDoUsuario); 

            if(ehVencedor)
                Console.WriteLine("venceu");
            else
                Console.WriteLine("perdeu");
        }

        public static bool EhVencedor(string opcaoDoUsuario)
        {
            string vencedor = "franca";
            return opcaoDoUsuario == vencedor;
            
        }
    }
}
