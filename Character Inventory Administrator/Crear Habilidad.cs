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
    public partial class Crear_Habilidad : Form
    {
        List<Habilidad> listaHabilidades = new List<Habilidad>();
        CtrlHabilidades manejoHabilidades = new CtrlHabilidades();

        public Crear_Habilidad()
        {
            InitializeComponent();
            InicializarGridViewHabilidades();
        }

        private void btnCargarHabilidad_Click(object sender, EventArgs e)
        {
            Habilidad nuevaHabilidad = new Habilidad(txtNombreHabilidad.Text, selectorAtribPrincipal.Text);
            listaHabilidades.Add(nuevaHabilidad);
            manejoHabilidades.AgregarListaHabilidades(listaHabilidades);
            this.Close();
        }
        
        private void InicializarGridViewHabilidades()
        {
            listaHabilidades = manejoHabilidades.DameListaComp();
            habilidadesSource.DataSource = listaHabilidades;
            dataGridViewHabilidades.AutoGenerateColumns = false;
            DataGridViewTextBoxColumn nombreColumn = new DataGridViewTextBoxColumn();
            nombreColumn.DataPropertyName = "Nombre";
            nombreColumn.HeaderText = "Nombre";
            DataGridViewTextBoxColumn atributoClaveColumn = new DataGridViewTextBoxColumn();
            atributoClaveColumn.DataPropertyName = "AtributoClave";
            atributoClaveColumn.HeaderText = "Atributo Clave";
            dataGridViewHabilidades.Columns.Add(nombreColumn);
            dataGridViewHabilidades.Columns.Add(atributoClaveColumn);
            dataGridViewHabilidades.DataSource = habilidadesSource;
        }
    }
}
