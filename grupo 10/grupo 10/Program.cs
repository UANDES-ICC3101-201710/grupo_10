using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Net;

namespace grupo_10
{


    class Program
    {

        static void Main(string[] args)
        {
            Console.WriteLine("Hola, Ingrese su nombre: ");
            string nombre = Console.ReadLine();
            grupo_10.Jugador player1 = new grupo_10.Jugador(nombre, 30, 1);

            Console.WriteLine("Estas son las cartas de su mano: ");
            Console.WriteLine(mano);



        }
    }
}
