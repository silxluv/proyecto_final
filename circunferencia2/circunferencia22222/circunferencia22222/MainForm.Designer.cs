/*
 * Creado por SharpDevelop.
 * Usuario: CC2_PC05
 * Fecha: 10/12/2025
 * Hora: 06:12 p. m.
 * 
 * Para cambiar esta plantilla use Herramientas | Opciones | Codificación | Editar Encabezados Estándar
 */
namespace circunferencia22222
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
			this.btnCalcular = new System.Windows.Forms.Button();
			this.txtRadio = new System.Windows.Forms.TextBox();
			this.lblPerimetro = new System.Windows.Forms.Label();
			this.lblResultado = new System.Windows.Forms.Label();
			this.pictureBox1 = new System.Windows.Forms.PictureBox();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
			this.SuspendLayout();
			// 
			// lblTitulo
			// 
			this.lblTitulo.Font = new System.Drawing.Font("Stencil", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lblTitulo.Location = new System.Drawing.Point(12, 19);
			this.lblTitulo.Name = "lblTitulo";
			this.lblTitulo.Size = new System.Drawing.Size(471, 23);
			this.lblTitulo.TabIndex = 0;
			this.lblTitulo.Text = "Calcular el perimetro de circunferencia";
			// 
			// lblRadio
			// 
			this.lblRadio.Font = new System.Drawing.Font("Stencil", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lblRadio.Location = new System.Drawing.Point(86, 62);
			this.lblRadio.Name = "lblRadio";
			this.lblRadio.Size = new System.Drawing.Size(100, 23);
			this.lblRadio.TabIndex = 1;
			this.lblRadio.Text = "Radio :";
			// 
			// btnCalcular
			// 
			this.btnCalcular.Font = new System.Drawing.Font("Stencil", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnCalcular.Location = new System.Drawing.Point(169, 97);
			this.btnCalcular.Name = "btnCalcular";
			this.btnCalcular.Size = new System.Drawing.Size(128, 42);
			this.btnCalcular.TabIndex = 2;
			this.btnCalcular.Text = "Calcular";
			this.btnCalcular.UseVisualStyleBackColor = true;
			this.btnCalcular.Click += new System.EventHandler(this.BtnCalcularClick);
			// 
			// txtRadio
			// 
			this.txtRadio.Font = new System.Drawing.Font("Stencil", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.txtRadio.Location = new System.Drawing.Point(192, 59);
			this.txtRadio.Name = "txtRadio";
			this.txtRadio.Size = new System.Drawing.Size(193, 32);
			this.txtRadio.TabIndex = 3;
			// 
			// lblPerimetro
			// 
			this.lblPerimetro.Font = new System.Drawing.Font("Stencil", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lblPerimetro.Location = new System.Drawing.Point(101, 265);
			this.lblPerimetro.Name = "lblPerimetro";
			this.lblPerimetro.Size = new System.Drawing.Size(142, 23);
			this.lblPerimetro.TabIndex = 4;
			this.lblPerimetro.Text = "pERIMETRO :";
			// 
			// lblResultado
			// 
			this.lblResultado.Font = new System.Drawing.Font("Stencil", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lblResultado.Location = new System.Drawing.Point(235, 265);
			this.lblResultado.Name = "lblResultado";
			this.lblResultado.Size = new System.Drawing.Size(239, 23);
			this.lblResultado.TabIndex = 5;
			// 
			// pictureBox1
			// 
			this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
			this.pictureBox1.Location = new System.Drawing.Point(86, 145);
			this.pictureBox1.Name = "pictureBox1";
			this.pictureBox1.Size = new System.Drawing.Size(299, 112);
			this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
			this.pictureBox1.TabIndex = 6;
			this.pictureBox1.TabStop = false;
			// 
			// MainForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(486, 297);
			this.Controls.Add(this.pictureBox1);
			this.Controls.Add(this.lblResultado);
			this.Controls.Add(this.lblPerimetro);
			this.Controls.Add(this.txtRadio);
			this.Controls.Add(this.btnCalcular);
			this.Controls.Add(this.lblRadio);
			this.Controls.Add(this.lblTitulo);
			this.Name = "MainForm";
			this.Text = "circunferencia22222";
			((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();
		}
		private System.Windows.Forms.PictureBox pictureBox1;
		private System.Windows.Forms.Label lblResultado;
		private System.Windows.Forms.Label lblPerimetro;
		private System.Windows.Forms.TextBox txtRadio;
		private System.Windows.Forms.Button btnCalcular;
		private System.Windows.Forms.Label lblRadio;
		private System.Windows.Forms.Label lblTitulo;
	}
}
