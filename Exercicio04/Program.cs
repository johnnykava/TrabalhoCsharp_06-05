using System;

namespace Exercicio04{
    class Program{
        static void Main(string[] args){
            int escolha = 0;
            double celsius, fahrenheit;

            do{
                Console.WriteLine("1 - Celsius para Fahrenheit");
                Console.WriteLine("2 - Fahrenheit para Celsius");
                Console.WriteLine("3 - Sair");
                escolha = int.Parse(Console.ReadLine());

                switch(escolha){
                    case 1:
                        Console.WriteLine("Digite a temperatura em Celsius que deseja transformar em Fahrenheit: ");
                        celsius = double.Parse(Console.ReadLine());

                        fahrenheit = (celsius * 9/5) + 32;

                        Console.WriteLine("Temperatura em Fahrenheit: " + fahrenheit);

                        break;
                    case 2:
                        Console.WriteLine("Digite a temperatura em Fahrenheit que deseja transformar em Celsius: ");
                        fahrenheit = double.Parse(Console.ReadLine());

                        celsius = (fahrenheit - 32) * 5/9;

                        Console.WriteLine("Temperatura em Celsius: " + celsius);

                        break;
                    case 3:
                        Console.WriteLine("Obrigado por usar o sistema de conversão!");
                        break;
                    default:
                        Console.WriteLine("Opção invalida. Digite um número valido no menu!");
                        break;
                }
            }while(escolha != 3);
        }
    }
}