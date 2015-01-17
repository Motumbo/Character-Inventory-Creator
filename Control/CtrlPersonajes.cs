using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Dao;
using Modelos;

namespace Control
{
    class CtrlPersonajes
    {
        DaoPersonajes datosPersonajes = new DaoPersonajes();
        List<Personaje> _listaPersonajes = new List<Personaje>();

        public Personaje AgregarPersonaje(Personaje nuevoPersonaje)
        {
            return nuevoPersonaje;
        }

        public List<Personaje> AgregarListPersonajes(List<Personaje> nuevaListaPersonajes)
        {
            datosPersonajes.AgregarArchivoPersonajes(nuevaListaPersonajes);
            return nuevaListaPersonajes;
        }

        public List<Personaje> DameListaComp()
        {
            return datosPersonajes.DameAllPersonajes();
        }

        public Personaje BuscarPorNombre(string nombre)
        {
            _listaPersonajes = datosPersonajes.DameAllPersonajes();
            foreach (Personaje personaje in _listaPersonajes)
            {
                if (personaje.Nombre == nombre)
                {
                    return personaje;
                }
            }
            return null;
        }

        public Personaje BuscarPersonaje(Personaje buscado)
        {
            _listaPersonajes = datosPersonajes.DameAllPersonajes();
            foreach (Personaje personaje in _listaPersonajes)
            {
                if (personaje == buscado)
                {
                    return personaje;
                }
            }
            return null;
        }
    }
}
