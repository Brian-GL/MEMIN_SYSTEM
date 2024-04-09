/*
 * Creado por SharpDevelop.
 * Usuario: Brian Gaytan Lomeli
 * Fecha: 21/10/2019
 * Hora: 11:51
 * 
 * Para cambiar esta plantilla use Herramientas | Opciones | Codificación | Editar Encabezados Estándar
 */
using System;
using System.Drawing;
using System.Windows.Forms;
using System.IO;
using MySql.Data.MySqlClient;
using System.Data;

namespace MEMIN_SYSTEM
{
	/// <summary>
	/// Description of ConsultarProductos.
	/// </summary>
	public partial class ConsultarProductos : Form
	{
		MySqlConnection myConnection;
		public ConsultarProductos(FormWindowState ws, Color c)
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
		void ConsultarProductosFormClosing(object sender, FormClosingEventArgs e)
		{
			myConnection.Dispose();
			this.Dispose();
			
		}
		
		void ConsultarProductosLoad(object sender, EventArgs e)
		{
						
			dataGridViewProductos.Rows.Clear();
			bool seEncontraron = false;
			myConnection.ConnectionString = "server=localhost;password=;" +
				"database=sistema_memin; User Id=root";
			const string sentence = "SELECT *FROM PRODUCTO";
			var command = new MySqlCommand(sentence,myConnection);
			//var dataAdapter = new MySqlDataAdapter(command);
			myConnection.Open();
			MySqlDataReader myReader;
			myReader = command.ExecuteReader();
			
			while(myReader.Read()){
				seEncontraron = true;
            int renglon = dataGridViewProductos.Rows.Add();
             dataGridViewProductos.Rows[renglon].Cells["ID_PRODUCTO"].Value = 
                	myReader.GetInt32(myReader.GetOrdinal("ID_PRODUCTO")).ToString();
                dataGridViewProductos.Rows[renglon].Cells["NOMBRE"].Value =
                	myReader.GetString(myReader.GetOrdinal("NOMBRE"));
                dataGridViewProductos.Rows[renglon].Cells["TIPO"].Value =
                	myReader.GetString(myReader.GetOrdinal("TIPO"));
                dataGridViewProductos.Rows[renglon].Cells["DESCRIPCION"].Value =
                	myReader.GetString(myReader.GetOrdinal("DESCRIPCION"));
                dataGridViewProductos.Rows[renglon].Cells["DISPONIBILIDAD"].Value =
                	myReader.GetString(myReader.GetOrdinal("DISPONIBILIDAD"));
                dataGridViewProductos.Rows[renglon].Cells["OBSERVACIONES"].Value =
                	myReader.GetString(myReader.GetOrdinal("OBSERVACIONES"));
                 dataGridViewProductos.Rows[renglon].Cells["COSTO"].Value =
                 	myReader.GetDecimal(myReader.GetOrdinal("COSTO")).ToString();
                  dataGridViewProductos.Rows[renglon].Cells["IMAGEN"].Value =
                  	myReader[7];
              
			}
			
			if(!seEncontraron)
				MessageBox.Show("¡NO HAY PRODUCTOS REGISTRADOS HASTA EL MOMENTO!","INFORMACIÓN",MessageBoxButtons.OK,MessageBoxIcon.Exclamation);
				
         	myConnection.Close();
         	myReader.Dispose();
         	command.Dispose();
         	
		}
		
	}
}
