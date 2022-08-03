using Entidades;
using System;
using System.Collections.Generic;
using System.Windows.Forms;
namespace GMAdopcion
{
    public partial class FrmInicio : Form, IActualizarDatos
    {
        List<Perro> listaPerros;
        List<Adoptante> listaAdoptantes;
        Perro seleccionDelPerro;
        Adoptante seleccionAdoptante;
        public FrmInicio()
        {
            InitializeComponent();
            listaPerros = ClaseSerializadora<List<Perro>>.DeSerializar_json("listaPerros.json", EDirectorio.DirectorioBaseProyecto);
            listaAdoptantes = ClaseSerializadora<List<Adoptante>>.DeSerializar_json("listaAdoptantes.json", EDirectorio.DirectorioBaseProyecto);
            seleccionDelPerro = null;
            seleccionAdoptante = null;


            ActualizarDatos();
            this.textBox_adoptante.Text = "";
            this.textBox_perro.Text = "";


        }
        public void ActualizarDatos()
        {

            this.comboBox_Perros.DataSource = null;
            this.comboBox_Perros.DataSource = listaPerros;
            this.comboBox_Perros.SelectionStart = 0;
            this.comboBox_adoptantes.DataSource = null;
            this.comboBox_adoptantes.DataSource = listaAdoptantes;
            this.comboBox_adoptantes.SelectionStart = 0;
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
            FrmAltaAdoptante frmAltaAdoptante = new FrmAltaAdoptante();
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
                listaPerros.Add(frmAltaPerro.ObtenerDatos());
                ActualizarDatos();


            }
        }

        private void button_guardar_Click(object sender, EventArgs e)
        {
            
            ClaseSerializadora<List<Perro>>.Serializar_json(listaPerros, "listaPerros.json", EDirectorio.DirectorioBaseProyecto);
            ClaseSerializadora<List<Adoptante>>.Serializar_json(listaAdoptantes, "listaAdoptantes.json", EDirectorio.DirectorioBaseProyecto);
            MessageBox.Show($"listaPerros.json  y listaAdoptante.json guardada en {AppDomain.CurrentDomain.BaseDirectory}");

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

                seleccionAdoptante += seleccionDelPerro;
                ActualizarDatos();
            }
            else
            {
                MessageBox.Show("Debe cargar Campos");
            }
        }

    }
}
