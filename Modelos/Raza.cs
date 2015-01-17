using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Modelos
{
    public class Raza
    {
        string _nombre;
        Atributos _modAtributos;
        List<Habilidad> _listaModHabilidades;

        public string Nombre
        {
            get { return _nombre; }
            set { _nombre = value; }
        }

        public Atributos ModAtributos
        {
            get { return _modAtributos; }
            set { _modAtributos = value; }
        }

        public List<Habilidad> ListaHabilidadesRaza
        {
            get { return _listaModHabilidades; }
            set { _listaModHabilidades = value; }
        }

        public Raza()
        {
            Nombre = "";
            ModAtributos = new Atributos();
            ListaHabilidadesRaza = new List<Habilidad>();
        }

        public Raza(string nombreRaza, Atributos atribRaza)
        {
            Nombre = nombreRaza;
            ModAtributos = atribRaza;
            ListaHabilidadesRaza = null;
        }
    }
}
