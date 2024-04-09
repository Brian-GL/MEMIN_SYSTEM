/*
 * Creado por SharpDevelop.
 * Usuario: Brian Gaytan Lomeli
 * Fecha: 27/10/2019
 * Hora: 17:20
 * 
 * Para cambiar esta plantilla use Herramientas | Opciones | Codificación | Editar Encabezados Estándar
 */
namespace MEMIN_SYSTEM
{
	partial class ComandasAsignadas
	{
		/// <summary>
		/// Designer variable used to keep track of non-visual components.
		/// </summary>
		private System.ComponentModel.IContainer components = null;
		private System.Windows.Forms.Panel panelFondo;
		private System.Windows.Forms.Label labelTitulo;
		private System.Windows.Forms.DataGridView dataGridViewComandas;
		private System.Windows.Forms.DataGridViewTextBoxColumn ID_COMANDA_ENCONTRADA;
		private System.Windows.Forms.DataGridViewTextBoxColumn ID_EMPLEADO;
		private System.Windows.Forms.DataGridViewTextBoxColumn NOMBRE_MESERO;
		private System.Windows.Forms.DataGridViewTextBoxColumn NOMBRE_CLIENTE;
		private System.Windows.Forms.DataGridViewTextBoxColumn NUMERO_MESA;
		private System.Windows.Forms.DataGridViewTextBoxColumn FECHA_CREACION;
		private System.Windows.Forms.DataGridViewTextBoxColumn ESTATUS;
		private System.Windows.Forms.DataGridViewTextBoxColumn ID_EMPLEADO_COCINA;
		private System.Windows.Forms.DataGridViewTextBoxColumn NOMBRE_COCINERO;
		private System.Windows.Forms.DataGridView dataGridViewDetalleComanda;
		private System.Windows.Forms.DataGridViewTextBoxColumn ID_COMANDA;
		private System.Windows.Forms.DataGridViewTextBoxColumn ID_PRODUCTO;
		private System.Windows.Forms.DataGridViewTextBoxColumn NOMBRE_PRODUCTO;
		private System.Windows.Forms.DataGridViewTextBoxColumn DESCRIPCION_PRODUCTO_DETALLE;
		private System.Windows.Forms.DataGridViewTextBoxColumn CANTIDAD;
		private System.Windows.Forms.DataGridViewTextBoxColumn PRECIO_UNITARIO;
		private System.Windows.Forms.DataGridViewTextBoxColumn IMPORTE;
		private System.Windows.Forms.DataGridViewButtonColumn MOSTRAR_DETALLE_COMANDA;
		
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
			System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
			System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
			System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ComandasAsignadas));
			this.panelFondo = new System.Windows.Forms.Panel();
			this.labelTitulo = new System.Windows.Forms.Label();
			this.dataGridViewComandas = new System.Windows.Forms.DataGridView();
			this.ID_COMANDA_ENCONTRADA = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.ID_EMPLEADO = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.NOMBRE_MESERO = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.NOMBRE_CLIENTE = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.NUMERO_MESA = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.FECHA_CREACION = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.ESTATUS = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.ID_EMPLEADO_COCINA = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.NOMBRE_COCINERO = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.MOSTRAR_DETALLE_COMANDA = new System.Windows.Forms.DataGridViewButtonColumn();
			this.dataGridViewDetalleComanda = new System.Windows.Forms.DataGridView();
			this.ID_COMANDA = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.ID_PRODUCTO = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.NOMBRE_PRODUCTO = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.DESCRIPCION_PRODUCTO_DETALLE = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.CANTIDAD = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.PRECIO_UNITARIO = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.IMPORTE = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.panelFondo.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.dataGridViewComandas)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.dataGridViewDetalleComanda)).BeginInit();
			this.SuspendLayout();
			// 
			// panelFondo
			// 
			this.panelFondo.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
			| System.Windows.Forms.AnchorStyles.Right)));
			this.panelFondo.BackColor = System.Drawing.Color.OrangeRed;
			this.panelFondo.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
			this.panelFondo.Controls.Add(this.labelTitulo);
			this.panelFondo.Location = new System.Drawing.Point(0, 0);
			this.panelFondo.Name = "panelFondo";
			this.panelFondo.Size = new System.Drawing.Size(1352, 100);
			this.panelFondo.TabIndex = 112;
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
			this.labelTitulo.Location = new System.Drawing.Point(281, 17);
			this.labelTitulo.Name = "labelTitulo";
			this.labelTitulo.Size = new System.Drawing.Size(749, 50);
			this.labelTitulo.TabIndex = 1;
			this.labelTitulo.Text = "CONSULTAR COMANDAS ASIGNADAS ";
			this.labelTitulo.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// dataGridViewComandas
			// 
			this.dataGridViewComandas.AllowUserToAddRows = false;
			this.dataGridViewComandas.AllowUserToDeleteRows = false;
			this.dataGridViewComandas.AllowUserToOrderColumns = true;
			dataGridViewCellStyle1.NullValue = null;
			this.dataGridViewComandas.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
			this.dataGridViewComandas.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
			this.dataGridViewComandas.BackgroundColor = System.Drawing.Color.White;
			this.dataGridViewComandas.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
			this.dataGridViewComandas.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.Sunken;
			this.dataGridViewComandas.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
			dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
			dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Control;
			dataGridViewCellStyle2.Font = new System.Drawing.Font("Maiandra GD", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText;
			dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
			dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
			dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
			this.dataGridViewComandas.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
			this.dataGridViewComandas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dataGridViewComandas.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
			this.ID_COMANDA_ENCONTRADA,
			this.ID_EMPLEADO,
			this.NOMBRE_MESERO,
			this.NOMBRE_CLIENTE,
			this.NUMERO_MESA,
			this.FECHA_CREACION,
			this.ESTATUS,
			this.ID_EMPLEADO_COCINA,
			this.NOMBRE_COCINERO,
			this.MOSTRAR_DETALLE_COMANDA});
			dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
			dataGridViewCellStyle3.BackColor = System.Drawing.Color.White;
			dataGridViewCellStyle3.Font = new System.Drawing.Font("Maiandra GD", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			dataGridViewCellStyle3.ForeColor = System.Drawing.Color.Black;
			dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
			dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.White;
			dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
			this.dataGridViewComandas.DefaultCellStyle = dataGridViewCellStyle3;
			this.dataGridViewComandas.Location = new System.Drawing.Point(10, 107);
			this.dataGridViewComandas.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
			this.dataGridViewComandas.Name = "dataGridViewComandas";
			this.dataGridViewComandas.ReadOnly = true;
			this.dataGridViewComandas.RowHeadersVisible = false;
			dataGridViewCellStyle4.Font = new System.Drawing.Font("Maiandra GD", 9F);
			this.dataGridViewComandas.RowsDefaultCellStyle = dataGridViewCellStyle4;
			this.dataGridViewComandas.RowTemplate.DefaultCellStyle.Font = new System.Drawing.Font("Maiandra GD", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.dataGridViewComandas.RowTemplate.Height = 40;
			this.dataGridViewComandas.RowTemplate.ReadOnly = true;
			this.dataGridViewComandas.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.CellSelect;
			this.dataGridViewComandas.Size = new System.Drawing.Size(1326, 300);
			this.dataGridViewComandas.TabIndex = 146;
			this.dataGridViewComandas.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DataGridViewComandasCellContentClick);
			// 
			// ID_COMANDA_ENCONTRADA
			// 
			this.ID_COMANDA_ENCONTRADA.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
			this.ID_COMANDA_ENCONTRADA.HeaderText = "ID COMANDA";
			this.ID_COMANDA_ENCONTRADA.Name = "ID_COMANDA_ENCONTRADA";
			this.ID_COMANDA_ENCONTRADA.ReadOnly = true;
			// 
			// ID_EMPLEADO
			// 
			this.ID_EMPLEADO.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
			this.ID_EMPLEADO.HeaderText = "ID MESERO";
			this.ID_EMPLEADO.Name = "ID_EMPLEADO";
			this.ID_EMPLEADO.ReadOnly = true;
			// 
			// NOMBRE_MESERO
			// 
			this.NOMBRE_MESERO.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
			this.NOMBRE_MESERO.HeaderText = "NOMBRE MESERO";
			this.NOMBRE_MESERO.Name = "NOMBRE_MESERO";
			this.NOMBRE_MESERO.ReadOnly = true;
			// 
			// NOMBRE_CLIENTE
			// 
			this.NOMBRE_CLIENTE.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
			this.NOMBRE_CLIENTE.HeaderText = "NOMBRE CLIENTE";
			this.NOMBRE_CLIENTE.Name = "NOMBRE_CLIENTE";
			this.NOMBRE_CLIENTE.ReadOnly = true;
			// 
			// NUMERO_MESA
			// 
			this.NUMERO_MESA.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
			this.NUMERO_MESA.HeaderText = "# MESA";
			this.NUMERO_MESA.Name = "NUMERO_MESA";
			this.NUMERO_MESA.ReadOnly = true;
			// 
			// FECHA_CREACION
			// 
			this.FECHA_CREACION.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
			this.FECHA_CREACION.HeaderText = "FECHA CREACIÓN";
			this.FECHA_CREACION.Name = "FECHA_CREACION";
			this.FECHA_CREACION.ReadOnly = true;
			// 
			// ESTATUS
			// 
			this.ESTATUS.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
			this.ESTATUS.HeaderText = "ESTATUS";
			this.ESTATUS.Name = "ESTATUS";
			this.ESTATUS.ReadOnly = true;
			// 
			// ID_EMPLEADO_COCINA
			// 
			this.ID_EMPLEADO_COCINA.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
			this.ID_EMPLEADO_COCINA.HeaderText = "ID COCINERO";
			this.ID_EMPLEADO_COCINA.Name = "ID_EMPLEADO_COCINA";
			this.ID_EMPLEADO_COCINA.ReadOnly = true;
			// 
			// NOMBRE_COCINERO
			// 
			this.NOMBRE_COCINERO.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
			this.NOMBRE_COCINERO.HeaderText = "NOMBRE COCINERO";
			this.NOMBRE_COCINERO.Name = "NOMBRE_COCINERO";
			this.NOMBRE_COCINERO.ReadOnly = true;
			// 
			// MOSTRAR_DETALLE_COMANDA
			// 
			this.MOSTRAR_DETALLE_COMANDA.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader;
			this.MOSTRAR_DETALLE_COMANDA.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
			this.MOSTRAR_DETALLE_COMANDA.HeaderText = "MOSTRAR DETALLE COMANDA";
			this.MOSTRAR_DETALLE_COMANDA.Name = "MOSTRAR_DETALLE_COMANDA";
			this.MOSTRAR_DETALLE_COMANDA.ReadOnly = true;
			this.MOSTRAR_DETALLE_COMANDA.Width = 176;
			// 
			// dataGridViewDetalleComanda
			// 
			this.dataGridViewDetalleComanda.AllowUserToAddRows = false;
			this.dataGridViewDetalleComanda.AllowUserToDeleteRows = false;
			this.dataGridViewDetalleComanda.AllowUserToOrderColumns = true;
			this.dataGridViewDetalleComanda.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
			this.dataGridViewDetalleComanda.BackgroundColor = System.Drawing.Color.White;
			this.dataGridViewDetalleComanda.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
			dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
			dataGridViewCellStyle5.BackColor = System.Drawing.Color.White;
			dataGridViewCellStyle5.Font = new System.Drawing.Font("Maiandra GD", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			dataGridViewCellStyle5.ForeColor = System.Drawing.SystemColors.WindowText;
			dataGridViewCellStyle5.SelectionBackColor = System.Drawing.SystemColors.Highlight;
			dataGridViewCellStyle5.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
			dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
			this.dataGridViewDetalleComanda.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle5;
			this.dataGridViewDetalleComanda.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dataGridViewDetalleComanda.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
			this.ID_COMANDA,
			this.ID_PRODUCTO,
			this.NOMBRE_PRODUCTO,
			this.DESCRIPCION_PRODUCTO_DETALLE,
			this.CANTIDAD,
			this.PRECIO_UNITARIO,
			this.IMPORTE});
			dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
			dataGridViewCellStyle6.BackColor = System.Drawing.SystemColors.Window;
			dataGridViewCellStyle6.Font = new System.Drawing.Font("Maiandra GD", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			dataGridViewCellStyle6.ForeColor = System.Drawing.SystemColors.ControlText;
			dataGridViewCellStyle6.SelectionBackColor = System.Drawing.SystemColors.Highlight;
			dataGridViewCellStyle6.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
			dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
			this.dataGridViewDetalleComanda.DefaultCellStyle = dataGridViewCellStyle6;
			this.dataGridViewDetalleComanda.Location = new System.Drawing.Point(10, 421);
			this.dataGridViewDetalleComanda.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
			this.dataGridViewDetalleComanda.Name = "dataGridViewDetalleComanda";
			this.dataGridViewDetalleComanda.RowHeadersVisible = false;
			dataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
			dataGridViewCellStyle7.Font = new System.Drawing.Font("Maiandra GD", 9F);
			this.dataGridViewDetalleComanda.RowsDefaultCellStyle = dataGridViewCellStyle7;
			this.dataGridViewDetalleComanda.RowTemplate.DefaultCellStyle.Font = new System.Drawing.Font("Maiandra GD", 9F);
			this.dataGridViewDetalleComanda.RowTemplate.Height = 30;
			this.dataGridViewDetalleComanda.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.CellSelect;
			this.dataGridViewDetalleComanda.Size = new System.Drawing.Size(1326, 297);
			this.dataGridViewDetalleComanda.TabIndex = 145;
			// 
			// ID_COMANDA
			// 
			this.ID_COMANDA.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader;
			this.ID_COMANDA.HeaderText = "ID COMANDA";
			this.ID_COMANDA.Name = "ID_COMANDA";
			this.ID_COMANDA.Width = 104;
			// 
			// ID_PRODUCTO
			// 
			this.ID_PRODUCTO.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader;
			this.ID_PRODUCTO.HeaderText = "ID PRODUCTO";
			this.ID_PRODUCTO.Name = "ID_PRODUCTO";
			this.ID_PRODUCTO.Width = 108;
			// 
			// NOMBRE_PRODUCTO
			// 
			this.NOMBRE_PRODUCTO.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
			this.NOMBRE_PRODUCTO.HeaderText = "NOMBRE";
			this.NOMBRE_PRODUCTO.Name = "NOMBRE_PRODUCTO";
			// 
			// DESCRIPCION_PRODUCTO_DETALLE
			// 
			this.DESCRIPCION_PRODUCTO_DETALLE.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
			this.DESCRIPCION_PRODUCTO_DETALLE.HeaderText = "DESCRIPCIÓN";
			this.DESCRIPCION_PRODUCTO_DETALLE.Name = "DESCRIPCION_PRODUCTO_DETALLE";
			// 
			// CANTIDAD
			// 
			this.CANTIDAD.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader;
			this.CANTIDAD.HeaderText = "CANTIDAD";
			this.CANTIDAD.Name = "CANTIDAD";
			this.CANTIDAD.Width = 96;
			// 
			// PRECIO_UNITARIO
			// 
			this.PRECIO_UNITARIO.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
			this.PRECIO_UNITARIO.HeaderText = "PRECIO UNITARIO";
			this.PRECIO_UNITARIO.Name = "PRECIO_UNITARIO";
			// 
			// IMPORTE
			// 
			this.IMPORTE.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
			this.IMPORTE.HeaderText = "IMPORTE";
			this.IMPORTE.Name = "IMPORTE";
			// 
			// ComandasAsignadas
			// 
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
			this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
			this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
			this.ClientSize = new System.Drawing.Size(1348, 727);
			this.Controls.Add(this.dataGridViewComandas);
			this.Controls.Add(this.dataGridViewDetalleComanda);
			this.Controls.Add(this.panelFondo);
			this.DoubleBuffered = true;
			this.HelpButton = true;
			this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
			this.MinimumSize = new System.Drawing.Size(1364, 736);
			this.Name = "ComandasAsignadas";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
			this.Text = "SISTEMA MEMÍN® ";
			this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
			this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.ComandasAsignadasFormClosing);
			this.Load += new System.EventHandler(this.ComandasAsignadasLoad);
			this.panelFondo.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.dataGridViewComandas)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.dataGridViewDetalleComanda)).EndInit();
			this.ResumeLayout(false);

		}
	}
}
