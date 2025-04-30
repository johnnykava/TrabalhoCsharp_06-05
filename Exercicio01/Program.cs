using System;
using System.Text.RegularExpressions;

namespace Exercicio01{
    class Program{
        static void Main(string[] args){
            string senha;

            Console.WriteLine("Digite sua senha: ");
            senha = Console.ReadLine();

            bool temCaractereEspecial = Regex.IsMatch(senha, @"[^a-zA-Z0-9\s]");
            bool temLetrasMaiuscula = Regex.IsMatch(senha, @"[A-Z]");
            bool temNumeros = Regex.IsMatch(senha, @"[0-9]");
            bool temLetrasMinuscula = Regex.IsMatch(senha, @"[a-z]");

            if(temCaractereEspecial && temLetrasMaiuscula && temLetrasMinuscula && temNumeros && senha.Length >= 8){
                Console.WriteLine("Essa senha é forte!!");
            }
            else{
                Console.WriteLine("Essa senha NÃO é forte!");
            }
        }
    }
}