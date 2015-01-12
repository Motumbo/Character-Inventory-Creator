using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;
using System.Xml.Serialization;
using Modelos;

namespace Dao
{
    public class DaoClases
    {
        public List<Clase> AgregarArchivoClases(List<Clase> listaCompletadeClases)
        {
            TextWriter archivoEscritura = new StreamWriter(@"..\Clases.xml");
            XmlSerializer writer = new XmlSerializer(typeof(List<Clase>));
            writer.Serialize(archivoEscritura, listaCompletadeClases);
            archivoEscritura.Close();
            return listaCompletadeClases;
        }

        public List<Clase> DameAllClases()
        {
            List<Clase> listaCompletadeClases = new List<Clase>();
            if (File.Exists(@"..\Clases.xml"))
            {
                TextReader archivoLectura = new StreamReader(@"..\Clases.xml");
                XmlSerializer reader = new XmlSerializer(typeof(List<Clase>));
                listaCompletadeClases = (List<Clase>)reader.Deserialize(archivoLectura);
                archivoLectura.Close();
                return listaCompletadeClases;
            }
            else
            {
                return listaCompletadeClases;
            }
        }
    }
}
