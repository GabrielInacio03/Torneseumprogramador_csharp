using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Desafio21DiasCsharpOO.Models
{
    internal class Pessoa
    {
        //public long Id; não é uma propriedade, é apenas uma atributo simples
        public long Id { get; set; } //Propriedade

        //public string Nome; //não é uma propriedade, é apenas uma atributo simples
        public string Nome { get; set; } //Propriedade

        //public string Endereco; //não é uma propriedade, é apenas uma atributo simples
        public string Endereco { get; set; }//Propriedade
        public Pessoa() { }

        public Pessoa(long id, string nome, string endereco)
        {
            this.Id = id;
            this.Nome = nome;
            this.Endereco = endereco;
        }
    }
}
