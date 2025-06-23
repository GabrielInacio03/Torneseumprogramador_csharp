using System;
using DesafioPOO.Models;

namespace DesafioPOO
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("========================================");
            Console.WriteLine("Desafio 21 dias de orientação a objetos!");
            Console.WriteLine("========================================");

            Pessoa gabriel = new Pessoa();
            gabriel.Id = 1;
            gabriel.Nome = "Gabriel";
            gabriel.Endereco = "Brasil, rua 1234";

            Pessoa marcos = new Pessoa();
            marcos.Id = 2;
            marcos.Nome = "Marcos";
            marcos.Endereco = "Brasil, rua 567";

            Pessoa maria = new Pessoa();
            maria.Id = 2;
            maria.Nome = "Maria";
            maria.Endereco = "Brasil, rua 8910";
        }
    }
}