using System;
using System.Collections.Generic;
using System.Reflection;

namespace Character_Inventory_Administrator.Modelo
{
    public struct Atributos
    {
        public int Fuerza;
        public int Destreza;
        public int Constitucion;
        public int Inteligencia;
        public int Sabiduria;
        public int Carisma;
    }

    public class AtributosModel
    {
        private PersonajeModel _personaje;
        private Atributos _atributosBase;

        //todo: refactorizar atributos

        public AtributosModel(PersonajeModel personaje)
        {
            _personaje = personaje;

            _atributosBase.Fuerza = 0;
            _atributosBase.Destreza = 0;
            _atributosBase.Constitucion = 0;
            _atributosBase.Inteligencia = 0;
            _atributosBase.Sabiduria = 0;
            _atributosBase.Carisma = 0;
        }

        public AtributosModel(int f, int d, int c, int i, int s, int ch)
        {
            _atributosBase.Fuerza = f;
            _atributosBase.Destreza = d;
            _atributosBase.Constitucion = c;
            _atributosBase.Inteligencia = i;
            _atributosBase.Sabiduria = s;
            _atributosBase.Carisma = ch;
        }
       
        int AtributoValor(string atributo)
        {
            //Usamos reflection para no repetir codigo
            int valorAtributoBase = (int) this.GetType().GetMethod(atributo+"Base").Invoke(this, null); //Base
            int valorAtributoRaza = (int) _personaje.RazaModel.GetType().GetMethod(atributo).Invoke(_personaje.RazaModel, null); //Raza
            int valorAtributoClase = (int) _personaje.ClaseModel.GetType().GetMethod(atributo).Invoke(_personaje.ClaseModel, null); //Clase

            return valorAtributoBase + valorAtributoRaza + valorAtributoClase;
        }

        int AtributoMod(string atributo)
        {
            return (AtributoValor(atributo) - 10) / 2;
        }

        public int Fuerza() { return AtributoValor("Fuerza"); }
        public int FuerzaBase() {return _atributosBase.Fuerza;}
        public int ModFuerza() { return AtributoMod("Fuerza"); }

        public int Destreza() { return AtributoValor("Destreza"); }
        public int DestrezaBase() { return _atributosBase.Destreza; }
        public int ModDestreza() { return AtributoMod("Destreza"); }

        public int Constitucion() { return AtributoValor("Constitucion"); }
        public int ConstitucionBase() { return _atributosBase.Constitucion; }
        public int ModConstitucion() { return AtributoMod("Constitucion"); }

        public int Inteligencia() { return AtributoValor("Inteligencia"); }
        public int InteligenciaBase() { return _atributosBase.Inteligencia; }
        public int ModInteligencia() { return AtributoMod("Inteligencia"); }

        public int Sabiduria() { return AtributoValor("Sabiduria"); }
        public int SabiduriaBase() { return _atributosBase.Sabiduria; }
        public int ModSabiduria() { return AtributoMod("Sabiduria"); }

        public int Carisma() { return AtributoValor("Carisma"); }
        public int CarismaBase() { return _atributosBase.Carisma; }
        public int ModCarisma() { return AtributoMod("Carisma"); }




        //public int getAtributosDict() {
        //    //TODO: add getters
        //    Dictionary<string, attributeGetter> dictionary = new Dictionary<string, attributeGetter>();
        //    dictionary.Add("Fuerza", this.Fuerza);
        //    dictionary.Add("Destreza", this.Destreza);
        //    dictionary.Add("Constitucion", this.Constitucion);
        //    dictionary.Add("Inteligencia", this.Inteligencia);
        //    dictionary.Add("Sabiduria", this.Sabiduria);
        //    dictionary.Add("Carisma", this.Carisma);
        //}
    }
}
