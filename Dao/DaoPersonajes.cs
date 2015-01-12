using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;
using System.Xml.Serialization;
using Modelos;

namespace Dao
{
    public class DaoPersonajes
    {
        public List<Personaje> AgregarArchivoPersonajes(List<Personaje> listaCompletadePersonajes)
        {
            TextWriter archivoEscritura = new StreamWriter(@"..\Personajes.xml");
            XmlSerializer writer = new XmlSerializer(typeof(List<Personaje>));
            writer.Serialize(archivoEscritura, listaCompletadePersonajes);
            archivoEscritura.Close();
            return listaCompletadePersonajes;
        }

        public List<Personaje> DameAllPersonajes()
        {
            List<Personaje> listaCompletadePersonajes = new List<Personaje>();
            if (File.Exists(@"..\Personajes.xml"))
            {
                TextReader archivoLectura = new StreamReader(@"..\Personajes.xml");
                XmlSerializer reader = new XmlSerializer(typeof(List<Personaje>));
                listaCompletadePersonajes = (List<Personaje>)reader.Deserialize(archivoLectura);
                archivoLectura.Close();
                return listaCompletadePersonajes;
            }
            else
            {
                return listaCompletadePersonajes;
            }
        }
    }
}
