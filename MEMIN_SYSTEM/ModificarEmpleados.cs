/*
 * Creado por SharpDevelop.
 * Usuario: Brian Gaytan Lomeli
 * Fecha: 21/10/2019
 * Hora: 16:21
 * 
 * Para cambiar esta plantilla use Herramientas | Opciones | Codificación | Editar Encabezados Estándar
 */
using System;
using System.Drawing;
using System.Windows.Forms;
using System.Collections.Generic;
using MySql.Data.MySqlClient;
using System.IO;
using System.Linq;
using System.Drawing.Imaging;
using System.Text.RegularExpressions;

namespace MEMIN_SYSTEM
{
	/// <summary>
	/// Description of ModificarEmpleados.
	/// </summary>
	public partial class ModificarEmpleados : Form
	{
		MySqlConnection myConnection;
		string correos;
		string telefonos;
		int idEmpleadoAModificar;
		public ModificarEmpleados(FormWindowState ws, Color c)
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
			correos = telefonos = "";
			dataGridViewTelefono.Rows[0].Cells["ELIMINAR_TELEFONO"].Value = "X";
			dataGridViewTelefono.Rows[0].Cells["Telefono"].Value = "";
			dataGridViewCorreos.Rows[0].Cells["ELIMINAR_CORREO"].Value = "X";
			dataGridViewCorreos.Rows[0].Cells["Correo"].Value = "";
		}
		void ButtonCargarImagenClick(object sender, EventArgs e)
		{
			var openImagen = new OpenFileDialog();
			openImagen.Filter =  "Imágenes (*.png; *.jpg; *.jpeg; *.bmp) | *.png; *.jpg; *.jpeg; *.bmp";
			var result = openImagen.ShowDialog();
			
			if(!result.Equals(System.Windows.Forms.DialogResult.Cancel) && openImagen.FileName.Length > 1)
				pictureBoxImagenCargada.Image = Resizar(new Bitmap(openImagen.FileName),200,200);
				
			openImagen.Dispose();
		}
		
		Bitmap Resizar(Image imagen, int w, int h){
			var bmp = new Bitmap(w,h);
			var grafico = Graphics.FromImage(bmp);
			grafico.DrawImage(imagen,0,0,w,h);
			
			grafico.Dispose();
			
			return bmp;
		}
		
