namespace Character_Inventory_Administrator.Vista
{
    partial class CrearRazaView
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.btnCargarRaza = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.txtNomRaza = new System.Windows.Forms.TextBox();
            this.selectFuerza = new System.Windows.Forms.NumericUpDown();
            this.selectCarisma = new System.Windows.Forms.NumericUpDown();
            this.selectSabiduria = new System.Windows.Forms.NumericUpDown();
            this.selectInteligencia = new System.Windows.Forms.NumericUpDown();
            this.selectDestreza = new System.Windows.Forms.NumericUpDown();
            this.selectConstitucion = new System.Windows.Forms.NumericUpDown();
            this.label19 = new System.Windows.Forms.Label();
            this.label18 = new System.Windows.Forms.Label();
            this.label17 = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.listBoxRazas = new System.Windows.Forms.ListBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.selectorTamaño = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.selectorVelocidad = new System.Windows.Forms.NumericUpDown();
            ((System.ComponentModel.ISupportInitialize)(this.selectFuerza)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.selectCarisma)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.selectSabiduria)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.selectInteligencia)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.selectDestreza)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.selectConstitucion)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.selectorVelocidad)).BeginInit();
            this.SuspendLayout();
            // 
            // btnCargarRaza
            // 
            this.btnCargarRaza.Location = new System.Drawing.Point(260, 227);
            this.btnCargarRaza.Name = "btnCargarRaza";
            this.btnCargarRaza.Size = new System.Drawing.Size(96, 23);
            this.btnCargarRaza.TabIndex = 0;
            this.btnCargarRaza.Text = "Guardar RazaModel";
            this.btnCargarRaza.UseVisualStyleBackColor = true;
            this.btnCargarRaza.Click += new System.EventHandler(this.btnCargarRaza_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(11, 27);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(72, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Nombre Raza";
            // 
            // txtNomRaza
            // 
            this.txtNomRaza.Location = new System.Drawing.Point(83, 24);
            this.txtNomRaza.Name = "txtNomRaza";
            this.txtNomRaza.Size = new System.Drawing.Size(100, 20);
            this.txtNomRaza.TabIndex = 2;
            // 
            // selectFuerza
            // 
            this.selectFuerza.Location = new System.Drawing.Point(86, 15);
            this.selectFuerza.Minimum = new decimal(new int[] {
            10,
            0,
            0,
            -2147483648});
            this.selectFuerza.Name = "selectFuerza";
            this.selectFuerza.Size = new System.Drawing.Size(39, 20);
            this.selectFuerza.TabIndex = 58;
            this.selectFuerza.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // selectCarisma
            // 
            this.selectCarisma.Location = new System.Drawing.Point(86, 125);
            this.selectCarisma.Minimum = new decimal(new int[] {
            10,
            0,
            0,
            -2147483648});
            this.selectCarisma.Name = "selectCarisma";
            this.selectCarisma.Size = new System.Drawing.Size(39, 20);
            this.selectCarisma.TabIndex = 57;
            this.selectCarisma.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // selectSabiduria
            // 
            this.selectSabiduria.Location = new System.Drawing.Point(86, 103);
            this.selectSabiduria.Minimum = new decimal(new int[] {
            10,
            0,
            0,
            -2147483648});
            this.selectSabiduria.Name = "selectSabiduria";
            this.selectSabiduria.Size = new System.Drawing.Size(39, 20);
            this.selectSabiduria.TabIndex = 56;
            this.selectSabiduria.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // selectInteligencia
            // 
            this.selectInteligencia.Location = new System.Drawing.Point(86, 81);
            this.selectInteligencia.Minimum = new decimal(new int[] {
            10,
            0,
            0,
            -2147483648});
            this.selectInteligencia.Name = "selectInteligencia";
            this.selectInteligencia.Size = new System.Drawing.Size(39, 20);
            this.selectInteligencia.TabIndex = 55;
            this.selectInteligencia.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // selectDestreza
            // 
            this.selectDestreza.Location = new System.Drawing.Point(86, 37);
            this.selectDestreza.Minimum = new decimal(new int[] {
            10,
            0,
            0,
            -2147483648});
            this.selectDestreza.Name = "selectDestreza";
            this.selectDestreza.Size = new System.Drawing.Size(39, 20);
            this.selectDestreza.TabIndex = 54;
            this.selectDestreza.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // selectConstitucion
            // 
            this.selectConstitucion.Location = new System.Drawing.Point(86, 59);
            this.selectConstitucion.Minimum = new decimal(new int[] {
            10,
            0,
            0,
            -2147483648});
            this.selectConstitucion.Name = "selectConstitucion";
            this.selectConstitucion.Size = new System.Drawing.Size(39, 20);
            this.selectConstitucion.TabIndex = 53;
            this.selectConstitucion.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.Location = new System.Drawing.Point(15, 127);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(44, 13);
            this.label19.TabIndex = 52;
            this.label19.Text = "Carisma";
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Location = new System.Drawing.Point(15, 105);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(51, 13);
            this.label18.TabIndex = 51;
            this.label18.Text = "Sabiduria";
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Location = new System.Drawing.Point(15, 83);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(61, 13);
            this.label17.TabIndex = 50;
            this.label17.Text = "Inteligencia";
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Location = new System.Drawing.Point(15, 61);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(65, 13);
            this.label16.TabIndex = 49;
            this.label16.Text = "Constitucion";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(15, 39);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(49, 13);
            this.label15.TabIndex = 48;
            this.label15.Text = "Destreza";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(15, 17);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(39, 13);
            this.label14.TabIndex = 47;
            this.label14.Text = "Fuerza";
            // 
            // listBoxRazas
            // 
            this.listBoxRazas.FormattingEnabled = true;
            this.listBoxRazas.Location = new System.Drawing.Point(361, 12);
            this.listBoxRazas.Name = "listBoxRazas";
            this.listBoxRazas.Size = new System.Drawing.Size(120, 238);
            this.listBoxRazas.TabIndex = 75;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.label14);
            this.panel1.Controls.Add(this.label15);
            this.panel1.Controls.Add(this.selectFuerza);
            this.panel1.Controls.Add(this.label16);
            this.panel1.Controls.Add(this.selectCarisma);
            this.panel1.Controls.Add(this.label17);
            this.panel1.Controls.Add(this.selectSabiduria);
            this.panel1.Controls.Add(this.label18);
            this.panel1.Controls.Add(this.selectInteligencia);
            this.panel1.Controls.Add(this.label19);
            this.panel1.Controls.Add(this.selectDestreza);
            this.panel1.Controls.Add(this.selectConstitucion);
            this.panel1.Location = new System.Drawing.Point(12, 63);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(140, 156);
            this.panel1.TabIndex = 76;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(190, 27);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(46, 13);
            this.label2.TabIndex = 77;
            this.label2.Text = "Tamaño";
            // 
            // selectorTamaño
            // 
            this.selectorTamaño.FormattingEnabled = true;
            this.selectorTamaño.Items.AddRange(new object[] {
            "Minusculo",
            "Diminuto",
            "Menudo",
            "Pequeño",
            "Mediano",
            "Grande",
            "Enorme",
            "Gargantuesco",
            "Colosal"});
            this.selectorTamaño.Location = new System.Drawing.Point(235, 23);
            this.selectorTamaño.Name = "selectorTamaño";
            this.selectorTamaño.Size = new System.Drawing.Size(96, 21);
            this.selectorTamaño.TabIndex = 78;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(190, 63);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(54, 13);
            this.label3.TabIndex = 79;
            this.label3.Text = "Velocidad";
            // 
            // selectorVelocidad
            // 
            this.selectorVelocidad.Increment = new decimal(new int[] {
            5,
            0,
            0,
            0});
            this.selectorVelocidad.Location = new System.Drawing.Point(250, 61);
            this.selectorVelocidad.Name = "selectorVelocidad";
            this.selectorVelocidad.Size = new System.Drawing.Size(47, 20);
            this.selectorVelocidad.TabIndex = 80;
            this.selectorVelocidad.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.selectorVelocidad.Value = new decimal(new int[] {
            20,
            0,
            0,
            0});
            // 
            // CrearRazaView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(493, 262);
            this.Controls.Add(this.selectorVelocidad);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.selectorTamaño);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.listBoxRazas);
            this.Controls.Add(this.txtNomRaza);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnCargarRaza);
            this.Name = "CrearRazaView";
            this.Text = "Crear Raza";
            ((System.ComponentModel.ISupportInitialize)(this.selectFuerza)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.selectCarisma)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.selectSabiduria)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.selectInteligencia)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.selectDestreza)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.selectConstitucion)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.selectorVelocidad)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnCargarRaza;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtNomRaza;
        private System.Windows.Forms.NumericUpDown selectFuerza;
        private System.Windows.Forms.NumericUpDown selectCarisma;
        private System.Windows.Forms.NumericUpDown selectSabiduria;
        private System.Windows.Forms.NumericUpDown selectInteligencia;
        private System.Windows.Forms.NumericUpDown selectDestreza;
        private System.Windows.Forms.NumericUpDown selectConstitucion;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.ListBox listBoxRazas;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox selectorTamaño;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.NumericUpDown selectorVelocidad;
    }
}