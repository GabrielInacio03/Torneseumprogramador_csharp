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
        static int Calcular()
        {
            int a = 1;
            int b = 2;
            int c = a + b;
            return c ;
        }
        public static void MostrarMensagemNaTela()
        {
            Console.WriteLine("Ola Mundo");
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
            Console.WriteLine(Calcular());
            Tabuada(2);
            LerArquivo(@"C:\workspace_pessoal\arquivos\", 1);
            Console.ReadLine();
        }
    }
}