		void ModificarEmpleadosFormClosing(object sender, FormClosingEventArgs e)
		{
			myConnection.Dispose();
			this.Dispose();
		}
		void DataGridViewCorreosCellContentDoubleClick(object sender, DataGridViewCellEventArgs e)
		{
			
			if(dataGridViewCorreos.Rows[e.RowIndex].Cells["Correo"].Value != null){
			var result = MessageBox.Show("¿ESTÁ SEGURO DE ELIMINAR TAL CORREO?","PREGUNTA",MessageBoxButtons.YesNo,MessageBoxIcon.Question);
			if(result == DialogResult.Yes)
				dataGridViewCorreos.Rows.RemoveAt(e.RowIndex);
			}
		}
		void DataGridViewTelefonoCellContentDoubleClick(object sender, DataGridViewCellEventArgs e)
		{
			if(dataGridViewTelefono.Rows[e.RowIndex].Cells["Telefono"].Value != null){
				var result = MessageBox.Show("¿ESTÁ SEGURO DE ELIMINAR TAL TELÉFONO?","PREGUNTA",MessageBoxButtons.YesNo,MessageBoxIcon.Question);
				if(result == DialogResult.Yes)
					dataGridViewTelefono.Rows.RemoveAt(e.RowIndex);
			}

		}
		void DataGridViewCorreosRowsAdded(object sender, DataGridViewRowsAddedEventArgs e)
		{
			dataGridViewCorreos.Rows[e.RowIndex].Cells["ELIMINAR_CORREO"].Value = "X";
			dataGridViewCorreos.Rows[e.RowIndex].Cells["Correo"].Value = "";
		}
		void DataGridViewTelefonoRowsAdded(object sender, DataGridViewRowsAddedEventArgs e)
		{
			dataGridViewTelefono.Rows[e.RowIndex].Cells["ELIMINAR_TELEFONO"].Value = "X";
			dataGridViewTelefono.Rows[e.RowIndex].Cells["Telefono"].Value = "";
		}
		void DataGridViewCorreosCellEndEdit(object sender, DataGridViewCellEventArgs e)
		{
			if(dataGridViewCorreos.Rows[e.RowIndex].Cells["Correo"].Value != null){
				string value = dataGridViewCorreos.Rows[e.RowIndex].Cells["Correo"].Value.ToString();
				if(value.Length > 0){
					if(!validEmail(dataGridViewCorreos.Rows[e.RowIndex].Cells["Correo"].Value.ToString())){
						MessageBox.Show("FORMATO INVÁLIDO DE CORREO, INGRESE UN CORREO CORRECTAMENTE","ERROR",MessageBoxButtons.OK,MessageBoxIcon.Error);
						dataGridViewCorreos.Rows[e.RowIndex].Cells["Correo"].Value = "";
					}
				}
			}
		}
		void DataGridViewTelefonoCellEndEdit(object sender, DataGridViewCellEventArgs e)
		{
			if(dataGridViewTelefono.Rows[e.RowIndex].Cells["Telefono"].Value != null){
				string value = dataGridViewTelefono.Rows[e.RowIndex].Cells["Telefono"].Value.ToString();
				if(value.Length > 0){
					if(!validTelephone(dataGridViewTelefono.Rows[e.RowIndex].Cells["Telefono"].Value.ToString())){
						MessageBox.Show("FORMATO INVÁLIDO DE TELÉFONO, INGRESE UN TELEFONO CORRECTAMENTE","ERROR",MessageBoxButtons.OK,MessageBoxIcon.Error);
						dataGridViewTelefono.Rows[e.RowIndex].Cells["Telefono"].Value = "";
					}
				}
			}
			
		}
		
		void obtenerTelefonos(){
			
			for(int i = 0; i < dataGridViewTelefono.Rows.Count;i++){
				if(dataGridViewTelefono.Rows[i].Cells["Telefono"].Value != null){
					telefonos+=dataGridViewTelefono.Rows[i].Cells["Telefono"].Value+"|";
				}
			}

		}
		void obtenerCorreos(){
			for(int i = 0; i < dataGridViewCorreos.Rows.Count;i++){
				if(dataGridViewCorreos.Rows[i].Cells["Correo"].Value != null){
					correos+=dataGridViewCorreos.Rows[i].Cells["Correo"].Value+"|";
				}
			}
		}
		bool validEmail(string email)
		{
		   string expresion;
		   expresion = "\\w+([-+.']\\w+)*@\\w+([-.]\\w+)*\\.\\w+([-.]\\w+)*";
			return Regex.IsMatch(email, expresion) && (Regex.Replace(email, expresion, String.Empty).Length == 0);
		}
		bool validTelephone(string telefono){
			if(telefono[0].ToString() == "0")
				return false;
			for(int i = 0; i < telefono.Length;i++){
				if(!Char.IsDigit(telefono[i]))
					return false;
			}
			
			return (telefono.Length == 10);
			
		}
		
