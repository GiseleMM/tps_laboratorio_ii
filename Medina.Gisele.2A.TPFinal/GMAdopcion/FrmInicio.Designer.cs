
namespace GMAdopcion
{
    partial class FrmInicio
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.comboBox_Perros = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.button_agregarAdoptante = new System.Windows.Forms.Button();
            this.label_Perros = new System.Windows.Forms.Label();
            this.button_AgregarPerro = new System.Windows.Forms.Button();
            this.comboBox_adoptantes = new System.Windows.Forms.ComboBox();
            this.button_guardar = new System.Windows.Forms.Button();
            this.textBox_perro = new System.Windows.Forms.TextBox();
            this.groupBox_adopcion = new System.Windows.Forms.GroupBox();
            this.textBox_adoptante = new System.Windows.Forms.TextBox();
            this.label_confirmar = new System.Windows.Forms.Label();
            this.button_si = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.groupBox_adopcion.SuspendLayout();
            this.SuspendLayout();
            // 
            // comboBox_Perros
            // 
            this.comboBox_Perros.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox_Perros.FormattingEnabled = true;
            this.comboBox_Perros.Location = new System.Drawing.Point(12, 148);
            this.comboBox_Perros.Name = "comboBox_Perros";
            this.comboBox_Perros.Size = new System.Drawing.Size(432, 23);
            this.comboBox_Perros.TabIndex = 0;
            this.comboBox_Perros.SelectedIndexChanged += new System.EventHandler(this.comboBox_Perros_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(68, 15);
            this.label1.TabIndex = 1;
            this.label1.Text = "Adoptantes";
            // 
            // button_agregarAdoptante
            // 
            this.button_agregarAdoptante.Location = new System.Drawing.Point(450, 57);
            this.button_agregarAdoptante.Name = "button_agregarAdoptante";
            this.button_agregarAdoptante.Size = new System.Drawing.Size(135, 23);
            this.button_agregarAdoptante.TabIndex = 2;
            this.button_agregarAdoptante.Text = "Agregar adoptante";
            this.button_agregarAdoptante.UseVisualStyleBackColor = true;
            this.button_agregarAdoptante.Click += new System.EventHandler(this.button_agregarAdoptante_Click);
            // 
            // label_Perros
            // 
            this.label_Perros.AutoSize = true;
            this.label_Perros.Location = new System.Drawing.Point(12, 105);
            this.label_Perros.Name = "label_Perros";
            this.label_Perros.Size = new System.Drawing.Size(40, 15);
            this.label_Perros.TabIndex = 3;
            this.label_Perros.Text = "Perros";
            // 
            // button_AgregarPerro
            // 
            this.button_AgregarPerro.Location = new System.Drawing.Point(450, 147);
            this.button_AgregarPerro.Name = "button_AgregarPerro";
            this.button_AgregarPerro.Size = new System.Drawing.Size(135, 23);
            this.button_AgregarPerro.TabIndex = 4;
            this.button_AgregarPerro.Text = "Agregar Perro";
            this.button_AgregarPerro.UseVisualStyleBackColor = true;
            this.button_AgregarPerro.Click += new System.EventHandler(this.button_AgregarPerros_Click);
            // 
            // comboBox_adoptantes
            // 
            this.comboBox_adoptantes.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox_adoptantes.FormattingEnabled = true;
            this.comboBox_adoptantes.Location = new System.Drawing.Point(12, 58);
            this.comboBox_adoptantes.Name = "comboBox_adoptantes";
            this.comboBox_adoptantes.Size = new System.Drawing.Size(432, 23);
            this.comboBox_adoptantes.TabIndex = 5;
            this.comboBox_adoptantes.SelectedIndexChanged += new System.EventHandler(this.comboBox_adoptantes_SelectedIndexChanged);
            // 
            // button_guardar
            // 
            this.button_guardar.Location = new System.Drawing.Point(474, 314);
            this.button_guardar.Name = "button_guardar";
            this.button_guardar.Size = new System.Drawing.Size(75, 23);
            this.button_guardar.TabIndex = 6;
            this.button_guardar.Text = "Guardar";
            this.button_guardar.UseVisualStyleBackColor = true;
            this.button_guardar.Click += new System.EventHandler(this.button_guardar_Click);
            // 
            // textBox_perro
            // 
            this.textBox_perro.Location = new System.Drawing.Point(6, 22);
            this.textBox_perro.Name = "textBox_perro";
            this.textBox_perro.Size = new System.Drawing.Size(179, 23);
            this.textBox_perro.TabIndex = 9;
            // 
            // groupBox_adopcion
            // 
            this.groupBox_adopcion.Controls.Add(this.textBox_adoptante);
            this.groupBox_adopcion.Controls.Add(this.textBox_perro);
            this.groupBox_adopcion.Location = new System.Drawing.Point(170, 215);
            this.groupBox_adopcion.Name = "groupBox_adopcion";
            this.groupBox_adopcion.Size = new System.Drawing.Size(200, 100);
            this.groupBox_adopcion.TabIndex = 10;
            this.groupBox_adopcion.TabStop = false;
            this.groupBox_adopcion.Text = "Seleccionados";
            // 
            // textBox_adoptante
            // 
            this.textBox_adoptante.Location = new System.Drawing.Point(6, 51);
            this.textBox_adoptante.Name = "textBox_adoptante";
            this.textBox_adoptante.Size = new System.Drawing.Size(179, 23);
            this.textBox_adoptante.TabIndex = 10;
            // 
            // label_confirmar
            // 
            this.label_confirmar.AutoSize = true;
            this.label_confirmar.Location = new System.Drawing.Point(170, 322);
            this.label_confirmar.Name = "label_confirmar";
            this.label_confirmar.Size = new System.Drawing.Size(114, 15);
            this.label_confirmar.TabIndex = 11;
            this.label_confirmar.Text = "Confirma seleccion?";
            // 
            // button_si
            // 
            this.button_si.Location = new System.Drawing.Point(283, 314);
            this.button_si.Name = "button_si";
            this.button_si.Size = new System.Drawing.Size(87, 27);
            this.button_si.TabIndex = 12;
            this.button_si.Text = "si";
            this.button_si.UseVisualStyleBackColor = true;
            this.button_si.Click += new System.EventHandler(this.button_si_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(14, 40);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(183, 15);
            this.label2.TabIndex = 13;
            this.label2.Text = "DNI   Nombre Direccion  telefono";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 130);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(158, 15);
            this.label3.TabIndex = 14;
            this.label3.Text = "Id   Nombre  Refugio  estado";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(14, 244);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(107, 15);
            this.label4.TabIndex = 15;
            this.label4.Text = "Perro seleccionado";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(14, 273);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(135, 15);
            this.label5.TabIndex = 16;
            this.label5.Text = "Adoptante seleccionado";
            // 
            // FrmInicio
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(597, 450);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.button_si);
            this.Controls.Add(this.label_confirmar);
            this.Controls.Add(this.groupBox_adopcion);
            this.Controls.Add(this.button_guardar);
            this.Controls.Add(this.comboBox_adoptantes);
            this.Controls.Add(this.button_AgregarPerro);
            this.Controls.Add(this.label_Perros);
            this.Controls.Add(this.button_agregarAdoptante);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.comboBox_Perros);
            this.Name = "FrmInicio";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Gestion Adopcion";
            this.groupBox_adopcion.ResumeLayout(false);
            this.groupBox_adopcion.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox comboBox_Perros;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button_agregarAdoptante;
        private System.Windows.Forms.Label label_Perros;
        private System.Windows.Forms.Button button_AgregarPerro;
        private System.Windows.Forms.ComboBox comboBox_adoptantes;
        private System.Windows.Forms.Button button_guardar;
        private System.Windows.Forms.TextBox textBox_perro;
        private System.Windows.Forms.GroupBox groupBox_adopcion;
        private System.Windows.Forms.TextBox textBox_adoptante;
        private System.Windows.Forms.Label label_confirmar;
        private System.Windows.Forms.Button button_si;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
    }
}

