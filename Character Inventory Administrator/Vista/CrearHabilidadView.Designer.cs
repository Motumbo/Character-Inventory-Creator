namespace Character_Inventory_Administrator.Vista
{
    partial class CrearHabilidadView
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
            this.components = new System.ComponentModel.Container();
            this.btnCargarHabilidad = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.txtNombreHabilidad = new System.Windows.Forms.TextBox();
            this.selectorAtribPrincipal = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.dataGridViewHabilidades = new System.Windows.Forms.DataGridView();
            this.habilidadesSource = new System.Windows.Forms.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewHabilidades)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.habilidadesSource)).BeginInit();
            this.SuspendLayout();
            // 
            // btnCargarHabilidad
            // 
            this.btnCargarHabilidad.Location = new System.Drawing.Point(280, 31);
            this.btnCargarHabilidad.Name = "btnCargarHabilidad";
            this.btnCargarHabilidad.Size = new System.Drawing.Size(75, 43);
            this.btnCargarHabilidad.TabIndex = 0;
            this.btnCargarHabilidad.Text = "Guardar HabilidadModel";
            this.btnCargarHabilidad.UseVisualStyleBackColor = true;
            this.btnCargarHabilidad.Click += new System.EventHandler(this.btnCargarHabilidad_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 34);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(44, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Nombre";
            // 
            // txtNombreHabilidad
            // 
            this.txtNombreHabilidad.Location = new System.Drawing.Point(63, 31);
            this.txtNombreHabilidad.Name = "txtNombreHabilidad";
            this.txtNombreHabilidad.Size = new System.Drawing.Size(162, 20);
            this.txtNombreHabilidad.TabIndex = 2;
            // 
            // selectorAtribPrincipal
            // 
            this.selectorAtribPrincipal.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.selectorAtribPrincipal.FormattingEnabled = true;
            this.selectorAtribPrincipal.Items.AddRange(new object[] {
            "Fuerza",
            "Destreza",
            "Constitucion",
            "Inteligencia",
            "Sabiduria",
            "Carisma"});
            this.selectorAtribPrincipal.Location = new System.Drawing.Point(63, 60);
            this.selectorAtribPrincipal.Name = "selectorAtribPrincipal";
            this.selectorAtribPrincipal.Size = new System.Drawing.Size(121, 21);
            this.selectorAtribPrincipal.TabIndex = 76;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 57);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(43, 26);
            this.label2.TabIndex = 77;
            this.label2.Text = "Atributo\r\nClave";
            // 
            // dataGridViewHabilidades
            // 
            this.dataGridViewHabilidades.AutoGenerateColumns = false;
            this.dataGridViewHabilidades.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewHabilidades.DataSource = this.habilidadesSource;
            this.dataGridViewHabilidades.Location = new System.Drawing.Point(12, 98);
            this.dataGridViewHabilidades.Name = "dataGridViewHabilidades";
            this.dataGridViewHabilidades.ReadOnly = true;
            this.dataGridViewHabilidades.RowHeadersVisible = false;
            this.dataGridViewHabilidades.Size = new System.Drawing.Size(229, 237);
            this.dataGridViewHabilidades.TabIndex = 78;
            // 
            // Crear_Habilidad
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(367, 347);
            this.Controls.Add(this.dataGridViewHabilidades);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.selectorAtribPrincipal);
            this.Controls.Add(this.txtNombreHabilidad);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnCargarHabilidad);
            this.Name = "Crear_Habilidad";
            this.Text = "Crear_Habilidad";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewHabilidades)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.habilidadesSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnCargarHabilidad;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtNombreHabilidad;
        private System.Windows.Forms.ComboBox selectorAtribPrincipal;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridView dataGridViewHabilidades;
        private System.Windows.Forms.BindingSource habilidadesSource;
    }
}