using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace Character_Inventory_Administrator.Habilidades
{
    public partial class CrearHabilidadView : Form
    {
        List<HabilidadModel> _listaHabilidades = new List<HabilidadModel>();

        public CrearHabilidadView()
        {
            InitializeComponent();
            _listaHabilidades= HabilidadModel.DameListaCompHabilidades();
            InicializarGridViewHabilidades();
        }

        private void btnCargarHabilidad_Click(object sender, EventArgs e)
        {
            HabilidadModel nuevaHabilidadModel = new HabilidadModel(txtNombreHabilidad.Text, selectorAtribPrincipal.Text, checkNormal.Checked); 
            _listaHabilidades.Add(nuevaHabilidadModel);
            HabilidadModel.AgregarListaHabilidades(_listaHabilidades);
            InicializarGridViewHabilidades();
            
        }
        
        private void InicializarGridViewHabilidades()
        {
            habilidadesSource.DataSource = HabilidadModel.DameListaCompHabilidades();
            dataGridViewHabilidades.AutoGenerateColumns = false;
            nombreColumn.DataPropertyName = "Nombre";
            normalColumn.DataPropertyName = "Normal";
            atributoClaveColumn.DataPropertyName = "AtributoClave";
            dataGridViewHabilidades.DataSource = habilidadesSource;
        }
    }
}
