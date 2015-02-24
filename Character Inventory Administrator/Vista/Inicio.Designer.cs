namespace Character_Inventory_Administrator.Vista
{
    partial class Inicio
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
            this.btnCrearPersonaje = new System.Windows.Forms.Button();
            this.btnAbrir = new System.Windows.Forms.Button();
            this.btnCrearRaza = new System.Windows.Forms.Button();
            this.btnCrearClase = new System.Windows.Forms.Button();
            this.btnCrearHabilidad = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnCrearPersonaje
            // 
            this.btnCrearPersonaje.Location = new System.Drawing.Point(266, 55);
            this.btnCrearPersonaje.Name = "btnCrearPersonaje";
            this.btnCrearPersonaje.Size = new System.Drawing.Size(209, 23);
            this.btnCrearPersonaje.TabIndex = 0;
            this.btnCrearPersonaje.Text = "Crear Nuevo Personaje";
            this.btnCrearPersonaje.UseVisualStyleBackColor = true;
            this.btnCrearPersonaje.Click += new System.EventHandler(this.btnCrear_Click);
            // 
            // btnAbrir
            // 
            this.btnAbrir.Location = new System.Drawing.Point(266, 228);
            this.btnAbrir.Name = "btnAbrir";
            this.btnAbrir.Size = new System.Drawing.Size(209, 23);
            this.btnAbrir.TabIndex = 1;
            this.btnAbrir.Text = "Abrir PersonajeModel Ya Existente";
            this.btnAbrir.UseVisualStyleBackColor = true;
            // 
            // btnCrearRaza
            // 
            this.btnCrearRaza.Location = new System.Drawing.Point(266, 117);
            this.btnCrearRaza.Name = "btnCrearRaza";
            this.btnCrearRaza.Size = new System.Drawing.Size(209, 23);
            this.btnCrearRaza.TabIndex = 2;
            this.btnCrearRaza.Text = "Crear Nueva Raza";
            this.btnCrearRaza.UseVisualStyleBackColor = true;
            this.btnCrearRaza.Click += new System.EventHandler(this.btnCrearRaza_Click);
            // 
            // btnCrearClase
            // 
            this.btnCrearClase.Location = new System.Drawing.Point(266, 146);
            this.btnCrearClase.Name = "btnCrearClase";
            this.btnCrearClase.Size = new System.Drawing.Size(209, 23);
            this.btnCrearClase.TabIndex = 3;
            this.btnCrearClase.Text = "Crear Nueva Clase";
            this.btnCrearClase.UseVisualStyleBackColor = true;
            this.btnCrearClase.Click += new System.EventHandler(this.btnCrearClase_Click);
            // 
            // btnCrearHabilidad
            // 
            this.btnCrearHabilidad.Location = new System.Drawing.Point(266, 175);
            this.btnCrearHabilidad.Name = "btnCrearHabilidad";
            this.btnCrearHabilidad.Size = new System.Drawing.Size(209, 23);
            this.btnCrearHabilidad.TabIndex = 4;
            this.btnCrearHabilidad.Text = "Crear Nueva Habilidad";
            this.btnCrearHabilidad.UseVisualStyleBackColor = true;
            this.btnCrearHabilidad.Click += new System.EventHandler(this.btnCrearHabilidad_Click);
            // 
            // Inicio
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(773, 286);
            this.Controls.Add(this.btnCrearHabilidad);
            this.Controls.Add(this.btnCrearClase);
            this.Controls.Add(this.btnCrearRaza);
            this.Controls.Add(this.btnAbrir);
            this.Controls.Add(this.btnCrearPersonaje);
            this.Name = "Inicio";
            this.Text = "Inicio";
            this.Load += new System.EventHandler(this.Inicio_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnCrearPersonaje;
        private System.Windows.Forms.Button btnAbrir;
        private System.Windows.Forms.Button btnCrearRaza;
        private System.Windows.Forms.Button btnCrearClase;
        private System.Windows.Forms.Button btnCrearHabilidad;
    }
}