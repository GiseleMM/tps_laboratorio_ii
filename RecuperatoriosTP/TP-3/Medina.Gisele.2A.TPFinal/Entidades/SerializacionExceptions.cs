using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class SerializacionExceptions : Exception
    {
        public SerializacionExceptions():base("Error en serializacion\n")
        {
        }

        public SerializacionExceptions(string message) : base(message)
        {
        }

        public SerializacionExceptions(string message, Exception innerException) : base(message, innerException)
        {
        }
        public override string ToString()
        {
            return "Error: " + base.InnerException.Message + "\nOrigen:" + base.Source;
        }

    }
}
