/*
 * Creado por SharpDevelop.
 * Usuario: Brian Gaytan Lomeli
 * Fecha: 21/10/2019
 * Hora: 9:33
 * 
 * Para cambiar esta plantilla use Herramientas | Opciones | Codificación | Editar Encabezados Estándar
 */
namespace MEMIN_SYSTEM
{
	partial class ModificarProductos
	{
		/// <summary>
		/// Designer variable used to keep track of non-visual components.
		/// </summary>
		private System.ComponentModel.IContainer components = null;
		private System.Windows.Forms.Label labelTitulo;
		private System.Windows.Forms.Label labelID;
		private System.Windows.Forms.Label labelNombre;
		private System.Windows.Forms.Label labelTipo;
		private System.Windows.Forms.Label labelCosto;
		private System.Windows.Forms.Label labelDisponibilidad;
		private System.Windows.Forms.Label labelDescripcion;
		private System.Windows.Forms.Label labelObservaciones;
		private System.Windows.Forms.TextBox textBoxNombre;
		private System.Windows.Forms.TextBox textBoxDescripcion;
		private System.Windows.Forms.TextBox textBoxObservaciones;
		private System.Windows.Forms.ComboBox comboBoxTipo;
		private System.Windows.Forms.ComboBox comboBoxDisponibilidad;
		private System.Windows.Forms.NumericUpDown numericUpDownCosto;
		private System.Windows.Forms.Button buttonCargarImagen;
		private System.Windows.Forms.PictureBox pictureBoxImagenCargada;
		private System.Windows.Forms.Button buttonModificar;
		private System.Windows.Forms.Button buttonVerificarID;
		private System.Windows.Forms.Button buttonModificarNombre;
		private System.Windows.Forms.Button buttonModificarTipo;
		private System.Windows.Forms.Button buttonModificarCosto;
		private System.Windows.Forms.Button buttonModificarDisponibilidad;
		private System.Windows.Forms.Button buttonModificarDescripcion;
		private System.Windows.Forms.Button buttonModificarObservaciones;
		private System.Windows.Forms.Button buttonModificarImagen;
		private System.Windows.Forms.Panel panelFondo;
		private System.Windows.Forms.NumericUpDown numericUpDownIDProducto;
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ModificarProductos));
			this.labelID = new System.Windows.Forms.Label();
			this.labelNombre = new System.Windows.Forms.Label();
			this.labelTipo = new System.Windows.Forms.Label();
			this.labelCosto = new System.Windows.Forms.Label();
			this.labelDisponibilidad = new System.Windows.Forms.Label();
			this.labelDescripcion = new System.Windows.Forms.Label();
			this.labelObservaciones = new System.Windows.Forms.Label();
			this.textBoxNombre = new System.Windows.Forms.TextBox();
			this.textBoxDescripcion = new System.Windows.Forms.TextBox();
			this.textBoxObservaciones = new System.Windows.Forms.TextBox();
			this.comboBoxTipo = new System.Windows.Forms.ComboBox();
			this.comboBoxDisponibilidad = new System.Windows.Forms.ComboBox();
			this.numericUpDownCosto = new System.Windows.Forms.NumericUpDown();
			this.buttonCargarImagen = new System.Windows.Forms.Button();
			this.pictureBoxImagenCargada = new System.Windows.Forms.PictureBox();
			this.buttonModificar = new System.Windows.Forms.Button();
			this.buttonVerificarID = new System.Windows.Forms.Button();
			this.buttonModificarNombre = new System.Windows.Forms.Button();
			this.buttonModificarTipo = new System.Windows.Forms.Button();
			this.buttonModificarCosto = new System.Windows.Forms.Button();
			this.buttonModificarDisponibilidad = new System.Windows.Forms.Button();
			this.buttonModificarDescripcion = new System.Windows.Forms.Button();
			this.buttonModificarObservaciones = new System.Windows.Forms.Button();
			this.buttonModificarImagen = new System.Windows.Forms.Button();
			this.panelFondo = new System.Windows.Forms.Panel();
			this.labelTitulo = new System.Windows.Forms.Label();
			this.numericUpDownIDProducto = new System.Windows.Forms.NumericUpDown();
			this.buttonModificarTodosLosCampos = new System.Windows.Forms.Button();
			((System.ComponentModel.ISupportInitialize)(this.numericUpDownCosto)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.pictureBoxImagenCargada)).BeginInit();
			this.panelFondo.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.numericUpDownIDProducto)).BeginInit();
			this.SuspendLayout();
			// 
			// labelID
			// 
			this.labelID.BackColor = System.Drawing.Color.Transparent;
			this.labelID.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
			this.labelID.Font = new System.Drawing.Font("Maiandra GD", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.labelID.ForeColor = System.Drawing.Color.White;
			this.labelID.Location = new System.Drawing.Point(12, 130);
			this.labelID.Name = "labelID";
			this.labelID.Size = new System.Drawing.Size(200, 36);
			this.labelID.TabIndex = 3;
			this.labelID.Text = "ID DE PRODUCTO:";
			this.labelID.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// labelNombre
			// 
			this.labelNombre.BackColor = System.Drawing.Color.Transparent;
			this.labelNombre.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
			this.labelNombre.Font = new System.Drawing.Font("Maiandra GD", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.labelNombre.ForeColor = System.Drawing.Color.White;
			this.labelNombre.Location = new System.Drawing.Point(14, 185);
			this.labelNombre.Name = "labelNombre";
			this.labelNombre.Size = new System.Drawing.Size(200, 36);
			this.labelNombre.TabIndex = 4;
			this.labelNombre.Text = "NOMBRE:";
			this.labelNombre.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// labelTipo
			// 
			this.labelTipo.BackColor = System.Drawing.Color.Transparent;
			this.labelTipo.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
			this.labelTipo.Font = new System.Drawing.Font("Maiandra GD", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.labelTipo.ForeColor = System.Drawing.Color.White;
			this.labelTipo.Location = new System.Drawing.Point(12, 252);
			this.labelTipo.Name = "labelTipo";
			this.labelTipo.Size = new System.Drawing.Size(200, 36);
			this.labelTipo.TabIndex = 5;
			this.labelTipo.Text = "TIPO:";
			this.labelTipo.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// labelCosto
			// 
			this.labelCosto.BackColor = System.Drawing.Color.Transparent;
			this.labelCosto.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
			this.labelCosto.Font = new System.Drawing.Font("Maiandra GD", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.labelCosto.ForeColor = System.Drawing.Color.White;
			this.labelCosto.Location = new System.Drawing.Point(14, 316);
			this.labelCosto.Name = "labelCosto";
			this.labelCosto.Size = new System.Drawing.Size(200, 36);
			this.labelCosto.TabIndex = 6;
			this.labelCosto.Text = "COSTO:";
			this.labelCosto.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// labelDisponibilidad
			// 
			this.labelDisponibilidad.BackColor = System.Drawing.Color.Transparent;
			this.labelDisponibilidad.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
			this.labelDisponibilidad.Font = new System.Drawing.Font("Maiandra GD", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.labelDisponibilidad.ForeColor = System.Drawing.Color.White;
			this.labelDisponibilidad.Location = new System.Drawing.Point(12, 386);
			this.labelDisponibilidad.Name = "labelDisponibilidad";
			this.labelDisponibilidad.Size = new System.Drawing.Size(200, 36);
			this.labelDisponibilidad.TabIndex = 7;
			this.labelDisponibilidad.Text = "DISPONIBILIDAD:";
			this.labelDisponibilidad.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// labelDescripcion
			// 
			this.labelDescripcion.BackColor = System.Drawing.Color.Transparent;
			this.labelDescripcion.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
			this.labelDescripcion.Font = new System.Drawing.Font("Maiandra GD", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.labelDescripcion.ForeColor = System.Drawing.Color.White;
			this.labelDescripcion.Location = new System.Drawing.Point(12, 463);
			this.labelDescripcion.Name = "labelDescripcion";
			this.labelDescripcion.Size = new System.Drawing.Size(200, 36);
			this.labelDescripcion.TabIndex = 8;
			this.labelDescripcion.Text = "DESCRIPCIÓN:";
			this.labelDescripcion.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// labelObservaciones
			// 
			this.labelObservaciones.BackColor = System.Drawing.Color.Transparent;
			this.labelObservaciones.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
			this.labelObservaciones.Font = new System.Drawing.Font("Maiandra GD", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.labelObservaciones.ForeColor = System.Drawing.Color.White;
			this.labelObservaciones.Location = new System.Drawing.Point(12, 607);
			this.labelObservaciones.Name = "labelObservaciones";
			this.labelObservaciones.Size = new System.Drawing.Size(200, 36);
			this.labelObservaciones.TabIndex = 9;
			this.labelObservaciones.Text = "OBSERVACIONES:";
			this.labelObservaciones.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// textBoxNombre
			// 
			this.textBoxNombre.Enabled = false;
			this.textBoxNombre.Font = new System.Drawing.Font("Maiandra GD", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.textBoxNombre.Location = new System.Drawing.Point(220, 185);
			this.textBoxNombre.MaxLength = 50;
			this.textBoxNombre.Name = "textBoxNombre";
			this.textBoxNombre.ScrollBars = System.Windows.Forms.ScrollBars.Horizontal;
			this.textBoxNombre.Size = new System.Drawing.Size(498, 36);
			this.textBoxNombre.TabIndex = 11;
			this.textBoxNombre.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
			this.textBoxNombre.TextChanged += new System.EventHandler(this.TextBoxNombreTextChanged);
			// 
			// textBoxDescripcion
			// 
			this.textBoxDescripcion.Enabled = false;
			this.textBoxDescripcion.Font = new System.Drawing.Font("Maiandra GD", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.textBoxDescripcion.Location = new System.Drawing.Point(220, 463);
			this.textBoxDescripcion.Multiline = true;
			this.textBoxDescripcion.Name = "textBoxDescripcion";
			this.textBoxDescripcion.ScrollBars = System.Windows.Forms.ScrollBars.Both;
			this.textBoxDescripcion.Size = new System.Drawing.Size(500, 108);
			this.textBoxDescripcion.TabIndex = 12;
			// 
			// textBoxObservaciones
			// 
			this.textBoxObservaciones.Enabled = false;
			this.textBoxObservaciones.Font = new System.Drawing.Font("Maiandra GD", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.textBoxObservaciones.Location = new System.Drawing.Point(220, 607);
			this.textBoxObservaciones.Multiline = true;
			this.textBoxObservaciones.Name = "textBoxObservaciones";
			this.textBoxObservaciones.ScrollBars = System.Windows.Forms.ScrollBars.Both;
			this.textBoxObservaciones.Size = new System.Drawing.Size(500, 108);
			this.textBoxObservaciones.TabIndex = 13;
			// 
			// comboBoxTipo
			// 
			this.comboBoxTipo.Enabled = false;
			this.comboBoxTipo.Font = new System.Drawing.Font("Maiandra GD", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.comboBoxTipo.FormattingEnabled = true;
			this.comboBoxTipo.Items.AddRange(new object[] {
			"Mariscos",
			"Japonesa",
			"Bebida",
			"Postre"});
			this.comboBoxTipo.Location = new System.Drawing.Point(218, 252);
			this.comboBoxTipo.Name = "comboBoxTipo";
			this.comboBoxTipo.Size = new System.Drawing.Size(500, 37);
			this.comboBoxTipo.TabIndex = 14;
			// 
			// comboBoxDisponibilidad
			// 
			this.comboBoxDisponibilidad.Enabled = false;
			this.comboBoxDisponibilidad.Font = new System.Drawing.Font("Maiandra GD", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.comboBoxDisponibilidad.FormattingEnabled = true;
			this.comboBoxDisponibilidad.Items.AddRange(new object[] {
			"DISPONIBLE",
			"NO DISPONIBLE"});
			this.comboBoxDisponibilidad.Location = new System.Drawing.Point(218, 386);
			this.comboBoxDisponibilidad.Name = "comboBoxDisponibilidad";
			this.comboBoxDisponibilidad.Size = new System.Drawing.Size(500, 37);
			this.comboBoxDisponibilidad.TabIndex = 15;
			this.comboBoxDisponibilidad.Text = "DISPONIBLE";
			// 
			// numericUpDownCosto
			// 
			this.numericUpDownCosto.DecimalPlaces = 2;
			this.numericUpDownCosto.Enabled = false;
			this.numericUpDownCosto.Font = new System.Drawing.Font("Lucida Bright", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.numericUpDownCosto.Location = new System.Drawing.Point(220, 316);
			this.numericUpDownCosto.Maximum = new decimal(new int[] {
			1410065407,
			2,
			0,
			0});
			this.numericUpDownCosto.Name = "numericUpDownCosto";
			this.numericUpDownCosto.Size = new System.Drawing.Size(500, 36);
			this.numericUpDownCosto.TabIndex = 16;
			this.numericUpDownCosto.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
			// 
			// buttonCargarImagen
			// 
			this.buttonCargarImagen.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
			this.buttonCargarImagen.BackColor = System.Drawing.Color.Transparent;
			this.buttonCargarImagen.Cursor = System.Windows.Forms.Cursors.Hand;
			this.buttonCargarImagen.Enabled = false;
			this.buttonCargarImagen.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
			this.buttonCargarImagen.Font = new System.Drawing.Font("Maiandra GD", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.buttonCargarImagen.ForeColor = System.Drawing.Color.White;
			this.buttonCargarImagen.Location = new System.Drawing.Point(1081, 463);
			this.buttonCargarImagen.Name = "buttonCargarImagen";
			this.buttonCargarImagen.Size = new System.Drawing.Size(160, 60);
			this.buttonCargarImagen.TabIndex = 17;
			this.buttonCargarImagen.Text = "CARGAR IMAGEN";
			this.buttonCargarImagen.UseVisualStyleBackColor = false;
			this.buttonCargarImagen.Click += new System.EventHandler(this.ButtonCargarImagenClick);
			// 
			// pictureBoxImagenCargada
			// 
			this.pictureBoxImagenCargada.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
			this.pictureBoxImagenCargada.BackColor = System.Drawing.Color.Transparent;
			this.pictureBoxImagenCargada.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
			this.pictureBoxImagenCargada.Location = new System.Drawing.Point(1006, 157);
			this.pictureBoxImagenCargada.Name = "pictureBoxImagenCargada";
			this.pictureBoxImagenCargada.Size = new System.Drawing.Size(300, 300);
			this.pictureBoxImagenCargada.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
			this.pictureBoxImagenCargada.TabIndex = 18;
			this.pictureBoxImagenCargada.TabStop = false;
			// 
			// buttonModificar
			// 
			this.buttonModificar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
			this.buttonModificar.BackColor = System.Drawing.Color.Transparent;
			this.buttonModificar.Cursor = System.Windows.Forms.Cursors.Hand;
			this.buttonModificar.Enabled = false;
			this.buttonModificar.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
			this.buttonModificar.Font = new System.Drawing.Font("Maiandra GD", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.buttonModificar.ForeColor = System.Drawing.Color.White;
			this.buttonModificar.Location = new System.Drawing.Point(1146, 655);
			this.buttonModificar.Name = "buttonModificar";
			this.buttonModificar.Size = new System.Drawing.Size(190, 60);
			this.buttonModificar.TabIndex = 20;
			this.buttonModificar.Text = "MODIFICAR";
			this.buttonModificar.UseVisualStyleBackColor = false;
			this.buttonModificar.Click += new System.EventHandler(this.ButtonModificarClick);
			// 
			// buttonVerificarID
			// 
			this.buttonVerificarID.BackColor = System.Drawing.Color.Transparent;
			this.buttonVerificarID.Cursor = System.Windows.Forms.Cursors.Hand;
			this.buttonVerificarID.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
			this.buttonVerificarID.Font = new System.Drawing.Font("Maiandra GD", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.buttonVerificarID.ForeColor = System.Drawing.Color.White;
			this.buttonVerificarID.Location = new System.Drawing.Point(735, 130);
			this.buttonVerificarID.Name = "buttonVerificarID";
			this.buttonVerificarID.Size = new System.Drawing.Size(142, 36);
			this.buttonVerificarID.TabIndex = 26;
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
			this.buttonModificarNombre.Location = new System.Drawing.Point(735, 187);
			this.buttonModificarNombre.Name = "buttonModificarNombre";
			this.buttonModificarNombre.Size = new System.Drawing.Size(142, 36);
			this.buttonModificarNombre.TabIndex = 72;
			this.buttonModificarNombre.Text = "¿MODIFICAR?";
			this.buttonModificarNombre.UseVisualStyleBackColor = false;
			this.buttonModificarNombre.Click += new System.EventHandler(this.ButtonModificarNombreClick);
			// 
			// buttonModificarTipo
			// 
			this.buttonModificarTipo.BackColor = System.Drawing.Color.Transparent;
			this.buttonModificarTipo.Cursor = System.Windows.Forms.Cursors.Hand;
			this.buttonModificarTipo.Enabled = false;
			this.buttonModificarTipo.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
			this.buttonModificarTipo.Font = new System.Drawing.Font("Maiandra GD", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.buttonModificarTipo.ForeColor = System.Drawing.Color.White;
			this.buttonModificarTipo.Location = new System.Drawing.Point(735, 254);
			this.buttonModificarTipo.Name = "buttonModificarTipo";
			this.buttonModificarTipo.Size = new System.Drawing.Size(142, 36);
			this.buttonModificarTipo.TabIndex = 73;
			this.buttonModificarTipo.Text = "¿MODIFICAR?";
			this.buttonModificarTipo.UseVisualStyleBackColor = false;
			this.buttonModificarTipo.Click += new System.EventHandler(this.ButtonModificarTipoClick);
			// 
			// buttonModificarCosto
			// 
			this.buttonModificarCosto.BackColor = System.Drawing.Color.Transparent;
			this.buttonModificarCosto.Cursor = System.Windows.Forms.Cursors.Hand;
			this.buttonModificarCosto.Enabled = false;
			this.buttonModificarCosto.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
			this.buttonModificarCosto.Font = new System.Drawing.Font("Maiandra GD", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.buttonModificarCosto.ForeColor = System.Drawing.Color.White;
			this.buttonModificarCosto.Location = new System.Drawing.Point(735, 320);
			this.buttonModificarCosto.Name = "buttonModificarCosto";
			this.buttonModificarCosto.Size = new System.Drawing.Size(142, 36);
			this.buttonModificarCosto.TabIndex = 74;
			this.buttonModificarCosto.Text = "¿MODIFICAR?";
			this.buttonModificarCosto.UseVisualStyleBackColor = false;
			this.buttonModificarCosto.Click += new System.EventHandler(this.ButtonModificarCostoClick);
			// 
			// buttonModificarDisponibilidad
			// 
			this.buttonModificarDisponibilidad.BackColor = System.Drawing.Color.Transparent;
			this.buttonModificarDisponibilidad.Cursor = System.Windows.Forms.Cursors.Hand;
			this.buttonModificarDisponibilidad.Enabled = false;
			this.buttonModificarDisponibilidad.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
			this.buttonModificarDisponibilidad.Font = new System.Drawing.Font("Maiandra GD", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.buttonModificarDisponibilidad.ForeColor = System.Drawing.Color.White;
			this.buttonModificarDisponibilidad.Location = new System.Drawing.Point(735, 388);
			this.buttonModificarDisponibilidad.Name = "buttonModificarDisponibilidad";
			this.buttonModificarDisponibilidad.Size = new System.Drawing.Size(142, 36);
			this.buttonModificarDisponibilidad.TabIndex = 75;
			this.buttonModificarDisponibilidad.Text = "¿MODIFICAR?";
			this.buttonModificarDisponibilidad.UseVisualStyleBackColor = false;
			this.buttonModificarDisponibilidad.Click += new System.EventHandler(this.ButtonModificarDisponibilidadClick);
			// 
			// buttonModificarDescripcion
			// 
			this.buttonModificarDescripcion.BackColor = System.Drawing.Color.Transparent;
			this.buttonModificarDescripcion.Cursor = System.Windows.Forms.Cursors.Hand;
			this.buttonModificarDescripcion.Enabled = false;
			this.buttonModificarDescripcion.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
			this.buttonModificarDescripcion.Font = new System.Drawing.Font("Maiandra GD", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.buttonModificarDescripcion.ForeColor = System.Drawing.Color.White;
			this.buttonModificarDescripcion.Location = new System.Drawing.Point(735, 497);
			this.buttonModificarDescripcion.Name = "buttonModificarDescripcion";
			this.buttonModificarDescripcion.Size = new System.Drawing.Size(142, 36);
			this.buttonModificarDescripcion.TabIndex = 76;
			this.buttonModificarDescripcion.Text = "¿MODIFICAR?";
			this.buttonModificarDescripcion.UseVisualStyleBackColor = false;
			this.buttonModificarDescripcion.Click += new System.EventHandler(this.ButtonModificarDescripcionClick);
			// 
			// buttonModificarObservaciones
			// 
			this.buttonModificarObservaciones.BackColor = System.Drawing.Color.Transparent;
			this.buttonModificarObservaciones.Cursor = System.Windows.Forms.Cursors.Hand;
			this.buttonModificarObservaciones.Enabled = false;
			this.buttonModificarObservaciones.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
			this.buttonModificarObservaciones.Font = new System.Drawing.Font("Maiandra GD", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.buttonModificarObservaciones.ForeColor = System.Drawing.Color.White;
			this.buttonModificarObservaciones.Location = new System.Drawing.Point(735, 637);
			this.buttonModificarObservaciones.Name = "buttonModificarObservaciones";
			this.buttonModificarObservaciones.Size = new System.Drawing.Size(142, 36);
			this.buttonModificarObservaciones.TabIndex = 77;
			this.buttonModificarObservaciones.Text = "¿MODIFICAR?";
			this.buttonModificarObservaciones.UseVisualStyleBackColor = false;
			this.buttonModificarObservaciones.Click += new System.EventHandler(this.ButtonModificarObservacionesClick);
			// 
			// buttonModificarImagen
			// 
			this.buttonModificarImagen.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
			this.buttonModificarImagen.BackColor = System.Drawing.Color.Transparent;
			this.buttonModificarImagen.Cursor = System.Windows.Forms.Cursors.Hand;
			this.buttonModificarImagen.Enabled = false;
			this.buttonModificarImagen.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
			this.buttonModificarImagen.Font = new System.Drawing.Font("Maiandra GD", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.buttonModificarImagen.ForeColor = System.Drawing.Color.White;
			this.buttonModificarImagen.Location = new System.Drawing.Point(1099, 115);
			this.buttonModificarImagen.Name = "buttonModificarImagen";
			this.buttonModificarImagen.Size = new System.Drawing.Size(142, 36);
			this.buttonModificarImagen.TabIndex = 79;
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
			this.panelFondo.Size = new System.Drawing.Size(1352, 100);
			this.panelFondo.TabIndex = 108;
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
			this.labelTitulo.Size = new System.Drawing.Size(633, 56);
			this.labelTitulo.TabIndex = 1;
			this.labelTitulo.Text = "MODIFICAR PRODUCTOS";
			this.labelTitulo.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// numericUpDownIDProducto
			// 
			this.numericUpDownIDProducto.Font = new System.Drawing.Font("Lucida Bright", 15.75F);
			this.numericUpDownIDProducto.Location = new System.Drawing.Point(220, 130);
			this.numericUpDownIDProducto.Maximum = new decimal(new int[] {
			100000000,
			0,
			0,
			0});
			this.numericUpDownIDProducto.Minimum = new decimal(new int[] {
			1,
			0,
			0,
			0});
			this.numericUpDownIDProducto.Name = "numericUpDownIDProducto";
			this.numericUpDownIDProducto.Size = new System.Drawing.Size(498, 32);
			this.numericUpDownIDProducto.TabIndex = 109;
			this.numericUpDownIDProducto.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
			this.numericUpDownIDProducto.Value = new decimal(new int[] {
			1,
			0,
			0,
			0});
			// 
			// buttonModificarTodosLosCampos
			// 
			this.buttonModificarTodosLosCampos.BackColor = System.Drawing.Color.Transparent;
			this.buttonModificarTodosLosCampos.Cursor = System.Windows.Forms.Cursors.Hand;
			this.buttonModificarTodosLosCampos.Enabled = false;
			this.buttonModificarTodosLosCampos.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
			this.buttonModificarTodosLosCampos.Font = new System.Drawing.Font("Maiandra GD", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.buttonModificarTodosLosCampos.ForeColor = System.Drawing.Color.White;
			this.buttonModificarTodosLosCampos.Location = new System.Drawing.Point(923, 634);
			this.buttonModificarTodosLosCampos.Name = "buttonModificarTodosLosCampos";
			this.buttonModificarTodosLosCampos.Size = new System.Drawing.Size(142, 81);
			this.buttonModificarTodosLosCampos.TabIndex = 144;
			this.buttonModificarTodosLosCampos.Text = "¿MODIFICAR TODOS LOS CAMPOS?";
			this.buttonModificarTodosLosCampos.UseVisualStyleBackColor = false;
			this.buttonModificarTodosLosCampos.Click += new System.EventHandler(this.ButtonModificarTodosLosCamposClick);
			// 
			// ModificarProductos
			// 
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
			this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
			this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
			this.ClientSize = new System.Drawing.Size(1348, 727);
			this.Controls.Add(this.buttonModificarTodosLosCampos);
			this.Controls.Add(this.numericUpDownIDProducto);
			this.Controls.Add(this.panelFondo);
			this.Controls.Add(this.buttonModificarImagen);
			this.Controls.Add(this.buttonModificarObservaciones);
			this.Controls.Add(this.buttonModificarDescripcion);
			this.Controls.Add(this.buttonModificarDisponibilidad);
			this.Controls.Add(this.buttonModificarCosto);
			this.Controls.Add(this.buttonModificarTipo);
			this.Controls.Add(this.buttonModificarNombre);
			this.Controls.Add(this.buttonVerificarID);
			this.Controls.Add(this.buttonModificar);
			this.Controls.Add(this.pictureBoxImagenCargada);
			this.Controls.Add(this.buttonCargarImagen);
			this.Controls.Add(this.numericUpDownCosto);
			this.Controls.Add(this.comboBoxDisponibilidad);
			this.Controls.Add(this.comboBoxTipo);
			this.Controls.Add(this.textBoxObservaciones);
			this.Controls.Add(this.textBoxDescripcion);
			this.Controls.Add(this.textBoxNombre);
			this.Controls.Add(this.labelObservaciones);
			this.Controls.Add(this.labelDescripcion);
			this.Controls.Add(this.labelDisponibilidad);
			this.Controls.Add(this.labelCosto);
			this.Controls.Add(this.labelTipo);
			this.Controls.Add(this.labelNombre);
			this.Controls.Add(this.labelID);
			this.DoubleBuffered = true;
			this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
			this.MaximizeBox = false;
			this.MinimumSize = new System.Drawing.Size(1364, 766);
			this.Name = "ModificarProductos";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "SISTEMA MEMÍN® ";
			this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
			this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.ModificarProductosFormClosing);
			((System.ComponentModel.ISupportInitialize)(this.numericUpDownCosto)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.pictureBoxImagenCargada)).EndInit();
			this.panelFondo.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.numericUpDownIDProducto)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

		}
	}
}
