/*
 * Creado por SharpDevelop.
 * Usuario: Brian Gaytan Lomeli
 * Fecha: 26/10/2019
 * Hora: 18:04
 * 
 * Para cambiar esta plantilla use Herramientas | Opciones | Codificación | Editar Encabezados Estándar
 */
namespace MEMIN_SYSTEM
{
	partial class ModificarPassword
	{
		/// <summary>
		/// Designer variable used to keep track of non-visual components.
		/// </summary>
		private System.ComponentModel.IContainer components = null;
		private System.Windows.Forms.Button buttonGuardar;
		private System.Windows.Forms.TextBox textBoxPassword3;
		private System.Windows.Forms.Label labelPassword3;
		private System.Windows.Forms.TextBox textBoxPassword1;
		private System.Windows.Forms.Label labelPassword1;
		private System.Windows.Forms.Label labelTitulo;
		private System.Windows.Forms.TextBox textBoxPassword2;
		private System.Windows.Forms.Label labelNuevaContrasenia;
		private System.Windows.Forms.TextBox textBoxNombreEmpleado;
		private System.Windows.Forms.Label labelNombreEmpleado;
		private System.Windows.Forms.NumericUpDown numericUpDownIDEmpleado;
		private System.Windows.Forms.Label labelID;
		private System.Windows.Forms.Button buttonVerificarID;
		
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ModificarPassword));
			this.buttonGuardar = new System.Windows.Forms.Button();
			this.textBoxPassword3 = new System.Windows.Forms.TextBox();
			this.labelPassword3 = new System.Windows.Forms.Label();
			this.textBoxPassword1 = new System.Windows.Forms.TextBox();
			this.labelPassword1 = new System.Windows.Forms.Label();
			this.labelTitulo = new System.Windows.Forms.Label();
			this.textBoxPassword2 = new System.Windows.Forms.TextBox();
			this.labelNuevaContrasenia = new System.Windows.Forms.Label();
			this.textBoxNombreEmpleado = new System.Windows.Forms.TextBox();
			this.labelNombreEmpleado = new System.Windows.Forms.Label();
			this.numericUpDownIDEmpleado = new System.Windows.Forms.NumericUpDown();
			this.labelID = new System.Windows.Forms.Label();
			this.buttonVerificarID = new System.Windows.Forms.Button();
			((System.ComponentModel.ISupportInitialize)(this.numericUpDownIDEmpleado)).BeginInit();
			this.SuspendLayout();
			// 
			// buttonGuardar
			// 
			this.buttonGuardar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
			this.buttonGuardar.BackColor = System.Drawing.Color.Transparent;
			this.buttonGuardar.Cursor = System.Windows.Forms.Cursors.Hand;
			this.buttonGuardar.Enabled = false;
			this.buttonGuardar.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
			this.buttonGuardar.Font = new System.Drawing.Font("Maiandra GD", 28F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.buttonGuardar.ForeColor = System.Drawing.Color.White;
			this.buttonGuardar.Location = new System.Drawing.Point(12, 578);
			this.buttonGuardar.Name = "buttonGuardar";
			this.buttonGuardar.Size = new System.Drawing.Size(786, 71);
			this.buttonGuardar.TabIndex = 41;
			this.buttonGuardar.Text = "MODIFICAR";
			this.buttonGuardar.UseVisualStyleBackColor = false;
			this.buttonGuardar.Click += new System.EventHandler(this.ButtonGuardarClick);
			// 
			// textBoxPassword3
			// 
			this.textBoxPassword3.Enabled = false;
			this.textBoxPassword3.Font = new System.Drawing.Font("Maiandra GD", 14.25F);
			this.textBoxPassword3.Location = new System.Drawing.Point(331, 489);
			this.textBoxPassword3.Name = "textBoxPassword3";
			this.textBoxPassword3.PasswordChar = '֎';
			this.textBoxPassword3.ScrollBars = System.Windows.Forms.ScrollBars.Horizontal;
			this.textBoxPassword3.Size = new System.Drawing.Size(467, 30);
			this.textBoxPassword3.TabIndex = 40;
			// 
			// labelPassword3
			// 
			this.labelPassword3.BackColor = System.Drawing.Color.Transparent;
			this.labelPassword3.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
			this.labelPassword3.Font = new System.Drawing.Font("Maiandra GD", 14.25F, System.Drawing.FontStyle.Bold);
			this.labelPassword3.ForeColor = System.Drawing.Color.White;
			this.labelPassword3.Location = new System.Drawing.Point(12, 489);
			this.labelPassword3.Name = "labelPassword3";
			this.labelPassword3.Size = new System.Drawing.Size(299, 30);
			this.labelPassword3.TabIndex = 39;
			this.labelPassword3.Text = "CONFIRME CONTRASEÑA:";
			this.labelPassword3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// textBoxPassword1
			// 
			this.textBoxPassword1.Font = new System.Drawing.Font("Maiandra GD", 14.25F);
			this.textBoxPassword1.Location = new System.Drawing.Point(331, 261);
			this.textBoxPassword1.Name = "textBoxPassword1";
			this.textBoxPassword1.PasswordChar = '֎';
			this.textBoxPassword1.ScrollBars = System.Windows.Forms.ScrollBars.Horizontal;
			this.textBoxPassword1.Size = new System.Drawing.Size(467, 30);
			this.textBoxPassword1.TabIndex = 38;
			// 
			// labelPassword1
			// 
			this.labelPassword1.BackColor = System.Drawing.Color.Transparent;
			this.labelPassword1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
			this.labelPassword1.Font = new System.Drawing.Font("Maiandra GD", 14.25F, System.Drawing.FontStyle.Bold);
			this.labelPassword1.ForeColor = System.Drawing.Color.White;
			this.labelPassword1.Location = new System.Drawing.Point(12, 261);
			this.labelPassword1.Name = "labelPassword1";
			this.labelPassword1.Size = new System.Drawing.Size(299, 30);
			this.labelPassword1.TabIndex = 36;
			this.labelPassword1.Text = "CONTRASEÑA ACTUAL:";
			this.labelPassword1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
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
			this.labelTitulo.Location = new System.Drawing.Point(126, 5);
			this.labelTitulo.Name = "labelTitulo";
			this.labelTitulo.Size = new System.Drawing.Size(606, 65);
			this.labelTitulo.TabIndex = 34;
			this.labelTitulo.Text = "MODIFICAR CONTRASEÑA";
			this.labelTitulo.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// textBoxPassword2
			// 
			this.textBoxPassword2.Enabled = false;
			this.textBoxPassword2.Font = new System.Drawing.Font("Maiandra GD", 14.25F);
			this.textBoxPassword2.Location = new System.Drawing.Point(331, 432);
			this.textBoxPassword2.Name = "textBoxPassword2";
			this.textBoxPassword2.PasswordChar = '֎';
			this.textBoxPassword2.ScrollBars = System.Windows.Forms.ScrollBars.Horizontal;
			this.textBoxPassword2.Size = new System.Drawing.Size(467, 30);
			this.textBoxPassword2.TabIndex = 43;
			// 
			// labelNuevaContrasenia
			// 
			this.labelNuevaContrasenia.BackColor = System.Drawing.Color.Transparent;
			this.labelNuevaContrasenia.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
			this.labelNuevaContrasenia.Font = new System.Drawing.Font("Maiandra GD", 14.25F, System.Drawing.FontStyle.Bold);
			this.labelNuevaContrasenia.ForeColor = System.Drawing.Color.White;
			this.labelNuevaContrasenia.Location = new System.Drawing.Point(12, 432);
			this.labelNuevaContrasenia.Name = "labelNuevaContrasenia";
			this.labelNuevaContrasenia.Size = new System.Drawing.Size(299, 30);
			this.labelNuevaContrasenia.TabIndex = 42;
			this.labelNuevaContrasenia.Text = "NUEVA CONTRASEÑA:";
			this.labelNuevaContrasenia.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// textBoxNombreEmpleado
			// 
			this.textBoxNombreEmpleado.Font = new System.Drawing.Font("Maiandra GD", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.textBoxNombreEmpleado.Location = new System.Drawing.Point(331, 187);
			this.textBoxNombreEmpleado.Name = "textBoxNombreEmpleado";
			this.textBoxNombreEmpleado.ReadOnly = true;
			this.textBoxNombreEmpleado.ScrollBars = System.Windows.Forms.ScrollBars.Horizontal;
			this.textBoxNombreEmpleado.Size = new System.Drawing.Size(467, 30);
			this.textBoxNombreEmpleado.TabIndex = 152;
			// 
			// labelNombreEmpleado
			// 
			this.labelNombreEmpleado.BackColor = System.Drawing.Color.Transparent;
			this.labelNombreEmpleado.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
			this.labelNombreEmpleado.Font = new System.Drawing.Font("Maiandra GD", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.labelNombreEmpleado.ForeColor = System.Drawing.Color.White;
			this.labelNombreEmpleado.Location = new System.Drawing.Point(12, 187);
			this.labelNombreEmpleado.Name = "labelNombreEmpleado";
			this.labelNombreEmpleado.Size = new System.Drawing.Size(299, 30);
			this.labelNombreEmpleado.TabIndex = 151;
			this.labelNombreEmpleado.Text = "NOMBRE DE EMPLEADO:";
			this.labelNombreEmpleado.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// numericUpDownIDEmpleado
			// 
			this.numericUpDownIDEmpleado.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
			this.numericUpDownIDEmpleado.Font = new System.Drawing.Font("Lucida Bright", 14.25F);
			this.numericUpDownIDEmpleado.Location = new System.Drawing.Point(331, 120);
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
			this.numericUpDownIDEmpleado.TabIndex = 150;
			this.numericUpDownIDEmpleado.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
			this.numericUpDownIDEmpleado.Value = new decimal(new int[] {
			2,
			0,
			0,
			0});
			// 
			// labelID
			// 
			this.labelID.BackColor = System.Drawing.Color.Transparent;
			this.labelID.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
			this.labelID.Font = new System.Drawing.Font("Maiandra GD", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.labelID.ForeColor = System.Drawing.Color.White;
			this.labelID.Location = new System.Drawing.Point(12, 120);
			this.labelID.Name = "labelID";
			this.labelID.Size = new System.Drawing.Size(299, 30);
			this.labelID.TabIndex = 149;
			this.labelID.Text = "ID DE EMPLEADO:";
			this.labelID.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// buttonVerificarID
			// 
			this.buttonVerificarID.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
			this.buttonVerificarID.BackColor = System.Drawing.Color.Transparent;
			this.buttonVerificarID.Cursor = System.Windows.Forms.Cursors.Hand;
			this.buttonVerificarID.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
			this.buttonVerificarID.Font = new System.Drawing.Font("Maiandra GD", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.buttonVerificarID.ForeColor = System.Drawing.Color.White;
			this.buttonVerificarID.Location = new System.Drawing.Point(331, 341);
			this.buttonVerificarID.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
			this.buttonVerificarID.Name = "buttonVerificarID";
			this.buttonVerificarID.Size = new System.Drawing.Size(467, 49);
			this.buttonVerificarID.TabIndex = 153;
			this.buttonVerificarID.Text = "VERIFICAR ID";
			this.buttonVerificarID.UseVisualStyleBackColor = false;
			this.buttonVerificarID.Click += new System.EventHandler(this.ButtonVerificarIDClick);
			// 
			// ModificarPassword
			// 
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
			this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
			this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
			this.ClientSize = new System.Drawing.Size(810, 661);
			this.Controls.Add(this.buttonVerificarID);
			this.Controls.Add(this.textBoxNombreEmpleado);
			this.Controls.Add(this.labelNombreEmpleado);
			this.Controls.Add(this.numericUpDownIDEmpleado);
			this.Controls.Add(this.labelID);
			this.Controls.Add(this.textBoxPassword2);
			this.Controls.Add(this.labelNuevaContrasenia);
			this.Controls.Add(this.buttonGuardar);
			this.Controls.Add(this.textBoxPassword3);
			this.Controls.Add(this.labelPassword3);
			this.Controls.Add(this.textBoxPassword1);
			this.Controls.Add(this.labelPassword1);
			this.Controls.Add(this.labelTitulo);
			this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
			this.MaximizeBox = false;
			this.MaximumSize = new System.Drawing.Size(826, 700);
			this.MinimumSize = new System.Drawing.Size(826, 700);
			this.Name = "ModificarPassword";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "SISTEMA MEMÍN® ";
			this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.ModificarPasswordFormClosing);
			((System.ComponentModel.ISupportInitialize)(this.numericUpDownIDEmpleado)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

		}
	}
}
