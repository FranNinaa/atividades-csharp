//Faça um programa usando vetor que armazene 
//  N nomes e depois mostre na tela os
// nomes na sequência que foram digitados. 


using System;
using System.Globalization;

class Program
{
    static void Main()
    {
        Console.Write("\n\t Digite a quantidade de nome a serem armazenados: ");
        int n = Convert.ToInt32(Console.ReadLine());

        string[] nomes = new string[n];

        for (int i = 0; i < n; i++)
        {
            Console.Write($"\n\t Digite o nome {i + 1}: ");
            nomes[i] = Console.ReadLine();
        }

        Console.Write("\n\tNomes que foram Digitados em Ordem\n ");
        for (int i = 0; i < n; i++)
        {
            Console.WriteLine("\n\t" + nomes[i]);
        }

        Console.Clear();

        //Faça um programa que leia 5 valores inteiros, 
        //armazene-os em um vetor, calcule e apresente a soma destes valores.

        int[] valor = new int[5];
        int soma = 0;

        for (int i = 0; i < valor.Length; i++)
        {
            Console.Write($" \n\tInforme o {1 + i}º número --> ");
            valor[i] = int.Parse(Console.ReadLine());

            soma = soma + valor[i];
        }

        Console.WriteLine("\n\tTotal = " + soma);
        Console.ReadLine();
    }

}
