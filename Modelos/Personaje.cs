using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Modelos
{
    public class Personaje
    {
        string nombre;
        string jugador;
        int nivel;
        int vida;
        Raza raza;
        Clase clase;
        Atributos atributos;

        string edad;
        string sexo;
        string altura;
        string peso;
        string ojos;
        string pelo;
        string piel;
        


        public string Nombre
        {
            get { return nombre; }
            set { nombre = value; }
        }

        public string Jugador
        {
            get { return jugador; }
            set { jugador = value; }
        }

        public int Nivel
        {
            get { return nivel; }
            set { nivel = value; }
        }

        public int Vida
        {
            get { return vida; }
            set { vida = value; }
        }

        public Raza Raza
        {
            get { return raza; }
            set { raza = value; }
        }

        public Clase Clase
        {
            get { return clase; }
            set { clase = value; }
        }

        public Atributos Atributos
        {
            get { return atributos; }
            set { atributos = value; }
        }

        public string Edad
        {
            get { return edad; }
            set { edad = value; }
        }       

        public string Sexo
        {
            get { return sexo; }
            set { sexo = value; }
        }        

        public string Altura
        {
            get { return altura; }
            set { altura = value; }
        }        

        public string Peso
        {
            get { return peso; }
            set { peso = value; }
        }        

        public string Ojos
        {
            get { return ojos; }
            set { ojos = value; }
        }        

        public string Pelo
        {
            get { return pelo; }
            set { pelo = value; }
        }       

        public string Piel
        {
            get { return piel; }
            set { piel = value; }
        }



        public Personaje()
        {
            Nombre = "";
            Jugador = "";
            Nivel = 0;
            Vida = 0;
            Raza = new Raza();
            Clase = new Clase();
            Atributos = new Atributos();
            Edad = "";
            Sexo = "";
            Altura = "";
            Peso = "";
            Ojos = "";
            Pelo = "";
            Piel = "";
        }
        
        public Personaje(string n, string j, int lvl, int v, Raza r, string e, string s, string a, string p, string o, string pe, string pi)
        {
            Nombre = n;
            Jugador = j;
            Nivel = lvl;
            Vida = v;
            Raza = r;
            Edad = e;
            Sexo = s;
            Altura = a;
            Peso = p;
            Ojos = o;
            Pelo = pe;
            Piel = pi;
        }

        public int fuerza()
        {
            return Atributos.Fuerza + raza.ModAtributos.Fuerza + clase.ModAtributos.Fuerza;
        }
    }
}
