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
using System.Drawing.Imaging;
using System.Linq;


namespace MEMIN_SYSTEM
{
	/// <summary>
	/// Description of RegistrarProductos.
	/// </summary>
	public partial class RegistrarProductos : Form
	{
		
		MySqlConnection myConnection = new MySqlConnection();
		int indice;
		public RegistrarProductos(FormWindowState ws, Color c)
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
			
			myConnection.ConnectionString="server=localhost;password=; database=sistema_memin; User Id=root";
			const string sentence = "SELECT COUNT(ID_PRODUCTO) AS LAST_ID FROM PRODUCTO";
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
			
			

		}
		void RegistrarProductosFormClosing(object sender, FormClosingEventArgs e)
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
		void ButtonGuardarClick(object sender, EventArgs e)
		{
			//Guardamos:
			
			if(textBoxNombre.Text.Length > 1 && textBoxNombre.Text.First() != ' '){
				
				//costo, tipo, ID y disponibilidad no hay problema.
				//descripcion, observaciones e imagen pueden ser nulos.
				
				if(pictureBoxImagenCargada.Image != null){ //esta cubierta la imagen
					
					var memoryStream = new MemoryStream();
					pictureBoxImagenCargada.Image.Save(memoryStream,ImageFormat.Jpeg);

					string valueCosto = numericUpDownCosto.Value.ToString();
					valueCosto = valueCosto.Replace(',','.');
					myConnection.Open();
					string sentencia = "INSERT INTO PRODUCTO VALUES("+int.Parse(textBoxID.Text)+",'"+textBoxNombre.Text+"', " +
						"'"+comboBoxTipo.SelectedItem+"','"+textBoxDescripcion.Text+"',"+valueCosto+",'"+comboBoxDisponibilidad.SelectedItem+"'," +
					"'"+textBoxObservaciones.Text+"',@Imagen)";
					var command = new MySqlCommand(sentencia,myConnection);
					command.Parameters.AddWithValue("@Imagen",memoryStream.ToArray());
					command.ExecuteNonQuery();
					command.Dispose();
					memoryStream.Dispose();
					myConnection.Close();
					
				}
				
				else{ //no está cubierta la imagen
					
					var memoryStream = new MemoryStream();
					pictureBoxImagenCargada.Image = new Bitmap(this.BackgroundImage);
					pictureBoxImagenCargada.Image.Save(memoryStream,ImageFormat.Jpeg);

					string valueCosto = numericUpDownCosto.Value.ToString();
					valueCosto = valueCosto.Replace(',','.');
					myConnection.Open();
					string sentencia = "INSERT INTO PRODUCTO VALUES("+int.Parse(textBoxID.Text)+",'"+textBoxNombre.Text+"', " +
						"'"+comboBoxTipo.SelectedItem+"','"+textBoxDescripcion.Text+"',"+valueCosto+",'"+comboBoxDisponibilidad.SelectedItem+"'," +
					"'"+textBoxObservaciones.Text+"',@Imagen)";
					var command = new MySqlCommand(sentencia,myConnection);
					command.Parameters.AddWithValue("@Imagen",memoryStream.ToArray());
					command.ExecuteNonQuery();
					command.Dispose();
					memoryStream.Dispose();
					myConnection.Close();
					
				}
				
				MessageBox.Show(textBoxNombre.Text+" HA SIDO ALMACENADO CORRECTAMENTE");
				indice++;
				textBoxID.Text = indice.ToString();
				
				//Limpiar
				textBoxDescripcion.Clear();
				textBoxNombre.Clear();
				textBoxObservaciones.Clear();
				numericUpDownCosto.Value = 0;
				pictureBoxImagenCargada.Image = null;
				
			}
			else{
				MessageBox.Show("ERROR, ALGUNOS CAMPOS NO HAN SIDO LLENADOS CORRECTAMENTE","ERROR",MessageBoxButtons.OK,MessageBoxIcon.Error);
			}
			
		}

		void ButtonLimpiarClick(object sender, EventArgs e)
		{
			textBoxDescripcion.Clear();
			textBoxNombre.Clear();
			textBoxObservaciones.Clear();
			numericUpDownCosto.Value = 0;
			pictureBoxImagenCargada.Image = null;
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
