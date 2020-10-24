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
			double reais, dolarCotacao, euroCotacao, dolar, euro;
			Console.WriteLine("Digite a qtd de reais a serem convertidos:");
			reais= double.Parse(Console.ReadLine());
			Console.WriteLine("Digite o valor da cotação do dólar:");
			dolarCotacao = double.Parse(Console.ReadLine());
			Console.WriteLine("Digite o valor da cotação do Euro:");
			euroCotacao= double.Parse(Console.ReadLine());
			dolar= reais / dolarCotacao;
			euro= reais / euroCotacao;
			Console.WriteLine("R$ " + reais + " é igual a " + dolar + " Dólares, e " + euro + " Euros");
			Console.ReadKey();	
        }
    }
}