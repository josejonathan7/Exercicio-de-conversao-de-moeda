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
			int a, b, c;
			Console.WriteLine("Digite o valor de A:");
			a= int.Parse(Console.ReadLine());
			Console.WriteLine("Digite o valor de B:");
			b= int.Parse(Console.ReadLine());
			c = b;
			b = a;
			a = c;
			Console.WriteLine("Invertido o valor das variáveis A e B fica respectivamente: " + a + " e " + b);
			Console.ReadKey();
        }
    }
}