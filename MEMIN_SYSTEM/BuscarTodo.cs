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
using System.Collections.Generic;
using System.Drawing.Imaging;

namespace MEMIN_SYSTEM
{
	/// <summary>
	/// Description of BuscarComandas.
	/// </summary>
	public partial class BuscarTodo : Form
	{
		MySqlConnection myConnection;
		
		public BuscarTodo(FormWindowState ws, Color c)
		{
			//
			// The InitializeComponent() call is required for Windows Forms designer support.
			//
			InitializeComponent();
			
			//
			// TODO: Add constructor code after the InitializeComponent() call.
			//
			this.WindowState = ws;
			panelFondo.BackColor = c;
			myConnection = new MySqlConnection();
			if(c.R >=240 || c.G >= 240 || c.B >= 240)
				labelTitulo.ForeColor = Color.Black;
		}
		void BuscarComandasFormClosing(object sender, FormClosingEventArgs e)
		{
			myConnection.Dispose();
			this.Dispose();
		}
		void ButtonBuscarProductoClick(object sender, EventArgs e)
		{
			dataGridViewProductos.Rows.Clear();
			myConnection.ConnectionString = "server=localhost;password=;" +
				"database=sistema_memin; User Id=root";
			string sentence = "SELECT *FROM PRODUCTO WHERE ID_PRODUCTO = "+numericUpDownIDProducto.Value+";";
			var command = new MySqlCommand(sentence,myConnection);
			myConnection.Open();
			MySqlDataReader myReader;
			myReader = command.ExecuteReader();
			
			if(myReader.Read()){
				 int renglon = dataGridViewProductos.Rows.Add();
                 dataGridViewProductos.Rows[renglon].Cells["ID_DE_PRODUCTO"].Value = 
                	myReader.GetInt32(myReader.GetOrdinal("ID_PRODUCTO")).ToString();
                dataGridViewProductos.Rows[renglon].Cells["NOMBRE_DE_PRODUCTO"].Value =
                	myReader.GetString(myReader.GetOrdinal("NOMBRE"));
                dataGridViewProductos.Rows[renglon].Cells["TIPO_PRODUCTO"].Value =
                	myReader.GetString(myReader.GetOrdinal("TIPO"));
                dataGridViewProductos.Rows[renglon].Cells["DESCRIPCION"].Value =
                	myReader.GetString(myReader.GetOrdinal("DESCRIPCION"));
                dataGridViewProductos.Rows[renglon].Cells["DISPONIBILIDAD"].Value =
                	myReader.GetString(myReader.GetOrdinal("DISPONIBILIDAD"));
                dataGridViewProductos.Rows[renglon].Cells["OBSERVACIONES_PRODUCTO"].Value =
                	myReader.GetString(myReader.GetOrdinal("OBSERVACIONES"));
                 dataGridViewProductos.Rows[renglon].Cells["COSTO"].Value =
                 	myReader.GetDecimal(myReader.GetOrdinal("COSTO")).ToString();
                 var datos = (byte[])myReader[7];
                 pictureBoxImagenProducto.Image = ByteArrayToImage(datos);

			}else{
				MessageBox.Show("PRODUCTO NO ENCONTRADO","INFORMACIÓN",MessageBoxButtons.OK,MessageBoxIcon.Information);
			}
         	myConnection.Close();
         	myReader.Dispose();
         	command.Dispose();
			
		}
		
		public static Image ByteArrayToImage(byte[] byteArrayIn)
	    {
	        var ms = new MemoryStream(byteArrayIn);
	        return Image.FromStream(ms);
	    }
	
