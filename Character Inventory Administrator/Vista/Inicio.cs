using System;
using System.Windows.Forms;
using Character_Inventory_Administrator.Controlador;
using Character_Inventory_Administrator.Modelo;
using Character_Inventory_Administrator.Vistas;

namespace Character_Inventory_Administrator.Vista
{
    public partial class Inicio : Form
    {
        public Inicio()
        {
            InitializeComponent();
        }

        private void Inicio_Load(object sender, EventArgs e)
        {

        }

        private void btnCrear_Click(object sender, EventArgs e)
        {
            PersonajeModel modelo = new PersonajeModel();
            PersonajesController controlador = new PersonajesController();
            CrearPersonajeView vista = new CrearPersonajeView();
            modelo.Vista = vista;
            vista.NuevoPersonajeModel = modelo;
            controlador.Modelo = modelo;
            vista.ShowDialog();
        }

        private void btnCrearRaza_Click(object sender, EventArgs e)
        {
            CrearRazaView creadorRazaView = new CrearRazaView();
            creadorRazaView.ShowDialog();
        }

        private void btnCrearClase_Click(object sender, EventArgs e)
        {
            CrearClaseView creadorClaseView = new CrearClaseView();
            creadorClaseView.ShowDialog();
        }

        private void btnCrearHabilidad_Click(object sender, EventArgs e)
        {
            CrearHabilidadView creadorHabilidadView = new CrearHabilidadView();
            creadorHabilidadView.ShowDialog();
        }
    }
}
