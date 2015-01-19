﻿using System.Collections.Generic;
using System.IO;
using System.Xml.Serialization;
using Character_Inventory_Administrator.Modelo;

namespace Character_Inventory_Administrator.Dao
{
    public class ClasesDAO : Interface_DAO<ClaseModel>
    {
        public List<ClaseModel> AgregarArchivo(List<ClaseModel> listaCompletadeClases)
        {
            TextWriter archivoEscritura = new StreamWriter(@"..\Clases.xml");
            XmlSerializer writer = new XmlSerializer(typeof(List<ClaseModel>));
            writer.Serialize(archivoEscritura, listaCompletadeClases);
            archivoEscritura.Close();
            return listaCompletadeClases;
        }

        public List<ClaseModel> DameAll()
        {
            List<ClaseModel> listaCompletadeClases = new List<ClaseModel>();
            if (File.Exists(@"..\Clases.xml"))
            {
                TextReader archivoLectura = new StreamReader(@"..\Clases.xml");
                XmlSerializer reader = new XmlSerializer(typeof(List<ClaseModel>));
                listaCompletadeClases = (List<ClaseModel>)reader.Deserialize(archivoLectura);
                archivoLectura.Close();
                return listaCompletadeClases;
            }
            else
            {
                return listaCompletadeClases;
            }
        }


        public ClaseModel Modificar(ClaseModel entidad)
        {
            throw new System.NotImplementedException();
        }

        public void Borrar(ClaseModel entidad)
        {
            throw new System.NotImplementedException();
        }

        public ClaseModel DameXId(string id)
        {
            throw new System.NotImplementedException();
        }
    }
}