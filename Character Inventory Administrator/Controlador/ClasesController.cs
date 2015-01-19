using System.Collections.Generic;
using Character_Inventory_Administrator.Dao;
using Character_Inventory_Administrator.Modelo;

namespace Character_Inventory_Administrator.Controlador
{
    public class ClasesController
    {
        ClasesDAO _datos = new ClasesDAO();
        List<ClaseModel> _listaClases = new List<ClaseModel>(); 

        public ClaseModel AgregarClase(ClaseModel nuevaClaseModel)
        {
            return nuevaClaseModel;
        }

        public List<ClaseModel> AgregarListaClases(List<ClaseModel> nuevaListaClases)
        {
            _datos.AgregarArchivo(nuevaListaClases);
            return nuevaListaClases;
        }

        public List<ClaseModel> DameListaComp()
        {
            return _datos.DameAll();
        }

        public ClaseModel BuscarPorNombre(string nombre)
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
