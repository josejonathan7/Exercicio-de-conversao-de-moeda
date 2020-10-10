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
        	int a, b;
        	Console.WriteLine("Digite o valor de A:");
    		a = int.Parse(Console.ReadLine());
        	Console.WriteLine("Digite o valor de B");
        	b = int.Parse(Console.ReadLine());
        	if( a > b){
        		Console.WriteLine("O valor de A que é " + a + ", é maior que B, que é " + b);
        	}else {
        	Console.WriteLine("o valor de B que é " + b + ", é maior que A, que é " + a);
        	Console.ReadKey();
        	}
        }
    }
}