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
        List<Habilidad> listaHabilidadesClase;

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

        public List<Habilidad> ListaHabilidadesClase
        {
            get { return listaHabilidadesClase; }
            set { listaHabilidadesClase = value; }
        }

        public Clase()
        {
            Nombre = "";
            ModAtributos = new Atributos();
            ListaHabilidadesClase = new List<Habilidad>();
        }

        public Clase(string nombreClase, Atributos atribClase, List<Habilidad> listaHabilidades)
        {
            Nombre = nombreClase;
            ModAtributos = atribClase;
            ListaHabilidadesClase = listaHabilidades;
        }
    }
}
