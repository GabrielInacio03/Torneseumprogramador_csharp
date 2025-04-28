using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Net.Mime.MediaTypeNames;

namespace Fundamentos
{
    internal class Program
    {
        public const string NOME_PROGRAMA = "Torne se um Programador";
        static int Calcular()
        {
            int a = 1;
            int b = 2;
            int c = a + b;
            return c ;
        }
        public static void MostrarMensagemNaTela()
        {
            Console.WriteLine("=========================================");
            Console.WriteLine($"Bem Vindo ao {NOME_PROGRAMA}");
            Console.WriteLine("Veja as opções no menu abaixo");
            Console.WriteLine("=========================================");
        }
        public static void Tabuada(int numero)
        {
            Console.WriteLine("=========================================");
            for (int i = 0; i <= 10; i++) 
            {
                Console.WriteLine($"{numero} X {i} = {numero * i}");
            }
            Console.WriteLine("=========================================");
        }
        public static void LerArquivo(string nomeArquivo, int numArquivo)
        {
            if (File.Exists(nomeArquivo)) 
            {
                string path = nomeArquivo + $"arq{numArquivo}.txt";
                using (StreamReader arquivo = File.OpenText(path))
                {
                    string linha;
                    while ((linha = arquivo.ReadLine()) != null)
                    {
                        Console.WriteLine(linha);
                    }
                }
            }
            else
            {
                Console.WriteLine($"Arquivo {nomeArquivo} não foi encontrado");
            }

            string pathOutro = nomeArquivo + $"arq{numArquivo + 1}.txt";
            if (File.Exists(pathOutro))
            {
                LerArquivo(nomeArquivo, numArquivo+1);
            }

        }
        static void Main(string[] args)
        {
            MostrarMensagemNaTela();
            int opcao = 1;
            while (opcao != 0) 
            {
                Console.WriteLine("=========================================");
                Console.WriteLine("MENU: ");
                Console.WriteLine("0 - Sair do Programa");
                Console.WriteLine("1 - Tabuada");
                Console.WriteLine("2 - Calcular");
                Console.WriteLine("3 - LerArquivo");

                opcao = int.Parse(Console.ReadLine());

                switch (opcao)
                {
                    case 0:
                        Console.WriteLine("saindo...");
                        break;
                    case 1:
                        Tabuada(5);
                        break;
                    case 2:
                        Calcular();
                        break;
                    case 3:
                        LerArquivo(@"C:\workspace_pessoal\arquivos\", 1);
                        break;
                    default:
                        Console.WriteLine("Opção não valida");
                        break;
                }

            }
            Console.ReadLine();
        }
    }
}
