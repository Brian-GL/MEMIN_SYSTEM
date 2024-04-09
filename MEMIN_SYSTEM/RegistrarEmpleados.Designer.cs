/*
 * Creado por SharpDevelop.
 * Usuario: Brian Gaytan Lomeli
 * Fecha: 21/10/2019
 * Hora: 16:21
 * 
 * Para cambiar esta plantilla use Herramientas | Opciones | Codificación | Editar Encabezados Estándar
 */
namespace MEMIN_SYSTEM
{
	partial class RegistrarEmpleados
	{
		/// <summary>
		/// Designer variable used to keep track of non-visual components.
		/// </summary>
		private System.ComponentModel.IContainer components = null;
		private System.Windows.Forms.PictureBox pictureBoxImagenCargada;
		private System.Windows.Forms.Button buttonCargarImagen;
		private System.Windows.Forms.Button buttonGuardar;
		private System.Windows.Forms.Button buttonLimpiar;
		private System.Windows.Forms.TextBox textBoxID;
		private System.Windows.Forms.Label labelID;
		private System.Windows.Forms.TextBox textBoxNombre;
		private System.Windows.Forms.Label labelNombre;
		private System.Windows.Forms.TextBox textBoxApellidoPaterno;
		private System.Windows.Forms.Label labelApellidoPaterno;
		private System.Windows.Forms.TextBox textBoxApellidoMaterno;
		private System.Windows.Forms.Label labelApellidoMaterno;
		private System.Windows.Forms.Label labelPuesto;
		private System.Windows.Forms.ComboBox comboBoxPuesto;
		private System.Windows.Forms.DataGridView dataGridViewCorreos;
		private System.Windows.Forms.DataGridViewTextBoxColumn Correo;
		private System.Windows.Forms.DataGridView dataGridViewTelefono;
		private System.Windows.Forms.DataGridViewTextBoxColumn Telefono;
		private System.Windows.Forms.Panel panelFondo;
		private System.Windows.Forms.Label labelTitulo;
		private System.Windows.Forms.DataGridViewButtonColumn ELIMINAR_CORREO;
		private System.Windows.Forms.DataGridViewButtonColumn ELIMINAR_TELEFONO;
		
		/// <summary>
		/// Disposes resources used by the form.
		/// </summary>
		/// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		protected override void Dispose(bool disposing)
		{
			if (disposing) {
				if (components != null) {
					components.Dispose();
				}
			}
			base.Dispose(disposing);
		}
		
