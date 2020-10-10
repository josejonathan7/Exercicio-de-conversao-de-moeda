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
           a = int.Parse(Console.ReadLine());
		   Console.WriteLine("Digite o valor de B:");
           b = int.Parse(Console.ReadLine());
		   Console.WriteLine("Digite o valor de C:");
           c = int.Parse(Console.ReadLine());
           
           if(a>b && a>c && b>c){
           	Console.WriteLine(a + "(A) é maior que " + b + "(B) que é maior que " + c + "(C)");
           } else{
           		if(a> b && a>c && c>b){
           			Console.WriteLine(a + "(A) é maior que " + c + "(C) que é maior que " + b + "(B)");
           		} else{
           			if(b>a && b>c && a>c){
           				Console.WriteLine(b + "(B) é maior que " + a + "(A) que é maior que " + c + "(C)");
           			} else{
           				if(b>a && b>c && c>a){
           					Console.WriteLine(b + "(B) é maior que " + c + "(C) que é maior que " + a + "(A)");
           				} else{
           					if(c>a && c>b && a>b){
           						Console.WriteLine(c + "(C) é maior que " + a + "(A) que é maior que " + b + "(B)");
           					} else{
           						if(c>a && c>b && b>a){
           							Console.WriteLine(c + "(C) é maior que " + b + "(B) que é maior que " + a + "(A)");
           						} else{
									Console.WriteLine("os valores que você digitou são iguais");
           						}
           					}
           				}
           			}
           		}
           }
           Console.ReadKey();
        }
    }
}