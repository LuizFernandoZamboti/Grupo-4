using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Grupo4
{
    public static class TabuadaEstatica
    {
        public static void Calcular(int valor)
        {
            for (int i = 1; i <= 10; i++)
            {
                Console.WriteLine($"{valor} * {i} = {valor * i}");
            }
        }
    }
}
