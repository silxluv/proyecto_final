/*
 * Creado por SharpDevelop.
 * Usuario: Elia Martha
 * Fecha: 11/12/2025
 * Hora: 12:44 p. m.
 * 
 * Para cambiar esta plantilla use Herramientas | Opciones | Codificación | Editar Encabezados Estándar
 */
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace boletaCalificaciones
{
	/// <summary>
	/// Description of MainForm.
	/// </summary>
	public partial class MainForm : Form
	{
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
		
		void BtnRegistrarClick(object sender, EventArgs e)
		{
			if(cboEspecialidad.SelectedIndex == -1)
			{
				MessageBox.Show("Debe seleccionar su especialidad");
			}
			else if(cboSemestre.SelectedIndex == -1)
			{
				MessageBox.Show("Debe seleccionar en que grado esta");
			}
			else if(cboMateria.SelectedIndex == -1)
			{
				MessageBox.Show("Debe seleccionar una materia");
			}
			else
			{
				//Esto es para capturar los datos :p
				string materia = cboMateria.Text;
				int parcial1 = Convert.ToInt32(txtp1.Text);
				int parcial2 = Convert.ToInt32(txtp2.Text);
				int parcial3 = Convert.ToInt32(txtp3.Text);
				//Esto es para calcular el promedio de la materia y si esta aprobado o reprobado
				double promedio=Convert.ToInt32((parcial1+parcial2+parcial3)/3);
				if(promedio>=6)
				{
					columnHeader6.Text="Aprobado";
				}
				else
				{
					columnHeader6.Text="Reprobado";
				}
				//Para el promedio general
				double promGral=(promedio+promedio+promedio)/3;
				lblPromedioGral.Text=String.Format("{0:F2}",promGral);
				//Para mostrar los resultados en la ListView
				ListViewItem fila= new ListViewItem(materia);
				fila.SubItems.Add(materia);
				fila.SubItems.Add(parcial1.ToString());
				fila.SubItems.Add(parcial2.ToString());
				fila.SubItems.Add(parcial3.ToString());
				fila.SubItems.Add(promedio.ToString());
				lvCalificacion.Items.Add(fila);
				BtnCancelarClick(sender, e);
			}
		}
		
		void BtnCancelarClick(object sender, EventArgs e)
		{
			cboEspecialidad.Text="(Seleccione su especialidad)";
			cboMateria.Text="(Seleccione una materia)";
			cboSemestre.Text="(Seleccione su grado)";
			txtp1.Text="";
			txtp2.Text="";
			txtp3.Text="";
			txtNombre.Text="";
		}
		
		void BtnSalirClick(object sender, EventArgs e)
		{
			Close();
		}
	}
}
