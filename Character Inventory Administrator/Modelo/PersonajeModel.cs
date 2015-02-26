using System.Collections.Generic;
using Character_Inventory_Administrator.Dao;

namespace Character_Inventory_Administrator.Modelo
{
    public class PersonajeModel
    {
        private string _nombre;
        private string _jugador;
        private int _nivel;
        private int _vida;
        private RazaModel _razaModel;
        private ClaseModel _claseModel;
        private AtributosModel _atributosModel;
        private List<HabilidadModel> _listHabilidadesModel;

        private string _edad;
        private string _sexo;
        private string _altura;
        private string _peso;
        private string _ojos;
        private string _pelo;
        private string _piel;

        ////////////////////////////////// PARA MANEJO DE DAO DE LA CLASE ////////////////////////////////////////////////////////////////

        static private PersonajesDAO _datos = new PersonajesDAO();
        static private List<PersonajeModel> _listaPersonajes = new List<PersonajeModel>();

        ////////////////////////////////// PARA MANEJO DE DAO DE LA CLASE ////////////////////////////////////////////////////////////////

        public string Nombre
        {
            get { return _nombre; }
            set { _nombre = value; }
        }
        public string Jugador
        {
            get { return _jugador; }
            set { _jugador = value; }
        }
        public int Nivel
        {
            get { return _nivel; }
            set { _nivel = value; }
        }
        public int Vida
        {
            get { return _vida; }
            set { _vida = value; }
        }
        public RazaModel RazaModel
        {
            get { return _razaModel; }
            set { _razaModel = value; }
        }
        public ClaseModel ClaseModel
        {
            get { return _claseModel; }
            set { _claseModel = value; }
        }
        public AtributosModel AtributosModel
        {
            get { return _atributosModel; }
            set { _atributosModel = value; }
        }
        public List<HabilidadModel> ListHabilidadesModel
        {
            get { return _listHabilidadesModel; }
            set { _listHabilidadesModel = value; }
        }
        public string Edad
        {
            get { return _edad; }
            set { _edad = value; }
        }       
        public string Sexo
        {
            get { return _sexo; }
            set { _sexo = value; }
        }        
        public string Altura
        {
            get { return _altura; }
            set { _altura = value; }
        }        
        public string Peso
        {
            get { return _peso; }
            set { _peso = value; }
        }        
        public string Ojos
        {
            get { return _ojos; }
            set { _ojos = value; }
        }        
        public string Pelo
        {
            get { return _pelo; }
            set { _pelo = value; }
        }       
        public string Piel
        {
            get { return _piel; }
            set { _piel = value; }
        }

        public PersonajeModel()
        {
            Nombre = "";
            Jugador = "";
            Nivel = 0;
            Vida = 0;
            RazaModel = new RazaModel();
            ClaseModel = new ClaseModel();
            AtributosModel = new AtributosModel();
            Edad = "";
            Sexo = "";
            Altura = "";
            Peso = "";
            Ojos = "";
            Pelo = "";
            Piel = "";
        }
        
        public PersonajeModel(string n, string j, int lvl, int v, RazaModel r, string e, string s, string a, string p, string o, string pe, string pi)
        {
            Nombre = n;
            Jugador = j;
            Nivel = lvl;
            Vida = v;
            RazaModel = r;
            Edad = e;
            Sexo = s;
            Altura = a;
            Peso = p;
            Ojos = o;
            Pelo = pe;
            Piel = pi;
        }

        public int Fuerza()
        {
            return AtributosModel.Fuerza + RazaModel.ModAtributosModel.Fuerza + ClaseModel.ModAtributosModel.Fuerza;
        }

        public int ModFuerza()
        {
            return (((Fuerza()) - 10)/2);
        }

        public int Destraza()
        {
            return AtributosModel.Destreza + RazaModel.ModAtributosModel.Destreza + ClaseModel.ModAtributosModel.Destreza;
        }

        public int ModDestreza()
        {
            return (((Destraza()) - 10)/2);
        }

        public int Constitucion()
        {
            return AtributosModel.Constitucion + RazaModel.ModAtributosModel.Constitucion + ClaseModel.ModAtributosModel.Constitucion;
        }

        public int ModConstitucion()
        {
            return (Constitucion() - 10)/2;
        }

        public int Inteligencia()
        {
            return AtributosModel.Inteligencia + RazaModel.ModAtributosModel.Inteligencia + ClaseModel.ModAtributosModel.Inteligencia;
        }

        public int ModInteligencia()
        {
            return (Inteligencia() - 10)/2;
        }

        public int Sabiduria()
        {
            return AtributosModel.Sabiduria + RazaModel.ModAtributosModel.Sabiduria + ClaseModel.ModAtributosModel.Sabiduria;
        }

        public int ModSabiduria()
        {
            return (Sabiduria() - 10)/2;
        }

        public int Carisma()
        {
            return AtributosModel.Carisma + RazaModel.ModAtributosModel.Carisma + ClaseModel.ModAtributosModel.Carisma;
        }

        public int ModCarisma()
        {
            return (Carisma() - 10)/2;
        }

        ////////////////////////////////////////////////////////////////////////// METODOS DE ALMACENAMIENTO DE LA CLASE //////////////////////////////////////////

        static public PersonajeModel AgregarPersonaje(PersonajeModel nuevoPersonajeModel)
        {
            _listaPersonajes = _datos.DameAll();
            _listaPersonajes.Add(nuevoPersonajeModel);
            AgregarListPersonajes(_listaPersonajes);
            return nuevoPersonajeModel;
        }

        static public List<PersonajeModel> AgregarListPersonajes(List<PersonajeModel> nuevaListaPersonajes)
        {
            _datos.AgregarArchivo(nuevaListaPersonajes);
            return nuevaListaPersonajes;
        }

        static public List<PersonajeModel> DameListaComp()
        {
            return _datos.DameAll();
        }

        static public PersonajeModel BuscarPorNombre(string nombre)
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

        static public PersonajeModel BuscarPersonaje(PersonajeModel buscado)
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
    }
}
