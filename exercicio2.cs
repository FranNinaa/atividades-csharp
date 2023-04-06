using System;
using System.Globalization;



class Exercicio2
{
    static void Main(string[] args)
    {
        Console.Title = "Exercicio2";
        Console.BackgroundColor = ConsoleColor.Gray;
        Console.ForegroundColor = ConsoleColor.Black;
        Console.Clear();

        Console.WriteLine("\t\t\t------------------------------------------------------");
        Console.WriteLine("\t\t\t------------------Meu Exercício-----------------------");
        Console.WriteLine("\t\t\t------------------------------------------------------");
        /* Faça um programa que o aluno informe a nota da primeira e segunda avaliação(nota1 e nota2)
          e retorne uma mensagem com a nota do aluno e sua situação.
          (Ex: NOTA FINAL 5.5 - ALUNO REPROVADO)
          Obs: Para ser aprovado a soma das notas precisa ser maior ou igual que 6.0 
        e todos os valores devem ter uma casa decimal. */



        Console.Write("\n\tDigite o valor da Primeira Nota -->  ");
        double nota1 = double.Parse(Console.ReadLine());



        Console.Write("\n\tDigite o valor da Segunda Nota --> ");
        double nota2 = double.Parse(Console.ReadLine());



        double media = (nota1 + nota2) / 2;



        if (media > 6)
        {
            Console.WriteLine("\n\tA Média total é " + media + " , Aluno Aprovado !!");
        }
        else
        {
            Console.WriteLine("\n\tA Média total é " + media + " , Aluno Reprovado !!");
        }



        Console.WriteLine("");
        Console.WriteLine("_____________________________________________________________________");
        Console.WriteLine("");



        //Fazer um programa para ler três números inteiros e mostrar na tela o maior deles.



        Console.WriteLine("\n\tDetermine o maior Valor de tres Valores !!! ");



        Console.Write("\n\t Informe o Primeiro Valor ---> ");
        int valor1 = int.Parse(Console.ReadLine());
        int maiorValor = valor1;



        Console.Write("\n\t Informe o Segundo Valor ---> ");
        int valor2 = int.Parse(Console.ReadLine());
        if (valor2 > maiorValor)
        {
            maiorValor = valor2;
        }
        Console.Write("\n\tInforme o Terceiro Valor ---> ");
        int valor3 = int.Parse(Console.ReadLine());
        if (valor3 > maiorValor)
        {
            maiorValor = valor3;
        }

        Console.WriteLine("\n\tO maior valor digitado  é " + maiorValor);
    }
   
}