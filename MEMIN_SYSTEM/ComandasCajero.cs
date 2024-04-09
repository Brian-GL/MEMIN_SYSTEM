/*
 * Creado por SharpDevelop.
 * Usuario: Brian Gaytan Lomeli
 * Fecha: 27/10/2019
 * Hora: 17:20
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
	/// Description of ComandasDeUnCajeroEnElDia.
	/// </summary>
	public partial class ComandasCajero : Form
	{
		MySqlConnection myConnection;
		public ComandasCajero(FormWindowState ws, Color c)
		{
			//
			// The InitializeComponent() call is required for Windows Forms designer support.
			//
			InitializeComponent();
			
			//
			// TODO: Add constructor code after the InitializeComponent() call.
			//
			myConnection = new MySqlConnection();
			myConnection.ConnectionString = "server=localhost;password=;database=sistema_memin; User Id=root";
			this.WindowState = ws;
			this.panelFondo.BackColor = c;
			if(c.R >=240 || c.G >= 240 || c.B >= 240)
				labelTitulo.ForeColor = Color.Black;
			
		}
		void ComandasDeUnCajeroEnElDiaFormClosing(object sender, FormClosingEventArgs e)
		{
			myConnection.Dispose();
			Dispose();
		}
		void ButtonBuscarClick(object sender, EventArgs e)
		{
			dataGridViewComandas.Rows.Clear();
			dataGridViewDetalleComanda.Rows.Clear();
			decimal subtotal,servicio,totalComandas = 0;
			subtotal = 0;
			servicio = 0;
			bool seEncontro = false;
			int cont = 0;
			//ver el estatus de la comanda:
			
			string mes = (DateTime.Now.Month < 10)? "0"+DateTime.Now.Month : DateTime.Now.Month.ToString();
			string dia = (DateTime.Now.Day < 10)? "0"+DateTime.Now.Day : DateTime.Now.Day.ToString();
			string fechaInicio = DateTime.Now.Year + "-"+mes+"-"+dia+" 00:00:00";
			string fechaFin = DateTime.Now.Year + "-"+mes+"-"+dia+" 23:59:59";
			
			
			string sentence = "SELECT ID_COMANDA,ESTATUS FROM COMANDA WHERE ID_EMPLEADO_CAJERO= "+numericUpDownIDCajero.Value+" and fecha_creacion between '"+fechaInicio+"' and '"+fechaFin+"' ;";
			//string sentence = "SELECT ID_COMANDA,ESTATUS FROM COMANDA WHERE ID_EMPLEADO_CAJERO= "+numericUpDownIDCajero.Value+";";
			myConnection.Open();
			var comanda = new MySqlCommand(sentence,myConnection);
			MySqlDataReader lector = comanda.ExecuteReader();
			
			while(lector.Read()){
				subtotal = 0;
				servicio = 0;
				string status = lector.GetString(1);
				string idcomanda = lector.GetString(0);
				//otra conexion:
				seEncontro = true;
				
				var otherConnection = new  MySqlConnection();
				otherConnection.ConnectionString = "server=localhost;password=;database=sistema_memin; User Id=root";
				otherConnection.Open();
				if(status == "PEDIDA"){
					string sentencia = "SELECT ID_COMANDA,NOMBRE_CLIENTE,FECHA_CREACION, NUMERO_MESA,EMPLEADO.ID_EMPLEADO, EMPLEADO.NOMBRE, EMPLEADO.APELLIDO_PATERNO FROM COMANDA INNER JOIN EMPLEADO ON COMANDA.ID_EMPLEADO_MESERO = EMPLEADO.ID_EMPLEADO WHERE ID_COMANDA = "+idcomanda+";";
					var otherCommand = new MySqlCommand(sentencia,otherConnection);
					MySqlDataReader myReader;
					myReader = otherCommand.ExecuteReader();
					if(myReader.Read()){
						int renglon = dataGridViewComandas.Rows.Add();
						dataGridViewComandas.Rows[renglon].Cells["NUMERO_COMANDA"].Value = (renglon+1).ToString();
		                dataGridViewComandas.Rows[renglon].Cells["ID_COMANDA_ENCONTRADA"].Value =  myReader.GetString(0);
		                dataGridViewComandas.Rows[renglon].Cells["NOMBRE_CLIENTE"].Value = myReader.GetString(1);
		                dataGridViewComandas.Rows[renglon].Cells["FECHA_CREACION"].Value = myReader.GetString(2);
		                dataGridViewComandas.Rows[renglon].Cells["ESTATUS"].Value = status;
		                dataGridViewComandas.Rows[renglon].Cells["NUMERO_MESA"].Value = myReader.GetString(3);
		                dataGridViewComandas.Rows[renglon].Cells["ID_EMPLEADO"].Value = myReader.GetString(4);
		                dataGridViewComandas.Rows[renglon].Cells["NOMBRE_MESERO"].Value = myReader.GetString(5) + " "+ myReader.GetString(6);
		                dataGridViewComandas.Rows[renglon].Cells["MOSTRAR_DETALLE_COMANDA"].Value = "✔";
						
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
					
					string sentencia = "SELECT ID_COMANDA,NOMBRE_CLIENTE,FECHA_CREACION,NUMERO_MESA,EMPLEADO.ID_EMPLEADO, EMPLEADO.NOMBRE, EMPLEADO.APELLIDO_PATERNO,TABLA1.ID_EMPLEADO, TABLA1.NOMBRE,TABLA1.APELLIDO_PATERNO FROM COMANDA INNER JOIN EMPLEADO ON COMANDA.ID_EMPLEADO_MESERO = EMPLEADO.ID_EMPLEADO INNER JOIN EMPLEADO AS TABLA1 ON COMANDA.ID_EMPLEADO_COCINA = TABLA1.ID_EMPLEADO  WHERE ID_COMANDA = "+idcomanda+"";
					
					var otherCommand = new MySqlCommand(sentencia,otherConnection);
					MySqlDataReader myReader;
					myReader = otherCommand.ExecuteReader();
					
					if(myReader.Read()){
						int renglon = dataGridViewComandas.Rows.Add();
						dataGridViewComandas.Rows[renglon].Cells["NUMERO_COMANDA"].Value = (renglon+1).ToString();
		                dataGridViewComandas.Rows[renglon].Cells["ID_COMANDA_ENCONTRADA"].Value =  myReader.GetString(0);
		                dataGridViewComandas.Rows[renglon].Cells["NOMBRE_CLIENTE"].Value = myReader.GetString(1);
		                dataGridViewComandas.Rows[renglon].Cells["FECHA_CREACION"].Value = myReader.GetString(2);
		                dataGridViewComandas.Rows[renglon].Cells["ESTATUS"].Value = status;
		                dataGridViewComandas.Rows[renglon].Cells["NUMERO_MESA"].Value = myReader.GetString(3);
		                dataGridViewComandas.Rows[renglon].Cells["ID_EMPLEADO"].Value = myReader.GetString(4);
		                dataGridViewComandas.Rows[renglon].Cells["NOMBRE_MESERO"].Value = myReader.GetString(5) + " "+ myReader.GetString(6);	
        				dataGridViewComandas.Rows[renglon].Cells["ID_EMPLEADO_COCINA"].Value =  myReader.GetString(7);
        				dataGridViewComandas.Rows[renglon].Cells["NOMBRE_COCINERO"].Value =  myReader.GetString(8) +" " +myReader.GetString(9);
        				dataGridViewComandas.Rows[renglon].Cells["MOSTRAR_DETALLE_COMANDA"].Value = "✔";
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
					
					string sentencia = "SELECT ID_COMANDA,NOMBRE_CLIENTE,FECHA_CREACION, NUMERO_MESA,EMPLEADO.ID_EMPLEADO, EMPLEADO.NOMBRE, EMPLEADO.APELLIDO_PATERNO,TABLA1.ID_EMPLEADO, TABLA1.NOMBRE,TABLA1.APELLIDO_PATERNO, TABLA2.ID_EMPLEADO, TABLA2.NOMBRE,TABLA2.APELLIDO_PATERNO,FECHA_CIERRE,FORMA_PAGO,SERVICIO  FROM COMANDA INNER JOIN EMPLEADO ON COMANDA.ID_EMPLEADO_MESERO = EMPLEADO.ID_EMPLEADO INNER JOIN EMPLEADO AS TABLA1 ON COMANDA.ID_EMPLEADO_COCINA = TABLA1.ID_EMPLEADO INNER JOIN EMPLEADO AS TABLA2 ON COMANDA.ID_EMPLEADO_CAJERO = TABLA2.ID_EMPLEADO WHERE ID_COMANDA = "+idcomanda+";";
					var otherCommand = new MySqlCommand(sentencia,otherConnection);
					MySqlDataReader myReader;
					myReader = otherCommand.ExecuteReader();
					
					if(myReader.Read()){
						int renglon = dataGridViewComandas.Rows.Add();
						dataGridViewComandas.Rows[renglon].Cells["NUMERO_COMANDA"].Value = (renglon+1).ToString();
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
			        	dataGridViewComandas.Rows[renglon].Cells["MOSTRAR_DETALLE_COMANDA"].Value = "✔";
			        	
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
				

				//obtener el subtotal y total:
				var conexion = new  MySqlConnection();
				conexion.ConnectionString = "server=localhost;password=;database=sistema_memin; User Id=root";
				string sentencie = "SELECT (CANTIDAD * PRECIO_UNITARIO) AS MUL FROM DETALLE_COMANDA WHERE ID_COMANDA = "+idcomanda+";";
				conexion.Open();
				var comando = new MySqlCommand(sentencie,conexion);
				MySqlDataReader myLector;
				myLector = comando.ExecuteReader();
				
				while(myLector.Read())
					subtotal += Decimal.Parse(myLector.GetString(0));
				
				conexion.Close();
				conexion.Dispose();
				comando.Dispose();
				myLector.Close();
				myLector.Dispose();
				dataGridViewComandas.Rows[cont].Cells["SUBTOTAL_COMANDA"].Value = subtotal + servicio;
				dataGridViewComandas.Rows[cont].Cells["TOTAL_COMANDA"].Value = ((subtotal*Convert.ToDecimal(0.16)) + subtotal).ToString();
				totalComandas+= Decimal.Parse(dataGridViewComandas.Rows[cont].Cells["TOTAL_COMANDA"].Value.ToString());
				cont++;
			}
			
			if(!seEncontro){
				MessageBox.Show("COMANDAS NO ENCONTRADAS","INFORMACIÓN",MessageBoxButtons.OK,MessageBoxIcon.Information);
			}
			
			
			textBoxTotalComandas.Text = totalComandas.ToString();
			myConnection.Close();
			lector.Dispose();
			comanda.Dispose();	
		}
		void DataGridViewComandasCellContentClick(object sender, DataGridViewCellEventArgs e)
		{
			if(e.ColumnIndex == 17){
				//mostrar detalle comanda:
				
				dataGridViewDetalleComanda.Rows.Clear();
				string sentencia = "SELECT D.ID_COMANDA,P.ID_PRODUCTO,P.NOMBRE,P.DESCRIPCION,D.CANTIDAD,D.PRECIO_UNITARIO FROM DETALLE_COMANDA AS D INNER JOIN PRODUCTO AS P ON D.ID_PRODUCTO = P.ID_PRODUCTO WHERE D.ID_COMANDA = "+dataGridViewComandas.Rows[e.RowIndex].Cells["ID_COMANDA_ENCONTRADA"].Value+";";
				myConnection.Open();
				var otherCommand = new MySqlCommand(sentencia,myConnection);
				MySqlDataReader myReader;
				myReader = otherCommand.ExecuteReader();
				
				while(myReader.Read()){
					int renglon = dataGridViewDetalleComanda.Rows.Add();
	                dataGridViewDetalleComanda.Rows[renglon].Cells["ID_COMANDA"].Value =  myReader.GetString(0);
	                dataGridViewDetalleComanda.Rows[renglon].Cells["ID_PRODUCTO"].Value = myReader.GetString(1);
	                dataGridViewDetalleComanda.Rows[renglon].Cells["NOMBRE_PRODUCTO"].Value = myReader.GetString(2);
	                dataGridViewDetalleComanda.Rows[renglon].Cells["DESCRIPCION_PRODUCTO_DETALLE"].Value = myReader.GetString(3);;
	                dataGridViewDetalleComanda.Rows[renglon].Cells["CANTIDAD"].Value = myReader.GetString(4);
	                dataGridViewDetalleComanda.Rows[renglon].Cells["PRECIO_UNITARIO"].Value = myReader.GetString(5);
	                dataGridViewDetalleComanda.Rows[renglon].Cells["IMPORTE"].Value = Decimal.Parse(myReader.GetString(4)) * Decimal.Parse(myReader.GetString(5));
				}
			
				myReader.Close();
				myConnection.Close();
				otherCommand.Dispose();
				myReader.Dispose();
			}
			
		}
		

		
	
	}
}
