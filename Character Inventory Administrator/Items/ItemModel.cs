using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Character_Inventory_Administrator.PropiedadesEspeciales;

namespace Character_Inventory_Administrator.Items
{
    class ItemModel
    {
        private String _nombre;
        private String _categoria;
        private String _tamaño;
        private float _peso;
        private String _imagePath;
        private int _altoImagen;
        private int _anchoImagen;
        private int _maxStack;

        private List<PropiedadesEspecialesModel> _listaPropiedadesEspecialesItem;

        public ItemModel()
        {
            Nombre = "";
            Categoria = "";
            Tamaño = "";
            Peso = 0;
            ImagePath = "";
            MaxStack = 0;
            ListaPropiedadesEspecialesItem = null;
        }

        public ItemModel(String nombre, String categoria, String tamaño, float peso, String imagenPath, int alto, int ancho, int maxStack)
        {
            Nombre = nombre;
            Categoria = categoria;
            Tamaño = tamaño;
            Peso = peso;
            ImagePath = imagenPath;
            AltoImagen = alto;
            AnchoImagen = ancho;
            MaxStack = maxStack;
            ListaPropiedadesEspecialesItem = null;
        }

        public string Nombre
        {
            get { return _nombre; }
            set { _nombre = value; }
        }

        public string Categoria
        {
            get { return _categoria; }
            set { _categoria = value; }
        }

        public string Tamaño
        {
            get { return _tamaño; }
            set { _tamaño = value; }
        }

        public float Peso
        {
            get { return _peso; }
            set { _peso = value; }
        }

        public string ImagePath
        {
            get { return _imagePath; }
            set { _imagePath = value; }
        }

        public int AltoImagen
        {
            get { return _altoImagen; }
            set { _altoImagen = value; }
        }

        public int AnchoImagen
        {
            get { return _anchoImagen; }
            set { _anchoImagen = value; }
        }

        public int MaxStack
        {
            get { return _maxStack; }
            set { _maxStack = value; }
        }

        public List<PropiedadesEspecialesModel> ListaPropiedadesEspecialesItem
        {
            get { return _listaPropiedadesEspecialesItem; }
            set { _listaPropiedadesEspecialesItem = value; }
        }

        
        //////////////////////////////////////////////////////// METODOS PARA ALMACENAMIENTO CON DAO DE LA CLASE //////////////////////////////////////////
        static private ItemDAO _datos = new ItemDAO();
        static private List<ItemModel> _listaItems = new List<ItemModel>();

        static public ItemModel AgregarRaza(ItemModel nuevoItemModel)
        {
            return nuevoItemModel;
        }

        static public List<ItemModel> AgregarListaItems(List<ItemModel> nuevaListaItems)
        {
            _datos.AgregarArchivo(nuevaListaItems);
            return nuevaListaItems;
        }

        static public List<ItemModel> DameListaCompItems()
        {
            return _datos.DameAll();
        }

        static public ItemModel BuscarPorNombre(string nombre)
        {
            _listaItems = _datos.DameAll();
            foreach (ItemModel item in _listaItems)
            {
                if (item.Nombre == nombre)
                {
                    return item;
                }
            }
            return null;
        }
        //////////////////////////////////////////////////////// METODOS PARA ALMACENAMIENTO CON DAO DE LA CLASE //////////////////////////////////////////

    }
}
