using System.Collections.Generic;
using Character_Inventory_Administrator.Dao;
using Character_Inventory_Administrator.Modelo;

namespace Character_Inventory_Administrator.Controlador
{
    public class HabilidadesController
    {
        HabilidadesDAO _datos = new HabilidadesDAO();
        List<HabilidadModel> _listaHabilidades = new List<HabilidadModel>(); 

        public HabilidadModel AgregarHabilidad(HabilidadModel nuevaHabilidadModel)
        {
            return nuevaHabilidadModel;
        }

        public List<HabilidadModel> AgregarListaHabilidades(List<HabilidadModel> nuevaListaHabilidades)
        {
            _datos.AgregarArchivo(nuevaListaHabilidades);
            return nuevaListaHabilidades;
        }

        public List<HabilidadModel> DameListaComp()
        {
            return _datos.DameAll();
        }

        public HabilidadModel BuscarPorNombre(string nombre)
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
    }
}
