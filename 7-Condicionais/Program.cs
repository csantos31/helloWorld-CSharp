using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _7_Condicionais
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Executando projeto 7 - Condicionais");

            int idade = 18;
            int quantidadePessoas = 2;
            if (idade >= 18)
            {
                Console.WriteLine("Maior de 18 anos, pode entrar");
            }
            else
            {
                if (quantidadePessoas >= 2)
                {
                    Console.WriteLine("Menor de 18 anos mas está acompanhado, pode entrar");

                }
                else
                {
                    Console.WriteLine("Menor de 18 anos, volte quando for maior");
                }
            }

            Console.ReadLine();
        }
    }
}
