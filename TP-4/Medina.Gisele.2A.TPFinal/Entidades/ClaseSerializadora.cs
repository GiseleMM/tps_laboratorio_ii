using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace Entidades
{
    public  class ClaseSerializadora<T>
    {
        static string rutaBaseJson;

        public static string RutaBaseJson { get => rutaBaseJson; set => rutaBaseJson = value; }

        static ClaseSerializadora()
        {
            DirectoryInfo infoJson= Directory.CreateDirectory(Environment.GetFolderPath(Environment.SpecialFolder.Desktop)+"\\Archivos_SerializadosJson\\");
            rutaBaseJson = infoJson.FullName;
        }
        /// <summary>
        ///  Por defecto serializa en fotmato Json la carpeta creada en Escritorio con Archivos serializados
        /// </summary>
        /// <param name="objecto"></param> Generica sin ningun tipo de restriccion 
        /// <param name="archivo"></param> solo el nombre, la ruta es la del escritorio
        /// <returns></returns>
        public static string Serializar_json(T objecto, string archivo)
        {
            string obj_json = string.Empty;
            JsonSerializerOptions configuracion = new JsonSerializerOptions();
            configuracion.WriteIndented = true;

            try
            {
                using (StreamWriter sw = new StreamWriter(rutaBaseJson+archivo))
                {
                    obj_json = JsonSerializer.Serialize(objecto, configuracion);
                    Console.WriteLine(objecto);
                    sw.WriteLine(obj_json);
                }
            }
            catch (Exception e)
            {
                throw new SerializacionExceptions("Metodo Serializacion Json",e);
            }

            return obj_json;
        }
        /// <summary>
        /// Sobrecargar de serializacion con un Enumerado  que me dice donde guarda el json
        /// </summary>
        /// <param name="objecto"></param> 
        /// <param name="archivo"></param> nombre.json
        /// <param name="ubicacion"></param> puede ser el Escritorio o En el proyecto 
        /// <returns></returns>
        public static string Serializar_json(T objecto, string archivo,EDirectorio ubicacion)
        {
            if( ubicacion== EDirectorio.Escritorio)
            {
                return Serializar_json(objecto, archivo);
            }
            string rutaBase = AppDomain.CurrentDomain.BaseDirectory;
            string obj_json = string.Empty;
            JsonSerializerOptions configuracion = new JsonSerializerOptions();
            configuracion.WriteIndented = true;

            try
            {
                using (StreamWriter sw = new StreamWriter(rutaBase + archivo))
                {
                    obj_json = JsonSerializer.Serialize(objecto, configuracion);
                    
                    sw.WriteLine(obj_json);
                    
                }
            }
            catch (Exception e)
            {
                throw new SerializacionExceptions("Metodo Serializacion Json", e);
            }

            return obj_json;
        }
        /// <summary>
        ///  Deserializa json Generica por defecto, lo lee en la carpeta creada por la claseSerializadora
        /// </summary>
        /// <param name="nombreArchivo"></param> nombre.json
        /// <returns></returns>
        public static T DeSerializar_json(string nombreArchivo)
        {
            T dato = default(T);
            string obj_json = string.Empty;
            try
            {
                using (StreamReader reader = new StreamReader(rutaBaseJson+nombreArchivo))
                {
                   
                   obj_json= reader.ReadToEnd();
                    //Console.WriteLine(obj_json);
                    dato = JsonSerializer.Deserialize<T>(obj_json);
                   

                }
            }
            catch (Exception e)
            {

                throw new SerializacionExceptions("Metodo Deserializacion Json\n",e);
            }

            return dato;
        }
        /// <summary>
        /// Sobrecargar de Deserializacion con Enumerado indicando la ubicacion desde donde leer el 1° parametro
        /// </summary>
        /// <param name="nombreArchivo"></param>
        /// <param name="ubicacion"></param>
        /// <returns></returns>
        public static T DeSerializar_json(string nombreArchivo,EDirectorio ubicacion)
        {
            if( ubicacion==EDirectorio.Escritorio)
            {
                return ClaseSerializadora<T>.DeSerializar_json(nombreArchivo);
            }
            string rutaBase =AppDomain.CurrentDomain.BaseDirectory;

            T dato = default(T);
            string obj_json = string.Empty;
            try
            {
                using (StreamReader reader = new StreamReader(rutaBase+ nombreArchivo))
                {

                    obj_json = reader.ReadToEnd();
                   // Console.WriteLine(obj_json);
                    dato = JsonSerializer.Deserialize<T>(obj_json);


                }
            }
            catch (Exception e)
            {

                throw new SerializacionExceptions("Metodo Deserializacion Json\n", e);
            }

            return dato;
        }
        

    }
}
