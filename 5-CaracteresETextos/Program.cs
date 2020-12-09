using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _5_CaracteresETextos
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Executando projeto 5 - Caracteres e textos");

            char primeiraLetra = 'a';
            Console.WriteLine(primeiraLetra);
            primeiraLetra = (char)65;
            Console.WriteLine(primeiraLetra);
            primeiraLetra = (char)(primeiraLetra + 1);
            Console.WriteLine(primeiraLetra);

            String titulo = "A aula é de strings e chars - caracteres - " + 2020;
            Console.WriteLine(titulo);

            titulo = @"Os cursos oferecidos são: 
- Java
- .Net
- Javascript";
            Console.WriteLine(titulo);

            Console.ReadLine();
        }
    }
}
