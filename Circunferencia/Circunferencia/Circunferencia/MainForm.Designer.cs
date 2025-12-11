/*
 * Created by SharpDevelop.
 * User: CC2_PC05
 * Date: 10/12/2025
 * Time: 05:48 p. m.
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
namespace Circunferencia
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
			this.lblTitulo = new System.Windows.Forms.Label();
			this.lblRadio = new System.Windows.Forms.Label();
			this.txtRadio = new System.Windows.Forms.TextBox();
			this.btnCalcular = new System.Windows.Forms.Button();
			this.lblPerimetro = new System.Windows.Forms.Label();
			this.lblResultado = new System.Windows.Forms.Label();
			this.pictureBox1 = new System.Windows.Forms.PictureBox();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
			this.SuspendLayout();
			// 
			// lblTitulo
			// 
			this.lblTitulo.Font = new System.Drawing.Font("Stencil", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lblTitulo.Location = new System.Drawing.Point(12, 21);
			this.lblTitulo.Name = "lblTitulo";
			this.lblTitulo.Size = new System.Drawing.Size(473, 23);
			this.lblTitulo.TabIndex = 0;
			this.lblTitulo.Text = "Calcular el perimetro de circunferencia";
			// 
			// lblRadio
			// 
			this.lblRadio.Font = new System.Drawing.Font("Stencil", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lblRadio.Location = new System.Drawing.Point(103, 72);
			this.lblRadio.Name = "lblRadio";
			this.lblRadio.Size = new System.Drawing.Size(100, 23);
			this.lblRadio.TabIndex = 1;
			this.lblRadio.Text = "Radio :";
			// 
			// txtRadio
			// 
			this.txtRadio.Font = new System.Drawing.Font("Stencil", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.txtRadio.Location = new System.Drawing.Point(209, 69);
			this.txtRadio.Name = "txtRadio";
			this.txtRadio.Size = new System.Drawing.Size(177, 32);
			this.txtRadio.TabIndex = 2;
			// 
			// btnCalcular
			// 
			this.btnCalcular.Font = new System.Drawing.Font("Stencil", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnCalcular.Location = new System.Drawing.Point(181, 116);
			this.btnCalcular.Name = "btnCalcular";
			this.btnCalcular.Size = new System.Drawing.Size(125, 46);
			this.btnCalcular.TabIndex = 3;
			this.btnCalcular.Text = "Calcular";
			this.btnCalcular.UseVisualStyleBackColor = true;
			this.btnCalcular.Click += new System.EventHandler(this.BtnCalcularClick);
			// 
			// lblPerimetro
			// 
			this.lblPerimetro.Font = new System.Drawing.Font("Stencil", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lblPerimetro.Location = new System.Drawing.Point(103, 280);
			this.lblPerimetro.Name = "lblPerimetro";
			this.lblPerimetro.Size = new System.Drawing.Size(145, 23);
			this.lblPerimetro.TabIndex = 4;
			this.lblPerimetro.Text = "Perimetro :";
			// 
			// lblResultado
			// 
			this.lblResultado.Font = new System.Drawing.Font("Stencil", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lblResultado.Location = new System.Drawing.Point(248, 280);
			this.lblResultado.Name = "lblResultado";
			this.lblResultado.Size = new System.Drawing.Size(237, 23);
			this.lblResultado.TabIndex = 5;
			this.lblResultado.Click += new System.EventHandler(this.LblResultadoClick);
			// 
			// pictureBox1
			// 
			this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
			this.pictureBox1.Location = new System.Drawing.Point(84, 168);
			this.pictureBox1.Name = "pictureBox1";
			this.pictureBox1.Size = new System.Drawing.Size(317, 101);
			this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
			this.pictureBox1.TabIndex = 6;
			this.pictureBox1.TabStop = false;
			// 
			// MainForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(495, 312);
			this.Controls.Add(this.pictureBox1);
			this.Controls.Add(this.lblResultado);
			this.Controls.Add(this.lblPerimetro);
			this.Controls.Add(this.btnCalcular);
			this.Controls.Add(this.txtRadio);
			this.Controls.Add(this.lblRadio);
			this.Controls.Add(this.lblTitulo);
			this.Name = "MainForm";
			this.Text = "Circunferencia";
			((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();
		}
		private System.Windows.Forms.PictureBox pictureBox1;
		private System.Windows.Forms.Label lblResultado;
		private System.Windows.Forms.Label lblPerimetro;
		private System.Windows.Forms.Button btnCalcular;
		private System.Windows.Forms.TextBox txtRadio;
		private System.Windows.Forms.Label lblRadio;
		private System.Windows.Forms.Label lblTitulo;
	}
}
