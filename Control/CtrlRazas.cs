using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Dao;
using Modelos;

namespace Control
{
    public class CtrlRazas
    {
        DaoRazas datosRazas = new DaoRazas();
        List<Raza> _listaRazas = new List<Raza>();

        public Raza AgregarRaza(Raza nuevaRaza)
        {
            return nuevaRaza;
        }

        public List<Raza> AgregarListaRazas(List<Raza> nuevaListaRazas)
        {
            datosRazas.AgregarArchivoRazas(nuevaListaRazas);
            return nuevaListaRazas;
        }

        public List<Raza> DameListaComp()
        {
            return datosRazas.DameAllRazas();
        }

        public Raza BuscarPorNombre(string nombre)
        {
            _listaRazas = datosRazas.DameAllRazas();
            foreach (Raza raza in _listaRazas)
            {
                if (raza.Nombre == nombre)
                {
                    return raza;
                }
            }
            return null;
        }
    }
}
