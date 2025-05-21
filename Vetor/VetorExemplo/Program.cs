using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VetorExemplo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] vetnomes = new string[3];

            //vetnomes[0] = "juquinha";
            //vetnomes[1] = "maria";
            //vetnomes[2] = "teobaldo";

            Console.Write("INFORME O PRIMEIRO NOME:");
            vetnomes[0] = Console.ReadLine();
            Console.Write("INFORME O SEGUNDO NOME:");
            vetnomes[1] = Console.ReadLine();
            Console.Write("INFORME O TERCEIRO NOME:");
            vetnomes[2] = Console.ReadLine();

            Console.WriteLine("==== VALORES ====");

            Console.WriteLine($"Primeiro nome: {vetnomes[0]}");
            Console.WriteLine($"Segundo nome: {vetnomes[1]}");
            Console.WriteLine($"Terceiro nome: {vetnomes[2]}");
        }
    }
}
