using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Modelos
{
    public class Clase
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

        public Clase()
        {
            Nombre = "";
            ModAtributos = null;
            ListaModHabilidades = null;
        }

        public Clase(string nombreClase, Atributos atribClase)
        {
            Nombre = nombreClase;
            ModAtributos = atribClase;
        }
    }
}
