using System;
using System.Collections.Generic;
using System.Windows.Forms;
using Character_Inventory_Administrator.Controlador;
using Character_Inventory_Administrator.Modelo;

namespace Character_Inventory_Administrator.Vista
{
    public partial class CrearRazaView : Form
    {        
        List<RazaModel> listaRazas = new List<RazaModel>();
        RazasController _manejoRazasController = new RazasController();

        public CrearRazaView()
        {
            InitializeComponent();
            listaRazas = _manejoRazasController.DameListaComp();
            InicializarTablaRazas();
        }

        private void btnCargarRaza_Click(object sender, EventArgs e)
        {
            AtributosModel modAtributosModel = new AtributosModel((int)selectFuerza.Value, (int)selectDestreza.Value, (int)selectConstitucion.Value, (int)selectInteligencia.Value, (int)selectSabiduria.Value, (int)selectCarisma.Value);
            RazaModel nuevaRazaModel = new RazaModel(txtNomRaza.Text, modAtributosModel);
            listaRazas.Add(nuevaRazaModel);
            _manejoRazasController.AgregarListaRazas(listaRazas);
            MessageBox.Show("RazaModel agregada");
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
