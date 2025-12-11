/*
 * Created by SharpDevelop.
 * User: CC2_PC05
 * Date: 10/12/2025
 * Time: 05:48 p. m.
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace Circunferencia
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
		
		void LblResultadoClick(object sender, EventArgs e)
		{
			
		}
	}
}
