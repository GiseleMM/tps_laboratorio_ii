using System.Collections.Generic;
using System.Text;

namespace Entidades
{
    public class Adoptante
    {
        string nombre;
        string direccion;
        int dni;
        int telefono;
       

       
        List<Perro> perros;

        public Adoptante()
        {
            perros = new List<Perro>();
        }

        public Adoptante(string nombre, string direccion,int dni, int telefono ): this()
        {
            this.nombre = nombre;
            this.direccion = direccion;
            
            this.telefono = telefono;
            this.dni = dni;
            
        }


        public string Nombre { get => nombre; set => nombre = value; }
        public string Direccion { get => direccion; set => direccion = value; }

        public List<Perro> Perros { get => perros; set => perros = value; }
        public int Dni { get => dni; set => dni = value; }
        public int Telefono { get => telefono; set => telefono = value; }
        

        public static Adoptante operator +(Adoptante a, Perro p)
        {
            a.Perros.Add(p);
            p += a;
            return a;

        }
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendFormat("{0:-15} - {1:-15} - {2:-15} - {3:-15}", Dni.ToString(), Nombre, Direccion, Telefono.ToString());
            if(perros.Count>0)
            {
                sb.AppendLine("\n -Perro/s: ");
                foreach (var item in perros)
                {
                    sb.AppendLine(item.ToString());
                    sb.AppendLine("  ");
                }
            }
            return sb.ToString();
        }
    }
}
