using System;
using System.Collections.Generic;
using System.Windows.Forms;
using Character_Inventory_Administrator.Controlador;
using Character_Inventory_Administrator.Modelo;

namespace Character_Inventory_Administrator.Vista
{
    public partial class CrearPersonajeView : Form
    {
        private PersonajeModel _personajeModelModel;
        private PersonajesController _personajeController;

        private RazasController _razaController = new RazasController();
        private ClasesController _claseController = new ClasesController();
        private HabilidadesController _habilidadesController = new HabilidadesController();

        private AtributosModel _atributosModelCreacion = new AtributosModel();
        private RazaModel _razaModelCreacion = new RazaModel();
        private ClaseModel _claseModelCreacion = new ClaseModel();

        private List<RazaModel> listaRazas = new List<RazaModel>();
        private List<ClaseModel> listaClases = new List<ClaseModel>();
        private List<HabilidadModel> listaHabilidades = new List<HabilidadModel>();
        private List<HabilidadModel> _listaHabilidadesClase = new List<HabilidadModel>();

        //List<PersonajeModel> listaPersonajes = new List<PersonajeModel>();
        
        public PersonajesController PersonajeController
        {
            get { return _personajeController; }
            set { _personajeController = value; }
        }

        public PersonajeModel NuevoPersonajeModel
        {
            get { return _personajeModelModel; }
            set { _personajeModelModel = value; }
        }


        public CrearPersonajeView()
        {
            InitializeComponent();
            NuevoPersonajeModel = new PersonajeModel();
            listaClases = _claseController.DameListaComp();
            listaRazas = _razaController.DameListaComp();
            listaHabilidades = _habilidadesController.DameListaComp();
            _listaHabilidadesClase = new List<HabilidadModel>();
            
            InicializarSelectorRazas();
            InicializarSelectorClases();
            
            SetValuesAtributeBoxes();
            
            EnlazaDataGridViewHabilidades();
            SetDataGridViewHabilidades();
        }     

        private void Crear_Personaje_Load(object sender, EventArgs e)
        {
            SetValuesAtributeBoxes();
            SetDataGridViewHabilidades();
        }
        private void SetearAtributosSeleccionados()
        {
            _atributosModelCreacion = new AtributosModel(
                Convert.ToInt16(selectFuerza.Value),
                Convert.ToInt16(selectDestreza.Value),
                Convert.ToInt16(selectConstitucion.Value),
                Convert.ToInt16(selectInteligencia.Value),
                Convert.ToInt16(selectSabiduria.Value),
                Convert.ToInt16(selectCarisma.Value));
            NuevoPersonajeModel.AtributosModel = _atributosModelCreacion;
        }
        private void SetValuesAtributeBoxes()
        {
            SetearModRaza();
            SetearModClase();
            SetearAtributosSeleccionados();
            SetearAtributosTotales();
            SetearModAtributos();
        }

        private void SetearModAtributos()
        {
            txtModFuerza.Text = NuevoPersonajeModel.ModFuerza().ToString();
            txtModDestreza.Text = NuevoPersonajeModel.ModDestreza().ToString();
            txtModConstitucion.Text = NuevoPersonajeModel.ModConstitucion().ToString();
            txtModInteligencia.Text = NuevoPersonajeModel.ModInteligencia().ToString();
            txtModSabiduria.Text = NuevoPersonajeModel.ModSabiduria().ToString();
            txtModCarisma.Text = NuevoPersonajeModel.ModCarisma().ToString();
        }
        private void SetearAtributosTotales()
        {
            txtTotalFuerza.Text = NuevoPersonajeModel.Fuerza().ToString();
            txtTotalDestreza.Text = NuevoPersonajeModel.Destraza().ToString();
            txtTotalConstitucion.Text = NuevoPersonajeModel.Constitucion().ToString();
            txtTotalInteligencia.Text = NuevoPersonajeModel.Inteligencia().ToString();
            txtTotalSabiduria.Text = NuevoPersonajeModel.Sabiduria().ToString();
            txtTotalCarisma.Text = NuevoPersonajeModel.Carisma().ToString();
        }
        private void SetearModRaza()
        {
            txtModRazaFuerza.Text = _razaModelCreacion.ModAtributosModel.Fuerza.ToString();
            txtModRazaDestreza.Text = _razaModelCreacion.ModAtributosModel.Destreza.ToString();
            txtModRazaConstitucion.Text = _razaModelCreacion.ModAtributosModel.Constitucion.ToString();
            txtModRazaInteligencia.Text = _razaModelCreacion.ModAtributosModel.Inteligencia.ToString();
            txtModRazaSabiduria.Text = _razaModelCreacion.ModAtributosModel.Sabiduria.ToString();
            txtModRazaCarisma.Text = _razaModelCreacion.ModAtributosModel.Carisma.ToString();
        }
        private void SetearModClase()
        {
            txtModClaseFuerza.Text = _claseModelCreacion.ModAtributosModel.Fuerza.ToString();
            txtModClaseDestreza.Text = _claseModelCreacion.ModAtributosModel.Destreza.ToString();
            txtModClaseConstitucion.Text = _claseModelCreacion.ModAtributosModel.Constitucion.ToString();
            txtModClaseInteligencia.Text = _claseModelCreacion.ModAtributosModel.Inteligencia.ToString();
            txtModClaseSabiduria.Text = _claseModelCreacion.ModAtributosModel.Sabiduria.ToString();
            txtModClaseCarisma.Text = _claseModelCreacion.ModAtributosModel.Carisma.ToString();
        }

