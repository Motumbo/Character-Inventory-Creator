using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Xml.Serialization;
using Character_Inventory_Administrator.Dao;

namespace Character_Inventory_Administrator.Items
{
    class ItemDAO : Interface_DAO<ItemModel>
    {
        public List<ItemModel> AgregarArchivo(List<ItemModel> listaCompletadeItems)
        {
            TextWriter archivoEscritura = new StreamWriter(@"..\..\Archivos\Items.xml");
            XmlSerializer writer = new XmlSerializer(typeof(List<ItemModel>));
            writer.Serialize(archivoEscritura, listaCompletadeItems);
            archivoEscritura.Close();
            return listaCompletadeItems;
        }

        public ItemModel Modificar(ItemModel entidad)
        {
            throw new NotImplementedException();
        }

        public void Borrar(ItemModel entidad)
        {
            throw new NotImplementedException();
        }

        public List<ItemModel> DameAll()
        {
            List<ItemModel> listaCompletadeItems = new List<ItemModel>();
            if (File.Exists(@"..\..\Archivos\Razas.xml"))
            {
                TextReader archivoLectura = new StreamReader(@"..\..\Archivos\Items.xml");
                XmlSerializer reader = new XmlSerializer(typeof(List<ItemModel>));
                listaCompletadeItems = (List<ItemModel>)reader.Deserialize(archivoLectura);
                archivoLectura.Close();
                return listaCompletadeItems;
            }
            else
            {
                return listaCompletadeItems;
            }
        }

        public ItemModel DameXId(string id)
        {
            throw new NotImplementedException();
        }
    }
}
