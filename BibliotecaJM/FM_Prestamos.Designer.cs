namespace BibliotecaJM
{
    partial class FM_Prestamos
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.Label id_lecLabel;
            System.Windows.Forms.Label nombre_lecLabel;
            System.Windows.Forms.Label domicilio_lecLabel;
            System.Windows.Forms.Label fecha_penalizacion_lecLabel;
            System.Windows.Forms.Label label1;
            System.Windows.Forms.Label label2;
            System.Windows.Forms.Label id_libLabel;
            System.Windows.Forms.Label titulo_libLabel;
            System.Windows.Forms.Label autor_libLabel;
            this.gbBuscarLector = new System.Windows.Forms.GroupBox();
            this.bBuscarNombreLector = new System.Windows.Forms.Button();
            this.bBuscarIDLector = new System.Windows.Forms.Button();
            this.tbNombre = new System.Windows.Forms.TextBox();
            this.tbIDLector = new System.Windows.Forms.TextBox();
            this.id_lecLabel1 = new System.Windows.Forms.Label();
            this.lectoresBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dS_Lectores = new BibliotecaJM.DS_Lectores();
            this.nombre_lecLabel1 = new System.Windows.Forms.Label();
            this.domicilio_lecLabel1 = new System.Windows.Forms.Label();
            this.fecha_penalizacion_lecLabel1 = new System.Windows.Forms.Label();
            this.gbBuscarLibro = new System.Windows.Forms.GroupBox();
            this.lectoresTableAdapter = new BibliotecaJM.DS_LectoresTableAdapters.lectoresTableAdapter();
            this.dS_LibrosPrestados = new BibliotecaJM.DS_LibrosPrestados();
            this.librosPrestadosBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.librosPrestadosTableAdapter = new BibliotecaJM.DS_LibrosPrestadosTableAdapters.LibrosPrestadosTableAdapter();
            this.librosPrestadosDataGridView = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dS_Libros = new BibliotecaJM.DS_Libros();
            this.librosBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.librosTableAdapter = new BibliotecaJM.DS_LibrosTableAdapters.librosTableAdapter();
            this.tableAdapterManager = new BibliotecaJM.DS_LibrosTableAdapters.TableAdapterManager();
            this.librosDataGridView = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn9 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.id_libTextBox = new System.Windows.Forms.TextBox();
            this.titulo_libTextBox = new System.Windows.Forms.TextBox();
            this.autor_libTextBox = new System.Windows.Forms.TextBox();
            this.bBuscarIDLibro = new System.Windows.Forms.Button();
            this.bBuscarTituloLibro = new System.Windows.Forms.Button();
            this.bRealizarPrestamo = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            id_lecLabel = new System.Windows.Forms.Label();
            nombre_lecLabel = new System.Windows.Forms.Label();
            domicilio_lecLabel = new System.Windows.Forms.Label();
            fecha_penalizacion_lecLabel = new System.Windows.Forms.Label();
            label1 = new System.Windows.Forms.Label();
            label2 = new System.Windows.Forms.Label();
            id_libLabel = new System.Windows.Forms.Label();
            titulo_libLabel = new System.Windows.Forms.Label();
            autor_libLabel = new System.Windows.Forms.Label();
            this.gbBuscarLector.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.lectoresBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dS_Lectores)).BeginInit();
            this.gbBuscarLibro.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dS_LibrosPrestados)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.librosPrestadosBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.librosPrestadosDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dS_Libros)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.librosBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.librosDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // id_lecLabel
            // 
            id_lecLabel.AutoSize = true;
            id_lecLabel.Location = new System.Drawing.Point(40, 96);
            id_lecLabel.Name = "id_lecLabel";
            id_lecLabel.Size = new System.Drawing.Size(54, 13);
            id_lecLabel.TabIndex = 0;
            id_lecLabel.Text = "ID Lector:";
            // 
            // nombre_lecLabel
            // 
            nombre_lecLabel.AutoSize = true;
            nombre_lecLabel.Location = new System.Drawing.Point(40, 119);
            nombre_lecLabel.Name = "nombre_lecLabel";
            nombre_lecLabel.Size = new System.Drawing.Size(47, 13);
            nombre_lecLabel.TabIndex = 2;
            nombre_lecLabel.Text = "Nombre:";
            // 
            // domicilio_lecLabel
            // 
            domicilio_lecLabel.AutoSize = true;
            domicilio_lecLabel.Location = new System.Drawing.Point(40, 142);
            domicilio_lecLabel.Name = "domicilio_lecLabel";
            domicilio_lecLabel.Size = new System.Drawing.Size(52, 13);
            domicilio_lecLabel.TabIndex = 4;
            domicilio_lecLabel.Text = "Domicilio:";
            // 
            // fecha_penalizacion_lecLabel
            // 
            fecha_penalizacion_lecLabel.AutoSize = true;
            fecha_penalizacion_lecLabel.Location = new System.Drawing.Point(40, 165);
            fecha_penalizacion_lecLabel.Name = "fecha_penalizacion_lecLabel";
            fecha_penalizacion_lecLabel.Size = new System.Drawing.Size(103, 13);
            fecha_penalizacion_lecLabel.TabIndex = 6;
            fecha_penalizacion_lecLabel.Text = "Fecha Penalizacion:";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new System.Drawing.Point(40, 51);
            label1.Name = "label1";
            label1.Size = new System.Drawing.Size(47, 13);
            label1.TabIndex = 2;
            label1.Text = "Nombre:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new System.Drawing.Point(40, 28);
            label2.Name = "label2";
            label2.Size = new System.Drawing.Size(54, 13);
            label2.TabIndex = 0;
            label2.Text = "ID Lector:";
            // 
            // gbBuscarLector
            // 
            this.gbBuscarLector.Controls.Add(this.bBuscarNombreLector);
            this.gbBuscarLector.Controls.Add(this.bBuscarIDLector);
            this.gbBuscarLector.Controls.Add(this.tbNombre);
            this.gbBuscarLector.Controls.Add(this.tbIDLector);
            this.gbBuscarLector.Controls.Add(label2);
            this.gbBuscarLector.Controls.Add(id_lecLabel);
            this.gbBuscarLector.Controls.Add(label1);
            this.gbBuscarLector.Controls.Add(this.id_lecLabel1);
            this.gbBuscarLector.Controls.Add(nombre_lecLabel);
            this.gbBuscarLector.Controls.Add(this.nombre_lecLabel1);
            this.gbBuscarLector.Controls.Add(domicilio_lecLabel);
            this.gbBuscarLector.Controls.Add(this.domicilio_lecLabel1);
            this.gbBuscarLector.Controls.Add(fecha_penalizacion_lecLabel);
            this.gbBuscarLector.Controls.Add(this.fecha_penalizacion_lecLabel1);
            this.gbBuscarLector.Location = new System.Drawing.Point(12, 12);
            this.gbBuscarLector.Name = "gbBuscarLector";
            this.gbBuscarLector.Size = new System.Drawing.Size(428, 191);
            this.gbBuscarLector.TabIndex = 0;
            this.gbBuscarLector.TabStop = false;
            this.gbBuscarLector.Text = "Búsqueda Lector";
            // 
            // bBuscarNombreLector
            // 
            this.bBuscarNombreLector.Location = new System.Drawing.Point(322, 47);
            this.bBuscarNombreLector.Name = "bBuscarNombreLector";
            this.bBuscarNombreLector.Size = new System.Drawing.Size(75, 20);
            this.bBuscarNombreLector.TabIndex = 9;
            this.bBuscarNombreLector.Text = "Buscar";
            this.bBuscarNombreLector.UseVisualStyleBackColor = true;
            // 
            // bBuscarIDLector
            // 
            this.bBuscarIDLector.Location = new System.Drawing.Point(322, 24);
            this.bBuscarIDLector.Name = "bBuscarIDLector";
            this.bBuscarIDLector.Size = new System.Drawing.Size(75, 20);
            this.bBuscarIDLector.TabIndex = 9;
            this.bBuscarIDLector.Text = "Buscar";
            this.bBuscarIDLector.UseVisualStyleBackColor = true;
            // 
            // tbNombre
            // 
            this.tbNombre.Location = new System.Drawing.Point(139, 48);
            this.tbNombre.Name = "tbNombre";
            this.tbNombre.Size = new System.Drawing.Size(162, 20);
            this.tbNombre.TabIndex = 8;
            // 
            // tbIDLector
            // 
            this.tbIDLector.Location = new System.Drawing.Point(139, 25);
            this.tbIDLector.Name = "tbIDLector";
            this.tbIDLector.Size = new System.Drawing.Size(162, 20);
            this.tbIDLector.TabIndex = 8;
            // 
            // id_lecLabel1
            // 
            this.id_lecLabel1.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.lectoresBindingSource, "id_lec", true));
            this.id_lecLabel1.Location = new System.Drawing.Point(162, 96);
            this.id_lecLabel1.Name = "id_lecLabel1";
            this.id_lecLabel1.Size = new System.Drawing.Size(100, 23);
            this.id_lecLabel1.TabIndex = 1;
            // 
            // lectoresBindingSource
            // 
            this.lectoresBindingSource.DataMember = "lectores";
            this.lectoresBindingSource.DataSource = this.dS_Lectores;
            // 
            // dS_Lectores
            // 
            this.dS_Lectores.DataSetName = "DS_Lectores";
            this.dS_Lectores.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // nombre_lecLabel1
            // 
            this.nombre_lecLabel1.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.lectoresBindingSource, "nombre_lec", true));
            this.nombre_lecLabel1.Location = new System.Drawing.Point(162, 119);
            this.nombre_lecLabel1.Name = "nombre_lecLabel1";
            this.nombre_lecLabel1.Size = new System.Drawing.Size(100, 23);
            this.nombre_lecLabel1.TabIndex = 3;
            // 
            // domicilio_lecLabel1
            // 
            this.domicilio_lecLabel1.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.lectoresBindingSource, "domicilio_lec", true));
            this.domicilio_lecLabel1.Location = new System.Drawing.Point(162, 142);
            this.domicilio_lecLabel1.Name = "domicilio_lecLabel1";
            this.domicilio_lecLabel1.Size = new System.Drawing.Size(100, 23);
            this.domicilio_lecLabel1.TabIndex = 5;
            // 
            // fecha_penalizacion_lecLabel1
            // 
            this.fecha_penalizacion_lecLabel1.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.lectoresBindingSource, "fecha_penalizacion_lec", true));
            this.fecha_penalizacion_lecLabel1.Location = new System.Drawing.Point(162, 165);
            this.fecha_penalizacion_lecLabel1.Name = "fecha_penalizacion_lecLabel1";
            this.fecha_penalizacion_lecLabel1.Size = new System.Drawing.Size(100, 23);
            this.fecha_penalizacion_lecLabel1.TabIndex = 7;
            // 
            // gbBuscarLibro
            // 
            this.gbBuscarLibro.Controls.Add(id_libLabel);
            this.gbBuscarLibro.Controls.Add(this.bRealizarPrestamo);
            this.gbBuscarLibro.Controls.Add(this.button1);
            this.gbBuscarLibro.Controls.Add(this.bBuscarTituloLibro);
            this.gbBuscarLibro.Controls.Add(this.bBuscarIDLibro);
            this.gbBuscarLibro.Controls.Add(this.id_libTextBox);
            this.gbBuscarLibro.Controls.Add(titulo_libLabel);
            this.gbBuscarLibro.Controls.Add(this.titulo_libTextBox);
            this.gbBuscarLibro.Controls.Add(autor_libLabel);
            this.gbBuscarLibro.Controls.Add(this.autor_libTextBox);
            this.gbBuscarLibro.Controls.Add(this.librosDataGridView);
            this.gbBuscarLibro.Location = new System.Drawing.Point(474, 12);
            this.gbBuscarLibro.Name = "gbBuscarLibro";
            this.gbBuscarLibro.Size = new System.Drawing.Size(524, 649);
            this.gbBuscarLibro.TabIndex = 0;
            this.gbBuscarLibro.TabStop = false;
            this.gbBuscarLibro.Text = "Buscar Libro";
            // 
            // lectoresTableAdapter
            // 
            this.lectoresTableAdapter.ClearBeforeFill = true;
            // 
            // dS_LibrosPrestados
            // 
            this.dS_LibrosPrestados.DataSetName = "DS_LibrosPrestados";
            this.dS_LibrosPrestados.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // librosPrestadosBindingSource
            // 
            this.librosPrestadosBindingSource.DataMember = "LibrosPrestados";
            this.librosPrestadosBindingSource.DataSource = this.dS_LibrosPrestados;
            // 
            // librosPrestadosTableAdapter
            // 
            this.librosPrestadosTableAdapter.ClearBeforeFill = true;
            // 
            // librosPrestadosDataGridView
            // 
            this.librosPrestadosDataGridView.AutoGenerateColumns = false;
            this.librosPrestadosDataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.librosPrestadosDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.librosPrestadosDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn4});
            this.librosPrestadosDataGridView.DataSource = this.librosPrestadosBindingSource;
            this.librosPrestadosDataGridView.Location = new System.Drawing.Point(12, 231);
            this.librosPrestadosDataGridView.Name = "librosPrestadosDataGridView";
            this.librosPrestadosDataGridView.RowHeadersVisible = false;
            this.librosPrestadosDataGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.librosPrestadosDataGridView.Size = new System.Drawing.Size(428, 430);
            this.librosPrestadosDataGridView.TabIndex = 2;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "id_lib";
            this.dataGridViewTextBoxColumn1.FillWeight = 30.45685F;
            this.dataGridViewTextBoxColumn1.HeaderText = "ID";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "titulo_lib";
            this.dataGridViewTextBoxColumn2.FillWeight = 123.181F;
            this.dataGridViewTextBoxColumn2.HeaderText = "Título";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "fecha_presta_pre";
            this.dataGridViewTextBoxColumn3.FillWeight = 123.181F;
            this.dataGridViewTextBoxColumn3.HeaderText = "Fecha Préstamo";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.DataPropertyName = "fecha_devol_pre";
            this.dataGridViewTextBoxColumn4.FillWeight = 123.181F;
            this.dataGridViewTextBoxColumn4.HeaderText = "Fecha Devolución";
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            // 
            // dS_Libros
            // 
            this.dS_Libros.DataSetName = "DS_Libros";
            this.dS_Libros.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // librosBindingSource
            // 
            this.librosBindingSource.DataMember = "libros";
            this.librosBindingSource.DataSource = this.dS_Libros;
            // 
            // librosTableAdapter
            // 
            this.librosTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.librosTableAdapter = this.librosTableAdapter;
            this.tableAdapterManager.UpdateOrder = BibliotecaJM.DS_LibrosTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // librosDataGridView
            // 
            this.librosDataGridView.AutoGenerateColumns = false;
            this.librosDataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.librosDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.librosDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn5,
            this.dataGridViewTextBoxColumn6,
            this.dataGridViewTextBoxColumn7,
            this.dataGridViewTextBoxColumn9});
            this.librosDataGridView.DataSource = this.librosBindingSource;
            this.librosDataGridView.Location = new System.Drawing.Point(28, 134);
            this.librosDataGridView.Name = "librosDataGridView";
            this.librosDataGridView.RowHeadersVisible = false;
            this.librosDataGridView.Size = new System.Drawing.Size(469, 456);
            this.librosDataGridView.TabIndex = 0;
            // 
            // dataGridViewTextBoxColumn5
            // 
            this.dataGridViewTextBoxColumn5.DataPropertyName = "id_lib";
            this.dataGridViewTextBoxColumn5.FillWeight = 40.60914F;
            this.dataGridViewTextBoxColumn5.HeaderText = "ID";
            this.dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            this.dataGridViewTextBoxColumn5.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn6
            // 
            this.dataGridViewTextBoxColumn6.DataPropertyName = "titulo_lib";
            this.dataGridViewTextBoxColumn6.FillWeight = 119.797F;
            this.dataGridViewTextBoxColumn6.HeaderText = "Título";
            this.dataGridViewTextBoxColumn6.Name = "dataGridViewTextBoxColumn6";
            // 
            // dataGridViewTextBoxColumn7
            // 
            this.dataGridViewTextBoxColumn7.DataPropertyName = "autor_lib";
            this.dataGridViewTextBoxColumn7.FillWeight = 119.797F;
            this.dataGridViewTextBoxColumn7.HeaderText = "Autor";
            this.dataGridViewTextBoxColumn7.Name = "dataGridViewTextBoxColumn7";
            // 
            // dataGridViewTextBoxColumn9
            // 
            this.dataGridViewTextBoxColumn9.DataPropertyName = "prestado_sn_lib";
            this.dataGridViewTextBoxColumn9.FillWeight = 119.797F;
            this.dataGridViewTextBoxColumn9.HeaderText = "Prestado";
            this.dataGridViewTextBoxColumn9.Name = "dataGridViewTextBoxColumn9";
            // 
            // id_libLabel
            // 
            id_libLabel.AutoSize = true;
            id_libLabel.Location = new System.Drawing.Point(25, 32);
            id_libLabel.Name = "id_libLabel";
            id_libLabel.Size = new System.Drawing.Size(68, 13);
            id_libLabel.TabIndex = 1;
            id_libLabel.Text = "Identificador:";
            // 
            // id_libTextBox
            // 
            this.id_libTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.librosBindingSource, "id_lib", true));
            this.id_libTextBox.Location = new System.Drawing.Point(114, 32);
            this.id_libTextBox.Name = "id_libTextBox";
            this.id_libTextBox.Size = new System.Drawing.Size(250, 20);
            this.id_libTextBox.TabIndex = 2;
            // 
            // titulo_libLabel
            // 
            titulo_libLabel.AutoSize = true;
            titulo_libLabel.Location = new System.Drawing.Point(25, 58);
            titulo_libLabel.Name = "titulo_libLabel";
            titulo_libLabel.Size = new System.Drawing.Size(38, 13);
            titulo_libLabel.TabIndex = 3;
            titulo_libLabel.Text = "Título:";
            // 
            // titulo_libTextBox
            // 
            this.titulo_libTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.librosBindingSource, "titulo_lib", true));
            this.titulo_libTextBox.Location = new System.Drawing.Point(114, 58);
            this.titulo_libTextBox.Name = "titulo_libTextBox";
            this.titulo_libTextBox.Size = new System.Drawing.Size(250, 20);
            this.titulo_libTextBox.TabIndex = 4;
            // 
            // autor_libLabel
            // 
            autor_libLabel.AutoSize = true;
            autor_libLabel.Location = new System.Drawing.Point(25, 84);
            autor_libLabel.Name = "autor_libLabel";
            autor_libLabel.Size = new System.Drawing.Size(35, 13);
            autor_libLabel.TabIndex = 5;
            autor_libLabel.Text = "Autor:";
            // 
            // autor_libTextBox
            // 
            this.autor_libTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.librosBindingSource, "autor_lib", true));
            this.autor_libTextBox.Location = new System.Drawing.Point(114, 84);
            this.autor_libTextBox.Name = "autor_libTextBox";
            this.autor_libTextBox.Size = new System.Drawing.Size(250, 20);
            this.autor_libTextBox.TabIndex = 6;
            // 
            // bBuscarIDLibro
            // 
            this.bBuscarIDLibro.Location = new System.Drawing.Point(394, 32);
            this.bBuscarIDLibro.Name = "bBuscarIDLibro";
            this.bBuscarIDLibro.Size = new System.Drawing.Size(75, 20);
            this.bBuscarIDLibro.TabIndex = 9;
            this.bBuscarIDLibro.Text = "Buscar";
            this.bBuscarIDLibro.UseVisualStyleBackColor = true;
            // 
            // bBuscarTituloLibro
            // 
            this.bBuscarTituloLibro.Location = new System.Drawing.Point(394, 58);
            this.bBuscarTituloLibro.Name = "bBuscarTituloLibro";
            this.bBuscarTituloLibro.Size = new System.Drawing.Size(75, 20);
            this.bBuscarTituloLibro.TabIndex = 9;
            this.bBuscarTituloLibro.Text = "Buscar";
            this.bBuscarTituloLibro.UseVisualStyleBackColor = true;
            // 
            // bRealizarPrestamo
            // 
            this.bRealizarPrestamo.Location = new System.Drawing.Point(28, 608);
            this.bRealizarPrestamo.Name = "bRealizarPrestamo";
            this.bRealizarPrestamo.Size = new System.Drawing.Size(469, 26);
            this.bRealizarPrestamo.TabIndex = 9;
            this.bRealizarPrestamo.Text = "REALIZAR PRÉSTAMO";
            this.bRealizarPrestamo.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(394, 84);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 20);
            this.button1.TabIndex = 9;
            this.button1.Text = "Buscar";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // FM_Prestamos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.ClientSize = new System.Drawing.Size(1018, 700);
            this.Controls.Add(this.librosPrestadosDataGridView);
            this.Controls.Add(this.gbBuscarLibro);
            this.Controls.Add(this.gbBuscarLector);
            this.Name = "FM_Prestamos";
            this.Load += new System.EventHandler(this.FM_Prestamos_Load);
            this.gbBuscarLector.ResumeLayout(false);
            this.gbBuscarLector.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.lectoresBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dS_Lectores)).EndInit();
            this.gbBuscarLibro.ResumeLayout(false);
            this.gbBuscarLibro.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dS_LibrosPrestados)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.librosPrestadosBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.librosPrestadosDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dS_Libros)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.librosBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.librosDataGridView)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox gbBuscarLector;
        private System.Windows.Forms.GroupBox gbBuscarLibro;
        private DS_Lectores dS_Lectores;
        private System.Windows.Forms.BindingSource lectoresBindingSource;
        private DS_LectoresTableAdapters.lectoresTableAdapter lectoresTableAdapter;
        private System.Windows.Forms.Button bBuscarNombreLector;
        private System.Windows.Forms.Button bBuscarIDLector;
        private System.Windows.Forms.TextBox tbNombre;
        private System.Windows.Forms.TextBox tbIDLector;
        private System.Windows.Forms.Label id_lecLabel1;
        private System.Windows.Forms.Label nombre_lecLabel1;
        private System.Windows.Forms.Label domicilio_lecLabel1;
        private System.Windows.Forms.Label fecha_penalizacion_lecLabel1;
        private DS_LibrosPrestados dS_LibrosPrestados;
        private System.Windows.Forms.BindingSource librosPrestadosBindingSource;
        private DS_LibrosPrestadosTableAdapters.LibrosPrestadosTableAdapter librosPrestadosTableAdapter;
        private System.Windows.Forms.DataGridView librosPrestadosDataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private DS_Libros dS_Libros;
        private System.Windows.Forms.BindingSource librosBindingSource;
        private DS_LibrosTableAdapters.librosTableAdapter librosTableAdapter;
        private DS_LibrosTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.Button bRealizarPrestamo;
        private System.Windows.Forms.Button bBuscarTituloLibro;
        private System.Windows.Forms.Button bBuscarIDLibro;
        private System.Windows.Forms.TextBox id_libTextBox;
        private System.Windows.Forms.TextBox titulo_libTextBox;
        private System.Windows.Forms.TextBox autor_libTextBox;
        private System.Windows.Forms.DataGridView librosDataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn6;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn7;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn9;
        private System.Windows.Forms.Button button1;
    }
}
