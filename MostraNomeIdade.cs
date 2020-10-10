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
        	string nome;
        	int anoAtual, anoNasc;
        	Console.WriteLine("Digite o seu nome:");
        	nome = Console.ReadLine();
        	Console.WriteLine("Digite o ano em que você nasceu:");
        	anoNasc = int.Parse(Console.ReadLine());
        	Console.WriteLine("Digite o ano atual:");
        	anoAtual = int.Parse(Console.ReadLine());
        	
        	if((anoAtual - anoNasc) >= 18){
        		Console.WriteLine(nome + " você é maior de idade, pois tem " + (anoAtual - anoNasc) + " anos.");
        	} else {
        		Console.WriteLine(nome + " você não é maior de idade, pois tem " + (anoAtual - anoNasc) + " anos.");
        	}
        	Console.ReadKey();
        }
    }
}