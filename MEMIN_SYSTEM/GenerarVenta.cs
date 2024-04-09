/*
 * Creado por SharpDevelop.
 * Usuario: Brian Gaytan Lomeli
 * Fecha: 27/10/2019
 * Hora: 16:55
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
	/// Description of GenerarVenta.
	/// </summary>
	public partial class GenerarVenta : Form
	{
		MySqlConnection myConnection;
		string subtotalInicial = "";
		public GenerarVenta(FormWindowState ws , Color c, string idEmpleado, string nombreEmpleado)
		{
			//
			// The InitializeComponent() call is required for Windows Forms designer support.
			//
			InitializeComponent();
			
			//
			// TODO: Add constructor code after the InitializeComponent() call.
			//
			
			this.textBoxIDEmpleado.Text = idEmpleado;
			textBoxNombreEmpleado.Text = nombreEmpleado;
			this.WindowState = ws;
			this.panelFondo.BackColor = c;
			if(c.R >=240 || c.G >= 240 || c.B >= 240)
				labelTitulo.ForeColor = Color.Black;
			myConnection = new MySqlConnection();
			myConnection.ConnectionString="server=localhost;password=; database=sistema_memin; User Id=root";
		}
		void GenerarVentaFormClosing(object sender, FormClosingEventArgs e)
		{
			myConnection.Dispose();
			this.Dispose();
		}
		void GenerarVentaLoad(object sender, EventArgs e)
		{

			bool seEncontraron = false;
			const string sentencia = "SELECT ID_COMANDA,NOMBRE_CLIENTE,NUMERO_MESA,FECHA_CREACION,ESTATUS,EMPLEADO.ID_EMPLEADO, EMPLEADO.NOMBRE, EMPLEADO.APELLIDO_PATERNO, EMPLEADO.IMAGEN,TABLA1.ID_EMPLEADO, TABLA1.NOMBRE,TABLA1.APELLIDO_PATERNO, TABLA1.IMAGEN FROM COMANDA INNER JOIN EMPLEADO ON COMANDA.ID_EMPLEADO_MESERO = EMPLEADO.ID_EMPLEADO INNER JOIN EMPLEADO AS TABLA1 ON COMANDA.ID_EMPLEADO_COCINA = TABLA1.ID_EMPLEADO  WHERE ESTATUS = 'CERRADA';";
			myConnection.Open();
			var otherCommand = new MySqlCommand(sentencia,myConnection);
			MySqlDataReader myReader;
			myReader = otherCommand.ExecuteReader();
			
			while(myReader.Read()){
				seEncontraron = true;
				int renglon = dataGridViewComandasCerradas.Rows.Add();
				dataGridViewComandasCerradas.Rows[renglon].Cells["ID_COMANDA_CERRADA"].Value = myReader.GetString(0);
				dataGridViewComandasCerradas.Rows[renglon].Cells["NOMBRE_CLIENTE_CERRADA"].Value = myReader.GetString(1);
				dataGridViewComandasCerradas.Rows[renglon].Cells["NUMERO_MESA_CERRADA"].Value = myReader.GetString(2);
				dataGridViewComandasCerradas.Rows[renglon].Cells["FECHA_CREACION_CERRADA"].Value = myReader.GetString(3);
				dataGridViewComandasCerradas.Rows[renglon].Cells["ESTATUS_CERRADA"].Value = myReader.GetString(4);
				dataGridViewComandasCerradas.Rows[renglon].Cells["ID_MESERO_CERRADA"].Value = myReader.GetString(5);
				dataGridViewComandasCerradas.Rows[renglon].Cells["NOMBRE_MESERO_CERRADA"].Value = myReader.GetString(6) + " " + myReader.GetString(7);
				dataGridViewComandasCerradas.Rows[renglon].Cells["IMAGEN_MESERO_CERRADA"].Value = myReader[8];
				dataGridViewComandasCerradas.Rows[renglon].Cells["ID_COCINERO_CERRADA"].Value = myReader.GetString(9);
				dataGridViewComandasCerradas.Rows[renglon].Cells["NOMBRE_COCINERO_CERRADA"].Value = myReader.GetString(10) + " " +myReader.GetString(11);
				dataGridViewComandasCerradas.Rows[renglon].Cells["IMAGEN_COCINERO_CERRADA"].Value = myReader[12];
				dataGridViewComandasCerradas.Rows[renglon].Cells["MOSTRAR_DETALLE_COMANDA"].Value = "✔";
				
				//obtener subtotal y total:
				
				var otherConnection = new  MySqlConnection();
				otherConnection.ConnectionString = "server=localhost;password=;database=sistema_memin; User Id=root";
				string sentence = "SELECT (CANTIDAD * PRECIO_UNITARIO) AS MUL FROM DETALLE_COMANDA WHERE ID_COMANDA = "+myReader.GetString(0)+";";
				otherConnection.Open();
				var comando = new MySqlCommand(sentence,otherConnection);
				MySqlDataReader myLector;
				myLector = comando.ExecuteReader();
				Decimal subtotal = 0;
				while(myLector.Read()){
					subtotal += Decimal.Parse(myLector.GetString(0));
				}
				dataGridViewComandasCerradas.Rows[renglon].Cells["SUBTOTAL_CERRADA"].Value = subtotal;
				dataGridViewComandasCerradas.Rows[renglon].Cells["TOTAL_CERRADA"].Value = ((subtotal*Convert.ToDecimal(0.16)) + subtotal).ToString();
				
				otherConnection.Close();
				myLector.Close();
				myLector.Dispose();
				comando.Dispose();
				otherConnection.Dispose();
				
			}
			
			if(!seEncontraron){
				MessageBox.Show("¡NO HAY COMANDAS CERRADAS HASTA EL MOMENTO!","INFORMACIÓN",MessageBoxButtons.OK,MessageBoxIcon.Information);
			}
		
			myReader.Close();
			myConnection.Close();
			otherCommand.Dispose();
			myReader.Dispose();
		}
		void DataGridViewComandasCerradasCellContentClick(object sender, DataGridViewCellEventArgs e)
		{
			if(e.ColumnIndex == 13){
				//mostrar detalle de comanda
				//mostrar detalle comanda:
				
				dataGridViewDetalleComandaCerrada.Rows.Clear();
				string sentencia = "SELECT D.ID_COMANDA,P.ID_PRODUCTO,P.NOMBRE,P.DESCRIPCION,D.CANTIDAD,D.PRECIO_UNITARIO FROM DETALLE_COMANDA AS D INNER JOIN PRODUCTO AS P ON D.ID_PRODUCTO = P.ID_PRODUCTO WHERE D.ID_COMANDA = "+dataGridViewComandasCerradas.Rows[e.RowIndex].Cells["ID_COMANDA_CERRADA"].Value+";";
				myConnection.Open();
				var otherCommand = new MySqlCommand(sentencia,myConnection);
				MySqlDataReader myReader;
				myReader = otherCommand.ExecuteReader();
				
				while(myReader.Read()){
					int renglon = dataGridViewDetalleComandaCerrada.Rows.Add();
	                dataGridViewDetalleComandaCerrada.Rows[renglon].Cells["ID_COMANDA_DETALLE_COMANDA_CERRADA"].Value =  myReader.GetString(0);
	                dataGridViewDetalleComandaCerrada.Rows[renglon].Cells["ID_PRODUCTO_DETALLE_COMANDA_CERRADA"].Value = myReader.GetString(1);
	                dataGridViewDetalleComandaCerrada.Rows[renglon].Cells["NOMBRE_PRODUCTO_DETALLE_COMANDA_CERRADA"].Value = myReader.GetString(2);
	                dataGridViewDetalleComandaCerrada.Rows[renglon].Cells["DESCRIPCION_DETALLE_COMANDA_CERRADA"].Value = myReader.GetString(3);;
	                dataGridViewDetalleComandaCerrada.Rows[renglon].Cells["CANTIDAD_DETALLE_COMANDA_CERRADA"].Value = myReader.GetString(4);
	                dataGridViewDetalleComandaCerrada.Rows[renglon].Cells["PRECIO_UNITARIO_DETALLE_COMANDA_CERRADA"].Value = myReader.GetString(5);
	                dataGridViewDetalleComandaCerrada.Rows[renglon].Cells["IMPORTE_DETALLE_COMANDA_CERRADA"].Value = Decimal.Parse(myReader.GetString(4)) * Decimal.Parse(myReader.GetString(5));
				}
			
				myReader.Close();
				myConnection.Close();
				otherCommand.Dispose();
				myReader.Dispose();
			}
		}
		void ButtonVerificarIDComandaClick(object sender, EventArgs e)
		{
			dataGridViewComandas.Rows.Clear();
			dataGridViewDetalleComanda.Rows.Clear();

			bool seEncontro = false;
			
			string sentencia = "SELECT ID_COMANDA,NOMBRE_CLIENTE,FECHA_CREACION, NUMERO_MESA,EMPLEADO.ID_EMPLEADO, EMPLEADO.NOMBRE, EMPLEADO.APELLIDO_PATERNO,EMPLEADO.IMAGEN, TABLA1.ID_EMPLEADO, TABLA1.NOMBRE, TABLA1.APELLIDO_PATERNO, TABLA1.IMAGEN FROM COMANDA INNER JOIN EMPLEADO ON COMANDA.ID_EMPLEADO_MESERO = EMPLEADO.ID_EMPLEADO INNER JOIN EMPLEADO AS TABLA1 ON TABLA1.ID_EMPLEADO = COMANDA.ID_EMPLEADO_COCINA WHERE ID_COMANDA = "+numericUpDownIDComandaCobrar.Value+" AND ESTATUS = 'CERRADA';";
			myConnection.Open();
			var otherCommand = new MySqlCommand(sentencia,myConnection);
			MySqlDataReader myReader;
			myReader = otherCommand.ExecuteReader();
			
			if(myReader.Read()){
				seEncontro = true;
				int renglon = dataGridViewComandas.Rows.Add();
                dataGridViewComandas.Rows[renglon].Cells["ID_COMANDA_ENCONTRADA"].Value =  myReader.GetString(0);
                dataGridViewComandas.Rows[renglon].Cells["NOMBRE_CLIENTE"].Value = myReader.GetString(1);
                dataGridViewComandas.Rows[renglon].Cells["FECHA_CREACION"].Value = myReader.GetString(2);
                dataGridViewComandas.Rows[renglon].Cells["ESTATUS"].Value = "CERRADA";
                dataGridViewComandas.Rows[renglon].Cells["NUMERO_MESA"].Value = myReader.GetString(3);
                dataGridViewComandas.Rows[renglon].Cells["ID_MESERO"].Value = myReader.GetString(4);
                dataGridViewComandas.Rows[renglon].Cells["NOMBRE_MESERO"].Value = myReader.GetString(5) + " "+ myReader.GetString(6);
                dataGridViewComandas.Rows[renglon].Cells["IMAGEN_MESERO"].Value = myReader[7];
                dataGridViewComandas.Rows[renglon].Cells["ID_COCINERO"].Value = myReader.GetString(8);
                dataGridViewComandas.Rows[renglon].Cells["NOMBRE_COCINERO"].Value = myReader.GetString(9) + " "+ myReader.GetString(10);
                dataGridViewComandas.Rows[renglon].Cells["IMAGEN_COCINERO"].Value = myReader[11];
                buttonCobrar.Enabled = true;
			}
			else{
				MessageBox.Show("COMANDA NO ENCONTRADA","INFORMACIÓN",MessageBoxButtons.OK,MessageBoxIcon.Information);
				buttonCobrar.Enabled = false;
			}
			
			myConnection.Close();
			myReader.Close();
			myReader.Dispose();
			otherCommand.Dispose();
			myConnection.Dispose();

			if(seEncontro){
				comboBoxFormaPago.Enabled = numericUpDownServicio.Enabled = true;
				Decimal subtotal = 0;
				sentencia = "SELECT TABLA1.ID_COMANDA, TABLA1.ID_PRODUCTO,TABLA2.NOMBRE, TABLA2.DESCRIPCION, TABLA1.CANTIDAD,TABLA1.PRECIO_UNITARIO" +
				" FROM DETALLE_COMANDA TABLA1, PRODUCTO TABLA2 WHERE TABLA1.ID_COMANDA = "+numericUpDownIDComandaCobrar.Value+" AND TABLA2.ID_PRODUCTO = TABLA1.ID_PRODUCTO";
			
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
	                subtotal+= Decimal.Parse(myLector.GetString(4)) * Decimal.Parse(myLector.GetString(5));
				}
				
				textBoxSubtotal.Text = subtotal.ToString();
				textBoxTotal.Text  = ((subtotal*Convert.ToDecimal(0.16)) + subtotal).ToString();
				subtotalInicial = subtotal.ToString();
				textBoxIVA.Text = "16 %";
				
				myConnection.Close();
				myLector.Dispose();
				comando.Dispose();
			
			}
			
		}
		void NumericUpDownServicioValueChanged(object sender, EventArgs e)
		{
			Decimal subtotal = Decimal.Parse(subtotalInicial);
			subtotal+=numericUpDownServicio.Value;
			textBoxSubtotal.Text = subtotal.ToString();
			textBoxTotal.Text  = ((subtotal*Convert.ToDecimal(0.16)) + subtotal).ToString();
		}
		void ButtonCobrarClick(object sender, EventArgs e)
		{
	
			if(comboBoxFormaPago.Text.Length > 1){
				//modificar los campos de la comanda:
				string mes = (DateTime.Now.Month < 10)? "0"+DateTime.Now.Month : DateTime.Now.Month.ToString();
				string dia = (DateTime.Now.Day < 10)? "0"+DateTime.Now.Day : DateTime.Now.Day.ToString();
				string hora = (DateTime.Now.Hour < 10)? "0"+DateTime.Now.Hour : DateTime.Now.Hour.ToString();
				string minuto = (DateTime.Now.Minute < 10)? "0"+DateTime.Now.Minute : DateTime.Now.Minute.ToString();
				string segundo = (DateTime.Now.Second < 10)? "0"+DateTime.Now.Second : DateTime.Now.Second.ToString();
				string fechaCaptura = DateTime.Now.Year + "-"+mes+"-"+dia+" "+hora+":"+minuto+":"+segundo; 
				
				string valueServicio = numericUpDownServicio.Value.ToString();
				valueServicio = valueServicio.Replace(',','.');
				
				string sentencia = "UPDATE COMANDA SET FORMA_PAGO = '"+comboBoxFormaPago.Text+"',ID_EMPLEADO_CAJERO = "+textBoxIDEmpleado.Text+", ESTATUS = 'PAGADA', FECHA_CIERRE = '"+fechaCaptura+"', SERVICIO = "+valueServicio+" WHERE ID_COMANDA = "+numericUpDownIDComandaCobrar.Value+";";
				myConnection.Open();
				var otherCommand = new MySqlCommand(sentencia,myConnection);
				otherCommand.ExecuteNonQuery();
				myConnection.Close();
				otherCommand.Dispose();
				
				//notificar a mesero:
				
				string notificacion = "LA COMANDA CON EL ID "+numericUpDownIDComandaCobrar.Value+" HA SIDO COBRADA POR EL EMPLEADO CON ID: "+textBoxIDEmpleado.Text+" ("+textBoxNombreEmpleado.Text+")";
				
				sentencia = "INSERT INTO NOTIFICACIONES VALUES("+dataGridViewComandas.Rows[0].Cells["ID_MESERO"].Value+",'"+notificacion+"','"+fechaCaptura+"'); ";
				
				myConnection.Open();
				var comando = new MySqlCommand(sentencia,myConnection);
				comando.ExecuteNonQuery();
				myConnection.Close();
				
				//BORRAR NOTIFICACION DEL MISMO CAJERO:
				
				sentencia = "DELETE FROM NOTIFICACIONES WHERE ID_EMPLEADO = "+textBoxIDEmpleado.Text+" AND NOTIFICACION = '¡HAY COMANDA(S) LISTA(S) PARA COBRAR!';";
				
				myConnection.Open();
				comando = new MySqlCommand(sentencia,myConnection);
				comando.ExecuteNonQuery();
				myConnection.Close();
				
				//SI NO HAY COMANDAS PARA COBRAR BORRAR NOTIFICACIONES:
				
				sentencia = "SELECT ID_COMANDA FROM COMANDA WHERE ESTATUS = 'CERRADA';";
				
				myConnection.Open();
				comando = new MySqlCommand(sentencia,myConnection);
				MySqlDataReader myLector = comando.ExecuteReader();
				
				if(!myLector.Read()){
					//se eliminan las notificaciones de los cocineros:
					const string sentensia = "DELETE FROM NOTIFICACIONES WHERE NOTIFICACION = '¡HAY COMANDA(S) LISTA(S) PARA COBRAR!';";
					var otherConnection = new  MySqlConnection();
					otherConnection.ConnectionString = "server=localhost;password=;database=sistema_memin; User Id=root";
					otherConnection.Open();
					var comanda = new MySqlCommand(sentensia,otherConnection);
					comanda.ExecuteNonQuery();
					comanda.Dispose();
					otherConnection.Close();
					otherConnection.Dispose();
				}
				
				myLector.Close();
				myConnection.Close();
				myLector.Dispose();
				comando.Dispose();
	
				MessageBox.Show("¡LA COMANDA HA SIDO PAGADA DE FORMA EXITOSA!","INFORMACIÓN",MessageBoxButtons.OK,MessageBoxIcon.Information);
				
				
				this.Close();
			}
			else{
				MessageBox.Show("INGRESE UNA FORMA DE PAGO ADECUADA","ERROR",MessageBoxButtons.OK,MessageBoxIcon.Error);
			}

		}
	
		
		
	
	
	}
}
