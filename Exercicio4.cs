using System;

class Program
{
    static void Main()
    {
        Console.Write("\n\tInforme uma senha com 4 números inteiros --> ");
        int senhaCorreta = int.Parse(Console.ReadLine());
        Console.Clear();

        int senhaDigitada;
        bool senhaIncorreta = true;

        do
        {
            Console.Write("\n\tDigite a Senha que voçê acabou de informar --> ");
            if (int.TryParse(Console.ReadLine(), out senhaDigitada))
            {
                if (senhaDigitada == senhaCorreta)
                {
                    Console.WriteLine("\n\tSenha Correta.\n\t\aSeja Bem Vindo!!");
                    senhaIncorreta = false;
                }
                else
                {
                    Console.WriteLine(" \n\tSenha Incorreta!!\n\tTente Novamente !!\n");
                }
            }
            else
            {
                Console.WriteLine("\n\tSenha inválida. A senha deve ser composta apenas por números.\n");
            }

        } while (senhaIncorreta);

        
        Console.Clear();

        //Faça um programa, utilizando for, 
        // que peça para o usuário inserir um número 
        // N e mostre na tela todos os números ímpares até 


            Console.Write("\n\tDigite um número inteiro -->  ");
            int n = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("\n\tNúmeros ímpares até " + n + ":");

           
            for (int i = 1; i <= n; i++)
            {
                
                if (i % 2 != 0)
                {
                    Console.WriteLine("\t"+i);
                }
            }

            Console.ReadKey();
        }
    }

