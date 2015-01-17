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
    public partial class Crear_Personaje : Form
    {
        CtrlRazas manejoRazas = new CtrlRazas();
        CtrlClases manejoClases = new CtrlClases();
        CtrlHabilidades manejoHabilidades = new CtrlHabilidades();
        
        Atributos _atributosCreacion = new Atributos();
        Clase _claseCreacion = new Clase();
        Raza _razaCreacion = new Raza();

        List<Raza> listaRazas = new List<Raza>();
        List<Clase> listaClases = new List<Clase>();
        List<Habilidad> listaHabilidades = new List<Habilidad>();
        //List<Personaje> listaPersonajes = new List<Personaje>();
        
        
        
        

        public Crear_Personaje()
        {
            InitializeComponent();
            listaClases = manejoClases.DameListaComp();
            listaRazas = manejoRazas.DameListaComp();
            listaHabilidades = manejoHabilidades.DameListaComp();
            
            InicializarSelectorRazas();
            InicializarSelectorClases();

            InicializarModBoxValues();
            SetModBoxValues();
            
            EnlazaDataGridViewHabilidades();
            SetDataGridViewHabilidades();
        }

        private void Crear_Personaje_Load(object sender, EventArgs e)
        {
            SetearModClase();
            SetearModRaza();
            SetModBoxValues();
            SetDataGridViewHabilidades();
        }



        private void selectorRaza_SelectionChangeCommitted(object sender, EventArgs e)
        {
            _razaCreacion = manejoRazas.BuscarPorNombre(selectorRaza.SelectedValue.ToString());
            SetearModRaza();
            SetModBoxValues();
            SetDataGridViewHabilidades();
        }

        private void selectorClase_SelectionChangeCommitted(object sender, EventArgs e)
        {
            _claseCreacion = manejoClases.BuscarPorNombre(selectorClase.SelectedValue.ToString());
            listaHabilidades = _claseCreacion.ListaHabilidadesClase;
            SetearModClase();
            SetModBoxValues();
            EnlazaDataGridViewHabilidades();
            SetDataGridViewHabilidades();
        }

        private void btnContCreacion_Click(object sender, EventArgs e)
        {
            Personaje nuevoCharacter = new Personaje();

            nuevoCharacter.Nombre = txtNombre.Text;
            nuevoCharacter.Jugador = txtJugador.Text;
            nuevoCharacter.Piel = txtPiel.Text;
            nuevoCharacter.Pelo = txtPelo.Text;
            nuevoCharacter.Ojos = txtOjos.Text;

            nuevoCharacter.Sexo = selectorSexo.SelectedValue.ToString();    
            nuevoCharacter.Altura = selectorAltura.Value.ToString();
            nuevoCharacter.Peso = selectorPeso.Value.ToString();
            nuevoCharacter.Edad = selectorEdad.Value.ToString();

            nuevoCharacter.Vida = (int)selectorVida.Value;
            nuevoCharacter.Nivel = (int)selectorLvl.Value;

            _atributosCreacion = new Atributos(
                Convert.ToInt16(txtTotalFuerza.Text),   
                Convert.ToInt16(txtTotalDestreza.Text),
                Convert.ToInt16(txtTotalConstitucion.Text),
                Convert.ToInt16(txtTotalInteligencia.Text),
                Convert.ToInt16(txtTotalSabiduria.Text),
                Convert.ToInt16(txtTotalCarisma.Text));

            nuevoCharacter.Atributos = _atributosCreacion;
            nuevoCharacter.Raza = _razaCreacion;
            nuevoCharacter.Clase = _claseCreacion;

            ma

            this.Close();
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
        private void SetearModRaza()
        {
            txtModRazaFuerza.Text = _razaCreacion.ModAtributos.Fuerza.ToString();
            txtModRazaDestreza.Text = _razaCreacion.ModAtributos.Destreza.ToString();
            txtModRazaConstitucion.Text = _razaCreacion.ModAtributos.Constitucion.ToString();
            txtModRazaInteligencia.Text = _razaCreacion.ModAtributos.Inteligencia.ToString();
            txtModRazaSabiduria.Text = _razaCreacion.ModAtributos.Sabiduria.ToString();
            txtModRazaCarisma.Text = _razaCreacion.ModAtributos.Carisma.ToString();
        }
        private void SetearModClase()
        {
            txtModClaseFuerza.Text = _claseCreacion.ModAtributos.Fuerza.ToString();
            txtModClaseDestreza.Text = _claseCreacion.ModAtributos.Destreza.ToString();
            txtModClaseConstitucion.Text = _claseCreacion.ModAtributos.Constitucion.ToString();
            txtModClaseInteligencia.Text = _claseCreacion.ModAtributos.Inteligencia.ToString();
            txtModClaseSabiduria.Text = _claseCreacion.ModAtributos.Sabiduria.ToString();
            txtModClaseCarisma.Text = _claseCreacion.ModAtributos.Carisma.ToString();
        }
        private void EnlazaDataGridViewHabilidades()
        {
            habilidadesSource.DataSource = listaHabilidades;
            nombreColumn.DataPropertyName = "Nombre";
            atributoClaveColumn.DataPropertyName = "AtributoClave";
            rangosColumn.DataPropertyName = "Rangos";
            dataGridViewHabilidades.DataSource = habilidadesSource;
        }
        private void SetDataGridViewHabilidades()
        {
            foreach (DataGridViewRow row in dataGridViewHabilidades.Rows)
            {
                switch (row.Cells[atributoClaveColumn.Name].Value.ToString())
                {
                    case "Fuerza":
                        row.Cells[modClaveColumn.Name].Value = txtModFuerza.Text;
                        break;
                    case "Destreza":
                        row.Cells[modClaveColumn.Name].Value = txtModDestreza.Text;
                        break;
                    case "Constitucion":
                        row.Cells[modClaveColumn.Name].Value = txtModConstitucion.Text;
                        break;
                    case "Inteligencia":
                        row.Cells[modClaveColumn.Name].Value = txtModInteligencia.Text;
                        break;
                    case "Sabiduria":
                        row.Cells[modClaveColumn.Name].Value = txtModSabiduria.Text;
                        break;
                    case "Carisma":
                        row.Cells[modClaveColumn.Name].Value = txtModCarisma.Text;
                        break;
                }
            }
        }

        private void InicializarModBoxValues()
        {
            txtModRazaFuerza.Text = "0";
            txtModRazaDestreza.Text = "0";
            txtModRazaConstitucion.Text = "0";
            txtModRazaInteligencia.Text = "0";
            txtModRazaSabiduria.Text = "0";
            txtModRazaCarisma.Text = "0";

            txtModClaseFuerza.Text = "0";
            txtModClaseDestreza.Text = "0";
            txtModClaseConstitucion.Text = "0";
            txtModClaseInteligencia.Text = "0";
            txtModClaseSabiduria.Text = "0";
            txtModClaseCarisma.Text = "0";

            txtTotalFuerza.Text = "0";
            txtTotalDestreza.Text = "0";
            txtTotalConstitucion.Text = "0";
            txtTotalInteligencia.Text = "0";
            txtTotalSabiduria.Text = "0";
            txtTotalCarisma.Text = "0";

            txtModFuerza.Text = "0";
            txtModDestreza.Text = "0";
            txtModConstitucion.Text = "0";
            txtModInteligencia.Text = "0";
            txtModSabiduria.Text = "0";
            txtModCarisma.Text = "0";
        }

        private void SetModBoxValues()
        {
            txtTotalFuerza.Text = Convert.ToString(Convert.ToInt16(txtModClaseFuerza.Text) + Convert.ToInt16(txtModRazaFuerza.Text) + selectFuerza.Value);
            txtTotalDestreza.Text = Convert.ToString(Convert.ToInt16(txtModClaseDestreza.Text) + Convert.ToInt16(txtModRazaDestreza.Text) + selectDestreza.Value);
            txtTotalConstitucion.Text = Convert.ToString(Convert.ToInt16(txtModClaseConstitucion.Text) + Convert.ToInt16(txtModRazaConstitucion.Text) + selectConstitucion.Value);
            txtTotalInteligencia.Text = Convert.ToString(Convert.ToInt16(txtModClaseInteligencia.Text) + Convert.ToInt16(txtModRazaInteligencia.Text) + selectInteligencia.Value);
            txtTotalSabiduria.Text = Convert.ToString(Convert.ToInt16(txtModClaseSabiduria.Text) + Convert.ToInt16(txtModRazaSabiduria.Text) + selectSabiduria.Value);
            txtTotalCarisma.Text = Convert.ToString(Convert.ToInt16(txtModClaseCarisma.Text) + Convert.ToInt16(txtModRazaCarisma.Text) + selectCarisma.Value);
            //Modificador mas usado y util, txtMod..
            txtModFuerza.Text = Convert.ToString((int)(((Convert.ToInt16(txtTotalFuerza.Text)) - 10) / 2));
            txtModDestreza.Text = Convert.ToString((int)(((Convert.ToInt16(txtTotalDestreza.Text)) - 10) / 2));
            txtModConstitucion.Text = Convert.ToString((int)(((Convert.ToInt16(txtTotalConstitucion.Text)) - 10) / 2));
            txtModInteligencia.Text = Convert.ToString((int)(((Convert.ToInt16(txtTotalInteligencia.Text)) - 10) / 2));
            txtModSabiduria.Text = Convert.ToString((int)(((Convert.ToInt16(txtTotalSabiduria.Text)) - 10) / 2));
            txtModCarisma.Text = Convert.ToString((int)(((Convert.ToInt16(txtTotalCarisma.Text)) - 10) / 2));

        }

    }
}
