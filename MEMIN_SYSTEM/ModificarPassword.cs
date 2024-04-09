/*
 * Creado por SharpDevelop.
 * Usuario: Brian Gaytan Lomeli
 * Fecha: 26/10/2019
 * Hora: 18:04
 * 
 * Para cambiar esta plantilla use Herramientas | Opciones | Codificación | Editar Encabezados Estándar
 */
using System;
using System.Drawing;
using System.Windows.Forms;
using MySql.Data.MySqlClient;


namespace MEMIN_SYSTEM
{
	/// <summary>
	/// Description of ModificarPassword.
	/// </summary>
	public partial class ModificarPassword : Form
	{
		MySqlConnection myConnection;
		public ModificarPassword()
		{
			//
			// The InitializeComponent() call is required for Windows Forms designer support.
			//
			InitializeComponent();
			
			//
			// TODO: Add constructor code after the InitializeComponent() call.
			//
			
			myConnection = new MySqlConnection();
		}
		void ModificarPasswordFormClosing(object sender, FormClosingEventArgs e)
		{
			myConnection.Dispose();
			this.Dispose();
		}
		void ButtonVerificarIDClick(object sender, EventArgs e)
		{
			if(textBoxPassword1.Text.Length < 8){
				MessageBox.Show("LA CONTRASEÑA INGRESADA NO CUMPLE CON EL TAMAÑO APROPIADO DE CARÁCTERES","INFORMACIÓN",MessageBoxButtons.OK,MessageBoxIcon.Information);
				return;
			}
			
			myConnection.ConnectionString = "server=localhost;password=;" +
				"database=sistema_memin; User Id=root";
			string sentence = "SELECT *FROM EMPLEADO WHERE ID_EMPLEADO = "+numericUpDownIDEmpleado.Value+" and Password = '"+textBoxPassword1.Text+"';";
			var command = new MySqlCommand(sentence,myConnection);
			myConnection.Open();
			MySqlDataReader myReader;
			myReader = command.ExecuteReader();
			
			if(myReader.Read()){
				textBoxNombreEmpleado.Text = myReader[1].ToString();
				textBoxPassword3.Enabled = textBoxPassword2.Enabled = true;
				numericUpDownIDEmpleado.Enabled = textBoxPassword1.Enabled = false;
				buttonVerificarID.Enabled = false;
				buttonGuardar.Enabled = true;
			}else{
				MessageBox.Show("EMPLEADO NO ENCONTRADO","INFORMACIÓN",MessageBoxButtons.OK,MessageBoxIcon.Information);
				textBoxPassword1.Text = "";
			}

         	myConnection.Close();
         	myReader.Dispose();
         	command.Dispose();
		}
		void ButtonGuardarClick(object sender, EventArgs e)
		{
			if(textBoxPassword2.Text.Length < 8 || textBoxPassword3.Text.Length < 8){
				MessageBox.Show("ALGUNA DE LAS CONTRASEÑAS INGRESADAS NO CUMPLE CON EL TAMAÑO APROPIADO DE CARÁCTERES","INFORMACIÓN",MessageBoxButtons.OK,MessageBoxIcon.Information);
				return;
			}
			if(textBoxPassword2.Text != textBoxPassword3.Text){
				MessageBox.Show("LAS CONTRASEÑAS NO COINCIDES","INFORMACIÓN",MessageBoxButtons.OK,MessageBoxIcon.Information);
				return;
			}
			
			//revisar ID EMPLEADO:
			
			myConnection.ConnectionString = "server=localhost;password=;" +
				"database=sistema_memin; User Id=root";
         		string sentence = "UPDATE EMPLEADO SET PASSWORD = @PASSWORD WHERE ID_EMPLEADO = "+numericUpDownIDEmpleado.Value+";";
         		var comando = new MySqlCommand(sentence,myConnection);
				myConnection.Open();
				
				comando.Parameters.AddWithValue("@PASSWORD",textBoxPassword2.Text);
				comando.ExecuteNonQuery();
				
				comando.Dispose();
				myConnection.Close();
				MessageBox.Show("MODIFICACIÓN DE CUENTA EXÍTOSA","INFORMACIÓN",MessageBoxButtons.OK,MessageBoxIcon.Information);
         		textBoxPassword3.Text = textBoxPassword2.Text = textBoxPassword1.Text = "";
         		numericUpDownIDEmpleado.Value = 2;
         		
         		textBoxPassword3.Enabled = textBoxPassword2.Enabled = false;
				numericUpDownIDEmpleado.Enabled = textBoxPassword1.Enabled = true;
				buttonVerificarID.Enabled = true;
				buttonGuardar.Enabled = false;
				textBoxNombreEmpleado.Clear();
				textBoxPassword1.Clear();
				textBoxPassword2.Clear();
				textBoxPassword3.Clear();
		}
	}
}
