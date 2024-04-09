/*
 * Creado por SharpDevelop.
 * Usuario: Brian Gaytan Lomeli
 * Fecha: 26/10/2019
 * Hora: 13:01
 * 
 * Para cambiar esta plantilla use Herramientas | Opciones | Codificación | Editar Encabezados Estándar
 */
namespace MEMIN_SYSTEM
{
	partial class ConsultarEmpleados
	{
		/// <summary>
		/// Designer variable used to keep track of non-visual components.
		/// </summary>
		private System.ComponentModel.IContainer components = null;
		private System.Windows.Forms.DataGridView dataGridViewEmpleados;
		private System.Windows.Forms.DataGridViewTextBoxColumn ID_EMPLEADO;
		private System.Windows.Forms.DataGridViewTextBoxColumn NOMBRE;
		private System.Windows.Forms.DataGridViewTextBoxColumn APELLIDO_PATERNO;
		private System.Windows.Forms.DataGridViewTextBoxColumn APELIIDO_MATERNO;
		private System.Windows.Forms.DataGridViewTextBoxColumn PUESTO;
		private System.Windows.Forms.DataGridViewImageColumn IMAGEN;
		private System.Windows.Forms.Panel panelFondo;
		private System.Windows.Forms.Label labelTitulo;
		
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ConsultarEmpleados));
			this.dataGridViewEmpleados = new System.Windows.Forms.DataGridView();
			this.ID_EMPLEADO = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.NOMBRE = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.APELLIDO_PATERNO = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.APELIIDO_MATERNO = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.PUESTO = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.IMAGEN = new System.Windows.Forms.DataGridViewImageColumn();
			this.panelFondo = new System.Windows.Forms.Panel();
			this.labelTitulo = new System.Windows.Forms.Label();
			((System.ComponentModel.ISupportInitialize)(this.dataGridViewEmpleados)).BeginInit();
			this.panelFondo.SuspendLayout();
			this.SuspendLayout();
			// 
			// dataGridViewEmpleados
			// 
			this.dataGridViewEmpleados.AllowUserToAddRows = false;
			this.dataGridViewEmpleados.AllowUserToDeleteRows = false;
			dataGridViewCellStyle1.NullValue = null;
			this.dataGridViewEmpleados.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
			this.dataGridViewEmpleados.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
			| System.Windows.Forms.AnchorStyles.Right)));
			this.dataGridViewEmpleados.BackgroundColor = System.Drawing.Color.White;
			this.dataGridViewEmpleados.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
			this.dataGridViewEmpleados.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.Sunken;
			this.dataGridViewEmpleados.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
			dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
			dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Control;
			dataGridViewCellStyle2.Font = new System.Drawing.Font("Maiandra GD", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText;
			dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
			dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
			dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
			this.dataGridViewEmpleados.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
			this.dataGridViewEmpleados.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dataGridViewEmpleados.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
			this.ID_EMPLEADO,
			this.NOMBRE,
			this.APELLIDO_PATERNO,
			this.APELIIDO_MATERNO,
			this.PUESTO,
			this.IMAGEN});
			dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
			dataGridViewCellStyle3.BackColor = System.Drawing.Color.White;
			dataGridViewCellStyle3.Font = new System.Drawing.Font("Maiandra GD", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			dataGridViewCellStyle3.ForeColor = System.Drawing.Color.Black;
			dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
			dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.White;
			dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
			this.dataGridViewEmpleados.DefaultCellStyle = dataGridViewCellStyle3;
			this.dataGridViewEmpleados.Location = new System.Drawing.Point(12, 118);
			this.dataGridViewEmpleados.Name = "dataGridViewEmpleados";
			this.dataGridViewEmpleados.ReadOnly = true;
			this.dataGridViewEmpleados.RowHeadersVisible = false;
			dataGridViewCellStyle4.Font = new System.Drawing.Font("Maiandra GD", 9F);
			this.dataGridViewEmpleados.RowsDefaultCellStyle = dataGridViewCellStyle4;
			this.dataGridViewEmpleados.RowTemplate.Height = 150;
			this.dataGridViewEmpleados.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.CellSelect;
			this.dataGridViewEmpleados.Size = new System.Drawing.Size(1324, 600);
			this.dataGridViewEmpleados.TabIndex = 5;
			// 
			// ID_EMPLEADO
			// 
			this.ID_EMPLEADO.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader;
			this.ID_EMPLEADO.HeaderText = "ID EMPLEADO";
			this.ID_EMPLEADO.Name = "ID_EMPLEADO";
			this.ID_EMPLEADO.ReadOnly = true;
			this.ID_EMPLEADO.Width = 105;
			// 
			// NOMBRE
			// 
			this.NOMBRE.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
			this.NOMBRE.HeaderText = "NOMBRE";
			this.NOMBRE.Name = "NOMBRE";
			this.NOMBRE.ReadOnly = true;
			// 
			// APELLIDO_PATERNO
			// 
			this.APELLIDO_PATERNO.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
			this.APELLIDO_PATERNO.HeaderText = "APELLIDO PATERNO";
			this.APELLIDO_PATERNO.Name = "APELLIDO_PATERNO";
			this.APELLIDO_PATERNO.ReadOnly = true;
			// 
			// APELIIDO_MATERNO
			// 
			this.APELIIDO_MATERNO.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
			this.APELIIDO_MATERNO.HeaderText = "APELLIDO MATERNO";
			this.APELIIDO_MATERNO.Name = "APELIIDO_MATERNO";
			this.APELIIDO_MATERNO.ReadOnly = true;
			// 
			// PUESTO
			// 
			this.PUESTO.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
			this.PUESTO.HeaderText = "PUESTO";
			this.PUESTO.Name = "PUESTO";
			this.PUESTO.ReadOnly = true;
			// 
			// IMAGEN
			// 
			this.IMAGEN.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
			this.IMAGEN.HeaderText = "IMAGEN";
			this.IMAGEN.ImageLayout = System.Windows.Forms.DataGridViewImageCellLayout.Stretch;
			this.IMAGEN.Name = "IMAGEN";
			this.IMAGEN.ReadOnly = true;
			this.IMAGEN.Resizable = System.Windows.Forms.DataGridViewTriState.True;
			this.IMAGEN.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
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
			this.panelFondo.TabIndex = 107;
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
			this.labelTitulo.Size = new System.Drawing.Size(695, 50);
			this.labelTitulo.TabIndex = 1;
			this.labelTitulo.Text = "CONSULTAR EMPLEADOS";
			this.labelTitulo.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// ConsultarEmpleados
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
			this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
			this.ClientSize = new System.Drawing.Size(1348, 727);
			this.Controls.Add(this.panelFondo);
			this.Controls.Add(this.dataGridViewEmpleados);
			this.DoubleBuffered = true;
			this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
			this.MinimumSize = new System.Drawing.Size(1364, 766);
			this.Name = "ConsultarEmpleados";
			this.Text = "SISTEMA MEMÍN® ";
			this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
			this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.ConsultarEmpleadosFormClosing);
			this.Load += new System.EventHandler(this.ConsultarEmpleadosLoad);
			((System.ComponentModel.ISupportInitialize)(this.dataGridViewEmpleados)).EndInit();
			this.panelFondo.ResumeLayout(false);
			this.ResumeLayout(false);

		}
	}
}
