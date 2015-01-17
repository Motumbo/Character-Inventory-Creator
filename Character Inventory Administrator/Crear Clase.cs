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
        List<Habilidad> listaTodasHabilidades = new List<Habilidad>();
        CtrlClases manejoClases = new CtrlClases();
        CtrlHabilidades manejoHabilidades = new CtrlHabilidades();

        public Crear_Clase()
        {
            InitializeComponent();
            listaClases = manejoClases.DameListaComp();
            InicializadorBoxClases();
            InicializarGridViewHabilidades();
        }

        

        private void btnCargarClase_Click(object sender, EventArgs e)
        {
            Atributos modAtributos = new Atributos((int)selectFuerza.Value, (int)selectDestreza.Value, (int)selectDestreza.Value, (int)selectInteligencia.Value, (int)selectSabiduria.Value, (int)selectCarisma.Value);
            
            List<Habilidad> listaHabilidadesClase = new List<Habilidad>();
            foreach (DataGridViewRow row in dataGridViewHabilidades.Rows)
            {
                
                if ((row.Cells[0].Value) != null)
                {
                    listaHabilidadesClase.Add(manejoHabilidades.BuscarPorNombre(row.Cells[nombreColumn.Name].Value.ToString()));
                }
            }
            

            Clase nuevaClase = new Clase(txtNomClase.Text, modAtributos, listaHabilidadesClase);

            listaClases.Add(nuevaClase);
            manejoClases.AgregarListaClases(listaClases);
            MessageBox.Show("Clase agregada");
            this.Close();
        }

        private void InicializadorBoxClases()
        {
            listBoxClases.DataSource = manejoClases.DameListaComp();
            listBoxClases.DisplayMember = "Nombre";
            listBoxClases.ValueMember = "Nombre";
        }

        private void InicializarGridViewHabilidades()
        {
            listaTodasHabilidades = manejoHabilidades.DameListaComp();
            habilidadesSource.DataSource = listaTodasHabilidades;
            dataGridViewHabilidades.AutoGenerateColumns = false;
            //DataGridViewTextBoxColumn nombreColumn = new DataGridViewTextBoxColumn();
            nombreColumn.DataPropertyName = "Nombre";
            //nombreColumn.HeaderText = "Nombre";
            //DataGridViewTextBoxColumn atributoClaveColumn = new DataGridViewTextBoxColumn();
            atributoClaveColumn.DataPropertyName = "AtributoClave";
            //atributoClaveColumn.HeaderText = "Atributo Clave";
            //Pertenece.TrueValue = true;
            //Pertenece.FalseValue = false;
            //dataGridViewHabilidades.Columns.Add(nombreColumn);
            //dataGridViewHabilidades.Columns.Add(atributoClaveColumn);
            dataGridViewHabilidades.DataSource = habilidadesSource;
        }
    }
}
