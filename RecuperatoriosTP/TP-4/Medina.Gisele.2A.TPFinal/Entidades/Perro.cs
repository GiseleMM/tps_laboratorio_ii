using System;
using System.Text;

namespace Entidades
{
    public class Perro
    {
        static int idUltimo;
        int id;
        string nombre;
        int edad;
        bool paraAdopcion;
        Adoptante adoptante; 
     
        string refugio;

        static Perro()
        {
            idUltimo = 0;
        }

     

        public Perro(string nombre, int edad,string refugio)
        {
            this.nombre = nombre;
            this.edad = edad;
            this.paraAdopcion = true;
            this.refugio = refugio;
            this.id = idUltimo;
            Perro.idUltimo++;
            
        }

        public string Nombre { get => nombre; set => nombre = value; }
        public int Edad { get => edad; set => edad = value; }
      
        public string Refugio { get => refugio; set => refugio = value; }
        public int Id { get => id; set => id=value; }
        public bool ParaAdopcion { get => paraAdopcion; set => paraAdopcion = value; }
        public Adoptante Adoptante { get => adoptante; set => adoptante = value; }

        public  static Perro operator +( Perro p, Adoptante a)
        {
            p.adoptante = a;
         
            p.paraAdopcion = false;
            return p;
        }
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendFormat("{0:-20} - {1:-20} - {2:-20} - {3:-20} - {4:-20}", Id.ToString(), Nombre, Edad.ToString(), Refugio, ParaAdopcion ? "Disponible": "Adoptado");
            return sb.ToString();
        }
       

    }
}
