using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Net;

namespace grupo_10
{
    public interface IStart
    {
        void DefinirMazo();

    }
    public interface IJugando
    {
        void DefinirMano();
        void DefinirCristales();
        void Atacar();
        void Defender();
        void NuevaCarta();
        void EliminarCarta();
        void FinTurno();

    }

    public class Jugador : Carta , IJugando , IStart

    {
        string nameJugador;
        int vidaJ;
        int mana;
        List<Carta> mazo;
        List<Carta> mano;




        public Jugador(string nameJugador, int vidaJ, int mana)
        {
            this.nameJugador = nameJugador;
            this.vidaJ = vidaJ;
            this.mana = mana;
            List<Carta> mazo = new List<Carta>();
            List<Carta> mano = new List<Carta>();

        }
        
        public void DefinirMazo()
        {
            mazo.Add(new Carta("Wisp", "Minion", 1, 0, 1, 1));
            mazo.Add(new Carta("Wisp", "Minion", 1, 0, 1, 1));
            mazo.Add(new Carta("Wisp", "Minion", 1, 0, 1, 1));
            mazo.Add(new Carta("Murloc Raider", "Minion", 1, 1, 2, 2));
            mazo.Add(new Carta("Murloc Raider", "Minion", 1, 1, 2, 2));
            mazo.Add(new Carta("Murloc Raider", "Minion", 1, 1, 2, 2));
            mazo.Add(new Carta("Bloodfen Raptor", "Minion", 2, 2, 3, 3));
            mazo.Add(new Carta("Bloodfen Raptor", "Minion", 2, 2, 3, 3));
            mazo.Add(new Carta("Bloodfen Raptor", "Minion", 2, 2, 3, 3));
            mazo.Add(new Carta("River Crocolisk", "Minion", 3, 2, 2, 2));
            mazo.Add(new Carta("River Crocolisk", "Minion", 3, 2, 2, 2));
            mazo.Add(new Carta("River Crocolisk", "Minion", 3, 2, 2, 2));
            mazo.Add(new Carta("Magma Rager", "Minion", 1, 3, 5, 5));
            mazo.Add(new Carta("Magma Rager", "Minion", 1, 3, 5, 5));
            mazo.Add(new Carta("Magma Rager", "Minion", 1, 3, 5, 5));
            mazo.Add(new Carta("Chillwind Yeti", "Minion", 5, 4, 4, 4));
            mazo.Add(new Carta("Chillwind Yeti", "Minion", 5, 4, 4, 4));
            mazo.Add(new Carta("Chillwind Yeti", "Minion", 5, 4, 4, 4));
            mazo.Add(new Carta("Oasis Snapjaw", "Minion", 7, 4, 2, 2));
            mazo.Add(new Carta("Oasis Snapjaw", "Minion", 7, 4, 2, 2));
            mazo.Add(new Carta("Oasis Snapjaw", "Minion", 7, 4, 2, 2));
            mazo.Add(new Carta("Boulderfis Ogre", "Minion", 7, 6, 6, 6));
            mazo.Add(new Carta("Boulderfis Ogre", "Minion", 7, 6, 6, 6));
            mazo.Add(new Carta("Boulderfis Ogre", "Minion", 7, 6, 6, 6));
            mazo.Add(new Carta("War Golem", "Minion", 7, 7, 7, 7));
            mazo.Add(new Carta("War Golem", "Minion", 7, 7, 7, 7));
            mazo.Add(new Carta("War Golem", "Minion", 7, 7, 7, 7));
            mazo.Add(new Carta("Core Hound", "Minion", 5, 7, 9, 9));
            mazo.Add(new Carta("Core Hound", "Minion", 5, 7, 9, 9));
            mazo.Add(new Carta("Core Hound", "Minion", 5, 7, 9, 9));
            


        }

        public void DefinirMano()
        {
            int i = 0;
            while (i < 5)
            {
                var ran = new Random();
                mano.Add(mazo[ran]);
                mazo.Remove(mazo[ran]);
                i++;
            }



        }
        public void Atacar()
        {

        }
        public void Defender() { }
        public void DefinirCristales() { }
        public void NuevaCarta()
        {
            var ran = new Random();
            mano.Add(mazo[ran]);
            mazo.Remove(mazo[ran]);

        }
        public void EliminarCarta()
        {
            if (Carta.vida = 0)
            {

            }
        }
        public void FinTurno() { }

    }
    
}
