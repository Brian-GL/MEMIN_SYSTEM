/*
 * Creado por SharpDevelop.
 * Usuario: Brian Gaytan Lomeli
 * Fecha: 17/11/2019
 * Hora: 16:15
 * 
 * Para cambiar esta plantilla use Herramientas | Opciones | Codificación | Editar Encabezados Estándar
 */
using System;
using System.Windows.Forms;
using System.Drawing;
using System.Collections.Generic;
using System.Drawing.Imaging;

namespace MEMIN_SYSTEM
{
	/// <summary>
	/// Description of Empleado.
	/// </summary>
	public class Empleado
	{
		public int ID_EMPLEADO;
		public string NOMBRE;
		public string APELLIDO_PATERNO; 
		public string PUESTO;
		public Image IMAGEN;
		
		public Empleado(){

		}
		
		public void Liberar(){
			ID_EMPLEADO = 0;
			NOMBRE = APELLIDO_PATERNO = PUESTO = "";
			IMAGEN = null;
		}

	}
}
