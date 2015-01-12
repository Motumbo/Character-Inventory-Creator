using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;
using System.Xml.Serialization;
using Modelos;

namespace Dao
{
    public class DaoRazas 
    {
        public List<Raza> AgregarArchivoRazas(List<Raza> listaCompletadeRazas)
        {
            TextWriter archivoEscritura = new StreamWriter(@"..\Razas.xml");
            XmlSerializer writer = new XmlSerializer(typeof(List<Raza>));
            writer.Serialize(archivoEscritura, listaCompletadeRazas);
            archivoEscritura.Close();
            return listaCompletadeRazas;
        }

        public List<Raza> DameAllRazas()
        {
            List<Raza> listaCompletadeRazas = new List<Raza>();
            if (File.Exists(@"..\Razas.xml"))
            {
                TextReader archivoLectura = new StreamReader(@"..\Razas.xml");
                XmlSerializer reader = new XmlSerializer(typeof(List<Raza>));
                listaCompletadeRazas = (List<Raza>)reader.Deserialize(archivoLectura);
                archivoLectura.Close();
                return listaCompletadeRazas;
            }
            else
            {
                return listaCompletadeRazas;
            }
        }

    }
}
