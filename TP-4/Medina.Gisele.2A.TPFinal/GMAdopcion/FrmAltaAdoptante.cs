using Entidades;
using System;
using System.Threading;
using System.Windows.Forms;
namespace GMAdopcion
{
    public delegate void IgualDNIdelegado(Adoptante a);
    public partial class FrmAltaAdoptante : Form, IActualizarDatos, IValidarCampos, IObtenerDatos<Adoptante>
    {
        Adoptante adoptanteAux = null;
        public event IgualDNIdelegado EventIgualDNI;
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
        {
            if ((textBox_nombre.Text == string.Empty) || (textBox_direccion.Text == string.Empty) || textBox_dni.Text == string.Empty || textBox_telefono.Text == string.Empty)
            {
                throw new CargaDeDatosExceptions("completar todos los datos requeridos");
            }
            if (!int.TryParse(this.textBox_dni.Text, out int dni) || (int.Parse(this.textBox_dni.Text) <= 0 || int.Parse(this.textBox_dni.Text) >= 99999999))
            {
                throw new CargaDeDatosExceptions("Error cargar de dni");
            }
            if (!int.TryParse(this.textBox_telefono.Text, out int telefono) || textBox_telefono.Text.Length < 0 || textBox_telefono.Text.Length > 10 || telefono < 0)
            {
                throw new CargaDeDatosExceptions("Error en carga de telefono");
            }


        }


        /// <summary>
        /// Asigna al atributo adoptanteAux un Adoptante el cual obtendra el frmInicio si se confirma los datos
        /// En caso de que el DNI ya este en la base de datos Se lanza un evento que lo maneja frm de inicio con un delegado
        /// que recibe un adoptante 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
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
                if (AdoptanteDAO.Leer(adoptanteAux.Dni) is null)
                {
                    this.EventIgualDNI(adoptanteAux);
                }
                else
                {

                    MessageBox.Show("Procesando datos......");
                    Thread.Sleep(dalay);
                    if (MessageBox.Show(adoptanteAux.ToString(), "confirma?", MessageBoxButtons.OKCancel) == DialogResult.OK)
                    {
                        MessageBox.Show("Se evaluaran la validez  de los datos antes de permitir la adopcion");


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
            }
            catch (CargaDeDatosExceptions ex)
            {
                MessageBox.Show(ex.Message);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message + "\nError alta Perro, Carga de datos");

            }
        }

        private void button_cancelar_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
        }
    }
}
