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
    public partial class Crear_Raza : Form
    {        
        List<Raza> listaRazas = new List<Raza>();
        CtrlRazas manejoRazas = new CtrlRazas();

        public Crear_Raza()
        {
            InitializeComponent();
            listaRazas = manejoRazas.DameListaComp();
            InicializarTablaRazas();
        }

        private void btnCargarRaza_Click(object sender, EventArgs e)
        {
            Atributos modAtributos = new Atributos((int)selectFuerza.Value, (int)selectDestreza.Value, (int)selectConstitucion.Value, (int)selectInteligencia.Value, (int)selectSabiduria.Value, (int)selectCarisma.Value);
            Raza nuevaRaza = new Raza(txtNomRaza.Text, modAtributos);
            listaRazas.Add(nuevaRaza);
            manejoRazas.AgregarListaRazas(listaRazas);
            MessageBox.Show("Raza agregada");
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
