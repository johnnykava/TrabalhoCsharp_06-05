using System;

namespace Exercicio04{
    class Program{
        static void Main(string[] args){
            int escolha = 0;
            double celsius, fahrenheit;

            do{
                //Menu de escolhas para o usario
                Console.WriteLine("1 - Celsius para Fahrenheit");
                Console.WriteLine("2 - Fahrenheit para Celsius");
                Console.WriteLine("3 - Sair");
                //Transforma em inteiro o numero digitado pelo usuario usando Parse()
                escolha = int.Parse(Console.ReadLine());

                switch(escolha){
                    //Escolhendo 1 mostra a temperatura em celsius para fahrenheit
                    case 1:
                        //Pede para o usuario digitar a temperatura em celsius
                        Console.WriteLine("Digite a temperatura em Celsius que deseja transformar em Fahrenheit: ");
                        celsius = double.Parse(Console.ReadLine());

                        //Pega a temperatura em celsius e faz o calculo para transformar em fahrenheit
                        fahrenheit = (celsius * 9/5) + 32;

                        //Mostra a temperatura em fahrenheit
                        Console.WriteLine("Temperatura em Fahrenheit: " + fahrenheit);

                        break;
                    //Escolhendo 2 mostra a temperatura em fahrenheit para celsius
                    case 2:
                        //Pede para o usuario digitar a temperatura em fahrenheit
                        Console.WriteLine("Digite a temperatura em Fahrenheit que deseja transformar em Celsius: ");
                        fahrenheit = double.Parse(Console.ReadLine());

                        //Pega a temperatura digitada em fahrenheit e faz o calculo para transformar em celsius
                        celsius = (fahrenheit - 32) * 5/9;

                        Console.WriteLine("Temperatura em Celsius: " + celsius);

                        break;
                    //Escolhendo 3 encerra o loop e finaliza o programa
                    case 3:
                        //Mostra uma mensagem de encerramento
                        Console.WriteLine("Obrigado por usar o sistema de conversão!");
                        break;
                    //Caso seja digitado qualquer valor invalido que não esteja no menu
                    default:
                        //Mostra a mensagem de erro e pede para usuario digitar um valor valido
                        Console.WriteLine("Opção invalida. Digite um número valido no menu!");
                        break;
                }
            }while(escolha != 3);
        }
    }
}