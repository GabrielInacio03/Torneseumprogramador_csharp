using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fundamentos.Classes.Calculo
{
    internal static class Media
    {
        public static int CalcularMedia()
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
    }
}
