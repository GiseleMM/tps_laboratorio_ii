using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Operando
    {
        private double numero;
   
        public Operando(double numero):this(numero.ToString())
        {
           
        }
        public Operando():this(0)
        {

        }
        public Operando( string strNumero)
        {
            this.Numero = strNumero;//usoo propiedad
        }
        /// <summary>
        /// signará un valor al atributo número, previa validación con ValidarOperando.
        /// </summary>
        public string Numero
        {
            set
            {

                this.numero = ValidarOperando(value);
            }
        }
        /// <summary>
        /// validará que se trate de un binario y luego convertirá ese número binario a decimal, en caso de ser posible. Caso contrario retornará "Valor inválido"
        /// </summary>
        /// <param name="binario"></param>
        /// <returns></returns>
        public string BinarioDecimal(string binario)
        {
            string conversion;
            if(!string.IsNullOrEmpty(binario) && EsBinario(binario))
            {
                conversion=Convert.ToInt32(binario,2).ToString();
            }
            else
            {

                conversion = "valor invalido";
            }
            return conversion;
        }
        public string DecimalBinario(double numero)
        {
            string conversion;
            int enteroAbsoluto = Math.Abs((int)numero);
            conversion=Convert.ToString(enteroAbsoluto, 2);
            if(!EsBinario(conversion))
            {
                conversion = "valor invalido";
            }
            return conversion;
        }
        public string DecimalBinario(string numero)
        {
            string conversion = "valor invalido";
            if(!string.IsNullOrEmpty(numero))
            {
                if(double.TryParse(numero,out double numeroDecimal))
                {
                   conversion = DecimalBinario(numeroDecimal);
                }
             
               
            }
            return conversion;
        }
        /// <summary>
        /// validará que la cadena de caracteres esté compuesta SOLAMENTE por caracteres '0' o '1'.
        /// </summary>
        /// <param name="binario"></param>
        /// <returns></returns>
        private bool EsBinario(string binario)
        {
            bool esBinario = true;
            if(! string.IsNullOrEmpty(binario))
            {
                foreach (char item in binario)
                {
                    if(item!='0' && item!='1' )
                    {
                        esBinario = false;
                        break;
                    }
                }
            }

            return esBinario;
        }
        /// <summary>
        /// comprobará que el valor recibido sea numérico, y lo retornará en formato double. Caso contrario, retornará 0.
        /// </summary>
        /// <param name="srtNumero"></param>
        /// <returns>en formato double si  es numerico, 0 si no lo es</returns>
        private double ValidarOperando(string srtNumero)
        {
            double valorRecibido;
            if(string.IsNullOrEmpty(srtNumero))
            {
                
                valorRecibido = 0;
            }
            else
            {
                if (!double.TryParse(srtNumero,out valorRecibido))
                {
                    valorRecibido = 0;
                }

            }

            return valorRecibido;
        }
        /// <summary>
        /// Los operadores realizarán las operaciones correspondientes entre dos números.Resta
        /// <param name="n1"></param>
        /// <param name="n2"></param>
        /// <returns></returns>
        public static double operator - ( Operando n1, Operando n2 )
        {
            double resultado = 0;
            if (n1 is not null && n2 is not null)
            {
                resultado = n1.numero - n2.numero;
            }
            return resultado;
        }
        /// <summary>
        /// Los operadores realizarán las operaciones correspondientes entre dos números.Multiplicacion
        /// </summary>
        /// <param name="n1"></param>
        /// <param name="n2"></param>
        /// <returns></returns>
        public static double operator * ( Operando n1, Operando n2)
        {
            double resultado = 0;
            if (n1 is not null && n2 is not null)
            {
                resultado = n1.numero * n2.numero;
            }
            return resultado;


        }
        /// <summary>
        /// Los operadores realizarán las operaciones correspondientes entre dos números. 
        /// <param name="n1"></param>
        /// <param name="n2"></param>
        /// <returns>Si se tratara de una división por 0, retornará double.MinValue</returns>
        public static double operator / ( Operando n1, Operando n2)
        {
            double resultado =0;
            if( n1 is not null && n2 is not null)
            {
                if (n2.numero==0)
                {
                    resultado = double.MinValue;
                }
                else
                {
                    resultado = n1.numero / n2.numero;
                }

                
            }
            return resultado;


        }
        /// <summary>
        /// Los operadores realizarán las operaciones correspondientes entre dos números. SuMa
        /// </summary>
        /// <param name="n1"></param>
        /// <param name="n2"></param>
        /// <returns></returns>
        public static double operator +( Operando n1, Operando n2)
        {
            double resultado = 0;
            if( n1 is not null && n2 is not null)
            {
                resultado = n1.numero + n2.numero;
            }
            return resultado;
        }




    }
}
