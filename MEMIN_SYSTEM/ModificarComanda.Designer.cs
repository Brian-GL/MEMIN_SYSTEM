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
	partial class ModificarComanda
	{
		/// <summary>
		/// Designer variable used to keep track of non-visual components.
		/// </summary>
		private System.ComponentModel.IContainer components = null;
		private System.Windows.Forms.Label labelTitulo;
		private System.Windows.Forms.Panel panelFondo;
		private System.Windows.Forms.TabControl tabControlRegistrarComandas;
		private System.Windows.Forms.TabPage tabPageRegistrarComanda;
		private System.Windows.Forms.Label labelNumeroDeMesa;
		private System.Windows.Forms.MonthCalendar monthCalendarFechaCreacion;
		private System.Windows.Forms.Label labelFechaHoraModificacion;
		private System.Windows.Forms.Label labelFechaModificacion;
		private System.Windows.Forms.Label labelEstado;
		private System.Windows.Forms.TextBox textBoxNombreEmpleado;
		private System.Windows.Forms.Label labelNombreEmpleado;
		private System.Windows.Forms.TextBox textBoxNombreCliente;
		private System.Windows.Forms.Label labelNombreCliente;
		private System.Windows.Forms.TextBox textBoxIDMesero;
		private System.Windows.Forms.Label labelIDMesero;
		private System.Windows.Forms.Label labelID;
		private System.Windows.Forms.TabPage tabPageAgregarProductos;
		private System.Windows.Forms.Timer timerFechaHoraActual;
		private System.Windows.Forms.ComboBox comboBoxEstatus;
		private System.Windows.Forms.NumericUpDown numericUpDownIDComanda;
		private System.Windows.Forms.Button buttonVerificarIDCompra;
		private System.Windows.Forms.Button buttonModificarNombreCliente;
		private System.Windows.Forms.Button buttonModificarNumeroMesa;
		private System.Windows.Forms.Button buttonModificarEstatus;
		private System.Windows.Forms.Button buttonModificarComanda;
		private System.Windows.Forms.Button buttonModificarTodosLosCampos;
		private System.Windows.Forms.DataGridView dataGridViewDetalleComanda;
		private System.Windows.Forms.DataGridViewTextBoxColumn ID_PRODUCTO;
		private System.Windows.Forms.DataGridViewTextBoxColumn NOMBRE_PRODUCTO;
		private System.Windows.Forms.DataGridViewTextBoxColumn DESCRIPCION_PRODUCTO;
		private System.Windows.Forms.DataGridViewTextBoxColumn PRECIO_UNITARIO;
		private System.Windows.Forms.DataGridViewTextBoxColumn IMPORTE;
		private System.Windows.Forms.DataGridViewButtonColumn RETIRAR;
		private System.Windows.Forms.TextBox textBoxTotal;
		private System.Windows.Forms.TextBox textBoxIVA;
		private System.Windows.Forms.TextBox textBoxSubTotal;
		private System.Windows.Forms.Label labelIVA;
		private System.Windows.Forms.Label labelSubtotal;
		private System.Windows.Forms.Label labelTotal;
		private System.Windows.Forms.TextBox textBoxNumeroMesa;
		private System.Windows.Forms.Label labelFechaDeCreacion;
		private System.Windows.Forms.Label labelFechaCreacion;
		private System.Windows.Forms.Label labelImagenEmpleado;
		private System.Windows.Forms.PictureBox pictureBoxImagenEmpleado;
		
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ModificarComanda));
			System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
			System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
			System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
			System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
			System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
			this.panelFondo = new System.Windows.Forms.Panel();
			this.labelTitulo = new System.Windows.Forms.Label();
			this.tabControlRegistrarComandas = new System.Windows.Forms.TabControl();
			this.tabPageRegistrarComanda = new System.Windows.Forms.TabPage();
			this.labelImagenEmpleado = new System.Windows.Forms.Label();
			this.pictureBoxImagenEmpleado = new System.Windows.Forms.PictureBox();
			this.textBoxNumeroMesa = new System.Windows.Forms.TextBox();
			this.labelFechaDeCreacion = new System.Windows.Forms.Label();
			this.labelFechaCreacion = new System.Windows.Forms.Label();
			this.buttonModificarTodosLosCampos = new System.Windows.Forms.Button();
			this.buttonModificarComanda = new System.Windows.Forms.Button();
			this.buttonModificarNombreCliente = new System.Windows.Forms.Button();
			this.buttonModificarNumeroMesa = new System.Windows.Forms.Button();
			this.buttonModificarEstatus = new System.Windows.Forms.Button();
			this.numericUpDownIDComanda = new System.Windows.Forms.NumericUpDown();
			this.buttonVerificarIDCompra = new System.Windows.Forms.Button();
			this.comboBoxEstatus = new System.Windows.Forms.ComboBox();
			this.labelNumeroDeMesa = new System.Windows.Forms.Label();
			this.monthCalendarFechaCreacion = new System.Windows.Forms.MonthCalendar();
			this.labelFechaHoraModificacion = new System.Windows.Forms.Label();
			this.labelFechaModificacion = new System.Windows.Forms.Label();
			this.labelEstado = new System.Windows.Forms.Label();
			this.textBoxNombreEmpleado = new System.Windows.Forms.TextBox();
			this.labelNombreEmpleado = new System.Windows.Forms.Label();
			this.textBoxNombreCliente = new System.Windows.Forms.TextBox();
			this.labelNombreCliente = new System.Windows.Forms.Label();
			this.textBoxIDMesero = new System.Windows.Forms.TextBox();
			this.labelIDMesero = new System.Windows.Forms.Label();
			this.labelID = new System.Windows.Forms.Label();
			this.tabPageAgregarProductos = new System.Windows.Forms.TabPage();
			this.textBoxTotal = new System.Windows.Forms.TextBox();
			this.textBoxIVA = new System.Windows.Forms.TextBox();
			this.textBoxSubTotal = new System.Windows.Forms.TextBox();
			this.labelIVA = new System.Windows.Forms.Label();
			this.labelSubtotal = new System.Windows.Forms.Label();
			this.labelTotal = new System.Windows.Forms.Label();
			this.dataGridViewDetalleComanda = new System.Windows.Forms.DataGridView();
			this.ID_PRODUCTO = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.NOMBRE_PRODUCTO = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.DESCRIPCION_PRODUCTO = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.PRECIO_UNITARIO = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.IMPORTE = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.RETIRAR = new System.Windows.Forms.DataGridViewButtonColumn();
			this.timerFechaHoraActual = new System.Windows.Forms.Timer(this.components);
			this.panelFondo.SuspendLayout();
			this.tabControlRegistrarComandas.SuspendLayout();
			this.tabPageRegistrarComanda.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.pictureBoxImagenEmpleado)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.numericUpDownIDComanda)).BeginInit();
			this.tabPageAgregarProductos.SuspendLayout();
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
			this.panelFondo.TabIndex = 112;
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
			this.labelTitulo.Text = "MODIFICAR COMANDAS";
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
			this.tabControlRegistrarComandas.TabIndex = 113;
			// 
			// tabPageRegistrarComanda
			// 
			this.tabPageRegistrarComanda.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("tabPageRegistrarComanda.BackgroundImage")));
			this.tabPageRegistrarComanda.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
			this.tabPageRegistrarComanda.Controls.Add(this.labelImagenEmpleado);
			this.tabPageRegistrarComanda.Controls.Add(this.pictureBoxImagenEmpleado);
			this.tabPageRegistrarComanda.Controls.Add(this.textBoxNumeroMesa);
			this.tabPageRegistrarComanda.Controls.Add(this.labelFechaDeCreacion);
			this.tabPageRegistrarComanda.Controls.Add(this.labelFechaCreacion);
			this.tabPageRegistrarComanda.Controls.Add(this.buttonModificarTodosLosCampos);
			this.tabPageRegistrarComanda.Controls.Add(this.buttonModificarComanda);
			this.tabPageRegistrarComanda.Controls.Add(this.buttonModificarNombreCliente);
			this.tabPageRegistrarComanda.Controls.Add(this.buttonModificarNumeroMesa);
			this.tabPageRegistrarComanda.Controls.Add(this.buttonModificarEstatus);
			this.tabPageRegistrarComanda.Controls.Add(this.numericUpDownIDComanda);
			this.tabPageRegistrarComanda.Controls.Add(this.buttonVerificarIDCompra);
			this.tabPageRegistrarComanda.Controls.Add(this.comboBoxEstatus);
			this.tabPageRegistrarComanda.Controls.Add(this.labelNumeroDeMesa);
			this.tabPageRegistrarComanda.Controls.Add(this.monthCalendarFechaCreacion);
			this.tabPageRegistrarComanda.Controls.Add(this.labelFechaHoraModificacion);
			this.tabPageRegistrarComanda.Controls.Add(this.labelFechaModificacion);
			this.tabPageRegistrarComanda.Controls.Add(this.labelEstado);
			this.tabPageRegistrarComanda.Controls.Add(this.textBoxNombreEmpleado);
			this.tabPageRegistrarComanda.Controls.Add(this.labelNombreEmpleado);
			this.tabPageRegistrarComanda.Controls.Add(this.textBoxNombreCliente);
			this.tabPageRegistrarComanda.Controls.Add(this.labelNombreCliente);
			this.tabPageRegistrarComanda.Controls.Add(this.textBoxIDMesero);
			this.tabPageRegistrarComanda.Controls.Add(this.labelIDMesero);
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
			this.labelImagenEmpleado.Location = new System.Drawing.Point(1014, 18);
			this.labelImagenEmpleado.Name = "labelImagenEmpleado";
			this.labelImagenEmpleado.Size = new System.Drawing.Size(300, 36);
			this.labelImagenEmpleado.TabIndex = 149;
			this.labelImagenEmpleado.Text = "MESERO:";
			this.labelImagenEmpleado.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// pictureBoxImagenEmpleado
			// 
			this.pictureBoxImagenEmpleado.BackColor = System.Drawing.Color.Transparent;
			this.pictureBoxImagenEmpleado.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
			this.pictureBoxImagenEmpleado.Location = new System.Drawing.Point(1014, 72);
			this.pictureBoxImagenEmpleado.Name = "pictureBoxImagenEmpleado";
			this.pictureBoxImagenEmpleado.Size = new System.Drawing.Size(300, 300);
			this.pictureBoxImagenEmpleado.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
			this.pictureBoxImagenEmpleado.TabIndex = 148;
			this.pictureBoxImagenEmpleado.TabStop = false;
			// 
			// textBoxNumeroMesa
			// 
			this.textBoxNumeroMesa.Enabled = false;
			this.textBoxNumeroMesa.Font = new System.Drawing.Font("Maiandra GD", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.textBoxNumeroMesa.Location = new System.Drawing.Point(317, 306);
			this.textBoxNumeroMesa.Name = "textBoxNumeroMesa";
			this.textBoxNumeroMesa.ScrollBars = System.Windows.Forms.ScrollBars.Horizontal;
			this.textBoxNumeroMesa.Size = new System.Drawing.Size(522, 36);
			this.textBoxNumeroMesa.TabIndex = 147;
			this.textBoxNumeroMesa.TextChanged += new System.EventHandler(this.TextBoxNumeroMesaTextChanged);
			// 
			// labelFechaDeCreacion
			// 
			this.labelFechaDeCreacion.BackColor = System.Drawing.Color.Transparent;
			this.labelFechaDeCreacion.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
			this.labelFechaDeCreacion.Font = new System.Drawing.Font("Maiandra GD", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.labelFechaDeCreacion.ForeColor = System.Drawing.Color.White;
			this.labelFechaDeCreacion.Location = new System.Drawing.Point(317, 210);
			this.labelFechaDeCreacion.Name = "labelFechaDeCreacion";
			this.labelFechaDeCreacion.Size = new System.Drawing.Size(522, 32);
			this.labelFechaDeCreacion.TabIndex = 146;
			this.labelFechaDeCreacion.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// labelFechaCreacion
			// 
			this.labelFechaCreacion.BackColor = System.Drawing.Color.Transparent;
			this.labelFechaCreacion.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
			this.labelFechaCreacion.Font = new System.Drawing.Font("Maiandra GD", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.labelFechaCreacion.ForeColor = System.Drawing.Color.White;
			this.labelFechaCreacion.Location = new System.Drawing.Point(6, 209);
			this.labelFechaCreacion.Name = "labelFechaCreacion";
			this.labelFechaCreacion.Size = new System.Drawing.Size(296, 36);
			this.labelFechaCreacion.TabIndex = 145;
			this.labelFechaCreacion.Text = "FECHA DE CREACIÓN:";
			this.labelFechaCreacion.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// buttonModificarTodosLosCampos
			// 
			this.buttonModificarTodosLosCampos.BackColor = System.Drawing.Color.Transparent;
			this.buttonModificarTodosLosCampos.Cursor = System.Windows.Forms.Cursors.Hand;
			this.buttonModificarTodosLosCampos.Enabled = false;
			this.buttonModificarTodosLosCampos.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
			this.buttonModificarTodosLosCampos.Font = new System.Drawing.Font("Maiandra GD", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.buttonModificarTodosLosCampos.ForeColor = System.Drawing.Color.White;
			this.buttonModificarTodosLosCampos.Location = new System.Drawing.Point(6, 528);
			this.buttonModificarTodosLosCampos.Name = "buttonModificarTodosLosCampos";
			this.buttonModificarTodosLosCampos.Size = new System.Drawing.Size(653, 46);
			this.buttonModificarTodosLosCampos.TabIndex = 144;
			this.buttonModificarTodosLosCampos.Text = "¿MODIFICAR TODOS LOS CAMPOS?";
			this.buttonModificarTodosLosCampos.UseVisualStyleBackColor = false;
			this.buttonModificarTodosLosCampos.Click += new System.EventHandler(this.ButtonModificarTodosLosCamposClick);
			// 
			// buttonModificarComanda
			// 
			this.buttonModificarComanda.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
			this.buttonModificarComanda.BackColor = System.Drawing.Color.Transparent;
			this.buttonModificarComanda.Cursor = System.Windows.Forms.Cursors.Hand;
			this.buttonModificarComanda.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
			this.buttonModificarComanda.Font = new System.Drawing.Font("Maiandra GD", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.buttonModificarComanda.ForeColor = System.Drawing.Color.White;
			this.buttonModificarComanda.Location = new System.Drawing.Point(995, 528);
			this.buttonModificarComanda.Name = "buttonModificarComanda";
			this.buttonModificarComanda.Size = new System.Drawing.Size(335, 46);
			this.buttonModificarComanda.TabIndex = 142;
			this.buttonModificarComanda.Text = "MODIFICAR COMANDA";
			this.buttonModificarComanda.UseVisualStyleBackColor = false;
			this.buttonModificarComanda.Click += new System.EventHandler(this.ButtonModificarComandaClick);
			// 
			// buttonModificarNombreCliente
			// 
			this.buttonModificarNombreCliente.BackColor = System.Drawing.Color.Transparent;
			this.buttonModificarNombreCliente.Cursor = System.Windows.Forms.Cursors.Hand;
			this.buttonModificarNombreCliente.Enabled = false;
			this.buttonModificarNombreCliente.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
			this.buttonModificarNombreCliente.Font = new System.Drawing.Font("Maiandra GD", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.buttonModificarNombreCliente.ForeColor = System.Drawing.Color.White;
			this.buttonModificarNombreCliente.Location = new System.Drawing.Point(845, 159);
			this.buttonModificarNombreCliente.Name = "buttonModificarNombreCliente";
			this.buttonModificarNombreCliente.Size = new System.Drawing.Size(142, 36);
			this.buttonModificarNombreCliente.TabIndex = 141;
			this.buttonModificarNombreCliente.Text = "¿MODIFICAR?";
			this.buttonModificarNombreCliente.UseVisualStyleBackColor = false;
			this.buttonModificarNombreCliente.Click += new System.EventHandler(this.ButtonModificarNombreClienteClick);
			// 
			// buttonModificarNumeroMesa
			// 
			this.buttonModificarNumeroMesa.BackColor = System.Drawing.Color.Transparent;
			this.buttonModificarNumeroMesa.Cursor = System.Windows.Forms.Cursors.Hand;
			this.buttonModificarNumeroMesa.Enabled = false;
			this.buttonModificarNumeroMesa.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
			this.buttonModificarNumeroMesa.Font = new System.Drawing.Font("Maiandra GD", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.buttonModificarNumeroMesa.ForeColor = System.Drawing.Color.White;
			this.buttonModificarNumeroMesa.Location = new System.Drawing.Point(845, 306);
			this.buttonModificarNumeroMesa.Name = "buttonModificarNumeroMesa";
			this.buttonModificarNumeroMesa.Size = new System.Drawing.Size(142, 36);
			this.buttonModificarNumeroMesa.TabIndex = 140;
			this.buttonModificarNumeroMesa.Text = "¿MODIFICAR?";
			this.buttonModificarNumeroMesa.UseVisualStyleBackColor = false;
			this.buttonModificarNumeroMesa.Click += new System.EventHandler(this.ButtonModificarNumeroMesaClick);
			// 
			// buttonModificarEstatus
			// 
			this.buttonModificarEstatus.BackColor = System.Drawing.Color.Transparent;
			this.buttonModificarEstatus.Cursor = System.Windows.Forms.Cursors.Hand;
			this.buttonModificarEstatus.Enabled = false;
			this.buttonModificarEstatus.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
			this.buttonModificarEstatus.Font = new System.Drawing.Font("Maiandra GD", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.buttonModificarEstatus.ForeColor = System.Drawing.Color.White;
			this.buttonModificarEstatus.Location = new System.Drawing.Point(845, 358);
			this.buttonModificarEstatus.Name = "buttonModificarEstatus";
			this.buttonModificarEstatus.Size = new System.Drawing.Size(142, 36);
			this.buttonModificarEstatus.TabIndex = 139;
			this.buttonModificarEstatus.Text = "¿MODIFICAR?";
			this.buttonModificarEstatus.UseVisualStyleBackColor = false;
			this.buttonModificarEstatus.Click += new System.EventHandler(this.ButtonModificarEstatusClick);
			// 
			// numericUpDownIDComanda
			// 
			this.numericUpDownIDComanda.Font = new System.Drawing.Font("Lucida Bright", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.numericUpDownIDComanda.Location = new System.Drawing.Point(317, 9);
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
			this.numericUpDownIDComanda.Size = new System.Drawing.Size(323, 36);
			this.numericUpDownIDComanda.TabIndex = 138;
			this.numericUpDownIDComanda.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
			this.numericUpDownIDComanda.Value = new decimal(new int[] {
			1,
			0,
			0,
			0});
			// 
			// buttonVerificarIDCompra
			// 
			this.buttonVerificarIDCompra.BackColor = System.Drawing.Color.Transparent;
			this.buttonVerificarIDCompra.Cursor = System.Windows.Forms.Cursors.Hand;
			this.buttonVerificarIDCompra.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
			this.buttonVerificarIDCompra.Font = new System.Drawing.Font("Maiandra GD", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.buttonVerificarIDCompra.ForeColor = System.Drawing.Color.White;
			this.buttonVerificarIDCompra.Location = new System.Drawing.Point(655, 9);
			this.buttonVerificarIDCompra.Name = "buttonVerificarIDCompra";
			this.buttonVerificarIDCompra.RightToLeft = System.Windows.Forms.RightToLeft.No;
			this.buttonVerificarIDCompra.Size = new System.Drawing.Size(184, 36);
			this.buttonVerificarIDCompra.TabIndex = 137;
			this.buttonVerificarIDCompra.Text = "VERIFICAR ID";
			this.buttonVerificarIDCompra.UseVisualStyleBackColor = false;
			this.buttonVerificarIDCompra.Click += new System.EventHandler(this.ButtonVerificarIDCompraClick);
			// 
			// comboBoxEstatus
			// 
			this.comboBoxEstatus.Enabled = false;
			this.comboBoxEstatus.Font = new System.Drawing.Font("Maiandra GD", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.comboBoxEstatus.FormattingEnabled = true;
			this.comboBoxEstatus.Location = new System.Drawing.Point(317, 358);
			this.comboBoxEstatus.Name = "comboBoxEstatus";
			this.comboBoxEstatus.Size = new System.Drawing.Size(522, 37);
			this.comboBoxEstatus.TabIndex = 136;
			// 
			// labelNumeroDeMesa
			// 
			this.labelNumeroDeMesa.BackColor = System.Drawing.Color.Transparent;
			this.labelNumeroDeMesa.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
			this.labelNumeroDeMesa.Font = new System.Drawing.Font("Maiandra GD", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.labelNumeroDeMesa.ForeColor = System.Drawing.Color.White;
			this.labelNumeroDeMesa.Location = new System.Drawing.Point(6, 304);
			this.labelNumeroDeMesa.Name = "labelNumeroDeMesa";
			this.labelNumeroDeMesa.Size = new System.Drawing.Size(296, 36);
			this.labelNumeroDeMesa.TabIndex = 110;
			this.labelNumeroDeMesa.Text = "NÚMERO DE MESA:";
			this.labelNumeroDeMesa.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// monthCalendarFechaCreacion
			// 
			this.monthCalendarFechaCreacion.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
			this.monthCalendarFechaCreacion.Font = new System.Drawing.Font("Maiandra GD", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.monthCalendarFechaCreacion.Location = new System.Drawing.Point(717, 412);
			this.monthCalendarFechaCreacion.MaxDate = new System.DateTime(2100, 1, 1, 0, 0, 0, 0);
			this.monthCalendarFechaCreacion.MinDate = new System.DateTime(2019, 11, 5, 0, 0, 0, 0);
			this.monthCalendarFechaCreacion.Name = "monthCalendarFechaCreacion";
			this.monthCalendarFechaCreacion.ShowWeekNumbers = true;
			this.monthCalendarFechaCreacion.TabIndex = 109;
			// 
			// labelFechaHoraModificacion
			// 
			this.labelFechaHoraModificacion.BackColor = System.Drawing.Color.Transparent;
			this.labelFechaHoraModificacion.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
			this.labelFechaHoraModificacion.Font = new System.Drawing.Font("Maiandra GD", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.labelFechaHoraModificacion.ForeColor = System.Drawing.Color.White;
			this.labelFechaHoraModificacion.Location = new System.Drawing.Point(317, 258);
			this.labelFechaHoraModificacion.Name = "labelFechaHoraModificacion";
			this.labelFechaHoraModificacion.Size = new System.Drawing.Size(522, 32);
			this.labelFechaHoraModificacion.TabIndex = 108;
			this.labelFechaHoraModificacion.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// labelFechaModificacion
			// 
			this.labelFechaModificacion.BackColor = System.Drawing.Color.Transparent;
			this.labelFechaModificacion.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
			this.labelFechaModificacion.Font = new System.Drawing.Font("Maiandra GD", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.labelFechaModificacion.ForeColor = System.Drawing.Color.White;
			this.labelFechaModificacion.Location = new System.Drawing.Point(6, 257);
			this.labelFechaModificacion.Name = "labelFechaModificacion";
			this.labelFechaModificacion.Size = new System.Drawing.Size(296, 36);
			this.labelFechaModificacion.TabIndex = 107;
			this.labelFechaModificacion.Text = "FECHA DE MODIFICACIÓN:";
			this.labelFechaModificacion.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// labelEstado
			// 
			this.labelEstado.BackColor = System.Drawing.Color.Transparent;
			this.labelEstado.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
			this.labelEstado.Font = new System.Drawing.Font("Maiandra GD", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.labelEstado.ForeColor = System.Drawing.Color.White;
			this.labelEstado.Location = new System.Drawing.Point(6, 358);
			this.labelEstado.Name = "labelEstado";
			this.labelEstado.Size = new System.Drawing.Size(296, 36);
			this.labelEstado.TabIndex = 105;
			this.labelEstado.Text = "ESTATUS:";
			this.labelEstado.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// textBoxNombreEmpleado
			// 
			this.textBoxNombreEmpleado.Enabled = false;
			this.textBoxNombreEmpleado.Font = new System.Drawing.Font("Maiandra GD", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.textBoxNombreEmpleado.Location = new System.Drawing.Point(317, 111);
			this.textBoxNombreEmpleado.Name = "textBoxNombreEmpleado";
			this.textBoxNombreEmpleado.ReadOnly = true;
			this.textBoxNombreEmpleado.ScrollBars = System.Windows.Forms.ScrollBars.Horizontal;
			this.textBoxNombreEmpleado.Size = new System.Drawing.Size(522, 36);
			this.textBoxNombreEmpleado.TabIndex = 102;
			// 
			// labelNombreEmpleado
			// 
			this.labelNombreEmpleado.BackColor = System.Drawing.Color.Transparent;
			this.labelNombreEmpleado.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
			this.labelNombreEmpleado.Font = new System.Drawing.Font("Maiandra GD", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.labelNombreEmpleado.ForeColor = System.Drawing.Color.White;
			this.labelNombreEmpleado.Location = new System.Drawing.Point(6, 110);
			this.labelNombreEmpleado.Name = "labelNombreEmpleado";
			this.labelNombreEmpleado.Size = new System.Drawing.Size(296, 36);
			this.labelNombreEmpleado.TabIndex = 101;
			this.labelNombreEmpleado.Text = "NOMBRE DEL MESERO:";
			this.labelNombreEmpleado.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// textBoxNombreCliente
			// 
			this.textBoxNombreCliente.Enabled = false;
			this.textBoxNombreCliente.Font = new System.Drawing.Font("Maiandra GD", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.textBoxNombreCliente.Location = new System.Drawing.Point(317, 159);
			this.textBoxNombreCliente.Name = "textBoxNombreCliente";
			this.textBoxNombreCliente.ScrollBars = System.Windows.Forms.ScrollBars.Horizontal;
			this.textBoxNombreCliente.Size = new System.Drawing.Size(522, 36);
			this.textBoxNombreCliente.TabIndex = 100;
			// 
			// labelNombreCliente
			// 
			this.labelNombreCliente.BackColor = System.Drawing.Color.Transparent;
			this.labelNombreCliente.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
			this.labelNombreCliente.Font = new System.Drawing.Font("Maiandra GD", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.labelNombreCliente.ForeColor = System.Drawing.Color.White;
			this.labelNombreCliente.Location = new System.Drawing.Point(6, 158);
			this.labelNombreCliente.Name = "labelNombreCliente";
			this.labelNombreCliente.Size = new System.Drawing.Size(296, 36);
			this.labelNombreCliente.TabIndex = 99;
			this.labelNombreCliente.Text = "NOMBRE DEL CLIENTE:";
			this.labelNombreCliente.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// textBoxIDMesero
			// 
			this.textBoxIDMesero.Enabled = false;
			this.textBoxIDMesero.Font = new System.Drawing.Font("Maiandra GD", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.textBoxIDMesero.Location = new System.Drawing.Point(317, 60);
			this.textBoxIDMesero.Name = "textBoxIDMesero";
			this.textBoxIDMesero.ReadOnly = true;
			this.textBoxIDMesero.ScrollBars = System.Windows.Forms.ScrollBars.Horizontal;
			this.textBoxIDMesero.Size = new System.Drawing.Size(522, 36);
			this.textBoxIDMesero.TabIndex = 98;
			// 
			// labelIDMesero
			// 
			this.labelIDMesero.BackColor = System.Drawing.Color.Transparent;
			this.labelIDMesero.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
			this.labelIDMesero.Font = new System.Drawing.Font("Maiandra GD", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.labelIDMesero.ForeColor = System.Drawing.Color.White;
			this.labelIDMesero.Location = new System.Drawing.Point(6, 59);
			this.labelIDMesero.Name = "labelIDMesero";
			this.labelIDMesero.Size = new System.Drawing.Size(296, 36);
			this.labelIDMesero.TabIndex = 97;
			this.labelIDMesero.Text = "ID DEL MESERO:";
			this.labelIDMesero.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// labelID
			// 
			this.labelID.BackColor = System.Drawing.Color.Transparent;
			this.labelID.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
			this.labelID.Font = new System.Drawing.Font("Maiandra GD", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.labelID.ForeColor = System.Drawing.Color.White;
			this.labelID.Location = new System.Drawing.Point(6, 9);
			this.labelID.Name = "labelID";
			this.labelID.Size = new System.Drawing.Size(296, 36);
			this.labelID.TabIndex = 95;
			this.labelID.Text = "ID DE LA COMANDA:";
			this.labelID.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// tabPageAgregarProductos
			// 
			this.tabPageAgregarProductos.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("tabPageAgregarProductos.BackgroundImage")));
			this.tabPageAgregarProductos.Controls.Add(this.textBoxTotal);
			this.tabPageAgregarProductos.Controls.Add(this.textBoxIVA);
			this.tabPageAgregarProductos.Controls.Add(this.textBoxSubTotal);
			this.tabPageAgregarProductos.Controls.Add(this.labelIVA);
			this.tabPageAgregarProductos.Controls.Add(this.labelSubtotal);
			this.tabPageAgregarProductos.Controls.Add(this.labelTotal);
			this.tabPageAgregarProductos.Controls.Add(this.dataGridViewDetalleComanda);
			this.tabPageAgregarProductos.Font = new System.Drawing.Font("Maiandra GD", 9.75F);
			this.tabPageAgregarProductos.Location = new System.Drawing.Point(4, 37);
			this.tabPageAgregarProductos.Name = "tabPageAgregarProductos";
			this.tabPageAgregarProductos.Padding = new System.Windows.Forms.Padding(3);
			this.tabPageAgregarProductos.Size = new System.Drawing.Size(1344, 584);
			this.tabPageAgregarProductos.TabIndex = 1;
			this.tabPageAgregarProductos.Text = "Modificar Productos De La Comanda";
			this.tabPageAgregarProductos.UseVisualStyleBackColor = true;
			// 
			// textBoxTotal
			// 
			this.textBoxTotal.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
			this.textBoxTotal.Font = new System.Drawing.Font("Maiandra GD", 11F, System.Drawing.FontStyle.Bold);
			this.textBoxTotal.Location = new System.Drawing.Point(663, 526);
			this.textBoxTotal.Name = "textBoxTotal";
			this.textBoxTotal.ReadOnly = true;
			this.textBoxTotal.Size = new System.Drawing.Size(669, 25);
			this.textBoxTotal.TabIndex = 138;
			this.textBoxTotal.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
			// 
			// textBoxIVA
			// 
			this.textBoxIVA.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
			this.textBoxIVA.Font = new System.Drawing.Font("Maiandra GD", 11F, System.Drawing.FontStyle.Bold);
			this.textBoxIVA.Location = new System.Drawing.Point(137, 547);
			this.textBoxIVA.Name = "textBoxIVA";
			this.textBoxIVA.ReadOnly = true;
			this.textBoxIVA.Size = new System.Drawing.Size(402, 25);
			this.textBoxIVA.TabIndex = 137;
			this.textBoxIVA.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
			// 
			// textBoxSubTotal
			// 
			this.textBoxSubTotal.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
			this.textBoxSubTotal.Font = new System.Drawing.Font("Maiandra GD", 11F, System.Drawing.FontStyle.Bold);
			this.textBoxSubTotal.Location = new System.Drawing.Point(137, 510);
			this.textBoxSubTotal.Name = "textBoxSubTotal";
			this.textBoxSubTotal.ReadOnly = true;
			this.textBoxSubTotal.Size = new System.Drawing.Size(402, 25);
			this.textBoxSubTotal.TabIndex = 136;
			this.textBoxSubTotal.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
			// 
			// labelIVA
			// 
			this.labelIVA.BackColor = System.Drawing.Color.Transparent;
			this.labelIVA.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
			this.labelIVA.Font = new System.Drawing.Font("Maiandra GD", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.labelIVA.ForeColor = System.Drawing.Color.White;
			this.labelIVA.Location = new System.Drawing.Point(8, 547);
			this.labelIVA.Name = "labelIVA";
			this.labelIVA.Size = new System.Drawing.Size(119, 25);
			this.labelIVA.TabIndex = 135;
			this.labelIVA.Text = "IVA:";
			this.labelIVA.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// labelSubtotal
			// 
			this.labelSubtotal.BackColor = System.Drawing.Color.Transparent;
			this.labelSubtotal.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
			this.labelSubtotal.Font = new System.Drawing.Font("Maiandra GD", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.labelSubtotal.ForeColor = System.Drawing.Color.White;
			this.labelSubtotal.Location = new System.Drawing.Point(8, 508);
			this.labelSubtotal.Name = "labelSubtotal";
			this.labelSubtotal.Size = new System.Drawing.Size(119, 25);
			this.labelSubtotal.TabIndex = 134;
			this.labelSubtotal.Text = "SUBTOTAL:";
			this.labelSubtotal.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// labelTotal
			// 
			this.labelTotal.BackColor = System.Drawing.Color.Transparent;
			this.labelTotal.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
			this.labelTotal.Font = new System.Drawing.Font("Maiandra GD", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.labelTotal.ForeColor = System.Drawing.Color.White;
			this.labelTotal.Location = new System.Drawing.Point(560, 526);
			this.labelTotal.Name = "labelTotal";
			this.labelTotal.Size = new System.Drawing.Size(97, 25);
			this.labelTotal.TabIndex = 133;
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
			dataGridViewCellStyle1.Font = new System.Drawing.Font("Maiandra GD", 9.75F);
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
			this.dataGridViewDetalleComanda.Location = new System.Drawing.Point(8, 6);
			this.dataGridViewDetalleComanda.Name = "dataGridViewDetalleComanda";
			this.dataGridViewDetalleComanda.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Sunken;
			dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
			dataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Control;
			dataGridViewCellStyle4.Font = new System.Drawing.Font("Maiandra GD", 9.75F);
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
			this.dataGridViewDetalleComanda.Size = new System.Drawing.Size(1326, 487);
			this.dataGridViewDetalleComanda.TabIndex = 132;
			this.dataGridViewDetalleComanda.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DataGridViewDetalleComandaCellContentClick);
			this.dataGridViewDetalleComanda.CellEndEdit += new System.Windows.Forms.DataGridViewCellEventHandler(this.DataGridViewDetalleComandaCellEndEdit);
			// 
			// ID_PRODUCTO
			// 
			this.ID_PRODUCTO.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader;
			this.ID_PRODUCTO.HeaderText = "ID PRODUCTO";
			this.ID_PRODUCTO.Name = "ID_PRODUCTO";
			this.ID_PRODUCTO.ReadOnly = true;
			this.ID_PRODUCTO.Width = 113;
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
			this.RETIRAR.Width = 66;
			// 
			// timerFechaHoraActual
			// 
			this.timerFechaHoraActual.Enabled = true;
			this.timerFechaHoraActual.Tick += new System.EventHandler(this.TimerFechaHoraActualTick);
			// 
			// ModificarComanda
			// 
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
			this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
			this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
			this.ClientSize = new System.Drawing.Size(1348, 727);
			this.Controls.Add(this.tabControlRegistrarComandas);
			this.Controls.Add(this.panelFondo);
			this.DoubleBuffered = true;
			this.HelpButton = true;
			this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
			this.MinimumSize = new System.Drawing.Size(1364, 766);
			this.Name = "ModificarComanda";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "SISTEMA MEMÍN® ";
			this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
			this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.ModificarComandaFormClosing);
			this.panelFondo.ResumeLayout(false);
			this.tabControlRegistrarComandas.ResumeLayout(false);
			this.tabPageRegistrarComanda.ResumeLayout(false);
			this.tabPageRegistrarComanda.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.pictureBoxImagenEmpleado)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.numericUpDownIDComanda)).EndInit();
			this.tabPageAgregarProductos.ResumeLayout(false);
			this.tabPageAgregarProductos.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.dataGridViewDetalleComanda)).EndInit();
			this.ResumeLayout(false);

		}
	}
}
