using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    //public class Suv
    public class Suv :Vehiculo
    {
        public Suv(EMarca marca, string chasis, ConsoleColor color)
            : base(chasis, marca, color)
        {
        }
        /// <summary>
        /// SUV son 'Grande'
        /// </summary>
        protected override ETamanio Tamanio
        {
            get
            {
                //return 0;
                return ETamanio.Grande;
            }
        }

        public override sealed string Mostrar()
        {
            StringBuilder sb = new StringBuilder();

            //sb.AppendLine("SUV");
            //sb.AppendLine(base);
            //sb.AppendLine("TAMAÑO : {0}", this.Tamanio);
            //sb.AppendLine("");
            //sb.AppendLine("---------------------");

            //return sb;
            sb.AppendLine("SUV");
            sb.Append(base.Mostrar());
            sb.AppendLine($"TAMAÑO : {this.Tamanio}");
            sb.AppendLine("");
            sb.AppendLine("-----------------------");
            return sb.ToString();
        }
    }
}
