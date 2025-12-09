/*
 * Creado por SharpDevelop.
 * Usuario: Elia Martha
 * Fecha: 08/12/2025
 * Hora: 02:40 p. m.
 * 
 * Para cambiar esta plantilla use Herramientas | Opciones | Codificación | Editar Encabezados Estándar
 */
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace proyectoFinal
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
		
		void MainFormLoad(object sender, EventArgs e)
		{
			txtFechaActual.Text=DateTime.Now.ToString("dd/MM/yyyy");
		}
		
		void TxtUsuarioEnter(object sender, EventArgs e)
		{
			if(txtUsuario.Text=="USUARIO")
			{
				txtUsuario.Text="";
				txtUsuario.ForeColor=Color.LightGray;
			}
		}
		
		void TxtUsuarioLeave(object sender, EventArgs e)
		{
			if(txtUsuario.Text=="USUARIO")
			{
				txtUsuario.Text="";
				txtUsuario.ForeColor=Color.DimGray;
			}
		}
		
		void TxtContraseñaEnter(object sender, EventArgs e)
		{
			if(txtContraseña.Text=="CONTRASEÑA")
			{
				txtContraseña.Text="";
				txtContraseña.ForeColor=Color.LightGray;
				txtContraseña.UseSystemPasswordChar=true;
			}
		}
		
		void TxtContraseñaLeave(object sender, EventArgs e)
		{
			if(txtContraseña.Text=="CONTRASEÑA")
			{
				txtContraseña.Text="";
				txtContraseña.ForeColor=Color.DimGray;
				txtContraseña.UseSystemPasswordChar=false;
			}
		}
		
		void BtnAccederClick(object sender, EventArgs e)
		{
			if(txtUsuario.Text=="usuariobonito" | txtContraseña.Text=="admin123")
			{
				MessageBox.Show("Bienvenido/a");
			}else{
				MessageBox.Show("Usuario o contraseñas incorrectos");
			}
		}
	}
}
