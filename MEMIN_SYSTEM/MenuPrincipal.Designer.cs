/*
 * Creado por SharpDevelop.
 * Usuario: Brian Gaytan Lomeli
 * Fecha: 21/10/2019
 * Hora: 7:58
 * 
 * Para cambiar esta plantilla use Herramientas | Opciones | Codificación | Editar Encabezados Estándar
 */
namespace MEMIN_SYSTEM
{
	partial class MenuPrincipal
	{
		/// <summary>
		/// Designer variable used to keep track of non-visual components.
		/// </summary>
		private System.ComponentModel.IContainer components = null;
		private System.Windows.Forms.Panel panelFondo;
		private System.Windows.Forms.Label labelTitulo;
		private System.Windows.Forms.MenuStrip menuStripMenus;
		private System.Windows.Forms.ToolStripMenuItem comandasToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem agregarNuevaComandaToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem consultarComandasToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem modificarComandasToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem cajaToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem productosToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem empleadosToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem consultarComandasPorMeseroToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem consultarComandasPorCocineroToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem generarVentaToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem registrarProductosToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem consultarProductosToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem registrarEmpleadosToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem consultarEmpleadosToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem modificarEmpleadosToolStripMenuItem;
		private System.Windows.Forms.Label labelRegresar;
		private System.Windows.Forms.ToolStripMenuItem consultarTodosLosProductosToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem consultarProductosPorTipoToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem consultarProductosPorDisponibilidadToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem modificarProductosToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem consultarComandasDeCajeroDelDiaToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem consultarEmpleadosPorPuestoToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem cocinaToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem asignarmeAUnaComandaToolStripMenuItem;
		private System.Windows.Forms.Label labelIdUSUARIO;
		private System.Windows.Forms.PictureBox pictureBoxImagenEmpleado;
		private System.Windows.Forms.ToolTip toolTipUser;
		private System.Windows.Forms.ToolTip toolTipImagenEmpleado;
		private System.Windows.Forms.ToolTip toolTipCerrarSesion;
		private System.Windows.Forms.ToolStripMenuItem consultarTodosLosEmpleadosToolStripMenuItem;
		private System.Windows.Forms.Label labelBienvenida;
		private System.Windows.Forms.ToolStripMenuItem buscarToolStripMenuItem;
		private System.Windows.Forms.DataGridView dataGridViewNotificaciones;
		private System.Windows.Forms.DataGridViewTextBoxColumn NOTIFICACION;
		private System.Windows.Forms.DataGridViewButtonColumn LEIDO;
		private System.Windows.Forms.DataGridViewTextBoxColumn FECHA;
		private System.Windows.Forms.ToolStripMenuItem comandasQueTengoAsignadasToolStripMenuItem;
		
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
			System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
			System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
			System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
			System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MenuPrincipal));
			this.panelFondo = new System.Windows.Forms.Panel();
			this.labelIdUSUARIO = new System.Windows.Forms.Label();
			this.menuStripMenus = new System.Windows.Forms.MenuStrip();
			this.comandasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.agregarNuevaComandaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.consultarComandasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.consultarComandasPorMeseroToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.consultarComandasPorCocineroToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.modificarComandasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.cajaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.generarVentaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.consultarComandasDeCajeroDelDiaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.productosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.registrarProductosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.consultarProductosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.consultarTodosLosProductosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.consultarProductosPorTipoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.consultarProductosPorDisponibilidadToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.modificarProductosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.empleadosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.registrarEmpleadosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.consultarEmpleadosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.consultarEmpleadosPorPuestoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.consultarTodosLosEmpleadosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.modificarEmpleadosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.cocinaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.asignarmeAUnaComandaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.buscarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.labelTitulo = new System.Windows.Forms.Label();
			this.labelRegresar = new System.Windows.Forms.Label();
			this.pictureBoxImagenEmpleado = new System.Windows.Forms.PictureBox();
			this.toolTipUser = new System.Windows.Forms.ToolTip(this.components);
			this.toolTipImagenEmpleado = new System.Windows.Forms.ToolTip(this.components);
			this.toolTipCerrarSesion = new System.Windows.Forms.ToolTip(this.components);
			this.labelBienvenida = new System.Windows.Forms.Label();
			this.dataGridViewNotificaciones = new System.Windows.Forms.DataGridView();
			this.NOTIFICACION = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.FECHA = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.LEIDO = new System.Windows.Forms.DataGridViewButtonColumn();
			this.comandasQueTengoAsignadasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.panelFondo.SuspendLayout();
			this.menuStripMenus.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.pictureBoxImagenEmpleado)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.dataGridViewNotificaciones)).BeginInit();
			this.SuspendLayout();
			// 
			// panelFondo
			// 
			this.panelFondo.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
			| System.Windows.Forms.AnchorStyles.Left) 
			| System.Windows.Forms.AnchorStyles.Right)));
			this.panelFondo.BackColor = System.Drawing.Color.OrangeRed;
			this.panelFondo.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
			this.panelFondo.Controls.Add(this.labelIdUSUARIO);
			this.panelFondo.Controls.Add(this.menuStripMenus);
			this.panelFondo.Controls.Add(this.labelTitulo);
			this.panelFondo.Location = new System.Drawing.Point(0, 0);
			this.panelFondo.Name = "panelFondo";
			this.panelFondo.Size = new System.Drawing.Size(1364, 150);
			this.panelFondo.TabIndex = 1;
			// 
			// labelIdUSUARIO
			// 
			this.labelIdUSUARIO.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
			| System.Windows.Forms.AnchorStyles.Left) 
			| System.Windows.Forms.AnchorStyles.Right)));
			this.labelIdUSUARIO.BackColor = System.Drawing.Color.Transparent;
			this.labelIdUSUARIO.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
			this.labelIdUSUARIO.Font = new System.Drawing.Font("Maiandra GD", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.labelIdUSUARIO.ForeColor = System.Drawing.Color.White;
			this.labelIdUSUARIO.Location = new System.Drawing.Point(10, 10);
			this.labelIdUSUARIO.Name = "labelIdUSUARIO";
			this.labelIdUSUARIO.Size = new System.Drawing.Size(341, 74);
			this.labelIdUSUARIO.TabIndex = 4;
			this.labelIdUSUARIO.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// menuStripMenus
			// 
			this.menuStripMenus.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
			this.menuStripMenus.BackColor = System.Drawing.Color.Transparent;
			this.menuStripMenus.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
			this.menuStripMenus.Dock = System.Windows.Forms.DockStyle.None;
			this.menuStripMenus.Font = new System.Drawing.Font("Maiandra GD", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.menuStripMenus.GripMargin = new System.Windows.Forms.Padding(0);
			this.menuStripMenus.GripStyle = System.Windows.Forms.ToolStripGripStyle.Visible;
			this.menuStripMenus.ImageScalingSize = new System.Drawing.Size(32, 32);
			this.menuStripMenus.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
			this.comandasToolStripMenuItem,
			this.cajaToolStripMenuItem,
			this.productosToolStripMenuItem,
			this.empleadosToolStripMenuItem,
			this.cocinaToolStripMenuItem,
			this.buscarToolStripMenuItem});
			this.menuStripMenus.LayoutStyle = System.Windows.Forms.ToolStripLayoutStyle.HorizontalStackWithOverflow;
			this.menuStripMenus.Location = new System.Drawing.Point(296, 116);
			this.menuStripMenus.Name = "menuStripMenus";
			this.menuStripMenus.RightToLeft = System.Windows.Forms.RightToLeft.No;
			this.menuStripMenus.ShowItemToolTips = true;
			this.menuStripMenus.Size = new System.Drawing.Size(660, 32);
			this.menuStripMenus.TabIndex = 2;
			// 
			// comandasToolStripMenuItem
			// 
			this.comandasToolStripMenuItem.AutoToolTip = true;
			this.comandasToolStripMenuItem.BackColor = System.Drawing.Color.Transparent;
			this.comandasToolStripMenuItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
			this.comandasToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
			this.agregarNuevaComandaToolStripMenuItem,
			this.consultarComandasToolStripMenuItem,
			this.modificarComandasToolStripMenuItem});
			this.comandasToolStripMenuItem.Font = new System.Drawing.Font("Maiandra GD", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.comandasToolStripMenuItem.ForeColor = System.Drawing.Color.White;
			this.comandasToolStripMenuItem.Name = "comandasToolStripMenuItem";
			this.comandasToolStripMenuItem.RightToLeftAutoMirrorImage = true;
			this.comandasToolStripMenuItem.Size = new System.Drawing.Size(114, 28);
			this.comandasToolStripMenuItem.Text = "Comandas";
			this.comandasToolStripMenuItem.TextDirection = System.Windows.Forms.ToolStripTextDirection.Horizontal;
			this.comandasToolStripMenuItem.ToolTipText = "Menú De Comandas";
			// 
			// agregarNuevaComandaToolStripMenuItem
			// 
			this.agregarNuevaComandaToolStripMenuItem.Font = new System.Drawing.Font("Maiandra GD", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.agregarNuevaComandaToolStripMenuItem.Name = "agregarNuevaComandaToolStripMenuItem";
			this.agregarNuevaComandaToolStripMenuItem.Size = new System.Drawing.Size(262, 28);
			this.agregarNuevaComandaToolStripMenuItem.Text = "Registrar Comandas";
			this.agregarNuevaComandaToolStripMenuItem.Click += new System.EventHandler(this.AgregarNuevaComandaToolStripMenuItemClick);
			// 
			// consultarComandasToolStripMenuItem
			// 
			this.consultarComandasToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
			this.consultarComandasPorMeseroToolStripMenuItem,
			this.consultarComandasPorCocineroToolStripMenuItem});
			this.consultarComandasToolStripMenuItem.Font = new System.Drawing.Font("Maiandra GD", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.consultarComandasToolStripMenuItem.Name = "consultarComandasToolStripMenuItem";
			this.consultarComandasToolStripMenuItem.Size = new System.Drawing.Size(262, 28);
			this.consultarComandasToolStripMenuItem.Text = "Consultar Comandas";
			// 
			// consultarComandasPorMeseroToolStripMenuItem
			// 
			this.consultarComandasPorMeseroToolStripMenuItem.Name = "consultarComandasPorMeseroToolStripMenuItem";
			this.consultarComandasPorMeseroToolStripMenuItem.Size = new System.Drawing.Size(381, 28);
			this.consultarComandasPorMeseroToolStripMenuItem.Text = "Consultar Comandas Por Mesero";
			this.consultarComandasPorMeseroToolStripMenuItem.Click += new System.EventHandler(this.ConsultarComandasPorMeseroToolStripMenuItemClick);
			// 
			// consultarComandasPorCocineroToolStripMenuItem
			// 
			this.consultarComandasPorCocineroToolStripMenuItem.Name = "consultarComandasPorCocineroToolStripMenuItem";
			this.consultarComandasPorCocineroToolStripMenuItem.Size = new System.Drawing.Size(381, 28);
			this.consultarComandasPorCocineroToolStripMenuItem.Text = "Consultar Comandas Por Cocinero";
			this.consultarComandasPorCocineroToolStripMenuItem.Click += new System.EventHandler(this.ConsultarComandasPorCocineroToolStripMenuItemClick);
			// 
			// modificarComandasToolStripMenuItem
			// 
			this.modificarComandasToolStripMenuItem.Font = new System.Drawing.Font("Maiandra GD", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.modificarComandasToolStripMenuItem.Name = "modificarComandasToolStripMenuItem";
			this.modificarComandasToolStripMenuItem.Size = new System.Drawing.Size(262, 28);
			this.modificarComandasToolStripMenuItem.Text = "Modificar Comandas";
			this.modificarComandasToolStripMenuItem.Click += new System.EventHandler(this.ModificarComandasToolStripMenuItemClick);
			// 
			// cajaToolStripMenuItem
			// 
			this.cajaToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
			this.generarVentaToolStripMenuItem,
			this.consultarComandasDeCajeroDelDiaToolStripMenuItem});
			this.cajaToolStripMenuItem.Font = new System.Drawing.Font("Maiandra GD", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.cajaToolStripMenuItem.ForeColor = System.Drawing.Color.White;
			this.cajaToolStripMenuItem.Name = "cajaToolStripMenuItem";
			this.cajaToolStripMenuItem.Size = new System.Drawing.Size(60, 28);
			this.cajaToolStripMenuItem.Text = "Caja";
			this.cajaToolStripMenuItem.ToolTipText = "Menú De Caja";
			// 
			// generarVentaToolStripMenuItem
			// 
			this.generarVentaToolStripMenuItem.Font = new System.Drawing.Font("Maiandra GD", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.generarVentaToolStripMenuItem.Name = "generarVentaToolStripMenuItem";
			this.generarVentaToolStripMenuItem.Size = new System.Drawing.Size(360, 24);
			this.generarVentaToolStripMenuItem.Text = "Generar Venta";
			this.generarVentaToolStripMenuItem.Click += new System.EventHandler(this.GenerarVentaToolStripMenuItemClick);
			// 
			// consultarComandasDeCajeroDelDiaToolStripMenuItem
			// 
			this.consultarComandasDeCajeroDelDiaToolStripMenuItem.Font = new System.Drawing.Font("Maiandra GD", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.consultarComandasDeCajeroDelDiaToolStripMenuItem.Name = "consultarComandasDeCajeroDelDiaToolStripMenuItem";
			this.consultarComandasDeCajeroDelDiaToolStripMenuItem.Size = new System.Drawing.Size(360, 24);
			this.consultarComandasDeCajeroDelDiaToolStripMenuItem.Text = "Consultar Comandas De Cajero Del Dia";
			this.consultarComandasDeCajeroDelDiaToolStripMenuItem.Click += new System.EventHandler(this.ConsultarComandasDeCajeroDelDiaToolStripMenuItemClick);
			// 
			// productosToolStripMenuItem
			// 
			this.productosToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
			this.registrarProductosToolStripMenuItem,
			this.consultarProductosToolStripMenuItem,
			this.modificarProductosToolStripMenuItem});
			this.productosToolStripMenuItem.ForeColor = System.Drawing.Color.White;
			this.productosToolStripMenuItem.Name = "productosToolStripMenuItem";
			this.productosToolStripMenuItem.Size = new System.Drawing.Size(109, 28);
			this.productosToolStripMenuItem.Text = "Productos";
			this.productosToolStripMenuItem.ToolTipText = "Menú De Productos";
			// 
			// registrarProductosToolStripMenuItem
			// 
			this.registrarProductosToolStripMenuItem.Name = "registrarProductosToolStripMenuItem";
			this.registrarProductosToolStripMenuItem.Size = new System.Drawing.Size(257, 28);
			this.registrarProductosToolStripMenuItem.Text = "Registrar Productos";
			this.registrarProductosToolStripMenuItem.Click += new System.EventHandler(this.RegistrarProductosToolStripMenuItemClick);
			// 
			// consultarProductosToolStripMenuItem
			// 
			this.consultarProductosToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
			this.consultarTodosLosProductosToolStripMenuItem,
			this.consultarProductosPorTipoToolStripMenuItem,
			this.consultarProductosPorDisponibilidadToolStripMenuItem});
			this.consultarProductosToolStripMenuItem.Name = "consultarProductosToolStripMenuItem";
			this.consultarProductosToolStripMenuItem.Size = new System.Drawing.Size(257, 28);
			this.consultarProductosToolStripMenuItem.Text = "Consultar Productos";
			// 
			// consultarTodosLosProductosToolStripMenuItem
			// 
			this.consultarTodosLosProductosToolStripMenuItem.Name = "consultarTodosLosProductosToolStripMenuItem";
			this.consultarTodosLosProductosToolStripMenuItem.Size = new System.Drawing.Size(425, 28);
			this.consultarTodosLosProductosToolStripMenuItem.Text = "Consultar Todos Los Productos";
			this.consultarTodosLosProductosToolStripMenuItem.Click += new System.EventHandler(this.ConsultarTodosLosProductosToolStripMenuItemClick);
			// 
			// consultarProductosPorTipoToolStripMenuItem
			// 
			this.consultarProductosPorTipoToolStripMenuItem.Name = "consultarProductosPorTipoToolStripMenuItem";
			this.consultarProductosPorTipoToolStripMenuItem.Size = new System.Drawing.Size(425, 28);
			this.consultarProductosPorTipoToolStripMenuItem.Text = "Consultar Productos Por Tipo";
			this.consultarProductosPorTipoToolStripMenuItem.Click += new System.EventHandler(this.ConsultarProductosPorTipoToolStripMenuItemClick);
			// 
			// consultarProductosPorDisponibilidadToolStripMenuItem
			// 
			this.consultarProductosPorDisponibilidadToolStripMenuItem.Name = "consultarProductosPorDisponibilidadToolStripMenuItem";
			this.consultarProductosPorDisponibilidadToolStripMenuItem.Size = new System.Drawing.Size(425, 28);
			this.consultarProductosPorDisponibilidadToolStripMenuItem.Text = "Consultar Productos Por Disponibilidad";
			this.consultarProductosPorDisponibilidadToolStripMenuItem.Click += new System.EventHandler(this.ConsultarProductosPorDisponibilidadToolStripMenuItemClick);
			// 
			// modificarProductosToolStripMenuItem
			// 
			this.modificarProductosToolStripMenuItem.Name = "modificarProductosToolStripMenuItem";
			this.modificarProductosToolStripMenuItem.Size = new System.Drawing.Size(257, 28);
			this.modificarProductosToolStripMenuItem.Text = "Modificar Productos";
			this.modificarProductosToolStripMenuItem.Click += new System.EventHandler(this.ModificarProductosToolStripMenuItemClick);
			// 
			// empleadosToolStripMenuItem
			// 
			this.empleadosToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
			this.registrarEmpleadosToolStripMenuItem,
			this.consultarEmpleadosToolStripMenuItem,
			this.modificarEmpleadosToolStripMenuItem});
			this.empleadosToolStripMenuItem.ForeColor = System.Drawing.Color.White;
			this.empleadosToolStripMenuItem.Name = "empleadosToolStripMenuItem";
			this.empleadosToolStripMenuItem.Size = new System.Drawing.Size(117, 28);
			this.empleadosToolStripMenuItem.Text = "Empleados";
			this.empleadosToolStripMenuItem.ToolTipText = "Menú De Empleados";
			// 
			// registrarEmpleadosToolStripMenuItem
			// 
			this.registrarEmpleadosToolStripMenuItem.Name = "registrarEmpleadosToolStripMenuItem";
			this.registrarEmpleadosToolStripMenuItem.Size = new System.Drawing.Size(265, 28);
			this.registrarEmpleadosToolStripMenuItem.Text = "Registrar Empleados";
			this.registrarEmpleadosToolStripMenuItem.Click += new System.EventHandler(this.RegistrarEmpleadosToolStripMenuItemClick);
			// 
			// consultarEmpleadosToolStripMenuItem
			// 
			this.consultarEmpleadosToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
			this.consultarEmpleadosPorPuestoToolStripMenuItem,
			this.consultarTodosLosEmpleadosToolStripMenuItem});
			this.consultarEmpleadosToolStripMenuItem.Name = "consultarEmpleadosToolStripMenuItem";
			this.consultarEmpleadosToolStripMenuItem.Size = new System.Drawing.Size(265, 28);
			this.consultarEmpleadosToolStripMenuItem.Text = "Consultar Empleados";
			// 
			// consultarEmpleadosPorPuestoToolStripMenuItem
			// 
			this.consultarEmpleadosPorPuestoToolStripMenuItem.Name = "consultarEmpleadosPorPuestoToolStripMenuItem";
			this.consultarEmpleadosPorPuestoToolStripMenuItem.Size = new System.Drawing.Size(364, 28);
			this.consultarEmpleadosPorPuestoToolStripMenuItem.Text = "Consultar Empleados Por Puesto";
			this.consultarEmpleadosPorPuestoToolStripMenuItem.Click += new System.EventHandler(this.ConsultarEmpleadosPorPuestoToolStripMenuItemClick);
			// 
			// consultarTodosLosEmpleadosToolStripMenuItem
			// 
			this.consultarTodosLosEmpleadosToolStripMenuItem.Name = "consultarTodosLosEmpleadosToolStripMenuItem";
			this.consultarTodosLosEmpleadosToolStripMenuItem.Size = new System.Drawing.Size(364, 28);
			this.consultarTodosLosEmpleadosToolStripMenuItem.Text = "Consultar Todos Los Empleados";
			this.consultarTodosLosEmpleadosToolStripMenuItem.Click += new System.EventHandler(this.ConsultarTodosLosEmpleadosToolStripMenuItemClick);
			// 
			// modificarEmpleadosToolStripMenuItem
			// 
			this.modificarEmpleadosToolStripMenuItem.Name = "modificarEmpleadosToolStripMenuItem";
			this.modificarEmpleadosToolStripMenuItem.Size = new System.Drawing.Size(265, 28);
			this.modificarEmpleadosToolStripMenuItem.Text = "Modificar Empleados";
			this.modificarEmpleadosToolStripMenuItem.Click += new System.EventHandler(this.ModificarEmpleadosToolStripMenuItemClick);
			// 
			// cocinaToolStripMenuItem
			// 
			this.cocinaToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
			this.asignarmeAUnaComandaToolStripMenuItem,
			this.comandasQueTengoAsignadasToolStripMenuItem});
			this.cocinaToolStripMenuItem.ForeColor = System.Drawing.Color.White;
			this.cocinaToolStripMenuItem.Name = "cocinaToolStripMenuItem";
			this.cocinaToolStripMenuItem.Size = new System.Drawing.Size(81, 28);
			this.cocinaToolStripMenuItem.Text = "Cocina";
			this.cocinaToolStripMenuItem.ToolTipText = "Menú De Cocina";
			// 
			// asignarmeAUnaComandaToolStripMenuItem
			// 
			this.asignarmeAUnaComandaToolStripMenuItem.Name = "asignarmeAUnaComandaToolStripMenuItem";
			this.asignarmeAUnaComandaToolStripMenuItem.Size = new System.Drawing.Size(368, 28);
			this.asignarmeAUnaComandaToolStripMenuItem.Text = "Asignarme A Una Comanda";
			this.asignarmeAUnaComandaToolStripMenuItem.Click += new System.EventHandler(this.AsignarmeAUnaComandaToolStripMenuItemClick);
			// 
			// buscarToolStripMenuItem
			// 
			this.buscarToolStripMenuItem.ForeColor = System.Drawing.Color.White;
			this.buscarToolStripMenuItem.Name = "buscarToolStripMenuItem";
			this.buscarToolStripMenuItem.Size = new System.Drawing.Size(77, 28);
			this.buscarToolStripMenuItem.Text = "Buscar";
			this.buscarToolStripMenuItem.Click += new System.EventHandler(this.BuscarToolStripMenuItemClick);
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
			this.labelTitulo.Location = new System.Drawing.Point(551, 7);
			this.labelTitulo.Name = "labelTitulo";
			this.labelTitulo.Size = new System.Drawing.Size(334, 77);
			this.labelTitulo.TabIndex = 1;
			this.labelTitulo.Text = "MENÚ PRINCIPAL";
			this.labelTitulo.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// labelRegresar
			// 
			this.labelRegresar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
			this.labelRegresar.BackColor = System.Drawing.Color.Transparent;
			this.labelRegresar.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
			this.labelRegresar.Font = new System.Drawing.Font("Maiandra GD", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.labelRegresar.ForeColor = System.Drawing.Color.White;
			this.labelRegresar.Location = new System.Drawing.Point(12, 631);
			this.labelRegresar.Name = "labelRegresar";
			this.labelRegresar.Size = new System.Drawing.Size(331, 87);
			this.labelRegresar.TabIndex = 2;
			this.labelRegresar.Text = "CERRAR SESIÓN";
			this.labelRegresar.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			this.labelRegresar.MouseDown += new System.Windows.Forms.MouseEventHandler(this.LabelRegresarMouseDown);
			this.labelRegresar.MouseEnter += new System.EventHandler(this.LabelRegresarMouseEnter);
			this.labelRegresar.MouseLeave += new System.EventHandler(this.LabelRegresarMouseLeave);
			// 
			// pictureBoxImagenEmpleado
			// 
			this.pictureBoxImagenEmpleado.BackColor = System.Drawing.Color.Transparent;
			this.pictureBoxImagenEmpleado.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
			this.pictureBoxImagenEmpleado.Location = new System.Drawing.Point(1132, 12);
			this.pictureBoxImagenEmpleado.Name = "pictureBoxImagenEmpleado";
			this.pictureBoxImagenEmpleado.Size = new System.Drawing.Size(200, 200);
			this.pictureBoxImagenEmpleado.TabIndex = 3;
			this.pictureBoxImagenEmpleado.TabStop = false;
			// 
			// toolTipUser
			// 
			this.toolTipUser.IsBalloon = true;
			this.toolTipUser.ToolTipIcon = System.Windows.Forms.ToolTipIcon.Info;
			this.toolTipUser.ToolTipTitle = "USER.";
			// 
			// toolTipImagenEmpleado
			// 
			this.toolTipImagenEmpleado.IsBalloon = true;
			this.toolTipImagenEmpleado.ToolTipIcon = System.Windows.Forms.ToolTipIcon.Info;
			this.toolTipImagenEmpleado.ToolTipTitle = "Imagen.";
			// 
			// toolTipCerrarSesion
			// 
			this.toolTipCerrarSesion.IsBalloon = true;
			this.toolTipCerrarSesion.ToolTipIcon = System.Windows.Forms.ToolTipIcon.Info;
			this.toolTipCerrarSesion.ToolTipTitle = "Cerrar Sesión";
			// 
			// labelBienvenida
			// 
			this.labelBienvenida.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
			| System.Windows.Forms.AnchorStyles.Left) 
			| System.Windows.Forms.AnchorStyles.Right)));
			this.labelBienvenida.BackColor = System.Drawing.Color.Transparent;
			this.labelBienvenida.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
			this.labelBienvenida.Font = new System.Drawing.Font("Maiandra GD", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.labelBienvenida.ForeColor = System.Drawing.Color.White;
			this.labelBienvenida.Location = new System.Drawing.Point(792, 662);
			this.labelBienvenida.Name = "labelBienvenida";
			this.labelBienvenida.Size = new System.Drawing.Size(544, 56);
			this.labelBienvenida.TabIndex = 5;
			this.labelBienvenida.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// dataGridViewNotificaciones
			// 
			this.dataGridViewNotificaciones.AllowUserToAddRows = false;
			this.dataGridViewNotificaciones.AllowUserToDeleteRows = false;
			this.dataGridViewNotificaciones.AllowUserToOrderColumns = true;
			this.dataGridViewNotificaciones.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
			| System.Windows.Forms.AnchorStyles.Left) 
			| System.Windows.Forms.AnchorStyles.Right)));
			this.dataGridViewNotificaciones.BackgroundColor = System.Drawing.Color.Black;
			this.dataGridViewNotificaciones.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
			this.dataGridViewNotificaciones.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.Sunken;
			this.dataGridViewNotificaciones.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Sunken;
			dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
			dataGridViewCellStyle1.BackColor = System.Drawing.Color.Black;
			dataGridViewCellStyle1.Font = new System.Drawing.Font("Maiandra GD", 8.25F);
			dataGridViewCellStyle1.ForeColor = System.Drawing.Color.White;
			dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
			dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.White;
			dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
			this.dataGridViewNotificaciones.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
			this.dataGridViewNotificaciones.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dataGridViewNotificaciones.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
			this.NOTIFICACION,
			this.FECHA,
			this.LEIDO});
			dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
			dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Window;
			dataGridViewCellStyle3.Font = new System.Drawing.Font("Maiandra GD", 8.25F);
			dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.ControlText;
			dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
			dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
			dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
			this.dataGridViewNotificaciones.DefaultCellStyle = dataGridViewCellStyle3;
			this.dataGridViewNotificaciones.Location = new System.Drawing.Point(788, 284);
			this.dataGridViewNotificaciones.Name = "dataGridViewNotificaciones";
			this.dataGridViewNotificaciones.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Sunken;
			this.dataGridViewNotificaciones.RowHeadersVisible = false;
			dataGridViewCellStyle4.BackColor = System.Drawing.Color.Black;
			dataGridViewCellStyle4.Font = new System.Drawing.Font("Maiandra GD", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			dataGridViewCellStyle4.ForeColor = System.Drawing.Color.White;
			dataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.Blue;
			dataGridViewCellStyle4.SelectionForeColor = System.Drawing.Color.White;
			this.dataGridViewNotificaciones.RowsDefaultCellStyle = dataGridViewCellStyle4;
			this.dataGridViewNotificaciones.RowTemplate.DefaultCellStyle.BackColor = System.Drawing.Color.Black;
			this.dataGridViewNotificaciones.RowTemplate.DefaultCellStyle.Font = new System.Drawing.Font("Maiandra GD", 9F);
			this.dataGridViewNotificaciones.RowTemplate.DefaultCellStyle.ForeColor = System.Drawing.Color.White;
			this.dataGridViewNotificaciones.RowTemplate.DefaultCellStyle.SelectionBackColor = System.Drawing.Color.Blue;
			this.dataGridViewNotificaciones.RowTemplate.DefaultCellStyle.SelectionForeColor = System.Drawing.Color.White;
			this.dataGridViewNotificaciones.RowTemplate.Height = 70;
			this.dataGridViewNotificaciones.RowTemplate.ReadOnly = true;
			this.dataGridViewNotificaciones.RowTemplate.Resizable = System.Windows.Forms.DataGridViewTriState.True;
			this.dataGridViewNotificaciones.Size = new System.Drawing.Size(544, 308);
			this.dataGridViewNotificaciones.TabIndex = 6;
			this.dataGridViewNotificaciones.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DataGridViewNotificacionesCellContentClick);
			// 
			// NOTIFICACION
			// 
			this.NOTIFICACION.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
			dataGridViewCellStyle2.BackColor = System.Drawing.Color.Transparent;
			dataGridViewCellStyle2.Font = new System.Drawing.Font("Maiandra GD", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			dataGridViewCellStyle2.ForeColor = System.Drawing.Color.Black;
			dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.Black;
			this.NOTIFICACION.DefaultCellStyle = dataGridViewCellStyle2;
			this.NOTIFICACION.HeaderText = "NOTIFICACIONES";
			this.NOTIFICACION.Name = "NOTIFICACION";
			// 
			// FECHA
			// 
			this.FECHA.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
			this.FECHA.HeaderText = "FECHA";
			this.FECHA.Name = "FECHA";
			this.FECHA.Width = 67;
			// 
			// LEIDO
			// 
			this.LEIDO.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader;
			this.LEIDO.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
			this.LEIDO.HeaderText = "NO VOLVER A MOSTRAR";
			this.LEIDO.Name = "LEIDO";
			this.LEIDO.Resizable = System.Windows.Forms.DataGridViewTriState.True;
			this.LEIDO.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
			this.LEIDO.Width = 98;
			// 
			// comandasQueTengoAsignadasToolStripMenuItem
			// 
			this.comandasQueTengoAsignadasToolStripMenuItem.Name = "comandasQueTengoAsignadasToolStripMenuItem";
			this.comandasQueTengoAsignadasToolStripMenuItem.Size = new System.Drawing.Size(368, 28);
			this.comandasQueTengoAsignadasToolStripMenuItem.Text = "Comandas Que Tengo Asignadas";
			this.comandasQueTengoAsignadasToolStripMenuItem.Click += new System.EventHandler(this.ComandasQueTengoAsignadasToolStripMenuItemClick);
			// 
			// MenuPrincipal
			// 
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
			this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
			this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
			this.ClientSize = new System.Drawing.Size(1348, 727);
			this.Controls.Add(this.dataGridViewNotificaciones);
			this.Controls.Add(this.labelBienvenida);
			this.Controls.Add(this.pictureBoxImagenEmpleado);
			this.Controls.Add(this.labelRegresar);
			this.Controls.Add(this.panelFondo);
			this.HelpButton = true;
			this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
			this.MainMenuStrip = this.menuStripMenus;
			this.MinimumSize = new System.Drawing.Size(1364, 766);
			this.Name = "MenuPrincipal";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "SISTEMA MEMÍN® ";
			this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
			this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.MenuPrincipalFormClosing);
			this.panelFondo.ResumeLayout(false);
			this.panelFondo.PerformLayout();
			this.menuStripMenus.ResumeLayout(false);
			this.menuStripMenus.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.pictureBoxImagenEmpleado)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.dataGridViewNotificaciones)).EndInit();
			this.ResumeLayout(false);

		}
	}
}
