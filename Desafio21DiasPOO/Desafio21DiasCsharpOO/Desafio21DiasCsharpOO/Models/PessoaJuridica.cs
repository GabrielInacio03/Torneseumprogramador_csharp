using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Desafio21DiasCsharpOO.Models
{
    internal class PessoaJuridica : Pessoa
    {
        public string Cnpj { get; set; }
        public string InscricaoEstadual { get; set; }
        public string NomeFantasia { get; set; }

        public PessoaJuridica(string cnpj, string inscricaoEstadual, string nomeFantasia) : base()
        {
            Cnpj = cnpj;
            InscricaoEstadual = inscricaoEstadual;
            NomeFantasia = nomeFantasia;
        }
        public PessoaJuridica(long id, string nome, string endereco, string cnpj, string inscricaoEstadual, string nomeFantasia) : base(id, nome, endereco)
        {
            Cnpj = cnpj;
            InscricaoEstadual = inscricaoEstadual;
            NomeFantasia = nomeFantasia;
        }
    }
}
