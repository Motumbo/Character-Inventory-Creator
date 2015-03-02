using System.Collections.Generic;
using Character_Inventory_Administrator.Dao;

namespace Character_Inventory_Administrator.Modelo
{
    public class ClaseModel
    {
        private string _nombre;
        private AtributosModel _modAtributosModel;
        private int _dadoPuntosVida;
        private int _velocidad;
        private List<HabilidadModel> _listaHabilidadesClase;
        
        
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
        public int DadoPuntosVida
        {
            get { return _dadoPuntosVida; }
            set { _dadoPuntosVida = value; }
        }
        public int Velocidad
        {
            get { return _velocidad; }
            set { _velocidad = value; }
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
            DadoPuntosVida = 0;
            Velocidad = 0;
            ListaHabilidadesClase = new List<HabilidadModel>();
        }

        public ClaseModel(string nombreClase, AtributosModel atribClase, int dadoPuntosVida, int velocidadClase,List<HabilidadModel> listaHabilidades)
        {
            Nombre = nombreClase;
            ModAtributosModel = atribClase;
            DadoPuntosVida = dadoPuntosVida;
            Velocidad = velocidadClase;
            ListaHabilidadesClase = listaHabilidades;
        }

        //////////////////////////////////////////////////////// METODOS PARA ALMACENAMIENTO CON DAO DE LA CLASE //////////////////////////////////////////
        static private ClasesDAO _datos = new ClasesDAO();
        static private List<ClaseModel> _listaClases = new List<ClaseModel>();

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
        //////////////////////////////////////////////////////// METODOS PARA ALMACENAMIENTO CON DAO DE LA CLASE //////////////////////////////////////////
    
    }
}
