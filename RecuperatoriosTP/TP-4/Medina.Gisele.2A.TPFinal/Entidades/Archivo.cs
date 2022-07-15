using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Archivo
    {
        static string rutaBaseEscritorio;
        static string rutaProyecto;
        static Archivo()
        {
            DirectoryInfo info = Directory.CreateDirectory(Environment.GetFolderPath(Environment.SpecialFolder.Desktop) + "\\Archivos_texto\\");
            rutaBaseEscritorio = info.FullName;
            rutaProyecto = AppDomain.CurrentDomain.BaseDirectory;

        }
        /// <summary>
        /// Guarda formato texto el contenido de tipo texto en la ubicacion indicada por el enumerado ,
        /// Escritorio se ubica en una carpeta llamada Archivos_texto
        /// </summary>
        /// <param name="nombreArchivo"></param>
        /// <param name="contenido"></param>
        /// <param name="ubicacion"></param>
        /// <returns></returns>
        public static string Guardar(string nombreArchivo,string contenido,EDirectorio ubicacion)
        {
            string ruta = string.Empty;
            if(ubicacion== EDirectorio.Escritorio)
            {
                ruta = rutaBaseEscritorio + nombreArchivo;
            }
            else
            {
                ruta = rutaProyecto + nombreArchivo;
            }

            try
            {
                File.WriteAllText(ruta, contenido);
            }
            catch (Exception )
            {
                throw;
               
            }
            return ruta;
            
        }
        /// <summary>
        /// Lee  archivo de texto desde Directorio ubicado en Escritorio\Archivos_texto o en el proyecto
        /// </summary>
        /// <param name="nombreDelArchivo"></param>
        /// <param name="ubicacion"></param>
        public void Leer(string nombreDelArchivo,EDirectorio ubicacion )
        {
            string ruta = string.Empty;
            if( ubicacion== EDirectorio.Escritorio)
            {
                ruta = rutaBaseEscritorio + nombreDelArchivo;
            }
            else
            {
                ruta = rutaProyecto + nombreDelArchivo;
            }
            try
            {
                File.ReadAllText(ruta);
            }
            catch (Exception)
            {

                throw;
            }
           
        }


    }
}
