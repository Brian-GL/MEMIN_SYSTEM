/*
 * Creado por SharpDevelop.
 * Usuario: Brian Gaytan Lomeli
 * Fecha: 26/10/2019
 * Hora: 11:50
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
	/// Description of ConsultarProductosTipo.
	/// </summary>
	public partial class ConsultarProductosTipo : Form
	{
		MySqlConnection myConnection;
		public ConsultarProductosTipo(FormWindowState ws, Color c)
		{
			//
			// The InitializeComponent() call is required for Windows Forms designer support.
			//
			InitializeComponent();
			
			//
			// TODO: Add constructor code after the InitializeComponent() call.
			//
			this.WindowState = ws;
			this.panelFondo.BackColor = c;
			if(c.R >=240 || c.G >= 240 || c.B >= 240)
				labelTitulo.ForeColor = Color.Black;
			myConnection = new MySqlConnection();
			
		}
		void ConsultarProductosTipoFormClosing(object sender, FormClosingEventArgs e)
		{
			myConnection.Dispose();
			this.Dispose();
		}
		
		void ButtonConsultarClick(object sender, EventArgs e)
		{
			if(comboBoxTipo.SelectedItem.ToString() != "MARISCOS"
			   && comboBoxTipo.SelectedItem.ToString() != "JAPONESA"
			  && comboBoxTipo.SelectedItem.ToString() != "BEBIDA"
			   && comboBoxTipo.SelectedItem.ToString() != "POSTRE"){
				MessageBox.Show("TIPO ERRÓNEO, ¡SELECCIONE UNO CORRECTAMENTE!","ERROR",MessageBoxButtons.OK,MessageBoxIcon.Error);
				return;
			}
			
			bool seEncontraron = false;
			dataGridViewProductos.Rows.Clear();
			myConnection.ConnectionString = "server=localhost;password=;" +
				"database=sistema_memin; User Id=root";
			string sentence = "SELECT *FROM PRODUCTO WHERE TIPO = '"+comboBoxTipo.SelectedItem+"';";
			var command = new MySqlCommand(sentence,myConnection);
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
         	myConnection.Close();
         	myReader.Dispose();
         	command.Dispose();
         	
         	if(!seEncontraron)
				MessageBox.Show("¡NO HAY PRODUCTOS REGISTRADOS CON TAL TIPO HASTA EL MOMENTO!","INFORMACIÓN",MessageBoxButtons.OK,MessageBoxIcon.Exclamation);
		}
		

		
	}
}
