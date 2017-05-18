using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace grupo_10
{
    public class Tablero : Carta
    {
        int maxCartas;
        List<Carta> tablero;

        public Tablero(int maxCartas)
        {
            this.maxCartas = maxCartas;
            List<Carta> tablero = new List<Carta>();
        }
       
    }
}
