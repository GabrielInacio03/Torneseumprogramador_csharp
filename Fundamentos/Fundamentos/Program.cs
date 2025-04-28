using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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
        static void Main(string[] args)
        {
            MostrarMensagemNaTela();
            Console.WriteLine(Calcular());
            Tabuada(2);
            Console.ReadLine();
        }
    }
}
