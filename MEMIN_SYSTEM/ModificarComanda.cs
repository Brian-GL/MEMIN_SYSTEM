/*
 * Creado por SharpDevelop.
 * Usuario: Brian Gaytan Lomeli
 * Fecha: 27/10/2019
 * Hora: 17:58
 * 
 * Para cambiar esta plantilla use Herramientas | Opciones | Codificación | Editar Encabezados Estándar
 */
using System;
using System.Drawing;
using System.Windows.Forms;
using System.Globalization;
using System.Linq;
using System.IO;
using System.Collections.Generic;
using MySql.Data.MySqlClient;


namespace MEMIN_SYSTEM
{
	/// <summary>
	/// Description of ModificarComanda.
	/// </summary>
	public partial class ModificarComanda : Form
	{
		MySqlConnection myConnection;
		string puestoDelEmpleado, idDelEmpleado, ESTATUS;
		Decimal SubTotal;
		int idComanda;
		List<string> idProductos;
		public ModificarComanda(FormWindowState ws, Color c,string puestoEmpleado, string idEmpleado)
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
			SubTotal = 0;
			idProductos = new List<string>();
			myConnection = new MySqlConnection();
			myConnection.ConnectionString="server=localhost;password=; database=sistema_memin; User Id=root";
			puestoDelEmpleado = puestoEmpleado;
			idDelEmpleado = idEmpleado;
			var col = new NumericUpDownColumn();
			col.Name = "CANTIDAD";
			col.HeaderText = "CANTIDAD";
			col.DisplayIndex = 3;
			col.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
        	this.dataGridViewDetalleComanda.Columns.Add(col);
        	textBoxIVA.Text = "16";
			
		}

		void ModificarComandaFormClosing(object sender, FormClosingEventArgs e)
		{
			idProductos.Clear();
			myConnection.Dispose();
			Dispose();
		}

