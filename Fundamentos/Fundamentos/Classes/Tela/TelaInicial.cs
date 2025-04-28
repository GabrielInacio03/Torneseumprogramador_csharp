using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fundamentos.Classes.Tela
{
    internal static class TelaInicial
    {
        public const string NOME_PROGRAMA = "Torne se um Programador";

        public static void MostrarMensagemNaTela()
        {
            Console.WriteLine("=========================================");
            Console.WriteLine($"Bem Vindo ao {NOME_PROGRAMA}");
            Console.WriteLine("Veja as opções no menu abaixo");
        }
    }
}
