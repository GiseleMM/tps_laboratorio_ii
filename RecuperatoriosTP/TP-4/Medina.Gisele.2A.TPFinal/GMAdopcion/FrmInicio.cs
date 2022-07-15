using Entidades;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Threading;
namespace GMAdopcion
{
    public delegate void sincronizarLista(List<Perro> p);
    public delegate void sincrinizarListaDelegado<T>(List<T> g);
    public delegate void informar();
    public partial class FrmInicio : Form, IActualizarDatos
    {
        
        static List<Perro> listaPerros;
        static List<Adoptante> listaAdoptantes;
        public static event informar OnInformar;
        Perro seleccionDelPerro;
        Adoptante seleccionAdoptante;
        FrmAltaAdoptante frmAltaAdoptante;
       
      
       

        public FrmInicio()
        {
            InitializeComponent();
            OnInformar += this.ActualizarDatos;
            TraerDeBaseDeDatosListas();
            
         
            frmAltaAdoptante = new FrmAltaAdoptante();
            frmAltaAdoptante.EventIgualDNI += new IgualDNIdelegado(ExistenteAdoptante);

            this.textBox_adoptante.Text = "";
            this.textBox_perro.Text = "";


        }
        public void ActualizarDatos()
        {
            if (this.InvokeRequired)
            {
                Action a = ActualizarDatos;
                this.Invoke(a);
            }
            else
            {

                this.comboBox_Perros.DataSource = null;
                this.comboBox_Perros.DataSource = listaPerros;
                this.comboBox_Perros.SelectionStart = 0;
                this.comboBox_adoptantes.DataSource = null;
                this.comboBox_adoptantes.DataSource = listaAdoptantes;
                this.textBox_adoptante.Text = "";
                this.textBox_perro.Text = "";
                //this.comboBox_adoptantes.SelectionStart = 0;
            }
            
        }



        private void comboBox_Perros_SelectedIndexChanged(object sender, EventArgs e)
        {
            seleccionDelPerro = (Perro)this.comboBox_Perros.SelectedItem;
            if (seleccionDelPerro is not null)
            {
                if (!seleccionDelPerro.ParaAdopcion)
                {
                    seleccionDelPerro = null;
                    this.textBox_perro.Text = string.Empty;
                }
                else
                {
                    this.textBox_perro.Text = seleccionDelPerro.Nombre;
                }

            }


        }


        private void button_agregarAdoptante_Click(object sender, EventArgs e)
        {
           
            frmAltaAdoptante.ShowDialog();
            if (frmAltaAdoptante.DialogResult == DialogResult.OK)
            {
                Adoptante aux = frmAltaAdoptante.ObtenerDatos();
                string ruta = Archivo.Guardar($"Adoptante_{DateTime.Now.ToString("HH-mm-ss")}.txt", aux.ToString(), EDirectorio.DirectorioBaseProyecto);
                MessageBox.Show($"Se a guardado dato de posible Adoptante en {ruta}");
            }
        }

        private void button_AgregarPerros_Click(object sender, EventArgs e)
        {
            FrmAltaPerro frmAltaPerro = new FrmAltaPerro();
            frmAltaPerro.ShowDialog();
            if (frmAltaPerro.DialogResult == DialogResult.OK)
            {
                Perro p=frmAltaPerro.ObtenerDatos();
               
                bool rta=p.Agregar();
                listaPerros = PerrosDAO.ListarPerros();
               
                ActualizarDatos();


            }
        }


        private void comboBox_adoptantes_SelectedIndexChanged(object sender, EventArgs e)
        {
            seleccionAdoptante = (Adoptante)this.comboBox_adoptantes.SelectedItem;

            if (seleccionAdoptante is null)
            {

                this.textBox_adoptante.Text = string.Empty;
            }
            else
            {
                this.textBox_adoptante.Text = seleccionAdoptante.Nombre;
            }

        }

        private void button_si_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(textBox_adoptante.Text) && !string.IsNullOrEmpty(textBox_perro.Text))
            {
             
                seleccionAdoptante += seleccionDelPerro;//adoptante agrega a lista y asigna a perro adoptante

                seleccionDelPerro.ModificarDatos(seleccionDelPerro.Nombre, seleccionDelPerro.Edad, seleccionDelPerro.Refugio, seleccionDelPerro.ParaAdopcion, seleccionDelPerro.Adoptante.Dni);//base de datos
                listaPerros = PerrosDAO.ListarPerros();
                ActualizarDatos();
            }
            else
            {
                MessageBox.Show("Debe cargar Campos");
            }
        }

        private void button_modificarAdoptante_Click(object sender, EventArgs e)
        {
            FrmModificacionAdoptante frmModificacionAdoptante = new FrmModificacionAdoptante(listaAdoptantes,SincronizarConMofificacion<Adoptante>)
            { Owner = this };
            frmModificacionAdoptante.Show();
        }

        private void button_modificarPerro_Click(object sender, EventArgs e)
        {
            FrmModificacionPerro frmModificacionPerro = new FrmModificacionPerro(SincronizarConMofificacion<Perro>) { Owner = this };
            frmModificacionPerro.Show();
        }

        private void FrmInicio_FormClosing(object sender, FormClosingEventArgs e)
        {
            if(MessageBox.Show("Desea salir de aplicacion","Cerrando",MessageBoxButtons.YesNo)==DialogResult.No)
            {
                e.Cancel = true;
            }
            else
            {
                
                listaPerros = PerrosDAO.ListarPerros();
                ClaseSerializadora<List<Perro>>.Serializar_json(listaPerros, "listaPerros.json", EDirectorio.DirectorioBaseProyecto);
              
            }
        }
   
        public void SincronizarConMofificacion<T>(List<T> obj)
        {
            if( obj is not null)
            {
                if( obj[0] is Adoptante)
                {
                    comboBox_adoptantes.DataSource = null;
                    comboBox_adoptantes.DataSource = obj;
                }
                else
                {
                    comboBox_Perros.DataSource = null;
                    comboBox_Perros.DataSource = obj;
                }
            }
        }
        public void ExistenteAdoptante(Adoptante a)
        {
            MessageBox.Show($"DNI  ya en el sistema {a.Nombre}- {a.Dni}");
        }
        /// <summary>
        /// Trae de la base de datos las listas que estan  en el combobox y lanza un evento q actualiza los combo box
        /// mediante un delegado con el metodo de ActualizarDatos
        /// </summary>
        public static async void TraerDeBaseDeDatosListas()
        {
            
            listaAdoptantes = await TraerListaAdoptante();
            listaPerros = await TraerListaPerro();
            await Task.Run(() =>
            {
                while (true)
                {
                    if (listaAdoptantes is not null && listaPerros is not null)
                    {
                        OnInformar.Invoke();

                        break;
                    }
                }
            });
          
           
        }
        private  static async Task<List<Perro>> TraerListaPerro()
        {
       
            List<Perro> aux = null;
            aux = await Task.Run(() => 
                 PerrosDAO.ListarPerros());
                
           
            return aux;
        }
        private static async Task<List<Adoptante>> TraerListaAdoptante()
        {
          

            List<Adoptante> aux = null;
            aux = await Task.Run(() =>     AdoptanteDAO.ListarAdoptantes());
         
            return aux;
        }

        private void FrmInicio_Load(object sender, EventArgs e)
        {

            ActualizarDatos();
            this.textBox_adoptante.Text = "";
            this.textBox_perro.Text = "";
        }
    }
}
