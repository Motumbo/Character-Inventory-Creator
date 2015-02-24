using System.Collections.Generic;
using System.IO;
using System.Xml.Serialization;
using Character_Inventory_Administrator.Modelo;

namespace Character_Inventory_Administrator.Dao
{
    public class HabilidadesDAO : Interface_DAO<HabilidadModel>
    {
        public List<HabilidadModel> AgregarArchivo(List<HabilidadModel> listaCompletadeHabilidades)
        {
            TextWriter archivoEscritura = new StreamWriter(@"..\..\Archivos\Habilidades Comunes.xml");
            XmlSerializer writer = new XmlSerializer(typeof(List<HabilidadModel>));
            writer.Serialize(archivoEscritura, listaCompletadeHabilidades);
            archivoEscritura.Close();
            return listaCompletadeHabilidades;
        }

        public List<HabilidadModel> DameAll()
        {
            List<HabilidadModel> listaCompletadeHabilidades = new List<HabilidadModel>();
            if (File.Exists(@"..\..\Archivos\Habilidades Comunes.xml"))
            {
                TextReader archivoLectura = new StreamReader(@"..\..\Archivos\Habilidades Comunes.xml");
                XmlSerializer reader = new XmlSerializer(typeof(List<HabilidadModel>));
                listaCompletadeHabilidades = (List<HabilidadModel>)reader.Deserialize(archivoLectura);
                archivoLectura.Close();
                return listaCompletadeHabilidades;
            }
            else
            {
                return listaCompletadeHabilidades;
            }
        }


        public HabilidadModel Modificar(HabilidadModel entidad)
        {
            throw new System.NotImplementedException();
        }

        public void Borrar(HabilidadModel entidad)
        {
            throw new System.NotImplementedException();
        }

        public HabilidadModel DameXId(string id)
        {
            throw new System.NotImplementedException();
        }
    }
}
