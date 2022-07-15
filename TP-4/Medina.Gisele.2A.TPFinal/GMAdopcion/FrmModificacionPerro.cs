using Entidades;
using System.Collections.Generic;
using System.Windows.Forms;
namespace GMAdopcion
{
    public partial class FrmModificacionPerro : Form, IActualizarDatos, IValidarCampos
    {
        List<Perro> lista = null;
        Perro perro = null;
        private sincrinizarListaDelegado<Perro>  sincrinizarListaDelegado;      
        public FrmModificacionPerro(sincrinizarListaDelegado<Perro> manejador)
        {
            InitializeComponent();
            lista = PerrosDAO.ListarPerros();
            if (manejador is not null)
            {
                sincrinizarListaDelegado = manejador;
            }
            button_modificar.Enabled = false;
            ActualizarDatos();
           
        }
        public void ActualizarDatos()
        {
            this.listBox_perros.DataSource = null;
            this.listBox_perros.DataSource = lista;
        }


        public void ValidarCampos()
        {
            if (textBox_nombre.Text == string.Empty || textBox_refugio.Text == string.Empty)
            {
                throw new CargaDeDatosExceptions("Error En Ingreso de datos ");
            }

        }

        private void listBox_perros_DoubleClick(object sender, System.EventArgs e)
        {
            perro = listBox_perros.SelectedItem as Perro;
            if(perro is not null)
            {
                textBox_nombre.Text = perro.Nombre;
                textBox_refugio.Text = perro.Refugio;
                numericUpDown_edad.Value = perro.Edad;
            }
            button_modificar.Enabled = true;
        }
        /// <summary>
        /// Modifica los campos habilitados en el textbox y sincroniza lista del frmInicio
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void button_modificar_Click(object sender, System.EventArgs e)
        {
            ValidarCampos();
            perro = listBox_perros.SelectedItem as Perro;
            if ( perro is not null)
            {
                try
                {
                    bool rta = perro.ModificarDatos(textBox_nombre.Text, (int)numericUpDown_edad.Value, textBox_refugio.Text, perro.ParaAdopcion, perro.Adoptante is null ? 0 : perro.Adoptante.Dni);
                    if(rta==true)
                    {
                        MessageBox.Show("Se realizo la modificacion");
                        lista = PerrosDAO.ListarPerros();
                        sincrinizarListaDelegado.Invoke(lista);
                        ActualizarDatos();
                    }

                }
                catch (System.Exception ex)
                {

                    MessageBox.Show(ex.Message);
                }
            }
        }
    }

}

