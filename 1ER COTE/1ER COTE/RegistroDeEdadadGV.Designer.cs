﻿namespace _1ER_COTE
{
    partial class RegistroDeEdadadGV
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
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.txtApellidos = new System.Windows.Forms.TextBox();
            this.btnAgregar = new System.Windows.Forms.Button();
            this.btnMostrarEdad = new System.Windows.Forms.Button();
            this.comboBoxCiudades = new System.Windows.Forms.ComboBox();
            this.dateTimePickerFechaDeNacimiento = new System.Windows.Forms.DateTimePicker();
            this.label3 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(99, 82);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(59, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "Nombre:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(101, 151);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(60, 16);
            this.label2.TabIndex = 1;
            this.label2.Text = "Apellido:";
            // 
            // txtNombre
            // 
            this.txtNombre.Location = new System.Drawing.Point(179, 76);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(213, 22);
            this.txtNombre.TabIndex = 3;
            // 
            // txtApellidos
            // 
            this.txtApellidos.Location = new System.Drawing.Point(179, 145);
            this.txtApellidos.Name = "txtApellidos";
            this.txtApellidos.Size = new System.Drawing.Size(213, 22);
            this.txtApellidos.TabIndex = 4;
            // 
            // btnAgregar
            // 
            this.btnAgregar.Location = new System.Drawing.Point(475, 69);
            this.btnAgregar.Name = "btnAgregar";
            this.btnAgregar.Size = new System.Drawing.Size(120, 56);
            this.btnAgregar.TabIndex = 5;
            this.btnAgregar.Text = "Agregar ";
            this.btnAgregar.UseVisualStyleBackColor = true;
            this.btnAgregar.Click += new System.EventHandler(this.button1_Click);
            // 
            // btnMostrarEdad
            // 
            this.btnMostrarEdad.Location = new System.Drawing.Point(474, 146);
            this.btnMostrarEdad.Name = "btnMostrarEdad";
            this.btnMostrarEdad.Size = new System.Drawing.Size(125, 50);
            this.btnMostrarEdad.TabIndex = 6;
            this.btnMostrarEdad.Text = "Mostrar Edad";
            this.btnMostrarEdad.UseVisualStyleBackColor = true;
            this.btnMostrarEdad.Click += new System.EventHandler(this.btnMostrarEdad_Click);
            // 
            // comboBoxCiudades
            // 
            this.comboBoxCiudades.FormattingEnabled = true;
            this.comboBoxCiudades.Location = new System.Drawing.Point(154, 294);
            this.comboBoxCiudades.Name = "comboBoxCiudades";
            this.comboBoxCiudades.Size = new System.Drawing.Size(340, 24);
            this.comboBoxCiudades.TabIndex = 7;
            this.comboBoxCiudades.SelectedIndexChanged += new System.EventHandler(this.comboBoxCiudades_SelectedIndexChanged);
            // 
            // dateTimePickerFechaDeNacimiento
            // 
            this.dateTimePickerFechaDeNacimiento.Location = new System.Drawing.Point(221, 223);
            this.dateTimePickerFechaDeNacimiento.Name = "dateTimePickerFechaDeNacimiento";
            this.dateTimePickerFechaDeNacimiento.Size = new System.Drawing.Size(242, 22);
            this.dateTimePickerFechaDeNacimiento.TabIndex = 8;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(61, 229);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(132, 16);
            this.label3.TabIndex = 9;
            this.label3.Text = "Fecha de nacimiento";
            // 
            // RegistroDeEdadadGV
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.dateTimePickerFechaDeNacimiento);
            this.Controls.Add(this.comboBoxCiudades);
            this.Controls.Add(this.btnMostrarEdad);
            this.Controls.Add(this.btnAgregar);
            this.Controls.Add(this.txtApellidos);
            this.Controls.Add(this.txtNombre);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "RegistroDeEdadadGV";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtNombre;
        private System.Windows.Forms.TextBox txtApellidos;
        private System.Windows.Forms.Button btnAgregar;
        private System.Windows.Forms.Button btnMostrarEdad;
        private System.Windows.Forms.ComboBox comboBoxCiudades;
        private System.Windows.Forms.DateTimePicker dateTimePickerFechaDeNacimiento;
        private System.Windows.Forms.Label label3;
    }
}

