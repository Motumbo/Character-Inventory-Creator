using System;
using System.Collections.Generic;
using System.Windows.Forms;
using Character_Inventory_Administrator.Controlador;
using Character_Inventory_Administrator.Modelo;

namespace Character_Inventory_Administrator.Vista
{
    public partial class CrearHabilidadView : Form
    {
        List<HabilidadModel> listaHabilidades = new List<HabilidadModel>();
        HabilidadesController _manejoHabilidadesController = new HabilidadesController();

        public CrearHabilidadView()
        {
            InitializeComponent();
            InicializarGridViewHabilidades();
        }

        private void btnCargarHabilidad_Click(object sender, EventArgs e)
        {
            HabilidadModel nuevaHabilidadModel = new HabilidadModel(txtNombreHabilidad.Text, selectorAtribPrincipal.Text);
            listaHabilidades.Add(nuevaHabilidadModel);
            _manejoHabilidadesController.AgregarListaHabilidades(listaHabilidades);
            this.Close();
        }
        
        private void InicializarGridViewHabilidades()
        {
            listaHabilidades = _manejoHabilidadesController.DameListaComp();
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
