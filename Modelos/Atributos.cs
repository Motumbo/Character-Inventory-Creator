using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Modelos
{
    public class Atributos
    {
        int fuerza;
        int destreza;
        int constitucion;
        int inteligencia;
        int sabiduria;
        int carisma;
        //todo: refactorizar atributos
        public int Fuerza
        {
            get { return fuerza; }
            set { fuerza = value; }
        }
        public int Destreza
        {
            get { return destreza; }
            set { destreza = value; }
        }
        public int Constitucion
        {
            get { return constitucion; }
            set { constitucion = value; }
        }
        public int Inteligencia
        {
            get { return inteligencia; }
            set { inteligencia = value; }
        }
        public int Sabiduria
        {
            get { return sabiduria; }
            set { sabiduria = value; }
        }
        public int Carisma
        {
            get { return carisma; }
            set { carisma = value; }
        }

        public Atributos()
        {
            Fuerza = 0;
            Destreza = 0;
            Constitucion = 0;
            Inteligencia = 0;
            Sabiduria = 0;
            Carisma = 0;
        }

        public Atributos(int f, int d, int c, int i, int s, int ch)
        {
            Fuerza = f;
            Destreza = d;
            Constitucion = c;
            Inteligencia = i;
            Sabiduria = s;
            Carisma = ch;
        }
    }
}
