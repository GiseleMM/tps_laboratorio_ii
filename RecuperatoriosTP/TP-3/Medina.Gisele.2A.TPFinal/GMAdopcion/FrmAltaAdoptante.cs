using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Entidades;
using System.Threading;
namespace GMAdopcion
{
    public partial class FrmAltaAdoptante : Form,IActualizarDatos,IValidarCampos,IObtenerDatos<Adoptante>
    {
        Adoptante adoptanteAux = null;
        public FrmAltaAdoptante()
        {
            InitializeComponent();
            ActualizarDatos();
           
        }

        public void ActualizarDatos()
        {
            this.comboBox_localidades.DataSource = null;
            foreach (ELocalidad item in Enum.GetValues(typeof(ELocalidad)))
            {
                this.comboBox_localidades.Items.Add(item);
            }
        }

        public Adoptante ObtenerDatos()
        {
            return adoptanteAux;
        }

  
        public void ValidarCampos()
        {   if((textBox_nombre.Text==string.Empty) || (textBox_direccion.Text==string.Empty) || textBox_dni.Text== string.Empty || textBox_telefono.Text==string.Empty)
            {
                throw new CargaDeDatosExceptions("comppletar todos los datos requeridos");
            }
            if(!int.TryParse(this.textBox_dni.Text, out int dni) || (int.Parse(this.textBox_dni.Text) <= 0 || int.Parse(this.textBox_dni.Text) >= 99999999))
            {
                throw new CargaDeDatosExceptions("Error cargar de dni");
            }
            if(!int.TryParse(this.textBox_telefono.Text, out int telefono) || textBox_telefono.Text.Length < 0 || textBox_telefono.Text.Length > 10 || telefono < 0)
            {
                throw new CargaDeDatosExceptions("Error en carga de telefono");
            }
        
        
        }

     

        private void button_aceptar_Click_1(object sender, EventArgs e)
        {
            int dalay = 2000;
            string nombre;
            int dni;
            string direccion;
            int telefono;
            try
            {
                ValidarCampos();
                nombre = this.textBox_nombre.Text;
                direccion = this.textBox_direccion.Text;
                dni = int.Parse(this.textBox_dni.Text);
                telefono = int.Parse(this.textBox_telefono.Text);
                adoptanteAux = new Adoptante(nombre, direccion, dni, telefono);

                MessageBox.Show("Procesando datos......");
                Thread.Sleep(dalay);
                if (MessageBox.Show(adoptanteAux.ToString(), "confirma?", MessageBoxButtons.OKCancel) == DialogResult.OK)
                {
                    MessageBox.Show("Se evaluaran la validez datos antes de permitir la adopcion");


                    this.DialogResult = DialogResult.OK;
                }
                else
                {
                    textBox_direccion.Text = String.Empty;
                    textBox_dni.Text = string.Empty;
                    textBox_nombre.Text = string.Empty;
                    textBox_telefono.Text = string.Empty;
                }
            }
            catch (CargaDeDatosExceptions ex)
            {
                MessageBox.Show(ex.Message);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message + "\nError alta Perro, Cargar de datos");

            }
        }

        private void button_cancelar_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
        }
    }
}
