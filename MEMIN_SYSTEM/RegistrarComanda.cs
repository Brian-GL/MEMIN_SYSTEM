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
using MySql.Data.MySqlClient;
using System.Linq;
using System.IO;
using System.Collections.Generic;

namespace MEMIN_SYSTEM
{
	/// <summary>
	/// Description of RegistrarComanda.
	/// </summary>
	public partial class RegistrarComanda : Form
	{
	
		MySqlConnection myConnection;
		int indice;
		public static decimal SubTotal;
		public RegistrarComanda(FormWindowState ws,string id,string nombre_empleado, Image img,Color c)
		{
			//
			// The InitializeComponent() call is required for Windows Forms designer support.
			//
			InitializeComponent();
			
			//
			// TODO: Add constructor code after the InitializeComponent() call.
			//
			
			myConnection = new MySqlConnection();
			textBoxNombreEmpleado.Text = nombre_empleado;
			this.WindowState = ws;
			panelFondo.BackColor = c;
			myConnection.ConnectionString="server=localhost;password=; database=sistema_memin; User Id=root";
			const string sentence = "SELECT COUNT(ID_COMANDA) AS LAST_ID FROM COMANDA";
			var command = new MySqlCommand(sentence,myConnection);
			myConnection.Open();
			MySqlDataReader myReader;
			myReader = command.ExecuteReader();
			if(c.R >=240 || c.G >= 240 || c.B >= 240)
				labelTitulo.ForeColor = Color.Black;
			if(myReader.Read())
				indice  = int.Parse(myReader.GetString(0))+1;
			
			textBoxID.Text = indice.ToString();
			
			myReader.Dispose();
			command.Dispose();
			myConnection.Close();
			SubTotal = 0;
		
			pictureBoxImagenEmpleado.Image = img;
			textBoxIDMesero.Text = id;
			textBoxNombreEmpleado.Text = nombre_empleado;
			
			
			const string sentencia = "SELECT NOMBRE FROM PRODUCTO";
			var comando = new MySqlCommand(sentencia,myConnection);
			myConnection.Open();
			MySqlDataReader myLector;
			myLector = comando.ExecuteReader();
			
			while(myLector.Read()){
				comboBoxProductos.Items.Add(myLector.GetString(0));
			}
			
			myConnection.Close();
			comando.Dispose();
			myLector.Dispose();
			
			var col = new NumericUpDownColumn();
			col.Name = "CANTIDAD";
			col.HeaderText = "CANTIDAD";
			col.DisplayIndex = 3;
			col.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
        	this.dataGridViewDetalleComanda.Columns.Add(col);
        	textBoxIVA.Text = "16";
        	
			
			
		}
		void TimerFechaHoraTick(object sender, EventArgs e)
		{
			labelFechaHoraCreacion.Refresh();
			var fecha = CultureInfo.CurrentCulture.DateTimeFormat;	
			labelFechaHoraCreacion.Text =  fecha.GetDayName(DateTime.Now.DayOfWeek).ToUpperInvariant() 
				+ " " + DateTime.Now.Day.ToString("D2") + " DE " + fecha.GetMonthName(DateTime.Now.Month).ToUpperInvariant() + " DE " + DateTime.Now.Year.ToString("D2") + "  " + DateTime.Now.Hour.ToString("D2") + ":" + DateTime.Now.Minute.ToString("D2") + ":"  + DateTime.Now.Second.ToString("D2");
			
			labelFechaHoraCreacion.Text += ( int.Parse(DateTime.Now.Hour.ToString("D2")) >= 12 && int.Parse(DateTime.Now.Hour.ToString("D2")) <= 23) ?  " PM" :  " AM";
		}
		void RegistrarComandaFormClosing(object sender, FormClosingEventArgs e)
		{
			myConnection.Dispose();
			Dispose();
		}


