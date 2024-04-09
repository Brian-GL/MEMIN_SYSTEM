/*
 * Creado por SharpDevelop.
 * Usuario: Brian Gaytan Lomeli
 * Fecha: 26/10/2019
 * Hora: 12:32
 * 
 * Para cambiar esta plantilla use Herramientas | Opciones | Codificación | Editar Encabezados Estándar
 */
using System;
using System.Drawing;
using System.Windows.Forms;
using MySql.Data.MySqlClient;
using System.IO;
using System.Drawing.Imaging;

namespace MEMIN_SYSTEM
{
	/// <summary>
	/// Description of BuscarProductos.
	/// </summary>
	public partial class BuscarProductos : Form
	{
		MySqlConnection myConnection;
		public BuscarProductos(FormWindowState ws, Color c)
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
		void BuscarProductosFormClosing(object sender, FormClosingEventArgs e)
		{
			myConnection.Dispose();
			this.Dispose();
		}
		void ButtonBuscarClick(object sender, EventArgs e)
		{
			dataGridViewProductos.Rows.Clear();
			myConnection.ConnectionString = "server=localhost;password=;" +
				"database=sistema_memin; User Id=root";
			string sentence = "SELECT *FROM PRODUCTO WHERE ID_PRODUCTO = "+numericUpDownIDProducto.Value+";";
			var command = new MySqlCommand(sentence,myConnection);
			//var dataAdapter = new MySqlDataAdapter(command);
			myConnection.Open();
			MySqlDataReader myReader;
			myReader = command.ExecuteReader();
			
			if(myReader.Read()){
           
                 int renglon = dataGridViewProductos.Rows.Add();
                 dataGridViewProductos.Rows[renglon].Cells["ID_PRODUCTO"].Value = 
                	myReader.GetInt32(myReader.GetOrdinal("ID_PRODUCTO")).ToString();
                dataGridViewProductos.Rows[renglon].Cells["NOMBRE_PRODUCTO"].Value =
                	myReader.GetString(myReader.GetOrdinal("NOMBRE"));
                dataGridViewProductos.Rows[renglon].Cells["TIPO_PRODUCTO"].Value =
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
                 
                
			}else{
				MessageBox.Show("PRODUCTO NO ENCONTRADO","INFORMACIÓN",MessageBoxButtons.OK,MessageBoxIcon.Information);
			}
         	myConnection.Close();
         	
         	command.Dispose();
		}
		
		public static Image ByteArrayToImage(byte[] byteArrayIn)
	    {
	        var ms = new MemoryStream(byteArrayIn);
	        return Image.FromStream(ms);
	    }
		
		
	}
}
