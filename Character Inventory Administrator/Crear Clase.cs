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
    public partial class Crear_Clase : Form
    {
        List<Clase> listaClases = new List<Clase>();
        CtrlClases manejoClases = new CtrlClases();
        CtrlHabilidades manejoHabilidades = new CtrlHabilidades();

        public Crear_Clase()
        {
            InitializeComponent();
            listaClases = manejoClases.DameListaComp();
            InicializadorBoxClases();

            checkedListBoxHabilidades.DataSource = manejoHabilidades.DameListaComp();
            checkedListBoxHabilidades.DisplayMember = "Nombre";
            checkedListBoxHabilidades.ValueMember = "Nombre";
        }

        

        private void btnCargarClase_Click(object sender, EventArgs e)
        {
            Atributos modAtributos = new Atributos((int)selectFuerza.Value, (int)selectDestreza.Value, (int)selectDestreza.Value, (int)selectInteligencia.Value, (int)selectSabiduria.Value, (int)selectCarisma.Value);
            Clase nuevaClase = new Clase(txtNomClase.Text, modAtributos);
            listaClases.Add(nuevaClase);
            manejoClases.AgregarListaClases(listaClases);
            List<Habilidad> listaHabilidades = new List<Habilidad>();
            //checkedListBoxHabilidades.che
            //listaHabilidades = 
            //   (List<Habilidad>) checkedListBoxHabilidades.SelectedItems
            //MessageBox.Show("Clase agregada");
            this.Close();
        }

        private void InicializadorBoxClases()
        {
            listBoxClases.DataSource = manejoClases.DameListaComp();
            listBoxClases.DisplayMember = "Nombre";
            listBoxClases.ValueMember = "Nombre";
        }
    }
}
