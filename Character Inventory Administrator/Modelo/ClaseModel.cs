using System.Collections.Generic;

namespace Character_Inventory_Administrator.Modelo
{
    public class ClaseModel
    {
        string _nombre;
        AtributosModel _modAtributosModel;
        List<HabilidadModel> _listaHabilidadesClase;

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
    }
}
