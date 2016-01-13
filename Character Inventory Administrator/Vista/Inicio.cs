using System;
using System.Windows.Forms;
using Character_Inventory_Administrator.Clases;
using Character_Inventory_Administrator.Habilidades;
using Character_Inventory_Administrator.Inventario;
using Character_Inventory_Administrator.Items;
using Character_Inventory_Administrator.Personajes;
using Character_Inventory_Administrator.Razas;


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
            CrearPersonajeView vista = new CrearPersonajeView();
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

        private void btnVerInventario_Click(object sender, EventArgs e)
        {
            InventarioView verInventarioView = new InventarioView();
            verInventarioView.ShowDialog();
        }

        private void btnCrearItem_Click(object sender, EventArgs e)
        {
            CrearItemView creadorItemView = new CrearItemView();
            creadorItemView.ShowDialog();
        }


        
    }
}