		void ButtonBuscarProductosClick(object sender, EventArgs e)
		{
			var buscarProductos = new BuscarProductos(WindowState,panelFondo.BackColor);
			buscarProductos.ShowDialog();
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

		int ExisteProducto(string id){
			
			for(int i = 0; i < dataGridViewDetalleComanda.Rows.Count;i++){
				if(dataGridViewDetalleComanda.Rows[i].Cells["ID_PRODUCTO"].Value.ToString() == id)
					return i;
			}
			
			return -1;
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
		
		
		void ComboBoxProductosKeyDown(object sender, KeyEventArgs e)
		{
			if(e.KeyCode == Keys.Enter){
				if(!comboBoxProductos.Items.Contains(comboBoxProductos.Text)){
					MessageBox.Show("PRODUCTO NO ENCONTRADO","INFORMACIÓN",MessageBoxButtons.OK,MessageBoxIcon.Information);
					comboBoxProductos.Text = "";
					return;
				}
				
				myConnection.ConnectionString = "server=localhost;password=;" +
					"database=sistema_memin; User Id=root";
				string sentence = "SELECT *FROM PRODUCTO WHERE ID_PRODUCTO = "+(comboBoxProductos.SelectedIndex+1)+";";
				var command = new MySqlCommand(sentence,myConnection);
				myConnection.Open();
				MySqlDataReader myReader;
				myReader = command.ExecuteReader();
				
				if(myReader.Read()){
					int index = ExisteProducto(myReader.GetString(0));
					
					if(index != -1){
						//aumentar cantidad
						dataGridViewDetalleComanda.Rows[index].Cells["CANTIDAD"].Value = Decimal.Parse(dataGridViewDetalleComanda.Rows[index].Cells["CANTIDAD"].Value.ToString()) +1;
	
						SubTotal -= Convert.ToDecimal(dataGridViewDetalleComanda.Rows[index].Cells["IMPORTE"].Value);
						dataGridViewDetalleComanda.Rows[index].Cells["IMPORTE"].Value = 
							Convert.ToDecimal(dataGridViewDetalleComanda.Rows[index].Cells["PRECIO_UNITARIO"].Value) * Decimal.Parse(dataGridViewDetalleComanda.Rows[index].Cells["CANTIDAD"].Value.ToString());
				
						SubTotal += Convert.ToDecimal(dataGridViewDetalleComanda.Rows[index].Cells["IMPORTE"].Value);
						textBoxTotal.Text = ((SubTotal*Decimal.Parse(textBoxIVA.Text)*Convert.ToDecimal(0.01)) + SubTotal).ToString();
						textBoxSubTotal.Text = SubTotal.ToString();
					}
					else{
						dataGridViewDetalleComanda.Enabled = true;
						int renglon = dataGridViewDetalleComanda.Rows.Add();
						dataGridViewDetalleComanda.Rows[renglon].Cells["ID_PRODUCTO"].Value = myReader.GetString(0);
						dataGridViewDetalleComanda.Rows[renglon].Cells["NOMBRE_PRODUCTO"].Value = myReader.GetString(1);
						dataGridViewDetalleComanda.Rows[renglon].Cells["CANTIDAD"].Value = "1";
						dataGridViewDetalleComanda.Rows[renglon].Cells["IMPORTE"].Value =  myReader.GetString(4);
						dataGridViewDetalleComanda.Rows[renglon].Cells["PRECIO_UNITARIO"].Value = myReader.GetString(4);
						dataGridViewDetalleComanda.Rows[renglon].Cells["DESCRIPCION_PRODUCTO"].Value = myReader.GetString(3);
						dataGridViewDetalleComanda.Rows[renglon].Cells["RETIRAR"].Value = "✔";
						SubTotal += Convert.ToDecimal(dataGridViewDetalleComanda.Rows[renglon].Cells["IMPORTE"].Value);
						textBoxTotal.Text = ((SubTotal*Decimal.Parse(textBoxIVA.Text)*Convert.ToDecimal(0.01)) + SubTotal).ToString();
						textBoxSubTotal.Text = SubTotal.ToString();
	
					}
				}else{
					MessageBox.Show("PRODUCTO NO ENCONTRADO","INFORMACIÓN",MessageBoxButtons.OK,MessageBoxIcon.Information);
				}
				myConnection.Close();
				command.Dispose();
				myReader.Dispose();
					
				
			}
		}
		void ButtonGuardarClick(object sender, EventArgs e)
		{
			
		
			if(textBoxNombreCliente.Text.Length < 1 || dataGridViewDetalleComanda.Rows.Count < 1){
				MessageBox.Show("ERROR, ALGUNOS CAMPOS NO HAN SIDO LLENADOS CORRECTAMENTE","ERROR",MessageBoxButtons.OK,MessageBoxIcon.Error);
				return;
			}

			int cont = 0;
			for(int i = 0; i < dataGridViewDetalleComanda.Rows.Count;i++){
				if(Decimal.Parse(dataGridViewDetalleComanda.Rows[i].Cells["CANTIDAD"].Value.ToString()) == 0)
					cont++;
			}
			
			if(cont == dataGridViewDetalleComanda.Rows.Count){
				MessageBox.Show("ERROR, DEBE DE HABER AL MENOS UN PRODUCTO CON CANTIDAD MAYOR A 1","ERROR",MessageBoxButtons.OK,MessageBoxIcon.Error);
				return;
			}
			
			//Guardar primeramente la comanda:
			
			myConnection.Open();
			string fechaCaptura = DateTime.Now.Year + "-"+DateTime.Now.Month+"-"+DateTime.Now.Day+" "+DateTime.Now.Hour+":"+DateTime.Now.Minute+":"+DateTime.Now.Second;
			string sentencia = "INSERT INTO COMANDA(ID_COMANDA,ID_EMPLEADO_MESERO,NOMBRE_CLIENTE,FECHA_CREACION,ESTATUS,NUMERO_MESA) VALUES(@ID,@EMPLEADO,@CLIENTE,@FECHA,@ESTATUS,@MESA);";
			var command = new MySqlCommand(sentencia,myConnection);
			command.Parameters.AddWithValue("@ID",int.Parse(textBoxID.Text));
			command.Parameters.AddWithValue("@EMPLEADO", textBoxIDMesero.Text);
			command.Parameters.AddWithValue("@CLIENTE", textBoxNombreCliente.Text);
			command.Parameters.AddWithValue("@FECHA", fechaCaptura);
			command.Parameters.AddWithValue("@ESTATUS", textBoxEstatus.Text);
			command.Parameters.AddWithValue("@MESA", numericUpDownNumeroMesa.Value);
			command.ExecuteNonQuery();
			command.Dispose();
			myConnection.Close();
			
			//guardar el detalle de comanda:
			
			
			var listaIDS = new List<string>();
			for(int i = 0; i < dataGridViewDetalleComanda.Rows.Count;i++){
				
				if(Decimal.Parse(dataGridViewDetalleComanda.Rows[i].Cells["CANTIDAD"].Value.ToString()) > 0){
					
					if(!listaIDS.Contains(dataGridViewDetalleComanda.Rows[i].Cells["ID_PRODUCTO"].ToString())){
					   	sentencia = "INSERT INTO DETALLE_COMANDA VALUES(@IDCOMANDA,@PRODUCTO,@CANTIDAD,@PRECIO);";
						myConnection.Open();
						var comando = new MySqlCommand(sentencia,myConnection);
						comando.Parameters.AddWithValue("@IDCOMANDA",int.Parse(textBoxID.Text));
						comando.Parameters.AddWithValue("@PRODUCTO", dataGridViewDetalleComanda.Rows[i].Cells["ID_PRODUCTO"].Value.ToString());
						comando.Parameters.AddWithValue("@CANTIDAD", Decimal.Parse(dataGridViewDetalleComanda.Rows[i].Cells["CANTIDAD"].Value.ToString()));
						comando.Parameters.AddWithValue("@PRECIO", Decimal.Parse(dataGridViewDetalleComanda.Rows[i].Cells["PRECIO_UNITARIO"].Value.ToString()));
						comando.ExecuteNonQuery();
						comando.Dispose();
						myConnection.Close();
						listaIDS.Add(dataGridViewDetalleComanda.Rows[i].Cells["ID_PRODUCTO"].ToString());
					}

				}
				
			}
			
			listaIDS.Clear();
			
			
			//REGISTRAR NOTIFICACIÓN:
			fechaCaptura = "";
			string mes = (DateTime.Now.Month < 10)? "0"+DateTime.Now.Month : DateTime.Now.Month.ToString();
			string dia = (DateTime.Now.Day < 10)? "0"+DateTime.Now.Day : DateTime.Now.Day.ToString();
			string hora = (DateTime.Now.Hour < 10)? "0"+DateTime.Now.Hour : DateTime.Now.Hour.ToString();
			string minuto = (DateTime.Now.Minute < 10)? "0"+DateTime.Now.Minute : DateTime.Now.Minute.ToString();
			string segundo = (DateTime.Now.Second < 10)? "0"+DateTime.Now.Second : DateTime.Now.Second.ToString();
			fechaCaptura = DateTime.Now.Year + "-"+mes+"-"+dia+" "+hora+":"+minuto+":"+segundo;
			const string notificacion = "HAY COMANDA(S) LISTA(S) PARA PREPARAR";
			
			
			const string nuevaSentencia = "SELECT ID_EMPLEADO FROM EMPLEADO WHERE PUESTO = 'COCINERO' OR PUESTO = 'CHEF' OR PUESTO = 'ENCARGADO COCINA' OR PUESTO = 'GERENCIA';";
			myConnection.Open();
			var comanda = new MySqlCommand(nuevaSentencia,myConnection);
			MySqlDataReader myReader;
			myReader = comanda.ExecuteReader();
			
			while(myReader.Read()){
							
				sentencia = "INSERT INTO NOTIFICACIONES VALUES("+myReader.GetString(0)+",'"+notificacion+"','"+fechaCaptura+"');";
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
			
			
			MessageBox.Show("¡COMANDA REGISTRADA CORRECTAMENTE!","INFORMACIÓN",MessageBoxButtons.OK,MessageBoxIcon.Information);
			
			//limpiar:
			
			indice++;
			textBoxID.Text = indice.ToString();
			textBoxTotal.Clear();
			SubTotal = 0;
			textBoxSubTotal.Clear();
			textBoxNombreCliente.Clear();
			dataGridViewDetalleComanda.Rows.Clear();
			numericUpDownNumeroMesa.Value = 1;
		
			
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
