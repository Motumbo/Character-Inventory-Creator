using System.Collections.Generic;
using System.IO;
using System.Xml.Serialization;
using Character_Inventory_Administrator.Modelo;

namespace Character_Inventory_Administrator.Dao
{
    public class RazasDAO : Interface_DAO<RazaModel>
    {
        public List<RazaModel> AgregarArchivo(List<RazaModel> listaCompletadeRazas)
        {
            TextWriter archivoEscritura = new StreamWriter(@"..\..\Archivos\Razas.xml");
            XmlSerializer writer = new XmlSerializer(typeof(List<RazaModel>));
            writer.Serialize(archivoEscritura, listaCompletadeRazas);
            archivoEscritura.Close();
            return listaCompletadeRazas;
        }

        public List<RazaModel> DameAll()
        {
            List<RazaModel> listaCompletadeRazas = new List<RazaModel>();
            if (File.Exists(@"..\..\Archivos\Razas.xml"))
            {
                TextReader archivoLectura = new StreamReader(@"..\..\Archivos\Razas.xml");
                XmlSerializer reader = new XmlSerializer(typeof(List<RazaModel>));
                listaCompletadeRazas = (List<RazaModel>)reader.Deserialize(archivoLectura);
                archivoLectura.Close();
                return listaCompletadeRazas;
            }
            else
            {
                return listaCompletadeRazas;
            }
        }



        public RazaModel Modificar(RazaModel entidad)
        {
            throw new System.NotImplementedException();
        }

        public void Borrar(RazaModel entidad)
        {
            throw new System.NotImplementedException();
        }

        public RazaModel DameXId(string id)
        {
            throw new System.NotImplementedException();
        }
    }
}
