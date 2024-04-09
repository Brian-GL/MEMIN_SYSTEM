/*
 * Creado por SharpDevelop.
 * Usuario: Brian Gaytan Lomeli
 * Fecha: 27/10/2019
 * Hora: 13:22
 * 
 * Para cambiar esta plantilla use Herramientas | Opciones | Codificación | Editar Encabezados Estándar
 */
using System;
using System.Drawing;
using System.Windows.Forms;
using MySql.Data.MySqlClient;
using System.IO;

namespace MEMIN_SYSTEM
{
	/// <summary>
	/// Description of AsignarmeComanda.
	/// </summary>
	public partial class AsignarmeComanda : Form
	{
		MySqlConnection myConnection;
		public AsignarmeComanda(FormWindowState ws,Color c,string idEmpleado,string nombreEmpleado)
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
			myConnection = new MySqlConnection();
			myConnection.ConnectionString="server=localhost;password=; database=sistema_memin; User Id=root";
			textBoxIDEmpleado.Text = idEmpleado;
			textBoxNombreEmpleado.Text = nombreEmpleado;
			if(c.R >=240 || c.G >= 240 || c.B >= 240)
			{
				labelTitulo.ForeColor = Color.Black;
			}
			
		
		}
		void AsignarmeComandaFormClosing(object sender, FormClosingEventArgs e)
		{
			myConnection.Dispose();
			this.Dispose();
		}
		
		public static Image ByteArrayToImage(byte[] byteArrayIn)
	    {
	        var ms = new MemoryStream(byteArrayIn);
	        return Image.FromStream(ms);
	    }
	

		void ButtonVerificarIDComandaClick(object sender, EventArgs e)
		{
			//Buscar comanda:
			
			dataGridViewComandas.Rows.Clear();
			dataGridViewDetalleComanda.Rows.Clear();

			bool seEncontro = false;
			
			string sentencia = "SELECT ID_COMANDA,NOMBRE_CLIENTE,FECHA_CREACION, NUMERO_MESA,EMPLEADO.ID_EMPLEADO, EMPLEADO.NOMBRE, EMPLEADO.APELLIDO_PATERNO,EMPLEADO.IMAGEN FROM COMANDA INNER JOIN EMPLEADO ON COMANDA.ID_EMPLEADO_MESERO = EMPLEADO.ID_EMPLEADO WHERE ID_COMANDA = "+numericUpDownIDComanda.Value+" AND ESTATUS = 'PEDIDA';";
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
                dataGridViewComandas.Rows[renglon].Cells["ESTATUS"].Value = "PEDIDA";
                dataGridViewComandas.Rows[renglon].Cells["NUMERO_MESA"].Value = myReader.GetString(3);
                dataGridViewComandas.Rows[renglon].Cells["ID_EMPLEADO"].Value = myReader.GetString(4);
                dataGridViewComandas.Rows[renglon].Cells["NOMBRE_MESERO"].Value = myReader.GetString(5) + " "+ myReader.GetString(6);
                dataGridViewComandas.Rows[renglon].Cells["IMAGEN_MESERO"].Value = myReader[7];
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
				sentencia = "SELECT TABLA1.ID_COMANDA, TABLA1.ID_PRODUCTO,TABLA2.NOMBRE, TABLA2.DESCRIPCION, TABLA1.CANTIDAD,TABLA1.PRECIO_UNITARIO" +
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
				}
				
