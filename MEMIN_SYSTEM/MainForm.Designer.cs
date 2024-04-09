/*
 * Creado por SharpDevelop.
 * Usuario: Brian Gaytan Lomeli
 * Fecha: 21/10/2019
 * Hora: 7:25
 * 
 * Para cambiar esta plantilla use Herramientas | Opciones | Codificación | Editar Encabezados Estándar
 */
namespace MEMIN_SYSTEM
{
	partial class MainForm
	{
		/// <summary>
		/// Designer variable used to keep track of non-visual components.
		/// </summary>
		private System.ComponentModel.IContainer components = null;
		private System.Windows.Forms.Panel panelFondo;
		private System.Windows.Forms.Label labelTitulo;
		private System.Windows.Forms.Label labelUsuario;
		private System.Windows.Forms.Label labelPassword;
		private System.Windows.Forms.TextBox textBoxPassword;
		private System.Windows.Forms.CheckBox checkBoxShowPassword;
		private System.Windows.Forms.Button buttonIngresar;
		private System.Windows.Forms.ToolTip toolTipLabelUsuario;
		private System.Windows.Forms.ToolTip toolTipLabelPassword;
		private System.Windows.Forms.ToolTip toolTipTextBoxUsuario;
		private System.Windows.Forms.ToolTip toolTipTextBoxPassword;
		private System.Windows.Forms.ToolTip toolTipButtonIngresar;
		private System.Windows.Forms.LinkLabel linkLabelNoTienesCuenta;
		private System.Windows.Forms.LinkLabel linkLabelModificarPassword;
		private System.Windows.Forms.NumericUpDown numericUpDownIDEmpleado;
		
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
			this.panelFondo = new System.Windows.Forms.Panel();
			this.labelTitulo = new System.Windows.Forms.Label();
			this.labelUsuario = new System.Windows.Forms.Label();
			this.labelPassword = new System.Windows.Forms.Label();
			this.textBoxPassword = new System.Windows.Forms.TextBox();
			this.checkBoxShowPassword = new System.Windows.Forms.CheckBox();
			this.buttonIngresar = new System.Windows.Forms.Button();
			this.toolTipLabelUsuario = new System.Windows.Forms.ToolTip(this.components);
			this.toolTipLabelPassword = new System.Windows.Forms.ToolTip(this.components);
			this.toolTipTextBoxUsuario = new System.Windows.Forms.ToolTip(this.components);
			this.toolTipTextBoxPassword = new System.Windows.Forms.ToolTip(this.components);
			this.toolTipButtonIngresar = new System.Windows.Forms.ToolTip(this.components);
			this.linkLabelNoTienesCuenta = new System.Windows.Forms.LinkLabel();
			this.linkLabelModificarPassword = new System.Windows.Forms.LinkLabel();
			this.numericUpDownIDEmpleado = new System.Windows.Forms.NumericUpDown();
			this.panelFondo.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.numericUpDownIDEmpleado)).BeginInit();
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
			this.panelFondo.TabIndex = 0;
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
			this.labelTitulo.Location = new System.Drawing.Point(545, 7);
			this.labelTitulo.Name = "labelTitulo";
			this.labelTitulo.Size = new System.Drawing.Size(322, 69);
			this.labelTitulo.TabIndex = 1;
			this.labelTitulo.Text = "SISTEMA MEMÍN";
			this.labelTitulo.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// labelUsuario
			// 
			this.labelUsuario.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
			| System.Windows.Forms.AnchorStyles.Right)));
			this.labelUsuario.BackColor = System.Drawing.Color.Transparent;
			this.labelUsuario.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
			this.labelUsuario.Font = new System.Drawing.Font("Maiandra GD", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.labelUsuario.ForeColor = System.Drawing.Color.White;
			this.labelUsuario.Location = new System.Drawing.Point(156, 238);
			this.labelUsuario.Name = "labelUsuario";
			this.labelUsuario.Size = new System.Drawing.Size(201, 49);
			this.labelUsuario.TabIndex = 2;
			this.labelUsuario.Text = "Usuario";
			this.labelUsuario.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// labelPassword
			// 
			this.labelPassword.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
			| System.Windows.Forms.AnchorStyles.Right)));
			this.labelPassword.BackColor = System.Drawing.Color.Transparent;
			this.labelPassword.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
			this.labelPassword.Font = new System.Drawing.Font("Maiandra GD", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.labelPassword.ForeColor = System.Drawing.Color.White;
			this.labelPassword.Location = new System.Drawing.Point(156, 316);
			this.labelPassword.Name = "labelPassword";
			this.labelPassword.Size = new System.Drawing.Size(201, 49);
			this.labelPassword.TabIndex = 3;
			this.labelPassword.Text = "Contraseña";
			this.labelPassword.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// textBoxPassword
			// 
			this.textBoxPassword.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
			| System.Windows.Forms.AnchorStyles.Right)));
			this.textBoxPassword.Font = new System.Drawing.Font("Maiandra GD", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.textBoxPassword.Location = new System.Drawing.Point(389, 316);
			this.textBoxPassword.Multiline = true;
			this.textBoxPassword.Name = "textBoxPassword";
			this.textBoxPassword.PasswordChar = '֎';
			this.textBoxPassword.ScrollBars = System.Windows.Forms.ScrollBars.Horizontal;
			this.textBoxPassword.Size = new System.Drawing.Size(843, 49);
			this.textBoxPassword.TabIndex = 2;
			this.textBoxPassword.KeyDown += new System.Windows.Forms.KeyEventHandler(this.TextBoxPasswordKeyDown);
			// 
			// checkBoxShowPassword
			// 
			this.checkBoxShowPassword.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
			this.checkBoxShowPassword.BackColor = System.Drawing.Color.Transparent;
			this.checkBoxShowPassword.Font = new System.Drawing.Font("Maiandra GD", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.checkBoxShowPassword.ForeColor = System.Drawing.Color.White;
			this.checkBoxShowPassword.Location = new System.Drawing.Point(966, 371);
			this.checkBoxShowPassword.Name = "checkBoxShowPassword";
			this.checkBoxShowPassword.Size = new System.Drawing.Size(266, 43);
			this.checkBoxShowPassword.TabIndex = 4;
			this.checkBoxShowPassword.Text = "Mostrar Contraseña";
			this.checkBoxShowPassword.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			this.checkBoxShowPassword.UseVisualStyleBackColor = false;
			this.checkBoxShowPassword.CheckedChanged += new System.EventHandler(this.CheckBoxShowPasswordCheckedChanged);
			// 
			// buttonIngresar
			// 
			this.buttonIngresar.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
			| System.Windows.Forms.AnchorStyles.Left) 
			| System.Windows.Forms.AnchorStyles.Right)));
			this.buttonIngresar.BackColor = System.Drawing.Color.Transparent;
			this.buttonIngresar.Cursor = System.Windows.Forms.Cursors.Hand;
			this.buttonIngresar.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
			this.buttonIngresar.Font = new System.Drawing.Font("Maiandra GD", 48F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.buttonIngresar.ForeColor = System.Drawing.Color.White;
			this.buttonIngresar.Location = new System.Drawing.Point(508, 479);
			this.buttonIngresar.Name = "buttonIngresar";
			this.buttonIngresar.Size = new System.Drawing.Size(336, 100);
			this.buttonIngresar.TabIndex = 3;
			this.buttonIngresar.Text = "Ingresar";
			this.buttonIngresar.UseVisualStyleBackColor = false;
			this.buttonIngresar.Click += new System.EventHandler(this.ButtonIngresarClick);
			// 
			// toolTipLabelUsuario
			// 
			this.toolTipLabelUsuario.IsBalloon = true;
			this.toolTipLabelUsuario.ToolTipIcon = System.Windows.Forms.ToolTipIcon.Info;
			this.toolTipLabelUsuario.ToolTipTitle = "Usuario.";
			// 
			// toolTipLabelPassword
			// 
			this.toolTipLabelPassword.IsBalloon = true;
			this.toolTipLabelPassword.ToolTipIcon = System.Windows.Forms.ToolTipIcon.Info;
			this.toolTipLabelPassword.ToolTipTitle = "Contraseña.";
			// 
			// toolTipTextBoxUsuario
			// 
			this.toolTipTextBoxUsuario.IsBalloon = true;
			this.toolTipTextBoxUsuario.ToolTipIcon = System.Windows.Forms.ToolTipIcon.Info;
			this.toolTipTextBoxUsuario.ToolTipTitle = "Ingresar Usuario.";
			// 
			// toolTipTextBoxPassword
			// 
			this.toolTipTextBoxPassword.IsBalloon = true;
			this.toolTipTextBoxPassword.ToolTipIcon = System.Windows.Forms.ToolTipIcon.Info;
			this.toolTipTextBoxPassword.ToolTipTitle = "Ingresar Contraseña.";
			// 
			// toolTipButtonIngresar
			// 
			this.toolTipButtonIngresar.IsBalloon = true;
			this.toolTipButtonIngresar.ToolTipIcon = System.Windows.Forms.ToolTipIcon.Info;
			this.toolTipButtonIngresar.ToolTipTitle = "Ingresar Al Sistema.";
			// 
			// linkLabelNoTienesCuenta
			// 
			this.linkLabelNoTienesCuenta.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
			this.linkLabelNoTienesCuenta.BackColor = System.Drawing.Color.Transparent;
			this.linkLabelNoTienesCuenta.Font = new System.Drawing.Font("Maiandra GD", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.linkLabelNoTienesCuenta.LinkColor = System.Drawing.Color.White;
			this.linkLabelNoTienesCuenta.Location = new System.Drawing.Point(0, 695);
			this.linkLabelNoTienesCuenta.Name = "linkLabelNoTienesCuenta";
			this.linkLabelNoTienesCuenta.Size = new System.Drawing.Size(434, 23);
			this.linkLabelNoTienesCuenta.TabIndex = 5;
			this.linkLabelNoTienesCuenta.TabStop = true;
			this.linkLabelNoTienesCuenta.Text = "¿NO TIENES CUENTA? ¡CREA UNA!";
			this.linkLabelNoTienesCuenta.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			this.linkLabelNoTienesCuenta.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.LinkLabelNoTienesCuentaLinkClicked);
			// 
			// linkLabelModificarPassword
			// 
			this.linkLabelModificarPassword.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
			this.linkLabelModificarPassword.BackColor = System.Drawing.Color.Transparent;
			this.linkLabelModificarPassword.Font = new System.Drawing.Font("Maiandra GD", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.linkLabelModificarPassword.LinkColor = System.Drawing.Color.White;
			this.linkLabelModificarPassword.Location = new System.Drawing.Point(950, 695);
			this.linkLabelModificarPassword.Name = "linkLabelModificarPassword";
			this.linkLabelModificarPassword.Size = new System.Drawing.Size(382, 23);
			this.linkLabelModificarPassword.TabIndex = 6;
			this.linkLabelModificarPassword.TabStop = true;
			this.linkLabelModificarPassword.Text = "MODIFICA TU CONTRASEÑA ¡AQUÍ!";
			this.linkLabelModificarPassword.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			this.linkLabelModificarPassword.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.LinkLabelModificarPasswordLinkClicked);
			// 
			// numericUpDownIDEmpleado
			// 
			this.numericUpDownIDEmpleado.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
			| System.Windows.Forms.AnchorStyles.Right)));
			this.numericUpDownIDEmpleado.Font = new System.Drawing.Font("Maiandra GD", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.numericUpDownIDEmpleado.Location = new System.Drawing.Point(389, 238);
			this.numericUpDownIDEmpleado.Maximum = new decimal(new int[] {
			100000000,
			0,
			0,
			0});
			this.numericUpDownIDEmpleado.Minimum = new decimal(new int[] {
			1,
			0,
			0,
			0});
			this.numericUpDownIDEmpleado.Name = "numericUpDownIDEmpleado";
			this.numericUpDownIDEmpleado.Size = new System.Drawing.Size(843, 49);
			this.numericUpDownIDEmpleado.TabIndex = 64;
			this.numericUpDownIDEmpleado.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
			this.numericUpDownIDEmpleado.Value = new decimal(new int[] {
			1,
			0,
			0,
			0});
			// 
			// MainForm
			// 
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
			this.AutoScroll = true;
			this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
			this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
			this.ClientSize = new System.Drawing.Size(1350, 727);
			this.Controls.Add(this.numericUpDownIDEmpleado);
			this.Controls.Add(this.linkLabelModificarPassword);
			this.Controls.Add(this.linkLabelNoTienesCuenta);
			this.Controls.Add(this.labelUsuario);
			this.Controls.Add(this.checkBoxShowPassword);
			this.Controls.Add(this.buttonIngresar);
			this.Controls.Add(this.textBoxPassword);
			this.Controls.Add(this.labelPassword);
			this.Controls.Add(this.panelFondo);
			this.HelpButton = true;
			this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
			this.MinimumSize = new System.Drawing.Size(1364, 766);
			this.Name = "MainForm";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "SISTEMA MEMÍN® ";
			this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
			this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.MainFormFormClosing);
			this.panelFondo.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.numericUpDownIDEmpleado)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

		}
	}
}
