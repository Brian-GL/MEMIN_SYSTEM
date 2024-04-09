/*
 * Creado por SharpDevelop.
 * Usuario: Brian Gaytan Lomeli
 * Fecha: 21/10/2019
 * Hora: 7:58
 * 
 * Para cambiar esta plantilla use Herramientas | Opciones | Codificación | Editar Encabezados Estándar
 */
using System;
using System.Drawing;
using System.Windows.Forms;
using MySql.Data.MySqlClient;
using System.Linq;
using System.Collections.Generic;

namespace MEMIN_SYSTEM
{
	/// <summary>
	/// Description of MenuPrincipal.
	/// </summary>
	public partial class MenuPrincipal : Form
	{
		Empleado myEmpleado;
		public MenuPrincipal(FormWindowState ws,Empleado employee)
		{
			//
			// The InitializeComponent() call is required for Windows Forms designer support.
			//
			InitializeComponent();
			
			//
			// TODO: Add constructor code after the InitializeComponent() call.
			//
			
			dataGridViewNotificaciones.Rows.Clear();
			this.WindowState = ws;
			
			this.toolTipUser.SetToolTip(labelIdUSUARIO,"Este valor representa el ID del usuario que está actualmente ingresado en el sistema.");
			this.toolTipImagenEmpleado.SetToolTip(pictureBoxImagenEmpleado,"Este recuadro representa la imagen del usuario que está actualmente ingresado en el sistema.");
			this.toolTipCerrarSesion.SetToolTip(labelRegresar,"Ingrese click en este espacio para cerrar su sesión actual.");
			agregarNuevaComandaToolStripMenuItem.ToolTipText = "Ingrese click en este espacio para registrar nuevas comandas en el sistema";
			myEmpleado = employee;
			pictureBoxImagenEmpleado.SizeMode = PictureBoxSizeMode.StretchImage;
			pictureBoxImagenEmpleado.Image = employee.IMAGEN;
			var color = PredominatColor(new Bitmap(employee.IMAGEN));
			if(color.R >=240 || color.G >= 240 || color.B >= 240)
			{
				labelIdUSUARIO.ForeColor = menuStripMenus.ForeColor = labelTitulo.ForeColor = Color.Black;
				comandasToolStripMenuItem.ForeColor = productosToolStripMenuItem.ForeColor = empleadosToolStripMenuItem.ForeColor = cocinaToolStripMenuItem.ForeColor
					= cajaToolStripMenuItem.ForeColor = buscarToolStripMenuItem.ForeColor = Color.Black;
			}
				
			panelFondo.BackColor = color;
			labelIdUSUARIO.Text = "ID EMPLEADO: "+employee.ID_EMPLEADO+"\nPUESTO:  "+" ["+employee.PUESTO+"]";
			labelBienvenida.Text = "BIENVENID@:     "+employee.NOMBRE+" "+employee.APELLIDO_PATERNO;

			var myConnection = new MySqlConnection();
			myConnection.ConnectionString = myConnection.ConnectionString="server=localhost;password=; database=sistema_memin; User Id=root";
			myConnection.Open();
			string sentence = "SELECT NOTIFICACION, FECHA FROM NOTIFICACIONES WHERE ID_EMPLEADO = "+employee.ID_EMPLEADO+";";
			var command = new MySqlCommand(sentence,myConnection);
			MySqlDataReader myReader;
			myReader = command.ExecuteReader();
			
			if(myReader.Read()){
				if(myReader.GetString(0).Length > 2){
					int renglon = dataGridViewNotificaciones.Rows.Add();
					
					dataGridViewNotificaciones.Rows[renglon].Cells["NOTIFICACION"].Value = myReader.GetString(0);
					dataGridViewNotificaciones.Rows[renglon].Cells["FECHA"].Value = myReader.GetString(1);;
					dataGridViewNotificaciones.Rows[renglon].Cells["LEIDO"].Value = "✔";
				}
				
			}
			
			myConnection.Close();
			command.Dispose();
			myReader.Dispose();
			myConnection.Dispose();

		
		}
		void MenuPrincipalFormClosing(object sender, FormClosingEventArgs e)
		{
			myEmpleado.Liberar();
			this.Dispose();
		}
		void RegistrarProductosToolStripMenuItemClick(object sender, EventArgs e)
		{
			var registrarProducto = new RegistrarProductos(this.WindowState,panelFondo.BackColor);
			registrarProducto.ShowDialog();
			
		}
		void LabelRegresarMouseDown(object sender, MouseEventArgs e)
		{
			var mainForm = new MainForm(this.WindowState);
			this.Close();
			mainForm.ShowDialog();
		}
		void ConsultarTodosLosProductosToolStripMenuItemClick(object sender, EventArgs e)
		{

			var consultarTodosProductos = new ConsultarProductos(this.WindowState,panelFondo.BackColor);
			consultarTodosProductos.ShowDialog();
		}
		void RegistrarEmpleadosToolStripMenuItemClick(object sender, EventArgs e)
		{
			if(myEmpleado.PUESTO != "GERENCIA"){
				MessageBox.Show("¡USTED NO TIENE PERMISOS PARA REGISTRAR COMANDAS!\n","ERROR",MessageBoxButtons.OK,MessageBoxIcon.Error);
				return;
			}
			
			var registrarEmpleado = new RegistrarEmpleados(this.WindowState,panelFondo.BackColor);
			registrarEmpleado.ShowDialog();

		}
	
