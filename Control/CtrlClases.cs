using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Dao;
using Modelos;

namespace Control
{
    public class CtrlClases
    {
        DaoClases datosClases = new DaoClases();

        public Clase AgregarClase(Clase nuevaClase)
        {
            return nuevaClase;
        }

        public List<Clase> AgregarListaClases(List<Clase> nuevaListaClases)
        {
            datosClases.AgregarArchivoClases(nuevaListaClases);
            return nuevaListaClases;
        }

        public List<Clase> DameListaComp()
        {
            return datosClases.DameAllClases();
        }
    }
}
