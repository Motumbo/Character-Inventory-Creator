namespace Character_Inventory_Administrator
{
    partial class Crear_Clase
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
            this.txtNomClase = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnCargarClase = new System.Windows.Forms.Button();
            this.listBoxClases = new System.Windows.Forms.ListBox();
            this.dataGridViewHabilidades = new System.Windows.Forms.DataGridView();
            this.habilidadesSource = new System.Windows.Forms.BindingSource(this.components);
            this.Pertenece = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.nombreColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.atributoClaveColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.selectFuerza)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.selectCarisma)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.selectSabiduria)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.selectInteligencia)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.selectDestreza)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.selectConstitucion)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewHabilidades)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.habilidadesSource)).BeginInit();
            this.SuspendLayout();
            // 
            // selectFuerza
            // 
            this.selectFuerza.Location = new System.Drawing.Point(83, 70);
            this.selectFuerza.Minimum = new decimal(new int[] {
            10,
            0,
            0,
            -2147483648});
            this.selectFuerza.Name = "selectFuerza";
            this.selectFuerza.Size = new System.Drawing.Size(39, 20);
            this.selectFuerza.TabIndex = 73;
            this.selectFuerza.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // selectCarisma
            // 
            this.selectCarisma.Location = new System.Drawing.Point(83, 180);
            this.selectCarisma.Minimum = new decimal(new int[] {
            10,
            0,
            0,
            -2147483648});
            this.selectCarisma.Name = "selectCarisma";
            this.selectCarisma.Size = new System.Drawing.Size(39, 20);
            this.selectCarisma.TabIndex = 72;
            this.selectCarisma.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // selectSabiduria
            // 
            this.selectSabiduria.Location = new System.Drawing.Point(83, 158);
            this.selectSabiduria.Minimum = new decimal(new int[] {
            10,
            0,
            0,
            -2147483648});
            this.selectSabiduria.Name = "selectSabiduria";
            this.selectSabiduria.Size = new System.Drawing.Size(39, 20);
            this.selectSabiduria.TabIndex = 71;
            this.selectSabiduria.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // selectInteligencia
            // 
            this.selectInteligencia.Location = new System.Drawing.Point(83, 136);
            this.selectInteligencia.Minimum = new decimal(new int[] {
            10,
            0,
            0,
            -2147483648});
            this.selectInteligencia.Name = "selectInteligencia";
            this.selectInteligencia.Size = new System.Drawing.Size(39, 20);
            this.selectInteligencia.TabIndex = 70;
            this.selectInteligencia.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // selectDestreza
            // 
            this.selectDestreza.Location = new System.Drawing.Point(83, 92);
            this.selectDestreza.Minimum = new decimal(new int[] {
            10,
            0,
            0,
            -2147483648});
            this.selectDestreza.Name = "selectDestreza";
            this.selectDestreza.Size = new System.Drawing.Size(39, 20);
            this.selectDestreza.TabIndex = 69;
            this.selectDestreza.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // selectConstitucion
            // 
            this.selectConstitucion.Location = new System.Drawing.Point(83, 114);
            this.selectConstitucion.Minimum = new decimal(new int[] {
            10,
            0,
            0,
            -2147483648});
            this.selectConstitucion.Name = "selectConstitucion";
            this.selectConstitucion.Size = new System.Drawing.Size(39, 20);
            this.selectConstitucion.TabIndex = 68;
            this.selectConstitucion.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.Location = new System.Drawing.Point(12, 182);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(44, 13);
            this.label19.TabIndex = 67;
            this.label19.Text = "Carisma";
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Location = new System.Drawing.Point(12, 160);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(51, 13);
            this.label18.TabIndex = 66;
            this.label18.Text = "Sabiduria";
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Location = new System.Drawing.Point(12, 138);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(61, 13);
            this.label17.TabIndex = 65;
            this.label17.Text = "Inteligencia";
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Location = new System.Drawing.Point(12, 116);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(65, 13);
            this.label16.TabIndex = 64;
            this.label16.Text = "Constitucion";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(12, 94);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(49, 13);
            this.label15.TabIndex = 63;
            this.label15.Text = "Destreza";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(12, 72);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(39, 13);
            this.label14.TabIndex = 62;
            this.label14.Text = "Fuerza";
            // 
            // txtNomClase
            // 
            this.txtNomClase.Location = new System.Drawing.Point(83, 24);
            this.txtNomClase.Name = "txtNomClase";
            this.txtNomClase.Size = new System.Drawing.Size(100, 20);
            this.txtNomClase.TabIndex = 61;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(11, 27);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(73, 13);
            this.label1.TabIndex = 60;
            this.label1.Text = "Nombre Clase";
            // 
            // btnCargarClase
            // 
            this.btnCargarClase.Location = new System.Drawing.Point(328, 433);
            this.btnCargarClase.Name = "btnCargarClase";
            this.btnCargarClase.Size = new System.Drawing.Size(96, 56);
            this.btnCargarClase.TabIndex = 59;
            this.btnCargarClase.Text = "Guardar Clase";
            this.btnCargarClase.UseVisualStyleBackColor = true;
            this.btnCargarClase.Click += new System.EventHandler(this.btnCargarClase_Click);
            // 
            // listBoxClases
            // 
            this.listBoxClases.FormattingEnabled = true;
            this.listBoxClases.Location = new System.Drawing.Point(152, 70);
            this.listBoxClases.Name = "listBoxClases";
            this.listBoxClases.Size = new System.Drawing.Size(120, 134);
            this.listBoxClases.TabIndex = 74;
            // 
            // dataGridViewHabilidades
            // 
            this.dataGridViewHabilidades.AllowUserToAddRows = false;
            this.dataGridViewHabilidades.AllowUserToDeleteRows = false;
            this.dataGridViewHabilidades.AutoGenerateColumns = false;
            this.dataGridViewHabilidades.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewHabilidades.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Pertenece,
            this.nombreColumn,
            this.atributoClaveColumn});
            this.dataGridViewHabilidades.DataSource = this.habilidadesSource;
            this.dataGridViewHabilidades.Location = new System.Drawing.Point(14, 223);
            this.dataGridViewHabilidades.Name = "dataGridViewHabilidades";
            this.dataGridViewHabilidades.RowHeadersVisible = false;
            this.dataGridViewHabilidades.Size = new System.Drawing.Size(294, 237);
            this.dataGridViewHabilidades.TabIndex = 79;
            // 
            // Pertenece
            // 
            this.Pertenece.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader;
            this.Pertenece.HeaderText = "Pertenece";
            this.Pertenece.Name = "Pertenece";
            this.Pertenece.Width = 62;
            // 
            // nombreColumn
            // 
            this.nombreColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.nombreColumn.HeaderText = "Nombre";
            this.nombreColumn.Name = "nombreColumn";
            // 
            // atributoClaveColumn
            // 
            this.atributoClaveColumn.HeaderText = "Atributo Clave";
            this.atributoClaveColumn.Name = "atributoClaveColumn";
            // 
            // Crear_Clase
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(436, 501);
            this.Controls.Add(this.dataGridViewHabilidades);
            this.Controls.Add(this.listBoxClases);
            this.Controls.Add(this.selectFuerza);
            this.Controls.Add(this.selectCarisma);
            this.Controls.Add(this.selectSabiduria);
            this.Controls.Add(this.selectInteligencia);
            this.Controls.Add(this.selectDestreza);
            this.Controls.Add(this.selectConstitucion);
            this.Controls.Add(this.label19);
            this.Controls.Add(this.label18);
            this.Controls.Add(this.label17);
            this.Controls.Add(this.label16);
            this.Controls.Add(this.label15);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.txtNomClase);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnCargarClase);
            this.Name = "Crear_Clase";
            this.Text = "Crear_Clase";
            ((System.ComponentModel.ISupportInitialize)(this.selectFuerza)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.selectCarisma)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.selectSabiduria)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.selectInteligencia)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.selectDestreza)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.selectConstitucion)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewHabilidades)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.habilidadesSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

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
        private System.Windows.Forms.TextBox txtNomClase;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnCargarClase;
        private System.Windows.Forms.ListBox listBoxClases;
        private System.Windows.Forms.DataGridView dataGridViewHabilidades;
        private System.Windows.Forms.BindingSource habilidadesSource;
        private System.Windows.Forms.DataGridViewCheckBoxColumn Pertenece;
        private System.Windows.Forms.DataGridViewTextBoxColumn nombreColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn atributoClaveColumn;
    }
}