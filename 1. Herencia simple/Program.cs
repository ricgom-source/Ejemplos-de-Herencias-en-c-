using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1.Herencia_simple
{
    internal class Program
    {
        class Computadora

        {
            public string modelo;

            public string sistemaop;


            public void Encender()

            {

                Console.WriteLine("Encendiendo....");

                Console.WriteLine();

                Console.ReadKey();

                Console.WriteLine("Bienvenido");


            }


        }

        class Pc:Computadora

        {




        }






        static void Main(string[] args)
        {
        }
    }
}
