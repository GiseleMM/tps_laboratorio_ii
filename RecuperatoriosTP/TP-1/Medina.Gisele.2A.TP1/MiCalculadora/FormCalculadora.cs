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

namespace MiCalculadora
{
    public partial class FormCalculadora : Form
    {
        
        public FormCalculadora()
        {
            InitializeComponent();
           
        }

        private void FormCalculadora_Load(object sender, EventArgs e)
        {
            Limpiar();
            this.cmbOperador.Items.Add("");
            this.cmbOperador.Items.Add("+");
            this.cmbOperador.Items.Add("-");
            this.cmbOperador.Items.Add("/");
            this.cmbOperador.Items.Add("*");
          
        }

        private void Limpiar()
        {
            this.cmbOperador.SelectedItem = "";
            lblResultado.Text = "0";
            txtNumero1.Text = string.Empty;
            txtNuemro2.Text = string.Empty;
          
        }
        private static double Operar( string numero1, string numero2, string operador)
        {
            double resultado;
          
            Operando n1 = new Operando(numero1);
            Operando n2 = new Operando(numero2);
            
         resultado=Calculadora.Operar(n1, n2, operador[0]);
            //MessageBox.Show(resultado.ToString());
            return resultado;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void FormCalculadora_FormClosing(object sender, FormClosingEventArgs e)
        {
            if(MessageBox.Show("¿Seguro de querer salir?","Salir",MessageBoxButtons.YesNo,MessageBoxIcon.Question)==DialogResult.No)
            {
               
                e.Cancel = true;
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Limpiar();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string aux1 = this.txtNumero1.Text;
            if(!double.TryParse(this.txtNumero1.Text,out double num))
            {
                aux1 = "0";
            }
            string aux2 = this.txtNuemro2.Text;
            if(!double.TryParse(this.txtNuemro2.Text,out double num2))
            {
                aux2 = "0";
            }
            string operando = this.cmbOperador.GetItemText(cmbOperador.SelectedItem);
            if (!string.IsNullOrEmpty(operando))
            {
              
                double rta = FormCalculadora.Operar(txtNumero1.Text, txtNuemro2.Text, operando);
                 
                lstOperaciones.Items.Add($"{aux1}  {operando}  {aux2} = {rta.ToString()}");

                this.lblResultado.Text = rta.ToString();
            }
        }

        private void btnCionvertirABinario_Click(object sender, EventArgs e)
        {
            Operando conversionABinario = new Operando();
            string aux = string.Empty;
            string buffer = this.lblResultado.Text;
            if(!string.IsNullOrEmpty(buffer) && buffer!= double.MinValue.ToString())
            {
                
                aux=conversionABinario.DecimalBinario(buffer);
                if( aux!= "valor invalido")
                {
                    this.lblResultado.Text=aux.PadLeft(8, '0');
                    this.lstOperaciones.Items.Add($"{buffer} = {aux.PadLeft(8, '0')}");
                }
                else
                {
                    this.lblResultado.Text = aux;
                }
                
            }
        }

        private void btnConvertirADecimal_Click(object sender, EventArgs e)
        {

            Operando conversionADecimal = new Operando();
            string aux = string.Empty;
            string buffer = this.lblResultado.Text;
            if (!string.IsNullOrEmpty(buffer))
            {

                aux = conversionADecimal.BinarioDecimal(buffer);
                if (aux != "valor invalido")
                {
                    this.lblResultado.Text = aux;
                    this.lstOperaciones.Items.Add($"{buffer} = {aux}");
                }
                else
                {
                    this.lblResultado.Text = aux;
                }

            }
        }
    }
}
