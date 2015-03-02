using System.Collections.Generic;
using Character_Inventory_Administrator.Dao;

namespace Character_Inventory_Administrator.Modelo
{
    public class HabilidadModel
    {
        private bool _deClase;
        private string _nombre;
        private string _atributoClave;
        private bool _normal;
        private int _rangos;
        //private int modClave;
        //private int modOtro;

        
        public bool DeClase
        {
            get { return _deClase; }
            set { _deClase = value; }
        }
        public string Nombre
        {
            get { return _nombre; }
            set { _nombre = value; }
        }
        public string AtributoClave
        {
            get { return _atributoClave; }
            set { _atributoClave = value; }
        }
        public bool Normal
        {
            get { return _normal; }
            set { _normal = value; }
        }
        public int Rangos
        {
            get { return _rangos; }
            set { _rangos = value; }
        }

        //public int ModClave
        //{
        //    get { return modClave; }
        //    set { modClave = value; }
        //}
        //public int ModOtro
        //{
        //    get { return modOtro; }
        //    set { modOtro = value; }
        //}

        public HabilidadModel()
        {
            DeClase = false;
            Nombre = "";
            AtributoClave = "";
            Normal = false;
            Rangos = 0;
            //ModClave = 0;
            //ModOtro = 0;
        }

        public HabilidadModel(string nombre, string atributoClave, bool normal)
        {
            DeClase = false;
            Nombre = nombre;
            AtributoClave = atributoClave;
            Normal = normal;
            Rangos = 0;
            //ModClave = 0;
            //ModOtro = 0;
        }

        //public GetModClave(string atributoClave)
        //{
        //    switch (atributoClave)
        //        {
        //            case "Fuerza":
        //             //row.Cells[modClaveColumn.Name].Value = txtModFuerza.Text;
                     
        //             //   row.Cells[totalColumn.Name].Value = Convert.ToString(Convert.ToInt32(row.Cells[rangosColumn.Name].Value) +
        //             //                                       Convert.ToInt32(row.Cells[modClaveColumn.Name].Value) +
        //             //                                       Convert.ToInt32(row.Cells[modOtrosColumn.Name].Value));

        //             total = rangos + modclave(Fuerza) + modotros   

        //                break;
        //            case "Destreza":
                        
        //                break;
        //            case "Constitucion":
                        
        //                break;
        //            case "Inteligencia":
                        
        //                break;
        //            case "Sabiduria":
                        
        //                break;
        //            case "Carisma":
                        
        //                break;
        //        }
            
        //}

        //////////////////////////////////////////////////////// METODOS PARA ALMACENAMIENTO CON DAO DE LA CLASE //////////////////////////////////////////
        static private HabilidadesDAO _datos = new HabilidadesDAO();
        static private List<HabilidadModel> _listaHabilidades = new List<HabilidadModel>();
        
        static public HabilidadModel AgregarHabilidad(HabilidadModel nuevaHabilidadModel)
        {
            return nuevaHabilidadModel;
        }

        static public List<HabilidadModel> AgregarListaHabilidades(List<HabilidadModel> nuevaListaHabilidades)
        {
            _datos.AgregarArchivo(nuevaListaHabilidades);
            return nuevaListaHabilidades;
        }

        static public List<HabilidadModel> DameListaCompHabilidades()
        {
            return _datos.DameAll();
        }

        static public HabilidadModel BuscarPorNombre(string nombre)
        {
            _listaHabilidades = _datos.DameAll();
            foreach (HabilidadModel habilidad in _listaHabilidades)
            {
                if (habilidad.Nombre == nombre)
                {
                    return habilidad;
                }
            }
            return null;
        }
        //////////////////////////////////////////////////////// METODOS PARA ALMACENAMIENTO CON DAO DE LA CLASE //////////////////////////////////////////

    }
}
