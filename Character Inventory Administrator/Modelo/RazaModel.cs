using System.Collections.Generic;

namespace Character_Inventory_Administrator.Modelo
{
    public class RazaModel
    {
        string _nombre;
        AtributosModel _modAtributosModel;
        List<HabilidadModel> _listaModHabilidades;

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
    }
}
