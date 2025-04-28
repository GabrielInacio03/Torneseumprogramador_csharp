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
        public const int SAIR_PROGRAMA = 0;
        public const int TABUADA = 1;
        public const int CALCULO_MEDIA = 2;
        public const int LER_ARQUIVOS = 3;
        static int CalcularMedia()
        {
            Console.WriteLine("Digite o valor de três notas");
            Console.WriteLine("Valor nota 1:");
            int v1 = int.Parse(Console.ReadLine());

            Console.WriteLine("Valor nota 2:");
            int v2 = int.Parse(Console.ReadLine());

            Console.WriteLine("Valor nota 3:");
            int v3 = int.Parse(Console.ReadLine());

            int totalNotas = v1 + v2 + v3;
            var media = totalNotas / 3;
            return media;
        }
        public static void MostrarMensagemNaTela()
        {
            Console.WriteLine("=========================================");
            Console.WriteLine($"Bem Vindo ao {NOME_PROGRAMA}");
            Console.WriteLine("Veja as opções no menu abaixo");
        }
        public static void Tabuada()
        {
            Console.WriteLine("=========================================");
            Console.WriteLine("Informe o valor da tabuada desejada:");
            int valor = int.Parse(Console.ReadLine());

            for (int i = 0; i <= 10; i++) 
            {
                Console.WriteLine($"{valor} X {i} = {valor * i}");
            }
        }
        public static void LerArquivo(string nomeArquivo, int numArquivo)
        {
            Console.WriteLine("=========================================");

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
        public static void Menu()
        {
            MostrarMensagemNaTela();

            while (true)
            {
                Console.WriteLine("=========================================");
                string menu = "MENU:" +
                    "\n     0 - Sair do Programa" +
                    "\n     1 - Tabuada" +
                    "\n     2 - Calcular Média" +
                    "\n     3 - LerArquivos";

                Console.WriteLine(menu);
                int opcao = int.Parse(Console.ReadLine());

                if (opcao == SAIR_PROGRAMA)
                {
                    Console.WriteLine("saindo...");
                    break;
                }
                else if (opcao == TABUADA)
                {
                    Tabuada();
                }
                else if (opcao == CALCULO_MEDIA)
                {
                    var media = CalcularMedia();
                    Console.WriteLine($"o valor final da sua média foi de {media}");
                }
                else if (opcao == LER_ARQUIVOS)
                {
                    LerArquivo(@"C:\workspace_pessoal\arquivos\", 1);
                }
                else
                {
                    Console.WriteLine("Opção não válida");
                }

            }
        }
        static void Main(string[] args)
        {

            Menu();
            Console.ReadLine();
        }
    }
}
