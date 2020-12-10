using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P10_CalculaPoupanca
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Executando Projeto 10 - calcula poupança ");

            double valorInvestido = 1000;

            for (int i = 1; i < 13; i++)
            {
                //0.36 % == 0.0036
                valorInvestido *= 0.0036;
                Console.WriteLine("Após " + i + " mes(es) você terá: R$ " + valorInvestido);
            }
            Console.ReadLine();
        }
    }
}
