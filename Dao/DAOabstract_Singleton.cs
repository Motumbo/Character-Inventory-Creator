using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Dao
{
    public abstract class DAOabstract_Singleton<D> where D : DAOabstract_Singleton<D>, new()
    {
        private static D _instancia;

        public static D instancia()
        {
            if (_instancia == null)
            {
                _instancia = new D();
            }
            return _instancia;
        }
    }
}
