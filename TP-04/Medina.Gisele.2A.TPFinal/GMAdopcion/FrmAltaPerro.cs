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
namespace GMAdopcion
{
    public partial class FrmAltaPerro : Form, IObtenerDatos<Perro>,IValidarCampos
    {
        Perro perroAux = null;
        public FrmAltaPerro()
        {
            InitializeComponent();
        }

        public Perro ObtenerDatos()
        {
            return perroAux;
        }

        private void button_aceptar_Click(object sender, EventArgs e)
        {
            string nombre;
            int edad;
            string refugio;
            try
            {
                ValidarCampos();
                nombre = this.textBox_Nombre.Text;
                edad = (int)this.numericUpDown_edad.Value;
                refugio = this.textBox_refugio.Text;
                perroAux = new Perro(nombre, edad, refugio);
                MessageBox.Show($"Nuevo Perro: {perroAux.Nombre} del refugio: {perroAux.Refugio}");
                this.DialogResult = DialogResult.OK;
            }
            catch(CargaDeDatosExceptions ex)
            {
                MessageBox.Show(ex.Message);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message+"\nError alta Perro, Cargar de datos");
                
            }
           
            
        }
        public void ValidarCampos()
        {
            if(textBox_Nombre.Text==string.Empty||textBox_refugio.Text==string.Empty)
            {
                throw new CargaDeDatosExceptions("Error En Ingreso de datos ");
            }
            
        }

        private void button_cancelar_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
            
        }
    }
}