		void AgregarNuevaComandaToolStripMenuItemClick(object sender, EventArgs e)
		{
			if(myEmpleado.PUESTO != "MESERO" && myEmpleado.PUESTO != "CAPITAN DE MESEROS" && myEmpleado.PUESTO != "GERENCIA"){
				MessageBox.Show("¡USTED NO TIENE PERMISOS PARA REGISTRAR COMANDAS!\n","ERROR",MessageBoxButtons.OK,MessageBoxIcon.Error);
				return;
			}

			var agregarComanda = new RegistrarComanda(this.WindowState,myEmpleado.ID_EMPLEADO.ToString(),myEmpleado.NOMBRE+", "+myEmpleado.APELLIDO_PATERNO,myEmpleado.IMAGEN,panelFondo.BackColor);
			agregarComanda.ShowDialog();
			
			RecargarNotificaciones();

		}
		void BuscarUnaComandaToolStripMenuItemClick(object sender, EventArgs e)
		{
			
			var buscarComandas = new BuscarTodo(this.WindowState,panelFondo.BackColor);
			buscarComandas.ShowDialog();
		}
		void ConsultarComandasPorMeseroToolStripMenuItemClick(object sender, EventArgs e)
		{
			if(myEmpleado.PUESTO != "MESERO" && myEmpleado.PUESTO != "CAPITAN DE MESEROS"  && myEmpleado.PUESTO != "GERENCIA"){
				MessageBox.Show("¡USTED NO TIENE PERMISOS PARA CONSULTAR COMANDAS REGSITRADAS POR MESEROS!\n","ERROR",MessageBoxButtons.OK,MessageBoxIcon.Error);
				return;
			}

			var vercomandasDeMesero = new ComandasMesero(this.WindowState,panelFondo.BackColor);
			vercomandasDeMesero.ShowDialog();
		}
		void ConsultarComandasPorCocineroToolStripMenuItemClick(object sender, EventArgs e)
		{
			if(myEmpleado.PUESTO != "COCINERO" && myEmpleado.PUESTO != "CHEF" && myEmpleado.PUESTO != "ENCARGADO COCINA" && myEmpleado.PUESTO != "GERENCIA"){
				MessageBox.Show("¡USTED NO TIENE PERMISOS PARA CONSULTAR COMANDAS PREPARADAS POR UN EMPLEADO DE COCINA!\n","ERROR",MessageBoxButtons.OK,MessageBoxIcon.Error);
				return;
			}

			var vercomandasDeCocinero = new ComandasCocinero(this.WindowState,panelFondo.BackColor);
			vercomandasDeCocinero.ShowDialog();
		}

		
		void GenerarVentaToolStripMenuItemClick(object sender, EventArgs e)
		{
			if(myEmpleado.PUESTO != "CAJERO"  && myEmpleado.PUESTO != "GERENCIA"){
				MessageBox.Show("¡USTED NO TIENE PERMISOS PARA GENERAR VENTAS!\n","ERROR",MessageBoxButtons.OK,MessageBoxIcon.Error);
				return;
			}
			
			var generarVenta = new GenerarVenta(this.WindowState,panelFondo.BackColor,myEmpleado.ID_EMPLEADO.ToString(),myEmpleado.NOMBRE +" " +myEmpleado.APELLIDO_PATERNO );
			generarVenta.ShowDialog();
			
			RecargarNotificaciones();
		}
		void ConsultarComandasDeCajeroDelDiaToolStripMenuItemClick(object sender, EventArgs e)
		{
			if(myEmpleado.PUESTO != "CAJERO" && myEmpleado.PUESTO != "GERENCIA"){
				MessageBox.Show("¡USTED NO TIENE PERMISOS PARA CONSULTAR COMANDAS COBRADAS POR ALGÚN CAJERO!\n","ERROR",MessageBoxButtons.OK,MessageBoxIcon.Error);
				return;
			}
			
			var comandasDeUnCajeroEnElDia = new ComandasCajero(this.WindowState,panelFondo.BackColor);
			comandasDeUnCajeroEnElDia.ShowDialog();
		}
		void ConsultarProductosPorTipoToolStripMenuItemClick(object sender, EventArgs e)
		{

			var consultarProductosTipo = new ConsultarProductosTipo(WindowState,panelFondo.BackColor);
			consultarProductosTipo.ShowDialog();
		}
		void BuscarProductoToolStripMenuItemClick(object sender, EventArgs e)
		{
			var buscarProductos = new BuscarProductos(WindowState,panelFondo.BackColor);
			buscarProductos.ShowDialog();
		}
		void ConsultarProductosPorDisponibilidadToolStripMenuItemClick(object sender, EventArgs e)
		{
			var consultarProductosDisponibilidad = new ConsultarProductosDisponibilidad(WindowState,panelFondo.BackColor);
			consultarProductosDisponibilidad.ShowDialog();
		}
		void ModificarProductosToolStripMenuItemClick(object sender, EventArgs e)
		{
			var modificarProductos = new ModificarProductos(WindowState,panelFondo.BackColor);
			modificarProductos.ShowDialog();
		}
		void ConsultarEmpleadosPorPuestoToolStripMenuItemClick(object sender, EventArgs e)
		{
			var consultarEmpleadosPorPuesto = new ConsultarEmpleadosPuesto(WindowState,panelFondo.BackColor);
			consultarEmpleadosPorPuesto.ShowDialog();
		}
		
