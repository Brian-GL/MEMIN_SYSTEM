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
using MySql.Data.MySqlClient;
using System.IO;
using System.Collections.Generic;
using System.Text.RegularExpressions;
using System.Drawing.Imaging;
using System.Linq;

namespace MEMIN_SYSTEM
{
	/// <summary>
	/// Description of RegistrarEmpleados.
	/// </summary>
	public partial class RegistrarEmpleados : Form
	{
		MySqlConnection myConnection = new MySqlConnection();
		int indice;
		string correos;
		string telefonos;
		public RegistrarEmpleados(FormWindowState ws, Color c)
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
			telefonos = "";
			correos = "";
			myConnection.ConnectionString="server=localhost;password=; database=sistema_memin; User Id=root";
			const string sentence = "SELECT COUNT(ID_EMPLEADO) AS LAST_ID FROM EMPLEADO";
			var command = new MySqlCommand(sentence,myConnection);
			myConnection.Open();
			MySqlDataReader myReader;
			myReader = command.ExecuteReader();
			
			if(myReader.Read())
				indice  = int.Parse(myReader.GetString(0))+1;
			
			textBoxID.Text = indice.ToString();
			
			myReader.Dispose();
			command.Dispose();
			myConnection.Close();
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
	
		void RegistrarEmpleadosFormClosing(object sender, FormClosingEventArgs e)
		{
			myConnection.Dispose();
			this.Dispose();
		}
		void ButtonLimpiarClick(object sender, EventArgs e)
		{
			
			textBoxApellidoMaterno.Clear();
			textBoxApellidoPaterno.Clear();
			textBoxNombre.Clear();
			pictureBoxImagenCargada.Image = null;
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
			
			return (telefono.Length == 10) ? true : false;
			
		}
		
		void ButtonGuardarClick(object sender, EventArgs e)
		{
			if(textBoxNombre.Text.Length > 1 && textBoxApellidoPaterno.Text.Length > 1 && textBoxNombre.Text.First() != ' ' && textBoxApellidoPaterno.Text.First() != ' '){
				obtenerCorreos();
					obtenerTelefonos();
					
				if(pictureBoxImagenCargada.Image != null){ //esta cubierta la imagen
					
					var memoryStream = new MemoryStream();
					pictureBoxImagenCargada.Image.Save(memoryStream,ImageFormat.Jpeg);

					myConnection.Open();
					const string sentencia = "INSERT INTO EMPLEADO VALUES(@ID,@NOMBRE,@APELLIDO_PATERNO,@APELLIDO_MATERNO,@PUESTO,@TELEFONOS,@CORREOS,@PASSWORD,@IMAGEN);";
					var command = new MySqlCommand(sentencia,myConnection);
					command.Parameters.AddWithValue("@ID",int.Parse(textBoxID.Text));
					command.Parameters.AddWithValue("@NOMBRE", textBoxNombre.Text);
					command.Parameters.AddWithValue("@APELLIDO_PATERNO", textBoxApellidoPaterno.Text);
					command.Parameters.AddWithValue("@APELLIDO_MATERNO", textBoxApellidoMaterno.Text);
					command.Parameters.AddWithValue("@PUESTO", comboBoxPuesto.Items[comboBoxPuesto.SelectedIndex].ToString());
					command.Parameters.AddWithValue("@TELEFONOS", telefonos);
					command.Parameters.AddWithValue("@CORREOS", correos);
					command.Parameters.AddWithValue("@PASSWORD","");
					command.Parameters.Add("@IMAGEN",MySqlDbType.Binary).Value = memoryStream.GetBuffer();
					command.ExecuteNonQuery();
					command.Dispose();
					memoryStream.Dispose();
					myConnection.Close();
					
				}
				
				else{ //no está cubierta la imagen
					
					var memoryStream = new MemoryStream();
					pictureBoxImagenCargada.Image = new Bitmap(this.BackgroundImage);
					pictureBoxImagenCargada.Image.Save(memoryStream,ImageFormat.Jpeg);
					myConnection.Open();
					const string sentencia = "INSERT INTO EMPLEADO VALUES(@ID,@NOMBRE,@APELLIDO_PATERNO,@APELLIDO_MATERNO,@PUESTO,@TELEFONOS,@CORREOS,@PASSWORD,@IMAGEN);";
					var command = new MySqlCommand(sentencia,myConnection);
					command.Parameters.AddWithValue("@ID",int.Parse(textBoxID.Text));
					command.Parameters.AddWithValue("@NOMBRE", textBoxNombre.Text);
					command.Parameters.AddWithValue("@APELLIDO_PATERNO", textBoxApellidoPaterno.Text);
					command.Parameters.AddWithValue("@APELLIDO_MATERNO", textBoxApellidoMaterno.Text);
					command.Parameters.AddWithValue("@TELEFONOS", telefonos);
					command.Parameters.AddWithValue("@CORREOS", correos);
					command.Parameters.AddWithValue("@PUESTO", comboBoxPuesto.Items[comboBoxPuesto.SelectedIndex].ToString());
					command.Parameters.AddWithValue("@PASSWORD","");
					command.Parameters.Add("@IMAGEN",MySqlDbType.Binary).Value = memoryStream.GetBuffer();
					command.ExecuteNonQuery();
					command.Dispose();
					memoryStream.Dispose();
					myConnection.Close();
					
				}
				
				indice++;
				textBoxID.Text = indice.ToString();
				MessageBox.Show(textBoxNombre.Text+" HA SIDO ALMACENADO CORRECTAMENTE");
		
				textBoxID.Text = indice.ToString();
				telefonos = "";
				correos = "";
				//Limpiar
				dataGridViewTelefono.Rows.Clear();
				dataGridViewCorreos.Rows.Clear();
				textBoxApellidoMaterno.Clear();
				textBoxApellidoPaterno.Clear();
				textBoxNombre.Clear();
				pictureBoxImagenCargada.Image = null;
			}
			else{
				MessageBox.Show("ERROR, ALGUNOS CAMPOS NO HAN SIDO LLENADOS CORRECTAMENTE","ERROR",MessageBoxButtons.OK,MessageBoxIcon.Error);
			}
		}
		void DataGridViewCorreosCellContentDoubleClick(object sender, DataGridViewCellEventArgs e)
		{
			
			if(dataGridViewCorreos.Rows[e.RowIndex].Cells["Correo"].Value.ToString().Length != 0){
			var result = MessageBox.Show("¿ESTÁ SEGURO DE ELIMINAR TAL CORREO?","PREGUNTA",MessageBoxButtons.YesNo,MessageBoxIcon.Question);
			if(result == DialogResult.Yes)
				dataGridViewCorreos.Rows.RemoveAt(e.RowIndex);
			}
		}
		void DataGridViewTelefonoCellContentDoubleClick(object sender, DataGridViewCellEventArgs e)
		{
			if(dataGridViewTelefono.Rows[e.RowIndex].Cells["Telefono"].Value !=  null){
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
			if(dataGridViewCorreos.Rows[e.RowIndex].Cells["Correo"].Value !=  null){
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
