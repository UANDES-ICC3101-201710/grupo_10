using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Net;

namespace grupo_10
{
    public class Carta
    {
        public string nombre;
        public string tipo;
        public int vida;
        public int precio;
        public int at;
        public int de;
        

        public Carta(string nombre, string tipo, int vida, int precio, int at, int de)
        {
            this.nombre = nombre;
            this.tipo = tipo;
            this.vida = vida;
            this.precio = precio;
            this.at = at;
            this.de = de;
        }

    }
}

