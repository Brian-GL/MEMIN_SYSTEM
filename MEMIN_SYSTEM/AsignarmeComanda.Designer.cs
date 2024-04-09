/*
 * Creado por SharpDevelop.
 * Usuario: Brian Gaytan Lomeli
 * Fecha: 27/10/2019
 * Hora: 13:22
 * 
 * Para cambiar esta plantilla use Herramientas | Opciones | Codificación | Editar Encabezados Estándar
 */
namespace MEMIN_SYSTEM
{
	partial class AsignarmeComanda
	{
		/// <summary>
		/// Designer variable used to keep track of non-visual components.
		/// </summary>
		private System.ComponentModel.IContainer components = null;
		private System.Windows.Forms.Button buttonAsignarme;
		private System.Windows.Forms.Panel panelFondo;
		private System.Windows.Forms.Label labelTitulo;
		private System.Windows.Forms.TabControl tabControlAsignarComandas;
		private System.Windows.Forms.TabPage tabPageComandasAPreparar;
		private System.Windows.Forms.DataGridView dataGridViewComandasPedidas;
		private System.Windows.Forms.DataGridView dataGridViewDetalleComandaPedidas;
		private System.Windows.Forms.TabPage tabPageAsignarComanda;
		private System.Windows.Forms.MonthCalendar monthCalendarFechaCierreComanda;
		private System.Windows.Forms.TextBox textBoxNombreEmpleado;
		private System.Windows.Forms.Label labelNombreEmpleado;
		private System.Windows.Forms.TextBox textBoxIDEmpleado;
		private System.Windows.Forms.Label labelIDEmpleado;
		private System.Windows.Forms.Button buttonCobrar;
		private System.Windows.Forms.Button buttonVerificarIDComanda;
		private System.Windows.Forms.Label labelIDComandaACobrar;
		private System.Windows.Forms.NumericUpDown numericUpDownIDComanda;
		//datagridview comandas pedidas:
		private System.Windows.Forms.DataGridViewTextBoxColumn ID_COMANDA_PEDIDA;
		private System.Windows.Forms.DataGridViewTextBoxColumn NOMBRE_CLIENTE_PEDIDA;
		private System.Windows.Forms.DataGridViewTextBoxColumn FECHA_CREACION_PEDIDA;
		private System.Windows.Forms.DataGridViewTextBoxColumn NUMERO_MESA_PEDIDA;
		private System.Windows.Forms.DataGridViewTextBoxColumn ESTATUS_PEDIDA;
		private System.Windows.Forms.DataGridViewTextBoxColumn ID_EMPLEADO_PEDIDA;
		private System.Windows.Forms.DataGridViewTextBoxColumn NOMBRE_EMPLEADO_PEDIDA;
		private System.Windows.Forms.DataGridViewImageColumn IMAGEN_PEDIDA;
		private System.Windows.Forms.DataGridViewButtonColumn MOSTRAR_DETALLE_COMANDA;
		//datagridview detalle comanda pedida
		private System.Windows.Forms.DataGridViewTextBoxColumn ID_COMANDA_DETALLE_COMANDA_PEDIDA;
		private System.Windows.Forms.DataGridViewTextBoxColumn ID_PRODUCTO_DETALLE_COMANDA_PEDIDA;
		private System.Windows.Forms.DataGridViewTextBoxColumn NOMBRE_PRODUCTO_DETALLE_COMANDA_PEDIDA;
		private System.Windows.Forms.DataGridViewTextBoxColumn DESCRIPCION_PRODUCTO_DETALLE_COMANDA_PEDIDA;
		private System.Windows.Forms.DataGridViewTextBoxColumn CANTIDAD_PRODUCTO_DETALLE_COMANDA_PEDIDA;
		private System.Windows.Forms.DataGridViewTextBoxColumn PRECIO_PRODUCTO_DETALLE_COMANDA_PEDIDA;
		private System.Windows.Forms.DataGridViewTextBoxColumn IMPORTE_DETALLE_COMANDA_PEDIDA;
		private System.Windows.Forms.DataGridView dataGridViewComandas;
		private System.Windows.Forms.DataGridViewTextBoxColumn ID_COMANDA_ENCONTRADA;
		private System.Windows.Forms.DataGridViewTextBoxColumn ID_EMPLEADO;
		private System.Windows.Forms.DataGridViewTextBoxColumn NOMBRE_MESERO;
		private System.Windows.Forms.DataGridViewTextBoxColumn NOMBRE_CLIENTE;
		private System.Windows.Forms.DataGridViewTextBoxColumn NUMERO_MESA;
		private System.Windows.Forms.DataGridViewTextBoxColumn FECHA_CREACION;
		private System.Windows.Forms.DataGridViewTextBoxColumn ESTATUS;
		private System.Windows.Forms.DataGridView dataGridViewDetalleComanda;
		private System.Windows.Forms.DataGridViewTextBoxColumn ID_COMANDA;
		private System.Windows.Forms.DataGridViewTextBoxColumn ID_PRODUCTO;
		private System.Windows.Forms.DataGridViewTextBoxColumn NOMBRE_PRODUCTO;
		private System.Windows.Forms.DataGridViewTextBoxColumn DESCRIPCION_PRODUCTO_DETALLE_COMANDA;
		private System.Windows.Forms.DataGridViewTextBoxColumn CANTIDAD;
		private System.Windows.Forms.DataGridViewTextBoxColumn PRECIO_UNITARIO;
		private System.Windows.Forms.DataGridViewTextBoxColumn IMPORTE;
		private System.Windows.Forms.DataGridViewImageColumn IMAGEN_MESERO;
		//datagridview comanda a asginarse:
		
		
		
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AsignarmeComanda));
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
			this.buttonAsignarme = new System.Windows.Forms.Button();
			this.panelFondo = new System.Windows.Forms.Panel();
			this.labelTitulo = new System.Windows.Forms.Label();
			this.tabControlAsignarComandas = new System.Windows.Forms.TabControl();
			this.tabPageComandasAPreparar = new System.Windows.Forms.TabPage();
			this.dataGridViewComandasPedidas = new System.Windows.Forms.DataGridView();
			this.ID_COMANDA_PEDIDA = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.NOMBRE_CLIENTE_PEDIDA = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.FECHA_CREACION_PEDIDA = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.NUMERO_MESA_PEDIDA = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.ESTATUS_PEDIDA = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.ID_EMPLEADO_PEDIDA = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.NOMBRE_EMPLEADO_PEDIDA = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.IMAGEN_PEDIDA = new System.Windows.Forms.DataGridViewImageColumn();
			this.MOSTRAR_DETALLE_COMANDA = new System.Windows.Forms.DataGridViewButtonColumn();
			this.dataGridViewDetalleComandaPedidas = new System.Windows.Forms.DataGridView();
			this.ID_COMANDA_DETALLE_COMANDA_PEDIDA = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.ID_PRODUCTO_DETALLE_COMANDA_PEDIDA = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.NOMBRE_PRODUCTO_DETALLE_COMANDA_PEDIDA = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.DESCRIPCION_PRODUCTO_DETALLE_COMANDA_PEDIDA = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.CANTIDAD_PRODUCTO_DETALLE_COMANDA_PEDIDA = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.PRECIO_PRODUCTO_DETALLE_COMANDA_PEDIDA = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.IMPORTE_DETALLE_COMANDA_PEDIDA = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.tabPageAsignarComanda = new System.Windows.Forms.TabPage();
			this.dataGridViewDetalleComanda = new System.Windows.Forms.DataGridView();
			this.ID_COMANDA = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.ID_PRODUCTO = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.NOMBRE_PRODUCTO = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.DESCRIPCION_PRODUCTO_DETALLE_COMANDA = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.CANTIDAD = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.PRECIO_UNITARIO = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.IMPORTE = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.dataGridViewComandas = new System.Windows.Forms.DataGridView();
			this.numericUpDownIDComanda = new System.Windows.Forms.NumericUpDown();
			this.monthCalendarFechaCierreComanda = new System.Windows.Forms.MonthCalendar();
			this.textBoxNombreEmpleado = new System.Windows.Forms.TextBox();
			this.labelNombreEmpleado = new System.Windows.Forms.Label();
			this.textBoxIDEmpleado = new System.Windows.Forms.TextBox();
			this.labelIDEmpleado = new System.Windows.Forms.Label();
			this.buttonCobrar = new System.Windows.Forms.Button();
			this.buttonVerificarIDComanda = new System.Windows.Forms.Button();
			this.labelIDComandaACobrar = new System.Windows.Forms.Label();
			this.ID_COMANDA_ENCONTRADA = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.NOMBRE_CLIENTE = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.NUMERO_MESA = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.FECHA_CREACION = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.ESTATUS = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.ID_EMPLEADO = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.NOMBRE_MESERO = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.IMAGEN_MESERO = new System.Windows.Forms.DataGridViewImageColumn();
			this.panelFondo.SuspendLayout();
			this.tabControlAsignarComandas.SuspendLayout();
			this.tabPageComandasAPreparar.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.dataGridViewComandasPedidas)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.dataGridViewDetalleComandaPedidas)).BeginInit();
			this.tabPageAsignarComanda.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.dataGridViewDetalleComanda)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.dataGridViewComandas)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.numericUpDownIDComanda)).BeginInit();
			this.SuspendLayout();
			// 
			// buttonAsignarme
			// 
			this.buttonAsignarme.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
			this.buttonAsignarme.BackColor = System.Drawing.Color.Transparent;
			this.buttonAsignarme.Cursor = System.Windows.Forms.Cursors.Hand;
			this.buttonAsignarme.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
			this.buttonAsignarme.Font = new System.Drawing.Font("Lucida Bright", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.buttonAsignarme.ForeColor = System.Drawing.Color.White;
			this.buttonAsignarme.Location = new System.Drawing.Point(1176, 99);
			this.buttonAsignarme.Name = "buttonAsignarme";
			this.buttonAsignarme.Size = new System.Drawing.Size(160, 60);
			this.buttonAsignarme.TabIndex = 33;
			this.buttonAsignarme.Text = "ASIGNARME";
			this.buttonAsignarme.UseVisualStyleBackColor = false;
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
			this.panelFondo.TabIndex = 121;
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
			this.labelTitulo.Location = new System.Drawing.Point(257, 12);
			this.labelTitulo.Name = "labelTitulo";
			this.labelTitulo.Size = new System.Drawing.Size(824, 61);
			this.labelTitulo.TabIndex = 1;
			this.labelTitulo.Text = "ASIGNAR COMANDAS A PREPARAR";
			this.labelTitulo.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// tabControlAsignarComandas
			// 
			this.tabControlAsignarComandas.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
			| System.Windows.Forms.AnchorStyles.Right)));
			this.tabControlAsignarComandas.Appearance = System.Windows.Forms.TabAppearance.FlatButtons;
			this.tabControlAsignarComandas.Controls.Add(this.tabPageComandasAPreparar);
			this.tabControlAsignarComandas.Controls.Add(this.tabPageAsignarComanda);
			this.tabControlAsignarComandas.Font = new System.Drawing.Font("Maiandra GD", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.tabControlAsignarComandas.HotTrack = true;
			this.tabControlAsignarComandas.Location = new System.Drawing.Point(0, 100);
			this.tabControlAsignarComandas.Name = "tabControlAsignarComandas";
			this.tabControlAsignarComandas.SelectedIndex = 0;
			this.tabControlAsignarComandas.Size = new System.Drawing.Size(1352, 628);
			this.tabControlAsignarComandas.TabIndex = 122;
			// 
			// tabPageComandasAPreparar
			// 
			this.tabPageComandasAPreparar.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("tabPageComandasAPreparar.BackgroundImage")));
			this.tabPageComandasAPreparar.Controls.Add(this.dataGridViewComandasPedidas);
			this.tabPageComandasAPreparar.Controls.Add(this.dataGridViewDetalleComandaPedidas);
			this.tabPageComandasAPreparar.Font = new System.Drawing.Font("Maiandra GD", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.tabPageComandasAPreparar.Location = new System.Drawing.Point(4, 37);
			this.tabPageComandasAPreparar.Name = "tabPageComandasAPreparar";
			this.tabPageComandasAPreparar.Padding = new System.Windows.Forms.Padding(3);
			this.tabPageComandasAPreparar.Size = new System.Drawing.Size(1344, 587);
			this.tabPageComandasAPreparar.TabIndex = 0;
			this.tabPageComandasAPreparar.Text = "Comandas A Preparar";
			this.tabPageComandasAPreparar.UseVisualStyleBackColor = true;
			// 
			// dataGridViewComandasPedidas
			// 
			this.dataGridViewComandasPedidas.AllowUserToAddRows = false;
			this.dataGridViewComandasPedidas.AllowUserToDeleteRows = false;
			this.dataGridViewComandasPedidas.AllowUserToOrderColumns = true;
			dataGridViewCellStyle1.NullValue = null;
			this.dataGridViewComandasPedidas.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
			this.dataGridViewComandasPedidas.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
			| System.Windows.Forms.AnchorStyles.Right)));
			this.dataGridViewComandasPedidas.BackgroundColor = System.Drawing.Color.White;
			this.dataGridViewComandasPedidas.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
			this.dataGridViewComandasPedidas.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.Sunken;
			this.dataGridViewComandasPedidas.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
			this.dataGridViewComandasPedidas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dataGridViewComandasPedidas.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
			this.ID_COMANDA_PEDIDA,
			this.NOMBRE_CLIENTE_PEDIDA,
			this.FECHA_CREACION_PEDIDA,
			this.NUMERO_MESA_PEDIDA,
			this.ESTATUS_PEDIDA,
			this.ID_EMPLEADO_PEDIDA,
			this.NOMBRE_EMPLEADO_PEDIDA,
			this.IMAGEN_PEDIDA,
			this.MOSTRAR_DETALLE_COMANDA});
			dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
			dataGridViewCellStyle2.BackColor = System.Drawing.Color.White;
			dataGridViewCellStyle2.Font = new System.Drawing.Font("Maiandra GD", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			dataGridViewCellStyle2.ForeColor = System.Drawing.Color.Black;
			dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
			dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.White;
			dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
			this.dataGridViewComandasPedidas.DefaultCellStyle = dataGridViewCellStyle2;
			this.dataGridViewComandasPedidas.Location = new System.Drawing.Point(9, 8);
			this.dataGridViewComandasPedidas.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
			this.dataGridViewComandasPedidas.Name = "dataGridViewComandasPedidas";
			this.dataGridViewComandasPedidas.ReadOnly = true;
			this.dataGridViewComandasPedidas.RowHeadersVisible = false;
			dataGridViewCellStyle3.Font = new System.Drawing.Font("Maiandra GD", 9F);
			this.dataGridViewComandasPedidas.RowsDefaultCellStyle = dataGridViewCellStyle3;
			this.dataGridViewComandasPedidas.RowTemplate.Height = 70;
			this.dataGridViewComandasPedidas.RowTemplate.ReadOnly = true;
			this.dataGridViewComandasPedidas.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.CellSelect;
			this.dataGridViewComandasPedidas.Size = new System.Drawing.Size(1323, 339);
			this.dataGridViewComandasPedidas.TabIndex = 135;
			this.dataGridViewComandasPedidas.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DataGridViewComandasPedidasCellContentClick);
			// 
			// ID_COMANDA_PEDIDA
			// 
			this.ID_COMANDA_PEDIDA.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
			this.ID_COMANDA_PEDIDA.HeaderText = "ID COMANDA";
			this.ID_COMANDA_PEDIDA.Name = "ID_COMANDA_PEDIDA";
			this.ID_COMANDA_PEDIDA.ReadOnly = true;
			// 
			// NOMBRE_CLIENTE_PEDIDA
			// 
			this.NOMBRE_CLIENTE_PEDIDA.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
			this.NOMBRE_CLIENTE_PEDIDA.HeaderText = "NOMBRE CLIENTE";
			this.NOMBRE_CLIENTE_PEDIDA.Name = "NOMBRE_CLIENTE_PEDIDA";
			this.NOMBRE_CLIENTE_PEDIDA.ReadOnly = true;
			// 
			// FECHA_CREACION_PEDIDA
			// 
			this.FECHA_CREACION_PEDIDA.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
			this.FECHA_CREACION_PEDIDA.HeaderText = "FECHA CREACIÓN";
			this.FECHA_CREACION_PEDIDA.Name = "FECHA_CREACION_PEDIDA";
			this.FECHA_CREACION_PEDIDA.ReadOnly = true;
			// 
			// NUMERO_MESA_PEDIDA
			// 
			this.NUMERO_MESA_PEDIDA.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
			this.NUMERO_MESA_PEDIDA.HeaderText = "NÚMERO MESA";
			this.NUMERO_MESA_PEDIDA.Name = "NUMERO_MESA_PEDIDA";
			this.NUMERO_MESA_PEDIDA.ReadOnly = true;
			// 
			// ESTATUS_PEDIDA
			// 
			this.ESTATUS_PEDIDA.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
			this.ESTATUS_PEDIDA.HeaderText = "ESTATUS";
			this.ESTATUS_PEDIDA.Name = "ESTATUS_PEDIDA";
			this.ESTATUS_PEDIDA.ReadOnly = true;
			// 
			// ID_EMPLEADO_PEDIDA
			// 
			this.ID_EMPLEADO_PEDIDA.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
			this.ID_EMPLEADO_PEDIDA.HeaderText = "ID MESERO";
			this.ID_EMPLEADO_PEDIDA.Name = "ID_EMPLEADO_PEDIDA";
			this.ID_EMPLEADO_PEDIDA.ReadOnly = true;
			// 
			// NOMBRE_EMPLEADO_PEDIDA
			// 
			this.NOMBRE_EMPLEADO_PEDIDA.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
			this.NOMBRE_EMPLEADO_PEDIDA.HeaderText = "NOMBRE MESERO";
			this.NOMBRE_EMPLEADO_PEDIDA.Name = "NOMBRE_EMPLEADO_PEDIDA";
			this.NOMBRE_EMPLEADO_PEDIDA.ReadOnly = true;
			// 
			// IMAGEN_PEDIDA
			// 
			this.IMAGEN_PEDIDA.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
			this.IMAGEN_PEDIDA.HeaderText = "MESERO";
			this.IMAGEN_PEDIDA.ImageLayout = System.Windows.Forms.DataGridViewImageCellLayout.Stretch;
			this.IMAGEN_PEDIDA.Name = "IMAGEN_PEDIDA";
			this.IMAGEN_PEDIDA.ReadOnly = true;
			this.IMAGEN_PEDIDA.Resizable = System.Windows.Forms.DataGridViewTriState.True;
			this.IMAGEN_PEDIDA.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
			// 
			// MOSTRAR_DETALLE_COMANDA
			// 
			this.MOSTRAR_DETALLE_COMANDA.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
			this.MOSTRAR_DETALLE_COMANDA.HeaderText = "MOSTRAR DETALLE";
			this.MOSTRAR_DETALLE_COMANDA.Name = "MOSTRAR_DETALLE_COMANDA";
			this.MOSTRAR_DETALLE_COMANDA.ReadOnly = true;
			// 
			// dataGridViewDetalleComandaPedidas
			// 
			this.dataGridViewDetalleComandaPedidas.AllowUserToAddRows = false;
			this.dataGridViewDetalleComandaPedidas.AllowUserToDeleteRows = false;
			this.dataGridViewDetalleComandaPedidas.AllowUserToOrderColumns = true;
			this.dataGridViewDetalleComandaPedidas.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
			| System.Windows.Forms.AnchorStyles.Right)));
			this.dataGridViewDetalleComandaPedidas.BackgroundColor = System.Drawing.Color.White;
			this.dataGridViewDetalleComandaPedidas.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
			dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
			dataGridViewCellStyle4.BackColor = System.Drawing.Color.White;
			dataGridViewCellStyle4.Font = new System.Drawing.Font("Maiandra GD", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.WindowText;
			dataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight;
			dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
			dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
			this.dataGridViewDetalleComandaPedidas.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle4;
			this.dataGridViewDetalleComandaPedidas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dataGridViewDetalleComandaPedidas.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
			this.ID_COMANDA_DETALLE_COMANDA_PEDIDA,
			this.ID_PRODUCTO_DETALLE_COMANDA_PEDIDA,
			this.NOMBRE_PRODUCTO_DETALLE_COMANDA_PEDIDA,
			this.DESCRIPCION_PRODUCTO_DETALLE_COMANDA_PEDIDA,
			this.CANTIDAD_PRODUCTO_DETALLE_COMANDA_PEDIDA,
			this.PRECIO_PRODUCTO_DETALLE_COMANDA_PEDIDA,
			this.IMPORTE_DETALLE_COMANDA_PEDIDA});
			this.dataGridViewDetalleComandaPedidas.Location = new System.Drawing.Point(9, 355);
			this.dataGridViewDetalleComandaPedidas.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
			this.dataGridViewDetalleComandaPedidas.Name = "dataGridViewDetalleComandaPedidas";
			this.dataGridViewDetalleComandaPedidas.RowHeadersVisible = false;
			dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
			dataGridViewCellStyle5.Font = new System.Drawing.Font("Maiandra GD", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.dataGridViewDetalleComandaPedidas.RowsDefaultCellStyle = dataGridViewCellStyle5;
			this.dataGridViewDetalleComandaPedidas.RowTemplate.Height = 30;
			this.dataGridViewDetalleComandaPedidas.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.CellSelect;
			this.dataGridViewDetalleComandaPedidas.Size = new System.Drawing.Size(1326, 222);
			this.dataGridViewDetalleComandaPedidas.TabIndex = 134;
			// 
			// ID_COMANDA_DETALLE_COMANDA_PEDIDA
			// 
			this.ID_COMANDA_DETALLE_COMANDA_PEDIDA.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader;
			this.ID_COMANDA_DETALLE_COMANDA_PEDIDA.HeaderText = "ID COMANDA";
			this.ID_COMANDA_DETALLE_COMANDA_PEDIDA.Name = "ID_COMANDA_DETALLE_COMANDA_PEDIDA";
			this.ID_COMANDA_DETALLE_COMANDA_PEDIDA.Width = 104;
			// 
			// ID_PRODUCTO_DETALLE_COMANDA_PEDIDA
			// 
			this.ID_PRODUCTO_DETALLE_COMANDA_PEDIDA.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader;
			this.ID_PRODUCTO_DETALLE_COMANDA_PEDIDA.HeaderText = "ID PRODUCTO";
			this.ID_PRODUCTO_DETALLE_COMANDA_PEDIDA.Name = "ID_PRODUCTO_DETALLE_COMANDA_PEDIDA";
			this.ID_PRODUCTO_DETALLE_COMANDA_PEDIDA.Width = 108;
			// 
			// NOMBRE_PRODUCTO_DETALLE_COMANDA_PEDIDA
			// 
			this.NOMBRE_PRODUCTO_DETALLE_COMANDA_PEDIDA.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
			this.NOMBRE_PRODUCTO_DETALLE_COMANDA_PEDIDA.HeaderText = "NOMBRE PRODUCTO";
			this.NOMBRE_PRODUCTO_DETALLE_COMANDA_PEDIDA.Name = "NOMBRE_PRODUCTO_DETALLE_COMANDA_PEDIDA";
			// 
			// DESCRIPCION_PRODUCTO_DETALLE_COMANDA_PEDIDA
			// 
			this.DESCRIPCION_PRODUCTO_DETALLE_COMANDA_PEDIDA.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
			this.DESCRIPCION_PRODUCTO_DETALLE_COMANDA_PEDIDA.HeaderText = "DESCRIPCIÓN";
			this.DESCRIPCION_PRODUCTO_DETALLE_COMANDA_PEDIDA.Name = "DESCRIPCION_PRODUCTO_DETALLE_COMANDA_PEDIDA";
			// 
			// CANTIDAD_PRODUCTO_DETALLE_COMANDA_PEDIDA
			// 
			this.CANTIDAD_PRODUCTO_DETALLE_COMANDA_PEDIDA.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader;
			this.CANTIDAD_PRODUCTO_DETALLE_COMANDA_PEDIDA.HeaderText = "CANTIDAD";
			this.CANTIDAD_PRODUCTO_DETALLE_COMANDA_PEDIDA.Name = "CANTIDAD_PRODUCTO_DETALLE_COMANDA_PEDIDA";
			this.CANTIDAD_PRODUCTO_DETALLE_COMANDA_PEDIDA.Width = 96;
			// 
			// PRECIO_PRODUCTO_DETALLE_COMANDA_PEDIDA
			// 
			this.PRECIO_PRODUCTO_DETALLE_COMANDA_PEDIDA.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
			this.PRECIO_PRODUCTO_DETALLE_COMANDA_PEDIDA.HeaderText = "PRECIO UNITARIO";
			this.PRECIO_PRODUCTO_DETALLE_COMANDA_PEDIDA.Name = "PRECIO_PRODUCTO_DETALLE_COMANDA_PEDIDA";
			// 
			// IMPORTE_DETALLE_COMANDA_PEDIDA
			// 
			this.IMPORTE_DETALLE_COMANDA_PEDIDA.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
			this.IMPORTE_DETALLE_COMANDA_PEDIDA.HeaderText = "IMPORTE";
			this.IMPORTE_DETALLE_COMANDA_PEDIDA.Name = "IMPORTE_DETALLE_COMANDA_PEDIDA";
			// 
			// tabPageAsignarComanda
			// 
			this.tabPageAsignarComanda.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("tabPageAsignarComanda.BackgroundImage")));
			this.tabPageAsignarComanda.Controls.Add(this.dataGridViewDetalleComanda);
			this.tabPageAsignarComanda.Controls.Add(this.dataGridViewComandas);
			this.tabPageAsignarComanda.Controls.Add(this.numericUpDownIDComanda);
			this.tabPageAsignarComanda.Controls.Add(this.monthCalendarFechaCierreComanda);
			this.tabPageAsignarComanda.Controls.Add(this.textBoxNombreEmpleado);
			this.tabPageAsignarComanda.Controls.Add(this.labelNombreEmpleado);
			this.tabPageAsignarComanda.Controls.Add(this.textBoxIDEmpleado);
			this.tabPageAsignarComanda.Controls.Add(this.labelIDEmpleado);
			this.tabPageAsignarComanda.Controls.Add(this.buttonCobrar);
			this.tabPageAsignarComanda.Controls.Add(this.buttonVerificarIDComanda);
			this.tabPageAsignarComanda.Controls.Add(this.labelIDComandaACobrar);
			this.tabPageAsignarComanda.Font = new System.Drawing.Font("Maiandra GD", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.tabPageAsignarComanda.Location = new System.Drawing.Point(4, 37);
			this.tabPageAsignarComanda.Name = "tabPageAsignarComanda";
			this.tabPageAsignarComanda.Padding = new System.Windows.Forms.Padding(3);
			this.tabPageAsignarComanda.Size = new System.Drawing.Size(1344, 587);
			this.tabPageAsignarComanda.TabIndex = 1;
			this.tabPageAsignarComanda.Text = "Asignar Comanda";
			this.tabPageAsignarComanda.UseVisualStyleBackColor = true;
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
			this.dataGridViewDetalleComanda.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
			this.dataGridViewDetalleComanda.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
			dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
			dataGridViewCellStyle6.BackColor = System.Drawing.Color.WhiteSmoke;
			dataGridViewCellStyle6.Font = new System.Drawing.Font("Maiandra GD", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			dataGridViewCellStyle6.ForeColor = System.Drawing.SystemColors.WindowText;
			dataGridViewCellStyle6.SelectionBackColor = System.Drawing.SystemColors.Highlight;
			dataGridViewCellStyle6.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
			dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
			this.dataGridViewDetalleComanda.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle6;
			this.dataGridViewDetalleComanda.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dataGridViewDetalleComanda.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
			this.ID_COMANDA,
			this.ID_PRODUCTO,
			this.NOMBRE_PRODUCTO,
			this.DESCRIPCION_PRODUCTO_DETALLE_COMANDA,
			this.CANTIDAD,
			this.PRECIO_UNITARIO,
			this.IMPORTE});
			this.dataGridViewDetalleComanda.Location = new System.Drawing.Point(8, 267);
			this.dataGridViewDetalleComanda.Name = "dataGridViewDetalleComanda";
			this.dataGridViewDetalleComanda.ReadOnly = true;
			this.dataGridViewDetalleComanda.RowHeadersVisible = false;
			dataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
			dataGridViewCellStyle7.Font = new System.Drawing.Font("Maiandra GD", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.dataGridViewDetalleComanda.RowsDefaultCellStyle = dataGridViewCellStyle7;
			this.dataGridViewDetalleComanda.RowTemplate.Height = 40;
			this.dataGridViewDetalleComanda.RowTemplate.ReadOnly = true;
			this.dataGridViewDetalleComanda.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.CellSelect;
			this.dataGridViewDetalleComanda.Size = new System.Drawing.Size(1103, 311);
			this.dataGridViewDetalleComanda.TabIndex = 111;
			// 
			// ID_COMANDA
			// 
			this.ID_COMANDA.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader;
			this.ID_COMANDA.HeaderText = "ID COMANDA";
			this.ID_COMANDA.Name = "ID_COMANDA";
			this.ID_COMANDA.ReadOnly = true;
			this.ID_COMANDA.Width = 104;
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
			// DESCRIPCION_PRODUCTO_DETALLE_COMANDA
			// 
			this.DESCRIPCION_PRODUCTO_DETALLE_COMANDA.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
			this.DESCRIPCION_PRODUCTO_DETALLE_COMANDA.HeaderText = "DESCRIPCIÓN";
			this.DESCRIPCION_PRODUCTO_DETALLE_COMANDA.Name = "DESCRIPCION_PRODUCTO_DETALLE_COMANDA";
			this.DESCRIPCION_PRODUCTO_DETALLE_COMANDA.ReadOnly = true;
			// 
			// CANTIDAD
			// 
			this.CANTIDAD.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
			this.CANTIDAD.HeaderText = "CANTIDAD";
			this.CANTIDAD.Name = "CANTIDAD";
			this.CANTIDAD.ReadOnly = true;
			// 
			// PRECIO_UNITARIO
			// 
			this.PRECIO_UNITARIO.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
			this.PRECIO_UNITARIO.HeaderText = "PRECIO UNITARIO";
			this.PRECIO_UNITARIO.Name = "PRECIO_UNITARIO";
			this.PRECIO_UNITARIO.ReadOnly = true;
			// 
			// IMPORTE
			// 
			this.IMPORTE.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
			this.IMPORTE.HeaderText = "IMPORTE";
			this.IMPORTE.Name = "IMPORTE";
			this.IMPORTE.ReadOnly = true;
			// 
			// dataGridViewComandas
			// 
			this.dataGridViewComandas.AllowDrop = true;
			this.dataGridViewComandas.AllowUserToAddRows = false;
			this.dataGridViewComandas.AllowUserToDeleteRows = false;
			dataGridViewCellStyle8.NullValue = null;
			this.dataGridViewComandas.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle8;
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
			this.ID_EMPLEADO,
			this.NOMBRE_MESERO,
			this.IMAGEN_MESERO});
			dataGridViewCellStyle9.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
			dataGridViewCellStyle9.BackColor = System.Drawing.Color.White;
			dataGridViewCellStyle9.Font = new System.Drawing.Font("Maiandra GD", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			dataGridViewCellStyle9.ForeColor = System.Drawing.Color.Black;
			dataGridViewCellStyle9.SelectionBackColor = System.Drawing.SystemColors.Highlight;
			dataGridViewCellStyle9.SelectionForeColor = System.Drawing.Color.White;
			dataGridViewCellStyle9.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
			this.dataGridViewComandas.DefaultCellStyle = dataGridViewCellStyle9;
			this.dataGridViewComandas.Location = new System.Drawing.Point(6, 105);
			this.dataGridViewComandas.Name = "dataGridViewComandas";
			this.dataGridViewComandas.ReadOnly = true;
			this.dataGridViewComandas.RowHeadersVisible = false;
			dataGridViewCellStyle10.Font = new System.Drawing.Font("Maiandra GD", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.dataGridViewComandas.RowsDefaultCellStyle = dataGridViewCellStyle10;
			this.dataGridViewComandas.RowTemplate.Height = 111;
			this.dataGridViewComandas.RowTemplate.ReadOnly = true;
			this.dataGridViewComandas.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.CellSelect;
			this.dataGridViewComandas.Size = new System.Drawing.Size(1326, 150);
			this.dataGridViewComandas.TabIndex = 110;
			// 
			// numericUpDownIDComanda
			// 
			this.numericUpDownIDComanda.Font = new System.Drawing.Font("Lucida Bright", 13F);
			this.numericUpDownIDComanda.Location = new System.Drawing.Point(309, 10);
			this.numericUpDownIDComanda.Maximum = new decimal(new int[] {
			100000000,
			0,
			0,
			0});
			this.numericUpDownIDComanda.Minimum = new decimal(new int[] {
			1,
			0,
			0,
			0});
			this.numericUpDownIDComanda.Name = "numericUpDownIDComanda";
			this.numericUpDownIDComanda.Size = new System.Drawing.Size(515, 28);
			this.numericUpDownIDComanda.TabIndex = 109;
			this.numericUpDownIDComanda.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
			this.numericUpDownIDComanda.Value = new decimal(new int[] {
			1,
			0,
			0,
			0});
			// 
			// monthCalendarFechaCierreComanda
			// 
			this.monthCalendarFechaCierreComanda.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
			| System.Windows.Forms.AnchorStyles.Right)));
			this.monthCalendarFechaCierreComanda.Location = new System.Drawing.Point(1140, 267);
			this.monthCalendarFechaCierreComanda.Name = "monthCalendarFechaCierreComanda";
			this.monthCalendarFechaCierreComanda.TabIndex = 103;
			// 
			// textBoxNombreEmpleado
			// 
			this.textBoxNombreEmpleado.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
			this.textBoxNombreEmpleado.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
			this.textBoxNombreEmpleado.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.HistoryList;
			this.textBoxNombreEmpleado.Font = new System.Drawing.Font("Maiandra GD", 13F);
			this.textBoxNombreEmpleado.Location = new System.Drawing.Point(856, 54);
			this.textBoxNombreEmpleado.Name = "textBoxNombreEmpleado";
			this.textBoxNombreEmpleado.ReadOnly = true;
			this.textBoxNombreEmpleado.ScrollBars = System.Windows.Forms.ScrollBars.Horizontal;
			this.textBoxNombreEmpleado.Size = new System.Drawing.Size(476, 28);
			this.textBoxNombreEmpleado.TabIndex = 94;
			// 
			// labelNombreEmpleado
			// 
			this.labelNombreEmpleado.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
			this.labelNombreEmpleado.BackColor = System.Drawing.Color.Transparent;
			this.labelNombreEmpleado.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
			this.labelNombreEmpleado.Font = new System.Drawing.Font("Maiandra GD", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.labelNombreEmpleado.ForeColor = System.Drawing.Color.White;
			this.labelNombreEmpleado.Location = new System.Drawing.Point(580, 54);
			this.labelNombreEmpleado.Name = "labelNombreEmpleado";
			this.labelNombreEmpleado.Size = new System.Drawing.Size(270, 28);
			this.labelNombreEmpleado.TabIndex = 93;
			this.labelNombreEmpleado.Text = "NOMBRE DEL EMPLEADO:";
			this.labelNombreEmpleado.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// textBoxIDEmpleado
			// 
			this.textBoxIDEmpleado.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
			this.textBoxIDEmpleado.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
			this.textBoxIDEmpleado.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.HistoryList;
			this.textBoxIDEmpleado.Font = new System.Drawing.Font("Maiandra GD", 13F);
			this.textBoxIDEmpleado.Location = new System.Drawing.Point(309, 54);
			this.textBoxIDEmpleado.Name = "textBoxIDEmpleado";
			this.textBoxIDEmpleado.ReadOnly = true;
			this.textBoxIDEmpleado.ScrollBars = System.Windows.Forms.ScrollBars.Horizontal;
			this.textBoxIDEmpleado.Size = new System.Drawing.Size(265, 28);
			this.textBoxIDEmpleado.TabIndex = 88;
			// 
			// labelIDEmpleado
			// 
			this.labelIDEmpleado.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
			this.labelIDEmpleado.BackColor = System.Drawing.Color.Transparent;
			this.labelIDEmpleado.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
			this.labelIDEmpleado.Font = new System.Drawing.Font("Maiandra GD", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.labelIDEmpleado.ForeColor = System.Drawing.Color.White;
			this.labelIDEmpleado.Location = new System.Drawing.Point(6, 54);
			this.labelIDEmpleado.Name = "labelIDEmpleado";
			this.labelIDEmpleado.Size = new System.Drawing.Size(297, 28);
			this.labelIDEmpleado.TabIndex = 87;
			this.labelIDEmpleado.Text = "ID DEL EMPLEADO A ASIGNARSE:";
			this.labelIDEmpleado.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// buttonCobrar
			// 
			this.buttonCobrar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
			this.buttonCobrar.BackColor = System.Drawing.Color.Transparent;
			this.buttonCobrar.Cursor = System.Windows.Forms.Cursors.Hand;
			this.buttonCobrar.Enabled = false;
			this.buttonCobrar.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
			this.buttonCobrar.Font = new System.Drawing.Font("Maiandra GD", 18F);
			this.buttonCobrar.ForeColor = System.Drawing.Color.White;
			this.buttonCobrar.Location = new System.Drawing.Point(1140, 495);
			this.buttonCobrar.Name = "buttonCobrar";
			this.buttonCobrar.Size = new System.Drawing.Size(192, 83);
			this.buttonCobrar.TabIndex = 45;
			this.buttonCobrar.Text = "ASIGNARME";
			this.buttonCobrar.UseVisualStyleBackColor = false;
			this.buttonCobrar.Click += new System.EventHandler(this.ButtonCobrarClick);
			// 
			// buttonVerificarIDComanda
			// 
			this.buttonVerificarIDComanda.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
			this.buttonVerificarIDComanda.BackColor = System.Drawing.Color.Transparent;
			this.buttonVerificarIDComanda.Cursor = System.Windows.Forms.Cursors.Hand;
			this.buttonVerificarIDComanda.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
			this.buttonVerificarIDComanda.Font = new System.Drawing.Font("Maiandra GD", 13F);
			this.buttonVerificarIDComanda.ForeColor = System.Drawing.Color.White;
			this.buttonVerificarIDComanda.Location = new System.Drawing.Point(854, 10);
			this.buttonVerificarIDComanda.Name = "buttonVerificarIDComanda";
			this.buttonVerificarIDComanda.Size = new System.Drawing.Size(478, 28);
			this.buttonVerificarIDComanda.TabIndex = 44;
			this.buttonVerificarIDComanda.Text = "VERIFICAR ID COMANDA";
			this.buttonVerificarIDComanda.UseVisualStyleBackColor = false;
			this.buttonVerificarIDComanda.Click += new System.EventHandler(this.ButtonVerificarIDComandaClick);
			// 
			// labelIDComandaACobrar
			// 
			this.labelIDComandaACobrar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
			this.labelIDComandaACobrar.BackColor = System.Drawing.Color.Transparent;
			this.labelIDComandaACobrar.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
			this.labelIDComandaACobrar.Font = new System.Drawing.Font("Maiandra GD", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.labelIDComandaACobrar.ForeColor = System.Drawing.Color.White;
			this.labelIDComandaACobrar.Location = new System.Drawing.Point(6, 10);
			this.labelIDComandaACobrar.Name = "labelIDComandaACobrar";
			this.labelIDComandaACobrar.Size = new System.Drawing.Size(297, 28);
			this.labelIDComandaACobrar.TabIndex = 42;
			this.labelIDComandaACobrar.Text = "ID DE COMANDA A ASIGNAR:";
			this.labelIDComandaACobrar.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
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
			// ID_EMPLEADO
			// 
			this.ID_EMPLEADO.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader;
			this.ID_EMPLEADO.HeaderText = "ID MESERO";
			this.ID_EMPLEADO.Name = "ID_EMPLEADO";
			this.ID_EMPLEADO.ReadOnly = true;
			this.ID_EMPLEADO.Width = 90;
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
			this.IMAGEN_MESERO.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
			this.IMAGEN_MESERO.HeaderText = "MESERO";
			this.IMAGEN_MESERO.ImageLayout = System.Windows.Forms.DataGridViewImageCellLayout.Stretch;
			this.IMAGEN_MESERO.Name = "IMAGEN_MESERO";
			this.IMAGEN_MESERO.ReadOnly = true;
			// 
			// AsignarmeComanda
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
			this.ClientSize = new System.Drawing.Size(1348, 727);
			this.Controls.Add(this.tabControlAsignarComandas);
			this.Controls.Add(this.panelFondo);
			this.Controls.Add(this.buttonAsignarme);
			this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
			this.MinimumSize = new System.Drawing.Size(1364, 736);
			this.Name = "AsignarmeComanda";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "SISTEMA MEMÍN® ";
			this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
			this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.AsignarmeComandaFormClosing);
			this.Load += new System.EventHandler(this.AsignarmeComandaLoad);
			this.panelFondo.ResumeLayout(false);
			this.tabControlAsignarComandas.ResumeLayout(false);
			this.tabPageComandasAPreparar.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.dataGridViewComandasPedidas)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.dataGridViewDetalleComandaPedidas)).EndInit();
			this.tabPageAsignarComanda.ResumeLayout(false);
			this.tabPageAsignarComanda.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.dataGridViewDetalleComanda)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.dataGridViewComandas)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.numericUpDownIDComanda)).EndInit();
			this.ResumeLayout(false);

		}
	}
}
