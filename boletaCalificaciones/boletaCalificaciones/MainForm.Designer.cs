/*
 * Creado por SharpDevelop.
 * Usuario: Elia Martha
 * Fecha: 11/12/2025
 * Hora: 12:44 p. m.
 * 
 * Para cambiar esta plantilla use Herramientas | Opciones | Codificación | Editar Encabezados Estándar
 */
namespace boletaCalificaciones
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
			this.txtNombre = new System.Windows.Forms.TextBox();
			this.label1 = new System.Windows.Forms.Label();
			this.label2 = new System.Windows.Forms.Label();
			this.label3 = new System.Windows.Forms.Label();
			this.label4 = new System.Windows.Forms.Label();
			this.txtp1 = new System.Windows.Forms.TextBox();
			this.txtp2 = new System.Windows.Forms.TextBox();
			this.txtp3 = new System.Windows.Forms.TextBox();
			this.label5 = new System.Windows.Forms.Label();
			this.cboSemestre = new System.Windows.Forms.ComboBox();
			this.label6 = new System.Windows.Forms.Label();
			this.cboEspecialidad = new System.Windows.Forms.ComboBox();
			this.label7 = new System.Windows.Forms.Label();
			this.cboMateria = new System.Windows.Forms.ComboBox();
			this.lvCalificacion = new System.Windows.Forms.ListView();
			this.columnHeader1 = new System.Windows.Forms.ColumnHeader();
			this.columnHeader2 = new System.Windows.Forms.ColumnHeader();
			this.columnHeader3 = new System.Windows.Forms.ColumnHeader();
			this.columnHeader4 = new System.Windows.Forms.ColumnHeader();
			this.columnHeader5 = new System.Windows.Forms.ColumnHeader();
			this.columnHeader6 = new System.Windows.Forms.ColumnHeader();
			this.btnRegistrar = new System.Windows.Forms.Button();
			this.btnCancelar = new System.Windows.Forms.Button();
			this.btnSalir = new System.Windows.Forms.Button();
			this.label8 = new System.Windows.Forms.Label();
			this.lblPromedioGral = new System.Windows.Forms.Label();
			this.SuspendLayout();
			// 
			// txtNombre
			// 
			this.txtNombre.Location = new System.Drawing.Point(189, 12);
			this.txtNombre.Name = "txtNombre";
			this.txtNombre.Size = new System.Drawing.Size(240, 20);
			this.txtNombre.TabIndex = 0;
			// 
			// label1
			// 
			this.label1.Font = new System.Drawing.Font("Comic Sans MS", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label1.Location = new System.Drawing.Point(23, 9);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(160, 23);
			this.label1.TabIndex = 1;
			this.label1.Text = "Nombre del alumno:";
			// 
			// label2
			// 
			this.label2.Font = new System.Drawing.Font("Comic Sans MS", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label2.Location = new System.Drawing.Point(23, 53);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(85, 23);
			this.label2.TabIndex = 2;
			this.label2.Text = "Parcial 1:";
			// 
			// label3
			// 
			this.label3.Font = new System.Drawing.Font("Comic Sans MS", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label3.Location = new System.Drawing.Point(129, 53);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(86, 23);
			this.label3.TabIndex = 3;
			this.label3.Text = "Parcial 2:";
			// 
			// label4
			// 
			this.label4.Font = new System.Drawing.Font("Comic Sans MS", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label4.Location = new System.Drawing.Point(235, 53);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(86, 23);
			this.label4.TabIndex = 4;
			this.label4.Text = "Parcial 3:";
			// 
			// txtp1
			// 
			this.txtp1.Location = new System.Drawing.Point(23, 85);
			this.txtp1.Name = "txtp1";
			this.txtp1.Size = new System.Drawing.Size(85, 20);
			this.txtp1.TabIndex = 5;
			// 
			// txtp2
			// 
			this.txtp2.Location = new System.Drawing.Point(129, 85);
			this.txtp2.Name = "txtp2";
			this.txtp2.Size = new System.Drawing.Size(85, 20);
			this.txtp2.TabIndex = 6;
			// 
			// txtp3
			// 
			this.txtp3.Location = new System.Drawing.Point(236, 85);
			this.txtp3.Name = "txtp3";
			this.txtp3.Size = new System.Drawing.Size(85, 20);
			this.txtp3.TabIndex = 7;
			// 
			// label5
			// 
			this.label5.Font = new System.Drawing.Font("Comic Sans MS", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label5.Location = new System.Drawing.Point(23, 123);
			this.label5.Name = "label5";
			this.label5.Size = new System.Drawing.Size(100, 23);
			this.label5.TabIndex = 8;
			this.label5.Text = "Semestre:";
			// 
			// cboSemestre
			// 
			this.cboSemestre.FormattingEnabled = true;
			this.cboSemestre.Items.AddRange(new object[] {
									"1ro",
									"3ro",
									"5to"});
			this.cboSemestre.Location = new System.Drawing.Point(119, 123);
			this.cboSemestre.Name = "cboSemestre";
			this.cboSemestre.Size = new System.Drawing.Size(118, 21);
			this.cboSemestre.TabIndex = 9;
			// 
			// label6
			// 
			this.label6.Font = new System.Drawing.Font("Comic Sans MS", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label6.Location = new System.Drawing.Point(273, 123);
			this.label6.Name = "label6";
			this.label6.Size = new System.Drawing.Size(108, 23);
			this.label6.TabIndex = 10;
			this.label6.Text = "Especialidad:";
			// 
			// cboEspecialidad
			// 
			this.cboEspecialidad.FormattingEnabled = true;
			this.cboEspecialidad.Items.AddRange(new object[] {
									"Programacion",
									"Ciberseguridad",
									"Alimentos",
									"Administracion",
									"Ofimatica",
									"Mecanica",
									"Soporte",
									"Contabilidad"});
			this.cboEspecialidad.Location = new System.Drawing.Point(387, 123);
			this.cboEspecialidad.Name = "cboEspecialidad";
			this.cboEspecialidad.Size = new System.Drawing.Size(121, 21);
			this.cboEspecialidad.TabIndex = 11;
			// 
			// label7
			// 
			this.label7.Font = new System.Drawing.Font("Comic Sans MS", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label7.Location = new System.Drawing.Point(23, 170);
			this.label7.Name = "label7";
			this.label7.Size = new System.Drawing.Size(192, 23);
			this.label7.TabIndex = 12;
			this.label7.Text = "Asignatura o submodulo:";
			// 
			// cboMateria
			// 
			this.cboMateria.FormattingEnabled = true;
			this.cboMateria.Items.AddRange(new object[] {
									"Emplea frameworks",
									"Metodologias agiles",
									"Humanidades",
									"Ciencias sociales",
									"Conciencia historica",
									"Matematicas",
									"Lengua y comunicacion",
									"Ingles",
									"Cultura digital"});
			this.cboMateria.Location = new System.Drawing.Point(221, 173);
			this.cboMateria.Name = "cboMateria";
			this.cboMateria.Size = new System.Drawing.Size(208, 21);
			this.cboMateria.TabIndex = 13;
			// 
			// lvCalificacion
			// 
			this.lvCalificacion.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
									this.columnHeader1,
									this.columnHeader2,
									this.columnHeader3,
									this.columnHeader4,
									this.columnHeader5,
									this.columnHeader6});
			this.lvCalificacion.Location = new System.Drawing.Point(23, 255);
			this.lvCalificacion.Name = "lvCalificacion";
			this.lvCalificacion.Size = new System.Drawing.Size(592, 154);
			this.lvCalificacion.TabIndex = 14;
			this.lvCalificacion.UseCompatibleStateImageBehavior = false;
			this.lvCalificacion.View = System.Windows.Forms.View.Details;
			// 
			// columnHeader1
			// 
			this.columnHeader1.Text = "Asignatura/submodulo";
			this.columnHeader1.Width = 133;
			// 
			// columnHeader2
			// 
			this.columnHeader2.Text = "Parcial 1";
			// 
			// columnHeader3
			// 
			this.columnHeader3.Text = "Parcial 2";
			// 
			// columnHeader4
			// 
			this.columnHeader4.Text = "Parcial 3";
			// 
			// columnHeader5
			// 
			this.columnHeader5.Text = "Promedio";
			// 
			// columnHeader6
			// 
			this.columnHeader6.Text = "Aprobado/reprobado";
			this.columnHeader6.Width = 122;
			// 
			// btnRegistrar
			// 
			this.btnRegistrar.BackColor = System.Drawing.Color.Snow;
			this.btnRegistrar.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
			this.btnRegistrar.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnRegistrar.Location = new System.Drawing.Point(306, 213);
			this.btnRegistrar.Name = "btnRegistrar";
			this.btnRegistrar.Size = new System.Drawing.Size(75, 23);
			this.btnRegistrar.TabIndex = 15;
			this.btnRegistrar.Text = "Registrar";
			this.btnRegistrar.UseVisualStyleBackColor = false;
			this.btnRegistrar.Click += new System.EventHandler(this.BtnRegistrarClick);
			// 
			// btnCancelar
			// 
			this.btnCancelar.BackColor = System.Drawing.Color.LightCyan;
			this.btnCancelar.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
			this.btnCancelar.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnCancelar.Location = new System.Drawing.Point(415, 213);
			this.btnCancelar.Name = "btnCancelar";
			this.btnCancelar.Size = new System.Drawing.Size(75, 23);
			this.btnCancelar.TabIndex = 16;
			this.btnCancelar.Text = "Cancelar";
			this.btnCancelar.UseVisualStyleBackColor = false;
			this.btnCancelar.Click += new System.EventHandler(this.BtnCancelarClick);
			// 
			// btnSalir
			// 
			this.btnSalir.BackColor = System.Drawing.Color.Honeydew;
			this.btnSalir.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
			this.btnSalir.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnSalir.Location = new System.Drawing.Point(524, 213);
			this.btnSalir.Name = "btnSalir";
			this.btnSalir.Size = new System.Drawing.Size(75, 23);
			this.btnSalir.TabIndex = 17;
			this.btnSalir.Text = "Salir";
			this.btnSalir.UseVisualStyleBackColor = false;
			this.btnSalir.Click += new System.EventHandler(this.BtnSalirClick);
			// 
			// label8
			// 
			this.label8.Font = new System.Drawing.Font("Comic Sans MS", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label8.Location = new System.Drawing.Point(306, 421);
			this.label8.Name = "label8";
			this.label8.Size = new System.Drawing.Size(147, 23);
			this.label8.TabIndex = 18;
			this.label8.Text = "Promedio general:";
			// 
			// lblPromedioGral
			// 
			this.lblPromedioGral.BackColor = System.Drawing.Color.Wheat;
			this.lblPromedioGral.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lblPromedioGral.Location = new System.Drawing.Point(459, 423);
			this.lblPromedioGral.Name = "lblPromedioGral";
			this.lblPromedioGral.Size = new System.Drawing.Size(100, 23);
			this.lblPromedioGral.TabIndex = 19;
			// 
			// MainForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.Color.FloralWhite;
			this.ClientSize = new System.Drawing.Size(627, 453);
			this.Controls.Add(this.lblPromedioGral);
			this.Controls.Add(this.label8);
			this.Controls.Add(this.btnSalir);
			this.Controls.Add(this.btnCancelar);
			this.Controls.Add(this.btnRegistrar);
			this.Controls.Add(this.lvCalificacion);
			this.Controls.Add(this.cboMateria);
			this.Controls.Add(this.label7);
			this.Controls.Add(this.cboEspecialidad);
			this.Controls.Add(this.label6);
			this.Controls.Add(this.cboSemestre);
			this.Controls.Add(this.label5);
			this.Controls.Add(this.txtp3);
			this.Controls.Add(this.txtp2);
			this.Controls.Add(this.txtp1);
			this.Controls.Add(this.label4);
			this.Controls.Add(this.label3);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.txtNombre);
			this.Name = "MainForm";
			this.Text = "boletaCalificaciones";
			this.ResumeLayout(false);
			this.PerformLayout();
		}
		private System.Windows.Forms.Label lblPromedioGral;
		private System.Windows.Forms.Label label8;
		private System.Windows.Forms.Button btnSalir;
		private System.Windows.Forms.Button btnCancelar;
		private System.Windows.Forms.Button btnRegistrar;
		private System.Windows.Forms.ColumnHeader columnHeader6;
		private System.Windows.Forms.ColumnHeader columnHeader5;
		private System.Windows.Forms.ColumnHeader columnHeader4;
		private System.Windows.Forms.ColumnHeader columnHeader3;
		private System.Windows.Forms.ColumnHeader columnHeader2;
		private System.Windows.Forms.ColumnHeader columnHeader1;
		private System.Windows.Forms.ListView lvCalificacion;
		private System.Windows.Forms.ComboBox cboMateria;
		private System.Windows.Forms.Label label7;
		private System.Windows.Forms.ComboBox cboEspecialidad;
		private System.Windows.Forms.Label label6;
		private System.Windows.Forms.ComboBox cboSemestre;
		private System.Windows.Forms.Label label5;
		private System.Windows.Forms.TextBox txtp3;
		private System.Windows.Forms.TextBox txtp2;
		private System.Windows.Forms.TextBox txtp1;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.TextBox txtNombre;
	}
}
