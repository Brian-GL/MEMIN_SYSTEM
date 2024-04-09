/*
 * Creado por SharpDevelop.
 * Usuario: Brian Gaytan Lomeli
 * Fecha: 27/10/2019
 * Hora: 17:58
 * 
 * Para cambiar esta plantilla use Herramientas | Opciones | Codificación | Editar Encabezados Estándar
 */
namespace MEMIN_SYSTEM
{
	partial class RegistrarComanda
	{
		/// <summary>
		/// Designer variable used to keep track of non-visual components.
		/// </summary>
		private System.ComponentModel.IContainer components = null;
		private System.Windows.Forms.Timer timerFechaHora;
		private System.Windows.Forms.Panel panelFondo;
		private System.Windows.Forms.Label labelTitulo;
		private System.Windows.Forms.TabControl tabControlRegistrarComandas;
		private System.Windows.Forms.TabPage tabPageRegistrarComanda;
		private System.Windows.Forms.Label labelFechaHoraCreacion;
		private System.Windows.Forms.Label labelFechaCreacion;
		private System.Windows.Forms.TextBox textBoxEstatus;
		private System.Windows.Forms.Label labelEstado;
		private System.Windows.Forms.TextBox textBoxNombreEmpleado;
		private System.Windows.Forms.Label labelNombreEmpleado;
		private System.Windows.Forms.TextBox textBoxNombreCliente;
		private System.Windows.Forms.Label labelNombreCliente;
		private System.Windows.Forms.TextBox textBoxIDMesero;
		private System.Windows.Forms.Label labelIDMesero;
		private System.Windows.Forms.TextBox textBoxID;
		private System.Windows.Forms.Label labelID;
		private System.Windows.Forms.TabPage tabPageAgregarProductos;
		private System.Windows.Forms.Label labelIDProducto;
		private System.Windows.Forms.Button buttonBuscarProductos;
		private System.Windows.Forms.Button buttonGuardar;
		private System.Windows.Forms.DataGridView dataGridViewDetalleComanda;
		private System.Windows.Forms.NumericUpDown numericUpDownNumeroMesa;
		private System.Windows.Forms.Label labelNumeroDeMesa;
		private System.Windows.Forms.MonthCalendar monthCalendarFechaCreacion;
		private System.Windows.Forms.DataGridViewTextBoxColumn ID_PRODUCTO;
		private System.Windows.Forms.DataGridViewTextBoxColumn NOMBRE_PRODUCTO;
		private System.Windows.Forms.DataGridViewTextBoxColumn PRECIO_UNITARIO;
		private System.Windows.Forms.DataGridViewTextBoxColumn IMPORTE;
		private System.Windows.Forms.Label labelTotal;
		private System.Windows.Forms.DataGridViewButtonColumn RETIRAR;
		private System.Windows.Forms.PictureBox pictureBoxImagenEmpleado;
		private System.Windows.Forms.DataGridViewTextBoxColumn DESCRIPCION_PRODUCTO;
		private System.Windows.Forms.Label labelIVA;
		private System.Windows.Forms.Label labelSubtotal;
		private System.Windows.Forms.ComboBox comboBoxProductos;
		private System.Windows.Forms.TextBox textBoxTotal;
		private System.Windows.Forms.TextBox textBoxIVA;
		private System.Windows.Forms.TextBox textBoxSubTotal;
		private System.Windows.Forms.Label labelImagenEmpleado;
		
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
			this.components = new System.ComponentModel.Container();
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(RegistrarComanda));
			System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
			System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
			System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
			System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
			System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
			this.timerFechaHora = new System.Windows.Forms.Timer(this.components);
			this.panelFondo = new System.Windows.Forms.Panel();
			this.labelTitulo = new System.Windows.Forms.Label();
			this.tabControlRegistrarComandas = new System.Windows.Forms.TabControl();
			this.tabPageRegistrarComanda = new System.Windows.Forms.TabPage();
			this.labelImagenEmpleado = new System.Windows.Forms.Label();
			this.pictureBoxImagenEmpleado = new System.Windows.Forms.PictureBox();
			this.numericUpDownNumeroMesa = new System.Windows.Forms.NumericUpDown();
			this.labelNumeroDeMesa = new System.Windows.Forms.Label();
			this.monthCalendarFechaCreacion = new System.Windows.Forms.MonthCalendar();
			this.labelFechaHoraCreacion = new System.Windows.Forms.Label();
			this.labelFechaCreacion = new System.Windows.Forms.Label();
			this.textBoxEstatus = new System.Windows.Forms.TextBox();
			this.labelEstado = new System.Windows.Forms.Label();
			this.textBoxNombreEmpleado = new System.Windows.Forms.TextBox();
			this.labelNombreEmpleado = new System.Windows.Forms.Label();
			this.textBoxNombreCliente = new System.Windows.Forms.TextBox();
			this.labelNombreCliente = new System.Windows.Forms.Label();
			this.textBoxIDMesero = new System.Windows.Forms.TextBox();
			this.labelIDMesero = new System.Windows.Forms.Label();
			this.textBoxID = new System.Windows.Forms.TextBox();
			this.labelID = new System.Windows.Forms.Label();
			this.tabPageAgregarProductos = new System.Windows.Forms.TabPage();
			this.textBoxTotal = new System.Windows.Forms.TextBox();
			this.textBoxIVA = new System.Windows.Forms.TextBox();
			this.textBoxSubTotal = new System.Windows.Forms.TextBox();
			this.comboBoxProductos = new System.Windows.Forms.ComboBox();
			this.labelIVA = new System.Windows.Forms.Label();
			this.labelSubtotal = new System.Windows.Forms.Label();
			this.buttonGuardar = new System.Windows.Forms.Button();
			this.labelTotal = new System.Windows.Forms.Label();
			this.dataGridViewDetalleComanda = new System.Windows.Forms.DataGridView();
			this.ID_PRODUCTO = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.NOMBRE_PRODUCTO = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.DESCRIPCION_PRODUCTO = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.PRECIO_UNITARIO = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.IMPORTE = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.RETIRAR = new System.Windows.Forms.DataGridViewButtonColumn();
			this.labelIDProducto = new System.Windows.Forms.Label();
			this.buttonBuscarProductos = new System.Windows.Forms.Button();
			this.panelFondo.SuspendLayout();
			this.tabControlRegistrarComandas.SuspendLayout();
			this.tabPageRegistrarComanda.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.pictureBoxImagenEmpleado)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.numericUpDownNumeroMesa)).BeginInit();
			this.tabPageAgregarProductos.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.dataGridViewDetalleComanda)).BeginInit();
			this.SuspendLayout();
			// 
			// timerFechaHora
			// 
			this.timerFechaHora.Enabled = true;
			this.timerFechaHora.Tick += new System.EventHandler(this.TimerFechaHoraTick);
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
			this.panelFondo.TabIndex = 104;
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
			this.labelTitulo.Text = "REGISTRAR COMANDA";
			this.labelTitulo.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// tabControlRegistrarComandas
			// 
			this.tabControlRegistrarComandas.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
			| System.Windows.Forms.AnchorStyles.Right)));
			this.tabControlRegistrarComandas.Appearance = System.Windows.Forms.TabAppearance.FlatButtons;
			this.tabControlRegistrarComandas.Controls.Add(this.tabPageRegistrarComanda);
			this.tabControlRegistrarComandas.Controls.Add(this.tabPageAgregarProductos);
			this.tabControlRegistrarComandas.Font = new System.Drawing.Font("Maiandra GD", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.tabControlRegistrarComandas.HotTrack = true;
			this.tabControlRegistrarComandas.Location = new System.Drawing.Point(0, 100);
			this.tabControlRegistrarComandas.Name = "tabControlRegistrarComandas";
			this.tabControlRegistrarComandas.SelectedIndex = 0;
			this.tabControlRegistrarComandas.ShowToolTips = true;
			this.tabControlRegistrarComandas.Size = new System.Drawing.Size(1352, 625);
			this.tabControlRegistrarComandas.SizeMode = System.Windows.Forms.TabSizeMode.FillToRight;
			this.tabControlRegistrarComandas.TabIndex = 105;
			// 
			// tabPageRegistrarComanda
			// 
			this.tabPageRegistrarComanda.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("tabPageRegistrarComanda.BackgroundImage")));
			this.tabPageRegistrarComanda.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
			this.tabPageRegistrarComanda.Controls.Add(this.labelImagenEmpleado);
			this.tabPageRegistrarComanda.Controls.Add(this.pictureBoxImagenEmpleado);
			this.tabPageRegistrarComanda.Controls.Add(this.numericUpDownNumeroMesa);
			this.tabPageRegistrarComanda.Controls.Add(this.labelNumeroDeMesa);
			this.tabPageRegistrarComanda.Controls.Add(this.monthCalendarFechaCreacion);
			this.tabPageRegistrarComanda.Controls.Add(this.labelFechaHoraCreacion);
			this.tabPageRegistrarComanda.Controls.Add(this.labelFechaCreacion);
			this.tabPageRegistrarComanda.Controls.Add(this.textBoxEstatus);
			this.tabPageRegistrarComanda.Controls.Add(this.labelEstado);
			this.tabPageRegistrarComanda.Controls.Add(this.textBoxNombreEmpleado);
			this.tabPageRegistrarComanda.Controls.Add(this.labelNombreEmpleado);
			this.tabPageRegistrarComanda.Controls.Add(this.textBoxNombreCliente);
			this.tabPageRegistrarComanda.Controls.Add(this.labelNombreCliente);
			this.tabPageRegistrarComanda.Controls.Add(this.textBoxIDMesero);
			this.tabPageRegistrarComanda.Controls.Add(this.labelIDMesero);
			this.tabPageRegistrarComanda.Controls.Add(this.textBoxID);
			this.tabPageRegistrarComanda.Controls.Add(this.labelID);
			this.tabPageRegistrarComanda.Font = new System.Drawing.Font("Lucida Bright", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.tabPageRegistrarComanda.Location = new System.Drawing.Point(4, 37);
			this.tabPageRegistrarComanda.Name = "tabPageRegistrarComanda";
			this.tabPageRegistrarComanda.Padding = new System.Windows.Forms.Padding(3);
			this.tabPageRegistrarComanda.Size = new System.Drawing.Size(1344, 584);
			this.tabPageRegistrarComanda.TabIndex = 0;
			this.tabPageRegistrarComanda.Text = "Agregar Datos Generales";
			this.tabPageRegistrarComanda.UseVisualStyleBackColor = true;
			// 
			// labelImagenEmpleado
			// 
			this.labelImagenEmpleado.BackColor = System.Drawing.Color.Transparent;
			this.labelImagenEmpleado.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
			this.labelImagenEmpleado.Font = new System.Drawing.Font("Maiandra GD", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.labelImagenEmpleado.ForeColor = System.Drawing.Color.White;
			this.labelImagenEmpleado.Location = new System.Drawing.Point(995, 54);
			this.labelImagenEmpleado.Name = "labelImagenEmpleado";
			this.labelImagenEmpleado.Size = new System.Drawing.Size(300, 36);
			this.labelImagenEmpleado.TabIndex = 113;
			this.labelImagenEmpleado.Text = "MESERO:";
			this.labelImagenEmpleado.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// pictureBoxImagenEmpleado
			// 
			this.pictureBoxImagenEmpleado.BackColor = System.Drawing.Color.Transparent;
			this.pictureBoxImagenEmpleado.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
			this.pictureBoxImagenEmpleado.Location = new System.Drawing.Point(995, 108);
			this.pictureBoxImagenEmpleado.Name = "pictureBoxImagenEmpleado";
			this.pictureBoxImagenEmpleado.Size = new System.Drawing.Size(300, 300);
			this.pictureBoxImagenEmpleado.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
			this.pictureBoxImagenEmpleado.TabIndex = 112;
			this.pictureBoxImagenEmpleado.TabStop = false;
			// 
			// numericUpDownNumeroMesa
			// 
			this.numericUpDownNumeroMesa.Font = new System.Drawing.Font("Lucida Bright", 18F);
			this.numericUpDownNumeroMesa.Location = new System.Drawing.Point(359, 284);
			this.numericUpDownNumeroMesa.Maximum = new decimal(new int[] {
			10000,
			0,
			0,
			0});
			this.numericUpDownNumeroMesa.Minimum = new decimal(new int[] {
			1,
			0,
			0,
			0});
			this.numericUpDownNumeroMesa.Name = "numericUpDownNumeroMesa";
			this.numericUpDownNumeroMesa.Size = new System.Drawing.Size(575, 36);
			this.numericUpDownNumeroMesa.TabIndex = 111;
			this.numericUpDownNumeroMesa.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
			this.numericUpDownNumeroMesa.Value = new decimal(new int[] {
			1,
			0,
			0,
			0});
			// 
			// labelNumeroDeMesa
			// 
			this.labelNumeroDeMesa.BackColor = System.Drawing.Color.Transparent;
			this.labelNumeroDeMesa.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
			this.labelNumeroDeMesa.Font = new System.Drawing.Font("Maiandra GD", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.labelNumeroDeMesa.ForeColor = System.Drawing.Color.White;
			this.labelNumeroDeMesa.Location = new System.Drawing.Point(12, 283);
			this.labelNumeroDeMesa.Name = "labelNumeroDeMesa";
			this.labelNumeroDeMesa.Size = new System.Drawing.Size(319, 36);
			this.labelNumeroDeMesa.TabIndex = 110;
			this.labelNumeroDeMesa.Text = "NÚMERO DE MESA:";
			this.labelNumeroDeMesa.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// monthCalendarFechaCreacion
			// 
			this.monthCalendarFechaCreacion.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
			this.monthCalendarFechaCreacion.CalendarDimensions = new System.Drawing.Size(4, 1);
			this.monthCalendarFechaCreacion.Font = new System.Drawing.Font("Maiandra GD", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.monthCalendarFechaCreacion.Location = new System.Drawing.Point(45, 406);
			this.monthCalendarFechaCreacion.MaxDate = new System.DateTime(2100, 1, 1, 0, 0, 0, 0);
			this.monthCalendarFechaCreacion.MinDate = new System.DateTime(2019, 11, 5, 0, 0, 0, 0);
			this.monthCalendarFechaCreacion.Name = "monthCalendarFechaCreacion";
			this.monthCalendarFechaCreacion.ShowWeekNumbers = true;
			this.monthCalendarFechaCreacion.TabIndex = 109;
			// 
			// labelFechaHoraCreacion
			// 
			this.labelFechaHoraCreacion.BackColor = System.Drawing.Color.Transparent;
			this.labelFechaHoraCreacion.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
			this.labelFechaHoraCreacion.Font = new System.Drawing.Font("Maiandra GD", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.labelFechaHoraCreacion.ForeColor = System.Drawing.Color.White;
			this.labelFechaHoraCreacion.Location = new System.Drawing.Point(359, 231);
			this.labelFechaHoraCreacion.Name = "labelFechaHoraCreacion";
			this.labelFechaHoraCreacion.Size = new System.Drawing.Size(575, 36);
			this.labelFechaHoraCreacion.TabIndex = 108;
			this.labelFechaHoraCreacion.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// labelFechaCreacion
			// 
			this.labelFechaCreacion.BackColor = System.Drawing.Color.Transparent;
			this.labelFechaCreacion.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
			this.labelFechaCreacion.Font = new System.Drawing.Font("Maiandra GD", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.labelFechaCreacion.ForeColor = System.Drawing.Color.White;
			this.labelFechaCreacion.Location = new System.Drawing.Point(12, 230);
			this.labelFechaCreacion.Name = "labelFechaCreacion";
			this.labelFechaCreacion.Size = new System.Drawing.Size(319, 36);
			this.labelFechaCreacion.TabIndex = 107;
			this.labelFechaCreacion.Text = "FECHA DE CREACIÓN:";
			this.labelFechaCreacion.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// textBoxEstatus
			// 
			this.textBoxEstatus.Font = new System.Drawing.Font("Maiandra GD", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.textBoxEstatus.Location = new System.Drawing.Point(359, 335);
			this.textBoxEstatus.Name = "textBoxEstatus";
			this.textBoxEstatus.ReadOnly = true;
			this.textBoxEstatus.ScrollBars = System.Windows.Forms.ScrollBars.Horizontal;
			this.textBoxEstatus.Size = new System.Drawing.Size(575, 36);
			this.textBoxEstatus.TabIndex = 106;
			this.textBoxEstatus.Text = "Pedida";
			// 
			// labelEstado
			// 
			this.labelEstado.BackColor = System.Drawing.Color.Transparent;
			this.labelEstado.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
			this.labelEstado.Font = new System.Drawing.Font("Maiandra GD", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.labelEstado.ForeColor = System.Drawing.Color.White;
			this.labelEstado.Location = new System.Drawing.Point(12, 335);
			this.labelEstado.Name = "labelEstado";
			this.labelEstado.Size = new System.Drawing.Size(319, 36);
			this.labelEstado.TabIndex = 105;
			this.labelEstado.Text = "ESTATUS:";
			this.labelEstado.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// textBoxNombreEmpleado
			// 
			this.textBoxNombreEmpleado.Font = new System.Drawing.Font("Maiandra GD", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.textBoxNombreEmpleado.Location = new System.Drawing.Point(359, 120);
			this.textBoxNombreEmpleado.Name = "textBoxNombreEmpleado";
			this.textBoxNombreEmpleado.ReadOnly = true;
			this.textBoxNombreEmpleado.ScrollBars = System.Windows.Forms.ScrollBars.Horizontal;
			this.textBoxNombreEmpleado.Size = new System.Drawing.Size(575, 36);
			this.textBoxNombreEmpleado.TabIndex = 102;
			this.textBoxNombreEmpleado.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
			// 
			// labelNombreEmpleado
			// 
			this.labelNombreEmpleado.BackColor = System.Drawing.Color.Transparent;
			this.labelNombreEmpleado.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
			this.labelNombreEmpleado.Font = new System.Drawing.Font("Maiandra GD", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.labelNombreEmpleado.ForeColor = System.Drawing.Color.White;
			this.labelNombreEmpleado.Location = new System.Drawing.Point(12, 119);
			this.labelNombreEmpleado.Name = "labelNombreEmpleado";
			this.labelNombreEmpleado.Size = new System.Drawing.Size(319, 36);
			this.labelNombreEmpleado.TabIndex = 101;
			this.labelNombreEmpleado.Text = "NOMBRE DEL MESERO:";
			this.labelNombreEmpleado.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// textBoxNombreCliente
			// 
			this.textBoxNombreCliente.Font = new System.Drawing.Font("Maiandra GD", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.textBoxNombreCliente.Location = new System.Drawing.Point(359, 176);
			this.textBoxNombreCliente.MaxLength = 100;
			this.textBoxNombreCliente.Name = "textBoxNombreCliente";
			this.textBoxNombreCliente.ScrollBars = System.Windows.Forms.ScrollBars.Horizontal;
			this.textBoxNombreCliente.Size = new System.Drawing.Size(575, 36);
			this.textBoxNombreCliente.TabIndex = 100;
			// 
			// labelNombreCliente
			// 
			this.labelNombreCliente.BackColor = System.Drawing.Color.Transparent;
			this.labelNombreCliente.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
			this.labelNombreCliente.Font = new System.Drawing.Font("Maiandra GD", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.labelNombreCliente.ForeColor = System.Drawing.Color.White;
			this.labelNombreCliente.Location = new System.Drawing.Point(12, 175);
			this.labelNombreCliente.Name = "labelNombreCliente";
			this.labelNombreCliente.Size = new System.Drawing.Size(319, 36);
			this.labelNombreCliente.TabIndex = 99;
			this.labelNombreCliente.Text = "NOMBRE DEL CLIENTE:";
			this.labelNombreCliente.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// textBoxIDMesero
			// 
			this.textBoxIDMesero.Font = new System.Drawing.Font("Maiandra GD", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.textBoxIDMesero.Location = new System.Drawing.Point(359, 68);
			this.textBoxIDMesero.Name = "textBoxIDMesero";
			this.textBoxIDMesero.ReadOnly = true;
			this.textBoxIDMesero.ScrollBars = System.Windows.Forms.ScrollBars.Horizontal;
			this.textBoxIDMesero.Size = new System.Drawing.Size(575, 36);
			this.textBoxIDMesero.TabIndex = 98;
			this.textBoxIDMesero.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
			// 
			// labelIDMesero
			// 
			this.labelIDMesero.BackColor = System.Drawing.Color.Transparent;
			this.labelIDMesero.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
			this.labelIDMesero.Font = new System.Drawing.Font("Maiandra GD", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.labelIDMesero.ForeColor = System.Drawing.Color.White;
			this.labelIDMesero.Location = new System.Drawing.Point(12, 67);
			this.labelIDMesero.Name = "labelIDMesero";
			this.labelIDMesero.Size = new System.Drawing.Size(319, 36);
			this.labelIDMesero.TabIndex = 97;
			this.labelIDMesero.Text = "ID DEL MESERO:";
			this.labelIDMesero.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// textBoxID
			// 
			this.textBoxID.Font = new System.Drawing.Font("Maiandra GD", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.textBoxID.Location = new System.Drawing.Point(359, 14);
			this.textBoxID.Name = "textBoxID";
			this.textBoxID.ReadOnly = true;
			this.textBoxID.ScrollBars = System.Windows.Forms.ScrollBars.Horizontal;
			this.textBoxID.Size = new System.Drawing.Size(575, 36);
			this.textBoxID.TabIndex = 96;
			this.textBoxID.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
			// 
			// labelID
			// 
			this.labelID.BackColor = System.Drawing.Color.Transparent;
			this.labelID.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
			this.labelID.Font = new System.Drawing.Font("Maiandra GD", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.labelID.ForeColor = System.Drawing.Color.White;
			this.labelID.Location = new System.Drawing.Point(12, 14);
			this.labelID.Name = "labelID";
			this.labelID.Size = new System.Drawing.Size(319, 36);
			this.labelID.TabIndex = 95;
			this.labelID.Text = "ID DE LA NUEVA COMANDA:";
			this.labelID.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// tabPageAgregarProductos
			// 
			this.tabPageAgregarProductos.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("tabPageAgregarProductos.BackgroundImage")));
			this.tabPageAgregarProductos.Controls.Add(this.textBoxTotal);
			this.tabPageAgregarProductos.Controls.Add(this.textBoxIVA);
			this.tabPageAgregarProductos.Controls.Add(this.textBoxSubTotal);
			this.tabPageAgregarProductos.Controls.Add(this.comboBoxProductos);
			this.tabPageAgregarProductos.Controls.Add(this.labelIVA);
			this.tabPageAgregarProductos.Controls.Add(this.labelSubtotal);
			this.tabPageAgregarProductos.Controls.Add(this.buttonGuardar);
			this.tabPageAgregarProductos.Controls.Add(this.labelTotal);
			this.tabPageAgregarProductos.Controls.Add(this.dataGridViewDetalleComanda);
			this.tabPageAgregarProductos.Controls.Add(this.labelIDProducto);
			this.tabPageAgregarProductos.Controls.Add(this.buttonBuscarProductos);
			this.tabPageAgregarProductos.Font = new System.Drawing.Font("Maiandra GD", 8F, System.Drawing.FontStyle.Bold);
			this.tabPageAgregarProductos.Location = new System.Drawing.Point(4, 37);
			this.tabPageAgregarProductos.Name = "tabPageAgregarProductos";
			this.tabPageAgregarProductos.Padding = new System.Windows.Forms.Padding(3);
			this.tabPageAgregarProductos.Size = new System.Drawing.Size(1344, 584);
			this.tabPageAgregarProductos.TabIndex = 1;
			this.tabPageAgregarProductos.Text = "Agregar Productos A La Comanda";
			this.tabPageAgregarProductos.UseVisualStyleBackColor = true;
			// 
			// textBoxTotal
			// 
			this.textBoxTotal.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
			this.textBoxTotal.Font = new System.Drawing.Font("Maiandra GD", 11F, System.Drawing.FontStyle.Bold);
			this.textBoxTotal.Location = new System.Drawing.Point(586, 528);
			this.textBoxTotal.Name = "textBoxTotal";
			this.textBoxTotal.ReadOnly = true;
			this.textBoxTotal.Size = new System.Drawing.Size(447, 25);
			this.textBoxTotal.TabIndex = 129;
			this.textBoxTotal.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
			// 
			// textBoxIVA
			// 
			this.textBoxIVA.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
			this.textBoxIVA.Font = new System.Drawing.Font("Maiandra GD", 11F, System.Drawing.FontStyle.Bold);
			this.textBoxIVA.Location = new System.Drawing.Point(137, 549);
			this.textBoxIVA.Name = "textBoxIVA";
			this.textBoxIVA.ReadOnly = true;
			this.textBoxIVA.Size = new System.Drawing.Size(334, 25);
			this.textBoxIVA.TabIndex = 128;
			this.textBoxIVA.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
			// 
			// textBoxSubTotal
			// 
			this.textBoxSubTotal.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
			this.textBoxSubTotal.Font = new System.Drawing.Font("Maiandra GD", 11F, System.Drawing.FontStyle.Bold);
			this.textBoxSubTotal.Location = new System.Drawing.Point(137, 512);
			this.textBoxSubTotal.Name = "textBoxSubTotal";
			this.textBoxSubTotal.ReadOnly = true;
			this.textBoxSubTotal.Size = new System.Drawing.Size(334, 25);
			this.textBoxSubTotal.TabIndex = 127;
			this.textBoxSubTotal.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
			// 
			// comboBoxProductos
			// 
			this.comboBoxProductos.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
			this.comboBoxProductos.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
			this.comboBoxProductos.Font = new System.Drawing.Font("Maiandra GD", 14.25F, System.Drawing.FontStyle.Bold);
			this.comboBoxProductos.FormattingEnabled = true;
			this.comboBoxProductos.Location = new System.Drawing.Point(264, 13);
			this.comboBoxProductos.Name = "comboBoxProductos";
			this.comboBoxProductos.Size = new System.Drawing.Size(769, 30);
			this.comboBoxProductos.TabIndex = 126;
			this.comboBoxProductos.KeyDown += new System.Windows.Forms.KeyEventHandler(this.ComboBoxProductosKeyDown);
			// 
			// labelIVA
			// 
			this.labelIVA.BackColor = System.Drawing.Color.Transparent;
			this.labelIVA.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
			this.labelIVA.Font = new System.Drawing.Font("Maiandra GD", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.labelIVA.ForeColor = System.Drawing.Color.White;
			this.labelIVA.Location = new System.Drawing.Point(8, 549);
			this.labelIVA.Name = "labelIVA";
			this.labelIVA.Size = new System.Drawing.Size(119, 25);
			this.labelIVA.TabIndex = 121;
			this.labelIVA.Text = "IVA:";
			this.labelIVA.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// labelSubtotal
			// 
			this.labelSubtotal.BackColor = System.Drawing.Color.Transparent;
			this.labelSubtotal.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
			this.labelSubtotal.Font = new System.Drawing.Font("Maiandra GD", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.labelSubtotal.ForeColor = System.Drawing.Color.White;
			this.labelSubtotal.Location = new System.Drawing.Point(8, 510);
			this.labelSubtotal.Name = "labelSubtotal";
			this.labelSubtotal.Size = new System.Drawing.Size(119, 25);
			this.labelSubtotal.TabIndex = 120;
			this.labelSubtotal.Text = "SUBTOTAL:";
			this.labelSubtotal.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// buttonGuardar
			// 
			this.buttonGuardar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
			this.buttonGuardar.BackColor = System.Drawing.Color.Transparent;
			this.buttonGuardar.Cursor = System.Windows.Forms.Cursors.Hand;
			this.buttonGuardar.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
			this.buttonGuardar.Font = new System.Drawing.Font("Maiandra GD", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.buttonGuardar.ForeColor = System.Drawing.Color.White;
			this.buttonGuardar.Location = new System.Drawing.Point(1054, 505);
			this.buttonGuardar.Name = "buttonGuardar";
			this.buttonGuardar.Size = new System.Drawing.Size(278, 69);
			this.buttonGuardar.TabIndex = 119;
			this.buttonGuardar.Text = "REGISTRAR COMANDA (MANDAR A COCINA)";
			this.buttonGuardar.UseVisualStyleBackColor = false;
			this.buttonGuardar.Click += new System.EventHandler(this.ButtonGuardarClick);
			// 
			// labelTotal
			// 
			this.labelTotal.BackColor = System.Drawing.Color.Transparent;
			this.labelTotal.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
			this.labelTotal.Font = new System.Drawing.Font("Maiandra GD", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.labelTotal.ForeColor = System.Drawing.Color.White;
			this.labelTotal.Location = new System.Drawing.Point(483, 528);
			this.labelTotal.Name = "labelTotal";
			this.labelTotal.Size = new System.Drawing.Size(97, 25);
			this.labelTotal.TabIndex = 117;
			this.labelTotal.Text = "TOTAL:";
			this.labelTotal.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// dataGridViewDetalleComanda
			// 
			this.dataGridViewDetalleComanda.AllowDrop = true;
			this.dataGridViewDetalleComanda.AllowUserToAddRows = false;
			this.dataGridViewDetalleComanda.AllowUserToOrderColumns = true;
			this.dataGridViewDetalleComanda.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
			| System.Windows.Forms.AnchorStyles.Right)));
			this.dataGridViewDetalleComanda.BackgroundColor = System.Drawing.Color.White;
			this.dataGridViewDetalleComanda.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
			dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
			dataGridViewCellStyle1.BackColor = System.Drawing.Color.White;
			dataGridViewCellStyle1.Font = new System.Drawing.Font("Maiandra GD", 8F, System.Drawing.FontStyle.Bold);
			dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
			dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
			dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
			dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
			this.dataGridViewDetalleComanda.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
			this.dataGridViewDetalleComanda.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dataGridViewDetalleComanda.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
			this.ID_PRODUCTO,
			this.NOMBRE_PRODUCTO,
			this.DESCRIPCION_PRODUCTO,
			this.PRECIO_UNITARIO,
			this.IMPORTE,
			this.RETIRAR});
			this.dataGridViewDetalleComanda.EditMode = System.Windows.Forms.DataGridViewEditMode.EditOnEnter;
			this.dataGridViewDetalleComanda.Enabled = false;
			this.dataGridViewDetalleComanda.Location = new System.Drawing.Point(8, 63);
			this.dataGridViewDetalleComanda.Name = "dataGridViewDetalleComanda";
			this.dataGridViewDetalleComanda.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Sunken;
			dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
			dataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Control;
			dataGridViewCellStyle4.Font = new System.Drawing.Font("Maiandra GD", 8F, System.Drawing.FontStyle.Bold);
			dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.WindowText;
			dataGridViewCellStyle4.Format = "N0";
			dataGridViewCellStyle4.NullValue = "-1";
			dataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight;
			dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
			dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
			this.dataGridViewDetalleComanda.RowHeadersDefaultCellStyle = dataGridViewCellStyle4;
			this.dataGridViewDetalleComanda.RowHeadersVisible = false;
			dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
			dataGridViewCellStyle5.Font = new System.Drawing.Font("Lucida Bright", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.dataGridViewDetalleComanda.RowsDefaultCellStyle = dataGridViewCellStyle5;
			this.dataGridViewDetalleComanda.RowTemplate.Height = 25;
			this.dataGridViewDetalleComanda.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.CellSelect;
			this.dataGridViewDetalleComanda.ShowEditingIcon = false;
			this.dataGridViewDetalleComanda.Size = new System.Drawing.Size(1326, 436);
			this.dataGridViewDetalleComanda.TabIndex = 115;
			this.dataGridViewDetalleComanda.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DataGridViewDetalleComandaCellContentClick);
			this.dataGridViewDetalleComanda.CellEndEdit += new System.Windows.Forms.DataGridViewCellEventHandler(this.DataGridViewDetalleComandaCellEndEdit);
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
			// DESCRIPCION_PRODUCTO
			// 
			this.DESCRIPCION_PRODUCTO.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
			this.DESCRIPCION_PRODUCTO.HeaderText = "DESCRIPCIÓN";
			this.DESCRIPCION_PRODUCTO.Name = "DESCRIPCION_PRODUCTO";
			this.DESCRIPCION_PRODUCTO.ReadOnly = true;
			// 
			// PRECIO_UNITARIO
			// 
			this.PRECIO_UNITARIO.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
			dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
			dataGridViewCellStyle2.Format = "N5";
			dataGridViewCellStyle2.NullValue = "0";
			this.PRECIO_UNITARIO.DefaultCellStyle = dataGridViewCellStyle2;
			this.PRECIO_UNITARIO.HeaderText = "PRECIO UNITARIO";
			this.PRECIO_UNITARIO.Name = "PRECIO_UNITARIO";
			this.PRECIO_UNITARIO.ReadOnly = true;
			// 
			// IMPORTE
			// 
			this.IMPORTE.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
			dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
			dataGridViewCellStyle3.Format = "N5";
			dataGridViewCellStyle3.NullValue = "0";
			this.IMPORTE.DefaultCellStyle = dataGridViewCellStyle3;
			this.IMPORTE.HeaderText = "IMPORTE";
			this.IMPORTE.Name = "IMPORTE";
			this.IMPORTE.ReadOnly = true;
			// 
			// RETIRAR
			// 
			this.RETIRAR.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader;
			this.RETIRAR.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
			this.RETIRAR.HeaderText = "RETIRAR";
			this.RETIRAR.Name = "RETIRAR";
			this.RETIRAR.ToolTipText = "PRESIONE DOS VECES PARA RETIRAR EL PRODUCTO";
			this.RETIRAR.Width = 64;
			// 
			// labelIDProducto
			// 
			this.labelIDProducto.BackColor = System.Drawing.Color.Transparent;
			this.labelIDProducto.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
			this.labelIDProducto.Font = new System.Drawing.Font("Maiandra GD", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.labelIDProducto.ForeColor = System.Drawing.Color.White;
			this.labelIDProducto.Location = new System.Drawing.Point(8, 13);
			this.labelIDProducto.Name = "labelIDProducto";
			this.labelIDProducto.Size = new System.Drawing.Size(250, 30);
			this.labelIDProducto.TabIndex = 105;
			this.labelIDProducto.Text = "NOMBRE DE PRODUCTO:";
			this.labelIDProducto.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// buttonBuscarProductos
			// 
			this.buttonBuscarProductos.BackColor = System.Drawing.Color.Transparent;
			this.buttonBuscarProductos.Cursor = System.Windows.Forms.Cursors.Hand;
			this.buttonBuscarProductos.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
			this.buttonBuscarProductos.Font = new System.Drawing.Font("Maiandra GD", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.buttonBuscarProductos.ForeColor = System.Drawing.Color.White;
			this.buttonBuscarProductos.Location = new System.Drawing.Point(1062, 13);
			this.buttonBuscarProductos.Name = "buttonBuscarProductos";
			this.buttonBuscarProductos.RightToLeft = System.Windows.Forms.RightToLeft.No;
			this.buttonBuscarProductos.Size = new System.Drawing.Size(270, 31);
			this.buttonBuscarProductos.TabIndex = 104;
			this.buttonBuscarProductos.Text = "BUSCAR PRODUCTOS";
			this.buttonBuscarProductos.UseVisualStyleBackColor = false;
			this.buttonBuscarProductos.Click += new System.EventHandler(this.ButtonBuscarProductosClick);
			// 
			// RegistrarComanda
			// 
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
			this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
			this.ClientSize = new System.Drawing.Size(1348, 727);
			this.Controls.Add(this.tabControlRegistrarComandas);
			this.Controls.Add(this.panelFondo);
			this.HelpButton = true;
			this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
			this.MinimumSize = new System.Drawing.Size(1364, 766);
			this.Name = "RegistrarComanda";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "SISTEMA MEMÍN® ";
			this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
			this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.RegistrarComandaFormClosing);
			this.panelFondo.ResumeLayout(false);
			this.tabControlRegistrarComandas.ResumeLayout(false);
			this.tabPageRegistrarComanda.ResumeLayout(false);
			this.tabPageRegistrarComanda.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.pictureBoxImagenEmpleado)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.numericUpDownNumeroMesa)).EndInit();
			this.tabPageAgregarProductos.ResumeLayout(false);
			this.tabPageAgregarProductos.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.dataGridViewDetalleComanda)).EndInit();
			this.ResumeLayout(false);

		}
	}
}
