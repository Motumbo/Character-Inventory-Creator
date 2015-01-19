namespace Character_Inventory_Administrator.Dao
{
    public abstract class AbstractSingletonDAO<D> where D : AbstractSingletonDAO<D>, new()
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
