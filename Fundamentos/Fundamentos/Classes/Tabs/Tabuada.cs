using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fundamentos.Classes.Tabs
{
    internal static class Tabuada
    {
        public static void ExibeTabuada()
        {
            Console.WriteLine("=========================================");
            Console.WriteLine("Informe o valor da tabuada desejada:");
            int valor = int.Parse(Console.ReadLine());

            for (int i = 0; i <= 10; i++)
            {
                Console.WriteLine($"{valor} X {i} = {valor * i}");
            }
        }
    }
}
