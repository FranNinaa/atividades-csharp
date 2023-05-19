bool sair = false;

while (!sair)
{
    Console.WriteLine();
    Console.WriteLine("\n\tLista  de Exercícios da Matéria: Desenvolvedor de Sistemas !!\n");
    Console.WriteLine("\t1 - Programa que retorna o nome completo, idade e peso  ");
    Console.WriteLine("\t2 - Programa que retorna uma mensagem de acordo com o horário informado!");
    Console.WriteLine("\t3 - Programa que calcula a área do quadrado !!");
    Console.WriteLine("\t4 - Programa que calcula a média final do aluno e mostre se esta aprovado!!");
    Console.WriteLine("\t5 - Programa para ler três númeos inteiros e mostra na tela o maior deles !");
    Console.WriteLine("\t6 - Programa que receba a senha e informe se correta ou não !");
    Console.WriteLine("\t7 - Programa que pede um número ao usuário e mostre na tela os números impares! ");
    Console.WriteLine("\t8 - Programa Vetor que mostre os nomes na sequência que foi digitada !");
    Console.WriteLine("\t9 - Programa que leia 5 valores inteiros, armazena em um vetor, calcule e apresente a soma deles! ");
    Console.WriteLine("\t10 - Programa que preencha uma matriz com valores da tabela que foi apresentada no exercício ! ");
    Console.WriteLine("\t11 - Programa do caixa eletrônico !");
    Console.WriteLine();
    Console.Write("\n\tDigite o número do exercício desejado --> ");

    string opcao = Console.ReadLine();
    Console.Clear();
    Console.WriteLine();

    switch (opcao)
    {
        case "1":
            Exercicio1();
            break;
        case "2":
            Exercicio2();
            break;
        case "3":
            Exercicio3();
            break;
        case "4":
            Exercicio4();
            break;
        case "5":
            Exercicio5();
            break;
        case "6":
            Exercicio6();
            break;
        case "7":
            Exercicio7();
            break;
        case "8":
            Exercicio8();
            break;
        case "9":
            Exercicio9();
            break;
        case "10":
            Exercicio10();
            break;
        case "11":
            Exercicio11();
            break;
        case "0":
            sair = true;
            break;
        default:
            Console.WriteLine("\n\tOpção Inválida. tente novamente !!");
            break;
    }
    Console.WriteLine();
}
static void Exercicio1()
{
    /*Faça um programa que pergunte ao usuário:
         * Nome completo, idade, altura, peso e mostre
         * na tela o seguinte texto abaixo com as
         * informações que o usuário digitou. 
         * Seu nome completo é {nome}, você tem { idade },
         * { altura}de altura e peso {peso} Kg.*/



    Console.Title = "Exercicio 1";
    Console.BackgroundColor = ConsoleColor.Gray;
    Console.ForegroundColor = ConsoleColor.Black;
    Console.Clear();



    Console.Write("\n\t\tDigite seu nome completo: ");
    string nome = Console.ReadLine();



    Console.Write("\n\t\tDigite sua idade: ");
    int idade = int.Parse(Console.ReadLine());



    Console.Write("\n\t\tDigite sua altura em metros: ");
    double altura = double.Parse(Console.ReadLine());



    Console.Write("\n\t\tDigite seu peso em Kg: ");
    double peso = double.Parse(Console.ReadLine());



    Console.WriteLine("\n\t\tSeu nome completo é {0}, você tem {1} anos, {2}m de altura e voçê pesa {3} Kg !", nome, idade, altura, peso);

    Console.WriteLine("\n\t\tClique qualquer tecla para voltar ao Menu Inicial !!");

    Console.ReadLine();
   
    Console.Clear();
    
}

