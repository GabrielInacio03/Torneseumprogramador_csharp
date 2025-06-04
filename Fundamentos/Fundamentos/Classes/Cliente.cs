using Fundamentos.Classes.Arquivos;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fundamentos.Classes
{
    public class Cliente
    {
        public string Nome { get; set; }
        public string Telefone { get; set; }
        public string CPF { get; set; }

        public Cliente() { }

        /// <summary>
        /// Construtor da classe
        /// </summary>
        /// <param name="nome"></param>
        /// <param name="telefone"></param>
        /// <param name="cpf"></param>
        /// <exception cref="ArgumentNullException"></exception>
        public Cliente(string nome, string telefone, string cpf)
        {
            this.Nome = nome ?? throw new ArgumentNullException(nameof(nome));
            this.Telefone = telefone ?? throw new ArgumentNullException(nameof(telefone));
            this.CPF = cpf ?? throw new ArgumentNullException(nameof(cpf));
        }
        public static string NomeArquivoBase()
        {
            string nomeArquivo = ConfigurationManager.AppSettings["baseDeClientes"];
            return nomeArquivo;
        }
        public void Gravar()
        {
            var linhaSalvar = ToLinhaCliente(this);
            string nomeArquivo = NomeArquivoBase();
            if (File.Exists(nomeArquivo))
            {
                using(StreamReader sr = File.OpenText(nomeArquivo))
                {
                    sr.Close();

                }
                File.AppendAllText(nomeArquivo, linhaSalvar + Environment.NewLine);

            }
        }
        public static List<Cliente> LerClientes()
        {
            string nomeArquivo = NomeArquivoBase();
            var clientes = new List<Cliente>();

            Console.WriteLine("=========================================");
            string path = nomeArquivo;
            if (File.Exists(path))
            {

                using (StreamReader arquivo = File.OpenText(path))
                {
                    string linha;
                    int i = 0;
                    while ((linha = arquivo.ReadLine()) != null)
                    {
                        i++;
                        if (i == 1)
                            continue;

                        Console.WriteLine(linha);
                        if (linha == "")
                            break;
                        clientes.Add(ToClientes(linha));
                    }
                    arquivo.Close();
                }
            }
            else
            {
                Console.WriteLine($"Arquivo {nomeArquivo} não foi encontrado");
            }

            return clientes;
        }
    
        public static Cliente ToClientes(string linha)
        {
            var clienteArquivo = linha.Split(';');
            Cliente cliente = new Cliente();
            cliente.Nome = clienteArquivo[0];
            cliente.Telefone = clienteArquivo[1];
            cliente.CPF = clienteArquivo[2];

            return cliente;
        }
        public static string ToLinhaCliente(Cliente cliente)
        {
            string linha = $"{cliente.Nome};{cliente.Telefone};{cliente.CPF}; \n";

            return linha;
        }
    }
}
