using System;
using System.Globalization;

class Exercicio1
	{
	static void Main ( string [ ] args )
	 
		{
		/*Faça um programa que pergunte ao usuário:
		 * Nome completo, idade, altura, peso e mostre
		 * na tela o seguinte texto abaixo com as
		 * informações que o usuário digitou. 
		 * Seu nome completo é {nome}, você tem { idade },
		 * { altura}de altura e peso {peso} Kg.*/

		Console . Title = "Exercicio";
		Console . BackgroundColor = ConsoleColor . Gray;
		Console.ForegroundColor = ConsoleColor.Black;
		Console.Clear ();
		
		Console . WriteLine ( "\t\t\t------------------------------------------------------" );
		Console . WriteLine ( "\t\t\t------------------Meu Exercício-----------------------" );
		Console . WriteLine ( "\t\t\t------------------------------------------------------" );

		Console . Write ( "\n\t\tDigite seu nome completo: " );
		string nome = Console.ReadLine();

		Console . Write ( "\n\t\tDigite sua idade: " );
		int idade = int.Parse(Console.ReadLine());

		Console . Write ( "\n\t\tDigite sua altura em metros: " );
		double altura = double.Parse(Console.ReadLine());

		Console . Write ( "\n\t\tDigite seu peso em Kg: " );
		double peso = double.Parse(Console.ReadLine());

		Console . WriteLine ( "\n\t\tSeu nome completo é {0}, você tem {1} anos, {2}m de altura e voçê pesa {3} Kg !" , nome , idade , altura , peso );
		Console . WriteLine ( "\n\t\t___________________________________________________________________________" );

		/*Faça um programa que pergunte ao usuário a hora atual e retorne a mensagem
		 * de acordo com o horário informado .Bom dia! ou Boa Tarde! ou Boa Noite!*/

		Console . Write ( "\n\t\tDigite a hora atual no formato HH:mm --> " );
		string horaDigitada = Console.ReadLine();
		DateTime hora;

		if ( DateTime . TryParseExact ( horaDigitada , "HH:mm" , null , System . Globalization . DateTimeStyles . None , out hora ) )
			{
			if ( hora . Hour >= 0 && hora . Hour < 12 )
				{
				Console . WriteLine ( "\n\t\tBom dia!" );
				}
			else if ( hora . Hour >= 12 && hora . Hour < 18 )
				{
				Console . WriteLine ( "\n\t\t\tBoa tarde!" );
				}
			else
				{
				Console . WriteLine ( "\n\t\t\tBoa noite!" );
				}
			}
		else
			{
			Console . WriteLine ( "\n\t\t\tHora inválida!" );
			}


		Console . WriteLine ( "\n\t\t_____________________________________________________________\n" );

		/*Faça um programa que calcule a área de um quadrado.*/

		Console . Write( "\t\tVamos calcular a área de um quadrado !!\n\t\tDigite o valor do lado do quadrado --> " );
		double lado = double.Parse(Console.ReadLine());

		double area = lado * lado;

		Console . WriteLine ( "\n\t\tA área do quadrado é iqual a " + area + " centímetros quadrado !" );
		Console . WriteLine ( "\n\t\tValeu Professora!" );

		Console . ReadLine ( );
	}
}  

	


