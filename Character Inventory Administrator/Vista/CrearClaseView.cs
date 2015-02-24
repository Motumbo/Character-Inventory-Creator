using System;
using System.Collections.Generic;
using System.Windows.Forms;
using Character_Inventory_Administrator.Controlador;
using Character_Inventory_Administrator.Modelo;

namespace Character_Inventory_Administrator.Vista
{
    public partial class CrearClaseView : Form
    {
        List<ClaseModel> listaClases = new List<ClaseModel>();
        List<HabilidadModel> _listaTodasHabilidades = new List<HabilidadModel>();
        ClasesController _manejoClasesController = new ClasesController();
        HabilidadesController _manejoHabilidadesController = new HabilidadesController();

        public CrearClaseView()
        {
            InitializeComponent();
            listaClases = _manejoClasesController.DameListaComp();
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
                    HabilidadModel habilidad = new HabilidadModel();
                    habilidad = _manejoHabilidadesController.BuscarPorNombre(row.Cells[nombreColumn.Name].Value.ToString());
                    habilidad.DeClase = true;
                    listaHabilidadesClase.Add(habilidad);
                }
            }

            ClaseModel nuevaClaseModel = new ClaseModel(txtNomClase.Text, modAtributosModel, listaHabilidadesClase);
            listaClases.Add(nuevaClaseModel);
            _manejoClasesController.AgregarListaClases(listaClases);
            MessageBox.Show(@"Clase agregada");
            Close();
        }

        private void InicializadorBoxClases()
        {
            listBoxClases.DataSource = _manejoClasesController.DameListaComp();
            listBoxClases.DisplayMember = "Nombre";
            listBoxClases.ValueMember = "Nombre";
        }

        private void InicializarGridViewHabilidades()
        {
            _listaTodasHabilidades = _manejoHabilidadesController.DameListaComp();
            habilidadesSource.DataSource = _listaTodasHabilidades;
            dataGridViewHabilidades.AutoGenerateColumns = false;
            nombreColumn.DataPropertyName = "Nombre";
            normalColumn.DataPropertyName = "Normal";
            atributoClaveColumn.DataPropertyName = "AtributoClave";
            dataGridViewHabilidades.DataSource = habilidadesSource;
        }
    }
}
