using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Modelos
{
    public class Personaje
    {
        string nombre;
        int nivel;
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

        public int Nivel
        {
            get { return nivel; }
            set { nivel = value; }
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
            Raza = null;
            Clase = null;
            Atributos = null;
            Edad = "";
            Sexo = "";
            Altura = "";
            Peso = "";
            Ojos = "";
            Pelo = "";
            Piel = "";
        }

        public Personaje(string n, Raza r, string e, string s, string a, string p, string o, string pe, string pi)
        {
            Nombre = n;
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
