using System.Collections.Generic;
using Character_Inventory_Administrator.Dao;
using Character_Inventory_Administrator.Modelo;

namespace Character_Inventory_Administrator.Controlador
{
    public class RazasController
    {
        RazasDAO _datos = new RazasDAO();
        List<RazaModel> _listaRazas = new List<RazaModel>();

        public RazaModel AgregarRaza(RazaModel nuevaRazaModel)
        {
            return nuevaRazaModel;
        }

        public List<RazaModel> AgregarListaRazas(List<RazaModel> nuevaListaRazas)
        {
            _datos.AgregarArchivo(nuevaListaRazas);
            return nuevaListaRazas;
        }

        public List<RazaModel> DameListaComp()
        {
            return _datos.DameAll();
        }

        public RazaModel BuscarPorNombre(string nombre)
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
