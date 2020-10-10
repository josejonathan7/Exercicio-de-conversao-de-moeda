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
           double a, b, c, x, x1, x2, delta;
           Console.WriteLine("Digite o valor de A:");
           a = double.Parse(Console.ReadLine());
           Console.WriteLine("Digite o valor de B:");
           b = double.Parse(Console.ReadLine());
           Console.WriteLine("Digite o valor de C:");
           c = double.Parse(Console.ReadLine());
           
           delta = b*b-4*a*c;
           
           if(delta < 0){
           	Console.WriteLine("Não há raizes!");
           } else {
           		if(delta == 0){
           			x = -b/2*a;
           			Console.WriteLine("Delta é igual a 0, então o valor da raiz é " + x);
           		} else{
           			if(delta > 0){
           				x1= (-b+Math.Sqrt(delta))/2*a;
           				x2= (-b-Math.Sqrt(delta))/2*a;
           				Console.WriteLine("Como o valor de delta é maior que 0, o valor de x1 é " + x1 + ", e o valor de x2 é " + x2);
           			}
           		}
           }
    		Console.ReadKey();
        }
    }
}