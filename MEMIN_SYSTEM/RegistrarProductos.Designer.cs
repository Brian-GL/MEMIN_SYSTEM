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
	partial class RegistrarProductos
	{
		/// <summary>
		/// Designer variable used to keep track of non-visual components.
		/// </summary>
		private System.ComponentModel.IContainer components = null;
		private System.Windows.Forms.Label labelID;
		private System.Windows.Forms.Label labelNombre;
		private System.Windows.Forms.Label labelTipo;
		private System.Windows.Forms.Label labelCosto;
		private System.Windows.Forms.Label labelDisponibilidad;
		private System.Windows.Forms.Label labelDescripcion;
		private System.Windows.Forms.Label labelObservaciones;
		private System.Windows.Forms.TextBox textBoxID;
		private System.Windows.Forms.TextBox textBoxNombre;
		private System.Windows.Forms.TextBox textBoxDescripcion;
		private System.Windows.Forms.TextBox textBoxObservaciones;
		private System.Windows.Forms.ComboBox comboBoxTipo;
		private System.Windows.Forms.ComboBox comboBoxDisponibilidad;
		private System.Windows.Forms.NumericUpDown numericUpDownCosto;
		private System.Windows.Forms.Button buttonCargarImagen;
		private System.Windows.Forms.PictureBox pictureBoxImagenCargada;
		private System.Windows.Forms.Button buttonGuardar;
		private System.Windows.Forms.Button buttonLimpiar;
		private System.Windows.Forms.Panel panelFondo;
		private System.Windows.Forms.Label labelTitulo;
		
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(RegistrarProductos));
			this.labelID = new System.Windows.Forms.Label();
			this.labelNombre = new System.Windows.Forms.Label();
			this.labelTipo = new System.Windows.Forms.Label();
			this.labelCosto = new System.Windows.Forms.Label();
			this.labelDisponibilidad = new System.Windows.Forms.Label();
			this.labelDescripcion = new System.Windows.Forms.Label();
			this.labelObservaciones = new System.Windows.Forms.Label();
			this.textBoxID = new System.Windows.Forms.TextBox();
			this.textBoxNombre = new System.Windows.Forms.TextBox();
			this.textBoxDescripcion = new System.Windows.Forms.TextBox();
			this.textBoxObservaciones = new System.Windows.Forms.TextBox();
			this.comboBoxTipo = new System.Windows.Forms.ComboBox();
			this.comboBoxDisponibilidad = new System.Windows.Forms.ComboBox();
			this.numericUpDownCosto = new System.Windows.Forms.NumericUpDown();
			this.buttonCargarImagen = new System.Windows.Forms.Button();
			this.pictureBoxImagenCargada = new System.Windows.Forms.PictureBox();
			this.buttonGuardar = new System.Windows.Forms.Button();
			this.buttonLimpiar = new System.Windows.Forms.Button();
			this.panelFondo = new System.Windows.Forms.Panel();
			this.labelTitulo = new System.Windows.Forms.Label();
			((System.ComponentModel.ISupportInitialize)(this.numericUpDownCosto)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.pictureBoxImagenCargada)).BeginInit();
			this.panelFondo.SuspendLayout();
			this.SuspendLayout();
			// 
			// labelID
			// 
			this.labelID.BackColor = System.Drawing.Color.Transparent;
			this.labelID.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
			this.labelID.Font = new System.Drawing.Font("Maiandra GD", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.labelID.ForeColor = System.Drawing.Color.White;
			this.labelID.Location = new System.Drawing.Point(12, 140);
			this.labelID.Name = "labelID";
			this.labelID.Size = new System.Drawing.Size(200, 36);
			this.labelID.TabIndex = 3;
			this.labelID.Text = "ID:";
			this.labelID.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// labelNombre
			// 
			this.labelNombre.BackColor = System.Drawing.Color.Transparent;
			this.labelNombre.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
			this.labelNombre.Font = new System.Drawing.Font("Maiandra GD", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.labelNombre.ForeColor = System.Drawing.Color.White;
			this.labelNombre.Location = new System.Drawing.Point(9, 191);
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
			this.labelTipo.Location = new System.Drawing.Point(9, 248);
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
			this.labelCosto.Location = new System.Drawing.Point(9, 315);
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
			this.labelDisponibilidad.Location = new System.Drawing.Point(9, 376);
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
			this.labelDescripcion.Location = new System.Drawing.Point(9, 460);
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
			this.labelObservaciones.Location = new System.Drawing.Point(9, 607);
			this.labelObservaciones.Name = "labelObservaciones";
			this.labelObservaciones.Size = new System.Drawing.Size(200, 36);
			this.labelObservaciones.TabIndex = 9;
			this.labelObservaciones.Text = "OBSERVACIONES:";
			this.labelObservaciones.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// textBoxID
			// 
			this.textBoxID.Enabled = false;
			this.textBoxID.Font = new System.Drawing.Font("Maiandra GD", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.textBoxID.Location = new System.Drawing.Point(215, 140);
			this.textBoxID.Name = "textBoxID";
			this.textBoxID.ReadOnly = true;
			this.textBoxID.ScrollBars = System.Windows.Forms.ScrollBars.Horizontal;
			this.textBoxID.Size = new System.Drawing.Size(742, 36);
			this.textBoxID.TabIndex = 10;
			this.textBoxID.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
			// 
			// textBoxNombre
			// 
			this.textBoxNombre.Font = new System.Drawing.Font("Maiandra GD", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.textBoxNombre.Location = new System.Drawing.Point(215, 191);
			this.textBoxNombre.MaxLength = 50;
			this.textBoxNombre.Name = "textBoxNombre";
			this.textBoxNombre.ScrollBars = System.Windows.Forms.ScrollBars.Horizontal;
			this.textBoxNombre.Size = new System.Drawing.Size(742, 36);
			this.textBoxNombre.TabIndex = 11;
			this.textBoxNombre.TextChanged += new System.EventHandler(this.TextBoxNombreTextChanged);
			// 
			// textBoxDescripcion
			// 
			this.textBoxDescripcion.Font = new System.Drawing.Font("Maiandra GD", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.textBoxDescripcion.Location = new System.Drawing.Point(215, 460);
			this.textBoxDescripcion.Multiline = true;
			this.textBoxDescripcion.Name = "textBoxDescripcion";
			this.textBoxDescripcion.ScrollBars = System.Windows.Forms.ScrollBars.Both;
			this.textBoxDescripcion.Size = new System.Drawing.Size(742, 108);
			this.textBoxDescripcion.TabIndex = 12;
			// 
			// textBoxObservaciones
			// 
			this.textBoxObservaciones.Font = new System.Drawing.Font("Maiandra GD", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.textBoxObservaciones.Location = new System.Drawing.Point(215, 607);
			this.textBoxObservaciones.Multiline = true;
			this.textBoxObservaciones.Name = "textBoxObservaciones";
			this.textBoxObservaciones.ScrollBars = System.Windows.Forms.ScrollBars.Both;
			this.textBoxObservaciones.Size = new System.Drawing.Size(742, 108);
			this.textBoxObservaciones.TabIndex = 13;
			// 
			// comboBoxTipo
			// 
			this.comboBoxTipo.Font = new System.Drawing.Font("Maiandra GD", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.comboBoxTipo.FormattingEnabled = true;
			this.comboBoxTipo.Items.AddRange(new object[] {
			"Mariscos",
			"Japonesa",
			"Bebida",
			"Postre"});
			this.comboBoxTipo.Location = new System.Drawing.Point(215, 248);
			this.comboBoxTipo.Name = "comboBoxTipo";
			this.comboBoxTipo.Size = new System.Drawing.Size(742, 37);
			this.comboBoxTipo.TabIndex = 14;
			this.comboBoxTipo.Text = "Mariscos";
			// 
			// comboBoxDisponibilidad
			// 
			this.comboBoxDisponibilidad.Font = new System.Drawing.Font("Maiandra GD", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.comboBoxDisponibilidad.FormattingEnabled = true;
			this.comboBoxDisponibilidad.Items.AddRange(new object[] {
			"Disponible",
			"No Disponible"});
			this.comboBoxDisponibilidad.Location = new System.Drawing.Point(215, 376);
			this.comboBoxDisponibilidad.Name = "comboBoxDisponibilidad";
			this.comboBoxDisponibilidad.Size = new System.Drawing.Size(742, 37);
			this.comboBoxDisponibilidad.TabIndex = 15;
			this.comboBoxDisponibilidad.Text = "Disponible";
			// 
			// numericUpDownCosto
			// 
			this.numericUpDownCosto.DecimalPlaces = 2;
			this.numericUpDownCosto.Font = new System.Drawing.Font("Lucida Bright", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.numericUpDownCosto.Location = new System.Drawing.Point(215, 315);
			this.numericUpDownCosto.Maximum = new decimal(new int[] {
			1410065407,
			2,
			0,
			0});
			this.numericUpDownCosto.Name = "numericUpDownCosto";
			this.numericUpDownCosto.Size = new System.Drawing.Size(742, 36);
			this.numericUpDownCosto.TabIndex = 16;
			this.numericUpDownCosto.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
			// 
			// buttonCargarImagen
			// 
			this.buttonCargarImagen.BackColor = System.Drawing.Color.Transparent;
			this.buttonCargarImagen.Cursor = System.Windows.Forms.Cursors.Hand;
			this.buttonCargarImagen.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
			this.buttonCargarImagen.Font = new System.Drawing.Font("Maiandra GD", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.buttonCargarImagen.ForeColor = System.Drawing.Color.White;
			this.buttonCargarImagen.Location = new System.Drawing.Point(1103, 478);
			this.buttonCargarImagen.Name = "buttonCargarImagen";
			this.buttonCargarImagen.Size = new System.Drawing.Size(120, 71);
			this.buttonCargarImagen.TabIndex = 17;
			this.buttonCargarImagen.Text = "CARGAR IMAGEN";
			this.buttonCargarImagen.UseVisualStyleBackColor = false;
			this.buttonCargarImagen.Click += new System.EventHandler(this.ButtonCargarImagenClick);
			// 
			// pictureBoxImagenCargada
			// 
			this.pictureBoxImagenCargada.BackColor = System.Drawing.Color.Transparent;
			this.pictureBoxImagenCargada.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
			this.pictureBoxImagenCargada.Location = new System.Drawing.Point(1013, 140);
			this.pictureBoxImagenCargada.Name = "pictureBoxImagenCargada";
			this.pictureBoxImagenCargada.Size = new System.Drawing.Size(300, 300);
			this.pictureBoxImagenCargada.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
			this.pictureBoxImagenCargada.TabIndex = 18;
			this.pictureBoxImagenCargada.TabStop = false;
			// 
			// buttonGuardar
			// 
			this.buttonGuardar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
			this.buttonGuardar.BackColor = System.Drawing.Color.Transparent;
			this.buttonGuardar.Cursor = System.Windows.Forms.Cursors.Hand;
			this.buttonGuardar.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
			this.buttonGuardar.Font = new System.Drawing.Font("Maiandra GD", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.buttonGuardar.ForeColor = System.Drawing.Color.White;
			this.buttonGuardar.Location = new System.Drawing.Point(1176, 655);
			this.buttonGuardar.Name = "buttonGuardar";
			this.buttonGuardar.Size = new System.Drawing.Size(160, 60);
			this.buttonGuardar.TabIndex = 20;
			this.buttonGuardar.Text = "GUARDAR";
			this.buttonGuardar.UseVisualStyleBackColor = false;
			this.buttonGuardar.Click += new System.EventHandler(this.ButtonGuardarClick);
			// 
			// buttonLimpiar
			// 
			this.buttonLimpiar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
			this.buttonLimpiar.BackColor = System.Drawing.Color.Transparent;
			this.buttonLimpiar.Cursor = System.Windows.Forms.Cursors.Hand;
			this.buttonLimpiar.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
			this.buttonLimpiar.Font = new System.Drawing.Font("Maiandra GD", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.buttonLimpiar.ForeColor = System.Drawing.Color.White;
			this.buttonLimpiar.Location = new System.Drawing.Point(983, 655);
			this.buttonLimpiar.Name = "buttonLimpiar";
			this.buttonLimpiar.Size = new System.Drawing.Size(160, 60);
			this.buttonLimpiar.TabIndex = 21;
			this.buttonLimpiar.Text = "LIMPIAR";
			this.buttonLimpiar.UseVisualStyleBackColor = false;
			this.buttonLimpiar.Click += new System.EventHandler(this.ButtonLimpiarClick);
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
			this.labelTitulo.Font = new System.Drawing.Font("Lucida Bright", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.labelTitulo.ForeColor = System.Drawing.Color.White;
			this.labelTitulo.Location = new System.Drawing.Point(334, 17);
			this.labelTitulo.Name = "labelTitulo";
			this.labelTitulo.Size = new System.Drawing.Size(633, 50);
			this.labelTitulo.TabIndex = 1;
			this.labelTitulo.Text = "REGISTRAR PRODUCTOS";
			this.labelTitulo.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// RegistrarProductos
			// 
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
			this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
			this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
			this.ClientSize = new System.Drawing.Size(1348, 727);
			this.Controls.Add(this.panelFondo);
			this.Controls.Add(this.buttonLimpiar);
			this.Controls.Add(this.buttonGuardar);
			this.Controls.Add(this.pictureBoxImagenCargada);
			this.Controls.Add(this.buttonCargarImagen);
			this.Controls.Add(this.numericUpDownCosto);
			this.Controls.Add(this.comboBoxDisponibilidad);
			this.Controls.Add(this.comboBoxTipo);
			this.Controls.Add(this.textBoxObservaciones);
			this.Controls.Add(this.textBoxDescripcion);
			this.Controls.Add(this.textBoxNombre);
			this.Controls.Add(this.textBoxID);
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
			this.Name = "RegistrarProductos";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "SISTEMA MEMÍN® ";
			this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
			this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.RegistrarProductosFormClosing);
			((System.ComponentModel.ISupportInitialize)(this.numericUpDownCosto)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.pictureBoxImagenCargada)).EndInit();
			this.panelFondo.ResumeLayout(false);
			this.ResumeLayout(false);
			this.PerformLayout();

		}
	}
}
