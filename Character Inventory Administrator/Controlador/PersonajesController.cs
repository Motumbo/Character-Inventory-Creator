using System.Collections.Generic;
using Character_Inventory_Administrator.Dao;
using Character_Inventory_Administrator.Modelo;
using Character_Inventory_Administrator.Vistas;

namespace Character_Inventory_Administrator.Controlador
{
    public class PersonajesController
    {
        private PersonajeModel _personajeModel;


        public PersonajeModel Modelo
        {
            get { return _personajeModel; }
            set { _personajeModel = value; }
        }


        PersonajesDAO _datos = new PersonajesDAO();
        List<PersonajeModel> _listaPersonajes = new List<PersonajeModel>();

        public PersonajeModel AgregarPersonaje(PersonajeModel nuevoPersonajeModel)
        {
            _listaPersonajes = _datos.DameAll();
            _listaPersonajes.Add(nuevoPersonajeModel);
            AgregarListPersonajes(_listaPersonajes);
            return nuevoPersonajeModel;
        }

        public List<PersonajeModel> AgregarListPersonajes(List<PersonajeModel> nuevaListaPersonajes)
        {
            _datos.AgregarArchivo(nuevaListaPersonajes);
            return nuevaListaPersonajes;
        }

        public List<PersonajeModel> DameListaComp()
        {
            return _datos.DameAll();
        }

        public PersonajeModel BuscarPorNombre(string nombre)
        {
            _listaPersonajes = _datos.DameAll();
            foreach (PersonajeModel personaje in _listaPersonajes)
            {
                if (personaje.Nombre == nombre)
                {
                    return personaje;
                }
            }
            return null;
        }

        public PersonajeModel BuscarPersonaje(PersonajeModel buscado)
        {
            _listaPersonajes = _datos.DameAll();
            foreach (PersonajeModel personaje in _listaPersonajes)
            {
                if (personaje == buscado)
                {
                    return personaje;
                }
            }
            return null;
        }

        public void UpdateSexo(string sexo)
        {
            _personajeModel.Sexo = sexo;
        }
    }
}
