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
	partial class BuscarTodo
	{
		/// <summary>
		/// Designer variable used to keep track of non-visual components.
		/// </summary>
		private System.ComponentModel.IContainer components = null;
		private System.Windows.Forms.Button buttonGenerarReporte;
		private System.Windows.Forms.Panel panelFondo;
		private System.Windows.Forms.Label labelTitulo;
		private System.Windows.Forms.TabControl tabControlBuscar;
		private System.Windows.Forms.TabPage tabPageBuscarComanda;
		private System.Windows.Forms.DataGridView dataGridViewComandas;
		private System.Windows.Forms.DataGridViewTextBoxColumn ID_COMANDA_ENCONTRADA;
		private System.Windows.Forms.DataGridViewTextBoxColumn ID_EMPLEADO;
		private System.Windows.Forms.DataGridViewTextBoxColumn NOMBRE_MESERO;
		private System.Windows.Forms.DataGridViewTextBoxColumn NOMBRE_CLIENTE;
		private System.Windows.Forms.DataGridViewTextBoxColumn FECHA_CREACION;
		private System.Windows.Forms.DataGridViewTextBoxColumn ESTATUS;
		private System.Windows.Forms.DataGridViewTextBoxColumn ID_EMPLEADO_COCINA;
		private System.Windows.Forms.DataGridViewTextBoxColumn NOMBRE_COCINERO;
		private System.Windows.Forms.DataGridViewTextBoxColumn ID_CAJERO;
		private System.Windows.Forms.DataGridViewTextBoxColumn NOMBRE_CAJERO;
		private System.Windows.Forms.DataGridViewTextBoxColumn FECHA_CIERRE;
		private System.Windows.Forms.Label labelIDComanda;
		private System.Windows.Forms.Button buttonBuscarComanda;
		private System.Windows.Forms.DataGridView dataGridViewDetalleComanda;
		private System.Windows.Forms.DataGridViewTextBoxColumn ID_COMANDA;
		private System.Windows.Forms.DataGridViewTextBoxColumn ID_PRODUCTO;
		private System.Windows.Forms.DataGridViewTextBoxColumn NOMBRE_PRODUCTO;
		private System.Windows.Forms.DataGridViewTextBoxColumn CANTIDAD;
		private System.Windows.Forms.DataGridViewTextBoxColumn PRECIO_UNITARIO;
		private System.Windows.Forms.DataGridViewTextBoxColumn IMPORTE;
		private System.Windows.Forms.TabPage tabPageBuscarEmpleados;
		private System.Windows.Forms.TabPage tabPageBuscarProductos;
		private System.Windows.Forms.DataGridViewTextBoxColumn NUMERO_MESA;
		private System.Windows.Forms.Label labelIDProducto;
		private System.Windows.Forms.Button buttonBuscarProducto;
		private System.Windows.Forms.DataGridView dataGridViewProductos;
		private System.Windows.Forms.DataGridViewTextBoxColumn ID_DE_PRODUCTO;
		private System.Windows.Forms.DataGridViewTextBoxColumn NOMBRE_DE_PRODUCTO;
		private System.Windows.Forms.DataGridViewTextBoxColumn TIPO_PRODUCTO;
		private System.Windows.Forms.DataGridViewTextBoxColumn DESCRIPCION;
		private System.Windows.Forms.DataGridViewTextBoxColumn COSTO;
		private System.Windows.Forms.DataGridViewTextBoxColumn DISPONIBILIDAD;
		private System.Windows.Forms.Label labelIDEmpleado;
		private System.Windows.Forms.Button buttonBuscarEmpleado;
		private System.Windows.Forms.DataGridView dataGridViewEmpleados;
		private System.Windows.Forms.DataGridViewTextBoxColumn ID_DEL_EMPLEADO;
		private System.Windows.Forms.DataGridViewTextBoxColumn NOMBRE_DEL_EMPLEADO;
		private System.Windows.Forms.DataGridViewTextBoxColumn APELLIDO_PATERNO;
		private System.Windows.Forms.DataGridViewTextBoxColumn APELLIDO_MATERNO;
		private System.Windows.Forms.DataGridViewTextBoxColumn PUESTO_DEL_EMPLEADO;
		private System.Windows.Forms.DataGridView dataGridViewTelefonosEmpleado;
		private System.Windows.Forms.DataGridViewTextBoxColumn TELEFONOS_EMPLEADO;
		private System.Windows.Forms.DataGridView dataGridViewCorreosEmpleado;
		private System.Windows.Forms.DataGridViewTextBoxColumn CORREOS_EMPLEADO;
		private System.Windows.Forms.DataGridViewTextBoxColumn TOTAL;
		private System.Windows.Forms.PictureBox pictureBoxImagenProducto;
		private System.Windows.Forms.Label labelImagenEmpleado;
		private System.Windows.Forms.PictureBox pictureBoxImagenEmpleado;
		private System.Windows.Forms.Label labelImagenProducto;
		private System.Windows.Forms.NumericUpDown numericUpDownIDProducto;
		private System.Windows.Forms.DataGridViewTextBoxColumn OBSERVACIONES_PRODUCTO;
		private System.Windows.Forms.NumericUpDown numericUpDownIDEmpleado;
		private System.Windows.Forms.NumericUpDown numericUpDownIDComanda;
		private System.Windows.Forms.DataGridViewTextBoxColumn SUBTOTAL;
		private System.Windows.Forms.DataGridViewTextBoxColumn DESCRIPCION_PRODUCTO_DETALLE_COMANDA;
		private System.Windows.Forms.DataGridViewTextBoxColumn FORMA_PAGO;
		private System.Windows.Forms.DataGridViewTextBoxColumn SERVICIO;
		private System.Windows.Forms.Label labelCajero;
		private System.Windows.Forms.Label labelCocinero;
		private System.Windows.Forms.Label labelMesero;
		private System.Windows.Forms.PictureBox pictureBoxCajeroComanda;
		private System.Windows.Forms.PictureBox pictureBoxCocineroComanda;
		private System.Windows.Forms.PictureBox pictureBoxMeseroComanda;
		private System.Windows.Forms.DataGridViewImageColumn IMAGEN_PRODUCTO_DETALLE_COMANDA;
		
		
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

		
	    void InitializeComponent()
		{
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(BuscarTodo));
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
			System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle11 = new System.Windows.Forms.DataGridViewCellStyle();
			System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle12 = new System.Windows.Forms.DataGridViewCellStyle();
			System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle13 = new System.Windows.Forms.DataGridViewCellStyle();
			this.buttonGenerarReporte = new System.Windows.Forms.Button();
			this.panelFondo = new System.Windows.Forms.Panel();
			this.labelTitulo = new System.Windows.Forms.Label();
			this.tabControlBuscar = new System.Windows.Forms.TabControl();
			this.tabPageBuscarComanda = new System.Windows.Forms.TabPage();
			this.labelCajero = new System.Windows.Forms.Label();
			this.labelCocinero = new System.Windows.Forms.Label();
			this.labelMesero = new System.Windows.Forms.Label();
			this.pictureBoxCajeroComanda = new System.Windows.Forms.PictureBox();
			this.pictureBoxCocineroComanda = new System.Windows.Forms.PictureBox();
			this.pictureBoxMeseroComanda = new System.Windows.Forms.PictureBox();
			this.numericUpDownIDComanda = new System.Windows.Forms.NumericUpDown();
			this.dataGridViewComandas = new System.Windows.Forms.DataGridView();
			this.labelIDComanda = new System.Windows.Forms.Label();
			this.buttonBuscarComanda = new System.Windows.Forms.Button();
			this.dataGridViewDetalleComanda = new System.Windows.Forms.DataGridView();
			this.ID_COMANDA = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.ID_PRODUCTO = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.NOMBRE_PRODUCTO = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.DESCRIPCION_PRODUCTO_DETALLE_COMANDA = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.IMAGEN_PRODUCTO_DETALLE_COMANDA = new System.Windows.Forms.DataGridViewImageColumn();
			this.CANTIDAD = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.PRECIO_UNITARIO = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.IMPORTE = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.tabPageBuscarEmpleados = new System.Windows.Forms.TabPage();
			this.numericUpDownIDEmpleado = new System.Windows.Forms.NumericUpDown();
			this.labelImagenEmpleado = new System.Windows.Forms.Label();
			this.pictureBoxImagenEmpleado = new System.Windows.Forms.PictureBox();
			this.dataGridViewTelefonosEmpleado = new System.Windows.Forms.DataGridView();
			this.TELEFONOS_EMPLEADO = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.dataGridViewCorreosEmpleado = new System.Windows.Forms.DataGridView();
			this.CORREOS_EMPLEADO = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.dataGridViewEmpleados = new System.Windows.Forms.DataGridView();
			this.ID_DEL_EMPLEADO = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.NOMBRE_DEL_EMPLEADO = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.APELLIDO_PATERNO = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.APELLIDO_MATERNO = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.PUESTO_DEL_EMPLEADO = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.labelIDEmpleado = new System.Windows.Forms.Label();
			this.buttonBuscarEmpleado = new System.Windows.Forms.Button();
			this.tabPageBuscarProductos = new System.Windows.Forms.TabPage();
			this.numericUpDownIDProducto = new System.Windows.Forms.NumericUpDown();
			this.labelImagenProducto = new System.Windows.Forms.Label();
			this.pictureBoxImagenProducto = new System.Windows.Forms.PictureBox();
			this.labelIDProducto = new System.Windows.Forms.Label();
			this.buttonBuscarProducto = new System.Windows.Forms.Button();
			this.dataGridViewProductos = new System.Windows.Forms.DataGridView();
			this.ID_DE_PRODUCTO = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.NOMBRE_DE_PRODUCTO = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.TIPO_PRODUCTO = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.DESCRIPCION = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.DISPONIBILIDAD = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.OBSERVACIONES_PRODUCTO = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.COSTO = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.ID_COMANDA_ENCONTRADA = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.NOMBRE_CLIENTE = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.NUMERO_MESA = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.FECHA_CREACION = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.ESTATUS = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.ID_EMPLEADO = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.NOMBRE_MESERO = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.ID_EMPLEADO_COCINA = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.NOMBRE_COCINERO = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.ID_CAJERO = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.NOMBRE_CAJERO = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.FECHA_CIERRE = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.FORMA_PAGO = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.SERVICIO = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.SUBTOTAL = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.TOTAL = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.panelFondo.SuspendLayout();
			this.tabControlBuscar.SuspendLayout();
			this.tabPageBuscarComanda.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.pictureBoxCajeroComanda)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.pictureBoxCocineroComanda)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.pictureBoxMeseroComanda)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.numericUpDownIDComanda)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.dataGridViewComandas)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.dataGridViewDetalleComanda)).BeginInit();
			this.tabPageBuscarEmpleados.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.numericUpDownIDEmpleado)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.pictureBoxImagenEmpleado)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.dataGridViewTelefonosEmpleado)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.dataGridViewCorreosEmpleado)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.dataGridViewEmpleados)).BeginInit();
			this.tabPageBuscarProductos.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.numericUpDownIDProducto)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.pictureBoxImagenProducto)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.dataGridViewProductos)).BeginInit();
			this.SuspendLayout();
			// 
			// buttonGenerarReporte
			// 
			this.buttonGenerarReporte.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
			this.buttonGenerarReporte.BackColor = System.Drawing.Color.Transparent;
			this.buttonGenerarReporte.Cursor = System.Windows.Forms.Cursors.Hand;
			this.buttonGenerarReporte.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
			this.buttonGenerarReporte.Font = new System.Drawing.Font("Lucida Bright", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.buttonGenerarReporte.ForeColor = System.Drawing.Color.White;
			this.buttonGenerarReporte.Location = new System.Drawing.Point(1110, 79);
			this.buttonGenerarReporte.Name = "buttonGenerarReporte";
			this.buttonGenerarReporte.Size = new System.Drawing.Size(226, 71);
			this.buttonGenerarReporte.TabIndex = 34;
			this.buttonGenerarReporte.Text = "GENERAR REPORTE";
			this.buttonGenerarReporte.UseVisualStyleBackColor = false;
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
			this.panelFondo.TabIndex = 106;
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
			this.labelTitulo.Text = "BUSCAR";
			this.labelTitulo.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// tabControlBuscar
			// 
			this.tabControlBuscar.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
			| System.Windows.Forms.AnchorStyles.Right)));
			this.tabControlBuscar.Appearance = System.Windows.Forms.TabAppearance.FlatButtons;
			this.tabControlBuscar.Controls.Add(this.tabPageBuscarComanda);
			this.tabControlBuscar.Controls.Add(this.tabPageBuscarEmpleados);
			this.tabControlBuscar.Controls.Add(this.tabPageBuscarProductos);
			this.tabControlBuscar.Font = new System.Drawing.Font("Maiandra GD", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.tabControlBuscar.HotTrack = true;
			this.tabControlBuscar.Location = new System.Drawing.Point(0, 100);
			this.tabControlBuscar.Name = "tabControlBuscar";
			this.tabControlBuscar.SelectedIndex = 0;
			this.tabControlBuscar.ShowToolTips = true;
			this.tabControlBuscar.Size = new System.Drawing.Size(1352, 625);
			this.tabControlBuscar.SizeMode = System.Windows.Forms.TabSizeMode.FillToRight;
			this.tabControlBuscar.TabIndex = 107;
			// 
			// tabPageBuscarComanda
			// 
			this.tabPageBuscarComanda.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("tabPageBuscarComanda.BackgroundImage")));
			this.tabPageBuscarComanda.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
			this.tabPageBuscarComanda.Controls.Add(this.labelCajero);
			this.tabPageBuscarComanda.Controls.Add(this.labelCocinero);
			this.tabPageBuscarComanda.Controls.Add(this.labelMesero);
			this.tabPageBuscarComanda.Controls.Add(this.pictureBoxCajeroComanda);
			this.tabPageBuscarComanda.Controls.Add(this.pictureBoxCocineroComanda);
			this.tabPageBuscarComanda.Controls.Add(this.pictureBoxMeseroComanda);
			this.tabPageBuscarComanda.Controls.Add(this.numericUpDownIDComanda);
			this.tabPageBuscarComanda.Controls.Add(this.dataGridViewComandas);
			this.tabPageBuscarComanda.Controls.Add(this.labelIDComanda);
			this.tabPageBuscarComanda.Controls.Add(this.buttonBuscarComanda);
			this.tabPageBuscarComanda.Controls.Add(this.dataGridViewDetalleComanda);
			this.tabPageBuscarComanda.Font = new System.Drawing.Font("Maiandra GD", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.tabPageBuscarComanda.Location = new System.Drawing.Point(4, 37);
			this.tabPageBuscarComanda.Name = "tabPageBuscarComanda";
			this.tabPageBuscarComanda.Padding = new System.Windows.Forms.Padding(3);
			this.tabPageBuscarComanda.Size = new System.Drawing.Size(1344, 584);
			this.tabPageBuscarComanda.TabIndex = 0;
			this.tabPageBuscarComanda.Text = "Buscar Comanda";
			this.tabPageBuscarComanda.UseVisualStyleBackColor = true;
			// 
			// labelCajero
			// 
			this.labelCajero.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
			| System.Windows.Forms.AnchorStyles.Right)));
			this.labelCajero.BackColor = System.Drawing.Color.Transparent;
			this.labelCajero.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
			this.labelCajero.Font = new System.Drawing.Font("Maiandra GD", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.labelCajero.ForeColor = System.Drawing.Color.White;
			this.labelCajero.Location = new System.Drawing.Point(903, 401);
			this.labelCajero.Name = "labelCajero";
			this.labelCajero.Size = new System.Drawing.Size(46, 168);
			this.labelCajero.TabIndex = 115;
			this.labelCajero.Text = "C\r\nA\r\nJ\r\nE\r\nR\r\nO";
			this.labelCajero.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// labelCocinero
			// 
			this.labelCocinero.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
			| System.Windows.Forms.AnchorStyles.Right)));
			this.labelCocinero.BackColor = System.Drawing.Color.Transparent;
			this.labelCocinero.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
			this.labelCocinero.Font = new System.Drawing.Font("Maiandra GD", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.labelCocinero.ForeColor = System.Drawing.Color.White;
			this.labelCocinero.Location = new System.Drawing.Point(1128, 292);
			this.labelCocinero.Name = "labelCocinero";
			this.labelCocinero.Size = new System.Drawing.Size(46, 208);
			this.labelCocinero.TabIndex = 114;
			this.labelCocinero.Text = "C\r\nO\r\nC\r\nI\r\nN\r\nE\r\nR\r\nO";
			this.labelCocinero.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// labelMesero
			// 
			this.labelMesero.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
			| System.Windows.Forms.AnchorStyles.Right)));
			this.labelMesero.BackColor = System.Drawing.Color.Transparent;
			this.labelMesero.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
			this.labelMesero.Font = new System.Drawing.Font("Maiandra GD", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.labelMesero.ForeColor = System.Drawing.Color.White;
			this.labelMesero.Location = new System.Drawing.Point(903, 203);
			this.labelMesero.Name = "labelMesero";
			this.labelMesero.Size = new System.Drawing.Size(46, 168);
			this.labelMesero.TabIndex = 113;
			this.labelMesero.Text = "M\r\nE\r\nS\r\nE\r\nR\r\nO";
			this.labelMesero.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// pictureBoxCajeroComanda
			// 
			this.pictureBoxCajeroComanda.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
			| System.Windows.Forms.AnchorStyles.Right)));
			this.pictureBoxCajeroComanda.BackColor = System.Drawing.Color.Transparent;
			this.pictureBoxCajeroComanda.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
			this.pictureBoxCajeroComanda.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
			this.pictureBoxCajeroComanda.InitialImage = null;
			this.pictureBoxCajeroComanda.Location = new System.Drawing.Point(955, 407);
			this.pictureBoxCajeroComanda.Name = "pictureBoxCajeroComanda";
			this.pictureBoxCajeroComanda.Size = new System.Drawing.Size(150, 150);
			this.pictureBoxCajeroComanda.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
			this.pictureBoxCajeroComanda.TabIndex = 112;
			this.pictureBoxCajeroComanda.TabStop = false;
			// 
			// pictureBoxCocineroComanda
			// 
			this.pictureBoxCocineroComanda.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
			| System.Windows.Forms.AnchorStyles.Right)));
			this.pictureBoxCocineroComanda.BackColor = System.Drawing.Color.Transparent;
			this.pictureBoxCocineroComanda.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
			this.pictureBoxCocineroComanda.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
			this.pictureBoxCocineroComanda.InitialImage = null;
			this.pictureBoxCocineroComanda.Location = new System.Drawing.Point(1180, 314);
			this.pictureBoxCocineroComanda.Name = "pictureBoxCocineroComanda";
			this.pictureBoxCocineroComanda.Size = new System.Drawing.Size(150, 150);
			this.pictureBoxCocineroComanda.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
			this.pictureBoxCocineroComanda.TabIndex = 111;
			this.pictureBoxCocineroComanda.TabStop = false;
			// 
			// pictureBoxMeseroComanda
			// 
			this.pictureBoxMeseroComanda.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
			| System.Windows.Forms.AnchorStyles.Right)));
			this.pictureBoxMeseroComanda.BackColor = System.Drawing.Color.Transparent;
			this.pictureBoxMeseroComanda.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
			this.pictureBoxMeseroComanda.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
			this.pictureBoxMeseroComanda.InitialImage = null;
			this.pictureBoxMeseroComanda.Location = new System.Drawing.Point(955, 213);
			this.pictureBoxMeseroComanda.Name = "pictureBoxMeseroComanda";
			this.pictureBoxMeseroComanda.Size = new System.Drawing.Size(150, 150);
			this.pictureBoxMeseroComanda.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
			this.pictureBoxMeseroComanda.TabIndex = 110;
			this.pictureBoxMeseroComanda.TabStop = false;
			// 
			// numericUpDownIDComanda
			// 
			this.numericUpDownIDComanda.Font = new System.Drawing.Font("Lucida Bright", 15.75F);
			this.numericUpDownIDComanda.Location = new System.Drawing.Point(252, 3);
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
			this.numericUpDownIDComanda.Size = new System.Drawing.Size(445, 32);
			this.numericUpDownIDComanda.TabIndex = 109;
			this.numericUpDownIDComanda.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
			this.numericUpDownIDComanda.Value = new decimal(new int[] {
			1,
			0,
			0,
			0});
			// 
			// dataGridViewComandas
			// 
			this.dataGridViewComandas.AllowDrop = true;
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
			this.ID_COMANDA_ENCONTRADA,
			this.NOMBRE_CLIENTE,
			this.NUMERO_MESA,
			this.FECHA_CREACION,
			this.ESTATUS,
			this.ID_EMPLEADO,
			this.NOMBRE_MESERO,
			this.ID_EMPLEADO_COCINA,
			this.NOMBRE_COCINERO,
			this.ID_CAJERO,
			this.NOMBRE_CAJERO,
			this.FECHA_CIERRE,
			this.FORMA_PAGO,
			this.SERVICIO,
			this.SUBTOTAL,
			this.TOTAL});
			dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
			dataGridViewCellStyle2.BackColor = System.Drawing.Color.White;
			dataGridViewCellStyle2.Font = new System.Drawing.Font("Maiandra GD", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			dataGridViewCellStyle2.ForeColor = System.Drawing.Color.Black;
			dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
			dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.White;
			dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
			this.dataGridViewComandas.DefaultCellStyle = dataGridViewCellStyle2;
			this.dataGridViewComandas.Location = new System.Drawing.Point(7, 45);
			this.dataGridViewComandas.Name = "dataGridViewComandas";
			this.dataGridViewComandas.ReadOnly = true;
			this.dataGridViewComandas.RowHeadersVisible = false;
			dataGridViewCellStyle3.Font = new System.Drawing.Font("Maiandra GD", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.dataGridViewComandas.RowsDefaultCellStyle = dataGridViewCellStyle3;
			this.dataGridViewComandas.RowTemplate.Height = 111;
			this.dataGridViewComandas.RowTemplate.ReadOnly = true;
			this.dataGridViewComandas.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.CellSelect;
			this.dataGridViewComandas.Size = new System.Drawing.Size(1326, 150);
			this.dataGridViewComandas.TabIndex = 84;
			// 
			// labelIDComanda
			// 
			this.labelIDComanda.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
			this.labelIDComanda.BackColor = System.Drawing.Color.Transparent;
			this.labelIDComanda.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
			this.labelIDComanda.Font = new System.Drawing.Font("Maiandra GD", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.labelIDComanda.ForeColor = System.Drawing.Color.White;
			this.labelIDComanda.Location = new System.Drawing.Point(7, 3);
			this.labelIDComanda.Name = "labelIDComanda";
			this.labelIDComanda.Size = new System.Drawing.Size(239, 32);
			this.labelIDComanda.TabIndex = 82;
			this.labelIDComanda.Text = "ID DE LA COMANDA:";
			this.labelIDComanda.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// buttonBuscarComanda
			// 
			this.buttonBuscarComanda.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
			this.buttonBuscarComanda.BackColor = System.Drawing.Color.Transparent;
			this.buttonBuscarComanda.Cursor = System.Windows.Forms.Cursors.Hand;
			this.buttonBuscarComanda.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
			this.buttonBuscarComanda.Font = new System.Drawing.Font("Maiandra GD", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.buttonBuscarComanda.ForeColor = System.Drawing.Color.White;
			this.buttonBuscarComanda.Location = new System.Drawing.Point(726, 4);
			this.buttonBuscarComanda.Name = "buttonBuscarComanda";
			this.buttonBuscarComanda.Size = new System.Drawing.Size(604, 32);
			this.buttonBuscarComanda.TabIndex = 81;
			this.buttonBuscarComanda.Text = "BUSCAR COMANDA";
			this.buttonBuscarComanda.UseVisualStyleBackColor = false;
			this.buttonBuscarComanda.Click += new System.EventHandler(this.ButtonBuscarComandaClick);
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
			dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
			dataGridViewCellStyle4.BackColor = System.Drawing.Color.WhiteSmoke;
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
			this.DESCRIPCION_PRODUCTO_DETALLE_COMANDA,
			this.IMAGEN_PRODUCTO_DETALLE_COMANDA,
			this.CANTIDAD,
			this.PRECIO_UNITARIO,
			this.IMPORTE});
			this.dataGridViewDetalleComanda.Location = new System.Drawing.Point(7, 201);
			this.dataGridViewDetalleComanda.Name = "dataGridViewDetalleComanda";
			this.dataGridViewDetalleComanda.ReadOnly = true;
			this.dataGridViewDetalleComanda.RowHeadersVisible = false;
			dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
			dataGridViewCellStyle5.Font = new System.Drawing.Font("Maiandra GD", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.dataGridViewDetalleComanda.RowsDefaultCellStyle = dataGridViewCellStyle5;
			this.dataGridViewDetalleComanda.RowTemplate.Height = 100;
			this.dataGridViewDetalleComanda.RowTemplate.ReadOnly = true;
			this.dataGridViewDetalleComanda.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.CellSelect;
			this.dataGridViewDetalleComanda.Size = new System.Drawing.Size(877, 373);
			this.dataGridViewDetalleComanda.TabIndex = 80;
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
			// IMAGEN_PRODUCTO_DETALLE_COMANDA
			// 
			this.IMAGEN_PRODUCTO_DETALLE_COMANDA.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
			this.IMAGEN_PRODUCTO_DETALLE_COMANDA.HeaderText = "PRODUCTO";
			this.IMAGEN_PRODUCTO_DETALLE_COMANDA.ImageLayout = System.Windows.Forms.DataGridViewImageCellLayout.Stretch;
			this.IMAGEN_PRODUCTO_DETALLE_COMANDA.Name = "IMAGEN_PRODUCTO_DETALLE_COMANDA";
			this.IMAGEN_PRODUCTO_DETALLE_COMANDA.ReadOnly = true;
			this.IMAGEN_PRODUCTO_DETALLE_COMANDA.Resizable = System.Windows.Forms.DataGridViewTriState.True;
			this.IMAGEN_PRODUCTO_DETALLE_COMANDA.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
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
			// tabPageBuscarEmpleados
			// 
			this.tabPageBuscarEmpleados.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("tabPageBuscarEmpleados.BackgroundImage")));
			this.tabPageBuscarEmpleados.Controls.Add(this.numericUpDownIDEmpleado);
			this.tabPageBuscarEmpleados.Controls.Add(this.labelImagenEmpleado);
			this.tabPageBuscarEmpleados.Controls.Add(this.pictureBoxImagenEmpleado);
			this.tabPageBuscarEmpleados.Controls.Add(this.dataGridViewTelefonosEmpleado);
			this.tabPageBuscarEmpleados.Controls.Add(this.dataGridViewCorreosEmpleado);
			this.tabPageBuscarEmpleados.Controls.Add(this.dataGridViewEmpleados);
			this.tabPageBuscarEmpleados.Controls.Add(this.labelIDEmpleado);
			this.tabPageBuscarEmpleados.Controls.Add(this.buttonBuscarEmpleado);
			this.tabPageBuscarEmpleados.Font = new System.Drawing.Font("Maiandra GD", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.tabPageBuscarEmpleados.Location = new System.Drawing.Point(4, 37);
			this.tabPageBuscarEmpleados.Name = "tabPageBuscarEmpleados";
			this.tabPageBuscarEmpleados.Padding = new System.Windows.Forms.Padding(3);
			this.tabPageBuscarEmpleados.Size = new System.Drawing.Size(1344, 584);
			this.tabPageBuscarEmpleados.TabIndex = 2;
			this.tabPageBuscarEmpleados.Text = "Buscar Empleados";
			this.tabPageBuscarEmpleados.UseVisualStyleBackColor = true;
			// 
			// numericUpDownIDEmpleado
			// 
			this.numericUpDownIDEmpleado.Font = new System.Drawing.Font("Lucida Bright", 15.75F);
			this.numericUpDownIDEmpleado.Location = new System.Drawing.Point(249, 13);
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
			this.numericUpDownIDEmpleado.Size = new System.Drawing.Size(379, 32);
			this.numericUpDownIDEmpleado.TabIndex = 63;
			this.numericUpDownIDEmpleado.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
			this.numericUpDownIDEmpleado.Value = new decimal(new int[] {
			2,
			0,
			0,
			0});
			// 
			// labelImagenEmpleado
			// 
			this.labelImagenEmpleado.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
			this.labelImagenEmpleado.BackColor = System.Drawing.Color.Transparent;
			this.labelImagenEmpleado.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
			this.labelImagenEmpleado.Font = new System.Drawing.Font("Lucida Bright", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.labelImagenEmpleado.ForeColor = System.Drawing.Color.White;
			this.labelImagenEmpleado.Location = new System.Drawing.Point(811, 378);
			this.labelImagenEmpleado.Name = "labelImagenEmpleado";
			this.labelImagenEmpleado.Size = new System.Drawing.Size(112, 32);
			this.labelImagenEmpleado.TabIndex = 62;
			this.labelImagenEmpleado.Text = "IMAGEN:";
			this.labelImagenEmpleado.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// pictureBoxImagenEmpleado
			// 
			this.pictureBoxImagenEmpleado.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
			| System.Windows.Forms.AnchorStyles.Left) 
			| System.Windows.Forms.AnchorStyles.Right)));
			this.pictureBoxImagenEmpleado.BackColor = System.Drawing.Color.Transparent;
			this.pictureBoxImagenEmpleado.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
			this.pictureBoxImagenEmpleado.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
			this.pictureBoxImagenEmpleado.Location = new System.Drawing.Point(943, 252);
			this.pictureBoxImagenEmpleado.Name = "pictureBoxImagenEmpleado";
			this.pictureBoxImagenEmpleado.Size = new System.Drawing.Size(300, 300);
			this.pictureBoxImagenEmpleado.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
			this.pictureBoxImagenEmpleado.TabIndex = 61;
			this.pictureBoxImagenEmpleado.TabStop = false;
			// 
			// dataGridViewTelefonosEmpleado
			// 
			this.dataGridViewTelefonosEmpleado.AllowUserToAddRows = false;
			this.dataGridViewTelefonosEmpleado.AllowUserToResizeColumns = false;
			this.dataGridViewTelefonosEmpleado.AllowUserToResizeRows = false;
			this.dataGridViewTelefonosEmpleado.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
			| System.Windows.Forms.AnchorStyles.Right)));
			this.dataGridViewTelefonosEmpleado.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.Sunken;
			this.dataGridViewTelefonosEmpleado.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
			this.dataGridViewTelefonosEmpleado.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dataGridViewTelefonosEmpleado.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
			this.TELEFONOS_EMPLEADO});
			this.dataGridViewTelefonosEmpleado.Location = new System.Drawing.Point(432, 242);
			this.dataGridViewTelefonosEmpleado.Name = "dataGridViewTelefonosEmpleado";
			this.dataGridViewTelefonosEmpleado.ReadOnly = true;
			this.dataGridViewTelefonosEmpleado.RowHeadersVisible = false;
			dataGridViewCellStyle6.Font = new System.Drawing.Font("Maiandra GD", 9F);
			this.dataGridViewTelefonosEmpleado.RowsDefaultCellStyle = dataGridViewCellStyle6;
			this.dataGridViewTelefonosEmpleado.Size = new System.Drawing.Size(265, 336);
			this.dataGridViewTelefonosEmpleado.TabIndex = 60;
			// 
			// TELEFONOS_EMPLEADO
			// 
			this.TELEFONOS_EMPLEADO.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
			this.TELEFONOS_EMPLEADO.HeaderText = "TELÉFONOS";
			this.TELEFONOS_EMPLEADO.Name = "TELEFONOS_EMPLEADO";
			this.TELEFONOS_EMPLEADO.ReadOnly = true;
			// 
			// dataGridViewCorreosEmpleado
			// 
			this.dataGridViewCorreosEmpleado.AllowUserToAddRows = false;
			this.dataGridViewCorreosEmpleado.AllowUserToResizeColumns = false;
			this.dataGridViewCorreosEmpleado.AllowUserToResizeRows = false;
			this.dataGridViewCorreosEmpleado.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
			| System.Windows.Forms.AnchorStyles.Left)));
			this.dataGridViewCorreosEmpleado.BackgroundColor = System.Drawing.Color.DimGray;
			this.dataGridViewCorreosEmpleado.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.Sunken;
			this.dataGridViewCorreosEmpleado.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
			this.dataGridViewCorreosEmpleado.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dataGridViewCorreosEmpleado.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
			this.CORREOS_EMPLEADO});
			this.dataGridViewCorreosEmpleado.Location = new System.Drawing.Point(8, 242);
			this.dataGridViewCorreosEmpleado.Name = "dataGridViewCorreosEmpleado";
			this.dataGridViewCorreosEmpleado.ReadOnly = true;
			this.dataGridViewCorreosEmpleado.RowHeadersVisible = false;
			dataGridViewCellStyle7.Font = new System.Drawing.Font("Maiandra GD", 9F);
			this.dataGridViewCorreosEmpleado.RowsDefaultCellStyle = dataGridViewCellStyle7;
			this.dataGridViewCorreosEmpleado.Size = new System.Drawing.Size(418, 336);
			this.dataGridViewCorreosEmpleado.TabIndex = 59;
			// 
			// CORREOS_EMPLEADO
			// 
			this.CORREOS_EMPLEADO.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
			this.CORREOS_EMPLEADO.HeaderText = "CORREOS";
			this.CORREOS_EMPLEADO.Name = "CORREOS_EMPLEADO";
			this.CORREOS_EMPLEADO.ReadOnly = true;
			// 
			// dataGridViewEmpleados
			// 
			this.dataGridViewEmpleados.AllowUserToAddRows = false;
			this.dataGridViewEmpleados.AllowUserToDeleteRows = false;
			dataGridViewCellStyle8.NullValue = null;
			this.dataGridViewEmpleados.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle8;
			this.dataGridViewEmpleados.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
			| System.Windows.Forms.AnchorStyles.Left) 
			| System.Windows.Forms.AnchorStyles.Right)));
			this.dataGridViewEmpleados.BackgroundColor = System.Drawing.Color.White;
			this.dataGridViewEmpleados.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.Sunken;
			this.dataGridViewEmpleados.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
			this.dataGridViewEmpleados.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dataGridViewEmpleados.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
			this.ID_DEL_EMPLEADO,
			this.NOMBRE_DEL_EMPLEADO,
			this.APELLIDO_PATERNO,
			this.APELLIDO_MATERNO,
			this.PUESTO_DEL_EMPLEADO});
			dataGridViewCellStyle9.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
			dataGridViewCellStyle9.BackColor = System.Drawing.Color.White;
			dataGridViewCellStyle9.Font = new System.Drawing.Font("Maiandra GD", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			dataGridViewCellStyle9.ForeColor = System.Drawing.Color.Black;
			dataGridViewCellStyle9.SelectionBackColor = System.Drawing.SystemColors.Highlight;
			dataGridViewCellStyle9.SelectionForeColor = System.Drawing.Color.White;
			dataGridViewCellStyle9.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
			this.dataGridViewEmpleados.DefaultCellStyle = dataGridViewCellStyle9;
			this.dataGridViewEmpleados.Location = new System.Drawing.Point(8, 76);
			this.dataGridViewEmpleados.Name = "dataGridViewEmpleados";
			this.dataGridViewEmpleados.ReadOnly = true;
			this.dataGridViewEmpleados.RowHeadersVisible = false;
			dataGridViewCellStyle10.Font = new System.Drawing.Font("Maiandra GD", 9F);
			this.dataGridViewEmpleados.RowsDefaultCellStyle = dataGridViewCellStyle10;
			this.dataGridViewEmpleados.RowTemplate.Height = 129;
			this.dataGridViewEmpleados.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.CellSelect;
			this.dataGridViewEmpleados.Size = new System.Drawing.Size(1324, 150);
			this.dataGridViewEmpleados.TabIndex = 38;
			// 
			// ID_DEL_EMPLEADO
			// 
			this.ID_DEL_EMPLEADO.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
			this.ID_DEL_EMPLEADO.HeaderText = "ID DE EMPLEADO";
			this.ID_DEL_EMPLEADO.Name = "ID_DEL_EMPLEADO";
			this.ID_DEL_EMPLEADO.ReadOnly = true;
			// 
			// NOMBRE_DEL_EMPLEADO
			// 
			this.NOMBRE_DEL_EMPLEADO.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
			this.NOMBRE_DEL_EMPLEADO.HeaderText = "NOMBRE";
			this.NOMBRE_DEL_EMPLEADO.Name = "NOMBRE_DEL_EMPLEADO";
			this.NOMBRE_DEL_EMPLEADO.ReadOnly = true;
			// 
			// APELLIDO_PATERNO
			// 
			this.APELLIDO_PATERNO.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
			this.APELLIDO_PATERNO.HeaderText = "APELLIDO PATERNO";
			this.APELLIDO_PATERNO.Name = "APELLIDO_PATERNO";
			this.APELLIDO_PATERNO.ReadOnly = true;
			// 
			// APELLIDO_MATERNO
			// 
			this.APELLIDO_MATERNO.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
			this.APELLIDO_MATERNO.HeaderText = "APELLIDO MATERNO";
			this.APELLIDO_MATERNO.Name = "APELLIDO_MATERNO";
			this.APELLIDO_MATERNO.ReadOnly = true;
			// 
			// PUESTO_DEL_EMPLEADO
			// 
			this.PUESTO_DEL_EMPLEADO.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
			this.PUESTO_DEL_EMPLEADO.HeaderText = "PUESTO";
			this.PUESTO_DEL_EMPLEADO.Name = "PUESTO_DEL_EMPLEADO";
			this.PUESTO_DEL_EMPLEADO.ReadOnly = true;
			// 
			// labelIDEmpleado
			// 
			this.labelIDEmpleado.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
			this.labelIDEmpleado.BackColor = System.Drawing.Color.Transparent;
			this.labelIDEmpleado.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
			this.labelIDEmpleado.Font = new System.Drawing.Font("Maiandra GD", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.labelIDEmpleado.ForeColor = System.Drawing.Color.White;
			this.labelIDEmpleado.Location = new System.Drawing.Point(8, 13);
			this.labelIDEmpleado.Name = "labelIDEmpleado";
			this.labelIDEmpleado.Size = new System.Drawing.Size(235, 32);
			this.labelIDEmpleado.TabIndex = 32;
			this.labelIDEmpleado.Text = "ID DEL EMPLEADO:";
			this.labelIDEmpleado.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// buttonBuscarEmpleado
			// 
			this.buttonBuscarEmpleado.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
			this.buttonBuscarEmpleado.BackColor = System.Drawing.Color.Transparent;
			this.buttonBuscarEmpleado.Cursor = System.Windows.Forms.Cursors.Hand;
			this.buttonBuscarEmpleado.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
			this.buttonBuscarEmpleado.Font = new System.Drawing.Font("Maiandra GD", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.buttonBuscarEmpleado.ForeColor = System.Drawing.Color.White;
			this.buttonBuscarEmpleado.Location = new System.Drawing.Point(687, 13);
			this.buttonBuscarEmpleado.Name = "buttonBuscarEmpleado";
			this.buttonBuscarEmpleado.Size = new System.Drawing.Size(645, 31);
			this.buttonBuscarEmpleado.TabIndex = 31;
			this.buttonBuscarEmpleado.Text = "BUSCAR EMPLEADO";
			this.buttonBuscarEmpleado.UseVisualStyleBackColor = false;
			this.buttonBuscarEmpleado.Click += new System.EventHandler(this.ButtonBuscarEmpleadoClick);
			// 
			// tabPageBuscarProductos
			// 
			this.tabPageBuscarProductos.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("tabPageBuscarProductos.BackgroundImage")));
			this.tabPageBuscarProductos.Controls.Add(this.numericUpDownIDProducto);
			this.tabPageBuscarProductos.Controls.Add(this.labelImagenProducto);
			this.tabPageBuscarProductos.Controls.Add(this.pictureBoxImagenProducto);
			this.tabPageBuscarProductos.Controls.Add(this.labelIDProducto);
			this.tabPageBuscarProductos.Controls.Add(this.buttonBuscarProducto);
			this.tabPageBuscarProductos.Controls.Add(this.dataGridViewProductos);
			this.tabPageBuscarProductos.Font = new System.Drawing.Font("Maiandra GD", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.tabPageBuscarProductos.Location = new System.Drawing.Point(4, 37);
			this.tabPageBuscarProductos.Name = "tabPageBuscarProductos";
			this.tabPageBuscarProductos.Padding = new System.Windows.Forms.Padding(3);
			this.tabPageBuscarProductos.Size = new System.Drawing.Size(1344, 584);
			this.tabPageBuscarProductos.TabIndex = 3;
			this.tabPageBuscarProductos.Text = "Buscar Productos";
			this.tabPageBuscarProductos.UseVisualStyleBackColor = true;
			// 
			// numericUpDownIDProducto
			// 
			this.numericUpDownIDProducto.Font = new System.Drawing.Font("Lucida Bright", 15.75F);
			this.numericUpDownIDProducto.Location = new System.Drawing.Point(247, 13);
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
			this.numericUpDownIDProducto.Size = new System.Drawing.Size(346, 32);
			this.numericUpDownIDProducto.TabIndex = 40;
			this.numericUpDownIDProducto.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
			this.numericUpDownIDProducto.Value = new decimal(new int[] {
			1,
			0,
			0,
			0});
			// 
			// labelImagenProducto
			// 
			this.labelImagenProducto.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
			this.labelImagenProducto.BackColor = System.Drawing.Color.Transparent;
			this.labelImagenProducto.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
			this.labelImagenProducto.Font = new System.Drawing.Font("Lucida Bright", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.labelImagenProducto.ForeColor = System.Drawing.Color.White;
			this.labelImagenProducto.Location = new System.Drawing.Point(348, 386);
			this.labelImagenProducto.Name = "labelImagenProducto";
			this.labelImagenProducto.Size = new System.Drawing.Size(112, 32);
			this.labelImagenProducto.TabIndex = 39;
			this.labelImagenProducto.Text = "IMAGEN:";
			this.labelImagenProducto.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// pictureBoxImagenProducto
			// 
			this.pictureBoxImagenProducto.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
			| System.Windows.Forms.AnchorStyles.Left) 
			| System.Windows.Forms.AnchorStyles.Right)));
			this.pictureBoxImagenProducto.BackColor = System.Drawing.Color.Transparent;
			this.pictureBoxImagenProducto.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
			this.pictureBoxImagenProducto.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
			this.pictureBoxImagenProducto.Location = new System.Drawing.Point(485, 241);
			this.pictureBoxImagenProducto.Name = "pictureBoxImagenProducto";
			this.pictureBoxImagenProducto.Size = new System.Drawing.Size(320, 320);
			this.pictureBoxImagenProducto.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
			this.pictureBoxImagenProducto.TabIndex = 38;
			this.pictureBoxImagenProducto.TabStop = false;
			// 
			// labelIDProducto
			// 
			this.labelIDProducto.BackColor = System.Drawing.Color.Transparent;
			this.labelIDProducto.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
			this.labelIDProducto.Font = new System.Drawing.Font("Maiandra GD", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.labelIDProducto.ForeColor = System.Drawing.Color.White;
			this.labelIDProducto.Location = new System.Drawing.Point(10, 13);
			this.labelIDProducto.Name = "labelIDProducto";
			this.labelIDProducto.Size = new System.Drawing.Size(210, 32);
			this.labelIDProducto.TabIndex = 32;
			this.labelIDProducto.Text = "ID DEL PRODUCTO:";
			this.labelIDProducto.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// buttonBuscarProducto
			// 
			this.buttonBuscarProducto.BackColor = System.Drawing.Color.Transparent;
			this.buttonBuscarProducto.Cursor = System.Windows.Forms.Cursors.Hand;
			this.buttonBuscarProducto.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
			this.buttonBuscarProducto.Font = new System.Drawing.Font("Maiandra GD", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.buttonBuscarProducto.ForeColor = System.Drawing.Color.White;
			this.buttonBuscarProducto.Location = new System.Drawing.Point(699, 13);
			this.buttonBuscarProducto.Name = "buttonBuscarProducto";
			this.buttonBuscarProducto.Size = new System.Drawing.Size(616, 28);
			this.buttonBuscarProducto.TabIndex = 31;
			this.buttonBuscarProducto.Text = "BUSCAR PRODUCTO";
			this.buttonBuscarProducto.UseVisualStyleBackColor = false;
			this.buttonBuscarProducto.Click += new System.EventHandler(this.ButtonBuscarProductoClick);
			// 
			// dataGridViewProductos
			// 
			this.dataGridViewProductos.AllowUserToAddRows = false;
			this.dataGridViewProductos.AllowUserToDeleteRows = false;
			dataGridViewCellStyle11.NullValue = null;
			this.dataGridViewProductos.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle11;
			this.dataGridViewProductos.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
			| System.Windows.Forms.AnchorStyles.Left) 
			| System.Windows.Forms.AnchorStyles.Right)));
			this.dataGridViewProductos.BackgroundColor = System.Drawing.Color.White;
			this.dataGridViewProductos.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.Sunken;
			this.dataGridViewProductos.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
			this.dataGridViewProductos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dataGridViewProductos.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
			this.ID_DE_PRODUCTO,
			this.NOMBRE_DE_PRODUCTO,
			this.TIPO_PRODUCTO,
			this.DESCRIPCION,
			this.DISPONIBILIDAD,
			this.OBSERVACIONES_PRODUCTO,
			this.COSTO});
			dataGridViewCellStyle12.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
			dataGridViewCellStyle12.BackColor = System.Drawing.Color.White;
			dataGridViewCellStyle12.Font = new System.Drawing.Font("Maiandra GD", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			dataGridViewCellStyle12.ForeColor = System.Drawing.Color.Black;
			dataGridViewCellStyle12.SelectionBackColor = System.Drawing.SystemColors.Highlight;
			dataGridViewCellStyle12.SelectionForeColor = System.Drawing.Color.White;
			dataGridViewCellStyle12.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
			this.dataGridViewProductos.DefaultCellStyle = dataGridViewCellStyle12;
			this.dataGridViewProductos.Location = new System.Drawing.Point(14, 76);
			this.dataGridViewProductos.Name = "dataGridViewProductos";
			this.dataGridViewProductos.ReadOnly = true;
			this.dataGridViewProductos.RowHeadersVisible = false;
			dataGridViewCellStyle13.Font = new System.Drawing.Font("Maiandra GD", 9F);
			this.dataGridViewProductos.RowsDefaultCellStyle = dataGridViewCellStyle13;
			this.dataGridViewProductos.RowTemplate.Height = 120;
			this.dataGridViewProductos.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.CellSelect;
			this.dataGridViewProductos.Size = new System.Drawing.Size(1324, 150);
			this.dataGridViewProductos.TabIndex = 6;
			// 
			// ID_DE_PRODUCTO
			// 
			this.ID_DE_PRODUCTO.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader;
			this.ID_DE_PRODUCTO.HeaderText = "ID DE PRODUCTO";
			this.ID_DE_PRODUCTO.Name = "ID_DE_PRODUCTO";
			this.ID_DE_PRODUCTO.ReadOnly = true;
			this.ID_DE_PRODUCTO.Width = 143;
			// 
			// NOMBRE_DE_PRODUCTO
			// 
			this.NOMBRE_DE_PRODUCTO.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
			this.NOMBRE_DE_PRODUCTO.HeaderText = "NOMBRE DE PRODUCTO";
			this.NOMBRE_DE_PRODUCTO.Name = "NOMBRE_DE_PRODUCTO";
			this.NOMBRE_DE_PRODUCTO.ReadOnly = true;
			// 
			// TIPO_PRODUCTO
			// 
			this.TIPO_PRODUCTO.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
			this.TIPO_PRODUCTO.HeaderText = "TIPO DE PRODUCTO";
			this.TIPO_PRODUCTO.Name = "TIPO_PRODUCTO";
			this.TIPO_PRODUCTO.ReadOnly = true;
			// 
			// DESCRIPCION
			// 
			this.DESCRIPCION.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
			this.DESCRIPCION.HeaderText = "DESCRIPCION";
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
			// OBSERVACIONES_PRODUCTO
			// 
			this.OBSERVACIONES_PRODUCTO.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
			this.OBSERVACIONES_PRODUCTO.HeaderText = "OBSERVACIONES";
			this.OBSERVACIONES_PRODUCTO.Name = "OBSERVACIONES_PRODUCTO";
			this.OBSERVACIONES_PRODUCTO.ReadOnly = true;
			// 
			// COSTO
			// 
			this.COSTO.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
			this.COSTO.HeaderText = "COSTO";
			this.COSTO.Name = "COSTO";
			this.COSTO.ReadOnly = true;
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
			this.ESTATUS.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
			this.ESTATUS.HeaderText = "ESTATUS";
			this.ESTATUS.Name = "ESTATUS";
			this.ESTATUS.ReadOnly = true;
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
			// ID_EMPLEADO_COCINA
			// 
			this.ID_EMPLEADO_COCINA.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader;
			this.ID_EMPLEADO_COCINA.HeaderText = "ID COCINERO";
			this.ID_EMPLEADO_COCINA.Name = "ID_EMPLEADO_COCINA";
			this.ID_EMPLEADO_COCINA.ReadOnly = true;
			this.ID_EMPLEADO_COCINA.Width = 105;
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
			this.ID_CAJERO.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader;
			this.ID_CAJERO.HeaderText = "ID CAJERO";
			this.ID_CAJERO.Name = "ID_CAJERO";
			this.ID_CAJERO.ReadOnly = true;
			this.ID_CAJERO.Width = 87;
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
			this.FORMA_PAGO.HeaderText = "FORMA DE PAGO";
			this.FORMA_PAGO.Name = "FORMA_PAGO";
			this.FORMA_PAGO.ReadOnly = true;
			this.FORMA_PAGO.Width = 92;
			// 
			// SERVICIO
			// 
			this.SERVICIO.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
			this.SERVICIO.HeaderText = "SERVICIO";
			this.SERVICIO.Name = "SERVICIO";
			this.SERVICIO.ReadOnly = true;
			// 
			// SUBTOTAL
			// 
			this.SUBTOTAL.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
			this.SUBTOTAL.HeaderText = "SUBTOTAL";
			this.SUBTOTAL.Name = "SUBTOTAL";
			this.SUBTOTAL.ReadOnly = true;
			// 
			// TOTAL
			// 
			this.TOTAL.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
			this.TOTAL.HeaderText = "TOTAL";
			this.TOTAL.Name = "TOTAL";
			this.TOTAL.ReadOnly = true;
			this.TOTAL.Width = 72;
			// 
			// BuscarTodo
			// 
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
			this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
			this.ClientSize = new System.Drawing.Size(1350, 727);
			this.Controls.Add(this.tabControlBuscar);
			this.Controls.Add(this.panelFondo);
			this.Controls.Add(this.buttonGenerarReporte);
			this.DoubleBuffered = true;
			this.Font = new System.Drawing.Font("Maiandra GD", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.HelpButton = true;
			this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
			this.MinimumSize = new System.Drawing.Size(1364, 736);
			this.Name = "BuscarTodo";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "SISTEMA MEMÍN® ";
			this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
			this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.BuscarComandasFormClosing);
			this.panelFondo.ResumeLayout(false);
			this.tabControlBuscar.ResumeLayout(false);
			this.tabPageBuscarComanda.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.pictureBoxCajeroComanda)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.pictureBoxCocineroComanda)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.pictureBoxMeseroComanda)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.numericUpDownIDComanda)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.dataGridViewComandas)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.dataGridViewDetalleComanda)).EndInit();
			this.tabPageBuscarEmpleados.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.numericUpDownIDEmpleado)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.pictureBoxImagenEmpleado)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.dataGridViewTelefonosEmpleado)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.dataGridViewCorreosEmpleado)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.dataGridViewEmpleados)).EndInit();
			this.tabPageBuscarProductos.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.numericUpDownIDProducto)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.pictureBoxImagenProducto)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.dataGridViewProductos)).EndInit();
			this.ResumeLayout(false);

		}
	}
}
