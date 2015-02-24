using System;
using System.Collections.Generic;
using System.Windows.Forms;
using Character_Inventory_Administrator.Controlador;
using Character_Inventory_Administrator.Modelo;

namespace Character_Inventory_Administrator.Vista
{
    public partial class CrearHabilidadView : Form
    {
        List<HabilidadModel> _listaHabilidades = new List<HabilidadModel>();
        HabilidadesController _manejoHabilidadesController = new HabilidadesController();

        public CrearHabilidadView()
        {
            InitializeComponent();
            InicializarGridViewHabilidades();
        }

        private void btnCargarHabilidad_Click(object sender, EventArgs e)
        {
            HabilidadModel nuevaHabilidadModel = new HabilidadModel(txtNombreHabilidad.Text, selectorAtribPrincipal.Text, checkNormal.Checked); 
            _listaHabilidades.Add(nuevaHabilidadModel);
            _manejoHabilidadesController.AgregarListaHabilidades(_listaHabilidades);
            InicializarGridViewHabilidades();
            //Close();
        }
        
        private void InicializarGridViewHabilidades()
        {
            _listaHabilidades = _manejoHabilidadesController.DameListaComp();
            habilidadesSource.DataSource = _listaHabilidades;
            dataGridViewHabilidades.AutoGenerateColumns = false;
            nombreColumn.DataPropertyName = "Nombre";
            normalColumn.DataPropertyName = "Normal";
            atributoClaveColumn.DataPropertyName = "AtributoClave";
            dataGridViewHabilidades.DataSource = habilidadesSource;
        }
    }
}
