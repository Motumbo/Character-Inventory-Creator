using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;
using System.Xml.Serialization;
using Modelos;

namespace Dao
{
    public class DaoHabilidades
    {
        public List<Habilidad> AgregarArchivoHabilidades(List<Habilidad> listaCompletadeHabilidades)
        {
            TextWriter archivoEscritura = new StreamWriter(@"..\Habilidades Comunes.xml");
            XmlSerializer writer = new XmlSerializer(typeof(List<Habilidad>));
            writer.Serialize(archivoEscritura, listaCompletadeHabilidades);
            archivoEscritura.Close();
            return listaCompletadeHabilidades;
        }

        public List<Habilidad> DameAllHabilidades()
        {
            List<Habilidad> listaCompletadeHabilidades = new List<Habilidad>();
            if (File.Exists(@"..\Habilidades Comunes.xml"))
            {
                TextReader archivoLectura = new StreamReader(@"..\Habilidades Comunes.xml");
                XmlSerializer reader = new XmlSerializer(typeof(List<Habilidad>));
                listaCompletadeHabilidades = (List<Habilidad>)reader.Deserialize(archivoLectura);
                archivoLectura.Close();
                return listaCompletadeHabilidades;
            }
            else
            {
                return listaCompletadeHabilidades;
            }
        }
    }
}
