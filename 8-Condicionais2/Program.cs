using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _8_Condicionais2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Executando projeto 8 - Condicionais2");

            int idade = 16;
            int quantidadePessoas = 2;
            
            if(idade >= 18 || quantidadePessoas >= 2)
            {
                Console.WriteLine("Maior de 18 anos ou acompanhado, pode entrar");
            }
            else
            {
                Console.WriteLine("Volte quando for maior ou estiver acompanhado por um responsável.");
            }
            Console.ReadLine();
        }
    }
}
