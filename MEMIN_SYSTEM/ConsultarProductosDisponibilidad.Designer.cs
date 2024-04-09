/*
 * Creado por SharpDevelop.
 * Usuario: Brian Gaytan Lomeli
 * Fecha: 26/10/2019
 * Hora: 12:02
 * 
 * Para cambiar esta plantilla use Herramientas | Opciones | Codificación | Editar Encabezados Estándar
 */
namespace MEMIN_SYSTEM
{
	partial class ConsultarProductosDisponibilidad
	{
		/// <summary>
		/// Designer variable used to keep track of non-visual components.
		/// </summary>
		private System.ComponentModel.IContainer components = null;
		private System.Windows.Forms.Label labelTipo;
		private System.Windows.Forms.ComboBox comboBoxDisponibilidad;
		private System.Windows.Forms.Button buttonConsultar;
		private System.Windows.Forms.Panel panelFondo;
		private System.Windows.Forms.Label labelTitulo;
		private System.Windows.Forms.DataGridView dataGridViewProductos;
		private System.Windows.Forms.DataGridViewTextBoxColumn ID_PRODUCTO;
		private System.Windows.Forms.DataGridViewTextBoxColumn NOMBRE;
		private System.Windows.Forms.DataGridViewTextBoxColumn TIPO;
		private System.Windows.Forms.DataGridViewTextBoxColumn DESCRIPCION;
		private System.Windows.Forms.DataGridViewTextBoxColumn DISPONIBILIDAD;
		private System.Windows.Forms.DataGridViewTextBoxColumn OBSERVACIONES;
		private System.Windows.Forms.DataGridViewTextBoxColumn COSTO;
		private System.Windows.Forms.DataGridViewImageColumn IMAGEN;
		
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
			System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
			System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
			System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ConsultarProductosDisponibilidad));
			this.labelTipo = new System.Windows.Forms.Label();
			this.comboBoxDisponibilidad = new System.Windows.Forms.ComboBox();
			this.buttonConsultar = new System.Windows.Forms.Button();
			this.panelFondo = new System.Windows.Forms.Panel();
			this.labelTitulo = new System.Windows.Forms.Label();
			this.dataGridViewProductos = new System.Windows.Forms.DataGridView();
			this.ID_PRODUCTO = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.NOMBRE = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.TIPO = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.DESCRIPCION = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.DISPONIBILIDAD = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.OBSERVACIONES = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.COSTO = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.IMAGEN = new System.Windows.Forms.DataGridViewImageColumn();
			this.panelFondo.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.dataGridViewProductos)).BeginInit();
			this.SuspendLayout();
			// 
			// labelTipo
			// 
			this.labelTipo.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
			this.labelTipo.BackColor = System.Drawing.Color.Transparent;
			this.labelTipo.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
			this.labelTipo.Font = new System.Drawing.Font("Maiandra GD", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.labelTipo.ForeColor = System.Drawing.Color.White;
			this.labelTipo.Location = new System.Drawing.Point(12, 111);
			this.labelTipo.Name = "labelTipo";
			this.labelTipo.Size = new System.Drawing.Size(176, 30);
			this.labelTipo.TabIndex = 30;
			this.labelTipo.Text = "DISPONIBILIDAD:";
			this.labelTipo.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// comboBoxDisponibilidad
			// 
			this.comboBoxDisponibilidad.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
			this.comboBoxDisponibilidad.Font = new System.Drawing.Font("Maiandra GD", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.comboBoxDisponibilidad.FormattingEnabled = true;
			this.comboBoxDisponibilidad.Items.AddRange(new object[] {
			"DISPONIBLE",
			"NO DISPONIBLE"});
			this.comboBoxDisponibilidad.Location = new System.Drawing.Point(205, 111);
			this.comboBoxDisponibilidad.Name = "comboBoxDisponibilidad";
			this.comboBoxDisponibilidad.Size = new System.Drawing.Size(201, 30);
			this.comboBoxDisponibilidad.TabIndex = 31;
			this.comboBoxDisponibilidad.Text = "DISPONIBLE";
			// 
			// buttonConsultar
			// 
			this.buttonConsultar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
			this.buttonConsultar.BackColor = System.Drawing.Color.Transparent;
			this.buttonConsultar.Cursor = System.Windows.Forms.Cursors.Hand;
			this.buttonConsultar.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
			this.buttonConsultar.Font = new System.Drawing.Font("Maiandra GD", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.buttonConsultar.ForeColor = System.Drawing.Color.White;
			this.buttonConsultar.Location = new System.Drawing.Point(842, 111);
			this.buttonConsultar.Name = "buttonConsultar";
			this.buttonConsultar.Size = new System.Drawing.Size(494, 34);
			this.buttonConsultar.TabIndex = 32;
			this.buttonConsultar.Text = "CONSULTAR";
			this.buttonConsultar.UseVisualStyleBackColor = false;
			this.buttonConsultar.Click += new System.EventHandler(this.ButtonConsultarClick);
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
			this.panelFondo.TabIndex = 107;
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
			this.labelTitulo.Location = new System.Drawing.Point(232, 17);
			this.labelTitulo.Name = "labelTitulo";
			this.labelTitulo.Size = new System.Drawing.Size(968, 50);
			this.labelTitulo.TabIndex = 1;
			this.labelTitulo.Text = "CONSULTAR PRODUCTOS POR DISPONIBILIDAD";
			this.labelTitulo.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// dataGridViewProductos
			// 
			this.dataGridViewProductos.AllowUserToAddRows = false;
			this.dataGridViewProductos.AllowUserToDeleteRows = false;
			dataGridViewCellStyle1.NullValue = null;
			this.dataGridViewProductos.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
			this.dataGridViewProductos.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
			| System.Windows.Forms.AnchorStyles.Right)));
			this.dataGridViewProductos.BackgroundColor = System.Drawing.Color.White;
			this.dataGridViewProductos.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
			this.dataGridViewProductos.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.Sunken;
			this.dataGridViewProductos.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
			dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
			dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Control;
			dataGridViewCellStyle2.Font = new System.Drawing.Font("Maiandra GD", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText;
			dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
			dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
			dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
			this.dataGridViewProductos.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
			this.dataGridViewProductos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dataGridViewProductos.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
			this.ID_PRODUCTO,
			this.NOMBRE,
			this.TIPO,
			this.DESCRIPCION,
			this.DISPONIBILIDAD,
			this.OBSERVACIONES,
			this.COSTO,
			this.IMAGEN});
			dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
			dataGridViewCellStyle3.BackColor = System.Drawing.Color.White;
			dataGridViewCellStyle3.Font = new System.Drawing.Font("Maiandra GD", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			dataGridViewCellStyle3.ForeColor = System.Drawing.Color.Black;
			dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
			dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.White;
			dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
			this.dataGridViewProductos.DefaultCellStyle = dataGridViewCellStyle3;
			this.dataGridViewProductos.Location = new System.Drawing.Point(12, 164);
			this.dataGridViewProductos.Name = "dataGridViewProductos";
			this.dataGridViewProductos.ReadOnly = true;
			this.dataGridViewProductos.RowHeadersVisible = false;
			dataGridViewCellStyle4.Font = new System.Drawing.Font("Maiandra GD", 9F);
			this.dataGridViewProductos.RowsDefaultCellStyle = dataGridViewCellStyle4;
			this.dataGridViewProductos.RowTemplate.Height = 150;
			this.dataGridViewProductos.RowTemplate.ReadOnly = true;
			this.dataGridViewProductos.RowTemplate.Resizable = System.Windows.Forms.DataGridViewTriState.True;
			this.dataGridViewProductos.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.CellSelect;
			this.dataGridViewProductos.Size = new System.Drawing.Size(1324, 556);
			this.dataGridViewProductos.TabIndex = 108;
			// 
			// ID_PRODUCTO
			// 
			this.ID_PRODUCTO.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader;
			this.ID_PRODUCTO.HeaderText = "ID PRODUCTO";
			this.ID_PRODUCTO.Name = "ID_PRODUCTO";
			this.ID_PRODUCTO.ReadOnly = true;
			this.ID_PRODUCTO.Width = 108;
			// 
			// NOMBRE
			// 
			this.NOMBRE.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
			this.NOMBRE.HeaderText = "NOMBRE";
			this.NOMBRE.Name = "NOMBRE";
			this.NOMBRE.ReadOnly = true;
			// 
			// TIPO
			// 
			this.TIPO.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
			this.TIPO.HeaderText = "TIPO";
			this.TIPO.Name = "TIPO";
			this.TIPO.ReadOnly = true;
			// 
			// DESCRIPCION
			// 
			this.DESCRIPCION.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
			this.DESCRIPCION.HeaderText = "DESCRIPCIÓN";
			this.DESCRIPCION.Name = "DESCRIPCION";
			this.DESCRIPCION.ReadOnly = true;
			// 
			// DISPONIBILIDAD
			// 
			this.DISPONIBILIDAD.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
			this.DISPONIBILIDAD.HeaderText = "DISPONIBILIDAD";
			this.DISPONIBILIDAD.Name = "DISPONIBILIDAD";
			this.DISPONIBILIDAD.ReadOnly = true;
			// 
			// OBSERVACIONES
			// 
			this.OBSERVACIONES.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
			this.OBSERVACIONES.HeaderText = "OBSERVACIONES";
			this.OBSERVACIONES.Name = "OBSERVACIONES";
			this.OBSERVACIONES.ReadOnly = true;
			// 
			// COSTO
			// 
			this.COSTO.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
			this.COSTO.HeaderText = "PRECIO UNITARIO";
			this.COSTO.Name = "COSTO";
			this.COSTO.ReadOnly = true;
			// 
			// IMAGEN
			// 
			this.IMAGEN.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
			this.IMAGEN.HeaderText = "IMAGEN";
			this.IMAGEN.ImageLayout = System.Windows.Forms.DataGridViewImageCellLayout.Stretch;
			this.IMAGEN.Name = "IMAGEN";
			this.IMAGEN.ReadOnly = true;
			this.IMAGEN.Resizable = System.Windows.Forms.DataGridViewTriState.True;
			this.IMAGEN.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
			// 
			// ConsultarProductosDisponibilidad
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
			this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
			this.ClientSize = new System.Drawing.Size(1348, 727);
			this.Controls.Add(this.dataGridViewProductos);
			this.Controls.Add(this.panelFondo);
			this.Controls.Add(this.buttonConsultar);
			this.Controls.Add(this.comboBoxDisponibilidad);
			this.Controls.Add(this.labelTipo);
			this.DoubleBuffered = true;
			this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
			this.MinimumSize = new System.Drawing.Size(1364, 766);
			this.Name = "ConsultarProductosDisponibilidad";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "SISTEMA MEMÍN® ";
			this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
			this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.ConsultarProductosDisponibilidadFormClosing);
			this.panelFondo.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.dataGridViewProductos)).EndInit();
			this.ResumeLayout(false);

		}
	}
}
