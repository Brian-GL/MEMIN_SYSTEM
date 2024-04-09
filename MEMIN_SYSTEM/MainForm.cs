/*
 * Creado por SharpDevelop.
 * Usuario: Brian Gaytan Lomeli
 * Fecha: 21/10/2019
 * Hora: 7:25
 * 
 * Para cambiar esta plantilla use Herramientas | Opciones | Codificación | Editar Encabezados Estándar
 */
using System;
using System.Linq;
using System.IO;
using System.Drawing;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace MEMIN_SYSTEM
{
	/// <summary>
	/// Description of MainForm.
	/// </summary>
	/// 
	
	public partial class MainForm : Form
	{
		MySqlConnection myConnection;
		public MainForm(FormWindowState ws)
		{
			//
			// The InitializeComponent() call is required for Windows Forms designer support.
			//
			InitializeComponent();
			
			//
			// TODO: Add constructor code after the InitializeComponent() call.
			//

			myConnection = new MySqlConnection();
			this.WindowState = ws;
			this.toolTipLabelUsuario.SetToolTip(this.labelUsuario, "El usuario representa la cadena de texto que lo identifica\ndentro del negocio y le permite acceder al sistema.");
			this.toolTipLabelPassword.SetToolTip(this.labelPassword,"La contraseña representa la cadena de texto por la cual usted puede\nautentificarse en el sistema, con el fin de controlar su acceso.");
			this.toolTipTextBoxUsuario.SetToolTip(this.numericUpDownIDEmpleado,"Ingrese su usuario en este espacio, recuerde que el usuario es su ID De Empleado.");
			this.toolTipTextBoxPassword.SetToolTip(this.textBoxPassword,"Ingrese su contraseña en este espacio.\nRecuerde respetar mayúsculas y minúsculas.");
			this.toolTipButtonIngresar.SetToolTip(this.buttonIngresar,"Ingrese un click izquierdo en este botón para acceder al sistema.\nRecuerde ingresar bien sus datos, en especial su contraseña, con un número de caracteres mayor o igual a 8. ");
		}
		void MainFormFormClosing(object sender, FormClosingEventArgs e){
			myConnection.Dispose();
			this.Dispose();
		}
		void ButtonIngresarClick(object sender, EventArgs e)
		{
			//BUSCAR EMPLEADO
			
			if(textBoxPassword.Text.Length <= 3){
				MessageBox.Show("LA CONTRASEÑA INGRESADA TIENE UNA CANTIDAD DE CARACTERES INCORRECTA","INFORMACIÓN",MessageBoxButtons.OK,MessageBoxIcon.Information);
				return;
			}
			
			myConnection.ConnectionString = "server=localhost;password= ;database=sistema_memin; User Id=root";
			string sentence = "SELECT *FROM EMPLEADO WHERE ID_EMPLEADO = "+numericUpDownIDEmpleado.Value+" and PASSWORD = '"+textBoxPassword.Text+"';";
			var command = new MySqlCommand(sentence,myConnection);
			myConnection.Open();
			MySqlDataReader myReader;
			myReader = command.ExecuteReader();
			var empleado = new Empleado();
			bool entra = false;
			
			if(myReader.Read()){
				entra = true;
				var datos = (byte[])myReader[8];
				empleado.ID_EMPLEADO = Convert.ToInt32(numericUpDownIDEmpleado.Value);
				empleado.NOMBRE = myReader[1].ToString();
				empleado.APELLIDO_PATERNO = myReader[2].ToString();
				empleado.PUESTO = myReader[4].ToString();
				empleado.IMAGEN = ByteArrayToImage(datos);
				
			}else{
				MessageBox.Show("EMPLEADO NO ENCONTRADO","INFORMACIÓN",MessageBoxButtons.OK,MessageBoxIcon.Information);
				textBoxPassword.Clear();
			}
			
			myConnection.Close();
			command.Dispose();
			myReader.Dispose();
			
			if(entra){			
				var menuPrincipal = new MenuPrincipal(this.WindowState,empleado);
				this.Close();
				menuPrincipal.ShowDialog();
			}			
			
		}
		void CheckBoxShowPasswordCheckedChanged(object sender, EventArgs e)
		{
			textBoxPassword.UseSystemPasswordChar = checkBoxShowPassword.Checked;
		}
		void LinkLabelNoTienesCuentaLinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
		{
			var crearCuenta = new CrearCuenta();
			crearCuenta.ShowDialog();
		}
		void LinkLabelModificarPasswordLinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
		{
			var modificarPassword = new ModificarPassword();
			modificarPassword.ShowDialog();
		}

		public static Image ByteArrayToImage(byte[] byteArrayIn)
	    {
	        var ms = new MemoryStream(byteArrayIn);
	        return Image.FromStream(ms);
	    }
		void TextBoxPasswordKeyDown(object sender, KeyEventArgs e)
		{
			if(e.KeyCode == Keys.Enter){
				if(textBoxPassword.Text.Length <= 3){
					MessageBox.Show("LA CONTRASEÑA INGRESADA TIENE UNA CANTIDAD DE CARACTERES INCORRECTA","INFORMACIÓN",MessageBoxButtons.OK,MessageBoxIcon.Information);
					return;
				}
				
				
				myConnection.ConnectionString = "server=localhost;password= ;database=sistema_memin; User Id=root";
				string sentence = "SELECT *FROM EMPLEADO WHERE ID_EMPLEADO = "+numericUpDownIDEmpleado.Value+" and PASSWORD = '"+textBoxPassword.Text+"';";
				var command = new MySqlCommand(sentence,myConnection);
				myConnection.Open();
				MySqlDataReader myReader;
				myReader = command.ExecuteReader();
				var empleado = new Empleado();
				bool entra = false;
				
				if(myReader.Read()){
					entra = true;
					var datos = (byte[])myReader[8];
					empleado.ID_EMPLEADO = Convert.ToInt32(numericUpDownIDEmpleado.Value);
					empleado.NOMBRE = myReader[1].ToString();
					empleado.APELLIDO_PATERNO = myReader[2].ToString();
					empleado.PUESTO = myReader[4].ToString();
					empleado.IMAGEN = ByteArrayToImage(datos);
					
				}else{
					MessageBox.Show("EMPLEADO NO ENCONTRADO","INFORMACIÓN",MessageBoxButtons.OK,MessageBoxIcon.Information);
					textBoxPassword.Clear();
				}
				
				myConnection.Close();
				command.Dispose();
				myReader.Dispose();
				
				if(entra){			
					var menuPrincipal = new MenuPrincipal(this.WindowState,empleado);
					this.Close();
					menuPrincipal.ShowDialog();
				}
			}
		}
		
		

	}
}
