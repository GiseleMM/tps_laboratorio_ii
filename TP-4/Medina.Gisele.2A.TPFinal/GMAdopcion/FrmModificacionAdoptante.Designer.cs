
namespace GMAdopcion
{
    partial class FrmModificacionAdoptante
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
            this.listBox_Adoptantes = new System.Windows.Forms.ListBox();
            this.textBox_nombre = new System.Windows.Forms.TextBox();
            this.textBox_direccion = new System.Windows.Forms.TextBox();
            this.textBox_telefono = new System.Windows.Forms.TextBox();
            this.button_modificar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // listBox_Adoptantes
            // 
            this.listBox_Adoptantes.FormattingEnabled = true;
            this.listBox_Adoptantes.ItemHeight = 15;
            this.listBox_Adoptantes.Location = new System.Drawing.Point(399, 46);
            this.listBox_Adoptantes.Name = "listBox_Adoptantes";
            this.listBox_Adoptantes.Size = new System.Drawing.Size(328, 259);
            this.listBox_Adoptantes.TabIndex = 0;
            this.listBox_Adoptantes.DoubleClick += new System.EventHandler(this.listBox_Adoptantes_DoubleClick);
            // 
            // textBox_nombre
            // 
            this.textBox_nombre.Location = new System.Drawing.Point(37, 65);
            this.textBox_nombre.Name = "textBox_nombre";
            this.textBox_nombre.Size = new System.Drawing.Size(262, 23);
            this.textBox_nombre.TabIndex = 1;
            // 
            // textBox_direccion
            // 
            this.textBox_direccion.Location = new System.Drawing.Point(37, 129);
            this.textBox_direccion.Name = "textBox_direccion";
            this.textBox_direccion.Size = new System.Drawing.Size(262, 23);
            this.textBox_direccion.TabIndex = 2;
            // 
            // textBox_telefono
            // 
            this.textBox_telefono.Location = new System.Drawing.Point(38, 193);
            this.textBox_telefono.Name = "textBox_telefono";
            this.textBox_telefono.Size = new System.Drawing.Size(261, 23);
            this.textBox_telefono.TabIndex = 3;
            // 
            // button_modificar
            // 
            this.button_modificar.Location = new System.Drawing.Point(122, 250);
            this.button_modificar.Name = "button_modificar";
            this.button_modificar.Size = new System.Drawing.Size(75, 23);
            this.button_modificar.TabIndex = 4;
            this.button_modificar.Text = "Modificar";
            this.button_modificar.UseVisualStyleBackColor = true;
            this.button_modificar.Click += new System.EventHandler(this.button_modificar_Click);
            // 
            // FrmModificacionAdoptante
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.button_modificar);
            this.Controls.Add(this.textBox_telefono);
            this.Controls.Add(this.textBox_direccion);
            this.Controls.Add(this.textBox_nombre);
            this.Controls.Add(this.listBox_Adoptantes);
            this.Name = "FrmModificacionAdoptante";
            this.Text = "Modificacion ";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox listBox_Adoptantes;
        private System.Windows.Forms.TextBox textBox_nombre;
        private System.Windows.Forms.TextBox textBox_direccion;
        private System.Windows.Forms.TextBox textBox_telefono;
        private System.Windows.Forms.Button button_modificar;
    }
}