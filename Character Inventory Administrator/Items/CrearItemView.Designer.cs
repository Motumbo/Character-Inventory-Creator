namespace Character_Inventory_Administrator.Items
{
    partial class CrearItemView
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CrearItemView));
            this.label1 = new System.Windows.Forms.Label();
            this.btnCrearItem = new System.Windows.Forms.Button();
            this.pictureBoxImagenItem = new System.Windows.Forms.PictureBox();
            this.txtNombreItem = new System.Windows.Forms.TextBox();
            this.openFileDialogImagenItem = new System.Windows.Forms.OpenFileDialog();
            this.selectorCategoria = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnAgregar = new System.Windows.Forms.Button();
            this.label8 = new System.Windows.Forms.Label();
            this.selectorPropiedadesEspeciales = new System.Windows.Forms.ComboBox();
            this.listBoxPropiedadesEspecialesItem = new System.Windows.Forms.ListBox();
            this.label6 = new System.Windows.Forms.Label();
            this.selectorPeso = new System.Windows.Forms.NumericUpDown();
            this.label5 = new System.Windows.Forms.Label();
            this.selectorMaxStack = new System.Windows.Forms.NumericUpDown();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.btnCargarImagenItem = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.selectorTamaño = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxImagenItem)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.selectorPeso)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.selectorMaxStack)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(44, 39);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(67, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Nombre Item";
            // 
            // btnCrearItem
            // 
            this.btnCrearItem.Location = new System.Drawing.Point(1037, 477);
            this.btnCrearItem.Name = "btnCrearItem";
            this.btnCrearItem.Size = new System.Drawing.Size(134, 73);
            this.btnCrearItem.TabIndex = 1;
            this.btnCrearItem.Text = "Guardar Item";
            this.btnCrearItem.UseVisualStyleBackColor = true;
            this.btnCrearItem.Click += new System.EventHandler(this.btnCrearItem_Click);
            // 
            // pictureBoxImagenItem
            // 
            this.pictureBoxImagenItem.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.pictureBoxImagenItem.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBoxImagenItem.BackgroundImage")));
            this.pictureBoxImagenItem.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.pictureBoxImagenItem.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pictureBoxImagenItem.Location = new System.Drawing.Point(876, 41);
            this.pictureBoxImagenItem.Name = "pictureBoxImagenItem";
            this.pictureBoxImagenItem.Size = new System.Drawing.Size(250, 100);
            this.pictureBoxImagenItem.TabIndex = 2;
            this.pictureBoxImagenItem.TabStop = false;
            // 
            // txtNombreItem
            // 
            this.txtNombreItem.Location = new System.Drawing.Point(129, 36);
            this.txtNombreItem.Name = "txtNombreItem";
            this.txtNombreItem.Size = new System.Drawing.Size(100, 20);
            this.txtNombreItem.TabIndex = 3;
            // 
            // openFileDialogImagenItem
            // 
            this.openFileDialogImagenItem.FileName = "openFileDialogImagenItem";
            // 
            // selectorCategoria
            // 
            this.selectorCategoria.FormattingEnabled = true;
            this.selectorCategoria.Location = new System.Drawing.Point(390, 35);
            this.selectorCategoria.Name = "selectorCategoria";
            this.selectorCategoria.Size = new System.Drawing.Size(121, 21);
            this.selectorCategoria.TabIndex = 4;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(309, 38);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(75, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "Categoria Item";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.btnAgregar);
            this.panel1.Controls.Add(this.label8);
            this.panel1.Controls.Add(this.selectorPropiedadesEspeciales);
            this.panel1.Controls.Add(this.listBoxPropiedadesEspecialesItem);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.selectorPeso);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.selectorMaxStack);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Location = new System.Drawing.Point(12, 120);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(797, 437);
            this.panel1.TabIndex = 6;
            // 
            // btnAgregar
            // 
            this.btnAgregar.Location = new System.Drawing.Point(399, 126);
            this.btnAgregar.Name = "btnAgregar";
            this.btnAgregar.Size = new System.Drawing.Size(75, 41);
            this.btnAgregar.TabIndex = 13;
            this.btnAgregar.Text = "Agregar Propiedad";
            this.btnAgregar.UseVisualStyleBackColor = true;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(3, 121);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(120, 13);
            this.label8.TabIndex = 12;
            this.label8.Text = "Propiedades Especiales";
            // 
            // selectorPropiedadesEspeciales
            // 
            this.selectorPropiedadesEspeciales.FormattingEnabled = true;
            this.selectorPropiedadesEspeciales.Items.AddRange(new object[] {
            "Enorme",
            "Grande",
            "Mediano",
            "Pequeño",
            "Diminuto"});
            this.selectorPropiedadesEspeciales.Location = new System.Drawing.Point(7, 137);
            this.selectorPropiedadesEspeciales.Name = "selectorPropiedadesEspeciales";
            this.selectorPropiedadesEspeciales.Size = new System.Drawing.Size(386, 21);
            this.selectorPropiedadesEspeciales.TabIndex = 11;
            // 
            // listBoxPropiedadesEspecialesItem
            // 
            this.listBoxPropiedadesEspecialesItem.FormattingEnabled = true;
            this.listBoxPropiedadesEspecialesItem.Location = new System.Drawing.Point(488, 3);
            this.listBoxPropiedadesEspecialesItem.Name = "listBoxPropiedadesEspecialesItem";
            this.listBoxPropiedadesEspecialesItem.Size = new System.Drawing.Size(306, 342);
            this.listBoxPropiedadesEspecialesItem.TabIndex = 11;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(373, 66);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(20, 13);
            this.label6.TabIndex = 10;
            this.label6.Text = "Kg";
            // 
            // selectorPeso
            // 
            this.selectorPeso.DecimalPlaces = 3;
            this.selectorPeso.Increment = new decimal(new int[] {
            1,
            0,
            0,
            196608});
            this.selectorPeso.Location = new System.Drawing.Point(314, 64);
            this.selectorPeso.Name = "selectorPeso";
            this.selectorPeso.Size = new System.Drawing.Size(53, 20);
            this.selectorPeso.TabIndex = 9;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(277, 66);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(31, 13);
            this.label5.TabIndex = 8;
            this.label5.Text = "Peso";
            // 
            // selectorMaxStack
            // 
            this.selectorMaxStack.Location = new System.Drawing.Point(96, 64);
            this.selectorMaxStack.Name = "selectorMaxStack";
            this.selectorMaxStack.Size = new System.Drawing.Size(53, 20);
            this.selectorMaxStack.TabIndex = 7;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(32, 66);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(58, 13);
            this.label4.TabIndex = 6;
            this.label4.Text = "Max Stack";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 104);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(215, 13);
            this.label3.TabIndex = 7;
            this.label3.Text = "Editor de Caracteristicas segun Tipo de Item";
            // 
            // btnCargarImagenItem
            // 
            this.btnCargarImagenItem.Location = new System.Drawing.Point(945, 12);
            this.btnCargarImagenItem.Name = "btnCargarImagenItem";
            this.btnCargarImagenItem.Size = new System.Drawing.Size(93, 23);
            this.btnCargarImagenItem.TabIndex = 8;
            this.btnCargarImagenItem.Text = "Cargar Imagen";
            this.btnCargarImagenItem.UseVisualStyleBackColor = true;
            this.btnCargarImagenItem.Click += new System.EventHandler(this.btnCargarImagenItem_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(309, 68);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(69, 13);
            this.label7.TabIndex = 10;
            this.label7.Text = "Tamaño Item";
            // 
            // selectorTamaño
            // 
            this.selectorTamaño.FormattingEnabled = true;
            this.selectorTamaño.Items.AddRange(new object[] {
            "Enorme",
            "Grande",
            "Mediano",
            "Pequeño",
            "Diminuto"});
            this.selectorTamaño.Location = new System.Drawing.Point(390, 65);
            this.selectorTamaño.Name = "selectorTamaño";
            this.selectorTamaño.Size = new System.Drawing.Size(121, 21);
            this.selectorTamaño.TabIndex = 9;
            this.selectorTamaño.SelectedIndexChanged += new System.EventHandler(this.selectorTamaño_SelectedIndexChanged);
            // 
            // CrearItemView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1183, 562);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.selectorTamaño);
            this.Controls.Add(this.btnCargarImagenItem);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.selectorCategoria);
            this.Controls.Add(this.txtNombreItem);
            this.Controls.Add(this.pictureBoxImagenItem);
            this.Controls.Add(this.btnCrearItem);
            this.Controls.Add(this.label1);
            this.Name = "CrearItemView";
            this.Text = "CrearItemView";
            this.Load += new System.EventHandler(this.CrearItemView_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxImagenItem)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.selectorPeso)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.selectorMaxStack)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnCrearItem;
        private System.Windows.Forms.PictureBox pictureBoxImagenItem;
        private System.Windows.Forms.TextBox txtNombreItem;
        private System.Windows.Forms.OpenFileDialog openFileDialogImagenItem;
        private System.Windows.Forms.ComboBox selectorCategoria;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnCargarImagenItem;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.NumericUpDown selectorPeso;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.NumericUpDown selectorMaxStack;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ComboBox selectorTamaño;
        private System.Windows.Forms.ComboBox selectorPropiedadesEspeciales;
        private System.Windows.Forms.ListBox listBoxPropiedadesEspecialesItem;
        private System.Windows.Forms.Button btnAgregar;
        private System.Windows.Forms.Label label8;
    }
}