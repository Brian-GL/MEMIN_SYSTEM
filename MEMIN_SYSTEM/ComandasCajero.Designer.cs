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
	partial class ComandasCajero
	{
		/// <summary>
		/// Designer variable used to keep track of non-visual components.
		/// </summary>
		private System.ComponentModel.IContainer components = null;
		private System.Windows.Forms.MonthCalendar monthCalendarDiaHoy;
		private System.Windows.Forms.Panel panelFondo;
		private System.Windows.Forms.Label labelTitulo;
		private System.Windows.Forms.Label labelID;
		private System.Windows.Forms.Button buttonBuscar;
		private System.Windows.Forms.NumericUpDown numericUpDownIDCajero;
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
		private System.Windows.Forms.DataGridViewTextBoxColumn ID_CAJERO;
		private System.Windows.Forms.DataGridViewTextBoxColumn NOMBRE_CAJERO;
		private System.Windows.Forms.DataGridViewTextBoxColumn FECHA_CIERRE;
		private System.Windows.Forms.DataGridViewTextBoxColumn FORMA_PAGO;
		private System.Windows.Forms.DataGridViewTextBoxColumn SUBTOTAL_COMANDA;
		private System.Windows.Forms.DataGridViewTextBoxColumn SERVICIO;
		private System.Windows.Forms.DataGridViewTextBoxColumn TOTAL_COMANDA;
		private System.Windows.Forms.DataGridViewButtonColumn MOSTRAR_DETALLE_COMANDA;
		private System.Windows.Forms.DataGridView dataGridViewDetalleComanda;
		private System.Windows.Forms.DataGridViewTextBoxColumn ID_COMANDA;
		private System.Windows.Forms.DataGridViewTextBoxColumn ID_PRODUCTO;
		private System.Windows.Forms.DataGridViewTextBoxColumn NOMBRE_PRODUCTO;
		private System.Windows.Forms.DataGridViewTextBoxColumn DESCRIPCION_PRODUCTO_DETALLE;
		private System.Windows.Forms.DataGridViewTextBoxColumn CANTIDAD;
		private System.Windows.Forms.DataGridViewTextBoxColumn PRECIO_UNITARIO;
		private System.Windows.Forms.DataGridViewTextBoxColumn IMPORTE;
		private System.Windows.Forms.TextBox textBoxTotalComandas;
		private System.Windows.Forms.Label labelTotalComandas;
		private System.Windows.Forms.DataGridViewTextBoxColumn NUMERO_COMANDA;
		
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ComandasCajero));
			this.monthCalendarDiaHoy = new System.Windows.Forms.MonthCalendar();
			this.panelFondo = new System.Windows.Forms.Panel();
			this.labelTitulo = new System.Windows.Forms.Label();
			this.labelID = new System.Windows.Forms.Label();
			this.buttonBuscar = new System.Windows.Forms.Button();
			this.numericUpDownIDCajero = new System.Windows.Forms.NumericUpDown();
			this.dataGridViewComandas = new System.Windows.Forms.DataGridView();
			this.dataGridViewDetalleComanda = new System.Windows.Forms.DataGridView();
			this.ID_COMANDA = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.ID_PRODUCTO = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.NOMBRE_PRODUCTO = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.DESCRIPCION_PRODUCTO_DETALLE = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.CANTIDAD = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.PRECIO_UNITARIO = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.IMPORTE = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.textBoxTotalComandas = new System.Windows.Forms.TextBox();
			this.labelTotalComandas = new System.Windows.Forms.Label();
			this.NUMERO_COMANDA = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.ID_COMANDA_ENCONTRADA = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.ID_EMPLEADO = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.NOMBRE_MESERO = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.NOMBRE_CLIENTE = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.NUMERO_MESA = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.FECHA_CREACION = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.ESTATUS = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.ID_EMPLEADO_COCINA = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.NOMBRE_COCINERO = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.ID_CAJERO = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.NOMBRE_CAJERO = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.FECHA_CIERRE = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.FORMA_PAGO = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.SUBTOTAL_COMANDA = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.SERVICIO = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.TOTAL_COMANDA = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.MOSTRAR_DETALLE_COMANDA = new System.Windows.Forms.DataGridViewButtonColumn();
			this.panelFondo.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.numericUpDownIDCajero)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.dataGridViewComandas)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.dataGridViewDetalleComanda)).BeginInit();
			this.SuspendLayout();
			// 
			// monthCalendarDiaHoy
			// 
			this.monthCalendarDiaHoy.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
			| System.Windows.Forms.AnchorStyles.Right)));
			this.monthCalendarDiaHoy.Font = new System.Drawing.Font("Maiandra GD", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.monthCalendarDiaHoy.Location = new System.Drawing.Point(1118, 5);
			this.monthCalendarDiaHoy.Margin = new System.Windows.Forms.Padding(9, 10, 9, 10);
			this.monthCalendarDiaHoy.MaxSelectionCount = 1;
			this.monthCalendarDiaHoy.MinDate = new System.DateTime(2019, 8, 12, 0, 0, 0, 0);
			this.monthCalendarDiaHoy.Name = "monthCalendarDiaHoy";
			this.monthCalendarDiaHoy.RightToLeft = System.Windows.Forms.RightToLeft.No;
			this.monthCalendarDiaHoy.ShowWeekNumbers = true;
			this.monthCalendarDiaHoy.TabIndex = 115;
			// 
			// panelFondo
			// 
			this.panelFondo.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
			this.panelFondo.BackColor = System.Drawing.Color.OrangeRed;
			this.panelFondo.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
			this.panelFondo.Controls.Add(this.labelTitulo);
			this.panelFondo.Location = new System.Drawing.Point(0, 0);
			this.panelFondo.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
			this.panelFondo.Name = "panelFondo";
			this.panelFondo.Size = new System.Drawing.Size(1526, 100);
			this.panelFondo.TabIndex = 119;
			// 
			// labelTitulo
			// 
			this.labelTitulo.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
			this.labelTitulo.BackColor = System.Drawing.Color.Transparent;
			this.labelTitulo.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
			this.labelTitulo.Font = new System.Drawing.Font("Maiandra GD", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.labelTitulo.ForeColor = System.Drawing.Color.White;
			this.labelTitulo.Location = new System.Drawing.Point(206, 18);
			this.labelTitulo.Name = "labelTitulo";
			this.labelTitulo.Size = new System.Drawing.Size(852, 59);
			this.labelTitulo.TabIndex = 1;
			this.labelTitulo.Text = "CONSULTAR COMANDAS DE CAJERO";
			this.labelTitulo.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// labelID
			// 
			this.labelID.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
			this.labelID.BackColor = System.Drawing.Color.Transparent;
			this.labelID.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
			this.labelID.Font = new System.Drawing.Font("Maiandra GD", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.labelID.ForeColor = System.Drawing.Color.White;
			this.labelID.Location = new System.Drawing.Point(12, 114);
			this.labelID.Name = "labelID";
			this.labelID.Size = new System.Drawing.Size(210, 32);
			this.labelID.TabIndex = 117;
			this.labelID.Text = "ID DE CAJERO(A):";
			this.labelID.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// buttonBuscar
			// 
			this.buttonBuscar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
			this.buttonBuscar.BackColor = System.Drawing.Color.Transparent;
			this.buttonBuscar.Cursor = System.Windows.Forms.Cursors.Hand;
			this.buttonBuscar.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
			this.buttonBuscar.Font = new System.Drawing.Font("Maiandra GD", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.buttonBuscar.ForeColor = System.Drawing.Color.White;
			this.buttonBuscar.Location = new System.Drawing.Point(670, 114);
			this.buttonBuscar.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
			this.buttonBuscar.Name = "buttonBuscar";
			this.buttonBuscar.Size = new System.Drawing.Size(367, 71);
			this.buttonBuscar.TabIndex = 116;
			this.buttonBuscar.Text = "BUSCAR";
			this.buttonBuscar.UseVisualStyleBackColor = false;
			this.buttonBuscar.Click += new System.EventHandler(this.ButtonBuscarClick);
			// 
			// numericUpDownIDCajero
			// 
			this.numericUpDownIDCajero.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
			this.numericUpDownIDCajero.Font = new System.Drawing.Font("Lucida Bright", 15.75F);
			this.numericUpDownIDCajero.Location = new System.Drawing.Point(232, 114);
			this.numericUpDownIDCajero.Maximum = new decimal(new int[] {
			100000000,
			0,
			0,
			0});
			this.numericUpDownIDCajero.Minimum = new decimal(new int[] {
			1,
			0,
			0,
			0});
			this.numericUpDownIDCajero.Name = "numericUpDownIDCajero";
			this.numericUpDownIDCajero.Size = new System.Drawing.Size(403, 32);
			this.numericUpDownIDCajero.TabIndex = 144;
			this.numericUpDownIDCajero.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
			this.numericUpDownIDCajero.Value = new decimal(new int[] {
			1,
			0,
			0,
			0});
			// 
			// dataGridViewComandas
			// 
			this.dataGridViewComandas.AllowUserToAddRows = false;
			this.dataGridViewComandas.AllowUserToDeleteRows = false;
			dataGridViewCellStyle1.NullValue = null;
			this.dataGridViewComandas.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
			this.dataGridViewComandas.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
			| System.Windows.Forms.AnchorStyles.Right)));
			this.dataGridViewComandas.BackgroundColor = System.Drawing.Color.White;
			this.dataGridViewComandas.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
			this.dataGridViewComandas.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.Sunken;
			this.dataGridViewComandas.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
			this.dataGridViewComandas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dataGridViewComandas.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
			this.NUMERO_COMANDA,
			this.ID_COMANDA_ENCONTRADA,
			this.ID_EMPLEADO,
			this.NOMBRE_MESERO,
			this.NOMBRE_CLIENTE,
			this.NUMERO_MESA,
			this.FECHA_CREACION,
			this.ESTATUS,
			this.ID_EMPLEADO_COCINA,
			this.NOMBRE_COCINERO,
			this.ID_CAJERO,
			this.NOMBRE_CAJERO,
			this.FECHA_CIERRE,
			this.FORMA_PAGO,
			this.SUBTOTAL_COMANDA,
			this.SERVICIO,
			this.TOTAL_COMANDA,
			this.MOSTRAR_DETALLE_COMANDA});
			dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
			dataGridViewCellStyle2.BackColor = System.Drawing.Color.White;
			dataGridViewCellStyle2.Font = new System.Drawing.Font("Maiandra GD", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			dataGridViewCellStyle2.ForeColor = System.Drawing.Color.Black;
			dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
			dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.White;
			dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
			this.dataGridViewComandas.DefaultCellStyle = dataGridViewCellStyle2;
			this.dataGridViewComandas.Location = new System.Drawing.Point(10, 197);
			this.dataGridViewComandas.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
			this.dataGridViewComandas.Name = "dataGridViewComandas";
			this.dataGridViewComandas.ReadOnly = true;
			this.dataGridViewComandas.RowHeadersVisible = false;
			dataGridViewCellStyle3.Font = new System.Drawing.Font("Maiandra GD", 8F);
			this.dataGridViewComandas.RowsDefaultCellStyle = dataGridViewCellStyle3;
			this.dataGridViewComandas.RowTemplate.Height = 60;
			this.dataGridViewComandas.RowTemplate.ReadOnly = true;
			this.dataGridViewComandas.RowTemplate.Resizable = System.Windows.Forms.DataGridViewTriState.True;
			this.dataGridViewComandas.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.CellSelect;
			this.dataGridViewComandas.Size = new System.Drawing.Size(1322, 298);
			this.dataGridViewComandas.TabIndex = 150;
			this.dataGridViewComandas.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DataGridViewComandasCellContentClick);
			// 
			// dataGridViewDetalleComanda
			// 
			this.dataGridViewDetalleComanda.AllowUserToAddRows = false;
			this.dataGridViewDetalleComanda.AllowUserToDeleteRows = false;
			this.dataGridViewDetalleComanda.AllowUserToOrderColumns = true;
			this.dataGridViewDetalleComanda.AllowUserToResizeColumns = false;
			this.dataGridViewDetalleComanda.AllowUserToResizeRows = false;
			this.dataGridViewDetalleComanda.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
			| System.Windows.Forms.AnchorStyles.Right)));
			this.dataGridViewDetalleComanda.BackgroundColor = System.Drawing.Color.White;
			this.dataGridViewDetalleComanda.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
			dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
			dataGridViewCellStyle4.BackColor = System.Drawing.Color.White;
			dataGridViewCellStyle4.Font = new System.Drawing.Font("Maiandra GD", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.WindowText;
			dataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight;
			dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
			dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
			this.dataGridViewDetalleComanda.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle4;
			this.dataGridViewDetalleComanda.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dataGridViewDetalleComanda.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
			this.ID_COMANDA,
			this.ID_PRODUCTO,
			this.NOMBRE_PRODUCTO,
			this.DESCRIPCION_PRODUCTO_DETALLE,
			this.CANTIDAD,
			this.PRECIO_UNITARIO,
			this.IMPORTE});
			this.dataGridViewDetalleComanda.Location = new System.Drawing.Point(10, 503);
			this.dataGridViewDetalleComanda.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
			this.dataGridViewDetalleComanda.Name = "dataGridViewDetalleComanda";
			this.dataGridViewDetalleComanda.RowHeadersVisible = false;
			dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
			dataGridViewCellStyle5.Font = new System.Drawing.Font("Maiandra GD", 9F);
			this.dataGridViewDetalleComanda.RowsDefaultCellStyle = dataGridViewCellStyle5;
			this.dataGridViewDetalleComanda.RowTemplate.Height = 30;
			this.dataGridViewDetalleComanda.RowTemplate.ReadOnly = true;
			this.dataGridViewDetalleComanda.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.CellSelect;
			this.dataGridViewDetalleComanda.Size = new System.Drawing.Size(1322, 221);
			this.dataGridViewDetalleComanda.TabIndex = 149;
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
			// textBoxTotalComandas
			// 
			this.textBoxTotalComandas.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
			this.textBoxTotalComandas.Font = new System.Drawing.Font("Maiandra GD", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.textBoxTotalComandas.Location = new System.Drawing.Point(232, 155);
			this.textBoxTotalComandas.Name = "textBoxTotalComandas";
			this.textBoxTotalComandas.ReadOnly = true;
			this.textBoxTotalComandas.Size = new System.Drawing.Size(403, 30);
			this.textBoxTotalComandas.TabIndex = 152;
			// 
			// labelTotalComandas
			// 
			this.labelTotalComandas.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
			this.labelTotalComandas.BackColor = System.Drawing.Color.Transparent;
			this.labelTotalComandas.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
			this.labelTotalComandas.Font = new System.Drawing.Font("Maiandra GD", 14F);
			this.labelTotalComandas.ForeColor = System.Drawing.Color.White;
			this.labelTotalComandas.Location = new System.Drawing.Point(10, 155);
			this.labelTotalComandas.Name = "labelTotalComandas";
			this.labelTotalComandas.Size = new System.Drawing.Size(212, 28);
			this.labelTotalComandas.TabIndex = 151;
			this.labelTotalComandas.Text = "Total De Las Comandas: ";
			this.labelTotalComandas.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// NUMERO_COMANDA
			// 
			this.NUMERO_COMANDA.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader;
			this.NUMERO_COMANDA.HeaderText = "#";
			this.NUMERO_COMANDA.Name = "NUMERO_COMANDA";
			this.NUMERO_COMANDA.ReadOnly = true;
			this.NUMERO_COMANDA.Width = 39;
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
			// ID_CAJERO
			// 
			this.ID_CAJERO.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
			this.ID_CAJERO.HeaderText = "ID CAJERO";
			this.ID_CAJERO.Name = "ID_CAJERO";
			this.ID_CAJERO.ReadOnly = true;
			// 
			// NOMBRE_CAJERO
			// 
			this.NOMBRE_CAJERO.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
			this.NOMBRE_CAJERO.HeaderText = "NOMBRE CAJERO";
			this.NOMBRE_CAJERO.Name = "NOMBRE_CAJERO";
			this.NOMBRE_CAJERO.ReadOnly = true;
			// 
			// FECHA_CIERRE
			// 
			this.FECHA_CIERRE.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
			this.FECHA_CIERRE.HeaderText = "FECHA CIERRE";
			this.FECHA_CIERRE.Name = "FECHA_CIERRE";
			this.FECHA_CIERRE.ReadOnly = true;
			// 
			// FORMA_PAGO
			// 
			this.FORMA_PAGO.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader;
			this.FORMA_PAGO.HeaderText = "FORMA PAGO";
			this.FORMA_PAGO.Name = "FORMA_PAGO";
			this.FORMA_PAGO.ReadOnly = true;
			this.FORMA_PAGO.Width = 105;
			// 
			// SUBTOTAL_COMANDA
			// 
			this.SUBTOTAL_COMANDA.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
			this.SUBTOTAL_COMANDA.HeaderText = "SUBTOTAL";
			this.SUBTOTAL_COMANDA.Name = "SUBTOTAL_COMANDA";
			this.SUBTOTAL_COMANDA.ReadOnly = true;
			// 
			// SERVICIO
			// 
			this.SERVICIO.HeaderText = "SERVICIO";
			this.SERVICIO.Name = "SERVICIO";
			this.SERVICIO.ReadOnly = true;
			// 
			// TOTAL_COMANDA
			// 
			this.TOTAL_COMANDA.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
			this.TOTAL_COMANDA.HeaderText = "TOTAL";
			this.TOTAL_COMANDA.Name = "TOTAL_COMANDA";
			this.TOTAL_COMANDA.ReadOnly = true;
			// 
			// MOSTRAR_DETALLE_COMANDA
			// 
			this.MOSTRAR_DETALLE_COMANDA.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
			this.MOSTRAR_DETALLE_COMANDA.HeaderText = "MOSTRAR DETALLE";
			this.MOSTRAR_DETALLE_COMANDA.Name = "MOSTRAR_DETALLE_COMANDA";
			this.MOSTRAR_DETALLE_COMANDA.ReadOnly = true;
			this.MOSTRAR_DETALLE_COMANDA.Resizable = System.Windows.Forms.DataGridViewTriState.True;
			this.MOSTRAR_DETALLE_COMANDA.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
			// 
			// ComandasCajero
			// 
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
			this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
			this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
			this.ClientSize = new System.Drawing.Size(1348, 727);
			this.Controls.Add(this.textBoxTotalComandas);
			this.Controls.Add(this.labelTotalComandas);
			this.Controls.Add(this.dataGridViewComandas);
			this.Controls.Add(this.dataGridViewDetalleComanda);
			this.Controls.Add(this.numericUpDownIDCajero);
			this.Controls.Add(this.monthCalendarDiaHoy);
			this.Controls.Add(this.panelFondo);
			this.Controls.Add(this.labelID);
			this.Controls.Add(this.buttonBuscar);
			this.DoubleBuffered = true;
			this.Font = new System.Drawing.Font("Maiandra GD", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
			this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
			this.MinimumSize = new System.Drawing.Size(1364, 736);
			this.Name = "ComandasCajero";
			this.Text = "SISTEMA MEMÍN® ";
			this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
			this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.ComandasDeUnCajeroEnElDiaFormClosing);
			this.panelFondo.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.numericUpDownIDCajero)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.dataGridViewComandas)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.dataGridViewDetalleComanda)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

		}
	}
}
