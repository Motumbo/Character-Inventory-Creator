using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Dao
{
    public interface Interface_DAO <T>
    {
        T Grabar(T entidad);
        T Modificar(T entidad);
        void Borrar(T entidad);
        List<T> DameTodos();
        T DameXId(string id);
    }
}
