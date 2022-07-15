using System;
using System.Collections.Generic;
using Entidades;
namespace ConsolaPrueba
{
    class Program
    {
        static void Main(string[] args)
        {
            //Console.WriteLine("Hello World!");
            //List<Perro> listaPerros = new List<Perro>();
            //Perro perro0 = new Perro("Blue", 2, "Refugio Sur");
            //Perro perro1 = new Perro("Rocky", 7,"San Francisco de Asis");
            //Perro perro2 = new Perro("Luna", 7,"San Francisco de Asis");
            //Perro perro3 = new Perro("Lebron", 3,"San Francisco de Asis");
            //Perro perro4 = new Perro("Isidoro", 2,"Refugio Sur");
            //Perro perro5 = new Perro("Rocky", 10, "Refugio Sur");
            //Perro perro6 = new Perro("Igor", 5, "Refugio Sur");
            //Perro perro7 = new Perro("Bombona", 5, "Naricitas frias");
            //Perro perro8 = new Perro("Andre", 1, "Naricitas frias");
            //Perro perro9 = new Perro("Bichi", 3, "Naricitas frias");
            //Perro perro10 = new Perro("Lucky", 7, "San Francisco de Asis");
            //Perro perro11 = new Perro("Osito", 7, "San Francisco de Asis");
            //Perro perro12 = new Perro("Princesa", 2, "San Francisco de Asis");
            //Perro perro13 = new Perro("Oreo", 1, "San Francisco de Asis");
            //Perro perro14 = new Perro("Elvis", 5, "Refugio Sur");
            //Perro perro15 = new Perro("Balto", 5, "Refugio Sur");
            //Perro perro16 = new Perro("Pluto", 3, "Refugio Sur");
            //Perro perro17 = new Perro("Max", 3, "Refugio Sur");
            //Perro perro18 = new Perro("Leo", 9, "San Francisco de Asis");
            //Perro perro19 = new Perro("Simba", 8, "San Francisco de Asis");
            //Perro perro20 = new Perro("Coco", 10, "San Francisco de Asis");
            //Perro perro21 = new Perro("Thor", 10, "Naricitas frias");
            //Perro perro22 = new Perro("Nene", 4, "Naricitas frias");
            //Perro perro23 = new Perro("Tobi", 4, "Naricitas frias");
            //Perro perro24 = new Perro("Beto", 2, "Naricitas frias");
            //Perro perro25 = new Perro("Tupac", 1, "Naricitas frias");
            //Perro perro26 = new Perro("Rocco", 8, "Naricitas frias");

            //listaPerros.Add(perro0);
            //listaPerros.Add(perro1);
            //listaPerros.Add(perro2);
            //listaPerros.Add(perro3);
            //listaPerros.Add(perro4);
            //listaPerros.Add(perro5);
            //listaPerros.Add(perro6);
            //listaPerros.Add(perro7);
            //listaPerros.Add(perro8);
            //listaPerros.Add(perro9);
            //listaPerros.Add(perro10);
            //listaPerros.Add(perro11);
            //listaPerros.Add(perro12);
            //listaPerros.Add(perro13);
            //listaPerros.Add(perro14);
            //listaPerros.Add(perro15);
            //listaPerros.Add(perro16);
            //listaPerros.Add(perro17);
            //listaPerros.Add(perro18);
            //listaPerros.Add(perro19);
            //listaPerros.Add(perro20);
            //listaPerros.Add(perro21);
            //listaPerros.Add(perro22);
            //listaPerros.Add(perro23);
            //listaPerros.Add(perro24);
            //listaPerros.Add(perro25);

            //listaPerros.Add(perro26);

            //foreach (var item in listaPerros)
            //{
            //    Console.WriteLine(item.ToString());
            //}

            //Adoptante adoptante0 = new Adoptante("Rocio Leal", "Lanus,Arturo Melo 1700", 44714923, 1511223344);
            //adoptante0 += perro26;
            //adoptante0 += perro25;
            //Adoptante adoptante1 = new Adoptante("Jonathan Garcia", "Lanus,Resistencia 1820", 20714983, 1500023344);
            //adoptante1 += perro24;
            //Adoptante adoptante2 = new Adoptante("Nestor Gomez", "Lanus,Beracruz 1490", 44722223, 1511223098);
            //adoptante2 += perro23;
            //Adoptante adoptante3 = new Adoptante("Rene Pagani", "Bnafield,Maipu 974", 65578823, 1587658899);
            //adoptante3 += perro22;
            //adoptante3 += perro21;
            //Adoptante adoptante4 = new Adoptante("Roberto Morales", "Banfield,Pedernera 1230", 45714523, 1521223444);
            //adoptante4 += perro20;


            //List<Adoptante> listaAdoptantes = new List<Adoptante>();
            //listaAdoptantes.Add(adoptante0);
            //listaAdoptantes.Add(adoptante1);
            //listaAdoptantes.Add(adoptante2);
            //listaAdoptantes.Add(adoptante3);
            //listaAdoptantes.Add(adoptante4);
            //foreach (var item in listaAdoptantes)
            //{
            //    Console.WriteLine(item.ToString());
            //}
            //ClaseSerializadora<List<Adoptante>>.Serializar_json(listaAdoptantes, "listaAdoptantes.json");
            //ClaseSerializadora<List<Perro>>.Serializar_json(listaPerros, "listaPerros.json");

            List<Perro> listaAuxPerros = null;
            listaAuxPerros = ClaseSerializadora<List<Perro>>.DeSerializar_json("listaPerros.json", EDirectorio.DirectorioBaseProyecto);
            foreach (Perro item in listaAuxPerros)
            {
                Console.WriteLine(item.ToString());
            }

            //List<string> listaPrueba = new List<string>() { "Lali", "Lomas", "boca", "juniors" };
            //ClaseSerializadora<List<string>>.Serializar_json(listaPrueba, "listaPrueba.json", EDirectorio.DirectorioBaseProyecto);


        }
    }
}
