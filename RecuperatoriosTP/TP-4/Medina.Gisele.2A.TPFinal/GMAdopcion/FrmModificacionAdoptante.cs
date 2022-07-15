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
    
    public partial class FrmModificacionAdoptante : Form,IActualizarDatos,IValidarCampos
    {
        Adoptante adoptante = null;
        //Adoptante aux = null;
        List<Adoptante> lista;
        private sincrinizarListaDelegado<Adoptante> delegadoSincronizarLista;

        public FrmModificacionAdoptante(List<Adoptante> lista,sincrinizarListaDelegado<Adoptante> manejador)
        {
            InitializeComponent();

            this.lista = lista;
            this.button_modificar.Enabled = false;
            ActualizarDatos();
            if(manejador is not null)
            {
                delegadoSincronizarLista += manejador;

            }
            
        }
       public void ActualizarDatos()
        {
            this.listBox_Adoptantes.DataSource = null;
            this.listBox_Adoptantes.DataSource = lista;
        }
        /// <summary>
        /// coloca en los textbox los campos a mofificar y habilita el boton modificar
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void listBox_Adoptantes_DoubleClick(object sender, EventArgs e)
        {
            adoptante = listBox_Adoptantes.SelectedItem as Adoptante;
            if( adoptante is not null)
            {
                textBox_nombre.Text = adoptante.Nombre;
                textBox_direccion.Text = adoptante.Direccion;
                textBox_telefono.Text = adoptante.Telefono.ToString();

            }
            this.button_modificar.Enabled = true;
        }
        /// <summary>
        /// realiza la mofificacion en la base de datos y actualiza la lista del del frmInicio con el delegado que
        /// se pasa en el constructor 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void button_modificar_Click(object sender, EventArgs e)
        {
            ValidarCampos();
            adoptante = this.listBox_Adoptantes.SelectedItem as Adoptante;
            if(adoptante  is not null)
            {
                try
                {
                    bool rta = adoptante.ModificarDatos(textBox_nombre.Text, textBox_direccion.Text, int.Parse(textBox_telefono.Text));
                    if( rta==false)
                    {
                        MessageBox.Show("Erro no se pudo mofificar");
                    }
                    else
                    {
                        lista = AdoptanteDAO.ListarAdoptantes();
                        delegadoSincronizarLista.Invoke(lista);//actualizo lista en frmInicio
                        ActualizarDatos();
                    }
                }
                catch (Exception ex)
                {

                    MessageBox.Show(ex.Message);
                }
            }
            
        }
        public void ValidarCampos()
        {
            if ((textBox_nombre.Text == string.Empty) || (textBox_direccion.Text == string.Empty) || textBox_telefono.Text == string.Empty)
            {
                throw new CargaDeDatosExceptions("completar todos los datos requeridos");
            }
          
            if (!int.TryParse(this.textBox_telefono.Text, out int telefono) || textBox_telefono.Text.Length<0 || textBox_telefono.Text.Length>10 || telefono<0)
            {
                throw new CargaDeDatosExceptions("Error en carga de telefono");
            }


        }
    }
}
