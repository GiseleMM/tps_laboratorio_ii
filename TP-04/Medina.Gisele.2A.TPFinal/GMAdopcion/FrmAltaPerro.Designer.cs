
namespace GMAdopcion
{
    partial class FrmAltaPerro
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
            this.label_Nombre = new System.Windows.Forms.Label();
            this.label_Edad = new System.Windows.Forms.Label();
            this.label_refugio = new System.Windows.Forms.Label();
            this.button_aceptar = new System.Windows.Forms.Button();
            this.button_cancelar = new System.Windows.Forms.Button();
            this.textBox_Nombre = new System.Windows.Forms.TextBox();
            this.textBox_refugio = new System.Windows.Forms.TextBox();
            this.numericUpDown_edad = new System.Windows.Forms.NumericUpDown();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_edad)).BeginInit();
            this.SuspendLayout();
            // 
            // label_Nombre
            // 
            this.label_Nombre.AutoSize = true;
            this.label_Nombre.Location = new System.Drawing.Point(74, 61);
            this.label_Nombre.Name = "label_Nombre";
            this.label_Nombre.Size = new System.Drawing.Size(51, 15);
            this.label_Nombre.TabIndex = 0;
            this.label_Nombre.Text = "Nombre";
            // 
            // label_Edad
            // 
            this.label_Edad.AutoSize = true;
            this.label_Edad.Location = new System.Drawing.Point(74, 116);
            this.label_Edad.Name = "label_Edad";
            this.label_Edad.Size = new System.Drawing.Size(98, 15);
            this.label_Edad.TabIndex = 1;
            this.label_Edad.Text = "Edad aproximada";
            // 
            // label_refugio
            // 
            this.label_refugio.AutoSize = true;
            this.label_refugio.Location = new System.Drawing.Point(74, 174);
            this.label_refugio.Name = "label_refugio";
            this.label_refugio.Size = new System.Drawing.Size(48, 15);
            this.label_refugio.TabIndex = 2;
            this.label_refugio.Text = "Refugio";
            // 
            // button_aceptar
            // 
            this.button_aceptar.Location = new System.Drawing.Point(275, 259);
            this.button_aceptar.Name = "button_aceptar";
            this.button_aceptar.Size = new System.Drawing.Size(121, 23);
            this.button_aceptar.TabIndex = 3;
            this.button_aceptar.Text = "Aceptar";
            this.button_aceptar.UseVisualStyleBackColor = true;
            this.button_aceptar.Click += new System.EventHandler(this.button_aceptar_Click);
            // 
            // button_cancelar
            // 
            this.button_cancelar.Location = new System.Drawing.Point(425, 259);
            this.button_cancelar.Name = "button_cancelar";
            this.button_cancelar.Size = new System.Drawing.Size(121, 23);
            this.button_cancelar.TabIndex = 4;
            this.button_cancelar.Text = "Cancelar";
            this.button_cancelar.UseVisualStyleBackColor = true;
            this.button_cancelar.Click += new System.EventHandler(this.button_cancelar_Click);
            // 
            // textBox_Nombre
            // 
            this.textBox_Nombre.Location = new System.Drawing.Point(275, 61);
            this.textBox_Nombre.Name = "textBox_Nombre";
            this.textBox_Nombre.Size = new System.Drawing.Size(271, 23);
            this.textBox_Nombre.TabIndex = 5;
            // 
            // textBox_refugio
            // 
            this.textBox_refugio.Location = new System.Drawing.Point(275, 174);
            this.textBox_refugio.Name = "textBox_refugio";
            this.textBox_refugio.Size = new System.Drawing.Size(271, 23);
            this.textBox_refugio.TabIndex = 7;
            // 
            // numericUpDown_edad
            // 
            this.numericUpDown_edad.Location = new System.Drawing.Point(275, 116);
            this.numericUpDown_edad.Maximum = new decimal(new int[] {
            17,
            0,
            0,
            0});
            this.numericUpDown_edad.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numericUpDown_edad.Name = "numericUpDown_edad";
            this.numericUpDown_edad.Size = new System.Drawing.Size(271, 23);
            this.numericUpDown_edad.TabIndex = 8;
            this.numericUpDown_edad.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // FrmAltaPerro
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(593, 319);
            this.Controls.Add(this.numericUpDown_edad);
            this.Controls.Add(this.textBox_refugio);
            this.Controls.Add(this.textBox_Nombre);
            this.Controls.Add(this.button_cancelar);
            this.Controls.Add(this.button_aceptar);
            this.Controls.Add(this.label_refugio);
            this.Controls.Add(this.label_Edad);
            this.Controls.Add(this.label_Nombre);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FrmAltaPerro";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Ingreso de datos";
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_edad)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label_Nombre;
        private System.Windows.Forms.Label label_Edad;
        private System.Windows.Forms.Label label_refugio;
        private System.Windows.Forms.Button button_aceptar;
        private System.Windows.Forms.Button button_cancelar;
        private System.Windows.Forms.TextBox textBox_Nombre;
        private System.Windows.Forms.TextBox textBox_refugio;
        private System.Windows.Forms.NumericUpDown numericUpDown_edad;
    }
}