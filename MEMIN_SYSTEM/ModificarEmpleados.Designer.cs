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
	partial class ModificarEmpleados
	{
		/// <summary>
		/// Designer variable used to keep track of non-visual components.
		/// </summary>
		private System.ComponentModel.IContainer components = null;
		private System.Windows.Forms.Label labelTitulo;
		private System.Windows.Forms.PictureBox pictureBoxImagenCargada;
		private System.Windows.Forms.Button buttonCargarImagen;
		private System.Windows.Forms.Button buttonModificar;
		private System.Windows.Forms.Label labelID;
		private System.Windows.Forms.TextBox textBoxNombre;
		private System.Windows.Forms.Label labelNombre;
		private System.Windows.Forms.TextBox textBoxApellidoPaterno;
		private System.Windows.Forms.Label labelApellidoPaterno;
		private System.Windows.Forms.TextBox textBoxApellidoMaterno;
		private System.Windows.Forms.Label labelApellidoMaterno;
		private System.Windows.Forms.Label labelPuesto;
		private System.Windows.Forms.ComboBox comboBoxPuesto;
		private System.Windows.Forms.Button buttonVerificarID;
		private System.Windows.Forms.Button buttonModificarNombre;
		private System.Windows.Forms.Button buttonModificarApellidoPaterno;
		private System.Windows.Forms.Button buttonModificarApellidoMaterno;
		private System.Windows.Forms.Button buttonModificarPuesto;
		private System.Windows.Forms.Button buttonModificarImagen;
		private System.Windows.Forms.Panel panelFondo;
		private System.Windows.Forms.NumericUpDown numericUpDownIDEmpleado;
		private System.Windows.Forms.DataGridView dataGridViewTelefono;
		private System.Windows.Forms.DataGridViewTextBoxColumn Telefono;
		private System.Windows.Forms.DataGridViewButtonColumn ELIMINAR_TELEFONO;
		private System.Windows.Forms.DataGridView dataGridViewCorreos;
		private System.Windows.Forms.DataGridViewTextBoxColumn Correo;
		private System.Windows.Forms.DataGridViewButtonColumn ELIMINAR_CORREO;
		private System.Windows.Forms.Button buttonModificarTodosLosCampos;
		
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
			System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
			System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
			System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
			System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
			System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle8 = new System.Windows.Forms.DataGridViewCellStyle();
			System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ModificarEmpleados));
			this.pictureBoxImagenCargada = new System.Windows.Forms.PictureBox();
			this.buttonCargarImagen = new System.Windows.Forms.Button();
			this.buttonModificar = new System.Windows.Forms.Button();
			this.labelID = new System.Windows.Forms.Label();
			this.textBoxNombre = new System.Windows.Forms.TextBox();
			this.labelNombre = new System.Windows.Forms.Label();
			this.textBoxApellidoPaterno = new System.Windows.Forms.TextBox();
			this.labelApellidoPaterno = new System.Windows.Forms.Label();
			this.textBoxApellidoMaterno = new System.Windows.Forms.TextBox();
			this.labelApellidoMaterno = new System.Windows.Forms.Label();
			this.labelPuesto = new System.Windows.Forms.Label();
			this.comboBoxPuesto = new System.Windows.Forms.ComboBox();
			this.buttonVerificarID = new System.Windows.Forms.Button();
			this.buttonModificarNombre = new System.Windows.Forms.Button();
			this.buttonModificarApellidoPaterno = new System.Windows.Forms.Button();
			this.buttonModificarApellidoMaterno = new System.Windows.Forms.Button();
			this.buttonModificarPuesto = new System.Windows.Forms.Button();
			this.buttonModificarImagen = new System.Windows.Forms.Button();
			this.panelFondo = new System.Windows.Forms.Panel();
			this.labelTitulo = new System.Windows.Forms.Label();
			this.numericUpDownIDEmpleado = new System.Windows.Forms.NumericUpDown();
			this.dataGridViewTelefono = new System.Windows.Forms.DataGridView();
			this.Telefono = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.ELIMINAR_TELEFONO = new System.Windows.Forms.DataGridViewButtonColumn();
			this.dataGridViewCorreos = new System.Windows.Forms.DataGridView();
			this.Correo = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.ELIMINAR_CORREO = new System.Windows.Forms.DataGridViewButtonColumn();
			this.buttonModificarTodosLosCampos = new System.Windows.Forms.Button();
			((System.ComponentModel.ISupportInitialize)(this.pictureBoxImagenCargada)).BeginInit();
			this.panelFondo.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.numericUpDownIDEmpleado)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.dataGridViewTelefono)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.dataGridViewCorreos)).BeginInit();
			this.SuspendLayout();
			// 
			// pictureBoxImagenCargada
			// 
			this.pictureBoxImagenCargada.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
			this.pictureBoxImagenCargada.BackColor = System.Drawing.Color.Transparent;
			this.pictureBoxImagenCargada.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
			this.pictureBoxImagenCargada.Location = new System.Drawing.Point(1013, 174);
			this.pictureBoxImagenCargada.Name = "pictureBoxImagenCargada";
			this.pictureBoxImagenCargada.Size = new System.Drawing.Size(300, 300);
			this.pictureBoxImagenCargada.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
			this.pictureBoxImagenCargada.TabIndex = 20;
			this.pictureBoxImagenCargada.TabStop = false;
			// 
			// buttonCargarImagen
			// 
			this.buttonCargarImagen.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
			this.buttonCargarImagen.BackColor = System.Drawing.Color.Transparent;
			this.buttonCargarImagen.Cursor = System.Windows.Forms.Cursors.Hand;
			this.buttonCargarImagen.Enabled = false;
			this.buttonCargarImagen.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.buttonCargarImagen.Font = new System.Drawing.Font("Lucida Bright", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.buttonCargarImagen.ForeColor = System.Drawing.Color.White;
			this.buttonCargarImagen.Location = new System.Drawing.Point(1092, 480);
			this.buttonCargarImagen.Name = "buttonCargarImagen";
			this.buttonCargarImagen.Size = new System.Drawing.Size(160, 60);
			this.buttonCargarImagen.TabIndex = 19;
			this.buttonCargarImagen.Text = "CARGAR IMAGEN";
			this.buttonCargarImagen.UseVisualStyleBackColor = false;
			this.buttonCargarImagen.Click += new System.EventHandler(this.ButtonCargarImagenClick);
			// 
			// buttonModificar
			// 
			this.buttonModificar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
			this.buttonModificar.BackColor = System.Drawing.Color.Transparent;
			this.buttonModificar.Cursor = System.Windows.Forms.Cursors.Hand;
			this.buttonModificar.Enabled = false;
			this.buttonModificar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.buttonModificar.Font = new System.Drawing.Font("Lucida Bright", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.buttonModificar.ForeColor = System.Drawing.Color.White;
			this.buttonModificar.Location = new System.Drawing.Point(1107, 655);
			this.buttonModificar.Name = "buttonModificar";
			this.buttonModificar.Size = new System.Drawing.Size(230, 60);
			this.buttonModificar.TabIndex = 21;
			this.buttonModificar.Text = "MODIFICAR";
			this.buttonModificar.UseVisualStyleBackColor = false;
			this.buttonModificar.Click += new System.EventHandler(this.ButtonModificarClick);
			// 
			// labelID
			// 
			this.labelID.BackColor = System.Drawing.Color.Transparent;
			this.labelID.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
			this.labelID.Font = new System.Drawing.Font("Maiandra GD", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.labelID.ForeColor = System.Drawing.Color.White;
			this.labelID.Location = new System.Drawing.Point(12, 130);
			this.labelID.Name = "labelID";
			this.labelID.Size = new System.Drawing.Size(212, 32);
			this.labelID.TabIndex = 24;
			this.labelID.Text = "ID DEL EMPLEADO:";
			this.labelID.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// textBoxNombre
			// 
			this.textBoxNombre.Enabled = false;
			this.textBoxNombre.Font = new System.Drawing.Font("Maiandra GD", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.textBoxNombre.Location = new System.Drawing.Point(230, 169);
			this.textBoxNombre.MaxLength = 35;
			this.textBoxNombre.Name = "textBoxNombre";
			this.textBoxNombre.ScrollBars = System.Windows.Forms.ScrollBars.Horizontal;
			this.textBoxNombre.Size = new System.Drawing.Size(480, 33);
			this.textBoxNombre.TabIndex = 27;
			this.textBoxNombre.TextChanged += new System.EventHandler(this.TextBoxNombreTextChanged);
			// 
			// labelNombre
			// 
			this.labelNombre.BackColor = System.Drawing.Color.Transparent;
			this.labelNombre.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
			this.labelNombre.Font = new System.Drawing.Font("Maiandra GD", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.labelNombre.ForeColor = System.Drawing.Color.White;
			this.labelNombre.Location = new System.Drawing.Point(12, 170);
			this.labelNombre.Name = "labelNombre";
			this.labelNombre.Size = new System.Drawing.Size(212, 32);
			this.labelNombre.TabIndex = 26;
			this.labelNombre.Text = "NOMBRE:";
			this.labelNombre.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// textBoxApellidoPaterno
			// 
			this.textBoxApellidoPaterno.Enabled = false;
			this.textBoxApellidoPaterno.Font = new System.Drawing.Font("Maiandra GD", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.textBoxApellidoPaterno.Location = new System.Drawing.Point(230, 209);
			this.textBoxApellidoPaterno.MaxLength = 25;
			this.textBoxApellidoPaterno.Name = "textBoxApellidoPaterno";
			this.textBoxApellidoPaterno.ScrollBars = System.Windows.Forms.ScrollBars.Horizontal;
			this.textBoxApellidoPaterno.Size = new System.Drawing.Size(480, 33);
			this.textBoxApellidoPaterno.TabIndex = 29;
			this.textBoxApellidoPaterno.TextChanged += new System.EventHandler(this.TextBoxApellidoPaternoTextChanged);
			// 
			// labelApellidoPaterno
			// 
			this.labelApellidoPaterno.BackColor = System.Drawing.Color.Transparent;
			this.labelApellidoPaterno.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
			this.labelApellidoPaterno.Font = new System.Drawing.Font("Maiandra GD", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.labelApellidoPaterno.ForeColor = System.Drawing.Color.White;
			this.labelApellidoPaterno.Location = new System.Drawing.Point(12, 210);
			this.labelApellidoPaterno.Name = "labelApellidoPaterno";
			this.labelApellidoPaterno.Size = new System.Drawing.Size(212, 32);
			this.labelApellidoPaterno.TabIndex = 28;
			this.labelApellidoPaterno.Text = "A. PATERNO:";
			this.labelApellidoPaterno.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// textBoxApellidoMaterno
			// 
			this.textBoxApellidoMaterno.Enabled = false;
			this.textBoxApellidoMaterno.Font = new System.Drawing.Font("Maiandra GD", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.textBoxApellidoMaterno.Location = new System.Drawing.Point(230, 249);
			this.textBoxApellidoMaterno.MaxLength = 25;
			this.textBoxApellidoMaterno.Name = "textBoxApellidoMaterno";
			this.textBoxApellidoMaterno.ScrollBars = System.Windows.Forms.ScrollBars.Horizontal;
			this.textBoxApellidoMaterno.Size = new System.Drawing.Size(480, 33);
			this.textBoxApellidoMaterno.TabIndex = 31;
			this.textBoxApellidoMaterno.TextChanged += new System.EventHandler(this.TextBoxApellidoMaternoTextChanged);
			// 
			// labelApellidoMaterno
			// 
			this.labelApellidoMaterno.BackColor = System.Drawing.Color.Transparent;
			this.labelApellidoMaterno.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
			this.labelApellidoMaterno.Font = new System.Drawing.Font("Maiandra GD", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.labelApellidoMaterno.ForeColor = System.Drawing.Color.White;
			this.labelApellidoMaterno.Location = new System.Drawing.Point(12, 250);
			this.labelApellidoMaterno.Name = "labelApellidoMaterno";
			this.labelApellidoMaterno.Size = new System.Drawing.Size(212, 32);
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
			this.labelPuesto.Location = new System.Drawing.Point(12, 290);
			this.labelPuesto.Name = "labelPuesto";
			this.labelPuesto.Size = new System.Drawing.Size(212, 32);
			this.labelPuesto.TabIndex = 32;
			this.labelPuesto.Text = "PUESTO:";
			this.labelPuesto.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// comboBoxPuesto
			// 
			this.comboBoxPuesto.Enabled = false;
			this.comboBoxPuesto.Font = new System.Drawing.Font("Maiandra GD", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
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
			this.comboBoxPuesto.Location = new System.Drawing.Point(230, 289);
			this.comboBoxPuesto.Name = "comboBoxPuesto";
			this.comboBoxPuesto.Size = new System.Drawing.Size(480, 33);
			this.comboBoxPuesto.TabIndex = 33;
			this.comboBoxPuesto.Text = "MESERO";
			// 
			// buttonVerificarID
			// 
			this.buttonVerificarID.BackColor = System.Drawing.Color.Transparent;
			this.buttonVerificarID.Cursor = System.Windows.Forms.Cursors.Hand;
			this.buttonVerificarID.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
			this.buttonVerificarID.Font = new System.Drawing.Font("Lucida Bright", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.buttonVerificarID.ForeColor = System.Drawing.Color.White;
			this.buttonVerificarID.Location = new System.Drawing.Point(716, 132);
			this.buttonVerificarID.Name = "buttonVerificarID";
			this.buttonVerificarID.Size = new System.Drawing.Size(142, 32);
			this.buttonVerificarID.TabIndex = 64;
			this.buttonVerificarID.Text = "VERIFICAR ID";
			this.buttonVerificarID.UseVisualStyleBackColor = false;
			this.buttonVerificarID.Click += new System.EventHandler(this.ButtonVerificarIDClick);
			// 
			// buttonModificarNombre
			// 
			this.buttonModificarNombre.BackColor = System.Drawing.Color.Transparent;
			this.buttonModificarNombre.Cursor = System.Windows.Forms.Cursors.Hand;
			this.buttonModificarNombre.Enabled = false;
			this.buttonModificarNombre.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
			this.buttonModificarNombre.Font = new System.Drawing.Font("Maiandra GD", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.buttonModificarNombre.ForeColor = System.Drawing.Color.White;
			this.buttonModificarNombre.Location = new System.Drawing.Point(716, 170);
			this.buttonModificarNombre.Name = "buttonModificarNombre";
			this.buttonModificarNombre.Size = new System.Drawing.Size(142, 32);
			this.buttonModificarNombre.TabIndex = 90;
			this.buttonModificarNombre.Text = "¿MODIFICAR?";
			this.buttonModificarNombre.UseVisualStyleBackColor = false;
			this.buttonModificarNombre.Click += new System.EventHandler(this.ButtonModificarNombreClick);
			// 
			// buttonModificarApellidoPaterno
			// 
			this.buttonModificarApellidoPaterno.BackColor = System.Drawing.Color.Transparent;
			this.buttonModificarApellidoPaterno.Cursor = System.Windows.Forms.Cursors.Hand;
			this.buttonModificarApellidoPaterno.Enabled = false;
			this.buttonModificarApellidoPaterno.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
			this.buttonModificarApellidoPaterno.Font = new System.Drawing.Font("Maiandra GD", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.buttonModificarApellidoPaterno.ForeColor = System.Drawing.Color.White;
			this.buttonModificarApellidoPaterno.Location = new System.Drawing.Point(716, 210);
			this.buttonModificarApellidoPaterno.Name = "buttonModificarApellidoPaterno";
			this.buttonModificarApellidoPaterno.Size = new System.Drawing.Size(142, 32);
			this.buttonModificarApellidoPaterno.TabIndex = 91;
			this.buttonModificarApellidoPaterno.Text = "¿MODIFICAR?";
			this.buttonModificarApellidoPaterno.UseVisualStyleBackColor = false;
			this.buttonModificarApellidoPaterno.Click += new System.EventHandler(this.ButtonModificarApellidoPaternoClick);
			// 
			// buttonModificarApellidoMaterno
			// 
			this.buttonModificarApellidoMaterno.BackColor = System.Drawing.Color.Transparent;
			this.buttonModificarApellidoMaterno.Cursor = System.Windows.Forms.Cursors.Hand;
			this.buttonModificarApellidoMaterno.Enabled = false;
			this.buttonModificarApellidoMaterno.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
			this.buttonModificarApellidoMaterno.Font = new System.Drawing.Font("Maiandra GD", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.buttonModificarApellidoMaterno.ForeColor = System.Drawing.Color.White;
			this.buttonModificarApellidoMaterno.Location = new System.Drawing.Point(716, 250);
			this.buttonModificarApellidoMaterno.Name = "buttonModificarApellidoMaterno";
			this.buttonModificarApellidoMaterno.Size = new System.Drawing.Size(142, 32);
			this.buttonModificarApellidoMaterno.TabIndex = 92;
			this.buttonModificarApellidoMaterno.Text = "¿MODIFICAR?";
			this.buttonModificarApellidoMaterno.UseVisualStyleBackColor = false;
			this.buttonModificarApellidoMaterno.Click += new System.EventHandler(this.ButtonModificarApellidoMaternoClick);
			// 
			// buttonModificarPuesto
			// 
			this.buttonModificarPuesto.BackColor = System.Drawing.Color.Transparent;
			this.buttonModificarPuesto.Cursor = System.Windows.Forms.Cursors.Hand;
			this.buttonModificarPuesto.Enabled = false;
			this.buttonModificarPuesto.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
			this.buttonModificarPuesto.Font = new System.Drawing.Font("Maiandra GD", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.buttonModificarPuesto.ForeColor = System.Drawing.Color.White;
			this.buttonModificarPuesto.Location = new System.Drawing.Point(716, 290);
			this.buttonModificarPuesto.Name = "buttonModificarPuesto";
			this.buttonModificarPuesto.Size = new System.Drawing.Size(142, 32);
			this.buttonModificarPuesto.TabIndex = 93;
			this.buttonModificarPuesto.Text = "¿MODIFICAR?";
			this.buttonModificarPuesto.UseVisualStyleBackColor = false;
			this.buttonModificarPuesto.Click += new System.EventHandler(this.ButtonModificarPuestoClick);
			// 
			// buttonModificarImagen
			// 
			this.buttonModificarImagen.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
			this.buttonModificarImagen.BackColor = System.Drawing.Color.Transparent;
			this.buttonModificarImagen.Cursor = System.Windows.Forms.Cursors.Hand;
			this.buttonModificarImagen.Enabled = false;
			this.buttonModificarImagen.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
			this.buttonModificarImagen.Font = new System.Drawing.Font("Lucida Bright", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.buttonModificarImagen.ForeColor = System.Drawing.Color.White;
			this.buttonModificarImagen.Location = new System.Drawing.Point(1096, 132);
			this.buttonModificarImagen.Name = "buttonModificarImagen";
			this.buttonModificarImagen.Size = new System.Drawing.Size(142, 36);
			this.buttonModificarImagen.TabIndex = 96;
			this.buttonModificarImagen.Text = "¿MODIFICAR?";
			this.buttonModificarImagen.UseVisualStyleBackColor = false;
			this.buttonModificarImagen.Click += new System.EventHandler(this.ButtonModificarImagenClick);
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
			this.panelFondo.Size = new System.Drawing.Size(1353, 100);
			this.panelFondo.TabIndex = 109;
			// 
			// labelTitulo
			// 
			this.labelTitulo.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
			| System.Windows.Forms.AnchorStyles.Right)));
			this.labelTitulo.BackColor = System.Drawing.Color.Transparent;
			this.labelTitulo.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
			this.labelTitulo.Font = new System.Drawing.Font("Maiandra GD", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.labelTitulo.ForeColor = System.Drawing.Color.White;
			this.labelTitulo.Location = new System.Drawing.Point(334, 17);
			this.labelTitulo.Name = "labelTitulo";
			this.labelTitulo.Size = new System.Drawing.Size(634, 56);
			this.labelTitulo.TabIndex = 1;
			this.labelTitulo.Text = "MODIFICAR EMPLEADOS";
			this.labelTitulo.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// numericUpDownIDEmpleado
			// 
			this.numericUpDownIDEmpleado.Font = new System.Drawing.Font("Lucida Bright", 15.75F);
			this.numericUpDownIDEmpleado.Location = new System.Drawing.Point(230, 129);
			this.numericUpDownIDEmpleado.Maximum = new decimal(new int[] {
			100000000,
			0,
			0,
			0});
			this.numericUpDownIDEmpleado.Minimum = new decimal(new int[] {
			2,
			0,
			0,
			0});
			this.numericUpDownIDEmpleado.Name = "numericUpDownIDEmpleado";
			this.numericUpDownIDEmpleado.Size = new System.Drawing.Size(480, 32);
			this.numericUpDownIDEmpleado.TabIndex = 110;
			this.numericUpDownIDEmpleado.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
			this.numericUpDownIDEmpleado.Value = new decimal(new int[] {
			2,
			0,
			0,
			0});
			// 
			// dataGridViewTelefono
			// 
			this.dataGridViewTelefono.AllowDrop = true;
			this.dataGridViewTelefono.AllowUserToOrderColumns = true;
			this.dataGridViewTelefono.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
			this.dataGridViewTelefono.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.Sunken;
			this.dataGridViewTelefono.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
			dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
			dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
			dataGridViewCellStyle1.Font = new System.Drawing.Font("Maiandra GD", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
			dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
			dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
			dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
			this.dataGridViewTelefono.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
			this.dataGridViewTelefono.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dataGridViewTelefono.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
			this.Telefono,
			this.ELIMINAR_TELEFONO});
			this.dataGridViewTelefono.EditMode = System.Windows.Forms.DataGridViewEditMode.EditOnEnter;
			this.dataGridViewTelefono.Enabled = false;
			this.dataGridViewTelefono.Location = new System.Drawing.Point(611, 349);
			this.dataGridViewTelefono.Name = "dataGridViewTelefono";
			this.dataGridViewTelefono.RowHeadersVisible = false;
			dataGridViewCellStyle3.Font = new System.Drawing.Font("Maiandra GD", 9.75F);
			this.dataGridViewTelefono.RowsDefaultCellStyle = dataGridViewCellStyle3;
			this.dataGridViewTelefono.RowTemplate.Height = 30;
			this.dataGridViewTelefono.Size = new System.Drawing.Size(247, 365);
			this.dataGridViewTelefono.TabIndex = 112;
			this.dataGridViewTelefono.CellContentDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DataGridViewTelefonoCellContentDoubleClick);
			this.dataGridViewTelefono.CellEndEdit += new System.Windows.Forms.DataGridViewCellEventHandler(this.DataGridViewTelefonoCellEndEdit);
			this.dataGridViewTelefono.RowsAdded += new System.Windows.Forms.DataGridViewRowsAddedEventHandler(this.DataGridViewTelefonoRowsAdded);
			// 
			// Telefono
			// 
			this.Telefono.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
			dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
			dataGridViewCellStyle2.Font = new System.Drawing.Font("Lucida Bright", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.Telefono.DefaultCellStyle = dataGridViewCellStyle2;
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
			// dataGridViewCorreos
			// 
			this.dataGridViewCorreos.AllowDrop = true;
			this.dataGridViewCorreos.AllowUserToOrderColumns = true;
			this.dataGridViewCorreos.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
			this.dataGridViewCorreos.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
			this.dataGridViewCorreos.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.Sunken;
			dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
			dataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Control;
			dataGridViewCellStyle4.Font = new System.Drawing.Font("Maiandra GD", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.WindowText;
			dataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight;
			dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
			dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
			this.dataGridViewCorreos.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle4;
			this.dataGridViewCorreos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dataGridViewCorreos.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
			this.Correo,
			this.ELIMINAR_CORREO});
			dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
			dataGridViewCellStyle6.BackColor = System.Drawing.SystemColors.Window;
			dataGridViewCellStyle6.Font = new System.Drawing.Font("Maiandra GD", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			dataGridViewCellStyle6.ForeColor = System.Drawing.SystemColors.ControlText;
			dataGridViewCellStyle6.SelectionBackColor = System.Drawing.SystemColors.Highlight;
			dataGridViewCellStyle6.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
			dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
			this.dataGridViewCorreos.DefaultCellStyle = dataGridViewCellStyle6;
			this.dataGridViewCorreos.EditMode = System.Windows.Forms.DataGridViewEditMode.EditOnEnter;
			this.dataGridViewCorreos.Enabled = false;
			this.dataGridViewCorreos.Location = new System.Drawing.Point(12, 349);
			this.dataGridViewCorreos.Name = "dataGridViewCorreos";
			this.dataGridViewCorreos.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Sunken;
			dataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
			dataGridViewCellStyle7.BackColor = System.Drawing.SystemColors.Control;
			dataGridViewCellStyle7.Font = new System.Drawing.Font("Maiandra GD", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			dataGridViewCellStyle7.ForeColor = System.Drawing.SystemColors.WindowText;
			dataGridViewCellStyle7.SelectionBackColor = System.Drawing.SystemColors.Highlight;
			dataGridViewCellStyle7.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
			dataGridViewCellStyle7.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
			this.dataGridViewCorreos.RowHeadersDefaultCellStyle = dataGridViewCellStyle7;
			this.dataGridViewCorreos.RowHeadersVisible = false;
			dataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
			dataGridViewCellStyle8.Font = new System.Drawing.Font("Maiandra GD", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.dataGridViewCorreos.RowsDefaultCellStyle = dataGridViewCellStyle8;
			this.dataGridViewCorreos.RowTemplate.Height = 30;
			this.dataGridViewCorreos.Size = new System.Drawing.Size(516, 366);
			this.dataGridViewCorreos.TabIndex = 111;
			this.dataGridViewCorreos.CellContentDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DataGridViewCorreosCellContentDoubleClick);
			this.dataGridViewCorreos.CellEndEdit += new System.Windows.Forms.DataGridViewCellEventHandler(this.DataGridViewCorreosCellEndEdit);
			this.dataGridViewCorreos.RowsAdded += new System.Windows.Forms.DataGridViewRowsAddedEventHandler(this.DataGridViewCorreosRowsAdded);
			// 
			// Correo
			// 
			this.Correo.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
			dataGridViewCellStyle5.Font = new System.Drawing.Font("Maiandra GD", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.Correo.DefaultCellStyle = dataGridViewCellStyle5;
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
			// buttonModificarTodosLosCampos
			// 
			this.buttonModificarTodosLosCampos.BackColor = System.Drawing.Color.Transparent;
			this.buttonModificarTodosLosCampos.Cursor = System.Windows.Forms.Cursors.Hand;
			this.buttonModificarTodosLosCampos.Enabled = false;
			this.buttonModificarTodosLosCampos.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
			this.buttonModificarTodosLosCampos.Font = new System.Drawing.Font("Maiandra GD", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.buttonModificarTodosLosCampos.ForeColor = System.Drawing.Color.White;
			this.buttonModificarTodosLosCampos.Location = new System.Drawing.Point(898, 633);
			this.buttonModificarTodosLosCampos.Name = "buttonModificarTodosLosCampos";
			this.buttonModificarTodosLosCampos.Size = new System.Drawing.Size(142, 81);
			this.buttonModificarTodosLosCampos.TabIndex = 144;
			this.buttonModificarTodosLosCampos.Text = "¿MODIFICAR TODOS LOS CAMPOS?";
			this.buttonModificarTodosLosCampos.UseVisualStyleBackColor = false;
			this.buttonModificarTodosLosCampos.Click += new System.EventHandler(this.ButtonModificarTodosLosCamposClick);
			// 
			// ModificarEmpleados
			// 
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
			this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
			this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
			this.ClientSize = new System.Drawing.Size(1349, 727);
			this.Controls.Add(this.buttonModificarTodosLosCampos);
			this.Controls.Add(this.dataGridViewTelefono);
			this.Controls.Add(this.dataGridViewCorreos);
			this.Controls.Add(this.numericUpDownIDEmpleado);
			this.Controls.Add(this.panelFondo);
			this.Controls.Add(this.buttonModificarImagen);
			this.Controls.Add(this.buttonModificarPuesto);
			this.Controls.Add(this.buttonModificarApellidoMaterno);
			this.Controls.Add(this.buttonModificarApellidoPaterno);
			this.Controls.Add(this.buttonModificarNombre);
			this.Controls.Add(this.buttonVerificarID);
			this.Controls.Add(this.comboBoxPuesto);
			this.Controls.Add(this.labelPuesto);
			this.Controls.Add(this.textBoxApellidoMaterno);
			this.Controls.Add(this.labelApellidoMaterno);
			this.Controls.Add(this.textBoxApellidoPaterno);
			this.Controls.Add(this.labelApellidoPaterno);
			this.Controls.Add(this.textBoxNombre);
			this.Controls.Add(this.labelNombre);
			this.Controls.Add(this.labelID);
			this.Controls.Add(this.buttonModificar);
			this.Controls.Add(this.pictureBoxImagenCargada);
			this.Controls.Add(this.buttonCargarImagen);
			this.DoubleBuffered = true;
			this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
			this.MinimumSize = new System.Drawing.Size(1364, 766);
			this.Name = "ModificarEmpleados";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "SISTEMA MEMÍN® ";
			this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
			this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.ModificarEmpleadosFormClosing);
			((System.ComponentModel.ISupportInitialize)(this.pictureBoxImagenCargada)).EndInit();
			this.panelFondo.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.numericUpDownIDEmpleado)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.dataGridViewTelefono)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.dataGridViewCorreos)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

		}
	}
}
