using System.Collections.Generic;
using System.IO;
using System.Xml.Serialization;
using Character_Inventory_Administrator.Modelo;

namespace Character_Inventory_Administrator.Dao
{
    public class PersonajesDAO : Interface_DAO<PersonajeModel>
    {
        public List<PersonajeModel> AgregarArchivo(List<PersonajeModel> listaCompletadePersonajes)
        {
            TextWriter archivoEscritura = new StreamWriter(@"..\Personajes.xml");
            XmlSerializer writer = new XmlSerializer(typeof(List<PersonajeModel>));
            writer.Serialize(archivoEscritura, listaCompletadePersonajes);
            archivoEscritura.Close();
            return listaCompletadePersonajes;
        }

        public List<PersonajeModel> DameAll()
        {
            List<PersonajeModel> listaCompletadePersonajes = new List<PersonajeModel>();
            if (File.Exists(@"..\Personajes.xml"))
            {
                TextReader archivoLectura = new StreamReader(@"..\Personajes.xml");
                XmlSerializer reader = new XmlSerializer(typeof(List<PersonajeModel>));
                listaCompletadePersonajes = (List<PersonajeModel>)reader.Deserialize(archivoLectura);
                archivoLectura.Close();
                return listaCompletadePersonajes;
            }
            else
            {
                return listaCompletadePersonajes;
            }
        }


        public PersonajeModel Modificar(PersonajeModel entidad)
        {
            throw new System.NotImplementedException();
        }

        public void Borrar(PersonajeModel entidad)
        {
            throw new System.NotImplementedException();
        }

        public PersonajeModel DameXId(string id)
        {
            throw new System.NotImplementedException();
        }
    }
}
