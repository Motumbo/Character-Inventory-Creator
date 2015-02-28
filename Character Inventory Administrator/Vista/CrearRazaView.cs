using System;
using System.Collections.Generic;
using System.Windows.Forms;
using Character_Inventory_Administrator.Modelo;

namespace Character_Inventory_Administrator.Vista
{
    public partial class CrearRazaView : Form
    {        
        List<RazaModel> listaRazas = new List<RazaModel>();

        public CrearRazaView()
        {
            InitializeComponent();
            listaRazas = RazaModel.DameListaCompRazas();
            InicializarTablaRazas();
        }

        private void btnCargarRaza_Click(object sender, EventArgs e)
        {
            AtributosModel modAtributosModel = new AtributosModel((int)selectFuerza.Value, (int)selectDestreza.Value, (int)selectConstitucion.Value, (int)selectInteligencia.Value, (int)selectSabiduria.Value, (int)selectCarisma.Value);
            RazaModel nuevaRazaModel = new RazaModel(txtNomRaza.Text, modAtributosModel, selectorTamaño.SelectedItem.ToString(), (int)selectorVelocidad.Value);
            listaRazas.Add(nuevaRazaModel);
            RazaModel.AgregarListaRazas(listaRazas);
            MessageBox.Show(@"Raza agregada");
            this.Close();
        }
        
        private void InicializarTablaRazas()
        {
            listBoxRazas.DataSource = listaRazas;
            listBoxRazas.DisplayMember = "Nombre";
            listBoxRazas.ValueMember = "Nombre";
        }
    }
}
