using Fundamentos.Classes.Arquivos;
using Fundamentos.Classes.Calculo;
using Fundamentos.Classes.Tabs;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fundamentos.Classes.Tela
{
    internal static class MenuInicial
    {
        public const int SAIR_PROGRAMA = 0;
        public const int TABUADA = 1;
        public const int CALCULO_MEDIA = 2;
        public const int LER_ARQUIVOS = 3;
        public const int LER_ARQUIVOS_CLIENTE = 4;
        public const int CADASTRAR_CLIENTE = 5;

        public static void Menu()
        {
            TelaInicial.MostrarMensagemNaTela();

            while (true)
            {
                Console.WriteLine("=========================================");
                string menu = "MENU:" +
                    "\n     0 - Sair do Programa" +
                    "\n     1 - Tabuada" +
                    "\n     2 - Calcular Média" +
                    "\n     3 - LerArquivos" +
                    "\n     4 - Ler Base Clientes "+
                    "\n     5 - Cadastrar Cliente";

                Console.WriteLine(menu);
                int opcao = int.Parse(Console.ReadLine());

                if (opcao == SAIR_PROGRAMA)
                {
                    Console.WriteLine("saindo...");
                    break;
                }
                else if (opcao == TABUADA)
                {
                    Tabuada.ExibeTabuada();
                }
                else if (opcao == CALCULO_MEDIA)
                {
                    var media = Media.CalcularMedia();
                    Console.WriteLine($"o valor final da sua média foi de {media}");
                }
                else if (opcao == LER_ARQUIVOS)
                {
                    string path = ConfigurationManager.AppSettings["caminho_arquivos"];
                    Arquivo.LerArquivo(path, 1);
                } else if(opcao == LER_ARQUIVOS_CLIENTE)
                {
                    var lista = Cliente.LerClientes();
                    foreach (var item in lista)
                    {
                        //Console.WriteLine($"Cliente: {item.Nome} - {item.Telefone} - {item.CPF}");
                        Console.WriteLine();
                    }
                } else if (opcao == CADASTRAR_CLIENTE)
                {
                    Console.WriteLine("=========================================");
                    Console.WriteLine("Digite o nome desejado: ");
                    string nomeCliente = Console.ReadLine();

                    Console.WriteLine("Digite o telefone desejado: ");
                    string telefoneCliente = Console.ReadLine();

                    Console.WriteLine("Digite o cpf desejado: ");
                    string cpfCliente = Console.ReadLine();

                    Cliente clienteSalvar = new Cliente(nomeCliente, telefoneCliente, cpfCliente);
                    clienteSalvar.Gravar();
                    Console.WriteLine("Cliente Salvo com Sucesso!");
                }
                else
                {
                    Console.WriteLine("Opção não válida");
                }

            }
        }
    }
}
