using System;
using System.Collections.Generic;
using System.Windows.Forms;
using Character_Inventory_Administrator.Habilidades;
using Character_Inventory_Administrator.Personajes.Atributos;

namespace Character_Inventory_Administrator.Clases
{
    public partial class CrearClaseView : Form
    {
        List<ClaseModel> listaClases = new List<ClaseModel>();
        List<HabilidadModel> _listaTodasHabilidades = new List<HabilidadModel>();
        
        public CrearClaseView()
        {
            InitializeComponent();
            listaClases = ClaseModel.DameListaCompClases();
            InicializadorBoxClases();
            InicializarGridViewHabilidades();
        }

        private void btnCargarClase_Click(object sender, EventArgs e)
        {
            AtributosModel modAtributosModel = new AtributosModel((int)selectFuerza.Value, (int)selectDestreza.Value, (int)selectDestreza.Value, (int)selectInteligencia.Value, (int)selectSabiduria.Value, (int)selectCarisma.Value);
            
            List<HabilidadModel> listaHabilidadesClase = new List<HabilidadModel>();
            foreach (DataGridViewRow row in dataGridViewHabilidades.Rows)
            {
                if ((row.Cells[0].Value) != null)
                {
                    HabilidadModel habilidad = HabilidadModel.BuscarPorNombre(row.Cells[nombreColumn.Name].Value.ToString());
                    habilidad.DeClase = true;
                    listaHabilidadesClase.Add(habilidad);
                }
            }
            ClaseModel nuevaClaseModel = new ClaseModel(txtNomClase.Text, modAtributosModel, (int)selectorTipoDadoVida.Value,(int)selectorVelocidad.Value, listaHabilidadesClase);
            listaClases.Add(nuevaClaseModel);
            ClaseModel.AgregarListaClases(listaClases);
            MessageBox.Show(@"Clase agregada");
            Close();
        }

        private void InicializadorBoxClases()
        {
            listBoxClases.DataSource = ClaseModel.DameListaCompClases();
            listBoxClases.DisplayMember = "Nombre";
            listBoxClases.ValueMember = "Nombre";
        }

        private void InicializarGridViewHabilidades()
        {
            _listaTodasHabilidades = HabilidadModel.DameListaCompHabilidades();
            habilidadesSource.DataSource = _listaTodasHabilidades;
            dataGridViewHabilidades.AutoGenerateColumns = false;
            nombreColumn.DataPropertyName = "Nombre";
            normalColumn.DataPropertyName = "Normal";
            atributoClaveColumn.DataPropertyName = "AtributoClave";
            dataGridViewHabilidades.DataSource = habilidadesSource;
        }
    }
}
