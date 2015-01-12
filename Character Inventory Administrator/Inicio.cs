using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Control;
using Dao;
using Modelos;

namespace Character_Inventory_Administrator
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
            Crear_Personaje creador = new Crear_Personaje();
            creador.ShowDialog();
        }

        private void btnCrearRaza_Click(object sender, EventArgs e)
        {
            Crear_Raza creadorRaza = new Crear_Raza();
            creadorRaza.ShowDialog();
        }

        private void btnCrearClase_Click(object sender, EventArgs e)
        {
            Crear_Clase creadorClase = new Crear_Clase();
            creadorClase.ShowDialog();
        }

        private void btnCrearHabilidad_Click(object sender, EventArgs e)
        {
            Crear_Habilidad creadorHabilidad = new Crear_Habilidad();
            creadorHabilidad.ShowDialog();
        }
    }
}
