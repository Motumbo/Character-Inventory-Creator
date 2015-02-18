namespace Character_Inventory_Administrator.Modelo
{
    public class HabilidadModel
    {
        string nombre;
        string atributoClave;
        int rangos;
        
        //int modClave;
        //int modOtro;

        //int mod1;
        //int mod2;
        
        public string Nombre
        {
            get { return nombre; }
            set { nombre = value; }
        }
        public string AtributoClave
        {
            get { return atributoClave; }
            set { atributoClave = value; }
        }
        public int Rangos
        {
            get { return rangos; }
            set { rangos = value; }
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
            Nombre = "";
            AtributoClave = "";
            Rangos = 0;
            //ModClave = 0;
            //ModOtro = 0;
        }

        public HabilidadModel(string _nombre, string _atributoClave)
        {
            Nombre = _nombre;
            AtributoClave = _atributoClave;
            Rangos = 0;
            //ModClave = 0;
            //ModOtro = 0;
        }

        //public GetModClave(string atributoClave)
        //{
        //    switch (atributoClave)
        //        {
        //            case "Fuerza":
                        
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
    }
}
