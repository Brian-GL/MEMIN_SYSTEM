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
	/// Description of ComandasAsignadas.
	/// </summary>
	public partial class ComandasAsignadas : Form
	{
		MySqlConnection myConnection;
		int idEmpleado;
		public ComandasAsignadas(FormWindowState ws, Color c,int id)
		{
			//
			// The InitializeComponent() call is required for Windows Forms designer support.
			//
			InitializeComponent();
			
			//
			// TODO: Add constructor code after the InitializeComponent() call.
			//
			
			idEmpleado = id;
			
			this.WindowState = ws;
			this.panelFondo.BackColor = c;
			if(c.R >=240 || c.G >= 240 || c.B >= 240)
				labelTitulo.ForeColor = Color.Black;
			myConnection = new MySqlConnection();
			myConnection.ConnectionString="server=localhost;password=; database=sistema_memin; User Id=root";
			
		}
		void ComandasAsignadasFormClosing(object sender, FormClosingEventArgs e)
		{
			myConnection.Dispose();
			Dispose();
		}
	
		void DataGridViewComandasCellContentClick(object sender, DataGridViewCellEventArgs e)
		{
			if(e.ColumnIndex == 9){
				dataGridViewDetalleComanda.Rows.Clear();
				//mostrar detalle comanda:
				
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
		void ComandasAsignadasLoad(object sender, EventArgs e)
		{
			bool seEncontro = false;
			
			string sentencia = "SELECT ID_COMANDA,NOMBRE_CLIENTE,FECHA_CREACION,NUMERO_MESA,EMPLEADO.ID_EMPLEADO, EMPLEADO.NOMBRE, EMPLEADO.APELLIDO_PATERNO,TABLA1.ID_EMPLEADO, TABLA1.NOMBRE,TABLA1.APELLIDO_PATERNO, ESTATUS FROM COMANDA INNER JOIN EMPLEADO ON COMANDA.ID_EMPLEADO_MESERO = EMPLEADO.ID_EMPLEADO INNER JOIN EMPLEADO AS TABLA1 ON COMANDA.ID_EMPLEADO_COCINA = TABLA1.ID_EMPLEADO  WHERE ID_EMPLEADO_COCINA = "+idEmpleado+" AND ESTATUS = 'ASIGNADA A COCINERO'";
			myConnection.Open();
			var otherCommand = new MySqlCommand(sentencia,myConnection);
			MySqlDataReader myReader;
			myReader = otherCommand.ExecuteReader();
			
			while(myReader.Read()){
				seEncontro = true;
				int renglon = dataGridViewComandas.Rows.Add();
                dataGridViewComandas.Rows[renglon].Cells["ID_COMANDA_ENCONTRADA"].Value =  myReader.GetString(0);
                dataGridViewComandas.Rows[renglon].Cells["NOMBRE_CLIENTE"].Value = myReader.GetString(1);
                dataGridViewComandas.Rows[renglon].Cells["FECHA_CREACION"].Value = myReader.GetString(2);
                dataGridViewComandas.Rows[renglon].Cells["ESTATUS"].Value = myReader.GetString(10);
                dataGridViewComandas.Rows[renglon].Cells["NUMERO_MESA"].Value = myReader.GetString(3);
                dataGridViewComandas.Rows[renglon].Cells["ID_EMPLEADO"].Value = myReader.GetString(4);
                dataGridViewComandas.Rows[renglon].Cells["NOMBRE_MESERO"].Value = myReader.GetString(5) + " "+ myReader.GetString(6);	
				dataGridViewComandas.Rows[renglon].Cells["ID_EMPLEADO_COCINA"].Value =  myReader.GetString(7);
				dataGridViewComandas.Rows[renglon].Cells["NOMBRE_COCINERO"].Value =  myReader.GetString(8) +" " +myReader.GetString(9);
				dataGridViewComandas.Rows[renglon].Cells["MOSTRAR_DETALLE_COMANDA"].Value = "✔";
			}
			
			if(!seEncontro){
				MessageBox.Show("COMANDAS NO ENCONTRADAS","INFORMACIÓN",MessageBoxButtons.OK,MessageBoxIcon.Information);
			}
			
			
			myConnection.Close();
			myReader.Close();
			myReader.Dispose();
			otherCommand.Dispose();
		}
		
	}
}
