using System.Collections.Generic;
using Character_Inventory_Administrator.Dao;

namespace Character_Inventory_Administrator.Modelo
{
    public class RazaModel
    {
        private string _nombre;
        private Atributos _modAtributos;
        private List<HabilidadModel> _listaModHabilidades;
        private string _tamaño;
        private int _velocidad;


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
        public List<HabilidadModel> ListaHabilidadesRaza
        {
            get { return _listaModHabilidades; }
            set { _listaModHabilidades = value; }
        }
        public string Tamaño
        {
            get { return _tamaño; }
            set { _tamaño = value; }
        }
        public int Velocidad
        {
            get { return _velocidad; }
            set { _velocidad = value; }
        }

        

        public RazaModel()
        {
            Nombre = "";           
            ListaHabilidadesRaza = new List<HabilidadModel>();
            Tamaño = "";
            Velocidad = 0;
        }

        public RazaModel(string nombreRaza, Atributos atribRaza, string tamañoRaza, int velocidadRaza)
        {
            Nombre = nombreRaza;
            ModAtributos = atribRaza;
            ListaHabilidadesRaza = null;
            Tamaño = tamañoRaza;
            Velocidad = velocidadRaza;
        }

        //////////////////////////////////////////////////////// METODOS PARA ALMACENAMIENTO CON DAO DE LA CLASE //////////////////////////////////////////
        static private RazasDAO _datos = new RazasDAO();
        static private List<RazaModel> _listaRazas = new List<RazaModel>();

        static public RazaModel AgregarRaza(RazaModel nuevaRazaModel)
        {
            return nuevaRazaModel;
        }

        static public List<RazaModel> AgregarListaRazas(List<RazaModel> nuevaListaRazas)
        {
            _datos.AgregarArchivo(nuevaListaRazas);
            return nuevaListaRazas;
        }

        static public List<RazaModel> DameListaCompRazas()
        {
            return _datos.DameAll();
        }

        static public RazaModel BuscarPorNombre(string nombre)
        {
            _listaRazas = _datos.DameAll();
            foreach (RazaModel raza in _listaRazas)
            {
                if (raza.Nombre == nombre)
                {
                    return raza;
                }
            }
            return null;
        }
        //////////////////////////////////////////////////////// METODOS PARA ALMACENAMIENTO CON DAO DE LA CLASE //////////////////////////////////////////
        
    }
}