	    public static byte[] ImageToByteArray(Image imageIn)
	    {
	        var ms = new MemoryStream();
	        imageIn.Save(ms, ImageFormat.Jpeg);
	        return ms.ToArray();
	    }
		void ButtonBuscarEmpleadoClick(object sender, EventArgs e)
		{
			dataGridViewEmpleados.Rows.Clear();
			dataGridViewCorreosEmpleado.Rows.Clear();
			dataGridViewTelefonosEmpleado.Rows.Clear();
			myConnection.ConnectionString = "server=localhost;password=;" +
				"database=sistema_memin; User Id=root";
			string sentence = "SELECT *FROM EMPLEADO WHERE ID_EMPLEADO = "+numericUpDownIDEmpleado.Value+";";
			var command = new MySqlCommand(sentence,myConnection);
			myConnection.Open();
			MySqlDataReader myReader;
			myReader = command.ExecuteReader();
			string telefonosEmpleado = "";
			string correosEmpleado ="";
			
			if(myReader.Read()){
				 int renglon = dataGridViewEmpleados.Rows.Add();
                 dataGridViewEmpleados.Rows[renglon].Cells["ID_DEL_EMPLEADO"].Value = 
                	myReader.GetInt32(myReader.GetOrdinal("ID_EMPLEADO")).ToString();
                 dataGridViewEmpleados.Rows[renglon].Cells["NOMBRE_DEL_EMPLEADO"].Value =
                	myReader.GetString(myReader.GetOrdinal("NOMBRE"));
                dataGridViewEmpleados.Rows[renglon].Cells["APELLIDO_PATERNO"].Value =
                	myReader.GetString(myReader.GetOrdinal("APELLIDO_PATERNO"));
                dataGridViewEmpleados.Rows[renglon].Cells["APELLIDO_MATERNO"].Value =
                	myReader.GetString(myReader.GetOrdinal("APELLIDO_MATERNO"));
                dataGridViewEmpleados.Rows[renglon].Cells["PUESTO_DEL_EMPLEADO"].Value =
                	myReader.GetString(myReader.GetOrdinal("PUESTO"));
                
              	  telefonosEmpleado = myReader.GetString(5);
	                correosEmpleado = myReader.GetString(6);
	                
	                obtenerTelefonos(telefonosEmpleado);
	                obtenerCorreos(correosEmpleado);
                
                 var datos = (byte[])myReader[8];
                 pictureBoxImagenEmpleado.Image = ByteArrayToImage(datos);
    
			}else{
				MessageBox.Show("EMPLEADO NO ENCONTRADO","INFORMACIÓN",MessageBoxButtons.OK,MessageBoxIcon.Information);
			}
         	myConnection.Close();
         	myReader.Dispose();
         	command.Dispose();
		}
	
