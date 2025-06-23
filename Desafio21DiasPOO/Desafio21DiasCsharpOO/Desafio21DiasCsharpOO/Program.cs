using System;
using Desafio21DiasCsharpOO.Models;

namespace Desafio21DiasCsharpOO
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("========================================");
            Console.WriteLine("Desafio 21 dias de orientação a objetos!");
            Console.WriteLine("========================================");

            Pessoa gabriel = new Pessoa(1, "Gabriel", "Brasil, rua 1234");
            Pessoa marcos = new Pessoa(2, "Marcos", "Brasil, rua 567");
            Pessoa maria = new Pessoa(3, "Maria", "Brasil, rua 8910");
           
            List<Pessoa> pessoas = new List<Pessoa>();
            pessoas.Add(marcos);
            pessoas.Add(maria);
            pessoas.Add(gabriel);

            foreach (var pessoa in pessoas)
            {
                Console.WriteLine($"Pessoa: {pessoa.Nome}");
            }


            PessoaFisica pe = new PessoaFisica(1, "Gabriel", "Brasil, rua 1234", "13213231","123132131");
        }
    }
}