				myConnection.Close();
				myLector.Dispose();
				comando.Dispose();
			
			}
			
		}
		void AsignarmeComandaLoad(object sender, EventArgs e)
		{	
			bool seEncontraron = false;
			const string sentencia = "SELECT ID_COMANDA,NOMBRE_CLIENTE,FECHA_CREACION,ESTATUS,NUMERO_MESA,EMPLEADO.ID_EMPLEADO, EMPLEADO.NOMBRE, EMPLEADO.APELLIDO_PATERNO, EMPLEADO.IMAGEN FROM COMANDA INNER JOIN EMPLEADO ON COMANDA.ID_EMPLEADO_MESERO = EMPLEADO.ID_EMPLEADO WHERE ESTATUS = 'PEDIDA';";
			myConnection.Open();
			var otherCommand = new MySqlCommand(sentencia,myConnection);
			MySqlDataReader myReader;
			myReader = otherCommand.ExecuteReader();
			
			while(myReader.Read()){
				seEncontraron = true;
				int renglon = dataGridViewComandasPedidas.Rows.Add();
                dataGridViewComandasPedidas.Rows[renglon].Cells["ID_COMANDA_PEDIDA"].Value =  myReader.GetString(0);
                dataGridViewComandasPedidas.Rows[renglon].Cells["NOMBRE_CLIENTE_PEDIDA"].Value = myReader.GetString(1);
                dataGridViewComandasPedidas.Rows[renglon].Cells["FECHA_CREACION_PEDIDA"].Value = myReader.GetString(2);
                dataGridViewComandasPedidas.Rows[renglon].Cells["ESTATUS_PEDIDA"].Value = myReader.GetString(3);;
                dataGridViewComandasPedidas.Rows[renglon].Cells["NUMERO_MESA_PEDIDA"].Value = myReader.GetString(4);
                dataGridViewComandasPedidas.Rows[renglon].Cells["ID_EMPLEADO_PEDIDA"].Value = myReader.GetString(5);
                dataGridViewComandasPedidas.Rows[renglon].Cells["NOMBRE_EMPLEADO_PEDIDA"].Value = myReader.GetString(6) + " "+ myReader.GetString(7);
                dataGridViewComandasPedidas.Rows[renglon].Cells["IMAGEN_PEDIDA"].Value = myReader[8];
                dataGridViewComandasPedidas.Rows[renglon].Cells["MOSTRAR_DETALLE_COMANDA"].Value = "✔";
                
			}
			
			if(!seEncontraron){
				MessageBox.Show("¡NO HAY COMANDAS PEDIDAS HASTA EL MOMENTO!","INFORMACIÓN",MessageBoxButtons.OK,MessageBoxIcon.Information);
			}
		
			myReader.Close();
			myConnection.Close();
			otherCommand.Dispose();
			myReader.Dispose();
	
		}
		void DataGridViewComandasPedidasCellContentClick(object sender, DataGridViewCellEventArgs e)
		{
			if(e.ColumnIndex == 8){
				//mostrar detalle comanda:
				
				dataGridViewDetalleComandaPedidas.Rows.Clear();
				string sentencia = "SELECT D.ID_COMANDA,P.ID_PRODUCTO,P.NOMBRE,P.DESCRIPCION,D.CANTIDAD,D.PRECIO_UNITARIO FROM DETALLE_COMANDA AS D INNER JOIN PRODUCTO AS P ON D.ID_PRODUCTO = P.ID_PRODUCTO WHERE D.ID_COMANDA = "+dataGridViewComandasPedidas.Rows[e.RowIndex].Cells["ID_COMANDA_PEDIDA"].Value+";";
				myConnection.Open();
				var otherCommand = new MySqlCommand(sentencia,myConnection);
				MySqlDataReader myReader;
				myReader = otherCommand.ExecuteReader();
				
				while(myReader.Read()){
					int renglon = dataGridViewDetalleComandaPedidas.Rows.Add();
	                dataGridViewDetalleComandaPedidas.Rows[renglon].Cells["ID_COMANDA_DETALLE_COMANDA_PEDIDA"].Value =  myReader.GetString(0);
	                dataGridViewDetalleComandaPedidas.Rows[renglon].Cells["ID_PRODUCTO_DETALLE_COMANDA_PEDIDA"].Value = myReader.GetString(1);
	                dataGridViewDetalleComandaPedidas.Rows[renglon].Cells["NOMBRE_PRODUCTO_DETALLE_COMANDA_PEDIDA"].Value = myReader.GetString(2);
	                dataGridViewDetalleComandaPedidas.Rows[renglon].Cells["DESCRIPCION_PRODUCTO_DETALLE_COMANDA_PEDIDA"].Value = myReader.GetString(3);;
	                dataGridViewDetalleComandaPedidas.Rows[renglon].Cells["CANTIDAD_PRODUCTO_DETALLE_COMANDA_PEDIDA"].Value = myReader.GetString(4);
	                dataGridViewDetalleComandaPedidas.Rows[renglon].Cells["PRECIO_PRODUCTO_DETALLE_COMANDA_PEDIDA"].Value = myReader.GetString(5);
	                dataGridViewDetalleComandaPedidas.Rows[renglon].Cells["IMPORTE_DETALLE_COMANDA_PEDIDA"].Value = Decimal.Parse(myReader.GetString(4)) * Decimal.Parse(myReader.GetString(5));
				}
			
				myReader.Close();
				myConnection.Close();
				otherCommand.Dispose();
				myReader.Dispose();
					
			}
		}
		void ButtonCobrarClick(object sender, EventArgs e)
		{
			//asignar comanda:
			
			string sentencia = "UPDATE COMANDA SET ID_EMPLEADO_COCINA = "+textBoxIDEmpleado.Text+", ESTATUS = 'ASIGNADA A COCINERO' WHERE ID_COMANDA = "+numericUpDownIDComanda.Value+";";
			myConnection.Open();
			var otherCommand = new MySqlCommand(sentencia,myConnection);
			otherCommand.ExecuteNonQuery();
			myConnection.Close();
			otherCommand.Dispose();
			
			//notificar a mesero:
			string mes = (DateTime.Now.Month < 10)? "0"+DateTime.Now.Month : DateTime.Now.Month.ToString();
			string dia = (DateTime.Now.Day < 10)? "0"+DateTime.Now.Day : DateTime.Now.Day.ToString();
			string hora = (DateTime.Now.Hour < 10)? "0"+DateTime.Now.Hour : DateTime.Now.Hour.ToString();
			string minuto = (DateTime.Now.Minute < 10)? "0"+DateTime.Now.Minute : DateTime.Now.Minute.ToString();
			string segundo = (DateTime.Now.Second < 10)? "0"+DateTime.Now.Second : DateTime.Now.Second.ToString();
			string fechaCaptura = DateTime.Now.Year + "-"+mes+"-"+dia+" "+hora+":"+minuto+":"+segundo; 
			string notificacion = "LA COMANDA CON EL ID "+numericUpDownIDComanda.Value+" HA SIDO ASIGNADA AL EMPLEADO CON ID: "+textBoxIDEmpleado.Text+" ("+textBoxNombreEmpleado.Text+")";
			
			sentencia = "INSERT INTO NOTIFICACIONES VALUES("+dataGridViewComandas.Rows[0].Cells["ID_EMPLEADO"].Value+",'"+notificacion+"','"+fechaCaptura+"'); ";
			
			myConnection.Open();
			var comando = new MySqlCommand(sentencia,myConnection);
			comando.ExecuteNonQuery();
			myConnection.Close();
			
			//BORRAR NOTIFICACION DEL MISMO COCINERO:
			
			sentencia = "DELETE FROM NOTIFICACIONES WHERE ID_EMPLEADO = "+textBoxIDEmpleado.Text+" AND NOTIFICACION = 'HAY COMANDA(S) LISTA(S) PARA PREPARAR';";
			
			myConnection.Open();
			comando = new MySqlCommand(sentencia,myConnection);
			comando.ExecuteNonQuery();
			myConnection.Close();
			

			//SI NO HAY COMANDAS PARA PREPARAR BORRAR NOTIFICACIONES:
			
			sentencia = "SELECT ID_COMANDA FROM COMANDA WHERE ESTATUS = 'PEDIDA';";
			
			myConnection.Open();
			comando = new MySqlCommand(sentencia,myConnection);
			MySqlDataReader myLector = comando.ExecuteReader();
			
			if(!myLector.Read()){
				//se eliminan las notificaciones de los cocineros:
				const string sentensia = "DELETE FROM NOTIFICACIONES WHERE NOTIFICACION = 'HAY COMANDA(S) LISTA(S) PARA PREPARAR';";
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

			MessageBox.Show("¡ASIGNACION DE COMANDA EXITOSA!","INFORMACIÓN",MessageBoxButtons.OK,MessageBoxIcon.Information);
			
			
			this.Close();
			
		}

	}
}