		void ModificarEmpleadosToolStripMenuItemClick(object sender, EventArgs e)
		{
			var modificarEmpleados = new ModificarEmpleados(WindowState,panelFondo.BackColor);
			modificarEmpleados.ShowDialog();
		}
		
		void AsignarmeAUnaComandaToolStripMenuItemClick(object sender, EventArgs e)
		{
			if(myEmpleado.PUESTO != "COCINERO" && myEmpleado.PUESTO != "CHEF" && myEmpleado.PUESTO != "ENCARGADO COCINA" && myEmpleado.PUESTO != "GERENCIA"){
				MessageBox.Show("¡USTED NO TIENE PERMISOS PARA ASIGNARSE A UNA COMANDA PARA PREPARACIÓN!\n","ERROR",MessageBoxButtons.OK,MessageBoxIcon.Error);
				return;
			}
			
			var asignarmeAComanda = new AsignarmeComanda(WindowState,panelFondo.BackColor,myEmpleado.ID_EMPLEADO.ToString(),myEmpleado.NOMBRE+" "+myEmpleado.APELLIDO_PATERNO);
			asignarmeAComanda.ShowDialog();
			RecargarNotificaciones();
		}
		void LabelRegresarMouseEnter(object sender, EventArgs e)
		{
			this.labelRegresar.TextAlign = ContentAlignment.MiddleLeft;
		}
		void LabelRegresarMouseLeave(object sender, EventArgs e)
		{
			this.labelRegresar.TextAlign = ContentAlignment.MiddleCenter;
		}
		void ConsultarTodosLosEmpleadosToolStripMenuItemClick(object sender, EventArgs e)
		{
			
			var consultarEmpleados = new ConsultarEmpleados(WindowState,panelFondo.BackColor);
			consultarEmpleados.ShowDialog();
		}
		
