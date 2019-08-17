using System;

namespace MeuPrimeiroTerminal
{       class Program
    {
        static void Main(string[] args)
        {
            // string txt = "Digite a sua idade:";
            // int idade = 0; 
            // Console.WriteLine(txt);     
            // string idadeEmString = Console.ReadLine();
            // idade = Convert.ToInt32(idadeEmString);
            /*
            int[] meuArray = new int[5];

            for(int i = 0; i <= 4; i++)
            {
                
                meuArray[i] = 10 + i;
                
            }

            for(int i =0; i < meuArray.Length; i++)
            {

                Console.WriteLine(meuArray[i]);

            }
            
            foreach(int variavelIntDoArray in meuArray)
            {
                Console.WriteLine(variavelIntDoArray); 

            }
            */

            // string txt = "Digite um numero:";
            // int numero = 0; 
            // Console.WriteLine(txt);     
            // string numeroEmString = Console.ReadLine();
            // numero = Convert.ToInt32(numeroEmString);

            // for(int i = 0; i <= numero; i++)
            // {
                
            //     Console.WriteLine(i);
                
            // }

            Console.WriteLine("Quantos numeros voce quer?");
            string numerosEmString = Console.ReadLine();
            int numeros = Convert.ToInt32(numerosEmString);

                int resultado = 1;
                for(int i =0; i < numeros; i++)
                {
                    Console.WriteLine("Escreva seu numero: ");
                    string numeroEmString = Console.ReadLine();
                    int numero = Convert.ToInt32(numeroEmString);
                    resultado *= numero;
                }
                Console.WriteLine($"O resultado eh: {resultado}");

        }

    }
   
}
