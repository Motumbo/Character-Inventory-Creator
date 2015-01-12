using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Modelos
{
    public class Raza
    {
        string nombre;
        Atributos modAtributos;
        List<Habilidad> listaModHabilidades;

        public string Nombre
        {
            get { return nombre; }
            set { nombre = value; }
        }

        public Atributos ModAtributos
        {
            get { return modAtributos; }
            set { modAtributos = value; }
        }

        public List<Habilidad> ListaModHabilidades
        {
            get { return listaModHabilidades; }
            set { listaModHabilidades = value; }
        }

        public Raza()
        {
            Nombre = "";
            ModAtributos = null;
            ListaModHabilidades = null;
        }

        public Raza(string nombreRaza, Atributos atribRaza)
        {
            Nombre = nombreRaza;
            ModAtributos = atribRaza;
        }
    }
}
