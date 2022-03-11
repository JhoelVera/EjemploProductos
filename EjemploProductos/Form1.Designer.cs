
namespace EjemploProductos
{
    partial class Form1
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.cmbTamanio = new System.Windows.Forms.ComboBox();
            this.rbtnBueno = new System.Windows.Forms.RadioButton();
            this.chbBlanco = new System.Windows.Forms.CheckBox();
            this.chbGris = new System.Windows.Forms.CheckBox();
            this.btnGuardar = new System.Windows.Forms.Button();
            this.btnMostrarDatos = new System.Windows.Forms.Button();
            this.mtxtNombre = new System.Windows.Forms.MaskedTextBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(153, 71);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(44, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Nombre";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(153, 106);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(46, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Tamaño";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(162, 139);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(31, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Color";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(157, 173);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(40, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "Estado";
            // 
            // cmbTamanio
            // 
            this.cmbTamanio.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbTamanio.FormattingEnabled = true;
            this.cmbTamanio.Items.AddRange(new object[] {
            "Pequeño",
            "Mediano",
            "Grande",
            "Extra Grande"});
            this.cmbTamanio.Location = new System.Drawing.Point(239, 106);
            this.cmbTamanio.Name = "cmbTamanio";
            this.cmbTamanio.Size = new System.Drawing.Size(121, 21);
            this.cmbTamanio.TabIndex = 4;
            this.cmbTamanio.SelectedIndexChanged += new System.EventHandler(this.cmbTamanio_SelectedIndexChanged);
            // 
            // rbtnBueno
            // 
            this.rbtnBueno.AutoSize = true;
            this.rbtnBueno.Location = new System.Drawing.Point(239, 169);
            this.rbtnBueno.Name = "rbtnBueno";
            this.rbtnBueno.Size = new System.Drawing.Size(56, 17);
            this.rbtnBueno.TabIndex = 6;
            this.rbtnBueno.TabStop = true;
            this.rbtnBueno.Text = "Bueno";
            this.rbtnBueno.UseVisualStyleBackColor = true;
            // 
            // chbBlanco
            // 
            this.chbBlanco.AutoSize = true;
            this.chbBlanco.Location = new System.Drawing.Point(239, 139);
            this.chbBlanco.Name = "chbBlanco";
            this.chbBlanco.Size = new System.Drawing.Size(59, 17);
            this.chbBlanco.TabIndex = 7;
            this.chbBlanco.Text = "Blanco";
            this.chbBlanco.UseVisualStyleBackColor = true;
            // 
            // chbGris
            // 
            this.chbGris.AutoSize = true;
            this.chbGris.Location = new System.Drawing.Point(325, 139);
            this.chbGris.Name = "chbGris";
            this.chbGris.Size = new System.Drawing.Size(44, 17);
            this.chbGris.TabIndex = 8;
            this.chbGris.Text = "Gris";
            this.chbGris.UseVisualStyleBackColor = true;
            // 
            // btnGuardar
            // 
            this.btnGuardar.Location = new System.Drawing.Point(200, 210);
            this.btnGuardar.Name = "btnGuardar";
            this.btnGuardar.Size = new System.Drawing.Size(75, 23);
            this.btnGuardar.TabIndex = 9;
            this.btnGuardar.Text = "Guardar";
            this.btnGuardar.UseVisualStyleBackColor = true;
            this.btnGuardar.Click += new System.EventHandler(this.btnGuardar_Click);
            // 
            // btnMostrarDatos
            // 
            this.btnMostrarDatos.Location = new System.Drawing.Point(286, 210);
            this.btnMostrarDatos.Name = "btnMostrarDatos";
            this.btnMostrarDatos.Size = new System.Drawing.Size(75, 23);
            this.btnMostrarDatos.TabIndex = 10;
            this.btnMostrarDatos.Text = "MostrarDatos";
            this.btnMostrarDatos.UseVisualStyleBackColor = true;
            this.btnMostrarDatos.Click += new System.EventHandler(this.btnMostrarDatos_Click);
            // 
            // mtxtNombre
            // 
            this.mtxtNombre.Location = new System.Drawing.Point(239, 68);
            this.mtxtNombre.Mask = "LLLLLLLLLLLLLLLLLLL";
            this.mtxtNombre.Name = "mtxtNombre";
            this.mtxtNombre.Size = new System.Drawing.Size(121, 20);
            this.mtxtNombre.TabIndex = 11;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.ClientSize = new System.Drawing.Size(580, 332);
            this.Controls.Add(this.mtxtNombre);
            this.Controls.Add(this.btnMostrarDatos);
            this.Controls.Add(this.btnGuardar);
            this.Controls.Add(this.chbGris);
            this.Controls.Add(this.chbBlanco);
            this.Controls.Add(this.rbtnBueno);
            this.Controls.Add(this.cmbTamanio);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox cmbTamanio;
        private System.Windows.Forms.RadioButton rbtnBueno;
        private System.Windows.Forms.CheckBox chbBlanco;
        private System.Windows.Forms.CheckBox chbGris;
        private System.Windows.Forms.Button btnGuardar;
        private System.Windows.Forms.Button btnMostrarDatos;
        private System.Windows.Forms.MaskedTextBox mtxtNombre;
    }
}

