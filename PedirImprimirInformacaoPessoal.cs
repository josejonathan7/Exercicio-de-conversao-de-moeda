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
        	string nome, cidade;
			int idade;
			Console.WriteLine("Digite seu nome:");
			nome = Console.ReadLine();
			Console.WriteLine("Digite sua idade:");
			idade = int.Parse(Console.ReadLine());
			Console.WriteLine(" Digite o nome da sua cidade:");
			cidade = Console.ReadLine();
			Console.WriteLine(nome+ " você tem " + idade + " anos e mora na cidade de " + cidade);
			Console.ReadKey();	
        }
    }
}