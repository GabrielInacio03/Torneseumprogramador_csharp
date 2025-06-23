using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DesafioPOO.Models
{
    public class PessoaFisica : Pessoa
    {
        public string Cpf;
        public string Rg;

        public PessoaFisica() : base()
        {
        }
    }
}