using System.Collections.Generic;

namespace Character_Inventory_Administrator.Dao
{
    public interface Interface_DAO <T>
    {
        List<T> AgregarArchivo(List<T> entidad);
        T Modificar(T entidad);
        void Borrar(T entidad);
        List<T> DameAll();
        T DameXId(string id);
    }
}
