using Entidades;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;
using System.IO;

namespace Test
{
    [TestClass]
    public class ClaseSerializadoraTest
    {
        [TestMethod]
        public void Serializadora_json_CuandoLePasoUnPerro_Deberia_producirUnArchivoJson()
        {
            //arrenge
            Perro p = new Perro("Firu", 3,"caritaSucia");

            //act
            ClaseSerializadora<Perro>.Serializar_json(p, "perro.json");
            //asser
            Assert.IsTrue(File.Exists("perro.json"));
        }

        [TestMethod]
        public void Serializadora_json_CuandoLePadoUnAdpotante_producirUnArchivoJson()
        {
      
            Adoptante a = new Adoptante("Adoptante", "BanfieldOeste",33777079,1533223456);

            ClaseSerializadora<Adoptante>.Serializar_json(a, "adoptante.json");

            Assert.IsTrue(File.Exists("adoptante.json"));
        }
        [TestMethod]
        [ExpectedException(typeof(SerializacionExceptions))]
        public void Serialiazadora_Json_CuandoLePasoRutaInvalida_lanzarEcxepcion()
        {
            Perro p = null;//puedo aceptar null porq la clse Generica no tiene ninguna restrinccion, puede ser de clase o de valor

            ClaseSerializadora<Perro>.Serializar_json(p,"C:\\Archivos\\direccion.json");

        }
        [TestMethod]
        public void DeSerializar_json_CuandoLePasoRutaPerro_DeberiaRetornarUnPerro()
        {
           
            //arrenge
            
            Perro actual = null;
            //act
            actual=ClaseSerializadora<Perro>.DeSerializar_json("perro.json");
            //asser
            Assert.IsInstanceOfType(actual, typeof(Perro));
        }

        [TestMethod]
        public void DeSerializar_json_CuandoLePasoRutaAdoptante_DeberiaRetonarUnAdoptante()
        {

            Adoptante actual = null;
            actual=ClaseSerializadora<Adoptante>.DeSerializar_json("adoptante.json");

            Assert.IsInstanceOfType(actual, typeof(Adoptante));
        }
        [TestMethod]
        [ExpectedException(typeof(SerializacionExceptions))]
        public void Deserialiazadora_Json_CuandoLePasoRutaInvalida_lanzarExcepcion()
        {
          

            ClaseSerializadora<Perro>.DeSerializar_json("C:\\Archivos\\direccion.json");

        }
        [TestMethod]
        public void PropiedadGetRutaJson_deberiaRetornarLaRutaDeLaCarpertaCreadaEnEscritorioConArchivosJson()
        {
            string actual = ClaseSerializadora<string>.RutaBaseJson;
            Assert.IsTrue(Directory.Exists(actual));
        }


    }
}






