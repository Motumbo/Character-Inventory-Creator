using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Dao;
using Modelos;

namespace Control
{
    public class CtrlHabilidades
    {
        DaoHabilidades datosHabilidades = new DaoHabilidades();
        List<Habilidad> _listaHabilidades = new List<Habilidad>(); 

        public Habilidad AgregarHabilidad(Habilidad nuevaHabilidad)
        {
            return nuevaHabilidad;
        }

        public List<Habilidad> AgregarListaHabilidades(List<Habilidad> nuevaListaHabilidades)
        {
            datosHabilidades.AgregarArchivoHabilidades(nuevaListaHabilidades);
            return nuevaListaHabilidades;
        }

        public List<Habilidad> DameListaComp()
        {
            return datosHabilidades.DameAllHabilidades();
        }

        public Habilidad BuscarPorNombre(string nombre)
        {
            _listaHabilidades = datosHabilidades.DameAllHabilidades();
            foreach (Habilidad habilidad in _listaHabilidades)
            {
                if (habilidad.Nombre == nombre)
                {
                    return habilidad;
                }
            }
            return null;
        }
    }
}
