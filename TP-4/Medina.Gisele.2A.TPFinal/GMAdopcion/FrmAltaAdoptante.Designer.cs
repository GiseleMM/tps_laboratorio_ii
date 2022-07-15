
namespace GMAdopcion
{
    partial class FrmAltaAdoptante
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.label_nombre = new System.Windows.Forms.Label();
            this.label_direccion = new System.Windows.Forms.Label();
            this.label_dni = new System.Windows.Forms.Label();
            this.label_telefono = new System.Windows.Forms.Label();
            this.button_aceptar = new System.Windows.Forms.Button();
            this.button_cancelar = new System.Windows.Forms.Button();
            this.textBox_nombre = new System.Windows.Forms.TextBox();
            this.textBox_direccion = new System.Windows.Forms.TextBox();
            this.textBox_dni = new System.Windows.Forms.TextBox();
            this.textBox_telefono = new System.Windows.Forms.TextBox();
            this.comboBox_localidades = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // label_nombre
            // 
            this.label_nombre.AutoSize = true;
            this.label_nombre.Location = new System.Drawing.Point(117, 68);
            this.label_nombre.Name = "label_nombre";
            this.label_nombre.Size = new System.Drawing.Size(49, 15);
            this.label_nombre.TabIndex = 0;
            this.label_nombre.Text = "nombre";
            // 
            // label_direccion
            // 
            this.label_direccion.AutoSize = true;
            this.label_direccion.Location = new System.Drawing.Point(117, 113);
            this.label_direccion.Name = "label_direccion";
            this.label_direccion.Size = new System.Drawing.Size(57, 15);
            this.label_direccion.TabIndex = 1;
            this.label_direccion.Text = "Direccion";
            // 
            // label_dni
            // 
            this.label_dni.AutoSize = true;
            this.label_dni.Location = new System.Drawing.Point(117, 161);
            this.label_dni.Name = "label_dni";
            this.label_dni.Size = new System.Drawing.Size(27, 15);
            this.label_dni.TabIndex = 2;
            this.label_dni.Text = "DNI";
            // 
            // label_telefono
            // 
            this.label_telefono.AutoSize = true;
            this.label_telefono.Location = new System.Drawing.Point(117, 210);
            this.label_telefono.Name = "label_telefono";
            this.label_telefono.Size = new System.Drawing.Size(51, 15);
            this.label_telefono.TabIndex = 3;
            this.label_telefono.Text = "telefono";
            // 
            // button_aceptar
            // 
            this.button_aceptar.Location = new System.Drawing.Point(273, 278);
            this.button_aceptar.Name = "button_aceptar";
            this.button_aceptar.Size = new System.Drawing.Size(129, 23);
            this.button_aceptar.TabIndex = 4;
            this.button_aceptar.Text = "Aceptar";
            this.button_aceptar.UseVisualStyleBackColor = true;
            this.button_aceptar.Click += new System.EventHandler(this.button_aceptar_Click_1);
            // 
            // button_cancelar
            // 
            this.button_cancelar.Location = new System.Drawing.Point(443, 278);
            this.button_cancelar.Name = "button_cancelar";
            this.button_cancelar.Size = new System.Drawing.Size(129, 23);
            this.button_cancelar.TabIndex = 5;
            this.button_cancelar.Text = "Cancelar";
            this.button_cancelar.UseVisualStyleBackColor = true;
            this.button_cancelar.Click += new System.EventHandler(this.button_cancelar_Click);
            // 
            // textBox_nombre
            // 
            this.textBox_nombre.Location = new System.Drawing.Point(273, 68);
            this.textBox_nombre.Name = "textBox_nombre";
            this.textBox_nombre.Size = new System.Drawing.Size(315, 23);
            this.textBox_nombre.TabIndex = 6;
            // 
            // textBox_direccion
            // 
            this.textBox_direccion.Location = new System.Drawing.Point(439, 110);
            this.textBox_direccion.Name = "textBox_direccion";
            this.textBox_direccion.Size = new System.Drawing.Size(149, 23);
            this.textBox_direccion.TabIndex = 8;
            // 
            // textBox_dni
            // 
            this.textBox_dni.Location = new System.Drawing.Point(273, 153);
            this.textBox_dni.Name = "textBox_dni";
            this.textBox_dni.Size = new System.Drawing.Size(315, 23);
            this.textBox_dni.TabIndex = 9;
            // 
            // textBox_telefono
            // 
            this.textBox_telefono.Location = new System.Drawing.Point(273, 202);
            this.textBox_telefono.Name = "textBox_telefono";
            this.textBox_telefono.Size = new System.Drawing.Size(315, 23);
            this.textBox_telefono.TabIndex = 10;
            // 
            // comboBox_localidades
            // 
            this.comboBox_localidades.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox_localidades.FormattingEnabled = true;
            this.comboBox_localidades.Location = new System.Drawing.Point(273, 110);
            this.comboBox_localidades.Name = "comboBox_localidades";
            this.comboBox_localidades.Size = new System.Drawing.Size(160, 23);
            this.comboBox_localidades.TabIndex = 11;
            // 
            // FrmAltaAdoptante
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.comboBox_localidades);
            this.Controls.Add(this.textBox_telefono);
            this.Controls.Add(this.textBox_dni);
            this.Controls.Add(this.textBox_direccion);
            this.Controls.Add(this.textBox_nombre);
            this.Controls.Add(this.button_cancelar);
            this.Controls.Add(this.button_aceptar);
            this.Controls.Add(this.label_telefono);
            this.Controls.Add(this.label_dni);
            this.Controls.Add(this.label_direccion);
            this.Controls.Add(this.label_nombre);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FrmAltaAdoptante";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Ingreso de datos";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label_nombre;
        private System.Windows.Forms.Label label_direccion;
        private System.Windows.Forms.Label label_dni;
        private System.Windows.Forms.Label label_telefono;
        private System.Windows.Forms.Button button_aceptar;
        private System.Windows.Forms.Button button_cancelar;
        private System.Windows.Forms.TextBox textBox_nombre;
        private System.Windows.Forms.TextBox textBox_direccion;
        private System.Windows.Forms.TextBox textBox_dni;
        private System.Windows.Forms.TextBox textBox_telefono;
        private System.Windows.Forms.ComboBox comboBox_localidades;
    }
}