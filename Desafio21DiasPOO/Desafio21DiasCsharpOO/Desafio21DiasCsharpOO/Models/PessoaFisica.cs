using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Desafio21DiasCsharpOO.Models
{
    internal class PessoaFisica : Pessoa
    {
        public string Cpf { get; set; }
        public string Rg { get; set; }

        public PessoaFisica(string Cpf, string Rg) : base()
        {
            this.Cpf = Cpf;
            this.Rg = Rg;
        }
        public PessoaFisica(long id, string nome, string endereco, string cpf, string Rg) :base(id, nome, endereco)
        {
            this.Rg = Rg;
            this.Cpf = Cpf;
        }
    }
}
