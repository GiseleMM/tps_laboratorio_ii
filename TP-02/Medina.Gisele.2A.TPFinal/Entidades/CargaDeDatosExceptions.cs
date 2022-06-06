using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class CargaDeDatosExceptions : Exception
    {

        public CargaDeDatosExceptions() : base("Error en carga de datos\n")
        {
        }

        public CargaDeDatosExceptions(string message) : base(message)
        {
        }

        public CargaDeDatosExceptions(string message, Exception innerException) : base(message, innerException)
        {
        }

    }
}