        private void selectorRaza_SelectionChangeCommitted(object sender, EventArgs e)
        {
            _razaModelCreacion = _razaController.BuscarPorNombre(selectorRaza.SelectedValue.ToString());
            NuevoPersonajeModel.RazaModel = _razaModelCreacion;
            SetValuesAtributeBoxes();
            SetDataGridViewHabilidades();
        }
        private void selectorClase_SelectionChangeCommitted(object sender, EventArgs e)
        {
            _claseModelCreacion = _claseController.BuscarPorNombre(selectorClase.SelectedValue.ToString());
            NuevoPersonajeModel.ClaseModel = _claseModelCreacion;
            _listaHabilidadesClase = _claseModelCreacion.ListaHabilidadesClase;
            SetValuesAtributeBoxes();
            SetDataGridViewHabilidades();
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
        private void EnlazaDataGridViewHabilidades()
        {
            habilidadesSource.DataSource = listaHabilidades;
            deClaseColumn.DataPropertyName = "DeClase";
            nombreColumn.DataPropertyName = "Nombre";
            normalColumn.DataPropertyName = "Normal";
            atributoClaveColumn.DataPropertyName = "AtributoClave";
            rangosColumn.DataPropertyName = "Rangos";

            dataGridViewHabilidades.DataSource = habilidadesSource;
        }

        private void SetDataGridViewHabilidades()
        {
            foreach (DataGridViewRow row in dataGridViewHabilidades.Rows)
            {
               foreach (HabilidadModel habilidad in _listaHabilidadesClase) // Con esto marco las habilidades que son propias de clase
                {
                    if (habilidad.Nombre == row.Cells[nombreColumn.Name].Value.ToString())
                    {
                        row.Cells[deClaseColumn.Name].Value = true;
                    }
                }
                
                switch (row.Cells[atributoClaveColumn.Name].Value.ToString())
                {
                    case "Fuerza":
                        row.Cells[modClaveColumn.Name].Value = txtModFuerza.Text;
                        row.Cells[totalColumn.Name].Value =
                            Convert.ToString(Convert.ToInt32(row.Cells[rangosColumn.Name].Value) +
                            Convert.ToInt32(row.Cells[modClaveColumn.Name].Value) +
                            Convert.ToInt32(row.Cells[modOtrosColumn.Name].Value));
                        break;
                    case "Destreza":
                        row.Cells[modClaveColumn.Name].Value = txtModDestreza.Text;
                        row.Cells[totalColumn.Name].Value =
                            Convert.ToString(Convert.ToInt32(row.Cells[rangosColumn.Name].Value) +
                            Convert.ToInt32(row.Cells[modClaveColumn.Name].Value) +
                            Convert.ToInt32(row.Cells[modOtrosColumn.Name].Value));
                        break;
                    case "Constitucion":
                        row.Cells[modClaveColumn.Name].Value = txtModConstitucion.Text;
                        row.Cells[totalColumn.Name].Value =
                            Convert.ToString(Convert.ToInt32(row.Cells[rangosColumn.Name].Value) +
                            Convert.ToInt32(row.Cells[modClaveColumn.Name].Value) +
                            Convert.ToInt32(row.Cells[modOtrosColumn.Name].Value));
                        break;
                    case "Inteligencia":
                        row.Cells[modClaveColumn.Name].Value = txtModInteligencia.Text;
                        row.Cells[totalColumn.Name].Value =
                            Convert.ToString(Convert.ToInt32(row.Cells[rangosColumn.Name].Value) +
                            Convert.ToInt32(row.Cells[modClaveColumn.Name].Value) +
                            Convert.ToInt32(row.Cells[modOtrosColumn.Name].Value));
                        break;
                    case "Sabiduria":
                        row.Cells[modClaveColumn.Name].Value = txtModSabiduria.Text;
                        row.Cells[totalColumn.Name].Value =
                            Convert.ToString(Convert.ToInt32(row.Cells[rangosColumn.Name].Value) +
                            Convert.ToInt32(row.Cells[modClaveColumn.Name].Value) +
                            Convert.ToInt32(row.Cells[modOtrosColumn.Name].Value));
                        break;
                    case "Carisma":
                        row.Cells[modClaveColumn.Name].Value = txtModCarisma.Text;
                        row.Cells[totalColumn.Name].Value =
                            Convert.ToString(Convert.ToInt32(row.Cells[rangosColumn.Name].Value) +
                            Convert.ToInt32(row.Cells[modClaveColumn.Name].Value) +
                            Convert.ToInt32(row.Cells[modOtrosColumn.Name].Value));
                        break;
                }
            }
        }

        private void btnContCreacion_Click(object sender, EventArgs e)
        {
            NuevoPersonajeModel.Nombre = txtNombre.Text;
            NuevoPersonajeModel.Jugador = txtJugador.Text;
            NuevoPersonajeModel.Piel = txtPiel.Text;
            NuevoPersonajeModel.Pelo = txtPelo.Text;
            NuevoPersonajeModel.Ojos = txtOjos.Text;

            NuevoPersonajeModel.Sexo = selectorSexo.SelectedItem.ToString();
            NuevoPersonajeModel.Altura = selectorAltura.Value.ToString();
            NuevoPersonajeModel.Peso = selectorPeso.Value.ToString();
            NuevoPersonajeModel.Edad = selectorEdad.Value.ToString();

            NuevoPersonajeModel.Vida = (int)selectorVida.Value;
            NuevoPersonajeModel.Nivel = (int)selectorLvl.Value;

            NuevoPersonajeModel.AtributosModel = _atributosModelCreacion;
            NuevoPersonajeModel.RazaModel = _razaModelCreacion;
            NuevoPersonajeModel.ClaseModel = _claseModelCreacion;

            this.Close();
        }
    }
}
