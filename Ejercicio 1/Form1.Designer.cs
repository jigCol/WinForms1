namespace Ejercicio_1
{
    partial class formulario1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(formulario1));
            this.btnName = new System.Windows.Forms.Button();
            this.lblTitulo = new System.Windows.Forms.Label();
            this.tboxApellido = new System.Windows.Forms.TextBox();
            this.btnTextBox = new System.Windows.Forms.Button();
            this.tboxEdad = new System.Windows.Forms.TextBox();
            this.lblEdad = new System.Windows.Forms.Label();
            this.lblApellido = new System.Windows.Forms.Label();
            this.tboxNombre = new System.Windows.Forms.TextBox();
            this.lblNombre = new System.Windows.Forms.Label();
            this.tboxMulti = new System.Windows.Forms.TextBox();
            this.tboxDireccion = new System.Windows.Forms.TextBox();
            this.lblDireccion = new System.Windows.Forms.Label();
            this.btnBorrar = new System.Windows.Forms.Button();
            this.btnCerrar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnName
            // 
            this.btnName.BackColor = System.Drawing.Color.Moccasin;
            this.btnName.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.btnName.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnName.Location = new System.Drawing.Point(12, 415);
            this.btnName.Name = "btnName";
            this.btnName.Size = new System.Drawing.Size(75, 23);
            this.btnName.TabIndex = 6;
            this.btnName.TabStop = false;
            this.btnName.Text = "Color";
            this.btnName.UseVisualStyleBackColor = false;
            this.btnName.Click += new System.EventHandler(this.btnName_Click);
            // 
            // lblTitulo
            // 
            this.lblTitulo.AutoSize = true;
            this.lblTitulo.BackColor = System.Drawing.Color.Aquamarine;
            this.lblTitulo.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblTitulo.Font = new System.Drawing.Font("Rockwell", 30F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitulo.ForeColor = System.Drawing.Color.Orange;
            this.lblTitulo.Location = new System.Drawing.Point(62, 29);
            this.lblTitulo.Name = "lblTitulo";
            this.lblTitulo.Size = new System.Drawing.Size(136, 52);
            this.lblTitulo.TabIndex = 12;
            this.lblTitulo.Text = "Datos";
            this.lblTitulo.MouseLeave += new System.EventHandler(this.lblTitulo_MouseLeave);
            this.lblTitulo.MouseMove += new System.Windows.Forms.MouseEventHandler(this.lblTitulo_MouseMove);
            // 
            // tboxApellido
            // 
            this.tboxApellido.BackColor = System.Drawing.SystemColors.Window;
            this.tboxApellido.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.tboxApellido.ForeColor = System.Drawing.SystemColors.WindowText;
            this.tboxApellido.Location = new System.Drawing.Point(89, 156);
            this.tboxApellido.MaxLength = 15;
            this.tboxApellido.Name = "tboxApellido";
            this.tboxApellido.Size = new System.Drawing.Size(100, 20);
            this.tboxApellido.TabIndex = 1;
            // 
            // btnTextBox
            // 
            this.btnTextBox.BackColor = System.Drawing.Color.Moccasin;
            this.btnTextBox.FlatAppearance.BorderColor = System.Drawing.Color.Orange;
            this.btnTextBox.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnTextBox.Image = ((System.Drawing.Image)(resources.GetObject("btnTextBox.Image")));
            this.btnTextBox.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnTextBox.Location = new System.Drawing.Point(89, 380);
            this.btnTextBox.Name = "btnTextBox";
            this.btnTextBox.Size = new System.Drawing.Size(75, 23);
            this.btnTextBox.TabIndex = 5;
            this.btnTextBox.TabStop = false;
            this.btnTextBox.Text = "Ingresar";
            this.btnTextBox.UseVisualStyleBackColor = false;
            this.btnTextBox.Click += new System.EventHandler(this.btnTextBox_Click);
            // 
            // tboxEdad
            // 
            this.tboxEdad.Location = new System.Drawing.Point(89, 182);
            this.tboxEdad.Name = "tboxEdad";
            this.tboxEdad.Size = new System.Drawing.Size(100, 20);
            this.tboxEdad.TabIndex = 2;
            this.tboxEdad.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBox1_KeyPress);
            // 
            // lblEdad
            // 
            this.lblEdad.AutoSize = true;
            this.lblEdad.Location = new System.Drawing.Point(48, 185);
            this.lblEdad.Name = "lblEdad";
            this.lblEdad.Size = new System.Drawing.Size(32, 13);
            this.lblEdad.TabIndex = 8;
            this.lblEdad.Text = "Edad";
            // 
            // lblApellido
            // 
            this.lblApellido.AutoSize = true;
            this.lblApellido.Location = new System.Drawing.Point(39, 159);
            this.lblApellido.Name = "lblApellido";
            this.lblApellido.Size = new System.Drawing.Size(44, 13);
            this.lblApellido.TabIndex = 10;
            this.lblApellido.Text = "Apellido";
            // 
            // tboxNombre
            // 
            this.tboxNombre.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.tboxNombre.Location = new System.Drawing.Point(89, 130);
            this.tboxNombre.Name = "tboxNombre";
            this.tboxNombre.Size = new System.Drawing.Size(100, 20);
            this.tboxNombre.TabIndex = 0;
            // 
            // lblNombre
            // 
            this.lblNombre.AutoSize = true;
            this.lblNombre.Location = new System.Drawing.Point(39, 133);
            this.lblNombre.Name = "lblNombre";
            this.lblNombre.Size = new System.Drawing.Size(44, 13);
            this.lblNombre.TabIndex = 11;
            this.lblNombre.Text = "Nombre";
            // 
            // tboxMulti
            // 
            this.tboxMulti.Location = new System.Drawing.Point(51, 269);
            this.tboxMulti.Multiline = true;
            this.tboxMulti.Name = "tboxMulti";
            this.tboxMulti.ReadOnly = true;
            this.tboxMulti.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.tboxMulti.Size = new System.Drawing.Size(156, 105);
            this.tboxMulti.TabIndex = 4;
            this.tboxMulti.Leave += new System.EventHandler(this.tboxMulti_Leave);
            // 
            // tboxDireccion
            // 
            this.tboxDireccion.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.tboxDireccion.Location = new System.Drawing.Point(89, 208);
            this.tboxDireccion.Name = "tboxDireccion";
            this.tboxDireccion.Size = new System.Drawing.Size(100, 20);
            this.tboxDireccion.TabIndex = 3;
            // 
            // lblDireccion
            // 
            this.lblDireccion.AutoSize = true;
            this.lblDireccion.Location = new System.Drawing.Point(31, 211);
            this.lblDireccion.Name = "lblDireccion";
            this.lblDireccion.Size = new System.Drawing.Size(52, 13);
            this.lblDireccion.TabIndex = 9;
            this.lblDireccion.Text = "Direccion";
            // 
            // btnBorrar
            // 
            this.btnBorrar.BackColor = System.Drawing.Color.Moccasin;
            this.btnBorrar.FlatAppearance.BorderColor = System.Drawing.Color.Orange;
            this.btnBorrar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBorrar.Location = new System.Drawing.Point(213, 309);
            this.btnBorrar.Name = "btnBorrar";
            this.btnBorrar.Size = new System.Drawing.Size(45, 29);
            this.btnBorrar.TabIndex = 7;
            this.btnBorrar.TabStop = false;
            this.btnBorrar.Text = "Borrar";
            this.btnBorrar.UseVisualStyleBackColor = false;
            this.btnBorrar.Click += new System.EventHandler(this.btnBorrar_Click);
            // 
            // btnCerrar
            // 
            this.btnCerrar.BackColor = System.Drawing.Color.Moccasin;
            this.btnCerrar.FlatAppearance.BorderColor = System.Drawing.Color.Orange;
            this.btnCerrar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCerrar.Location = new System.Drawing.Point(189, 415);
            this.btnCerrar.Name = "btnCerrar";
            this.btnCerrar.Size = new System.Drawing.Size(75, 23);
            this.btnCerrar.TabIndex = 13;
            this.btnCerrar.TabStop = false;
            this.btnCerrar.Text = "Cerrar";
            this.btnCerrar.UseVisualStyleBackColor = false;
            this.btnCerrar.Click += new System.EventHandler(this.btnCerrar_Click);
            // 
            // formulario1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightGreen;
            this.ClientSize = new System.Drawing.Size(276, 451);
            this.Controls.Add(this.btnCerrar);
            this.Controls.Add(this.btnBorrar);
            this.Controls.Add(this.lblDireccion);
            this.Controls.Add(this.tboxDireccion);
            this.Controls.Add(this.tboxMulti);
            this.Controls.Add(this.lblNombre);
            this.Controls.Add(this.tboxNombre);
            this.Controls.Add(this.lblApellido);
            this.Controls.Add(this.lblEdad);
            this.Controls.Add(this.tboxEdad);
            this.Controls.Add(this.btnTextBox);
            this.Controls.Add(this.tboxApellido);
            this.Controls.Add(this.lblTitulo);
            this.Controls.Add(this.btnName);
            this.ForeColor = System.Drawing.SystemColors.ControlText;
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(292, 490);
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(292, 490);
            this.Name = "formulario1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Datos";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.formulario1_FormClosed);
            this.Load += new System.EventHandler(this.formulario1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnName;
        private System.Windows.Forms.Label lblTitulo;
        private System.Windows.Forms.TextBox tboxApellido;
        private System.Windows.Forms.Button btnTextBox;
        private System.Windows.Forms.TextBox tboxEdad;
        private System.Windows.Forms.Label lblEdad;
        private System.Windows.Forms.Label lblApellido;
        private System.Windows.Forms.TextBox tboxNombre;
        private System.Windows.Forms.Label lblNombre;
        private System.Windows.Forms.TextBox tboxMulti;
        private System.Windows.Forms.TextBox tboxDireccion;
        private System.Windows.Forms.Label lblDireccion;
        private System.Windows.Forms.Button btnBorrar;
        private System.Windows.Forms.Button btnCerrar;
    }
}

