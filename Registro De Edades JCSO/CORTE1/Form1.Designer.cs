namespace CORTE1
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
            this.TBNombres = new System.Windows.Forms.TextBox();
            this.TBApellidos = new System.Windows.Forms.TextBox();
            this.DTPNacimiento = new System.Windows.Forms.DateTimePicker();
            this.CBCCiudad = new System.Windows.Forms.ComboBox();
            this.BtnAgregar = new System.Windows.Forms.Button();
            this.BtnCalcularEdad = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // TBNombres
            // 
            this.TBNombres.Location = new System.Drawing.Point(2, 12);
            this.TBNombres.Name = "TBNombres";
            this.TBNombres.Size = new System.Drawing.Size(100, 20);
            this.TBNombres.TabIndex = 0;
            this.TBNombres.Text = "Nombres";
            // 
            // TBApellidos
            // 
            this.TBApellidos.Location = new System.Drawing.Point(161, 12);
            this.TBApellidos.Name = "TBApellidos";
            this.TBApellidos.Size = new System.Drawing.Size(100, 20);
            this.TBApellidos.TabIndex = 1;
            this.TBApellidos.Text = "Apellidos";
            // 
            // DTPNacimiento
            // 
            this.DTPNacimiento.Location = new System.Drawing.Point(2, 63);
            this.DTPNacimiento.Name = "DTPNacimiento";
            this.DTPNacimiento.Size = new System.Drawing.Size(200, 20);
            this.DTPNacimiento.TabIndex = 2;
            // 
            // CBCCiudad
            // 
            this.CBCCiudad.FormattingEnabled = true;
            this.CBCCiudad.Location = new System.Drawing.Point(338, 12);
            this.CBCCiudad.Name = "CBCCiudad";
            this.CBCCiudad.Size = new System.Drawing.Size(121, 21);
            this.CBCCiudad.TabIndex = 3;
            // 
            // BtnAgregar
            // 
            this.BtnAgregar.Location = new System.Drawing.Point(302, 64);
            this.BtnAgregar.Name = "BtnAgregar";
            this.BtnAgregar.Size = new System.Drawing.Size(75, 23);
            this.BtnAgregar.TabIndex = 4;
            this.BtnAgregar.Text = "Agregar";
            this.BtnAgregar.UseVisualStyleBackColor = true;
            this.BtnAgregar.Click += new System.EventHandler(this.BtnAgregar_Click);
            // 
            // BtnCalcularEdad
            // 
            this.BtnCalcularEdad.Location = new System.Drawing.Point(404, 64);
            this.BtnCalcularEdad.Name = "BtnCalcularEdad";
            this.BtnCalcularEdad.Size = new System.Drawing.Size(106, 23);
            this.BtnCalcularEdad.TabIndex = 5;
            this.BtnCalcularEdad.Text = "Calcular Edad";
            this.BtnCalcularEdad.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.BtnCalcularEdad);
            this.Controls.Add(this.BtnAgregar);
            this.Controls.Add(this.CBCCiudad);
            this.Controls.Add(this.DTPNacimiento);
            this.Controls.Add(this.TBApellidos);
            this.Controls.Add(this.TBNombres);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox TBNombres;
        private System.Windows.Forms.TextBox TBApellidos;
        private System.Windows.Forms.DateTimePicker DTPNacimiento;
        private System.Windows.Forms.ComboBox CBCCiudad;
        private System.Windows.Forms.Button BtnAgregar;
        private System.Windows.Forms.Button BtnCalcularEdad;
    }
}