		void getTelefonos(string telephone){
			
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
				
				int renglon = dataGridViewTelefono.Rows.Add();
				dataGridViewTelefono.Rows[renglon].Cells["Telefono"].Value = lista[i];
				
			}
			
			
			lista.Clear();
			
		}
		void getCorreos(string email){
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
				int renglon = dataGridViewCorreos.Rows.Add();
				dataGridViewCorreos.Rows[renglon].Cells["Correo"].Value = lista[i];

			}
			
			lista.Clear();
		}
		
		void ButtonVerificarIDClick(object sender, EventArgs e)
		{
			//buscar empleado
			//buscar id:
			
			myConnection.ConnectionString = "server=localhost;password=;" +
				"database=sistema_memin; User Id=root";
			string sentence = "SELECT *FROM EMPLEADO WHERE ID_EMPLEADO = "+numericUpDownIDEmpleado.Value+";";
			var command = new MySqlCommand(sentence,myConnection);
			//var dataAdapter = new MySqlDataAdapter(command);
			myConnection.Open();
			MySqlDataReader myReader;
			myReader = command.ExecuteReader();
			
			if(myReader.Read()){
			  idEmpleadoAModificar = Convert.ToInt32(numericUpDownIDEmpleado.Value);
              textBoxNombre.Text =  myReader.GetString(myReader.GetOrdinal("NOMBRE"));
              textBoxApellidoPaterno.Text =  myReader.GetString(myReader.GetOrdinal("APELLIDO_PATERNO"));
              textBoxApellidoMaterno.Text =  myReader.GetString(myReader.GetOrdinal("APELLIDO_MATERNO"));
              comboBoxPuesto.Text = myReader.GetString(myReader.GetOrdinal("PUESTO"));
              buttonModificarNombre.Enabled = buttonModificarApellidoMaterno.Enabled = buttonModificarApellidoPaterno.Enabled = buttonModificarPuesto.Enabled = dataGridViewCorreos.Enabled = buttonModificarImagen.Enabled = dataGridViewTelefono.Enabled = true;
              getCorreos(myReader.GetString(6));
              getTelefonos(myReader.GetString(5));
              buttonModificar.Enabled = true;
               var datos = (byte[])myReader[8];
                 pictureBoxImagenCargada.Image = ByteArrayToImage(datos);
                 buttonModificarTodosLosCampos.Enabled = true;

			}else{
				MessageBox.Show("EMPLEADO NO ENCONTRADO","INFORMACIÓN",MessageBoxButtons.OK,MessageBoxIcon.Information);
			}
         	myConnection.Close();
         	myReader.Dispose();
         	command.Dispose();
		}
		void ButtonModificarClick(object sender, EventArgs e)
		{
			if(textBoxNombre.Text.Length > 1 && textBoxApellidoPaterno.Text.Length > 1 && textBoxNombre.Text.First() != ' ' && textBoxApellidoPaterno.Text.First() != ' '){
				
				//costo, tipo, ID y disponibilidad no hay problema.
				//descripcion, observaciones e imagen pueden ser nulos.
				
				obtenerCorreos();
				obtenerTelefonos();
			
				myConnection.ConnectionString="server=localhost;password=; database=sistema_memin; User Id=root";
				
				
				if(pictureBoxImagenCargada.Image != null){ //esta cubierta la imagen
					var memoryStream = new MemoryStream();
					pictureBoxImagenCargada.Image.Save(memoryStream,ImageFormat.Jpeg);
					
					
					string sentencia = "UPDATE EMPLEADO SET NOMBRE = @NOMBRE, PUESTO = @PUESTO, CORREO = @CORREO, TELEFONO = @TELEFONO, APELLIDO_PATERNO = @AP, APELLIDO_MATERNO = @AM, IMAGEN = @IMAGEN WHERE ID_EMPLEADO = "+idEmpleadoAModificar+";";
					
					
					myConnection.Open();
					var command = new MySqlCommand(sentencia,myConnection);
					
					command.Parameters.AddWithValue("@NOMBRE", textBoxNombre.Text);

					command.Parameters.AddWithValue("@PUESTO", comboBoxPuesto.SelectedItem.ToString());

					command.Parameters.AddWithValue("@CORREO", correos);

					command.Parameters.AddWithValue("@TELEFONO", telefonos);

					command.Parameters.AddWithValue("@AP", textBoxApellidoPaterno.Text);
					command.Parameters.AddWithValue("@AM", textBoxApellidoMaterno.Text);

					command.Parameters.Add("@IMAGEN",MySqlDbType.Binary).Value = memoryStream.GetBuffer();

					command.ExecuteNonQuery();
					command.Dispose();
					memoryStream.Dispose();
					myConnection.Close();
					

					MessageBox.Show("!MODIFICACIÓN REALIZADA CORRECTAMENTE!","INFORMACIÓN",MessageBoxButtons.OK,MessageBoxIcon.Information);
					
				}
				
				else{ //no está cubierta la imagen
					
					var memoryStream = new MemoryStream();
					pictureBoxImagenCargada.Image = new Bitmap(this.BackgroundImage);
					pictureBoxImagenCargada.Image.Save(memoryStream,ImageFormat.Jpeg);
					string sentencia = "UPDATE EMPLEADO SET NOMBRE = @NOMBRE, PUESTO = @PUESTO, CORREO = @CORREO, TELEFONO = @TELEFONO, APELLIDO_PATERNO = @AP, APELLIDO_MATERNO = @AM, IMAGEN = @IMAGEN WHERE ID_EMPLEADO = "+idEmpleadoAModificar+";";

					myConnection.Open();
					var command = new MySqlCommand(sentencia,myConnection);
					
					command.Parameters.AddWithValue("@NOMBRE", textBoxNombre.Text);

					command.Parameters.AddWithValue("@PUESTO", comboBoxPuesto.SelectedItem.ToString());

					command.Parameters.AddWithValue("@CORREO", correos);

					command.Parameters.AddWithValue("@TELEFONO", telefonos);

					command.Parameters.AddWithValue("@AP", textBoxApellidoPaterno.Text);
					command.Parameters.AddWithValue("@AM", textBoxApellidoMaterno.Text);

					command.Parameters.Add("@IMAGEN",MySqlDbType.Binary).Value = memoryStream.GetBuffer();

					command.ExecuteNonQuery();
					command.Dispose();
					memoryStream.Dispose();
					myConnection.Close();
					
					MessageBox.Show("!MODIFICACIÓN REALIZADA CORRECTAMENTE!","INFORMACIÓN",MessageBoxButtons.OK,MessageBoxIcon.Information);
					
				}
				
				//Limpiar
				textBoxApellidoPaterno.Clear();
				textBoxNombre.Clear();
				textBoxApellidoMaterno.Clear();
				comboBoxPuesto.Text = "";
				dataGridViewTelefono.Rows.Clear();
				dataGridViewCorreos.Rows.Clear();
				telefonos = correos = "";
				idEmpleadoAModificar = 1;
				pictureBoxImagenCargada.Image = null;
				buttonModificarImagen.Enabled = buttonModificarNombre.Enabled = buttonModificarApellidoMaterno.Enabled = buttonModificarApellidoPaterno.Enabled = 
              	buttonModificarPuesto.Enabled = buttonCargarImagen.Enabled =   buttonModificar.Enabled = false;
              	
				numericUpDownIDEmpleado.Enabled = buttonVerificarID.Enabled = true;
              
                textBoxNombre.Enabled = textBoxApellidoPaterno.Enabled = textBoxApellidoMaterno.Enabled = comboBoxPuesto.Enabled = dataGridViewTelefono.Enabled = dataGridViewCorreos.Enabled  = false;
				buttonModificarTodosLosCampos.Enabled = false;
				
			}
			else{
				MessageBox.Show("ERROR, ALGUNOS CAMPOS NO HAN SIDO LLENADOS CORRECTAMENTE O ESTAN MAL MODIFICADOS","ERROR",MessageBoxButtons.OK,MessageBoxIcon.Error);
			}
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
		void ButtonModificarNombreClick(object sender, EventArgs e)
		{
			textBoxNombre.Enabled = true;
			buttonModificarNombre.Enabled = false;
		}
		void ButtonModificarApellidoPaternoClick(object sender, EventArgs e)
		{
			textBoxApellidoPaterno.Enabled = true;
			buttonModificarApellidoPaterno.Enabled = false;
		}
		void ButtonModificarApellidoMaternoClick(object sender, EventArgs e)
		{
			textBoxApellidoMaterno.Enabled = true;
			buttonModificarApellidoMaterno.Enabled = false;
		}
		void ButtonModificarPuestoClick(object sender, EventArgs e)
		{
			comboBoxPuesto.Enabled = true;
			buttonModificarPuesto.Enabled = false;
		}
		void ButtonModificarImagenClick(object sender, EventArgs e)
		{
			buttonCargarImagen.Enabled = true;
			buttonModificarImagen.Enabled = false;
		}
		void ButtonModificarTodosLosCamposClick(object sender, EventArgs e)
		{
			buttonCargarImagen.Enabled = true;
			buttonModificarImagen.Enabled = false;
			comboBoxPuesto.Enabled = true;
			buttonModificarPuesto.Enabled = false;
			textBoxApellidoMaterno.Enabled = true;
			buttonModificarApellidoMaterno.Enabled = false;
			textBoxApellidoPaterno.Enabled = true;
			buttonModificarApellidoPaterno.Enabled = false;
			textBoxNombre.Enabled = true;
			buttonModificarNombre.Enabled = false;
			buttonModificarTodosLosCampos.Enabled = false;
		}
		void TextBoxNombreTextChanged(object sender, EventArgs e)
		{
			if(textBoxNombre.Text.Length > 0 && textBoxNombre.Text.Length < 35){
				if(!Char.IsLetter(textBoxNombre.Text.Last()) && textBoxNombre.Text.Last() != ' '){
					textBoxNombre.Text = textBoxNombre.Text.Substring(0,textBoxNombre.Text.Length-1);
					textBoxNombre.SelectionStart = textBoxNombre.Text.Length;
					textBoxNombre.Refresh();
				}
			}
			else if(textBoxNombre.Text.Length >= 35){
				textBoxNombre.Text = textBoxNombre.Text.Substring(0,textBoxNombre.Text.Length-1);
				textBoxNombre.SelectionStart = textBoxNombre.Text.Length;
				textBoxNombre.Refresh();
			}
		}
		void TextBoxApellidoPaternoTextChanged(object sender, EventArgs e)
		{
			if(textBoxApellidoPaterno.Text.Length > 0 && textBoxApellidoPaterno.Text.Length < 25){
				if(!Char.IsLetter(textBoxApellidoPaterno.Text.Last()) && textBoxApellidoPaterno.Text.Last() != ' '){
					textBoxApellidoPaterno.Text = textBoxApellidoPaterno.Text.Substring(0,textBoxApellidoPaterno.Text.Length-1);
					textBoxApellidoPaterno.SelectionStart = textBoxApellidoPaterno.Text.Length;
					textBoxApellidoPaterno.Refresh();
				}
			}else if(textBoxApellidoPaterno.Text.Length >= 25){
				textBoxApellidoPaterno.Text = textBoxApellidoPaterno.Text.Substring(0,textBoxApellidoPaterno.Text.Length-1);
				textBoxApellidoPaterno.SelectionStart = textBoxApellidoPaterno.Text.Length;
				textBoxApellidoPaterno.Refresh();
			}
		}
		void TextBoxApellidoMaternoTextChanged(object sender, EventArgs e)
		{
			if(textBoxApellidoMaterno.Text.Length > 0 && textBoxApellidoMaterno.Text.Length < 25){
				if(!Char.IsLetter(textBoxApellidoMaterno.Text.Last()) && textBoxApellidoMaterno.Text.Last() != ' '){
					textBoxApellidoMaterno.Text = textBoxApellidoMaterno.Text.Substring(0,textBoxApellidoMaterno.Text.Length-1);
					textBoxApellidoMaterno.SelectionStart = textBoxApellidoMaterno.Text.Length;
					textBoxApellidoMaterno.Refresh();
				}
			}else if(textBoxApellidoMaterno.Text.Length >= 25){
				textBoxApellidoMaterno.Text = textBoxApellidoMaterno.Text.Substring(0,textBoxApellidoMaterno.Text.Length-1);
				textBoxApellidoMaterno.SelectionStart = textBoxApellidoMaterno.Text.Length;
				textBoxApellidoMaterno.Refresh();
			}
		}
		
		

	}
}
