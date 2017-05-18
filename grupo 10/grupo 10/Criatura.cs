using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace grupo_10
{
    class Criatura : Carta
    {
        public Criatura(string nombre, string tipo, int vida, int precio, int at, int de, string especialidad) : base(nombre, tipo, vida, precio, at, de, especialidad)
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
