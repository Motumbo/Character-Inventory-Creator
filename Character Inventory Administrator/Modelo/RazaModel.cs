using System.Collections.Generic;
using Character_Inventory_Administrator.Dao;

namespace Character_Inventory_Administrator.Modelo
{
    public class RazaModel
    {
        private string _nombre;
        private AtributosModel _modAtributosModel;
        private List<HabilidadModel> _listaModHabilidades;

        ////////////////////////////////// PARA MANEJO DE DAO DE LA CLASE ////////////////////////////////////////////////////////////////

        static private RazasDAO _datos = new RazasDAO();
        static private List<RazaModel> _listaRazas = new List<RazaModel>();

        ////////////////////////////////// PARA MANEJO DE DAO DE LA CLASE ////////////////////////////////////////////////////////////////

        public string Nombre
        {
            get { return _nombre; }
            set { _nombre = value; }
        }

        public AtributosModel ModAtributosModel
        {
            get { return _modAtributosModel; }
            set { _modAtributosModel = value; }
        }

        public List<HabilidadModel> ListaHabilidadesRaza
        {
            get { return _listaModHabilidades; }
            set { _listaModHabilidades = value; }
        }

        public RazaModel()
        {
            Nombre = "";
            ModAtributosModel = new AtributosModel();
            ListaHabilidadesRaza = new List<HabilidadModel>();
        }

        public RazaModel(string nombreRaza, AtributosModel atribRaza)
        {
            Nombre = nombreRaza;
            ModAtributosModel = atribRaza;
            ListaHabilidadesRaza = null;
        }

        ////////////////////////////////////////////////////////////////////////// METODOS DE ALMACENAMIENTO DE LA CLASE //////////////////////////////////////////

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
    }
}