		void obtenerTelefonos(string telephone){
			//empleado: tipo _> 0
			var lista = new List<string>();
			string auxiliar = "";
			for(int i = 0;i < telephone.Length;i++){
				if(telephone[i] == '|'){
					lista.Add(auxiliar);
					auxiliar = "";
				}
				else{
					auxiliar+=telephone[i].ToString();
				}
			}
			
			
			lista.Add(auxiliar);
			
			for(int i = 0; i < lista.Count;i++){
				int renglon = dataGridViewTelefonosEmpleado.Rows.Add();
				dataGridViewTelefonosEmpleado.Rows[renglon].Cells["TELEFONOS_EMPLEADO"].Value = lista[i];
			}
			
			
			lista.Clear();
			
		}
		void obtenerCorreos(string email){
			var lista = new List<string>();
			string auxiliar = "";
			for(int i = 0;i < email.Length;i++){
				if(email[i] == '|'){
					lista.Add(auxiliar);
					auxiliar = "";
				}
				else{
					auxiliar+=email[i].ToString();
				}
			}
			
			lista.Add(auxiliar);
			
			for(int i = 0; i < lista.Count;i++){
				int renglon = dataGridViewCorreosEmpleado.Rows.Add();
				dataGridViewCorreosEmpleado.Rows[renglon].Cells["CORREOS_EMPLEADO"].Value = lista[i];	
			}
			
			lista.Clear();
		}
		void ButtonBuscarComandaClick(object sender, EventArgs e)
		{
			
			myConnection.ConnectionString = "server=localhost;password=;" +
				"database=sistema_memin; User Id=root";
			
			//COMANDA -> TABLA1
			//EMPLEADO -> TABLA2
			
			dataGridViewComandas.Rows.Clear();
			dataGridViewDetalleComanda.Rows.Clear();
			decimal subtotal,servicio;
			subtotal = 0;
			servicio = 0;
			bool seEncontro = false;
			
			//ver el estatus de la comanda:
			
			string sentence = "SELECT ESTATUS FROM COMANDA WHERE ID_COMANDA = "+numericUpDownIDComanda.Value+";";
			myConnection.Open();
			var comanda = new MySqlCommand(sentence,myConnection);
			MySqlDataReader lector = comanda.ExecuteReader();
			
			if(lector.Read()){
				
				string status = lector.GetString(0);
				//otra conexion:
				seEncontro = true;
				
				var otherConnection = new  MySqlConnection();
				otherConnection.ConnectionString = "server=localhost;password=;database=sistema_memin; User Id=root";
				otherConnection.Open();
				if(status == "PEDIDA"){
					string sentencia = "SELECT ID_COMANDA,NOMBRE_CLIENTE,FECHA_CREACION, NUMERO_MESA,EMPLEADO.ID_EMPLEADO, EMPLEADO.NOMBRE, EMPLEADO.APELLIDO_PATERNO, EMPLEADO.IMAGEN FROM COMANDA INNER JOIN EMPLEADO ON COMANDA.ID_EMPLEADO_MESERO = EMPLEADO.ID_EMPLEADO WHERE ID_COMANDA = "+numericUpDownIDComanda.Value+";";
					var otherCommand = new MySqlCommand(sentencia,otherConnection);
					MySqlDataReader myReader;
					myReader = otherCommand.ExecuteReader();
					
					if(myReader.Read()){
						int renglon = dataGridViewComandas.Rows.Add();
		                dataGridViewComandas.Rows[renglon].Cells["ID_COMANDA_ENCONTRADA"].Value =  myReader.GetString(0);
		                dataGridViewComandas.Rows[renglon].Cells["NOMBRE_CLIENTE"].Value = myReader.GetString(1);
		                dataGridViewComandas.Rows[renglon].Cells["FECHA_CREACION"].Value = myReader.GetString(2);
		                dataGridViewComandas.Rows[renglon].Cells["ESTATUS"].Value = status;
		                dataGridViewComandas.Rows[renglon].Cells["NUMERO_MESA"].Value = myReader.GetString(3);
		                dataGridViewComandas.Rows[renglon].Cells["ID_EMPLEADO"].Value = myReader.GetString(4);
		                dataGridViewComandas.Rows[renglon].Cells["NOMBRE_MESERO"].Value = myReader.GetString(5) + " "+ myReader.GetString(6);
		                var datos = (byte[])myReader[7];
                		pictureBoxMeseroComanda.Image = ByteArrayToImage(datos);
						
					}
					else{
						MessageBox.Show("COMANDA NO ENCONTRADA","INFORMACIÓN",MessageBoxButtons.OK,MessageBoxIcon.Information);
					}
					
					otherConnection.Close();
					myReader.Close();
					myReader.Dispose();
					otherCommand.Dispose();
					otherConnection.Dispose();
					
				}
				else if(status == "ASIGNADA A COCINERO" || 
                   status == "EN PREPARACION" || 
                   status == "PREPARADA" ||
                   status == "ENTREGADA" ||
                   status == "RE-PEDIDA" || 
                   status == "RE-ENTREGADA" || 
                   status == "CERRADA"){
					
					string sentencia = "SELECT ID_COMANDA,NOMBRE_CLIENTE,FECHA_CREACION,NUMERO_MESA,EMPLEADO.ID_EMPLEADO, EMPLEADO.NOMBRE, EMPLEADO.APELLIDO_PATERNO,TABLA1.ID_EMPLEADO, TABLA1.NOMBRE,TABLA1.APELLIDO_PATERNO, EMPLEADO.IMAGEN, TABAL1.IMAGEN FROM COMANDA INNER JOIN EMPLEADO ON COMANDA.ID_EMPLEADO_MESERO = EMPLEADO.ID_EMPLEADO INNER JOIN EMPLEADO AS TABLA1 ON COMANDA.ID_EMPLEADO_COCINA = TABLA1.ID_EMPLEADO  WHERE ID_COMANDA = "+numericUpDownIDComanda.Value+"";
					
					var otherCommand = new MySqlCommand(sentencia,otherConnection);
					MySqlDataReader myReader;
					myReader = otherCommand.ExecuteReader();
					
					if(myReader.Read()){
						int renglon = dataGridViewComandas.Rows.Add();
		                dataGridViewComandas.Rows[renglon].Cells["ID_COMANDA_ENCONTRADA"].Value =  myReader.GetString(0);
		                dataGridViewComandas.Rows[renglon].Cells["NOMBRE_CLIENTE"].Value = myReader.GetString(1);
		                dataGridViewComandas.Rows[renglon].Cells["FECHA_CREACION"].Value = myReader.GetString(2);
		                dataGridViewComandas.Rows[renglon].Cells["ESTATUS"].Value = status;
		                dataGridViewComandas.Rows[renglon].Cells["NUMERO_MESA"].Value = myReader.GetString(3);
		                dataGridViewComandas.Rows[renglon].Cells["ID_EMPLEADO"].Value = myReader.GetString(4);
		                dataGridViewComandas.Rows[renglon].Cells["NOMBRE_MESERO"].Value = myReader.GetString(5) + " "+ myReader.GetString(6);	
        				dataGridViewComandas.Rows[renglon].Cells["ID_EMPLEADO_COCINA"].Value =  myReader.GetString(7);
        				dataGridViewComandas.Rows[renglon].Cells["NOMBRE_COCINERO"].Value =  myReader.GetString(8) +" " +myReader.GetString(9);
        				var datos = (byte[])myReader[10];
                		pictureBoxMeseroComanda.Image = ByteArrayToImage(datos);
                		datos = (byte[])myReader[11];
                		pictureBoxCocineroComanda.Image = ByteArrayToImage(datos);
					}
					else{
						MessageBox.Show("COMANDA NO ENCONTRADA","INFORMACIÓN",MessageBoxButtons.OK,MessageBoxIcon.Information);
					}
					
					otherConnection.Close();
					myReader.Close();
					myReader.Dispose();
					otherCommand.Dispose();
					otherConnection.Dispose();
					
					
				}
				else if(status == "PAGADA"){
					
					string sentencia = "SELECT ID_COMANDA,NOMBRE_CLIENTE,FECHA_CREACION, NUMERO_MESA,EMPLEADO.ID_EMPLEADO, EMPLEADO.NOMBRE, EMPLEADO.APELLIDO_PATERNO,TABLA1.ID_EMPLEADO, TABLA1.NOMBRE,TABLA1.APELLIDO_PATERNO, TABLA2.ID_EMPLEADO, TABLA2.NOMBRE,TABLA2.APELLIDO_PATERNO,FECHA_CIERRE,FORMA_PAGO,SERVICIO, EMPLEADO.IMAGEN, TABLA1.IMAGEN, TABLA2.IMAGEN  FROM COMANDA INNER JOIN EMPLEADO ON COMANDA.ID_EMPLEADO_MESERO = EMPLEADO.ID_EMPLEADO INNER JOIN EMPLEADO AS TABLA1 ON COMANDA.ID_EMPLEADO_COCINA = TABLA1.ID_EMPLEADO INNER JOIN EMPLEADO AS TABLA2 ON COMANDA.ID_EMPLEADO_CAJERO = TABLA2.ID_EMPLEADO WHERE ID_COMANDA = "+numericUpDownIDComanda.Value+";";
					
					var otherCommand = new MySqlCommand(sentencia,otherConnection);
					MySqlDataReader myReader;
					myReader = otherCommand.ExecuteReader();
					
					if(myReader.Read()){
						int renglon = dataGridViewComandas.Rows.Add();
		                dataGridViewComandas.Rows[renglon].Cells["ID_COMANDA_ENCONTRADA"].Value =  myReader.GetString(0);
		                dataGridViewComandas.Rows[renglon].Cells["NOMBRE_CLIENTE"].Value = myReader.GetString(1);
		                dataGridViewComandas.Rows[renglon].Cells["FECHA_CREACION"].Value = myReader.GetString(2);
		                dataGridViewComandas.Rows[renglon].Cells["ESTATUS"].Value = status;
		                dataGridViewComandas.Rows[renglon].Cells["NUMERO_MESA"].Value = myReader.GetString(3);
		                dataGridViewComandas.Rows[renglon].Cells["ID_EMPLEADO"].Value = myReader.GetString(4);
		                dataGridViewComandas.Rows[renglon].Cells["NOMBRE_MESERO"].Value = myReader.GetString(5) + " "+ myReader.GetString(6);	
        				dataGridViewComandas.Rows[renglon].Cells["ID_EMPLEADO_COCINA"].Value =  myReader.GetString(7);
        				dataGridViewComandas.Rows[renglon].Cells["NOMBRE_COCINERO"].Value =  myReader.GetString(8) +" " +myReader.GetString(9);
        				dataGridViewComandas.Rows[renglon].Cells["ID_CAJERO"].Value = myReader.GetString(10);
			        	dataGridViewComandas.Rows[renglon].Cells["NOMBRE_CAJERO"].Value = myReader.GetString(11) + " " +myReader.GetString(12);
			        	dataGridViewComandas.Rows[renglon].Cells["FECHA_CIERRE"].Value = myReader.GetString(13);
			        	dataGridViewComandas.Rows[renglon].Cells["FORMA_PAGO"].Value = myReader.GetString(14);
			        	dataGridViewComandas.Rows[renglon].Cells["SERVICIO"].Value = myReader.GetString(15);
			        	servicio = Decimal.Parse(myReader.GetString(15));
			        	var datos = (byte[])myReader[16];
                		pictureBoxMeseroComanda.Image = ByteArrayToImage(datos);
                		datos = (byte[])myReader[17];
                		pictureBoxCocineroComanda.Image = ByteArrayToImage(datos);
                		datos = (byte[])myReader[18];
                		pictureBoxCajeroComanda.Image = ByteArrayToImage(datos);
			        	
					}
					else{
						MessageBox.Show("COMANDA NO ENCONTRADA","INFORMACIÓN",MessageBoxButtons.OK,MessageBoxIcon.Information);
					}
					
					otherConnection.Close();
					myReader.Close();
					myReader.Dispose();
					otherCommand.Dispose();
					otherConnection.Dispose();
					
				}
				
			}else{
				MessageBox.Show("COMANDA NO ENCONTRADA","INFORMACIÓN",MessageBoxButtons.OK,MessageBoxIcon.Information);
				pictureBoxMeseroComanda.Image = pictureBoxCajeroComanda.Image = pictureBoxCocineroComanda.Image = null;
			}
			
			myConnection.Close();
			lector.Dispose();
			comanda.Dispose();
			
			if(seEncontro){
				string sentencia = "SELECT TABLA1.ID_COMANDA, TABLA1.ID_PRODUCTO,TABLA2.NOMBRE, TABLA2.DESCRIPCION, TABLA1.CANTIDAD,TABLA1.PRECIO_UNITARIO, TABLA2.IMAGEN" +
				" FROM DETALLE_COMANDA TABLA1, PRODUCTO TABLA2 WHERE TABLA1.ID_COMANDA = "+numericUpDownIDComanda.Value+" AND TABLA2.ID_PRODUCTO = TABLA1.ID_PRODUCTO";
			
				var comando = new MySqlCommand(sentencia,myConnection);
				myConnection.Open();
				MySqlDataReader myLector;
				myLector = comando.ExecuteReader();
				
				while(myLector.Read()){
					
					int renglon = dataGridViewDetalleComanda.Rows.Add();
	                dataGridViewDetalleComanda.Rows[renglon].Cells["ID_COMANDA"].Value = 
	                	myLector.GetString(0);
	                dataGridViewDetalleComanda.Rows[renglon].Cells["ID_PRODUCTO"].Value = 
	                	myLector.GetString(1);
	                dataGridViewDetalleComanda.Rows[renglon].Cells["NOMBRE_PRODUCTO"].Value = 
	                	myLector.GetString(2);
	                dataGridViewDetalleComanda.Rows[renglon].Cells["CANTIDAD"].Value = 
	                	myLector.GetString(4);
	                dataGridViewDetalleComanda.Rows[renglon].Cells["PRECIO_UNITARIO"].Value = 
	                	myLector.GetString(5);
	                dataGridViewDetalleComanda.Rows[renglon].Cells["DESCRIPCION_PRODUCTO_DETALLE_COMANDA"].Value = 
	                	myLector.GetString(3);
	                dataGridViewDetalleComanda.Rows[renglon].Cells["IMPORTE"].Value = Decimal.Parse(myLector.GetString(4)) * Decimal.Parse(myLector.GetString(5));
	                dataGridViewDetalleComanda.Rows[renglon].Cells["IMAGEN_PRODUCTO_DETALLE_COMANDA"].Value = myLector[6];
	                
	                subtotal += Decimal.Parse(myLector.GetString(4)) * Decimal.Parse(myLector.GetString(5));
				}
				
				
				
				subtotal+= servicio;
				dataGridViewComandas.Rows[0].Cells["SUBTOTAL"].Value = subtotal.ToString();
				dataGridViewComandas.Rows[0].Cells["TOTAL"].Value = ((subtotal*Convert.ToDecimal(0.16)) + subtotal).ToString();
				
				
				myConnection.Close();
				myLector.Dispose();
				comando.Dispose();
			
			}

		}
		

	
	}
}