static void Exercicio2()
{
    /*Faça um programa que pergunte ao usuário a hora atual e retorne a mensagem
         * de acordo com o horário informado .Bom dia! ou Boa Tarde! ou Boa Noite!*/

    Console.Title = "Exercicio 2";
    Console.BackgroundColor = ConsoleColor.Magenta;
    Console.ForegroundColor = ConsoleColor.Black;
    Console.Clear();

    Console.Write("\n\t\tDigite a hora atual no formato HH:mm --> ");
    string horaDigitada = Console.ReadLine();
    DateTime hora;



    if (DateTime.TryParseExact(horaDigitada, "HH:mm", null, System.Globalization.DateTimeStyles.None, out hora))
    {
        if (hora.Hour >= 0 && hora.Hour < 12)
        {
            Console.WriteLine("\n\t\tBom dia!");
        }
        else if (hora.Hour >= 12 && hora.Hour < 18)
        {
            Console.WriteLine("\n\t\t\tBoa tarde!");
        }
        else
        {
            Console.WriteLine("\n\t\t\tBoa noite!");
        }
    }
    else
    {
        Console.WriteLine("\n\t\t\tHora inválida!");
    }

    Console.ReadLine();
    Console.Clear();
    Console.WriteLine();

}
static void Exercicio3()
{
    /*Faça um programa que calcule a área de um quadrado.*/

    Console.Title = "Exercicio 3";
    Console.BackgroundColor = ConsoleColor.Red;
    Console.ForegroundColor = ConsoleColor.Black;
    Console.Clear();

    Console.Write("\t\tVamos calcular a área de um quadrado !!\n\t\tDigite o valor do lado do quadrado --> ");
    double lado = double.Parse(Console.ReadLine());



    double area = lado * lado;



    Console.WriteLine("\n\t\tA área do quadrado é iqual a " + area + " centímetros quadrado !");
    Console.WriteLine("\n\t\tValeu Professora!");


    Console.ReadLine();
    Console.Clear();
    Console.WriteLine();
}

static void Exercicio4()
{
    /* Faça um programa que o aluno informe a nota da primeira e segunda avaliação(nota1 e nota2)
          e retorne uma mensagem com a nota do aluno e sua situação.
          (Ex: NOTA FINAL 5.5 - ALUNO REPROVADO)
          Obs: Para ser aprovado a soma das notas precisa ser maior ou igual que 6.0 
        e todos os valores devem ter uma casa decimal. */

    Console.Title = "Exercicio 4";
    Console.BackgroundColor = ConsoleColor.Yellow;
    Console.ForegroundColor = ConsoleColor.Black;
    Console.Clear();

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
    Console.ReadLine();
    Console.Clear();
    Console.WriteLine();
}

static void Exercicio5()
{
    //Fazer um programa para ler três números inteiros e mostrar na tela o maior deles.

    Console.Title = "Exercicio 4";
    Console.BackgroundColor = ConsoleColor.DarkBlue;
    Console.ForegroundColor = ConsoleColor.Black;
    Console.Clear();

    Console.WriteLine(" \n\tDetermine o maior Valor de tres Valores !!! ");



    Console.Write("\n\tInforme o Primeiro Valor ---> ");
    int valor1 = int.Parse(Console.ReadLine());
    int maiorValor = valor1;



    Console.Write("\n\t Informe o Segundo Valor ---> ");
    int valor2 = int.Parse(Console.ReadLine());
    if (valor2 > maiorValor)
    {
        maiorValor = valor2;
    }
    Console.Write("\n\t Informe o Terceiro Valor ---> ");
    int valor3 = int.Parse(Console.ReadLine());
    if (valor3 > maiorValor)
    {
        maiorValor = valor3;
    }

    Console.WriteLine("\n\t O maior valor digitado  é " + maiorValor);

  
    Console.ReadLine();
    Console.Clear();
    Console.WriteLine();
}

