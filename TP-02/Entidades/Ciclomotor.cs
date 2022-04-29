using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Ciclomotor : Vehiculo
    {
        public Ciclomotor(EMarca marca, string chasis, ConsoleColor color):base(chasis,marca,color)
        {
        }

        /// <summary>
        /// Ciclomotor son 'Chico'
        /// </summary>
        //protected short Tamanio
        protected override ETamanio Tamanio
        {
            get
            {
                //return 0;
                return ETamanio.Chico;

            }
        }

       public override sealed string Mostrar()
        {
            StringBuilder sb = new StringBuilder();

            //sb.AppendLine("CICLOMOTOR");
            //sb.AppendLine(this.Mostrar());
            //sb.AppendLine("TAMAÑO : {0}", this.Tamanio);
            //sb.AppendLine("");
            //sb.AppendLine("---------------------");

            //return sb;
            sb.AppendLine("CICLOMOTOR");
            sb.Append(base.Mostrar());
            sb.AppendLine($"TAMAÑO : {this.Tamanio}");
            sb.AppendLine("");
            sb.AppendLine("---------------------");

            return sb.ToString();



        }
    }
}
