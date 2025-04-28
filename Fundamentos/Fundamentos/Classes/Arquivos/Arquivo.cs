using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fundamentos.Classes.Arquivos
{
    internal static class Arquivo
    {
        public static void LerArquivo(string nomeArquivo, int numArquivo)
        {
            Console.WriteLine("=========================================");
            string path = nomeArquivo + $"arq{numArquivo}.txt";
            if (File.Exists(path))
            {
                
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
                LerArquivo(nomeArquivo, numArquivo + 1);
            }

        }
    }
}
