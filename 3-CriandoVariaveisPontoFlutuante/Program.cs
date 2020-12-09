using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3_CriandoVariaveisPontoFlutuante
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Executando projeto 3 - Criando Variáveis ponto flutuante");

            double salario = 3000.50;
            Console.WriteLine(salario);

            salario = 3002 / 4;
            Console.WriteLine("\n\t" + salario + " sem casa decimal");

            salario = 3002.0 / 4;
            Console.WriteLine("\n\t" + salario + " com casa decimal");



            Console.WriteLine("Execução finalizada - tecle enter para sair. . .");
            Console.ReadLine();
        }
    }
}
