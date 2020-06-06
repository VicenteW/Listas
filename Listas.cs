using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Listas
{
    class Listas
    {
        public static void Main(string[] args)
        {
            List<int> lista = new List<int>();
            lista.Add(4);
            lista.Add(2);
            lista.Add(5);
            lista.Add(1);
            lista.Add(3);
            lista.Sort();

            int indicador;
            indicador = lista.Find(item => item == 1);
            Console.WriteLine("El valor es " + indicador);
            foreach (int num in lista)
            {
                System.Console.WriteLine(num);
            }
            Console.ReadKey();
        }
    }
}