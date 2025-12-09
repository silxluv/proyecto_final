/*
 * Creado por SharpDevelop.
 * Usuario: Elia Martha
 * Fecha: 08/12/2025
 * Hora: 02:40 p. m.
 * 
 * Para cambiar esta plantilla use Herramientas | Opciones | Codificación | Editar Encabezados Estándar
 */
namespace proyectoFinal
{
	partial class MainForm
	{
		/// <summary>
		/// Designer variable used to keep track of non-visual components.
		/// </summary>
		private System.ComponentModel.IContainer components = null;
		
		/// <summary>
		/// Disposes resources used by the form.
		/// </summary>
		/// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		protected override void Dispose(bool disposing)
		{
			if (disposing) {
				if (components != null) {
					components.Dispose();
				}
			}
			base.Dispose(disposing);
		}
		
		/// <summary>
		/// This method is required for Windows Forms designer support.
		/// Do not change the method contents inside the source code editor. The Forms designer might
		/// not be able to load this method if it was changed manually.
		/// </summary>
		private void InitializeComponent()
		{
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
			this.pictureBox1 = new System.Windows.Forms.PictureBox();
			this.txtUsuario = new System.Windows.Forms.TextBox();
			this.txtContraseña = new System.Windows.Forms.TextBox();
			this.btnAcceder = new System.Windows.Forms.Button();
			this.txtFechaActual = new System.Windows.Forms.TextBox();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
			this.SuspendLayout();
			// 
			// pictureBox1
			// 
			this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
			this.pictureBox1.Location = new System.Drawing.Point(12, 12);
			this.pictureBox1.Name = "pictureBox1";
			this.pictureBox1.Size = new System.Drawing.Size(285, 285);
			this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
			this.pictureBox1.TabIndex = 0;
			this.pictureBox1.TabStop = false;
			// 
			// txtUsuario
			// 
			this.txtUsuario.BackColor = System.Drawing.Color.LavenderBlush;
			this.txtUsuario.BorderStyle = System.Windows.Forms.BorderStyle.None;
			this.txtUsuario.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.txtUsuario.ForeColor = System.Drawing.Color.MediumVioletRed;
			this.txtUsuario.Location = new System.Drawing.Point(327, 82);
			this.txtUsuario.Name = "txtUsuario";
			this.txtUsuario.Size = new System.Drawing.Size(308, 20);
			this.txtUsuario.TabIndex = 1;
			this.txtUsuario.Text = "USUARIO:";
			this.txtUsuario.Enter += new System.EventHandler(this.TxtUsuarioEnter);
			this.txtUsuario.Leave += new System.EventHandler(this.TxtUsuarioLeave);
			// 
			// txtContraseña
			// 
			this.txtContraseña.BackColor = System.Drawing.Color.LavenderBlush;
			this.txtContraseña.BorderStyle = System.Windows.Forms.BorderStyle.None;
			this.txtContraseña.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.txtContraseña.ForeColor = System.Drawing.Color.MediumVioletRed;
			this.txtContraseña.Location = new System.Drawing.Point(327, 120);
			this.txtContraseña.Name = "txtContraseña";
			this.txtContraseña.Size = new System.Drawing.Size(308, 20);
			this.txtContraseña.TabIndex = 2;
			this.txtContraseña.Text = "CONTRASEÑA:";
			this.txtContraseña.Enter += new System.EventHandler(this.TxtContraseñaEnter);
			this.txtContraseña.Leave += new System.EventHandler(this.TxtContraseñaLeave);
			// 
			// btnAcceder
			// 
			this.btnAcceder.BackColor = System.Drawing.Color.Thistle;
			this.btnAcceder.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnAcceder.Location = new System.Drawing.Point(385, 174);
			this.btnAcceder.Name = "btnAcceder";
			this.btnAcceder.Size = new System.Drawing.Size(195, 40);
			this.btnAcceder.TabIndex = 3;
			this.btnAcceder.Text = "Acceder";
			this.btnAcceder.UseVisualStyleBackColor = false;
			this.btnAcceder.Click += new System.EventHandler(this.BtnAccederClick);
			// 
			// txtFechaActual
			// 
			this.txtFechaActual.Location = new System.Drawing.Point(434, 276);
			this.txtFechaActual.Name = "txtFechaActual";
			this.txtFechaActual.Size = new System.Drawing.Size(100, 20);
			this.txtFechaActual.TabIndex = 4;
			// 
			// MainForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.Color.LavenderBlush;
			this.ClientSize = new System.Drawing.Size(656, 308);
			this.Controls.Add(this.txtFechaActual);
			this.Controls.Add(this.btnAcceder);
			this.Controls.Add(this.txtContraseña);
			this.Controls.Add(this.txtUsuario);
			this.Controls.Add(this.pictureBox1);
			this.Name = "MainForm";
			this.Text = "LogIn (Usuario y contraseña)";
			this.Load += new System.EventHandler(this.MainFormLoad);
			((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();
		}
		private System.Windows.Forms.TextBox txtFechaActual;
		private System.Windows.Forms.Button btnAcceder;
		private System.Windows.Forms.TextBox txtContraseña;
		private System.Windows.Forms.TextBox txtUsuario;
		private System.Windows.Forms.PictureBox pictureBox1;
	}
}