		public static Image ByteArrayToImage(byte[] byteArrayIn)
	    {
	        var ms = new MemoryStream(byteArrayIn);
	        return Image.FromStream(ms);
	    }
		void ButtonModificarNombreClienteClick(object sender, EventArgs e)
		{
			textBoxNombreCliente.Enabled = true;
			buttonModificarNombreCliente.Enabled = false;
		}
		void ButtonBuscarProductosClick(object sender, EventArgs e)
		{
			var buscarProductos = new BuscarProductos(WindowState,panelFondo.BackColor);
			buscarProductos.ShowDialog();
		}
		void TimerFechaHoraActualTick(object sender, EventArgs e)
		{
			labelFechaHoraModificacion.Refresh();
			var fecha = CultureInfo.CurrentCulture.DateTimeFormat;	
			labelFechaHoraModificacion.Text =  fecha.GetDayName(DateTime.Now.DayOfWeek).ToUpperInvariant() 
				+ " " + DateTime.Now.Day.ToString("D2") + " DE " + fecha.GetMonthName(DateTime.Now.Month).ToUpperInvariant() + " DE " + DateTime.Now.Year.ToString("D2") + "  " + DateTime.Now.Hour.ToString("D2") + ":" + DateTime.Now.Minute.ToString("D2") + ":"  + DateTime.Now.Second.ToString("D2");
			
			labelFechaHoraModificacion.Text += ( int.Parse(DateTime.Now.Hour.ToString("D2")) >= 12 && int.Parse(DateTime.Now.Hour.ToString("D2")) <= 23) ?  " PM" :  " AM";
		}
		void ButtonModificarComandaClick(object sender, EventArgs e)
		{
			if(textBoxNumeroMesa.Text.Length < 1 ||comboBoxEstatus.Text.Length < 1 || textBoxNombreCliente.Text.Length < 1){
				MessageBox.Show("ERROR, ALGUNOS CAMPOS NO HAN SIDO LLENADOS CORRECTAMENTE","ERROR",MessageBoxButtons.OK,MessageBoxIcon.Error);
			}else{
				
				//ESTATUS ES EL ESTATUS ANTERIOR DE LA COMANDA
				
				if(ESTATUS == "PEDIDA"){
					//modificar sólamente el número de mesa, nombre del cliente y el datagridview de los productos
					
					string sentenciaComanda = "UPDATE COMANDA SET NUMERO_MESA = "+textBoxNumeroMesa.Text+", NOMBRE_CLIENTE = '"+textBoxNombreCliente.Text+"' WHERE ID_COMANDA = "+idComanda+";";
					myConnection.Open();
					var comando = new MySqlCommand(sentenciaComanda,myConnection);
					comando.ExecuteNonQuery();
					comando.Dispose();
					myConnection.Close();
					
					//modificar detalle de comanda:
					
					for(int i = 0; i < idProductos.Count;i++){
						string deleteSentencia = "DELETE FROM DETALLE_COMANDA WHERE ID_COMANDA = "+idComanda+" AND ID_PRODUCTO = "+idProductos[i]+";";
						myConnection.Open();
						var comanda = new MySqlCommand(deleteSentencia,myConnection);
						comanda.ExecuteNonQuery();
						comanda.Dispose();
						myConnection.Close();
					}
					
					
					for(int i = 0; i < dataGridViewDetalleComanda.Rows.Count;i++){
						if(!dataGridViewDetalleComanda.Rows[i].Cells["CANTIDAD"].Value.ToString().Equals("0")){
							const string insertSentencia = "INSERT INTO DETALLE_COMANDA VALUES(@IDCOMANDA,@PRODUCTO,@CANTIDAD,@PRECIO);";
							myConnection.Open();
							var comand = new MySqlCommand(insertSentencia,myConnection);
							comand.Parameters.AddWithValue("@IDCOMANDA",idComanda);
							comand.Parameters.AddWithValue("@PRODUCTO", dataGridViewDetalleComanda.Rows[i].Cells["ID_PRODUCTO"].Value.ToString());
							comand.Parameters.AddWithValue("@CANTIDAD", Decimal.Parse(dataGridViewDetalleComanda.Rows[i].Cells["CANTIDAD"].Value.ToString()));
							comand.Parameters.AddWithValue("@PRECIO", Decimal.Parse(dataGridViewDetalleComanda.Rows[i].Cells["PRECIO_UNITARIO"].Value.ToString()));
							comand.ExecuteNonQuery();
							comand.Dispose();
							myConnection.Close();
						}
						
					}
					
					MessageBox.Show("¡MODIFICACIÓN REALIZADA CORRECTAMENTE!","INFORMACIÓN",MessageBoxButtons.OK,MessageBoxIcon.Information);
					
				}
				
				else if(ESTATUS == "ASIGNADA A COCINERO"){
					//modificar estatus:
					
					if(comboBoxEstatus.Text != ESTATUS){
						//SE MODIFICAR A PREPARADA
					
						string sentenciaComanda = "UPDATE COMANDA SET ESTATUS = '"+comboBoxEstatus.Text+"' WHERE ID_COMANDA = "+idComanda+";";
						myConnection.Open();
						var comando = new MySqlCommand(sentenciaComanda,myConnection);
						comando.ExecuteNonQuery();
						comando.Dispose();
						myConnection.Close();
						
						//NOTIFICAR AL MESERO QUE EL COCINERO TERMINÓ PREPARAACIÓN LA COMANDA:
						
						string mes = (DateTime.Now.Month < 10)? "0"+DateTime.Now.Month : DateTime.Now.Month.ToString();
						string dia = (DateTime.Now.Day < 10)? "0"+DateTime.Now.Day : DateTime.Now.Day.ToString();
						string hora = (DateTime.Now.Hour < 10)? "0"+DateTime.Now.Hour : DateTime.Now.Hour.ToString();
						string minuto = (DateTime.Now.Minute < 10)? "0"+DateTime.Now.Minute : DateTime.Now.Minute.ToString();
						string segundo = (DateTime.Now.Second < 10)? "0"+DateTime.Now.Second : DateTime.Now.Second.ToString();
						string fechaCaptura = DateTime.Now.Year + "-"+mes+"-"+dia+" "+hora+":"+minuto+":"+segundo; 
						string notificacion = "LA COMANDA CON EL ID "+idComanda+" HA SIDO PREPARADA Y LISTA PARA SERVIR";
						
						string sentencia = "INSERT INTO NOTIFICACIONES VALUES("+textBoxIDMesero.Text+",'"+notificacion+"','"+fechaCaptura+"'); ";
						
						myConnection.Open();
						comando = new MySqlCommand(sentencia,myConnection);
						comando.ExecuteNonQuery();
						myConnection.Close();
					}
					
					MessageBox.Show("¡MODIFICACIÓN REALIZADA CORRECTAMENTE!","INFORMACIÓN",MessageBoxButtons.OK,MessageBoxIcon.Information);
					
				}
				
				else if(ESTATUS == "PREPARADA"){
					//modificar estatus:
					
					if(comboBoxEstatus.Text != ESTATUS){
						//SE MODIFICAR A CERRADA POR EL MESERO
					
						string sentenciaComanda = "UPDATE COMANDA SET ESTATUS = '"+comboBoxEstatus.Text+"' WHERE ID_COMANDA = "+idComanda+";";
						myConnection.Open();
						var comando = new MySqlCommand(sentenciaComanda,myConnection);
						comando.ExecuteNonQuery();
						comando.Dispose();
						myConnection.Close();
						
						//NOTIFICAR A TODOS LOS CAJEROS QUE EL MESERO CERRÓ LA COMANDA:
						
						string mes = (DateTime.Now.Month < 10)? "0"+DateTime.Now.Month : DateTime.Now.Month.ToString();
						string dia = (DateTime.Now.Day < 10)? "0"+DateTime.Now.Day : DateTime.Now.Day.ToString();
						string hora = (DateTime.Now.Hour < 10)? "0"+DateTime.Now.Hour : DateTime.Now.Hour.ToString();
						string minuto = (DateTime.Now.Minute < 10)? "0"+DateTime.Now.Minute : DateTime.Now.Minute.ToString();
						string segundo = (DateTime.Now.Second < 10)? "0"+DateTime.Now.Second : DateTime.Now.Second.ToString();
						string fechaCaptura = DateTime.Now.Year + "-"+mes+"-"+dia+" "+hora+":"+minuto+":"+segundo; 
						const string notificacion = "¡HAY COMANDA(S) LISTA(S) PARA COBRAR!";
						
						const string nuevaSentencia = "SELECT ID_EMPLEADO FROM EMPLEADO WHERE PUESTO = 'CAJERO' OR PUESTO = 'GERENCIA';";
						myConnection.Open();
						var comanda = new MySqlCommand(nuevaSentencia,myConnection);
						MySqlDataReader myReader;
						myReader = comanda.ExecuteReader();
						
						while(myReader.Read()){
										
							string sentencia = "INSERT INTO NOTIFICACIONES VALUES("+myReader.GetString(0)+",'"+notificacion+"','"+fechaCaptura+"');";
							var otherConnection = new MySqlConnection();
							otherConnection.ConnectionString = "server=localhost;password=; database=sistema_memin; User Id=root";
							otherConnection.Open();
							var otherCommand = new MySqlCommand(sentencia,otherConnection);
							otherCommand.ExecuteNonQuery();
							otherConnection.Close();
							otherCommand.Dispose();
						}
						
						myConnection.Close();
						comanda.Dispose();
						myReader.Dispose();
						
					}
					
					MessageBox.Show("¡MODIFICACIÓN REALIZADA CORRECTAMENTE!","INFORMACIÓN",MessageBoxButtons.OK,MessageBoxIcon.Information);
					
				}
				

				//Limpiar:
				textBoxIDMesero.Clear();
				pictureBoxImagenEmpleado.Image = null;
				textBoxNombreCliente.Clear();
				textBoxNumeroMesa.Clear();
				textBoxSubTotal.Clear();
				textBoxNombreEmpleado.Clear();
				textBoxTotal.Clear();
				textBoxIVA.Clear();
				labelFechaDeCreacion.Text ="";
				comboBoxEstatus.Text ="";
				comboBoxEstatus.Items.Clear();
				textBoxIDMesero.Clear();
				dataGridViewDetalleComanda.Rows.Clear();
				
				//inhabilitar controles:
				textBoxIVA.Enabled = textBoxNombreCliente.Enabled = textBoxIDMesero.Enabled = textBoxNombreEmpleado.Enabled =  textBoxNumeroMesa.Enabled = comboBoxEstatus.Enabled = 
					buttonModificarComanda.Enabled = buttonModificarEstatus.Enabled = buttonModificarNombreCliente.Enabled = buttonModificarNumeroMesa.Enabled = buttonModificarTodosLosCampos.Enabled  = dataGridViewDetalleComanda.Enabled = false;
	
				
			}
		}
		void ButtonVerificarIDCompraClick(object sender, EventArgs e)
		{
			//Buscar comanda:
			idProductos.Clear();
            dataGridViewDetalleComanda.Rows.Clear();
            textBoxIDMesero.Clear();
            textBoxNombreCliente.Clear();
            textBoxNombreEmpleado.Clear();
            textBoxSubTotal.Clear();
            textBoxTotal.Clear();
            comboBoxEstatus.Text = "";
            comboBoxEstatus.Items.Clear();
            textBoxNumeroMesa.Clear();
			bool seEncontro = false;
			SubTotal = 0;
			idComanda = Convert.ToInt32(numericUpDownIDComanda.Value);
			
			textBoxIVA.Enabled = textBoxIDMesero.Enabled = textBoxNombreCliente.Enabled  = textBoxNombreEmpleado.Enabled = textBoxNumeroMesa.Enabled = textBoxSubTotal.Enabled = textBoxTotal.Enabled = buttonModificarComanda.Enabled = buttonModificarEstatus.Enabled = comboBoxEstatus.Enabled = buttonModificarNombreCliente.Enabled = buttonModificarNumeroMesa.Enabled = buttonModificarTodosLosCampos.Enabled =dataGridViewDetalleComanda.Enabled = false;
			
			//ver el estatus de la comanda:
			
			string sentence = "SELECT ESTATUS FROM COMANDA WHERE ID_COMANDA = "+numericUpDownIDComanda.Value+";";
			myConnection.Open();
			var comanda = new MySqlCommand(sentence,myConnection);
			MySqlDataReader lector = comanda.ExecuteReader();
			
			if(lector.Read()){
				
				ESTATUS = lector.GetString(0);
				//otra conexion:
				seEncontro = true;
				
				var otherConnection = new  MySqlConnection();
				otherConnection.ConnectionString = "server=localhost;password=;database=sistema_memin; User Id=root";
				otherConnection.Open();
				if(ESTATUS == "PEDIDA"){
					
					if(puestoDelEmpleado != "MESERO" && puestoDelEmpleado != "GERENCIA" && puestoDelEmpleado != "CAPITAN DE MESEROS"){
						MessageBox.Show("¡USTED NO TIENE PERMISOS PARA MODIFICAR ESTA COMANDA, YA QUE AÚN ESTA PEDIDA!","ERROR",MessageBoxButtons.OK,MessageBoxIcon.Error);
						otherConnection.Close();
						myConnection.Close();
						lector.Dispose();
						comanda.Dispose();
						return;
					}
					
					string sentencia = "SELECT NOMBRE_CLIENTE,FECHA_CREACION, NUMERO_MESA,EMPLEADO.ID_EMPLEADO, EMPLEADO.NOMBRE, EMPLEADO.APELLIDO_PATERNO,EMPLEADO.IMAGEN FROM COMANDA INNER JOIN EMPLEADO ON COMANDA.ID_EMPLEADO_MESERO = EMPLEADO.ID_EMPLEADO WHERE ID_COMANDA = "+numericUpDownIDComanda.Value+";";
					var otherCommand = new MySqlCommand(sentencia,otherConnection);
					MySqlDataReader myReader;
					myReader = otherCommand.ExecuteReader();
					
					if(myReader.Read()){
						textBoxNombreCliente.Text  = myReader.GetString(0);
		                labelFechaDeCreacion.Text = myReader.GetString(1);
		                textBoxNumeroMesa.Text = myReader.GetString(2);
		                comboBoxEstatus.Text = ESTATUS;
		                comboBoxEstatus.Items.Add(ESTATUS);
		                textBoxIDMesero.Text = myReader.GetString(3);
		                textBoxNombreEmpleado.Text = myReader.GetString(4) + " "+ myReader.GetString(5);
		               	var datos = (byte[])myReader[6];
		                pictureBoxImagenEmpleado.Image = ByteArrayToImage(datos);
		                buttonModificarComanda.Enabled = buttonModificarEstatus.Enabled = buttonModificarNombreCliente.Enabled = buttonModificarTodosLosCampos.Enabled = buttonModificarNumeroMesa.Enabled = dataGridViewDetalleComanda.Enabled = true;
		                
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
				else if(ESTATUS == "ASIGNADA A COCINERO"){
					
					if(puestoDelEmpleado != "COCINERO" && puestoDelEmpleado != "GERENCIA" && puestoDelEmpleado != "CHEF" && puestoDelEmpleado != "ENCARGADO COCINA"){
						MessageBox.Show("¡USTED NO TIENE PERMISOS PARA MODIFICAR ESTA COMANDA, YA QUE AÚN ESTA ASIGNADA A UN COCINERO!","ERROR",MessageBoxButtons.OK,MessageBoxIcon.Error);
						otherConnection.Close();
						myConnection.Close();
						lector.Dispose();
						comanda.Dispose();
						return;
					}
					
					string sentencia = "SELECT NOMBRE_CLIENTE,FECHA_CREACION, NUMERO_MESA,EMPLEADO.ID_EMPLEADO, EMPLEADO.NOMBRE, EMPLEADO.APELLIDO_PATERNO,EMPLEADO.IMAGEN FROM COMANDA INNER JOIN EMPLEADO ON COMANDA.ID_EMPLEADO_MESERO = EMPLEADO.ID_EMPLEADO WHERE ID_COMANDA = "+numericUpDownIDComanda.Value+";";
					
					var otherCommand = new MySqlCommand(sentencia,otherConnection);
					MySqlDataReader myReader;
					myReader = otherCommand.ExecuteReader();
					
					if(myReader.Read()){
						
						
						textBoxNombreCliente.Text  = myReader.GetString(0);
		                labelFechaDeCreacion.Text = myReader.GetString(1);
		                textBoxNumeroMesa.Text = myReader.GetString(2);
		                comboBoxEstatus.Text = ESTATUS;
		                comboBoxEstatus.Items.Add(ESTATUS);
		                comboBoxEstatus.Items.Add("PREPARADA");
		                textBoxIDMesero.Text = myReader.GetString(3);
		                textBoxNombreEmpleado.Text = myReader.GetString(4) + " "+ myReader.GetString(5);
		               	var datos = (byte[])myReader[6];
		                pictureBoxImagenEmpleado.Image = ByteArrayToImage(datos);
		                buttonModificarComanda.Enabled = buttonModificarEstatus.Enabled = true;
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
				else if(ESTATUS == "PREPARADA"){
					
					if(puestoDelEmpleado != "MESERO" && puestoDelEmpleado != "GERENCIA" && puestoDelEmpleado != "CAPITAN DE MESEROS"){
						MessageBox.Show("¡USTED NO TIENE PERMISOS PARA MODIFICAR ESTA COMANDA, YA QUE AÚN ESTA PREPARADA!","ERROR",MessageBoxButtons.OK,MessageBoxIcon.Error);
						otherConnection.Close();
						myConnection.Close();
						lector.Dispose();
						comanda.Dispose();
						return;
					}
					string sentencia = "SELECT NOMBRE_CLIENTE,FECHA_CREACION, NUMERO_MESA,EMPLEADO.ID_EMPLEADO, EMPLEADO.NOMBRE, EMPLEADO.APELLIDO_PATERNO,EMPLEADO.IMAGEN FROM COMANDA INNER JOIN EMPLEADO ON COMANDA.ID_EMPLEADO_MESERO = EMPLEADO.ID_EMPLEADO WHERE ID_COMANDA = "+numericUpDownIDComanda.Value+";";
					
					var otherCommand = new MySqlCommand(sentencia,otherConnection);
					MySqlDataReader myReader;
					myReader = otherCommand.ExecuteReader();
					
					if(myReader.Read()){
						textBoxNombreCliente.Text  = myReader.GetString(0);
		                labelFechaDeCreacion.Text = myReader.GetString(1);
		                textBoxNumeroMesa.Text = myReader.GetString(2);
		                comboBoxEstatus.Text = ESTATUS;
		                comboBoxEstatus.Items.Add(ESTATUS);
		                comboBoxEstatus.Items.Add("CERRADA");
		                textBoxIDMesero.Text = myReader.GetString(3);
		                textBoxNombreEmpleado.Text = myReader.GetString(4) + " "+ myReader.GetString(5);
		               	var datos = (byte[])myReader[6];
		                pictureBoxImagenEmpleado.Image = ByteArrayToImage(datos);
		                buttonModificarComanda.Enabled = buttonModificarEstatus.Enabled = true;
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
				else if(ESTATUS == "CERRADA" || ESTATUS == "PAGADA"){
					
					string sentencia = "SELECT NOMBRE_CLIENTE,FECHA_CREACION, NUMERO_MESA,EMPLEADO.ID_EMPLEADO, EMPLEADO.NOMBRE, EMPLEADO.APELLIDO_PATERNO,EMPLEADO.IMAGEN FROM COMANDA INNER JOIN EMPLEADO ON COMANDA.ID_EMPLEADO_MESERO = EMPLEADO.ID_EMPLEADO WHERE ID_COMANDA = "+numericUpDownIDComanda.Value+";";
					var otherCommand = new MySqlCommand(sentencia,otherConnection);
					MySqlDataReader myReader;
					myReader = otherCommand.ExecuteReader();
					
					if(myReader.Read()){
						
						
						textBoxNombreCliente.Text  = myReader.GetString(0);
		                labelFechaDeCreacion.Text = myReader.GetString(1);
		                textBoxNumeroMesa.Text = myReader.GetString(2);
		                comboBoxEstatus.Text = ESTATUS;
		                comboBoxEstatus.Items.Add(ESTATUS);
		                textBoxIDMesero.Text = myReader.GetString(3);
		                textBoxNombreEmpleado.Text = myReader.GetString(4) + " "+ myReader.GetString(5);
		               	var datos = (byte[])myReader[6];
		                pictureBoxImagenEmpleado.Image = ByteArrayToImage(datos);
		                
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
			}
			
			myConnection.Close();
			lector.Dispose();
			comanda.Dispose();
			
			if(seEncontro){
				string sentencia = "SELECT TABLA1.ID_COMANDA, TABLA1.ID_PRODUCTO,TABLA2.NOMBRE, TABLA2.DESCRIPCION, TABLA1.CANTIDAD,TABLA1.PRECIO_UNITARIO" +
				" FROM DETALLE_COMANDA TABLA1, PRODUCTO TABLA2 WHERE TABLA1.ID_COMANDA = "+numericUpDownIDComanda.Value+" AND TABLA2.ID_PRODUCTO = TABLA1.ID_PRODUCTO";
			
				var comando = new MySqlCommand(sentencia,myConnection);
				myConnection.Open();
				MySqlDataReader myLector;
				myLector = comando.ExecuteReader();
				
				while(myLector.Read()){
					
					int renglon = dataGridViewDetalleComanda.Rows.Add();
	                dataGridViewDetalleComanda.Rows[renglon].Cells["ID_PRODUCTO"].Value = 
	                	myLector.GetString(1);
	                idProductos.Add(myLector.GetString(1));
	                dataGridViewDetalleComanda.Rows[renglon].Cells["NOMBRE_PRODUCTO"].Value = 
	                	myLector.GetString(2);
	                dataGridViewDetalleComanda.Rows[renglon].Cells["CANTIDAD"].Value = 
	                	myLector.GetString(4);
	                dataGridViewDetalleComanda.Rows[renglon].Cells["PRECIO_UNITARIO"].Value = 
	                	myLector.GetString(5);
	                dataGridViewDetalleComanda.Rows[renglon].Cells["DESCRIPCION_PRODUCTO"].Value = 
	                	myLector.GetString(3);
	                dataGridViewDetalleComanda.Rows[renglon].Cells["IMPORTE"].Value = Decimal.Parse(myLector.GetString(4)) * Decimal.Parse(myLector.GetString(5));
	
	                SubTotal += Decimal.Parse(myLector.GetString(4)) * Decimal.Parse(myLector.GetString(5));
	                
	                dataGridViewDetalleComanda.Rows[renglon].Cells["RETIRAR"].Value = "✔";

				}

				textBoxTotal.Text = ((SubTotal*Decimal.Parse(textBoxIVA.Text)*Convert.ToDecimal(0.01)) + SubTotal).ToString();
						textBoxSubTotal.Text = SubTotal.ToString();
				
				
				myConnection.Close();
				myLector.Dispose();
				comando.Dispose();
				
			}
			
			
		}
		void ButtonModificarNumeroMesaClick(object sender, EventArgs e)
		{
			textBoxNumeroMesa.Enabled = true;
			buttonModificarNumeroMesa.Enabled = false;
		}
		void ButtonModificarEstatusClick(object sender, EventArgs e)
		{
			comboBoxEstatus.Enabled = true;
			buttonModificarEstatus.Enabled = false;
		}
		void ButtonModificarTodosLosCamposClick(object sender, EventArgs e)
		{
			
			textBoxNombreCliente.Enabled = true;
			buttonModificarNombreCliente.Enabled = false;
			textBoxNumeroMesa.Enabled = true;
			buttonModificarNumeroMesa.Enabled = false;
			comboBoxEstatus.Enabled = true;
			buttonModificarEstatus.Enabled = false;
			
			
			buttonModificarTodosLosCampos.Enabled = false;
		}
		void DataGridViewDetalleComandaCellContentClick(object sender, DataGridViewCellEventArgs e)
		{
			if(e.ColumnIndex == 5){
				
				var result = MessageBox.Show("¿ESTÁ SEGUR@ DE ELIMINAR DICHO PRODUCTO DE LA COMANDA?","PREGUNTA",MessageBoxButtons.YesNo,MessageBoxIcon.Question);
				if(result == DialogResult.Yes){
					//se elimina
					SubTotal -= Convert.ToDecimal(dataGridViewDetalleComanda.Rows[e.RowIndex].Cells["IMPORTE"].Value);
					textBoxTotal.Text = ((SubTotal*Decimal.Parse(textBoxIVA.Text)*Convert.ToDecimal(0.01)) + SubTotal).ToString();
					textBoxSubTotal.Text = SubTotal.ToString();
					dataGridViewDetalleComanda.Rows.RemoveAt(e.RowIndex);
				}
			}
		}
		void DataGridViewDetalleComandaCellEndEdit(object sender, DataGridViewCellEventArgs e)
		{
			if(dataGridViewDetalleComanda.Rows[e.RowIndex].Cells["CANTIDAD"].Value.ToString().Length == 0)
				dataGridViewDetalleComanda.Rows[e.RowIndex].Cells["CANTIDAD"].Value = "0";

			SubTotal -= Convert.ToDecimal(dataGridViewDetalleComanda.Rows[e.RowIndex].Cells["IMPORTE"].Value);
			dataGridViewDetalleComanda.Rows[e.RowIndex].Cells["IMPORTE"].Value = 
				Convert.ToDecimal(dataGridViewDetalleComanda.Rows[e.RowIndex].Cells["PRECIO_UNITARIO"].Value) * Decimal.Parse(dataGridViewDetalleComanda.Rows[e.RowIndex].Cells["CANTIDAD"].Value.ToString());
			
			SubTotal += Convert.ToDecimal(dataGridViewDetalleComanda.Rows[e.RowIndex].Cells["IMPORTE"].Value);
			textBoxTotal.Text = ((SubTotal*Decimal.Parse(textBoxIVA.Text)*Convert.ToDecimal(0.01)) + SubTotal).ToString();
			textBoxSubTotal.Text = SubTotal.ToString();
		}
		void TextBoxNumeroMesaTextChanged(object sender, EventArgs e)
		{
			if(textBoxNumeroMesa.Text.Length > 0){
				if(!Char.IsDigit(textBoxNumeroMesa.Text.Last())){
					textBoxNumeroMesa.Text = textBoxNumeroMesa.Text.Substring(0,textBoxNumeroMesa.Text.Length-1);
					textBoxNumeroMesa.SelectionStart = textBoxNumeroMesa.Text.Length;
					textBoxNumeroMesa.Refresh();
				}
			}
		}
		
		//numeric up down en datagridview
		public class NumericUpDownColumn : DataGridViewColumn{

			public NumericUpDownColumn(): base(new NumericUpDownCell()){}

	    	public override DataGridViewCell CellTemplate{
		        get
		        {
		            return base.CellTemplate;
		        }
		        set
		        {
		            // Ensure that the cell used for the template is a CalendarCell.
		            if (value != null && 
		                !value.GetType().IsAssignableFrom(typeof(NumericUpDownCell)))
		            {
		                throw new InvalidCastException("Must be a NumericUpDownCell");
		            }
		            base.CellTemplate = value;
		        }
	    	}
		}

 
		public class NumericUpDownCell : DataGridViewTextBoxCell{

			public NumericUpDownCell(): base(){
				this.Style.Format = "#.##";
			}

	    	public override void InitializeEditingControl(int rowIndex, object 
				                                              initialFormattedValue, DataGridViewCellStyle dataGridViewCellStyle){
	
				base.InitializeEditingControl(rowIndex, initialFormattedValue,dataGridViewCellStyle);
	
				var  ctl  = (NumericUpDownEditingControl)DataGridView.EditingControl;
	
	        	ctl.Value = (Value == null)? 0 : Convert.ToDecimal(this.Value);

			}
 

			public override Type EditType{

		         get
		         {
		            // Return the type of the editing control that CalendarCell uses.
		            return typeof(NumericUpDownEditingControl);
		         }

			}



		   	public override Type ValueType
		    {
		        get
		        {
		            // Return the type of the value that CalendarCell contains.
		            
		            return typeof(Decimal);
		        }
		    }

 

		    public override object DefaultNewRowValue
		    {
		        get
		        {
		            // Use the current date and time as the default value.
		            return 0;
		        }
		    }
		}

 
		class NumericUpDownEditingControl: NumericUpDown,IDataGridViewEditingControl{
			private DataGridView dataGridViewControl;
	
	    	private bool valueIsChanged = false;
	
	    	private int rowIndexNum;
	    	
	    	public NumericUpDownEditingControl(){
	    		this.DecimalPlaces = 0;
	    		this.Minimum = 0;
	    		this.Maximum = 9999999999;
        	}

	    	public object EditingControlFormattedValue{

       			get{

	    			return this.Value.ToString("#.##");

	    		}

	    		set{

	    			if (value is Decimal)
		            {
		                try
		                {
		                    // This will throw an exception of the string is 
		                    // null, empty, or not in the format of a date.
		                    this.Value = Decimal.Parse((String)value);
		                }
		                catch
		                {
		                    // In the case of an exception, just use the 
		                    // default value so we're not left with a null
		                    // value.
		                    this.Value = (Decimal)value;
		                }
		            }
	    		}

	    	}

	    	public object GetEditingControlFormattedValue(DataGridViewDataErrorContexts context){
	    		return this.Value.ToString("#.##");
	    	}

  	 		public void ApplyCellStyleToEditingControl(
	    		DataGridViewCellStyle dataGridViewCellStyle){

	    		this.Font = dataGridViewCellStyle.Font;

	    		this.ForeColor = dataGridViewCellStyle.ForeColor;

	    		this.BackColor = dataGridViewCellStyle.BackColor;
	    	}

	    	// disable once ConvertToAutoProperty
	    	public int EditingControlRowIndex{
	    		get{
	    			return rowIndexNum;
	    		}
	
	    		set{
	    			rowIndexNum = value;
	    		}
	    	}

		    public bool EditingControlWantsInputKey(
			    		Keys key, bool dataGridViewWantsInputKey){
		
		        switch (key & Keys.KeyCode)
		        {
		            case Keys.Left:
		            case Keys.Up:
		            case Keys.Down:
		            case Keys.Right:
		            case Keys.Home:
		            case Keys.End:
		            case Keys.PageDown:
		            case Keys.PageUp:
		                return true;
		            default:
		                return false;
		        }
	 
		   }

	    	public void PrepareEditingControlForEdit(bool selectAll){
				// No preparation needs to be done.

	    	}

	    	public bool RepositionEditingControlOnValueChange{
	    		get{
	    			return false;
	    		}
	    	}
	    	
	    	// disable once ConvertToAutoProperty
	    	public DataGridView EditingControlDataGridView{

	    		get{
	    			return dataGridViewControl;
	    		}
	
	    		set{
	    			dataGridViewControl = value;
	    		}

	    	}

	    	public bool EditingControlValueChanged{
		        get
		        {
		            return valueIsChanged;
		        }
		        set
		        {
		            valueIsChanged = value;
		        }
		    }

	    	public Cursor EditingPanelCursor{

	    		get{

	    			return base.Cursor;

	    		}
	    	}

 	    	protected override void OnValueChanged(EventArgs e){
		
		        valueIsChanged = true;
		
		        this.EditingControlDataGridView.NotifyCurrentCellDirty(true);
		
		        base.OnValueChanged(e);
	    	}
	    
		}

		
	}
}