		/// <summary>
		/// This method is required for Windows Forms designer support.
		/// Do not change the method contents inside the source code editor. The Forms designer might
		/// not be able to load this method if it was changed manually.
		/// </summary>
		private void InitializeComponent()
		{
			System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
			System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
			System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
			System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
			System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
			System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
			System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle8 = new System.Windows.Forms.DataGridViewCellStyle();
			System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(RegistrarEmpleados));
			this.pictureBoxImagenCargada = new System.Windows.Forms.PictureBox();
			this.buttonCargarImagen = new System.Windows.Forms.Button();
			this.buttonGuardar = new System.Windows.Forms.Button();
			this.buttonLimpiar = new System.Windows.Forms.Button();
			this.textBoxID = new System.Windows.Forms.TextBox();
			this.labelID = new System.Windows.Forms.Label();
			this.textBoxNombre = new System.Windows.Forms.TextBox();
			this.labelNombre = new System.Windows.Forms.Label();
			this.textBoxApellidoPaterno = new System.Windows.Forms.TextBox();
			this.labelApellidoPaterno = new System.Windows.Forms.Label();
			this.textBoxApellidoMaterno = new System.Windows.Forms.TextBox();
			this.labelApellidoMaterno = new System.Windows.Forms.Label();
			this.labelPuesto = new System.Windows.Forms.Label();
			this.comboBoxPuesto = new System.Windows.Forms.ComboBox();
			this.dataGridViewCorreos = new System.Windows.Forms.DataGridView();
			this.Correo = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.ELIMINAR_CORREO = new System.Windows.Forms.DataGridViewButtonColumn();
			this.dataGridViewTelefono = new System.Windows.Forms.DataGridView();
			this.Telefono = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.ELIMINAR_TELEFONO = new System.Windows.Forms.DataGridViewButtonColumn();
			this.panelFondo = new System.Windows.Forms.Panel();
			this.labelTitulo = new System.Windows.Forms.Label();
			((System.ComponentModel.ISupportInitialize)(this.pictureBoxImagenCargada)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.dataGridViewCorreos)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.dataGridViewTelefono)).BeginInit();
			this.panelFondo.SuspendLayout();
			this.SuspendLayout();
			// 
			// pictureBoxImagenCargada
			// 
			this.pictureBoxImagenCargada.BackColor = System.Drawing.Color.Transparent;
			this.pictureBoxImagenCargada.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
			this.pictureBoxImagenCargada.Location = new System.Drawing.Point(1016, 191);
			this.pictureBoxImagenCargada.Name = "pictureBoxImagenCargada";
			this.pictureBoxImagenCargada.Size = new System.Drawing.Size(300, 300);
			this.pictureBoxImagenCargada.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
			this.pictureBoxImagenCargada.TabIndex = 20;
			this.pictureBoxImagenCargada.TabStop = false;
			// 
			// buttonCargarImagen
			// 
			this.buttonCargarImagen.BackColor = System.Drawing.Color.Transparent;
			this.buttonCargarImagen.Cursor = System.Windows.Forms.Cursors.Hand;
			this.buttonCargarImagen.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.buttonCargarImagen.Font = new System.Drawing.Font("Maiandra GD", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.buttonCargarImagen.ForeColor = System.Drawing.Color.White;
			this.buttonCargarImagen.Location = new System.Drawing.Point(1078, 527);
			this.buttonCargarImagen.Name = "buttonCargarImagen";
			this.buttonCargarImagen.Size = new System.Drawing.Size(160, 60);
			this.buttonCargarImagen.TabIndex = 19;
			this.buttonCargarImagen.Text = "CARGAR IMAGEN";
			this.buttonCargarImagen.UseVisualStyleBackColor = false;
			this.buttonCargarImagen.Click += new System.EventHandler(this.ButtonCargarImagenClick);
			// 
			// buttonGuardar
			// 
			this.buttonGuardar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
			this.buttonGuardar.BackColor = System.Drawing.Color.Transparent;
			this.buttonGuardar.Cursor = System.Windows.Forms.Cursors.Hand;
			this.buttonGuardar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.buttonGuardar.Font = new System.Drawing.Font("Maiandra GD", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.buttonGuardar.ForeColor = System.Drawing.Color.White;
			this.buttonGuardar.Location = new System.Drawing.Point(1166, 655);
			this.buttonGuardar.Name = "buttonGuardar";
			this.buttonGuardar.Size = new System.Drawing.Size(160, 60);
			this.buttonGuardar.TabIndex = 21;
			this.buttonGuardar.Text = "GUARDAR";
			this.buttonGuardar.UseVisualStyleBackColor = false;
			this.buttonGuardar.Click += new System.EventHandler(this.ButtonGuardarClick);
			// 
			// buttonLimpiar
			// 
			this.buttonLimpiar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
			this.buttonLimpiar.BackColor = System.Drawing.Color.Transparent;
			this.buttonLimpiar.Cursor = System.Windows.Forms.Cursors.Hand;
			this.buttonLimpiar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.buttonLimpiar.Font = new System.Drawing.Font("Maiandra GD", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.buttonLimpiar.ForeColor = System.Drawing.Color.White;
			this.buttonLimpiar.Location = new System.Drawing.Point(985, 655);
			this.buttonLimpiar.Name = "buttonLimpiar";
			this.buttonLimpiar.Size = new System.Drawing.Size(160, 60);
			this.buttonLimpiar.TabIndex = 23;
			this.buttonLimpiar.Text = "LIMPIAR";
			this.buttonLimpiar.UseVisualStyleBackColor = false;
			this.buttonLimpiar.Click += new System.EventHandler(this.ButtonLimpiarClick);
			// 
			// textBoxID
			// 
			this.textBoxID.Enabled = false;
			this.textBoxID.Font = new System.Drawing.Font("Maiandra GD", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.textBoxID.Location = new System.Drawing.Point(200, 130);
			this.textBoxID.Name = "textBoxID";
			this.textBoxID.ReadOnly = true;
			this.textBoxID.ScrollBars = System.Windows.Forms.ScrollBars.Horizontal;
			this.textBoxID.Size = new System.Drawing.Size(405, 30);
			this.textBoxID.TabIndex = 25;
			this.textBoxID.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
			// 
			// labelID
			// 
			this.labelID.BackColor = System.Drawing.Color.Transparent;
			this.labelID.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
			this.labelID.Font = new System.Drawing.Font("Maiandra GD", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.labelID.ForeColor = System.Drawing.Color.White;
			this.labelID.Location = new System.Drawing.Point(12, 130);
			this.labelID.Name = "labelID";
			this.labelID.Size = new System.Drawing.Size(170, 32);
			this.labelID.TabIndex = 24;
			this.labelID.Text = "ID:";
			this.labelID.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// textBoxNombre
			// 
			this.textBoxNombre.Font = new System.Drawing.Font("Maiandra GD", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.textBoxNombre.Location = new System.Drawing.Point(200, 177);
			this.textBoxNombre.MaxLength = 35;
			this.textBoxNombre.Name = "textBoxNombre";
			this.textBoxNombre.ScrollBars = System.Windows.Forms.ScrollBars.Horizontal;
			this.textBoxNombre.Size = new System.Drawing.Size(405, 30);
			this.textBoxNombre.TabIndex = 27;
			this.textBoxNombre.TextChanged += new System.EventHandler(this.TextBoxNombreTextChanged);
			// 
			// labelNombre
			// 
			this.labelNombre.BackColor = System.Drawing.Color.Transparent;
			this.labelNombre.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
			this.labelNombre.Font = new System.Drawing.Font("Maiandra GD", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.labelNombre.ForeColor = System.Drawing.Color.White;
			this.labelNombre.Location = new System.Drawing.Point(12, 177);
			this.labelNombre.Name = "labelNombre";
			this.labelNombre.Size = new System.Drawing.Size(170, 32);
			this.labelNombre.TabIndex = 26;
			this.labelNombre.Text = "NOMBRE:";
			this.labelNombre.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// textBoxApellidoPaterno
			// 
			this.textBoxApellidoPaterno.Font = new System.Drawing.Font("Maiandra GD", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.textBoxApellidoPaterno.Location = new System.Drawing.Point(200, 224);
			this.textBoxApellidoPaterno.MaxLength = 25;
			this.textBoxApellidoPaterno.Name = "textBoxApellidoPaterno";
			this.textBoxApellidoPaterno.ScrollBars = System.Windows.Forms.ScrollBars.Horizontal;
			this.textBoxApellidoPaterno.Size = new System.Drawing.Size(405, 30);
			this.textBoxApellidoPaterno.TabIndex = 29;
			this.textBoxApellidoPaterno.TextChanged += new System.EventHandler(this.TextBoxApellidoPaternoTextChanged);
			// 
			// labelApellidoPaterno
			// 
			this.labelApellidoPaterno.BackColor = System.Drawing.Color.Transparent;
			this.labelApellidoPaterno.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
			this.labelApellidoPaterno.Font = new System.Drawing.Font("Maiandra GD", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.labelApellidoPaterno.ForeColor = System.Drawing.Color.White;
			this.labelApellidoPaterno.Location = new System.Drawing.Point(12, 224);
			this.labelApellidoPaterno.Name = "labelApellidoPaterno";
			this.labelApellidoPaterno.Size = new System.Drawing.Size(170, 32);
			this.labelApellidoPaterno.TabIndex = 28;
			this.labelApellidoPaterno.Text = "A. PATERNO:";
			this.labelApellidoPaterno.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// textBoxApellidoMaterno
			// 
			this.textBoxApellidoMaterno.Font = new System.Drawing.Font("Maiandra GD", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.textBoxApellidoMaterno.Location = new System.Drawing.Point(200, 271);
			this.textBoxApellidoMaterno.MaxLength = 25;
			this.textBoxApellidoMaterno.Name = "textBoxApellidoMaterno";
			this.textBoxApellidoMaterno.ScrollBars = System.Windows.Forms.ScrollBars.Horizontal;
			this.textBoxApellidoMaterno.Size = new System.Drawing.Size(405, 30);
			this.textBoxApellidoMaterno.TabIndex = 31;
			this.textBoxApellidoMaterno.TextChanged += new System.EventHandler(this.TextBoxApellidoMaternoTextChanged);
			// 
			// labelApellidoMaterno
			// 
			this.labelApellidoMaterno.BackColor = System.Drawing.Color.Transparent;
			this.labelApellidoMaterno.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
			this.labelApellidoMaterno.Font = new System.Drawing.Font("Maiandra GD", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.labelApellidoMaterno.ForeColor = System.Drawing.Color.White;
			this.labelApellidoMaterno.Location = new System.Drawing.Point(12, 271);
			this.labelApellidoMaterno.Name = "labelApellidoMaterno";
			this.labelApellidoMaterno.Size = new System.Drawing.Size(170, 32);
			this.labelApellidoMaterno.TabIndex = 30;
			this.labelApellidoMaterno.Text = "A. MATERNO:";
			this.labelApellidoMaterno.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// labelPuesto
			// 
			this.labelPuesto.BackColor = System.Drawing.Color.Transparent;
			this.labelPuesto.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
			this.labelPuesto.Font = new System.Drawing.Font("Maiandra GD", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.labelPuesto.ForeColor = System.Drawing.Color.White;
			this.labelPuesto.Location = new System.Drawing.Point(12, 319);
			this.labelPuesto.Name = "labelPuesto";
			this.labelPuesto.Size = new System.Drawing.Size(170, 32);
			this.labelPuesto.TabIndex = 32;
			this.labelPuesto.Text = "PUESTO:";
			this.labelPuesto.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// comboBoxPuesto
			// 
			this.comboBoxPuesto.Font = new System.Drawing.Font("Maiandra GD", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.comboBoxPuesto.FormattingEnabled = true;
			this.comboBoxPuesto.Items.AddRange(new object[] {
			"MESERO",
			"CAPITAN DE MESEROS",
			"COCINERO",
			"CHEF",
			"ENCARGADO COCINA",
			"COMPRAS",
			"ENCARGADO DE COMPRAS",
			"ALMACEN",
			"ENCARGADO DE ALMACEN",
			"GERENCIA",
			"FINANZAS",
			"ENCARGADO DE FINANZAS",
			"CAJERO"});
			this.comboBoxPuesto.Location = new System.Drawing.Point(200, 319);
			this.comboBoxPuesto.Name = "comboBoxPuesto";
			this.comboBoxPuesto.Size = new System.Drawing.Size(405, 30);
			this.comboBoxPuesto.TabIndex = 33;
			this.comboBoxPuesto.Text = "MESERO";
			// 
			// dataGridViewCorreos
			// 
			this.dataGridViewCorreos.AllowDrop = true;
			this.dataGridViewCorreos.AllowUserToOrderColumns = true;
			this.dataGridViewCorreos.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
			this.dataGridViewCorreos.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
			this.dataGridViewCorreos.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.Sunken;
			dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
			dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
			dataGridViewCellStyle1.Font = new System.Drawing.Font("Maiandra GD", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
			dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
			dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
			dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
			this.dataGridViewCorreos.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
			this.dataGridViewCorreos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dataGridViewCorreos.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
			this.Correo,
			this.ELIMINAR_CORREO});
			dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
			dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Window;
			dataGridViewCellStyle3.Font = new System.Drawing.Font("Maiandra GD", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.ControlText;
			dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
			dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
			dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
			this.dataGridViewCorreos.DefaultCellStyle = dataGridViewCellStyle3;
			this.dataGridViewCorreos.EditMode = System.Windows.Forms.DataGridViewEditMode.EditOnEnter;
			this.dataGridViewCorreos.Location = new System.Drawing.Point(12, 367);
			this.dataGridViewCorreos.Name = "dataGridViewCorreos";
			this.dataGridViewCorreos.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Sunken;
			dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
			dataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Control;
			dataGridViewCellStyle4.Font = new System.Drawing.Font("Maiandra GD", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.WindowText;
			dataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight;
			dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
			dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
			this.dataGridViewCorreos.RowHeadersDefaultCellStyle = dataGridViewCellStyle4;
			this.dataGridViewCorreos.RowHeadersVisible = false;
			dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
			dataGridViewCellStyle5.Font = new System.Drawing.Font("Maiandra GD", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.dataGridViewCorreos.RowsDefaultCellStyle = dataGridViewCellStyle5;
			this.dataGridViewCorreos.RowTemplate.Height = 30;
			this.dataGridViewCorreos.Size = new System.Drawing.Size(593, 348);
			this.dataGridViewCorreos.TabIndex = 55;
			this.dataGridViewCorreos.CellContentDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DataGridViewCorreosCellContentDoubleClick);
			this.dataGridViewCorreos.CellEndEdit += new System.Windows.Forms.DataGridViewCellEventHandler(this.DataGridViewCorreosCellEndEdit);
			this.dataGridViewCorreos.RowsAdded += new System.Windows.Forms.DataGridViewRowsAddedEventHandler(this.DataGridViewCorreosRowsAdded);
			// 
			// Correo
			// 
			this.Correo.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
			dataGridViewCellStyle2.Font = new System.Drawing.Font("Maiandra GD", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.Correo.DefaultCellStyle = dataGridViewCellStyle2;
			this.Correo.HeaderText = "CORREO";
			this.Correo.Name = "Correo";
			this.Correo.ToolTipText = "Correos Ingresados Hasta El Momento";
			// 
			// ELIMINAR_CORREO
			// 
			this.ELIMINAR_CORREO.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader;
			this.ELIMINAR_CORREO.HeaderText = "RETIRAR";
			this.ELIMINAR_CORREO.Name = "ELIMINAR_CORREO";
			this.ELIMINAR_CORREO.Width = 73;
			// 
			// dataGridViewTelefono
			// 
			this.dataGridViewTelefono.AllowDrop = true;
			this.dataGridViewTelefono.AllowUserToOrderColumns = true;
			this.dataGridViewTelefono.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
			this.dataGridViewTelefono.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.Sunken;
			this.dataGridViewTelefono.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
			dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
			dataGridViewCellStyle6.BackColor = System.Drawing.SystemColors.Control;
			dataGridViewCellStyle6.Font = new System.Drawing.Font("Maiandra GD", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			dataGridViewCellStyle6.ForeColor = System.Drawing.SystemColors.WindowText;
			dataGridViewCellStyle6.SelectionBackColor = System.Drawing.SystemColors.Highlight;
			dataGridViewCellStyle6.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
			dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
			this.dataGridViewTelefono.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle6;
			this.dataGridViewTelefono.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dataGridViewTelefono.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
			this.Telefono,
			this.ELIMINAR_TELEFONO});
			this.dataGridViewTelefono.EditMode = System.Windows.Forms.DataGridViewEditMode.EditOnEnter;
			this.dataGridViewTelefono.Location = new System.Drawing.Point(625, 130);
			this.dataGridViewTelefono.Name = "dataGridViewTelefono";
			this.dataGridViewTelefono.RowHeadersVisible = false;
			dataGridViewCellStyle8.Font = new System.Drawing.Font("Maiandra GD", 9.75F);
			this.dataGridViewTelefono.RowsDefaultCellStyle = dataGridViewCellStyle8;
			this.dataGridViewTelefono.RowTemplate.Height = 30;
			this.dataGridViewTelefono.Size = new System.Drawing.Size(342, 585);
			this.dataGridViewTelefono.TabIndex = 56;
			this.dataGridViewTelefono.CellContentDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DataGridViewTelefonoCellContentDoubleClick);
			this.dataGridViewTelefono.CellEndEdit += new System.Windows.Forms.DataGridViewCellEventHandler(this.DataGridViewTelefonoCellEndEdit);
			this.dataGridViewTelefono.RowsAdded += new System.Windows.Forms.DataGridViewRowsAddedEventHandler(this.DataGridViewTelefonoRowsAdded);
			// 
			// Telefono
			// 
			this.Telefono.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
			dataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
			dataGridViewCellStyle7.Font = new System.Drawing.Font("Lucida Bright", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.Telefono.DefaultCellStyle = dataGridViewCellStyle7;
			this.Telefono.HeaderText = "TELÉFONO";
			this.Telefono.Name = "Telefono";
			this.Telefono.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
			this.Telefono.ToolTipText = "Teléfonos agregados hasta el momento";
			// 
			// ELIMINAR_TELEFONO
			// 
			this.ELIMINAR_TELEFONO.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader;
			this.ELIMINAR_TELEFONO.HeaderText = "RETIRAR";
			this.ELIMINAR_TELEFONO.Name = "ELIMINAR_TELEFONO";
			this.ELIMINAR_TELEFONO.Width = 73;
			// 
			// panelFondo
			// 
			this.panelFondo.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
			| System.Windows.Forms.AnchorStyles.Left) 
			| System.Windows.Forms.AnchorStyles.Right)));
			this.panelFondo.BackColor = System.Drawing.Color.OrangeRed;
			this.panelFondo.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
			this.panelFondo.Controls.Add(this.labelTitulo);
			this.panelFondo.Location = new System.Drawing.Point(0, 0);
			this.panelFondo.Name = "panelFondo";
			this.panelFondo.Size = new System.Drawing.Size(1352, 100);
			this.panelFondo.TabIndex = 105;
			// 
			// labelTitulo
			// 
			this.labelTitulo.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
			| System.Windows.Forms.AnchorStyles.Left) 
			| System.Windows.Forms.AnchorStyles.Right)));
			this.labelTitulo.BackColor = System.Drawing.Color.Transparent;
			this.labelTitulo.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
			this.labelTitulo.Font = new System.Drawing.Font("Maiandra GD", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.labelTitulo.ForeColor = System.Drawing.Color.White;
			this.labelTitulo.Location = new System.Drawing.Point(334, 17);
			this.labelTitulo.Name = "labelTitulo";
			this.labelTitulo.Size = new System.Drawing.Size(633, 50);
			this.labelTitulo.TabIndex = 1;
			this.labelTitulo.Text = "REGISTRAR EMPLEADOS";
			this.labelTitulo.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// RegistrarEmpleados
			// 
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
			this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
			this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
			this.ClientSize = new System.Drawing.Size(1348, 727);
			this.Controls.Add(this.panelFondo);
			this.Controls.Add(this.dataGridViewTelefono);
			this.Controls.Add(this.dataGridViewCorreos);
			this.Controls.Add(this.comboBoxPuesto);
			this.Controls.Add(this.labelPuesto);
			this.Controls.Add(this.textBoxApellidoMaterno);
			this.Controls.Add(this.labelApellidoMaterno);
			this.Controls.Add(this.textBoxApellidoPaterno);
			this.Controls.Add(this.labelApellidoPaterno);
			this.Controls.Add(this.textBoxNombre);
			this.Controls.Add(this.labelNombre);
			this.Controls.Add(this.textBoxID);
			this.Controls.Add(this.labelID);
			this.Controls.Add(this.buttonLimpiar);
			this.Controls.Add(this.buttonGuardar);
			this.Controls.Add(this.pictureBoxImagenCargada);
			this.Controls.Add(this.buttonCargarImagen);
			this.DoubleBuffered = true;
			this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
			this.MinimumSize = new System.Drawing.Size(1364, 766);
			this.Name = "RegistrarEmpleados";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "SISTEMA MEMÍN® ";
			this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
			this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.RegistrarEmpleadosFormClosing);
			((System.ComponentModel.ISupportInitialize)(this.pictureBoxImagenCargada)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.dataGridViewCorreos)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.dataGridViewTelefono)).EndInit();
			this.panelFondo.ResumeLayout(false);
			this.ResumeLayout(false);
			this.PerformLayout();

		}
	}
}
