
namespace GMAdopcion
{
    partial class FrmModificacionPerro
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
            this.listBox_perros = new System.Windows.Forms.ListBox();
            this.textBox_nombre = new System.Windows.Forms.TextBox();
            this.textBox_refugio = new System.Windows.Forms.TextBox();
            this.numericUpDown_edad = new System.Windows.Forms.NumericUpDown();
            this.button_modificar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_edad)).BeginInit();
            this.SuspendLayout();
            // 
            // listBox_perros
            // 
            this.listBox_perros.FormattingEnabled = true;
            this.listBox_perros.ItemHeight = 15;
            this.listBox_perros.Location = new System.Drawing.Point(405, 34);
            this.listBox_perros.Name = "listBox_perros";
            this.listBox_perros.Size = new System.Drawing.Size(373, 304);
            this.listBox_perros.TabIndex = 0;
            this.listBox_perros.DoubleClick += new System.EventHandler(this.listBox_perros_DoubleClick);
            // 
            // textBox_nombre
            // 
            this.textBox_nombre.Location = new System.Drawing.Point(12, 52);
            this.textBox_nombre.Name = "textBox_nombre";
            this.textBox_nombre.Size = new System.Drawing.Size(359, 23);
            this.textBox_nombre.TabIndex = 1;
            // 
            // textBox_refugio
            // 
            this.textBox_refugio.Location = new System.Drawing.Point(12, 180);
            this.textBox_refugio.Name = "textBox_refugio";
            this.textBox_refugio.Size = new System.Drawing.Size(359, 23);
            this.textBox_refugio.TabIndex = 3;
            // 
            // numericUpDown_edad
            // 
            this.numericUpDown_edad.Location = new System.Drawing.Point(12, 114);
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
            this.numericUpDown_edad.Size = new System.Drawing.Size(359, 23);
            this.numericUpDown_edad.TabIndex = 4;
            this.numericUpDown_edad.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // button_modificar
            // 
            this.button_modificar.Location = new System.Drawing.Point(119, 254);
            this.button_modificar.Name = "button_modificar";
            this.button_modificar.Size = new System.Drawing.Size(144, 23);
            this.button_modificar.TabIndex = 5;
            this.button_modificar.Text = "Modificar";
            this.button_modificar.UseVisualStyleBackColor = true;
            this.button_modificar.Click += new System.EventHandler(this.button_modificar_Click);
            // 
            // FrmModificacionPerro
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.button_modificar);
            this.Controls.Add(this.numericUpDown_edad);
            this.Controls.Add(this.textBox_refugio);
            this.Controls.Add(this.textBox_nombre);
            this.Controls.Add(this.listBox_perros);
            this.Name = "FrmModificacionPerro";
            this.Text = "FrmModificacionPerro";
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_edad)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox listBox_perros;
        private System.Windows.Forms.TextBox textBox_nombre;
        private System.Windows.Forms.TextBox textBox_refugio;
        private System.Windows.Forms.NumericUpDown numericUpDown_edad;
        private System.Windows.Forms.Button button_modificar;
    }
}