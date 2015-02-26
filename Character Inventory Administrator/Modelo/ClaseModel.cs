using System.Collections.Generic;
using Character_Inventory_Administrator.Dao;

namespace Character_Inventory_Administrator.Modelo
{
    public class ClaseModel
    {
        private string _nombre;
        private AtributosModel _modAtributosModel;
        private List<HabilidadModel> _listaHabilidadesClase;
        
        ////////////////////////////////// PARA MANEJO DE DAO DE LA CLASE ////////////////////////////////////////////////////////////////
        
        static private ClasesDAO _datos = new ClasesDAO();
        static private List<ClaseModel> _listaClases = new List<ClaseModel>();

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

        public List<HabilidadModel> ListaHabilidadesClase
        {
            get { return _listaHabilidadesClase; }
            set { _listaHabilidadesClase = value; }
        }

        public ClaseModel()
        {
            Nombre = "";
            ModAtributosModel = new AtributosModel();
            ListaHabilidadesClase = new List<HabilidadModel>();
        }

        public ClaseModel(string nombreClase, AtributosModel atribClase, List<HabilidadModel> listaHabilidades)
        {
            Nombre = nombreClase;
            ModAtributosModel = atribClase;
            ListaHabilidadesClase = listaHabilidades;
        }

        ////////////////////////////////////////////////////////////////////////// METODOS DE ALMACENAMIENTO DE LA CLASE //////////////////////////////////////////

        static public ClaseModel AgregarClase(ClaseModel nuevaClaseModel)
        {
            return nuevaClaseModel;
        }

        static public List<ClaseModel> AgregarListaClases(List<ClaseModel> nuevaListaClases)
        {
            _datos.AgregarArchivo(nuevaListaClases);
            return nuevaListaClases;
        }

        static public List<ClaseModel> DameListaCompClases()
        {
            return _datos.DameAll();
        }

        static public ClaseModel BuscarPorNombre(string nombre)
        {
            _listaClases = _datos.DameAll();
            foreach (ClaseModel clase in _listaClases)
            {
                if (clase.Nombre == nombre)
                {
                    return clase;
                }
            }
            return null;
        }
    }
}
