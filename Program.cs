using System;

namespace Calculator
{
    class Program
    {
        static void Main(string[] args)
        {
            double num1, num2, result;
            char operation;

            Console.WriteLine("Calculadora em C#");
            Console.WriteLine("------------------");
            Console.WriteLine("Insira o primeiro número:");
            num1 = double.Parse(Console.ReadLine());

            Console.WriteLine("Insira o segundo número:");
            num2 = double.Parse(Console.ReadLine());

            Console.WriteLine("Insira a operação (+, -, *, /):");
            operation = char.Parse(Console.ReadLine());

            switch (operation)
            {
                case '+':
                    result = num1 + num2;
                    Console.WriteLine("Resultado: " + result);
                    break;
                case '-':
                    result = num1 - num2;
                    Console.WriteLine("Resultado: " + result);
                    break;
                case '*':
                    result = num1 * num2;
                    Console.WriteLine("Resultado: " + result);
                    break;
                case '/':
                    if (num2 == 0)
                    {
                        Console.WriteLine("Não é possível dividir por zero!");
                    }
                    else
                    {
                        result = num1 / num2;
                        Console.WriteLine("Resultado: " + result);
                    }
                    break;
                default:
                    Console.WriteLine("Operação inválida!");
                    break;
            }

            Console.ReadLine();
        }
    }
}
