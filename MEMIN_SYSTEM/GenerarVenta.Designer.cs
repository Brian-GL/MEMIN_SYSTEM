/*
 * Creado por SharpDevelop.
 * Usuario: Brian Gaytan Lomeli
 * Fecha: 27/10/2019
 * Hora: 16:55
 * 
 * Para cambiar esta plantilla use Herramientas | Opciones | Codificación | Editar Encabezados Estándar
 */
namespace MEMIN_SYSTEM
{
	partial class GenerarVenta
	{
		/// <summary>
		/// Designer variable used to keep track of non-visual components.
		/// </summary>
		private System.ComponentModel.IContainer components = null;
		private System.Windows.Forms.Panel panelFondo;
		private System.Windows.Forms.Label labelTitulo;
		private System.Windows.Forms.TabControl tabControlCobrarComandas;
		private System.Windows.Forms.TabPage tabPageComandasACobrar;
		private System.Windows.Forms.TabPage tabPageCobrarComanda;
		private System.Windows.Forms.DataGridView dataGridViewComandasCerradas;
		private System.Windows.Forms.DataGridView dataGridViewDetalleComandaCerrada;
		private System.Windows.Forms.Button buttonVerificarIDComanda;
		private System.Windows.Forms.Label labelIDComandaACobrar;
		private System.Windows.Forms.Button buttonCobrar;
		private System.Windows.Forms.ComboBox comboBoxFormaPago;
		private System.Windows.Forms.Label labelFormaDePago;
		private System.Windows.Forms.DataGridView dataGridViewComandas;
		private System.Windows.Forms.DataGridView dataGridViewDetalleComanda;
		private System.Windows.Forms.TextBox textBoxIVA;
		private System.Windows.Forms.TextBox textBoxSubtotal;
		private System.Windows.Forms.Label labelIVA;
		private System.Windows.Forms.Label labelSubtotal;
		private System.Windows.Forms.TextBox textBoxNombreEmpleado;
		private System.Windows.Forms.Label labelNombreEmpleado;
		private System.Windows.Forms.TextBox textBoxIDEmpleado;
		private System.Windows.Forms.Label labelIDEmpleado;
		private System.Windows.Forms.TextBox textBoxTotal;
		private System.Windows.Forms.Label labelTotal;
		private System.Windows.Forms.Label labelServicio;
		private System.Windows.Forms.MonthCalendar monthCalendarFechaCierreComanda;
		private System.Windows.Forms.NumericUpDown numericUpDownIDComandaCobrar;
		private System.Windows.Forms.NumericUpDown numericUpDownServicio;
		//Datagridviewcomandas cerradas
		private System.Windows.Forms.DataGridViewTextBoxColumn ID_COMANDA_CERRADA;
		private System.Windows.Forms.DataGridViewTextBoxColumn NOMBRE_CLIENTE_CERRADA;
		private System.Windows.Forms.DataGridViewTextBoxColumn NUMERO_MESA_CERRADA;
		private System.Windows.Forms.DataGridViewTextBoxColumn FECHA_CREACION_CERRADA;
		private System.Windows.Forms.DataGridViewTextBoxColumn ESTATUS_CERRADA;
		private System.Windows.Forms.DataGridViewTextBoxColumn ID_MESERO_CERRADA;
		private System.Windows.Forms.DataGridViewTextBoxColumn NOMBRE_MESERO_CERRADA;
		private System.Windows.Forms.DataGridViewImageColumn IMAGEN_MESERO_CERRADA;
		private System.Windows.Forms.DataGridViewTextBoxColumn ID_COCINERO_CERRADA;
		private System.Windows.Forms.DataGridViewTextBoxColumn NOMBRE_COCINERO_CERRADA;
		private System.Windows.Forms.DataGridViewImageColumn IMAGEN_COCINERO_CERRADA;
		private System.Windows.Forms.DataGridViewTextBoxColumn SUBTOTAL_CERRADA;
		private System.Windows.Forms.DataGridViewTextBoxColumn TOTAL_CERRADA;
		private System.Windows.Forms.DataGridViewButtonColumn MOSTRAR_DETALLE_COMANDA;
		//DATAGRIDVIEWDETALLE DE COMANDAS CERRADAS:
		private System.Windows.Forms.DataGridViewTextBoxColumn ID_COMANDA_DETALLE_COMANDA_CERRADA;
		private System.Windows.Forms.DataGridViewTextBoxColumn ID_PRODUCTO_DETALLE_COMANDA_CERRADA;
		private System.Windows.Forms.DataGridViewTextBoxColumn NOMBRE_PRODUCTO_DETALLE_COMANDA_CERRADA;
		private System.Windows.Forms.DataGridViewTextBoxColumn DESCRIPCION_DETALLE_COMANDA_CERRADA;
		private System.Windows.Forms.DataGridViewTextBoxColumn CANTIDAD_DETALLE_COMANDA_CERRADA;
		private System.Windows.Forms.DataGridViewTextBoxColumn PRECIO_UNITARIO_DETALLE_COMANDA_CERRADA;
		private System.Windows.Forms.DataGridViewTextBoxColumn IMPORTE_DETALLE_COMANDA_CERRADA;
		private System.Windows.Forms.DataGridViewTextBoxColumn ID_COMANDA_ENCONTRADA;
		private System.Windows.Forms.DataGridViewTextBoxColumn NOMBRE_CLIENTE;
		private System.Windows.Forms.DataGridViewTextBoxColumn NUMERO_MESA;
		private System.Windows.Forms.DataGridViewTextBoxColumn FECHA_CREACION;
		private System.Windows.Forms.DataGridViewTextBoxColumn ESTATUS;
		private System.Windows.Forms.DataGridViewTextBoxColumn ID_MESERO;
		private System.Windows.Forms.DataGridViewTextBoxColumn NOMBRE_MESERO;
		private System.Windows.Forms.DataGridViewTextBoxColumn ID_COCINERO;
		private System.Windows.Forms.DataGridViewTextBoxColumn NOMBRE_COCINERO;
		private System.Windows.Forms.DataGridViewTextBoxColumn ID_COMANDA;
		private System.Windows.Forms.DataGridViewTextBoxColumn ID_PRODUCTO;
		private System.Windows.Forms.DataGridViewTextBoxColumn NOMBRE_PRODUCTO;
		private System.Windows.Forms.DataGridViewTextBoxColumn DESCRIPCION_PRODUCTO_DETALLE_COMANDA;
		private System.Windows.Forms.DataGridViewTextBoxColumn CANTIDAD;
		private System.Windows.Forms.DataGridViewTextBoxColumn PRECIO_UNITARIO;
		private System.Windows.Forms.DataGridViewTextBoxColumn IMPORTE;
		private System.Windows.Forms.DataGridViewImageColumn IMAGEN_MESERO;
		private System.Windows.Forms.DataGridViewImageColumn IMAGEN_COCINERO;
		
		
		
		
		
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(GenerarVenta));
			System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
			System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
			System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
			System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
			System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
			System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
			System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
			System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle8 = new System.Windows.Forms.DataGridViewCellStyle();
			System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle9 = new System.Windows.Forms.DataGridViewCellStyle();
			System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle10 = new System.Windows.Forms.DataGridViewCellStyle();
			this.panelFondo = new System.Windows.Forms.Panel();
			this.labelTitulo = new System.Windows.Forms.Label();
			this.tabControlCobrarComandas = new System.Windows.Forms.TabControl();
			this.tabPageComandasACobrar = new System.Windows.Forms.TabPage();
			this.dataGridViewComandasCerradas = new System.Windows.Forms.DataGridView();
			this.ID_COMANDA_CERRADA = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.NOMBRE_CLIENTE_CERRADA = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.NUMERO_MESA_CERRADA = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.FECHA_CREACION_CERRADA = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.ESTATUS_CERRADA = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.ID_MESERO_CERRADA = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.NOMBRE_MESERO_CERRADA = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.IMAGEN_MESERO_CERRADA = new System.Windows.Forms.DataGridViewImageColumn();
			this.ID_COCINERO_CERRADA = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.NOMBRE_COCINERO_CERRADA = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.IMAGEN_COCINERO_CERRADA = new System.Windows.Forms.DataGridViewImageColumn();
			this.SUBTOTAL_CERRADA = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.TOTAL_CERRADA = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.MOSTRAR_DETALLE_COMANDA = new System.Windows.Forms.DataGridViewButtonColumn();
			this.dataGridViewDetalleComandaCerrada = new System.Windows.Forms.DataGridView();
			this.ID_COMANDA_DETALLE_COMANDA_CERRADA = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.ID_PRODUCTO_DETALLE_COMANDA_CERRADA = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.NOMBRE_PRODUCTO_DETALLE_COMANDA_CERRADA = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.DESCRIPCION_DETALLE_COMANDA_CERRADA = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.CANTIDAD_DETALLE_COMANDA_CERRADA = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.PRECIO_UNITARIO_DETALLE_COMANDA_CERRADA = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.IMPORTE_DETALLE_COMANDA_CERRADA = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.tabPageCobrarComanda = new System.Windows.Forms.TabPage();
			this.numericUpDownServicio = new System.Windows.Forms.NumericUpDown();
			this.numericUpDownIDComandaCobrar = new System.Windows.Forms.NumericUpDown();
			this.monthCalendarFechaCierreComanda = new System.Windows.Forms.MonthCalendar();
			this.textBoxTotal = new System.Windows.Forms.TextBox();
			this.labelTotal = new System.Windows.Forms.Label();
			this.labelServicio = new System.Windows.Forms.Label();
			this.textBoxIVA = new System.Windows.Forms.TextBox();
			this.textBoxSubtotal = new System.Windows.Forms.TextBox();
			this.labelIVA = new System.Windows.Forms.Label();
			this.labelSubtotal = new System.Windows.Forms.Label();
			this.textBoxNombreEmpleado = new System.Windows.Forms.TextBox();
			this.labelNombreEmpleado = new System.Windows.Forms.Label();
			this.comboBoxFormaPago = new System.Windows.Forms.ComboBox();
			this.labelFormaDePago = new System.Windows.Forms.Label();
			this.textBoxIDEmpleado = new System.Windows.Forms.TextBox();
			this.labelIDEmpleado = new System.Windows.Forms.Label();
			this.dataGridViewComandas = new System.Windows.Forms.DataGridView();
			this.ID_COMANDA_ENCONTRADA = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.NOMBRE_CLIENTE = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.NUMERO_MESA = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.FECHA_CREACION = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.ESTATUS = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.ID_MESERO = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.NOMBRE_MESERO = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.IMAGEN_MESERO = new System.Windows.Forms.DataGridViewImageColumn();
			this.ID_COCINERO = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.NOMBRE_COCINERO = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.IMAGEN_COCINERO = new System.Windows.Forms.DataGridViewImageColumn();
			this.dataGridViewDetalleComanda = new System.Windows.Forms.DataGridView();
			this.ID_COMANDA = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.ID_PRODUCTO = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.NOMBRE_PRODUCTO = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.DESCRIPCION_PRODUCTO_DETALLE_COMANDA = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.CANTIDAD = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.PRECIO_UNITARIO = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.IMPORTE = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.buttonCobrar = new System.Windows.Forms.Button();
			this.buttonVerificarIDComanda = new System.Windows.Forms.Button();
			this.labelIDComandaACobrar = new System.Windows.Forms.Label();
			this.panelFondo.SuspendLayout();
			this.tabControlCobrarComandas.SuspendLayout();
			this.tabPageComandasACobrar.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.dataGridViewComandasCerradas)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.dataGridViewDetalleComandaCerrada)).BeginInit();
			this.tabPageCobrarComanda.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.numericUpDownServicio)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.numericUpDownIDComandaCobrar)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.dataGridViewComandas)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.dataGridViewDetalleComanda)).BeginInit();
			this.SuspendLayout();
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
			this.panelFondo.TabIndex = 120;
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
			this.labelTitulo.Location = new System.Drawing.Point(213, 17);
			this.labelTitulo.Name = "labelTitulo";
			this.labelTitulo.Size = new System.Drawing.Size(824, 61);
			this.labelTitulo.TabIndex = 1;
			this.labelTitulo.Text = "COBRAR COMANDA";
			this.labelTitulo.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// tabControlCobrarComandas
			// 
			this.tabControlCobrarComandas.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
			| System.Windows.Forms.AnchorStyles.Right)));
			this.tabControlCobrarComandas.Appearance = System.Windows.Forms.TabAppearance.FlatButtons;
			this.tabControlCobrarComandas.Controls.Add(this.tabPageComandasACobrar);
			this.tabControlCobrarComandas.Controls.Add(this.tabPageCobrarComanda);
			this.tabControlCobrarComandas.Font = new System.Drawing.Font("Maiandra GD", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.tabControlCobrarComandas.HotTrack = true;
			this.tabControlCobrarComandas.Location = new System.Drawing.Point(0, 100);
			this.tabControlCobrarComandas.Name = "tabControlCobrarComandas";
			this.tabControlCobrarComandas.SelectedIndex = 0;
			this.tabControlCobrarComandas.Size = new System.Drawing.Size(1352, 628);
			this.tabControlCobrarComandas.TabIndex = 121;
			// 
			// tabPageComandasACobrar
			// 
			this.tabPageComandasACobrar.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("tabPageComandasACobrar.BackgroundImage")));
			this.tabPageComandasACobrar.Controls.Add(this.dataGridViewComandasCerradas);
			this.tabPageComandasACobrar.Controls.Add(this.dataGridViewDetalleComandaCerrada);
			this.tabPageComandasACobrar.Font = new System.Drawing.Font("Maiandra GD", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.tabPageComandasACobrar.Location = new System.Drawing.Point(4, 37);
			this.tabPageComandasACobrar.Name = "tabPageComandasACobrar";
			this.tabPageComandasACobrar.Padding = new System.Windows.Forms.Padding(3);
			this.tabPageComandasACobrar.Size = new System.Drawing.Size(1344, 587);
			this.tabPageComandasACobrar.TabIndex = 0;
			this.tabPageComandasACobrar.Text = "Comandas A Cobrar";
			this.tabPageComandasACobrar.UseVisualStyleBackColor = true;
			// 
			// dataGridViewComandasCerradas
			// 
			this.dataGridViewComandasCerradas.AllowUserToAddRows = false;
			this.dataGridViewComandasCerradas.AllowUserToDeleteRows = false;
			dataGridViewCellStyle1.NullValue = null;
			this.dataGridViewComandasCerradas.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
			this.dataGridViewComandasCerradas.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
			| System.Windows.Forms.AnchorStyles.Right)));
			this.dataGridViewComandasCerradas.BackgroundColor = System.Drawing.Color.White;
			this.dataGridViewComandasCerradas.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
			this.dataGridViewComandasCerradas.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.Sunken;
			this.dataGridViewComandasCerradas.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
			this.dataGridViewComandasCerradas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dataGridViewComandasCerradas.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
			this.ID_COMANDA_CERRADA,
			this.NOMBRE_CLIENTE_CERRADA,
			this.NUMERO_MESA_CERRADA,
			this.FECHA_CREACION_CERRADA,
			this.ESTATUS_CERRADA,
			this.ID_MESERO_CERRADA,
			this.NOMBRE_MESERO_CERRADA,
			this.IMAGEN_MESERO_CERRADA,
			this.ID_COCINERO_CERRADA,
			this.NOMBRE_COCINERO_CERRADA,
			this.IMAGEN_COCINERO_CERRADA,
			this.SUBTOTAL_CERRADA,
			this.TOTAL_CERRADA,
			this.MOSTRAR_DETALLE_COMANDA});
			dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
			dataGridViewCellStyle2.BackColor = System.Drawing.Color.White;
			dataGridViewCellStyle2.Font = new System.Drawing.Font("Maiandra GD", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			dataGridViewCellStyle2.ForeColor = System.Drawing.Color.Black;
			dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
			dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.White;
			dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
			this.dataGridViewComandasCerradas.DefaultCellStyle = dataGridViewCellStyle2;
			this.dataGridViewComandasCerradas.Location = new System.Drawing.Point(9, 7);
			this.dataGridViewComandasCerradas.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
			this.dataGridViewComandasCerradas.Name = "dataGridViewComandasCerradas";
			this.dataGridViewComandasCerradas.ReadOnly = true;
			this.dataGridViewComandasCerradas.RowHeadersVisible = false;
			dataGridViewCellStyle3.Font = new System.Drawing.Font("Maiandra GD", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.dataGridViewComandasCerradas.RowsDefaultCellStyle = dataGridViewCellStyle3;
			this.dataGridViewComandasCerradas.RowTemplate.Height = 100;
			this.dataGridViewComandasCerradas.RowTemplate.ReadOnly = true;
			this.dataGridViewComandasCerradas.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.CellSelect;
			this.dataGridViewComandasCerradas.Size = new System.Drawing.Size(1323, 341);
			this.dataGridViewComandasCerradas.TabIndex = 135;
			this.dataGridViewComandasCerradas.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DataGridViewComandasCerradasCellContentClick);
			// 
			// ID_COMANDA_CERRADA
			// 
			this.ID_COMANDA_CERRADA.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader;
			this.ID_COMANDA_CERRADA.HeaderText = "ID COMANDA";
			this.ID_COMANDA_CERRADA.Name = "ID_COMANDA_CERRADA";
			this.ID_COMANDA_CERRADA.ReadOnly = true;
			this.ID_COMANDA_CERRADA.Width = 104;
			// 
			// NOMBRE_CLIENTE_CERRADA
			// 
			this.NOMBRE_CLIENTE_CERRADA.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
			this.NOMBRE_CLIENTE_CERRADA.HeaderText = "NOMBRE CLIENTE";
			this.NOMBRE_CLIENTE_CERRADA.Name = "NOMBRE_CLIENTE_CERRADA";
			this.NOMBRE_CLIENTE_CERRADA.ReadOnly = true;
			// 
			// NUMERO_MESA_CERRADA
			// 
			this.NUMERO_MESA_CERRADA.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader;
			this.NUMERO_MESA_CERRADA.HeaderText = "# MESA";
			this.NUMERO_MESA_CERRADA.Name = "NUMERO_MESA_CERRADA";
			this.NUMERO_MESA_CERRADA.ReadOnly = true;
			this.NUMERO_MESA_CERRADA.Width = 69;
			// 
			// FECHA_CREACION_CERRADA
			// 
			this.FECHA_CREACION_CERRADA.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
			this.FECHA_CREACION_CERRADA.HeaderText = "FECHA CREACIÓN";
			this.FECHA_CREACION_CERRADA.Name = "FECHA_CREACION_CERRADA";
			this.FECHA_CREACION_CERRADA.ReadOnly = true;
			// 
			// ESTATUS_CERRADA
			// 
			this.ESTATUS_CERRADA.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
			this.ESTATUS_CERRADA.HeaderText = "ESTATUS";
			this.ESTATUS_CERRADA.Name = "ESTATUS_CERRADA";
			this.ESTATUS_CERRADA.ReadOnly = true;
			// 
			// ID_MESERO_CERRADA
			// 
			this.ID_MESERO_CERRADA.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader;
			this.ID_MESERO_CERRADA.HeaderText = "ID MESERO";
			this.ID_MESERO_CERRADA.Name = "ID_MESERO_CERRADA";
			this.ID_MESERO_CERRADA.ReadOnly = true;
			this.ID_MESERO_CERRADA.Width = 90;
			// 
			// NOMBRE_MESERO_CERRADA
			// 
			this.NOMBRE_MESERO_CERRADA.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
			this.NOMBRE_MESERO_CERRADA.HeaderText = "NOMBRE MESERO";
			this.NOMBRE_MESERO_CERRADA.Name = "NOMBRE_MESERO_CERRADA";
			this.NOMBRE_MESERO_CERRADA.ReadOnly = true;
			// 
			// IMAGEN_MESERO_CERRADA
			// 
			this.IMAGEN_MESERO_CERRADA.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
			this.IMAGEN_MESERO_CERRADA.HeaderText = "MESERO";
			this.IMAGEN_MESERO_CERRADA.ImageLayout = System.Windows.Forms.DataGridViewImageCellLayout.Stretch;
			this.IMAGEN_MESERO_CERRADA.Name = "IMAGEN_MESERO_CERRADA";
			this.IMAGEN_MESERO_CERRADA.ReadOnly = true;
			// 
			// ID_COCINERO_CERRADA
			// 
			this.ID_COCINERO_CERRADA.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader;
			this.ID_COCINERO_CERRADA.HeaderText = "ID COCINERO";
			this.ID_COCINERO_CERRADA.Name = "ID_COCINERO_CERRADA";
			this.ID_COCINERO_CERRADA.ReadOnly = true;
			this.ID_COCINERO_CERRADA.Resizable = System.Windows.Forms.DataGridViewTriState.True;
			this.ID_COCINERO_CERRADA.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
			this.ID_COCINERO_CERRADA.Width = 86;
			// 
			// NOMBRE_COCINERO_CERRADA
			// 
			this.NOMBRE_COCINERO_CERRADA.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
			this.NOMBRE_COCINERO_CERRADA.HeaderText = "NOMBRE COCINERO";
			this.NOMBRE_COCINERO_CERRADA.Name = "NOMBRE_COCINERO_CERRADA";
			this.NOMBRE_COCINERO_CERRADA.ReadOnly = true;
			// 
			// IMAGEN_COCINERO_CERRADA
			// 
			this.IMAGEN_COCINERO_CERRADA.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
			this.IMAGEN_COCINERO_CERRADA.HeaderText = "COCINERO";
			this.IMAGEN_COCINERO_CERRADA.ImageLayout = System.Windows.Forms.DataGridViewImageCellLayout.Stretch;
			this.IMAGEN_COCINERO_CERRADA.Name = "IMAGEN_COCINERO_CERRADA";
			this.IMAGEN_COCINERO_CERRADA.ReadOnly = true;
			// 
			// SUBTOTAL_CERRADA
			// 
			this.SUBTOTAL_CERRADA.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
			this.SUBTOTAL_CERRADA.HeaderText = "SUBTOTAL";
			this.SUBTOTAL_CERRADA.Name = "SUBTOTAL_CERRADA";
			this.SUBTOTAL_CERRADA.ReadOnly = true;
			// 
			// TOTAL_CERRADA
			// 
			this.TOTAL_CERRADA.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
			this.TOTAL_CERRADA.HeaderText = "TOTAL";
			this.TOTAL_CERRADA.Name = "TOTAL_CERRADA";
			this.TOTAL_CERRADA.ReadOnly = true;
			// 
			// MOSTRAR_DETALLE_COMANDA
			// 
			this.MOSTRAR_DETALLE_COMANDA.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader;
			this.MOSTRAR_DETALLE_COMANDA.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
			this.MOSTRAR_DETALLE_COMANDA.HeaderText = "MOSTRAR DETALLE";
			this.MOSTRAR_DETALLE_COMANDA.Name = "MOSTRAR_DETALLE_COMANDA";
			this.MOSTRAR_DETALLE_COMANDA.ReadOnly = true;
			this.MOSTRAR_DETALLE_COMANDA.Width = 114;
			// 
			// dataGridViewDetalleComandaCerrada
			// 
			this.dataGridViewDetalleComandaCerrada.AllowUserToAddRows = false;
			this.dataGridViewDetalleComandaCerrada.AllowUserToDeleteRows = false;
			this.dataGridViewDetalleComandaCerrada.AllowUserToOrderColumns = true;
			this.dataGridViewDetalleComandaCerrada.AllowUserToResizeColumns = false;
			this.dataGridViewDetalleComandaCerrada.AllowUserToResizeRows = false;
			this.dataGridViewDetalleComandaCerrada.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
			| System.Windows.Forms.AnchorStyles.Right)));
			this.dataGridViewDetalleComandaCerrada.BackgroundColor = System.Drawing.Color.White;
			this.dataGridViewDetalleComandaCerrada.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
			dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
			dataGridViewCellStyle4.BackColor = System.Drawing.Color.White;
			dataGridViewCellStyle4.Font = new System.Drawing.Font("Maiandra GD", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.WindowText;
			dataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight;
			dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
			dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
			this.dataGridViewDetalleComandaCerrada.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle4;
			this.dataGridViewDetalleComandaCerrada.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dataGridViewDetalleComandaCerrada.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
			this.ID_COMANDA_DETALLE_COMANDA_CERRADA,
			this.ID_PRODUCTO_DETALLE_COMANDA_CERRADA,
			this.NOMBRE_PRODUCTO_DETALLE_COMANDA_CERRADA,
			this.DESCRIPCION_DETALLE_COMANDA_CERRADA,
			this.CANTIDAD_DETALLE_COMANDA_CERRADA,
			this.PRECIO_UNITARIO_DETALLE_COMANDA_CERRADA,
			this.IMPORTE_DETALLE_COMANDA_CERRADA});
			this.dataGridViewDetalleComandaCerrada.Location = new System.Drawing.Point(6, 356);
			this.dataGridViewDetalleComandaCerrada.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
			this.dataGridViewDetalleComandaCerrada.Name = "dataGridViewDetalleComandaCerrada";
			this.dataGridViewDetalleComandaCerrada.RowHeadersVisible = false;
			dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
			dataGridViewCellStyle5.Font = new System.Drawing.Font("Maiandra GD", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.dataGridViewDetalleComandaCerrada.RowsDefaultCellStyle = dataGridViewCellStyle5;
			this.dataGridViewDetalleComandaCerrada.RowTemplate.Height = 40;
			this.dataGridViewDetalleComandaCerrada.RowTemplate.ReadOnly = true;
			this.dataGridViewDetalleComandaCerrada.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.CellSelect;
			this.dataGridViewDetalleComandaCerrada.Size = new System.Drawing.Size(1326, 224);
			this.dataGridViewDetalleComandaCerrada.TabIndex = 134;
			// 
			// ID_COMANDA_DETALLE_COMANDA_CERRADA
			// 
			this.ID_COMANDA_DETALLE_COMANDA_CERRADA.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader;
			this.ID_COMANDA_DETALLE_COMANDA_CERRADA.HeaderText = "ID COMANDA";
			this.ID_COMANDA_DETALLE_COMANDA_CERRADA.Name = "ID_COMANDA_DETALLE_COMANDA_CERRADA";
			this.ID_COMANDA_DETALLE_COMANDA_CERRADA.Width = 104;
			// 
			// ID_PRODUCTO_DETALLE_COMANDA_CERRADA
			// 
			this.ID_PRODUCTO_DETALLE_COMANDA_CERRADA.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader;
			this.ID_PRODUCTO_DETALLE_COMANDA_CERRADA.HeaderText = "ID PRODUCTO";
			this.ID_PRODUCTO_DETALLE_COMANDA_CERRADA.Name = "ID_PRODUCTO_DETALLE_COMANDA_CERRADA";
			this.ID_PRODUCTO_DETALLE_COMANDA_CERRADA.Width = 108;
			// 
			// NOMBRE_PRODUCTO_DETALLE_COMANDA_CERRADA
			// 
			this.NOMBRE_PRODUCTO_DETALLE_COMANDA_CERRADA.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
			this.NOMBRE_PRODUCTO_DETALLE_COMANDA_CERRADA.HeaderText = "NOMBRE PRODUCTO";
			this.NOMBRE_PRODUCTO_DETALLE_COMANDA_CERRADA.Name = "NOMBRE_PRODUCTO_DETALLE_COMANDA_CERRADA";
			// 
			// DESCRIPCION_DETALLE_COMANDA_CERRADA
			// 
			this.DESCRIPCION_DETALLE_COMANDA_CERRADA.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
			this.DESCRIPCION_DETALLE_COMANDA_CERRADA.HeaderText = "DESCRIPCIÓN";
			this.DESCRIPCION_DETALLE_COMANDA_CERRADA.Name = "DESCRIPCION_DETALLE_COMANDA_CERRADA";
			// 
			// CANTIDAD_DETALLE_COMANDA_CERRADA
			// 
			this.CANTIDAD_DETALLE_COMANDA_CERRADA.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader;
			this.CANTIDAD_DETALLE_COMANDA_CERRADA.HeaderText = "CANTIDAD";
			this.CANTIDAD_DETALLE_COMANDA_CERRADA.Name = "CANTIDAD_DETALLE_COMANDA_CERRADA";
			this.CANTIDAD_DETALLE_COMANDA_CERRADA.Width = 96;
			// 
			// PRECIO_UNITARIO_DETALLE_COMANDA_CERRADA
			// 
			this.PRECIO_UNITARIO_DETALLE_COMANDA_CERRADA.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
			this.PRECIO_UNITARIO_DETALLE_COMANDA_CERRADA.HeaderText = "PRECIO UNITARIO";
			this.PRECIO_UNITARIO_DETALLE_COMANDA_CERRADA.Name = "PRECIO_UNITARIO_DETALLE_COMANDA_CERRADA";
			// 
			// IMPORTE_DETALLE_COMANDA_CERRADA
			// 
			this.IMPORTE_DETALLE_COMANDA_CERRADA.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
			this.IMPORTE_DETALLE_COMANDA_CERRADA.HeaderText = "IMPORTE";
			this.IMPORTE_DETALLE_COMANDA_CERRADA.Name = "IMPORTE_DETALLE_COMANDA_CERRADA";
			// 
			// tabPageCobrarComanda
			// 
			this.tabPageCobrarComanda.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("tabPageCobrarComanda.BackgroundImage")));
			this.tabPageCobrarComanda.Controls.Add(this.numericUpDownServicio);
			this.tabPageCobrarComanda.Controls.Add(this.numericUpDownIDComandaCobrar);
			this.tabPageCobrarComanda.Controls.Add(this.monthCalendarFechaCierreComanda);
			this.tabPageCobrarComanda.Controls.Add(this.textBoxTotal);
			this.tabPageCobrarComanda.Controls.Add(this.labelTotal);
			this.tabPageCobrarComanda.Controls.Add(this.labelServicio);
			this.tabPageCobrarComanda.Controls.Add(this.textBoxIVA);
			this.tabPageCobrarComanda.Controls.Add(this.textBoxSubtotal);
			this.tabPageCobrarComanda.Controls.Add(this.labelIVA);
			this.tabPageCobrarComanda.Controls.Add(this.labelSubtotal);
			this.tabPageCobrarComanda.Controls.Add(this.textBoxNombreEmpleado);
			this.tabPageCobrarComanda.Controls.Add(this.labelNombreEmpleado);
			this.tabPageCobrarComanda.Controls.Add(this.comboBoxFormaPago);
			this.tabPageCobrarComanda.Controls.Add(this.labelFormaDePago);
			this.tabPageCobrarComanda.Controls.Add(this.textBoxIDEmpleado);
			this.tabPageCobrarComanda.Controls.Add(this.labelIDEmpleado);
			this.tabPageCobrarComanda.Controls.Add(this.dataGridViewComandas);
			this.tabPageCobrarComanda.Controls.Add(this.dataGridViewDetalleComanda);
			this.tabPageCobrarComanda.Controls.Add(this.buttonCobrar);
			this.tabPageCobrarComanda.Controls.Add(this.buttonVerificarIDComanda);
			this.tabPageCobrarComanda.Controls.Add(this.labelIDComandaACobrar);
			this.tabPageCobrarComanda.Font = new System.Drawing.Font("Maiandra GD", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.tabPageCobrarComanda.Location = new System.Drawing.Point(4, 37);
			this.tabPageCobrarComanda.Name = "tabPageCobrarComanda";
			this.tabPageCobrarComanda.Padding = new System.Windows.Forms.Padding(3);
			this.tabPageCobrarComanda.Size = new System.Drawing.Size(1344, 587);
			this.tabPageCobrarComanda.TabIndex = 1;
			this.tabPageCobrarComanda.Text = "Cobrar Comanda";
			this.tabPageCobrarComanda.UseVisualStyleBackColor = true;
			// 
			// numericUpDownServicio
			// 
			this.numericUpDownServicio.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
			this.numericUpDownServicio.DecimalPlaces = 2;
			this.numericUpDownServicio.Enabled = false;
			this.numericUpDownServicio.Font = new System.Drawing.Font("Maiandra GD", 14.25F);
			this.numericUpDownServicio.Location = new System.Drawing.Point(603, 512);
			this.numericUpDownServicio.Maximum = new decimal(new int[] {
			99999999,
			0,
			0,
			0});
			this.numericUpDownServicio.Name = "numericUpDownServicio";
			this.numericUpDownServicio.Size = new System.Drawing.Size(228, 30);
			this.numericUpDownServicio.TabIndex = 119;
			this.numericUpDownServicio.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
			this.numericUpDownServicio.ValueChanged += new System.EventHandler(this.NumericUpDownServicioValueChanged);
			// 
			// numericUpDownIDComandaCobrar
			// 
			this.numericUpDownIDComandaCobrar.Font = new System.Drawing.Font("Lucida Bright", 15F);
			this.numericUpDownIDComandaCobrar.Location = new System.Drawing.Point(304, 11);
			this.numericUpDownIDComandaCobrar.Maximum = new decimal(new int[] {
			1000000,
			0,
			0,
			0});
			this.numericUpDownIDComandaCobrar.Minimum = new decimal(new int[] {
			1,
			0,
			0,
			0});
			this.numericUpDownIDComandaCobrar.Name = "numericUpDownIDComandaCobrar";
			this.numericUpDownIDComandaCobrar.Size = new System.Drawing.Size(527, 31);
			this.numericUpDownIDComandaCobrar.TabIndex = 117;
			this.numericUpDownIDComandaCobrar.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
			this.numericUpDownIDComandaCobrar.Value = new decimal(new int[] {
			1,
			0,
			0,
			0});
			// 
			// monthCalendarFechaCierreComanda
			// 
			this.monthCalendarFechaCierreComanda.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
			| System.Windows.Forms.AnchorStyles.Right)));
			this.monthCalendarFechaCierreComanda.Location = new System.Drawing.Point(1134, 269);
			this.monthCalendarFechaCierreComanda.Name = "monthCalendarFechaCierreComanda";
			this.monthCalendarFechaCierreComanda.TabIndex = 103;
			// 
			// textBoxTotal
			// 
			this.textBoxTotal.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
			this.textBoxTotal.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
			this.textBoxTotal.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.HistoryList;
			this.textBoxTotal.Font = new System.Drawing.Font("Maiandra GD", 14.25F);
			this.textBoxTotal.Location = new System.Drawing.Point(854, 551);
			this.textBoxTotal.Name = "textBoxTotal";
			this.textBoxTotal.ReadOnly = true;
			this.textBoxTotal.ScrollBars = System.Windows.Forms.ScrollBars.Horizontal;
			this.textBoxTotal.Size = new System.Drawing.Size(264, 30);
			this.textBoxTotal.TabIndex = 102;
			// 
			// labelTotal
			// 
			this.labelTotal.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
			this.labelTotal.BackColor = System.Drawing.Color.Transparent;
			this.labelTotal.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
			this.labelTotal.Font = new System.Drawing.Font("Maiandra GD", 14.25F);
			this.labelTotal.ForeColor = System.Drawing.Color.White;
			this.labelTotal.Location = new System.Drawing.Point(943, 510);
			this.labelTotal.Name = "labelTotal";
			this.labelTotal.Size = new System.Drawing.Size(99, 30);
			this.labelTotal.TabIndex = 101;
			this.labelTotal.Text = "TOTAL:";
			this.labelTotal.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// labelServicio
			// 
			this.labelServicio.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
			this.labelServicio.BackColor = System.Drawing.Color.Transparent;
			this.labelServicio.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
			this.labelServicio.Font = new System.Drawing.Font("Maiandra GD", 14.25F);
			this.labelServicio.ForeColor = System.Drawing.Color.WhiteSmoke;
			this.labelServicio.Location = new System.Drawing.Point(485, 510);
			this.labelServicio.Name = "labelServicio";
			this.labelServicio.Size = new System.Drawing.Size(108, 30);
			this.labelServicio.TabIndex = 99;
			this.labelServicio.Text = "SERVICIO:";
			this.labelServicio.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// textBoxIVA
			// 
			this.textBoxIVA.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
			this.textBoxIVA.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
			this.textBoxIVA.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.HistoryList;
			this.textBoxIVA.Font = new System.Drawing.Font("Maiandra GD", 14.25F);
			this.textBoxIVA.Location = new System.Drawing.Point(603, 551);
			this.textBoxIVA.Name = "textBoxIVA";
			this.textBoxIVA.ReadOnly = true;
			this.textBoxIVA.ScrollBars = System.Windows.Forms.ScrollBars.Horizontal;
			this.textBoxIVA.Size = new System.Drawing.Size(228, 30);
			this.textBoxIVA.TabIndex = 98;
			// 
			// textBoxSubtotal
			// 
			this.textBoxSubtotal.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
			this.textBoxSubtotal.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
			this.textBoxSubtotal.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.HistoryList;
			this.textBoxSubtotal.Font = new System.Drawing.Font("Maiandra GD", 14.25F);
			this.textBoxSubtotal.Location = new System.Drawing.Point(207, 551);
			this.textBoxSubtotal.Name = "textBoxSubtotal";
			this.textBoxSubtotal.ReadOnly = true;
			this.textBoxSubtotal.ScrollBars = System.Windows.Forms.ScrollBars.Horizontal;
			this.textBoxSubtotal.Size = new System.Drawing.Size(272, 30);
			this.textBoxSubtotal.TabIndex = 97;
			// 
			// labelIVA
			// 
			this.labelIVA.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
			this.labelIVA.BackColor = System.Drawing.Color.Transparent;
			this.labelIVA.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
			this.labelIVA.Font = new System.Drawing.Font("Maiandra GD", 14.25F);
			this.labelIVA.ForeColor = System.Drawing.Color.White;
			this.labelIVA.Location = new System.Drawing.Point(485, 551);
			this.labelIVA.Name = "labelIVA";
			this.labelIVA.Size = new System.Drawing.Size(108, 30);
			this.labelIVA.TabIndex = 96;
			this.labelIVA.Text = "IVA:";
			this.labelIVA.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// labelSubtotal
			// 
			this.labelSubtotal.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
			this.labelSubtotal.BackColor = System.Drawing.Color.Transparent;
			this.labelSubtotal.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
			this.labelSubtotal.Font = new System.Drawing.Font("Maiandra GD", 14.25F);
			this.labelSubtotal.ForeColor = System.Drawing.Color.White;
			this.labelSubtotal.Location = new System.Drawing.Point(13, 551);
			this.labelSubtotal.Name = "labelSubtotal";
			this.labelSubtotal.Size = new System.Drawing.Size(183, 30);
			this.labelSubtotal.TabIndex = 95;
			this.labelSubtotal.Text = "SUBTOTAL:";
			this.labelSubtotal.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// textBoxNombreEmpleado
			// 
			this.textBoxNombreEmpleado.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
			this.textBoxNombreEmpleado.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
			this.textBoxNombreEmpleado.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.HistoryList;
			this.textBoxNombreEmpleado.Enabled = false;
			this.textBoxNombreEmpleado.Font = new System.Drawing.Font("Maiandra GD", 14.25F);
			this.textBoxNombreEmpleado.Location = new System.Drawing.Point(970, 54);
			this.textBoxNombreEmpleado.Name = "textBoxNombreEmpleado";
			this.textBoxNombreEmpleado.ReadOnly = true;
			this.textBoxNombreEmpleado.ScrollBars = System.Windows.Forms.ScrollBars.Horizontal;
			this.textBoxNombreEmpleado.Size = new System.Drawing.Size(362, 30);
			this.textBoxNombreEmpleado.TabIndex = 94;
			// 
			// labelNombreEmpleado
			// 
			this.labelNombreEmpleado.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
			this.labelNombreEmpleado.BackColor = System.Drawing.Color.Transparent;
			this.labelNombreEmpleado.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
			this.labelNombreEmpleado.Font = new System.Drawing.Font("Maiandra GD", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.labelNombreEmpleado.ForeColor = System.Drawing.Color.White;
			this.labelNombreEmpleado.Location = new System.Drawing.Point(685, 54);
			this.labelNombreEmpleado.Name = "labelNombreEmpleado";
			this.labelNombreEmpleado.Size = new System.Drawing.Size(270, 30);
			this.labelNombreEmpleado.TabIndex = 93;
			this.labelNombreEmpleado.Text = "NOMBRE DEL EMPLEADO:";
			this.labelNombreEmpleado.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// comboBoxFormaPago
			// 
			this.comboBoxFormaPago.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
			this.comboBoxFormaPago.Enabled = false;
			this.comboBoxFormaPago.Font = new System.Drawing.Font("Maiandra GD", 14.25F);
			this.comboBoxFormaPago.FormattingEnabled = true;
			this.comboBoxFormaPago.Items.AddRange(new object[] {
			"EFECTIVO",
			"TARJETA"});
			this.comboBoxFormaPago.Location = new System.Drawing.Point(207, 510);
			this.comboBoxFormaPago.Name = "comboBoxFormaPago";
			this.comboBoxFormaPago.Size = new System.Drawing.Size(272, 30);
			this.comboBoxFormaPago.TabIndex = 90;
			this.comboBoxFormaPago.Text = "TARJETA";
			// 
			// labelFormaDePago
			// 
			this.labelFormaDePago.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
			this.labelFormaDePago.BackColor = System.Drawing.Color.Transparent;
			this.labelFormaDePago.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
			this.labelFormaDePago.Font = new System.Drawing.Font("Maiandra GD", 14.25F);
			this.labelFormaDePago.ForeColor = System.Drawing.Color.White;
			this.labelFormaDePago.Location = new System.Drawing.Point(13, 510);
			this.labelFormaDePago.Name = "labelFormaDePago";
			this.labelFormaDePago.Size = new System.Drawing.Size(183, 30);
			this.labelFormaDePago.TabIndex = 89;
			this.labelFormaDePago.Text = "FORMA DE PAGO:";
			this.labelFormaDePago.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// textBoxIDEmpleado
			// 
			this.textBoxIDEmpleado.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
			this.textBoxIDEmpleado.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
			this.textBoxIDEmpleado.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.HistoryList;
			this.textBoxIDEmpleado.Enabled = false;
			this.textBoxIDEmpleado.Font = new System.Drawing.Font("Maiandra GD", 14.25F);
			this.textBoxIDEmpleado.Location = new System.Drawing.Point(304, 54);
			this.textBoxIDEmpleado.Name = "textBoxIDEmpleado";
			this.textBoxIDEmpleado.ReadOnly = true;
			this.textBoxIDEmpleado.ScrollBars = System.Windows.Forms.ScrollBars.Horizontal;
			this.textBoxIDEmpleado.Size = new System.Drawing.Size(375, 30);
			this.textBoxIDEmpleado.TabIndex = 88;
			// 
			// labelIDEmpleado
			// 
			this.labelIDEmpleado.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
			this.labelIDEmpleado.BackColor = System.Drawing.Color.Transparent;
			this.labelIDEmpleado.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
			this.labelIDEmpleado.Font = new System.Drawing.Font("Maiandra GD", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.labelIDEmpleado.ForeColor = System.Drawing.Color.White;
			this.labelIDEmpleado.Location = new System.Drawing.Point(6, 54);
			this.labelIDEmpleado.Name = "labelIDEmpleado";
			this.labelIDEmpleado.Size = new System.Drawing.Size(281, 30);
			this.labelIDEmpleado.TabIndex = 87;
			this.labelIDEmpleado.Text = "ID DEL EMPLEADO:";
			this.labelIDEmpleado.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// dataGridViewComandas
			// 
			this.dataGridViewComandas.AllowUserToAddRows = false;
			this.dataGridViewComandas.AllowUserToDeleteRows = false;
			dataGridViewCellStyle6.NullValue = null;
			this.dataGridViewComandas.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle6;
			this.dataGridViewComandas.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
			| System.Windows.Forms.AnchorStyles.Right)));
			this.dataGridViewComandas.BackgroundColor = System.Drawing.Color.White;
			this.dataGridViewComandas.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
			this.dataGridViewComandas.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.Sunken;
			this.dataGridViewComandas.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
			this.dataGridViewComandas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dataGridViewComandas.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
			this.ID_COMANDA_ENCONTRADA,
			this.NOMBRE_CLIENTE,
			this.NUMERO_MESA,
			this.FECHA_CREACION,
			this.ESTATUS,
			this.ID_MESERO,
			this.NOMBRE_MESERO,
			this.IMAGEN_MESERO,
			this.ID_COCINERO,
			this.NOMBRE_COCINERO,
			this.IMAGEN_COCINERO});
			dataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
			dataGridViewCellStyle7.BackColor = System.Drawing.Color.White;
			dataGridViewCellStyle7.Font = new System.Drawing.Font("Maiandra GD", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			dataGridViewCellStyle7.ForeColor = System.Drawing.Color.Black;
			dataGridViewCellStyle7.SelectionBackColor = System.Drawing.SystemColors.Highlight;
			dataGridViewCellStyle7.SelectionForeColor = System.Drawing.Color.White;
			dataGridViewCellStyle7.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
			this.dataGridViewComandas.DefaultCellStyle = dataGridViewCellStyle7;
			this.dataGridViewComandas.Location = new System.Drawing.Point(6, 99);
			this.dataGridViewComandas.Name = "dataGridViewComandas";
			this.dataGridViewComandas.ReadOnly = true;
			this.dataGridViewComandas.RowHeadersVisible = false;
			dataGridViewCellStyle8.Font = new System.Drawing.Font("Maiandra GD", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.dataGridViewComandas.RowsDefaultCellStyle = dataGridViewCellStyle8;
			this.dataGridViewComandas.RowTemplate.Height = 85;
			this.dataGridViewComandas.RowTemplate.ReadOnly = true;
			this.dataGridViewComandas.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.CellSelect;
			this.dataGridViewComandas.Size = new System.Drawing.Size(1326, 120);
			this.dataGridViewComandas.TabIndex = 86;
			// 
			// ID_COMANDA_ENCONTRADA
			// 
			this.ID_COMANDA_ENCONTRADA.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader;
			this.ID_COMANDA_ENCONTRADA.HeaderText = "ID COMANDA";
			this.ID_COMANDA_ENCONTRADA.Name = "ID_COMANDA_ENCONTRADA";
			this.ID_COMANDA_ENCONTRADA.ReadOnly = true;
			this.ID_COMANDA_ENCONTRADA.Width = 104;
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
			this.NUMERO_MESA.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader;
			this.NUMERO_MESA.HeaderText = "# MESA";
			this.NUMERO_MESA.Name = "NUMERO_MESA";
			this.NUMERO_MESA.ReadOnly = true;
			this.NUMERO_MESA.Width = 69;
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
			this.ESTATUS.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader;
			this.ESTATUS.HeaderText = "ESTATUS";
			this.ESTATUS.Name = "ESTATUS";
			this.ESTATUS.ReadOnly = true;
			this.ESTATUS.Width = 84;
			// 
			// ID_MESERO
			// 
			this.ID_MESERO.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader;
			this.ID_MESERO.HeaderText = "ID MESERO";
			this.ID_MESERO.Name = "ID_MESERO";
			this.ID_MESERO.ReadOnly = true;
			this.ID_MESERO.Width = 90;
			// 
			// NOMBRE_MESERO
			// 
			this.NOMBRE_MESERO.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
			this.NOMBRE_MESERO.HeaderText = "NOMBRE MESERO";
			this.NOMBRE_MESERO.Name = "NOMBRE_MESERO";
			this.NOMBRE_MESERO.ReadOnly = true;
			// 
			// IMAGEN_MESERO
			// 
			this.IMAGEN_MESERO.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
			this.IMAGEN_MESERO.HeaderText = "MESERO";
			this.IMAGEN_MESERO.ImageLayout = System.Windows.Forms.DataGridViewImageCellLayout.Stretch;
			this.IMAGEN_MESERO.Name = "IMAGEN_MESERO";
			this.IMAGEN_MESERO.ReadOnly = true;
			this.IMAGEN_MESERO.Width = 62;
			// 
			// ID_COCINERO
			// 
			this.ID_COCINERO.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader;
			this.ID_COCINERO.HeaderText = "ID COCINERO";
			this.ID_COCINERO.Name = "ID_COCINERO";
			this.ID_COCINERO.ReadOnly = true;
			this.ID_COCINERO.Width = 105;
			// 
			// NOMBRE_COCINERO
			// 
			this.NOMBRE_COCINERO.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
			this.NOMBRE_COCINERO.HeaderText = "NOMBRE COCINERO";
			this.NOMBRE_COCINERO.Name = "NOMBRE_COCINERO";
			this.NOMBRE_COCINERO.ReadOnly = true;
			// 
			// IMAGEN_COCINERO
			// 
			this.IMAGEN_COCINERO.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
			this.IMAGEN_COCINERO.HeaderText = "COCINERO";
			this.IMAGEN_COCINERO.ImageLayout = System.Windows.Forms.DataGridViewImageCellLayout.Stretch;
			this.IMAGEN_COCINERO.Name = "IMAGEN_COCINERO";
			this.IMAGEN_COCINERO.ReadOnly = true;
			// 
			// dataGridViewDetalleComanda
			// 
			this.dataGridViewDetalleComanda.AllowUserToAddRows = false;
			this.dataGridViewDetalleComanda.AllowUserToDeleteRows = false;
			this.dataGridViewDetalleComanda.AllowUserToOrderColumns = true;
			this.dataGridViewDetalleComanda.AllowUserToResizeColumns = false;
			this.dataGridViewDetalleComanda.AllowUserToResizeRows = false;
			this.dataGridViewDetalleComanda.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
			this.dataGridViewDetalleComanda.BackgroundColor = System.Drawing.Color.White;
			this.dataGridViewDetalleComanda.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
			this.dataGridViewDetalleComanda.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
			dataGridViewCellStyle9.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
			dataGridViewCellStyle9.BackColor = System.Drawing.Color.WhiteSmoke;
			dataGridViewCellStyle9.Font = new System.Drawing.Font("Maiandra GD", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			dataGridViewCellStyle9.ForeColor = System.Drawing.SystemColors.WindowText;
			dataGridViewCellStyle9.SelectionBackColor = System.Drawing.SystemColors.Highlight;
			dataGridViewCellStyle9.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
			dataGridViewCellStyle9.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
			this.dataGridViewDetalleComanda.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle9;
			this.dataGridViewDetalleComanda.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dataGridViewDetalleComanda.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
			this.ID_COMANDA,
			this.ID_PRODUCTO,
			this.NOMBRE_PRODUCTO,
			this.DESCRIPCION_PRODUCTO_DETALLE_COMANDA,
			this.CANTIDAD,
			this.PRECIO_UNITARIO,
			this.IMPORTE});
			this.dataGridViewDetalleComanda.Location = new System.Drawing.Point(6, 237);
			this.dataGridViewDetalleComanda.Name = "dataGridViewDetalleComanda";
			this.dataGridViewDetalleComanda.RowHeadersVisible = false;
			dataGridViewCellStyle10.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
			dataGridViewCellStyle10.Font = new System.Drawing.Font("Maiandra GD", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.dataGridViewDetalleComanda.RowsDefaultCellStyle = dataGridViewCellStyle10;
			this.dataGridViewDetalleComanda.RowTemplate.Height = 20;
			this.dataGridViewDetalleComanda.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.CellSelect;
			this.dataGridViewDetalleComanda.Size = new System.Drawing.Size(1116, 250);
			this.dataGridViewDetalleComanda.TabIndex = 85;
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
			// DESCRIPCION_PRODUCTO_DETALLE_COMANDA
			// 
			this.DESCRIPCION_PRODUCTO_DETALLE_COMANDA.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
			this.DESCRIPCION_PRODUCTO_DETALLE_COMANDA.HeaderText = "DESCRIPCIÓN";
			this.DESCRIPCION_PRODUCTO_DETALLE_COMANDA.Name = "DESCRIPCION_PRODUCTO_DETALLE_COMANDA";
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
			// buttonCobrar
			// 
			this.buttonCobrar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
			this.buttonCobrar.BackColor = System.Drawing.Color.Transparent;
			this.buttonCobrar.Cursor = System.Windows.Forms.Cursors.Hand;
			this.buttonCobrar.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
			this.buttonCobrar.Font = new System.Drawing.Font("Maiandra GD", 22F);
			this.buttonCobrar.ForeColor = System.Drawing.Color.White;
			this.buttonCobrar.Location = new System.Drawing.Point(1146, 498);
			this.buttonCobrar.Name = "buttonCobrar";
			this.buttonCobrar.Size = new System.Drawing.Size(186, 83);
			this.buttonCobrar.TabIndex = 45;
			this.buttonCobrar.Text = "COBRAR";
			this.buttonCobrar.UseVisualStyleBackColor = false;
			this.buttonCobrar.Click += new System.EventHandler(this.ButtonCobrarClick);
			// 
			// buttonVerificarIDComanda
			// 
			this.buttonVerificarIDComanda.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
			this.buttonVerificarIDComanda.BackColor = System.Drawing.Color.Transparent;
			this.buttonVerificarIDComanda.Cursor = System.Windows.Forms.Cursors.Hand;
			this.buttonVerificarIDComanda.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
			this.buttonVerificarIDComanda.Font = new System.Drawing.Font("Maiandra GD", 14.25F);
			this.buttonVerificarIDComanda.ForeColor = System.Drawing.Color.White;
			this.buttonVerificarIDComanda.Location = new System.Drawing.Point(854, 11);
			this.buttonVerificarIDComanda.Name = "buttonVerificarIDComanda";
			this.buttonVerificarIDComanda.Size = new System.Drawing.Size(478, 32);
			this.buttonVerificarIDComanda.TabIndex = 44;
			this.buttonVerificarIDComanda.Text = "VERIFICAR ID";
			this.buttonVerificarIDComanda.UseVisualStyleBackColor = false;
			this.buttonVerificarIDComanda.Click += new System.EventHandler(this.ButtonVerificarIDComandaClick);
			// 
			// labelIDComandaACobrar
			// 
			this.labelIDComandaACobrar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
			this.labelIDComandaACobrar.BackColor = System.Drawing.Color.Transparent;
			this.labelIDComandaACobrar.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
			this.labelIDComandaACobrar.Font = new System.Drawing.Font("Maiandra GD", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.labelIDComandaACobrar.ForeColor = System.Drawing.Color.White;
			this.labelIDComandaACobrar.Location = new System.Drawing.Point(6, 11);
			this.labelIDComandaACobrar.Name = "labelIDComandaACobrar";
			this.labelIDComandaACobrar.Size = new System.Drawing.Size(281, 30);
			this.labelIDComandaACobrar.TabIndex = 42;
			this.labelIDComandaACobrar.Text = "ID DE COMANDA A COBRAR:";
			this.labelIDComandaACobrar.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// GenerarVenta
			// 
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
			this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
			this.ClientSize = new System.Drawing.Size(1348, 727);
			this.Controls.Add(this.tabControlCobrarComandas);
			this.Controls.Add(this.panelFondo);
			this.Font = new System.Drawing.Font("Maiandra GD", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.HelpButton = true;
			this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
			this.MinimumSize = new System.Drawing.Size(1364, 736);
			this.Name = "GenerarVenta";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "SISTEMA MEMÍN® ";
			this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
			this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.GenerarVentaFormClosing);
			this.Load += new System.EventHandler(this.GenerarVentaLoad);
			this.panelFondo.ResumeLayout(false);
			this.tabControlCobrarComandas.ResumeLayout(false);
			this.tabPageComandasACobrar.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.dataGridViewComandasCerradas)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.dataGridViewDetalleComandaCerrada)).EndInit();
			this.tabPageCobrarComanda.ResumeLayout(false);
			this.tabPageCobrarComanda.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.numericUpDownServicio)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.numericUpDownIDComandaCobrar)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.dataGridViewComandas)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.dataGridViewDetalleComanda)).EndInit();
			this.ResumeLayout(false);

		}
	}
}
