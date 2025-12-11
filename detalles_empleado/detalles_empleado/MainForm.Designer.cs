/*
 * Creado por SharpDevelop.
 * Usuario: Elia Martha
 * Fecha: 08/12/2025
 * Hora: 06:23 p. m.
 * 
 * Para cambiar esta plantilla use Herramientas | Opciones | Codificación | Editar Encabezados Estándar
 */
namespace detalles_empleado
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
			this.components = new System.ComponentModel.Container();
			this.dgvDatos = new System.Windows.Forms.DataGridView();
			this.label1 = new System.Windows.Forms.Label();
			this.label2 = new System.Windows.Forms.Label();
			this.label3 = new System.Windows.Forms.Label();
			this.label4 = new System.Windows.Forms.Label();
			this.label5 = new System.Windows.Forms.Label();
			this.txtCodigo = new System.Windows.Forms.TextBox();
			this.txtNombre = new System.Windows.Forms.TextBox();
			this.cboPuesto = new System.Windows.Forms.ComboBox();
			this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
			this.cboSexo = new System.Windows.Forms.ComboBox();
			this.btnGuardar = new System.Windows.Forms.Button();
			this.btnEliminar = new System.Windows.Forms.Button();
			this.picEmpleado = new System.Windows.Forms.PictureBox();
			this.btnBuscar = new System.Windows.Forms.Button();
			this.txtRutaArchivo = new System.Windows.Forms.TextBox();
			this.erpError = new System.Windows.Forms.ErrorProvider(this.components);
			this.label6 = new System.Windows.Forms.Label();
			this.cboEstado = new System.Windows.Forms.ComboBox();
			((System.ComponentModel.ISupportInitialize)(this.dgvDatos)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.picEmpleado)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.erpError)).BeginInit();
			this.SuspendLayout();
			// 
			// dgvDatos
			// 
			this.dgvDatos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dgvDatos.Location = new System.Drawing.Point(12, 217);
			this.dgvDatos.Name = "dgvDatos";
			this.dgvDatos.Size = new System.Drawing.Size(618, 150);
			this.dgvDatos.TabIndex = 1;
			// 
			// label1
			// 
			this.label1.Font = new System.Drawing.Font("Comic Sans MS", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label1.Location = new System.Drawing.Point(12, 12);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(166, 23);
			this.label1.TabIndex = 2;
			this.label1.Text = "Codigo del empleado:";
			// 
			// label2
			// 
			this.label2.Font = new System.Drawing.Font("Comic Sans MS", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label2.Location = new System.Drawing.Point(12, 35);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(174, 23);
			this.label2.TabIndex = 3;
			this.label2.Text = "Nombre del empleado:";
			// 
			// label3
			// 
			this.label3.Font = new System.Drawing.Font("Comic Sans MS", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label3.Location = new System.Drawing.Point(12, 66);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(100, 23);
			this.label3.TabIndex = 4;
			this.label3.Text = "Puesto:";
			// 
			// label4
			// 
			this.label4.Font = new System.Drawing.Font("Comic Sans MS", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label4.Location = new System.Drawing.Point(12, 103);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(166, 23);
			this.label4.TabIndex = 5;
			this.label4.Text = "Fecha de nacimiento:";
			// 
			// label5
			// 
			this.label5.Font = new System.Drawing.Font("Comic Sans MS", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label5.Location = new System.Drawing.Point(12, 141);
			this.label5.Name = "label5";
			this.label5.Size = new System.Drawing.Size(100, 23);
			this.label5.TabIndex = 6;
			this.label5.Text = "Sexo:";
			// 
			// txtCodigo
			// 
			this.txtCodigo.Location = new System.Drawing.Point(184, 12);
			this.txtCodigo.Name = "txtCodigo";
			this.txtCodigo.Size = new System.Drawing.Size(78, 20);
			this.txtCodigo.TabIndex = 7;
			// 
			// txtNombre
			// 
			this.txtNombre.Location = new System.Drawing.Point(184, 43);
			this.txtNombre.Name = "txtNombre";
			this.txtNombre.Size = new System.Drawing.Size(273, 20);
			this.txtNombre.TabIndex = 8;
			// 
			// cboPuesto
			// 
			this.cboPuesto.FormattingEnabled = true;
			this.cboPuesto.Items.AddRange(new object[] {
									"Chef pastelero",
									"Panadero",
									"Ayudante de reposteria",
									"Decorador",
									"Cajero",
									"Mesero",
									"Vendedor de mostrador",
									"Gerente",
									"Jefe de produccion",
									"Personal de limpieza",
									"Repartidor",
									"Auxiliar de cocina"});
			this.cboPuesto.Location = new System.Drawing.Point(81, 69);
			this.cboPuesto.Name = "cboPuesto";
			this.cboPuesto.Size = new System.Drawing.Size(121, 21);
			this.cboPuesto.TabIndex = 9;
			// 
			// dateTimePicker1
			// 
			this.dateTimePicker1.Location = new System.Drawing.Point(184, 103);
			this.dateTimePicker1.MaxDate = new System.DateTime(2007, 12, 31, 0, 0, 0, 0);
			this.dateTimePicker1.MinDate = new System.DateTime(1960, 1, 1, 0, 0, 0, 0);
			this.dateTimePicker1.Name = "dateTimePicker1";
			this.dateTimePicker1.Size = new System.Drawing.Size(200, 20);
			this.dateTimePicker1.TabIndex = 10;
			this.dateTimePicker1.Value = new System.DateTime(2007, 12, 31, 0, 0, 0, 0);
			// 
			// cboSexo
			// 
			this.cboSexo.FormattingEnabled = true;
			this.cboSexo.Items.AddRange(new object[] {
									"Hombre",
									"Mujer",
									"No binario"});
			this.cboSexo.Location = new System.Drawing.Point(81, 141);
			this.cboSexo.Name = "cboSexo";
			this.cboSexo.Size = new System.Drawing.Size(121, 21);
			this.cboSexo.TabIndex = 11;
			// 
			// btnGuardar
			// 
			this.btnGuardar.BackColor = System.Drawing.Color.PaleGreen;
			this.btnGuardar.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
			this.btnGuardar.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnGuardar.ForeColor = System.Drawing.SystemColors.ControlText;
			this.btnGuardar.Location = new System.Drawing.Point(134, 376);
			this.btnGuardar.Name = "btnGuardar";
			this.btnGuardar.Size = new System.Drawing.Size(75, 23);
			this.btnGuardar.TabIndex = 15;
			this.btnGuardar.Text = "Guardar";
			this.btnGuardar.UseVisualStyleBackColor = false;
			this.btnGuardar.Click += new System.EventHandler(this.BtnGuardarClick);
			// 
			// btnEliminar
			// 
			this.btnEliminar.BackColor = System.Drawing.Color.PaleGreen;
			this.btnEliminar.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
			this.btnEliminar.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnEliminar.Location = new System.Drawing.Point(309, 376);
			this.btnEliminar.Name = "btnEliminar";
			this.btnEliminar.Size = new System.Drawing.Size(75, 23);
			this.btnEliminar.TabIndex = 16;
			this.btnEliminar.Text = "Eliminar";
			this.btnEliminar.UseVisualStyleBackColor = false;
			this.btnEliminar.Click += new System.EventHandler(this.BtnEliminarClick);
			// 
			// picEmpleado
			// 
			this.picEmpleado.Location = new System.Drawing.Point(522, 13);
			this.picEmpleado.Name = "picEmpleado";
			this.picEmpleado.Size = new System.Drawing.Size(108, 110);
			this.picEmpleado.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
			this.picEmpleado.TabIndex = 17;
			this.picEmpleado.TabStop = false;
			// 
			// btnBuscar
			// 
			this.btnBuscar.BackColor = System.Drawing.Color.PaleGreen;
			this.btnBuscar.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
			this.btnBuscar.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnBuscar.Location = new System.Drawing.Point(522, 163);
			this.btnBuscar.Name = "btnBuscar";
			this.btnBuscar.Size = new System.Drawing.Size(108, 23);
			this.btnBuscar.TabIndex = 18;
			this.btnBuscar.Text = "Buscar Imagen";
			this.btnBuscar.UseVisualStyleBackColor = false;
			this.btnBuscar.Click += new System.EventHandler(this.BtnBuscarClick);
			// 
			// txtRutaArchivo
			// 
			this.txtRutaArchivo.Location = new System.Drawing.Point(522, 137);
			this.txtRutaArchivo.Name = "txtRutaArchivo";
			this.txtRutaArchivo.Size = new System.Drawing.Size(108, 20);
			this.txtRutaArchivo.TabIndex = 19;
			// 
			// erpError
			// 
			this.erpError.ContainerControl = this;
			// 
			// label6
			// 
			this.label6.Font = new System.Drawing.Font("Comic Sans MS", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label6.Location = new System.Drawing.Point(12, 181);
			this.label6.Name = "label6";
			this.label6.Size = new System.Drawing.Size(73, 23);
			this.label6.TabIndex = 20;
			this.label6.Text = "Estado:";
			// 
			// cboEstado
			// 
			this.cboEstado.FormattingEnabled = true;
			this.cboEstado.Items.AddRange(new object[] {
									"Regular",
									"Contrato"});
			this.cboEstado.Location = new System.Drawing.Point(91, 181);
			this.cboEstado.Name = "cboEstado";
			this.cboEstado.Size = new System.Drawing.Size(121, 21);
			this.cboEstado.TabIndex = 21;
			// 
			// MainForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.Color.LightGreen;
			this.ClientSize = new System.Drawing.Size(642, 411);
			this.Controls.Add(this.cboEstado);
			this.Controls.Add(this.label6);
			this.Controls.Add(this.txtRutaArchivo);
			this.Controls.Add(this.btnBuscar);
			this.Controls.Add(this.picEmpleado);
			this.Controls.Add(this.btnEliminar);
			this.Controls.Add(this.btnGuardar);
			this.Controls.Add(this.cboSexo);
			this.Controls.Add(this.dateTimePicker1);
			this.Controls.Add(this.cboPuesto);
			this.Controls.Add(this.txtNombre);
			this.Controls.Add(this.txtCodigo);
			this.Controls.Add(this.label5);
			this.Controls.Add(this.label4);
			this.Controls.Add(this.label3);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.dgvDatos);
			this.Name = "MainForm";
			this.Text = "detalles_empleado";
			((System.ComponentModel.ISupportInitialize)(this.dgvDatos)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.picEmpleado)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.erpError)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();
		}
		private System.Windows.Forms.Label label6;
		private System.Windows.Forms.ComboBox cboEstado;
		private System.Windows.Forms.ErrorProvider erpError;
		private System.Windows.Forms.TextBox txtRutaArchivo;
		private System.Windows.Forms.Button btnBuscar;
		private System.Windows.Forms.PictureBox picEmpleado;
		private System.Windows.Forms.Button btnEliminar;
		private System.Windows.Forms.Button btnGuardar;
		private System.Windows.Forms.ComboBox cboSexo;
		private System.Windows.Forms.DateTimePicker dateTimePicker1;
		private System.Windows.Forms.ComboBox cboPuesto;
		private System.Windows.Forms.TextBox txtNombre;
		private System.Windows.Forms.TextBox txtCodigo;
		private System.Windows.Forms.Label label5;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.DataGridView dgvDatos;
	}
}