static void Exercicio6()
{
    Console.Title = "Exercicio 6";
    Console.BackgroundColor = ConsoleColor.DarkGray;
    Console.ForegroundColor = ConsoleColor.Black;
    Console.Clear();

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
    Console.ReadLine();
    Console.Clear();
    Console.WriteLine();
}
static void Exercicio7()
{

    //Faça um programa, utilizando for, 
    // que peça para o usuário inserir um número 
    // N e mostre na tela todos os números ímpares até

    Console.Title = "Exercicio 7";
    Console.BackgroundColor = ConsoleColor.DarkCyan ;
    Console.ForegroundColor = ConsoleColor.Black;
    Console.Clear();


    Console.Write("\n\tDigite um número inteiro -->  ");
    int n = Convert.ToInt32(Console.ReadLine());



    Console.WriteLine("\n\tNúmeros ímpares até " + n + ":");




    for (int i = 1; i <= n; i++)
    {

        if (i % 2 != 0)
        {
            Console.WriteLine("\n\t" + i);
        }
    }
    Console.ReadLine();
    Console.Clear();
    Console.WriteLine();
}



static void Exercicio8()
{
    //  N nomes e depois mostre na tela os
    // nomes na sequência que foram digitados.

    Console.Title = "Exercicio 9";
    Console.BackgroundColor = ConsoleColor.White;
    Console.ForegroundColor = ConsoleColor.Black;
    Console.Clear();

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

    Console.ReadLine();
    Console.Clear();
    Console.WriteLine();
}

static void Exercicio9()
{
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
    Console.Clear();
    Console.WriteLine();
}

static void Exercicio10()
{

    Console.Title = "Exercicio 10";
    Console.BackgroundColor = ConsoleColor.DarkMagenta;
    Console.ForegroundColor = ConsoleColor.Black;
    Console.Clear();

    int[,] matriz = new int[4, 4] { { 1, 2, 3, 4 }, { 10, 20, 30, 40 }, { 12, 22, 32, 42 }, { 15, 25, 35, 45 } };

    Console.WriteLine();

    for (int i = 0; i < 4; i++)
    {
        for (int j = 0; j < 4; j++)
        {
            
            Console.Write("\t{0,4}", matriz[i, j]);
        }
        Console.WriteLine();
    }

    Console.ReadLine();

    Console.Clear();
    Console.WriteLine();
}
static void Exercicio11()
{
    Console.Title = "Exercicio 11";
    Console.BackgroundColor = ConsoleColor.DarkGreen;
    Console.ForegroundColor = ConsoleColor.Black;
    Console.Clear();

    int opcao;
    double saldo = 0;
    do
    {
        Console.WriteLine("\n\t--- CAIXA ELETRÔNICO ---\n");
        Console.WriteLine("\t1 - Ver saldo");
        Console.WriteLine("\t2 - Depositar");
        Console.WriteLine("\t3 - Sacar");
        Console.WriteLine("\t0 - Sair");





        Console.Write("\n\tEscolha uma opção: ");
        opcao = int.Parse(Console.ReadLine());





        switch (opcao)
        {
            case 1:
                VerSaldo(saldo);
                break;
            case 2:
                Depositar(ref saldo);
                break;
            case 3:
                Sacar(ref saldo);
                break;
            case 0:
                Console.WriteLine("\n\tSaindo...");
                break;
            default:
                Console.WriteLine("\n\tOpção inválida.");
                break;
        }
    } while (opcao != 0);






    static void VerSaldo(double saldo)
    {
        Console.WriteLine("\n\tSeu saldo é de R$ " + saldo.ToString("F2"));
    }





    static void Depositar(ref double saldo)
    {
        double valor;





        Console.Write("\n\tDigite o valor a depositar: R$ ");
        valor = double.Parse(Console.ReadLine());





        saldo += valor;





        Console.WriteLine("\n\tDepósito realizado com sucesso!");
        Console.WriteLine("\tSeu novo saldo é de R$ " + saldo.ToString("F2"));
    }





    static void Sacar(ref double saldo)
    {
        double valor;





        Console.Write("\n\tDigite o valor a sacar: R$ ");
        valor = double.Parse(Console.ReadLine());





        if (valor > saldo)
        {
            Console.WriteLine("\n\tSaldo insuficiente.");
        }
        else
        {
            saldo -= valor;


            Console.WriteLine("\n\tSaque realizado com sucesso!");
            Console.WriteLine("\tSeu novo saldo atual é de R$ " + saldo.ToString("F2"));
        }
    }
    Console.ReadLine();
    Console.Clear();
    Console.WriteLine();
}
