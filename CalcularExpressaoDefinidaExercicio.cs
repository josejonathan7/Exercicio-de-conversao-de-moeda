using System;
using System.IO;
using System.Linq;
using System.Collections.Generic;

namespace CSharp_Shell
{

    public static class Program 
    {
        public static void Main() 
        {
			int a, b, c, resultado;
			Console.WriteLine("Digite o valor de A:");
			a = int.Parse(Console.ReadLine());
			Console.WriteLine("Digite o valor de B:");
			b = int.Parse(Console.ReadLine());
			Console.WriteLine("Digite o valor de C:");
			c = int.Parse(Console.ReadLine());
			resultado = (a*a) * 5 - c / (b - a % 4);
			Console.WriteLine("O resultado da seguinte operação matemática ( (a*a) * 5 - c / (b - a % 4)) baseado nos valores que você atribuiu é: " + resultado);
			Console.ReadKey();	
;
        }
    }
}