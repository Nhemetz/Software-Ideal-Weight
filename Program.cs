using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Peso_ideal
{
    class Program
    {
        static void Main(string[] args)
        {
            string Sexo;
            double Altura;

            Console.Write("Escreva seu sexo: ");
            Sexo = Console.ReadLine();
            Console.Write("Escreva sua altura: ");
            Altura = Convert.ToSingle (Console.ReadLine());


            if (Sexo == "masculino")
            {
                Altura = 72.7 * Altura - 58;
                
            }
            else
            {
                Altura = 62.1 * Altura -44.7;
                
            }
            Console.ReadKey();

        }
    }
}
