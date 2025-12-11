/*
 * Creado por SharpDevelop.
 * Usuario: CC2_PC05
 * Fecha: 10/12/2025
 * Hora: 06:12 p. m.
 * 
 * Para cambiar esta plantilla use Herramientas | Opciones | Codificación | Editar Encabezados Estándar
 */
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace circunferencia22222
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
		
		
		
		void BtnCalcularClick(object sender, EventArgs e)
		{
			double radio, perimetro;
            if 
                (double.TryParse(txtRadio.Text, out radio))
            {
                perimetro = 2 * Math.PI * radio;
                lblResultado.Text = perimetro.ToString("0.00");
            }
            else
            {
                MessageBox.Show("Ingrese un valor numerico valido");
            }

		}
	}
}
