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
			int x, y, z, w;
			bool verdade = true;
			bool falso = false;
			Console.WriteLine("Digite o valor de X:");
			x= int.Parse(Console.ReadLine());
			Console.WriteLine("Digite o valor de Y");
			y= int.Parse(Console.ReadLine());
			Console.WriteLine("Digite o valor de Z:");
			z= int.Parse(Console.ReadLine());
			Console.WriteLine("Digite o valor de W:");
			w= int.Parse(Console.ReadLine());
			Console.WriteLine("Com os dados inseridos agora vamos avaliar se a seguinte expressão é verdadeira ((x >= y) && (z <= x)) || ((x == w) && (y == z)) || (!(x != w)) e a resposta é " + (((x >= y) && (z <= x)) || ((x == w) && (y == z)) || (!(x != w))? verdade : falso));
			Console.ReadKey();
        }
    }
}