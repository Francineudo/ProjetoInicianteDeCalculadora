using System;
using System.ComponentModel.Design;
using System.Diagnostics;
using System.Globalization;
using System.Numerics;

namespace Calculator
{
    class Program
    {
        static void Main(string[] args)
        {
            Menu();
        }

        static void Menu()
        {
            Console.Clear();
            System.Console.WriteLine("O que você deseja fazer?");
            System.Console.WriteLine("1- Somar:");
            System.Console.WriteLine("2- Subtrair:");
            System.Console.WriteLine("3- Dividir:");
            System.Console.WriteLine("4- Multiplicar");
            System.Console.WriteLine("5- Sair");
            System.Console.WriteLine("---------------------------");

            System.Console.WriteLine();
            System.Console.Write("escolha uma opção: ");
            int resp = int.Parse(Console.ReadLine());

            System.Console.WriteLine();

            switch (resp)
            {
                case 1: Soma(); break;
                case 2: Subtracao(); break;
                case 3: Divisao(); break;
                case 4: Multiplicacao(); break;
                case 5:
                System.Console.WriteLine("Muito obrigado por usar a calculadora!");
                System.Environment.Exit(0); break;
                default: Menu(); break;
            }
        }
        static void Soma()
        {
            Console.Clear();

            System.Console.WriteLine("**************");
            System.Console.WriteLine("opção somar");
            System.Console.WriteLine("**************");
            System.Console.WriteLine();
            System.Console.Write("Digite um valor: ");
            double v1 = double.Parse(Console.ReadLine());
            System.Console.Write("digite outro valor: ");
            double v2 = double.Parse(Console.ReadLine());

            double resultado = v1 + v2;

            System.Console.WriteLine();
            System.Console.WriteLine($"O resultado da soma entre {v1} e {v2} é igual a: {resultado}");
            System.Console.WriteLine();
            System.Console.Write("Aperte enter para voltar ao menu!");
            Console.ReadKey();
            Menu();
        }
        static void Subtracao()
        {
            Console.Clear();

            System.Console.WriteLine("****************");
            System.Console.WriteLine("Opção subtrair");
            System.Console.WriteLine("****************");
            System.Console.WriteLine();
            System.Console.Write("Digite um valor: ");
            double v1 = double.Parse(Console.ReadLine());
            System.Console.Write("Digite outro valor: ");
            double v2 = double.Parse(Console.ReadLine());

            double resultado = v1 - v2;

            System.Console.WriteLine();
            System.Console.WriteLine($"O resultado da subtração entre {v1} e {v2} é igual a: {resultado}");
            System.Console.WriteLine();
            System.Console.Write("Aperte enter para voltar ao menu!");
            Console.ReadKey();
            Menu();
        }
        static void Divisao()
        {
            Console.Clear();

            System.Console.WriteLine("****************");
            System.Console.WriteLine("Opção dividir");
            System.Console.WriteLine("****************");
            System.Console.WriteLine();
            System.Console.Write("Digite um valor: ");
            double v1 = double.Parse(Console.ReadLine());
            System.Console.Write("Digite outro valor: ");
            double v2 = double.Parse(Console.ReadLine());

            double resultado = v1 / v2;

            System.Console.WriteLine();
            System.Console.WriteLine($"O resultado da divisão entre {v1} e {v2} é igual a: {resultado}");
            System.Console.WriteLine();
            System.Console.Write("Aperte enter para voltar ao menu!");
            Console.ReadKey();
            Menu();
        }
        static void Multiplicacao()
        {
            Console.Clear();

            System.Console.WriteLine("****************");
            System.Console.WriteLine("Opção multiplicar");
            System.Console.WriteLine("****************");
            System.Console.WriteLine();
            System.Console.Write("Digite um valor: ");
            double v1 = double.Parse(Console.ReadLine());
            System.Console.Write("Digite outro valor: ");
            double v2 = double.Parse(Console.ReadLine());

            double resultado = v1 * v2;

            System.Console.WriteLine();
            System.Console.WriteLine($"O resultado da multiplicação entre {v1} e {v2} é igual a: {resultado}");
            System.Console.WriteLine();
            System.Console.Write("Aperte enter para voltar ao menu!");
            Console.ReadKey();
            Menu();
        }
    }
}

