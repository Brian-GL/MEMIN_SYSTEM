/*
 * Creado por SharpDevelop.
 * Usuario: Brian Gaytan Lomeli
 * Fecha: 26/10/2019
 * Hora: 10:46
 * 
 * Para cambiar esta plantilla use Herramientas | Opciones | Codificación | Editar Encabezados Estándar
 */
namespace MEMIN_SYSTEM
{
	partial class CrearCuenta
	{
		/// <summary>
		/// Designer variable used to keep track of non-visual components.
		/// </summary>
		private System.ComponentModel.IContainer components = null;
		private System.Windows.Forms.Label labelTitulo;
		private System.Windows.Forms.Label labelPassword1;
		private System.Windows.Forms.Label labelID;
		private System.Windows.Forms.TextBox textBoxPassword1;
		private System.Windows.Forms.Label labelPassword2;
		private System.Windows.Forms.TextBox textBoxPassword2;
		private System.Windows.Forms.Button buttonGuardar;
		private System.Windows.Forms.NumericUpDown numericUpDownIDEmpleado;
		private System.Windows.Forms.Button buttonVerificarID;
		private System.Windows.Forms.Label labelNombreEmpleado;
		private System.Windows.Forms.TextBox textBoxNombreEmpleado;
		
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CrearCuenta));
			this.labelTitulo = new System.Windows.Forms.Label();
			this.labelPassword1 = new System.Windows.Forms.Label();
			this.labelID = new System.Windows.Forms.Label();
			this.textBoxPassword1 = new System.Windows.Forms.TextBox();
			this.labelPassword2 = new System.Windows.Forms.Label();
			this.textBoxPassword2 = new System.Windows.Forms.TextBox();
			this.buttonGuardar = new System.Windows.Forms.Button();
			this.numericUpDownIDEmpleado = new System.Windows.Forms.NumericUpDown();
			this.buttonVerificarID = new System.Windows.Forms.Button();
			this.labelNombreEmpleado = new System.Windows.Forms.Label();
			this.textBoxNombreEmpleado = new System.Windows.Forms.TextBox();
			((System.ComponentModel.ISupportInitialize)(this.numericUpDownIDEmpleado)).BeginInit();
			this.SuspendLayout();
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
			this.labelTitulo.Location = new System.Drawing.Point(106, 9);
			this.labelTitulo.Name = "labelTitulo";
			this.labelTitulo.Size = new System.Drawing.Size(606, 58);
			this.labelTitulo.TabIndex = 4;
			this.labelTitulo.Text = "CREAR CUENTA";
			this.labelTitulo.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// labelPassword1
			// 
			this.labelPassword1.BackColor = System.Drawing.Color.Transparent;
			this.labelPassword1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
			this.labelPassword1.Font = new System.Drawing.Font("Maiandra GD", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.labelPassword1.ForeColor = System.Drawing.Color.White;
			this.labelPassword1.Location = new System.Drawing.Point(12, 300);
			this.labelPassword1.Name = "labelPassword1";
			this.labelPassword1.Size = new System.Drawing.Size(308, 30);
			this.labelPassword1.TabIndex = 28;
			this.labelPassword1.Text = "CONTRASEÑA:";
			this.labelPassword1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// labelID
			// 
			this.labelID.BackColor = System.Drawing.Color.Transparent;
			this.labelID.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
			this.labelID.Font = new System.Drawing.Font("Maiandra GD", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.labelID.ForeColor = System.Drawing.Color.White;
			this.labelID.Location = new System.Drawing.Point(12, 106);
			this.labelID.Name = "labelID";
			this.labelID.Size = new System.Drawing.Size(308, 30);
			this.labelID.TabIndex = 27;
			this.labelID.Text = "ID DE EMPLEADO:";
			this.labelID.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// textBoxPassword1
			// 
			this.textBoxPassword1.Enabled = false;
			this.textBoxPassword1.Font = new System.Drawing.Font("Maiandra GD", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.textBoxPassword1.Location = new System.Drawing.Point(326, 300);
			this.textBoxPassword1.Name = "textBoxPassword1";
			this.textBoxPassword1.PasswordChar = '֎';
			this.textBoxPassword1.ScrollBars = System.Windows.Forms.ScrollBars.Horizontal;
			this.textBoxPassword1.Size = new System.Drawing.Size(467, 30);
			this.textBoxPassword1.TabIndex = 30;
			// 
			// labelPassword2
			// 
			this.labelPassword2.BackColor = System.Drawing.Color.Transparent;
			this.labelPassword2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
			this.labelPassword2.Font = new System.Drawing.Font("Maiandra GD", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.labelPassword2.ForeColor = System.Drawing.Color.White;
			this.labelPassword2.Location = new System.Drawing.Point(12, 350);
			this.labelPassword2.Name = "labelPassword2";
			this.labelPassword2.Size = new System.Drawing.Size(308, 30);
			this.labelPassword2.TabIndex = 31;
			this.labelPassword2.Text = "RE-INGRESE CONTRASEÑA:";
			this.labelPassword2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// textBoxPassword2
			// 
			this.textBoxPassword2.Enabled = false;
			this.textBoxPassword2.Font = new System.Drawing.Font("Maiandra GD", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.textBoxPassword2.Location = new System.Drawing.Point(326, 350);
			this.textBoxPassword2.Name = "textBoxPassword2";
			this.textBoxPassword2.PasswordChar = '֎';
			this.textBoxPassword2.ScrollBars = System.Windows.Forms.ScrollBars.Horizontal;
			this.textBoxPassword2.Size = new System.Drawing.Size(467, 30);
			this.textBoxPassword2.TabIndex = 32;
			// 
			// buttonGuardar
			// 
			this.buttonGuardar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
			this.buttonGuardar.BackColor = System.Drawing.Color.Transparent;
			this.buttonGuardar.Cursor = System.Windows.Forms.Cursors.Hand;
			this.buttonGuardar.Enabled = false;
			this.buttonGuardar.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
			this.buttonGuardar.Font = new System.Drawing.Font("Maiandra GD", 22F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.buttonGuardar.ForeColor = System.Drawing.Color.White;
			this.buttonGuardar.Location = new System.Drawing.Point(12, 413);
			this.buttonGuardar.Name = "buttonGuardar";
			this.buttonGuardar.Size = new System.Drawing.Size(781, 46);
			this.buttonGuardar.TabIndex = 33;
			this.buttonGuardar.Text = "GUARDAR";
			this.buttonGuardar.UseVisualStyleBackColor = false;
			this.buttonGuardar.Click += new System.EventHandler(this.ButtonGuardarClick);
			// 
			// numericUpDownIDEmpleado
			// 
			this.numericUpDownIDEmpleado.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
			this.numericUpDownIDEmpleado.Font = new System.Drawing.Font("Lucida Bright", 14.25F);
			this.numericUpDownIDEmpleado.Location = new System.Drawing.Point(326, 106);
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
			this.numericUpDownIDEmpleado.Size = new System.Drawing.Size(467, 30);
			this.numericUpDownIDEmpleado.TabIndex = 145;
			this.numericUpDownIDEmpleado.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
			this.numericUpDownIDEmpleado.Value = new decimal(new int[] {
			2,
			0,
			0,
			0});
			// 
			// buttonVerificarID
			// 
			this.buttonVerificarID.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
			this.buttonVerificarID.BackColor = System.Drawing.Color.Transparent;
			this.buttonVerificarID.Cursor = System.Windows.Forms.Cursors.Hand;
			this.buttonVerificarID.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
			this.buttonVerificarID.Font = new System.Drawing.Font("Maiandra GD", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.buttonVerificarID.ForeColor = System.Drawing.Color.White;
			this.buttonVerificarID.Location = new System.Drawing.Point(326, 217);
			this.buttonVerificarID.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
			this.buttonVerificarID.Name = "buttonVerificarID";
			this.buttonVerificarID.Size = new System.Drawing.Size(467, 49);
			this.buttonVerificarID.TabIndex = 146;
			this.buttonVerificarID.Text = "VERIFICAR ID";
			this.buttonVerificarID.UseVisualStyleBackColor = false;
			this.buttonVerificarID.Click += new System.EventHandler(this.ButtonVerificarIDClick);
			// 
			// labelNombreEmpleado
			// 
			this.labelNombreEmpleado.BackColor = System.Drawing.Color.Transparent;
			this.labelNombreEmpleado.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
			this.labelNombreEmpleado.Font = new System.Drawing.Font("Maiandra GD", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.labelNombreEmpleado.ForeColor = System.Drawing.Color.White;
			this.labelNombreEmpleado.Location = new System.Drawing.Point(12, 162);
			this.labelNombreEmpleado.Name = "labelNombreEmpleado";
			this.labelNombreEmpleado.Size = new System.Drawing.Size(308, 30);
			this.labelNombreEmpleado.TabIndex = 147;
			this.labelNombreEmpleado.Text = "NOMBRE DE EMPLEADO:";
			this.labelNombreEmpleado.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// textBoxNombreEmpleado
			// 
			this.textBoxNombreEmpleado.Font = new System.Drawing.Font("Maiandra GD", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.textBoxNombreEmpleado.Location = new System.Drawing.Point(326, 162);
			this.textBoxNombreEmpleado.Name = "textBoxNombreEmpleado";
			this.textBoxNombreEmpleado.ReadOnly = true;
			this.textBoxNombreEmpleado.ScrollBars = System.Windows.Forms.ScrollBars.Horizontal;
			this.textBoxNombreEmpleado.Size = new System.Drawing.Size(467, 30);
			this.textBoxNombreEmpleado.TabIndex = 148;
			// 
			// CrearCuenta
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
			this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
			this.ClientSize = new System.Drawing.Size(810, 471);
			this.Controls.Add(this.textBoxNombreEmpleado);
			this.Controls.Add(this.labelNombreEmpleado);
			this.Controls.Add(this.buttonVerificarID);
			this.Controls.Add(this.numericUpDownIDEmpleado);
			this.Controls.Add(this.buttonGuardar);
			this.Controls.Add(this.textBoxPassword2);
			this.Controls.Add(this.labelPassword2);
			this.Controls.Add(this.textBoxPassword1);
			this.Controls.Add(this.labelPassword1);
			this.Controls.Add(this.labelID);
			this.Controls.Add(this.labelTitulo);
			this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
			this.MaximizeBox = false;
			this.MaximumSize = new System.Drawing.Size(826, 510);
			this.MinimumSize = new System.Drawing.Size(826, 510);
			this.Name = "CrearCuenta";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "SISTEMA MEMÍN® ";
			this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.CrearCuentaFormClosing);
			((System.ComponentModel.ISupportInitialize)(this.numericUpDownIDEmpleado)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

		}
	}
}
