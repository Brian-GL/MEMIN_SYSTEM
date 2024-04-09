/*
 * Creado por SharpDevelop.
 * Usuario: Brian Gaytan Lomeli
 * Fecha: 26/10/2019
 * Hora: 13:01
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
	/// Description of ConsultarEmpleados.
	/// </summary>
	public partial class ConsultarEmpleados : Form
	{
		MySqlConnection myConnection;
		public ConsultarEmpleados(FormWindowState ws, Color c)
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
			this.panelFondo.BackColor = c;
			if(c.R >=240 || c.G >= 240 || c.B >= 240)
				labelTitulo.ForeColor = Color.Black;
		}
	
		void ConsultarEmpleadosFormClosing(object sender, FormClosingEventArgs e)
		{
			myConnection.Dispose();
			this.Dispose();
		}
		void ConsultarEmpleadosLoad(object sender, EventArgs e)
		{
			dataGridViewEmpleados.Rows.Clear();
			bool seEncontraron = false;
			myConnection.ConnectionString = "server=localhost;password=;" +
				"database=sistema_memin; User Id=root";
			const string sentence = "SELECT *FROM EMPLEADO WHERE ID_EMPLEADO > 1";
			var command = new MySqlCommand(sentence,myConnection);
			myConnection.Open();
			MySqlDataReader myReader;
			myReader = command.ExecuteReader();
			
			while(myReader.Read()){
				seEncontraron = true;
            	int renglon = dataGridViewEmpleados.Rows.Add();
             	dataGridViewEmpleados.Rows[renglon].Cells["ID_EMPLEADO"].Value = 
                	myReader.GetInt32(myReader.GetOrdinal("ID_EMPLEADO")).ToString();
                dataGridViewEmpleados.Rows[renglon].Cells["NOMBRE"].Value =
                	myReader.GetString(myReader.GetOrdinal("NOMBRE"));
                dataGridViewEmpleados.Rows[renglon].Cells["APELLIDO_PATERNO"].Value =
                	myReader.GetString(myReader.GetOrdinal("APELLIDO_PATERNO"));
                dataGridViewEmpleados.Rows[renglon].Cells["APELIIDO_MATERNO"].Value =
                	myReader.GetString(myReader.GetOrdinal("APELLIDO_MATERNO"));
                dataGridViewEmpleados.Rows[renglon].Cells["PUESTO"].Value =
                	myReader.GetString(myReader.GetOrdinal("PUESTO"));
                  dataGridViewEmpleados.Rows[renglon].Cells["IMAGEN"].Value =
                  	myReader[8];
              
			}
         	myConnection.Close();
         	myReader.Dispose();
         	command.Dispose();
         	
         	if(!seEncontraron)
         		MessageBox.Show("¡NO HAY EMPLEADOS REGISTRADOS HASTA EL MOMENTO!","INFORMACIÓN",MessageBoxButtons.OK,MessageBoxIcon.Exclamation);
		}
		

	}
}
