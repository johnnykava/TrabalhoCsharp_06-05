using System;

namespace Exercicio03{
    class Program{
        static void Main(string[] args){
            int numero, fatorial = 1;

            //Pede para o usuario digitar um numero inteiro
            Console.WriteLine("Digite um número inteiro positivo: ");
            //O numero digitado é uma string então é convertido com o Parse() para inteiro
            numero = int.Parse(Console.ReadLine());

            //Esse for itera de 1 ate o numero que foi digitado
            for(int i = 1; i < numero; i++){
                //Multiplica o numero que está na variavel fatorial pelo indice i do for e armazena somando com o valor que ja tem na variavel fatorial
                fatorial += i * fatorial;
            }

            //Mostra o fatorial do numero digitado
            Console.WriteLine($"O fatorial do número {numero} é {fatorial}");
        }
    }
}