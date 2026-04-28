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

            public void Inicio()

            {
                Console.WriteLine("Inicie sesion.");


            }



        }



        static void Main(string[] args)
        {
            Pc c = new Pc();

            Console.Write("Ingrese el modelo de su pc (Dell,Hp...): ");

            c.modelo = Console.ReadLine();

            Console.WriteLine();

            Console.Write("Ingrese el sistema operativo de su pc (windows,Linux,MacOs....):  ");

            c.sistemaop = Console.ReadLine();

            Console.WriteLine();

            c.Encender();

            c.Inicio();


        }
    }
}
