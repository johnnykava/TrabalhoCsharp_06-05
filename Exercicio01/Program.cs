using System;
using System.Text.RegularExpressions;

namespace Exercicio01{
    class Program{
        static void Main(string[] args){
            string senha;

            //Pedindo para o usuario digitar uma senha
            Console.WriteLine("Digite sua senha: ");
            senha = Console.ReadLine();

            //Verifica se a senha tem um caracter especial
            bool temCaractereEspecial = Regex.IsMatch(senha, @"[^a-zA-Z0-9\s]");
            //Verifica se a senha tem letras maiusculas
            bool temLetrasMaiuscula = Regex.IsMatch(senha, @"[A-Z]");
            //Verifica se a senha tem numeros
            bool temNumeros = Regex.IsMatch(senha, @"[0-9]");
            //Verifica se a senha tem caracteres minusculos
            bool temLetrasMinuscula = Regex.IsMatch(senha, @"[a-z]");

            //Se todas as condições acima forem verdadeiras e a senha tem no minimo 8 caracteres a senha é forte
            if(temCaractereEspecial && temLetrasMaiuscula && temLetrasMinuscula && temNumeros && senha.Length >= 8){
                Console.WriteLine("Essa senha é forte!!");
            }
            //Se não é fraca
            else{
                Console.WriteLine("Essa senha NÃO é forte!");
            }
        }
    }
}