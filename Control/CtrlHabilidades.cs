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
    }
}
