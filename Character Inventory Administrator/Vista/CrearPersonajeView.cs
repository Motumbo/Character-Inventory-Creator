using System;
using System.Collections.Generic;
using System.Windows.Forms;
using Character_Inventory_Administrator.Modelo;

namespace Character_Inventory_Administrator.Vista
{
    public partial class CrearPersonajeView : Form
    {
        private readonly PersonajeModel _nuevoPersonajeModel = new PersonajeModel();

        private AtributosModel _atributosModelCreacion = new AtributosModel(_nuevoPersonajeModel);
        private RazaModel _razaModelCreacion = new RazaModel();
        private ClaseModel _claseModelCreacion = new ClaseModel();

        private readonly List<RazaModel> _listaRazas = new List<RazaModel>();
        private readonly List<ClaseModel> _listaClases = new List<ClaseModel>();
        private readonly List<HabilidadModel> _listaHabilidades = new List<HabilidadModel>();
        private List<HabilidadModel> _listaHabilidadesClase = new List<HabilidadModel>();

        public CrearPersonajeView()
        {
            InitializeComponent();
 
            _listaClases = ClaseModel.DameListaCompClases();
            _listaRazas = RazaModel.DameListaCompRazas();
            _listaHabilidades = HabilidadModel.DameListaCompHabilidades();

            _nuevoPersonajeModel.AtributosModel = _atributosModelCreacion;
            _nuevoPersonajeModel.RazaModel = _razaModelCreacion;
            _nuevoPersonajeModel.ClaseModel = _claseModelCreacion;

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
            txtTamaño.Text = _nuevoPersonajeModel.Tamaño();
            txtVelocidad.Text = Convert.ToString(_nuevoPersonajeModel.Velocidad());
            txtDadoVida.Text = Convert.ToString(_nuevoPersonajeModel.ClaseModel.DadoPuntosVida);
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
            _nuevoPersonajeModel.AtributosModel = _atributosModelCreacion;
        }
        private void SetValuesAtributeBoxes()
        {
            SetearAtributosSeleccionados();
            SetearModRaza();
            SetearModClase();
            SetearAtributosTotales();
            SetearModAtributos();
        }

        private void SetearModAtributos()
        {
            txtModFuerza.Text = _nuevoPersonajeModel.AtributosModel.ModFuerza().ToString();
            txtModDestreza.Text = _nuevoPersonajeModel.AtributosModel.ModDestreza().ToString();
            txtModConstitucion.Text = _nuevoPersonajeModel.AtributosModel.ModConstitucion().ToString();
            txtModInteligencia.Text = _nuevoPersonajeModel.AtributosModel.ModInteligencia().ToString();
            txtModSabiduria.Text = _nuevoPersonajeModel.AtributosModel.ModSabiduria().ToString();
            txtModCarisma.Text = _nuevoPersonajeModel.AtributosModel.ModCarisma().ToString();
        }
        private void SetearAtributosTotales()
        {
            txtTotalFuerza.Text = _nuevoPersonajeModel.AtributosModel.Fuerza().ToString();
            txtTotalDestreza.Text = _nuevoPersonajeModel.AtributosModel.Destreza().ToString();
            txtTotalConstitucion.Text = _nuevoPersonajeModel.AtributosModel.Constitucion().ToString();
            txtTotalInteligencia.Text = _nuevoPersonajeModel.AtributosModel.Inteligencia().ToString();
            txtTotalSabiduria.Text = _nuevoPersonajeModel.AtributosModel.Sabiduria().ToString();
            txtTotalCarisma.Text = _nuevoPersonajeModel.AtributosModel.Carisma().ToString();
        }
        private void SetearModRaza()
        {
            txtModRazaFuerza.Text = _razaModelCreacion.ModAtributos.Fuerza.ToString();
            txtModRazaDestreza.Text = _razaModelCreacion.ModAtributos.Destreza.ToString();
            txtModRazaConstitucion.Text = _razaModelCreacion.ModAtributos.Constitucion.ToString();
            txtModRazaInteligencia.Text = _razaModelCreacion.ModAtributos.Inteligencia.ToString();
            txtModRazaSabiduria.Text = _razaModelCreacion.ModAtributos.Sabiduria.ToString();
            txtModRazaCarisma.Text = _razaModelCreacion.ModAtributos.Carisma.ToString();
        }
        private void SetearModClase()
        {
            txtModClaseFuerza.Text = _claseModelCreacion.ModAtributos.Fuerza.ToString();
            txtModClaseDestreza.Text = _claseModelCreacion.ModAtributos.Destreza.ToString();
            txtModClaseConstitucion.Text = _claseModelCreacion.ModAtributos.Constitucion.ToString();
            txtModClaseInteligencia.Text = _claseModelCreacion.ModAtributos.Inteligencia.ToString();
            txtModClaseSabiduria.Text = _claseModelCreacion.ModAtributos.Sabiduria.ToString();
            txtModClaseCarisma.Text = _claseModelCreacion.ModAtributos.Carisma.ToString();
        }

        private void selectorRaza_SelectionChangeCommitted(object sender, EventArgs e)
        {
            _razaModelCreacion = RazaModel.BuscarPorNombre(selectorRaza.SelectedValue.ToString());
            _nuevoPersonajeModel.RazaModel = _razaModelCreacion;
            Crear_Personaje_Load(sender, e);
        }
        private void selectorClase_SelectionChangeCommitted(object sender, EventArgs e)
        {
            _claseModelCreacion = ClaseModel.BuscarPorNombre(selectorClase.SelectedValue.ToString());
            _nuevoPersonajeModel.ClaseModel = _claseModelCreacion;
            _listaHabilidadesClase = _claseModelCreacion.ListaHabilidadesClase;
            Crear_Personaje_Load(sender, e);
        }

        private void InicializarSelectorClases()
        {
            selectorClase.DataSource = _listaClases;
            selectorClase.DisplayMember = "Nombre";
            selectorClase.ValueMember = "Nombre";
            selectorClase.SelectedValue = "";
        }
        private void InicializarSelectorRazas()
        {
            selectorRaza.DataSource = _listaRazas;
            selectorRaza.DisplayMember = "Nombre";
            selectorRaza.ValueMember = "Nombre";
            selectorRaza.SelectedValue = "";
        }    
        private void EnlazaDataGridViewHabilidades()
        {
            habilidadesSource.DataSource = _listaHabilidades;
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
            _nuevoPersonajeModel.Nombre = txtNombre.Text;
            _nuevoPersonajeModel.Jugador = txtJugador.Text;
            _nuevoPersonajeModel.Piel = txtPiel.Text;
            _nuevoPersonajeModel.Pelo = txtPelo.Text;
            _nuevoPersonajeModel.Ojos = txtOjos.Text;

            _nuevoPersonajeModel.Sexo = selectorSexo.SelectedItem.ToString();
            _nuevoPersonajeModel.Altura = selectorAltura.Value.ToString();
            _nuevoPersonajeModel.Peso = selectorPeso.Value.ToString();
            _nuevoPersonajeModel.Edad = selectorEdad.Value.ToString();

            _nuevoPersonajeModel.Vida = (int)selectorVida.Value;
            _nuevoPersonajeModel.Nivel = (int)selectorLvl.Value;

            //ESTO SE SETEA CADA VEZ QUE CAMBIAS ALGO DE ESTOS
            //_nuevoPersonajeModel.AtributosModel = _atributosModelCreacion;
            //_nuevoPersonajeModel.RazaModel = _razaModelCreacion;
            //_nuevoPersonajeModel.ClaseModel = _claseModelCreacion;

            Close();
        }
    }
}
