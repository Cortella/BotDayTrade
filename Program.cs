using System;
using BotDayTrade.Entities;

namespace BotDayTrade
{
    class Program
    {
        static void Main(string[] args)
        {
            Usuario usuario = new Usuario();
            while (!usuario.Logado)
            {
                Console.WriteLine("----------------------------------------------");
                Console.WriteLine("-------------------BotDayTrade-----------------");
                Console.WriteLine("Login: ");
                string login = Console.ReadLine();
                Console.WriteLine("Senha: ");
                int senha = int.Parse(Console.ReadLine());
                Console.WriteLine("Data de Nascimento (DD/MM/AAAA): ");
                DateTime nascimento = DateTime.Parse(Console.ReadLine());
                bool status = usuario.VerificarLogin();
                if(!status)
                {
                    Console.WriteLine("Houve um erro de login , verifique os dados digitados!!!");
                }
                Console.WriteLine("");
            }
            
        }
    }
}
