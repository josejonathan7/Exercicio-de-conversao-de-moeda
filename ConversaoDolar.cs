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
			double reais, dolar, cotacao;
			Console.WriteLine("Digite a qtd de reais a serem convertidos:");
			reais= double.Parse(Console.ReadLine());
			Console.WriteLine("Digite o valor da cotação:");
			cotacao = double.Parse(Console.ReadLine());
			dolar= reais / cotacao;
			Console.WriteLine("R$ " + reais + " é igual a " + dolar + " Dólares");
			Console.ReadKey();
        }
    }
}