		void ModificarComandasToolStripMenuItemClick(object sender, EventArgs e)
		{
			var modificarComandas = new ModificarComanda(WindowState,panelFondo.BackColor,myEmpleado.PUESTO,myEmpleado.ID_EMPLEADO.ToString());
			modificarComandas.ShowDialog();
		}
		void BuscarToolStripMenuItemClick(object sender, EventArgs e)
		{
			
			var buscarComandas = new BuscarTodo(this.WindowState,panelFondo.BackColor);
			buscarComandas.ShowDialog();
		}
		void DataGridViewNotificacionesCellContentClick(object sender, DataGridViewCellEventArgs e)
		{
			if(e.ColumnIndex == 2){
				var myConnection = new MySqlConnection();
				myConnection.ConnectionString = myConnection.ConnectionString="server=localhost;password=; database=sistema_memin; User Id=root";
				myConnection.Open();
				string sentence = "DELETE FROM NOTIFICACIONES WHERE ID_EMPLEADO = "+myEmpleado.ID_EMPLEADO+" AND NOTIFICACION = '"+dataGridViewNotificaciones.Rows[e.RowIndex].Cells["NOTIFICACION"].Value+"';";
				var command = new MySqlCommand(sentence,myConnection);
				command.ExecuteNonQuery();
				command.Dispose();
				myConnection.Close();
				myConnection.Dispose();
				dataGridViewNotificaciones.Rows.RemoveAt(e.RowIndex);
			}
		}
		
		void RecargarNotificaciones(){
			dataGridViewNotificaciones.Rows.Clear();
			var myConnection = new MySqlConnection();
			myConnection.ConnectionString = myConnection.ConnectionString="server=localhost;password=; database=sistema_memin; User Id=root";
			myConnection.Open();
			string sentence = "SELECT NOTIFICACION, FECHA FROM NOTIFICACIONES WHERE ID_EMPLEADO = "+myEmpleado.ID_EMPLEADO+";";
			var command = new MySqlCommand(sentence,myConnection);
			MySqlDataReader myReader;
			myReader = command.ExecuteReader();
			
			if(myReader.Read()){
				if(myReader.GetString(0).Length > 2){
					int renglon = dataGridViewNotificaciones.Rows.Add();
					
					dataGridViewNotificaciones.Rows[renglon].Cells["NOTIFICACION"].Value = myReader.GetString(0);
					dataGridViewNotificaciones.Rows[renglon].Cells["FECHA"].Value = myReader.GetString(1);;
					dataGridViewNotificaciones.Rows[renglon].Cells["LEIDO"].Value = "✔";
				}
				
			}
			
			myConnection.Close();
			command.Dispose();
			myReader.Dispose();
			myConnection.Dispose();
		}
		void ComandasQueTengoAsignadasToolStripMenuItemClick(object sender, EventArgs e)
		{
			if(myEmpleado.PUESTO != "COCINERO" && myEmpleado.PUESTO != "CHEF" && myEmpleado.PUESTO != "ENCARGADO COCINA" && myEmpleado.PUESTO != "GERENCIA"){
				MessageBox.Show("¡USTED NO TIENE PERMISOS PARA CONSULTAR COMANDAS ASIGNADAS!\n","ERROR",MessageBoxButtons.OK,MessageBoxIcon.Error);
				return;
			}
			
			var comandasAsignadas = new ComandasAsignadas(this.WindowState,panelFondo.BackColor,myEmpleado.ID_EMPLEADO);
			comandasAsignadas.ShowDialog();
		}
		
		Color PredominatColor(Bitmap img){
			var diccionario = new Dictionary<Color,int>();
			
			for(int i = 0; i < img.Width;i++){
				for(int j = 0; j < img.Height;j++){
					if(diccionario.ContainsKey(img.GetPixel(i,j))){
						diccionario[img.GetPixel(i,j)] = diccionario[img.GetPixel(i,j)]+1;
					}else{
						diccionario.Add(img.GetPixel(i,j),1);
					}

				}
			}

			return diccionario.OrderByDescending(x => x.Value).ToList().First().Key;

		}
		

	}
}
