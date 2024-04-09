/*
 * Creado por SharpDevelop.
 * Usuario: Brian Gaytan Lomeli
 * Fecha: 26/10/2019
 * Hora: 12:32
 * 
 * Para cambiar esta plantilla use Herramientas | Opciones | Codificación | Editar Encabezados Estándar
 */
namespace MEMIN_SYSTEM
{
	partial class BuscarProductos
	{
		/// <summary>
		/// Designer variable used to keep track of non-visual components.
		/// </summary>
		private System.ComponentModel.IContainer components = null;
		private System.Windows.Forms.DataGridView dataGridViewProductos;
		private System.Windows.Forms.Button buttonBuscar;
		private System.Windows.Forms.Label labelID;
		private System.Windows.Forms.Panel panelFondo;
		private System.Windows.Forms.Label labelTitulo;
		private System.Windows.Forms.DataGridViewTextBoxColumn ID_PRODUCTO;
		private System.Windows.Forms.DataGridViewTextBoxColumn NOMBRE_PRODUCTO;
		private System.Windows.Forms.DataGridViewTextBoxColumn TIPO_PRODUCTO;
		private System.Windows.Forms.DataGridViewTextBoxColumn DESCRIPCION;
		private System.Windows.Forms.DataGridViewTextBoxColumn COSTO;
		private System.Windows.Forms.DataGridViewTextBoxColumn DISPONIBILIDAD;
		private System.Windows.Forms.DataGridViewImageColumn IMAGEN;
		private System.Windows.Forms.NumericUpDown numericUpDownIDProducto;
		private System.Windows.Forms.DataGridViewTextBoxColumn OBSERVACIONES;
		
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
		/// 
		void InitializeComponent()
		{
			System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
			System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
			System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
			System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
			System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(BuscarProductos));
			this.dataGridViewProductos = new System.Windows.Forms.DataGridView();
			this.buttonBuscar = new System.Windows.Forms.Button();
			this.labelID = new System.Windows.Forms.Label();
			this.panelFondo = new System.Windows.Forms.Panel();
			this.labelTitulo = new System.Windows.Forms.Label();
			this.numericUpDownIDProducto = new System.Windows.Forms.NumericUpDown();
			this.ID_PRODUCTO = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.NOMBRE_PRODUCTO = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.DESCRIPCION = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.TIPO_PRODUCTO = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.DISPONIBILIDAD = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.OBSERVACIONES = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.COSTO = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.IMAGEN = new System.Windows.Forms.DataGridViewImageColumn();
			((System.ComponentModel.ISupportInitialize)(this.dataGridViewProductos)).BeginInit();
			this.panelFondo.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.numericUpDownIDProducto)).BeginInit();
			this.SuspendLayout();
			// 
			// dataGridViewProductos
			// 
			this.dataGridViewProductos.AllowUserToAddRows = false;
			this.dataGridViewProductos.AllowUserToDeleteRows = false;
			dataGridViewCellStyle1.NullValue = null;
			this.dataGridViewProductos.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
			this.dataGridViewProductos.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
			| System.Windows.Forms.AnchorStyles.Left) 
			| System.Windows.Forms.AnchorStyles.Right)));
			this.dataGridViewProductos.BackgroundColor = System.Drawing.Color.White;
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
			this.NOMBRE_PRODUCTO,
			this.DESCRIPCION,
			this.TIPO_PRODUCTO,
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
			this.dataGridViewProductos.Location = new System.Drawing.Point(9, 160);
			this.dataGridViewProductos.Name = "dataGridViewProductos";
			this.dataGridViewProductos.ReadOnly = true;
			dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
			dataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Control;
			dataGridViewCellStyle4.Font = new System.Drawing.Font("Maiandra GD", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.WindowText;
			dataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight;
			dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
			dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
			this.dataGridViewProductos.RowHeadersDefaultCellStyle = dataGridViewCellStyle4;
			this.dataGridViewProductos.RowHeadersVisible = false;
			this.dataGridViewProductos.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.AutoSizeToAllHeaders;
			dataGridViewCellStyle5.Font = new System.Drawing.Font("Maiandra GD", 9F);
			this.dataGridViewProductos.RowsDefaultCellStyle = dataGridViewCellStyle5;
			this.dataGridViewProductos.RowTemplate.Height = 250;
			this.dataGridViewProductos.RowTemplate.ReadOnly = true;
			this.dataGridViewProductos.RowTemplate.Resizable = System.Windows.Forms.DataGridViewTriState.True;
			this.dataGridViewProductos.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.CellSelect;
			this.dataGridViewProductos.Size = new System.Drawing.Size(1327, 290);
			this.dataGridViewProductos.TabIndex = 5;
			// 
			// buttonBuscar
			// 
			this.buttonBuscar.BackColor = System.Drawing.Color.Transparent;
			this.buttonBuscar.Cursor = System.Windows.Forms.Cursors.Hand;
			this.buttonBuscar.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
			this.buttonBuscar.Font = new System.Drawing.Font("Maiandra GD", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.buttonBuscar.ForeColor = System.Drawing.Color.White;
			this.buttonBuscar.Location = new System.Drawing.Point(877, 111);
			this.buttonBuscar.Name = "buttonBuscar";
			this.buttonBuscar.Size = new System.Drawing.Size(440, 32);
			this.buttonBuscar.TabIndex = 23;
			this.buttonBuscar.Text = "BUSCAR";
			this.buttonBuscar.UseVisualStyleBackColor = false;
			this.buttonBuscar.Click += new System.EventHandler(this.ButtonBuscarClick);
			// 
			// labelID
			// 
			this.labelID.BackColor = System.Drawing.Color.Transparent;
			this.labelID.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
			this.labelID.Font = new System.Drawing.Font("Maiandra GD", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.labelID.ForeColor = System.Drawing.Color.White;
			this.labelID.Location = new System.Drawing.Point(9, 111);
			this.labelID.Name = "labelID";
			this.labelID.Size = new System.Drawing.Size(372, 32);
			this.labelID.TabIndex = 25;
			this.labelID.Text = "ID DE PRODUCTO:";
			this.labelID.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
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
			this.labelTitulo.Text = "BUSCAR PRODUCTOS";
			this.labelTitulo.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// numericUpDownIDProducto
			// 
			this.numericUpDownIDProducto.Font = new System.Drawing.Font("Lucida Bright", 15.75F);
			this.numericUpDownIDProducto.Location = new System.Drawing.Point(407, 111);
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
			this.numericUpDownIDProducto.Size = new System.Drawing.Size(445, 32);
			this.numericUpDownIDProducto.TabIndex = 108;
			this.numericUpDownIDProducto.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
			this.numericUpDownIDProducto.Value = new decimal(new int[] {
			1,
			0,
			0,
			0});
			// 
			// ID_PRODUCTO
			// 
			this.ID_PRODUCTO.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader;
			this.ID_PRODUCTO.HeaderText = "ID PRODUCTO";
			this.ID_PRODUCTO.Name = "ID_PRODUCTO";
			this.ID_PRODUCTO.ReadOnly = true;
			this.ID_PRODUCTO.Width = 108;
			// 
			// NOMBRE_PRODUCTO
			// 
			this.NOMBRE_PRODUCTO.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
			this.NOMBRE_PRODUCTO.HeaderText = "NOMBRE";
			this.NOMBRE_PRODUCTO.Name = "NOMBRE_PRODUCTO";
			this.NOMBRE_PRODUCTO.ReadOnly = true;
			// 
			// DESCRIPCION
			// 
			this.DESCRIPCION.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
			this.DESCRIPCION.HeaderText = "DESCRIPCIÓN";
			this.DESCRIPCION.Name = "DESCRIPCION";
			this.DESCRIPCION.ReadOnly = true;
			// 
			// TIPO_PRODUCTO
			// 
			this.TIPO_PRODUCTO.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
			this.TIPO_PRODUCTO.HeaderText = "TIPO";
			this.TIPO_PRODUCTO.Name = "TIPO_PRODUCTO";
			this.TIPO_PRODUCTO.ReadOnly = true;
			// 
			// DISPONIBILIDAD
			// 
			this.DISPONIBILIDAD.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader;
			this.DISPONIBILIDAD.HeaderText = "DISPONIBILIDAD";
			this.DISPONIBILIDAD.Name = "DISPONIBILIDAD";
			this.DISPONIBILIDAD.ReadOnly = true;
			this.DISPONIBILIDAD.Width = 129;
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
			this.COSTO.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader;
			this.COSTO.HeaderText = "PRECIO UNITARIO";
			this.COSTO.Name = "COSTO";
			this.COSTO.ReadOnly = true;
			this.COSTO.Width = 129;
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
			// BuscarProductos
			// 
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
			this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
			this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
			this.ClientSize = new System.Drawing.Size(1348, 461);
			this.Controls.Add(this.numericUpDownIDProducto);
			this.Controls.Add(this.panelFondo);
			this.Controls.Add(this.labelID);
			this.Controls.Add(this.buttonBuscar);
			this.Controls.Add(this.dataGridViewProductos);
			this.DoubleBuffered = true;
			this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
			this.MaximizeBox = false;
			this.MinimumSize = new System.Drawing.Size(1364, 500);
			this.Name = "BuscarProductos";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "SISTEMA MEMÍN® ";
			this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.BuscarProductosFormClosing);
			((System.ComponentModel.ISupportInitialize)(this.dataGridViewProductos)).EndInit();
			this.panelFondo.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.numericUpDownIDProducto)).EndInit();
			this.ResumeLayout(false);

		}
		

		
	}
}
