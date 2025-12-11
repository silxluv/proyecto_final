/*
 * Creado por SharpDevelop.
 * Usuario: Elia Martha
 * Fecha: 08/12/2025
 * Hora: 06:23 p. m.
 * 
 * Para cambiar esta plantilla use Herramientas | Opciones | Codificación | Editar Encabezados Estándar
 */
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace detalles_empleado
{
	/// <summary>
	/// Description of MainForm.
	/// </summary>
	public partial class MainForm : Form
	{
		List<clsLista> miLista = new List<clsLista>();
		public MainForm()
		{
			//
			// The InitializeComponent() call is required for Windows Forms designer support.
			//
			InitializeComponent();
			
			//
			// TODO: Add constructor code after the InitializeComponent() call.
			//
		}
		
		void BtnGuardarClick(object sender, EventArgs e)
		{
			if(ValidarNombre() == false )
			{
				return;
			}
			
			if(ValidarCodigo() == false )
			{
				return;
			}
			//Esto es la creacion del objeto de la clase "lista"
			clsLista empleado = new clsLista();
			empleado.Nombre = txtNombre.Text;
			empleado.Codigo = int.Parse(txtCodigo.Text);
			empleado.Puesto = cboPuesto.SelectedItem.ToString();
			empleado.Estado =cboEstado.SelectedItem.ToString();
			empleado.Sexo = cboSexo.SelectedItem.ToString();
			miLista.Add(empleado);
			dgvDatos.DataSource = null;
			dgvDatos.DataSource = miLista;
			LimpiarControles();
			txtNombre.Focus();
		}
		
		//Para cuidar que no se ingrese el nombre del empleado otra vez
		private bool Existe(string Nombre)
		{
			foreach(clsLista empleado in miLista)
			{
				if(empleado.Nombre == Nombre)
				{
					return true;
				}
			}
			return false;
		}
		
		//Para validar el nombre del empleado
		private bool ValidarNombre()
		{
			if(string.IsNullOrEmpty(txtNombre.Text))
			{
				erpError.SetError(txtNombre,"Debe ingresar un nombre");
				return false;
			}
			else
			{
				erpError.SetError(txtNombre,"");
				return true;
			}
		}
		
		//Para validar el codigo del empleado
		private bool ValidarCodigo()
		{
			int codigo;
			if(!int.TryParse(txtCodigo.Text, out codigo) || txtCodigo.Text == "")
			{
				erpError.SetError(txtCodigo, "Debe ingresar un valor numerico para el codigo de empleado");
				txtCodigo.Clear();
				txtCodigo .Focus();
				return false;
			}
			else
			{
				erpError.SetError(txtCodigo,"");
				return true;
			}
		}
		
		//Para limpiar los controles
		private void LimpiarControles()
		{
			txtNombre.Clear();
			txtCodigo.Clear();
			cboEstado.SelectedIndex = 0;
			cboPuesto.SelectedIndex = 0;
			cboSexo.SelectedIndex = 0;
		}
		
		void BtnEliminarClick(object sender, EventArgs e)
		{
			if(txtNombre.Text=="")
			{
				erpError.SetError(txtNombre,"Debe consultar su nombre para eliminar");
				LimpiarControles();
				txtNombre.Focus();
				return;
			}
			else
			{
				erpError.SetError(txtNombre,"");
				//Aqui pregunta al usuario si esta seguro de querer eliminar el registro
				DialogResult Respuesta = MessageBox.Show("¿Esta seguro de eliminar el registro","Confirmacion",MessageBoxButtons.YesNo,MessageBoxIcon.Question,MessageBoxDefaultButton.Button2);
				if(Respuesta == DialogResult.Yes)
				{
					foreach(clsLista empleado in miLista)
					{
						if(empleado.Nombre == txtNombre.Text)
						{
							miLista.Remove(empleado);
							break;
						}
					}
					LimpiarControles();
					dgvDatos.DataSource = null;
					dgvDatos.DataSource = miLista;
				}
			}
		}
		
		void BtnBuscarClick(object sender, EventArgs e)
		{
			//Hice esto para que el empleado cargara una foto de si mismo
			OpenFileDialog BuscarImagen = new OpenFileDialog();
			BuscarImagen.Filter="Archivos de imagen|*.png";
			BuscarImagen.FileName="";
			BuscarImagen.InitialDirectory="C:\\";
			BuscarImagen.FileName=this.txtRutaArchivo.Text;
			if(BuscarImagen.ShowDialog()==DialogResult.OK)
			{
				this.txtRutaArchivo.Text=BuscarImagen.FileName;
				String Direccion=BuscarImagen.FileName;
				this.picEmpleado.ImageLocation=Direccion;
				picEmpleado.SizeMode= PictureBoxSizeMode.StretchImage;
			}
		}
	}
}
