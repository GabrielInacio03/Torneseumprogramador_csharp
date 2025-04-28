using Fundamentos.Classes.Calculo;
using Fundamentos.Classes.Tela;
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
        static void Main(string[] args)
        {
            TelaInicial.MostrarMensagemNaTela();
            MenuInicial.Menu();

            Console.ReadLine();
        }
    }
}
