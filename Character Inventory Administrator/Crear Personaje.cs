using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Control;
using Modelos;

namespace Character_Inventory_Administrator
{
    public partial class Crear_Personaje : Form
    {
        CtrlRazas manejoRazas = new CtrlRazas();
        CtrlClases manejoClases = new CtrlClases();
        CtrlHabilidades manejoHabilidades = new CtrlHabilidades();
        
        Atributos _atributosCreacion = new Atributos();
        Clase _claseCreacion = new Clase();
        Raza _razaCreacion = new Raza();

        List<Raza> listaRazas = new List<Raza>();
        List<Clase> listaClases = new List<Clase>();
        List<Habilidad> listaHabilidades = new List<Habilidad>();
        List<Personaje> listaPersonajes = new List<Personaje>();
        
        
        

        public Crear_Personaje()
        {
            InitializeComponent();
            listaClases = manejoClases.DameListaComp();
            listaRazas = manejoRazas.DameListaComp();
            InicializarSelectorRazas();
            InicializarSelectorClases();
        }

        private void Crear_Personaje_Load(object sender, EventArgs e)
        {
           
        }

        private void selectorClase_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void selectorRaza_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void btnContCreacion_Click(object sender, EventArgs e)
        {
            Personaje nuevoCharacter = new Personaje();
            nuevoCharacter.Altura = selectorAltura.Value.ToString();
            nuevoCharacter.Atributos = new Atributos((int)selectFuerza.Value, (int)selectDestreza.Value, (int)selectConstitucion.Value, (int)selectInteligencia.Value, (int)selectSabiduria.Value, (int)selectCarisma.Value);
            this.Close();
        }

        private void dataGridViewHabilidades_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void InicializarSelectorClases()
        {
            
            selectorClase.DataSource = listaClases;
            selectorClase.DisplayMember = "Nombre";
            selectorClase.ValueMember = "Nombre";
            selectorClase.SelectedValue = "";
        }

        private void InicializarSelectorRazas()
        {
            selectorRaza.DataSource = listaRazas;
            selectorRaza.DisplayMember = "Nombre";
            selectorRaza.ValueMember = "Nombre";
            selectorRaza.SelectedValue = "";
        }
    }
}
