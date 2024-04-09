/*
 * Creado por SharpDevelop.
 * Usuario: Brian Gaytan Lomeli
 * Fecha: 21/10/2019
 * Hora: 9:33
 * 
 * Para cambiar esta plantilla use Herramientas | Opciones | Codificación | Editar Encabezados Estándar
 */
using System;
using System.Drawing;
using System.Windows.Forms;
using MySql.Data.MySqlClient;
using System.IO;
using System.Linq;

using System.Drawing.Imaging;

namespace MEMIN_SYSTEM
{
	/// <summary>
	/// Description of ModificarProductos.
	/// </summary>
	public partial class ModificarProductos : Form
	{
		
		MySqlConnection myConnection;
		int idProducto;
		public ModificarProductos(FormWindowState ws, Color c)
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
		void ModificarProductosFormClosing(object sender, FormClosingEventArgs e)
		{
			myConnection.Dispose();
			this.Dispose();
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
		void ButtonModificarClick(object sender, EventArgs e)
		{
			if(textBoxNombre.Text.Length > 1 && textBoxNombre.Text.First() != ' '){
				
				//costo, tipo, ID y disponibilidad no hay problema.
				//descripcion, observaciones e imagen pueden ser nulos.
				string valueCosto = numericUpDownCosto.Value.ToString();
				myConnection.ConnectionString="server=localhost;password=; database=sistema_memin; User Id=root";
				valueCosto = valueCosto.Replace(',','.');
				
				if(pictureBoxImagenCargada.Image != null){ //esta cubierta la imagen
					var memoryStream = new MemoryStream();
					pictureBoxImagenCargada.Image.Save(memoryStream,ImageFormat.Jpeg);
					
					
					string sentencia = "UPDATE PRODUCTO SET NOMBRE = @NOMBRE, TIPO = @TIPO, DESCRIPCION = @DESCRIPCION, OBSERVACIONES = @OBSERVACIONES, DISPONIBILIDAD = @DISPONIBILIDAD, COSTO = @COSTO, IMAGEN = @IMAGEN WHERE ID_PRODUCTO = "+idProducto+";";
					
					
					myConnection.Open();
					var command = new MySqlCommand(sentencia,myConnection);
					
					command.Parameters.AddWithValue("@NOMBRE", textBoxNombre.Text);

					command.Parameters.AddWithValue("@TIPO", comboBoxTipo.SelectedItem.ToString());

					command.Parameters.AddWithValue("@DESCRIPCION", textBoxDescripcion.Text);

					command.Parameters.AddWithValue("@OBSERVACIONES", textBoxObservaciones.Text);

					command.Parameters.AddWithValue("@DISPONIBILIDAD", comboBoxDisponibilidad.SelectedItem.ToString());

					command.Parameters.AddWithValue("@COSTO", valueCosto);

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
					
					
					string sentencia = "UPDATE PRODUCTO SET NOMBRE = @NOMBRE, TIPO = @TIPO, DESCRIPCION = @DESCRIPCION, OBSERVACIONES = @OBSERVACIONES, DISPONIBILIDAD = @DISPONIBILIDAD, COSTO = @COSTO, IMAGEN = @IMAGEN WHERE ID_PRODUCTO = "+idProducto+";";
					
					
					myConnection.Open();
					var command = new MySqlCommand(sentencia,myConnection);
					
					command.Parameters.AddWithValue("@NOMBRE", textBoxNombre.Text);

					command.Parameters.AddWithValue("@TIPO", comboBoxTipo.SelectedItem.ToString());

					command.Parameters.AddWithValue("@DESCRIPCION", textBoxDescripcion.Text);

					command.Parameters.AddWithValue("@OBSERVACIONES", textBoxObservaciones.Text);

					command.Parameters.AddWithValue("@DISPONIBILIDAD", comboBoxDisponibilidad.SelectedItem.ToString());

					command.Parameters.AddWithValue("@COSTO", valueCosto);

					command.Parameters.Add("@IMAGEN",MySqlDbType.Binary).Value = memoryStream.GetBuffer();
					idProducto = 1; 
					command.ExecuteNonQuery();
					command.Dispose();
					memoryStream.Dispose();
					myConnection.Close();
					

					MessageBox.Show("!MODIFICACIÓN REALIZADA CORRECTAMENTE!","INFORMACIÓN",MessageBoxButtons.OK,MessageBoxIcon.Information);
					
				}
				
				//Limpiar
				textBoxDescripcion.Clear();
				textBoxNombre.Clear();
				textBoxObservaciones.Clear();
				comboBoxDisponibilidad.Text = "";
				comboBoxTipo.Text = "";
				numericUpDownCosto.Value = 0;
				pictureBoxImagenCargada.Image = null;
				buttonModificarCosto.Enabled = buttonModificarDescripcion.Enabled = buttonModificarDisponibilidad.Enabled = buttonModificarImagen.Enabled = 
              	buttonModificarNombre.Enabled = buttonModificarObservaciones.Enabled =   buttonModificarTipo.Enabled = false;
              	buttonModificarTodosLosCampos.Enabled = false;
              	buttonModificar.Enabled = false;
				numericUpDownIDProducto.Enabled = buttonVerificarID.Enabled = true;
              
              	textBoxNombre.Enabled = textBoxObservaciones.Enabled = textBoxDescripcion.Enabled = comboBoxDisponibilidad.Enabled = comboBoxTipo.Enabled = numericUpDownCosto.Enabled = buttonCargarImagen.Enabled = false;
				
				
			}
			else{
				MessageBox.Show("ERROR, ALGUNOS CAMPOS NO HAN SIDO LLENADOS CORRECTAMENTE O ESTAN MAL MODIFICADOS","ERROR",MessageBoxButtons.OK,MessageBoxIcon.Error);
			}
			
		}

		void ButtonVerificarIDClick(object sender, EventArgs e)
		{
			
			//buscar id:
			myConnection.ConnectionString = "server=localhost;password=;" +
				"database=sistema_memin; User Id=root";
			string sentence = "SELECT *FROM PRODUCTO WHERE ID_PRODUCTO = "+numericUpDownIDProducto.Value+";";
			var command = new MySqlCommand(sentence,myConnection);
			//var dataAdapter = new MySqlDataAdapter(command);
			myConnection.Open();
			MySqlDataReader myReader;
			myReader = command.ExecuteReader();
			
			if(myReader.Read()){

			  idProducto = Convert.ToInt32(numericUpDownIDProducto.Value);
              textBoxNombre.Text =  myReader.GetString(myReader.GetOrdinal("NOMBRE"));
              comboBoxTipo.Text = myReader.GetString(myReader.GetOrdinal("TIPO"));
              textBoxDescripcion.Text =  myReader.GetString(myReader.GetOrdinal("DESCRIPCION"));
              comboBoxDisponibilidad.Text = myReader.GetString(myReader.GetOrdinal("DISPONIBILIDAD"));
              textBoxObservaciones.Text = myReader.GetString(myReader.GetOrdinal("OBSERVACIONES"));
              numericUpDownCosto.Value =  myReader.GetDecimal(myReader.GetOrdinal("COSTO"));
              var datos = (byte[])myReader[7];
              pictureBoxImagenCargada.Image = ByteArrayToImage(datos);
              buttonModificarCosto.Enabled = buttonModificarDescripcion.Enabled = buttonModificarDisponibilidad.Enabled = buttonModificarImagen.Enabled = 
              buttonModificarNombre.Enabled = buttonModificarObservaciones.Enabled =   buttonModificarTipo.Enabled = true;
              buttonModificarTodosLosCampos.Enabled = true;
              buttonModificar.Enabled = true;
              buttonModificarTodosLosCampos.Enabled = true;

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
		void ButtonModificarNombreClick(object sender, EventArgs e)
		{
			textBoxNombre.Enabled = true;
			buttonModificarNombre.Enabled = false;
		}
		void ButtonModificarTipoClick(object sender, EventArgs e)
		{
			comboBoxTipo.Enabled = true;
			buttonModificarTipo.Enabled = false;
		}
		void ButtonModificarCostoClick(object sender, EventArgs e)
		{
			numericUpDownCosto.Enabled = true;
			buttonModificarCosto.Enabled = false;
		}
		void ButtonModificarDisponibilidadClick(object sender, EventArgs e)
		{
			comboBoxDisponibilidad.Enabled = true;
			buttonModificarDisponibilidad.Enabled = false;
		}
		void ButtonModificarDescripcionClick(object sender, EventArgs e)
		{
			textBoxDescripcion.Enabled = true;
			buttonModificarDescripcion.Enabled = false;
		}
		void ButtonModificarImagenClick(object sender, EventArgs e)
		{
			buttonModificarImagen.Enabled = false;
			buttonCargarImagen.Enabled = true;
		}
		void ButtonModificarObservacionesClick(object sender, EventArgs e)
		{
			textBoxObservaciones.Enabled = true;
			buttonModificarObservaciones.Enabled = false;
		}
		void ButtonModificarTodosLosCamposClick(object sender, EventArgs e)
		{
			buttonModificarTodosLosCampos.Enabled = false;
			textBoxObservaciones.Enabled = true;
			buttonModificarObservaciones.Enabled = false;
			buttonModificarImagen.Enabled = false;
			buttonCargarImagen.Enabled = true;
			textBoxDescripcion.Enabled = true;
			buttonModificarDescripcion.Enabled = false;
			comboBoxDisponibilidad.Enabled = true;
			buttonModificarDisponibilidad.Enabled = false;
			numericUpDownCosto.Enabled = true;
			buttonModificarCosto.Enabled = false;
			comboBoxTipo.Enabled = true;
			buttonModificarTipo.Enabled = false;
			textBoxNombre.Enabled = true;
			buttonModificarNombre.Enabled = false;
		}
		void TextBoxNombreTextChanged(object sender, EventArgs e)
		{
			if(textBoxNombre.Text.Length > 0){
				if(!Char.IsLetter(textBoxNombre.Text.Last()) && textBoxNombre.Text.Last() != ' '){
					textBoxNombre.Text = textBoxNombre.Text.Substring(0,textBoxNombre.Text.Length-1);
					textBoxNombre.SelectionStart = textBoxNombre.Text.Length;
					textBoxNombre.Refresh();
				}
			}
		}




		

	}
}
