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

        public void Gravar()
        {
            // TODO implementar
        }
        public static List<Cliente> LerClientes()
        {
            string nomeArquivo = ConfigurationManager.AppSettings["baseDeClientes"];
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
                        clientes.Add(ToClientes(linha));
                    }
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
    }
}
