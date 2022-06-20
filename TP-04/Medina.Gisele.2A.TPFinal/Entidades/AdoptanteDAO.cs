using System;
using System.Collections.Generic;
using System.Data.SqlClient;

namespace Entidades
{
    public static class AdoptanteDAO
    {
        private static string cadena_conexion;
        private static SqlConnection conexion;
        private static SqlCommand comando;
        private static SqlDataReader lector;

        static AdoptanteDAO()
        {

            cadena_conexion = $"Server=.;DataBase=TPFinal;trusted_connection=true;";
            comando = new SqlCommand();
            conexion = new SqlConnection(cadena_conexion);
            comando.CommandType = System.Data.CommandType.Text;
            comando.Connection = conexion;

        }
        public static bool ProbarConexion()
        {
            bool buenaConexion = true;
            try
            {
                conexion.Open();
            }
            catch (Exception)
            {
                buenaConexion = false;

            }
            finally
            {
                if (AdoptanteDAO.conexion.State == System.Data.ConnectionState.Open)
                {
                    AdoptanteDAO.conexion.Close();
                }
            }

            return buenaConexion;
        }
        /// <summary>
        /// Lee un adoptante de la base de dato y con el dato del dni realiza una consulta en la tabla de perro para obtener la lista de perros
        /// </summary>
        /// <param name="DNI"></param>
        /// <returns></returns>
        public static Adoptante Leer(int DNI)
        {
            Adoptante adoptante = null;
            try
            {
                comando.Parameters.Clear();
                comando.Parameters.AddWithValue("@DNI", DNI);
                string sql = $"SELECT * FROM WHERE DNI= @DNI";
                List<Perro> auxPerros = PerrosDAO.LeerPerrosDeADoptante(DNI);
                comando.CommandText = sql;
                conexion.Open();
                using (AdoptanteDAO.lector = comando.ExecuteReader())
                {
                    while (lector.Read())
                    {
                        adoptante = new Adoptante();
                        adoptante.Dni = lector.GetInt32(0);
                        adoptante.Nombre = lector.GetString(1);
                        adoptante.Direccion = lector.GetString(2);
                        adoptante.Telefono = lector.GetInt32(3);
                        adoptante.Perros = auxPerros;
                    }

                }



            }
            catch (Exception)
            {
                adoptante = null;


            }
            finally
            {
                if (conexion.State == System.Data.ConnectionState.Open)
                {
                    conexion.Close();
                }
            }
            return adoptante;
        }
        public static List<Adoptante> ListarAdoptantes()
        {
            List<Adoptante> listaAdoptantes = new List<Adoptante>();
            try
            {
                string sql = "SELECT *FROM ADOPTANTE";
                comando.CommandText = sql;
                conexion.Open();
                using (lector = comando.ExecuteReader())
                {
                    while (lector.Read())
                    {
                        Adoptante a = new Adoptante();
                        a.Dni = lector.GetInt32(0);
                        a.Nombre = lector.GetString(1);
                        a.Direccion = lector.GetString(2);
                        a.Telefono = lector.GetInt32(3);
                        if (a is not null)
                        {
                            listaAdoptantes.Add(a);
                        }
                    }
                }

            }
            catch (Exception)
            {
                listaAdoptantes = null;

            }
            finally
            {
                if (conexion.State == System.Data.ConnectionState.Open)
                {
                    conexion.Close();
                }
            }
            for (int i = 0; i < listaAdoptantes.Count; i++)
            {
                List<Perro> listaPerros = PerrosDAO.LeerPerrosDeADoptante(listaAdoptantes[i].Dni);//obtengo la lista dde perro de mi adoptante 
                for (int j = 0; j < listaPerros.Count; j++)
                {
                    listaAdoptantes[i] += listaPerros[j];

                }
            }

            return listaAdoptantes;
        }
       
        public static bool ModificarDatos( this Adoptante a,string nombre,string direccion,int telefono )
        {
            bool rta = true;
            try
            {

                conexion.Open();
                comando.Parameters.Clear();
                comando.Parameters.AddWithValue("@Nombre", nombre);
                comando.Parameters.AddWithValue("@Direccion", direccion);
                comando.Parameters.AddWithValue("@Telefono", telefono);
                comando.Parameters.AddWithValue("@DNI", a.Dni);
                

                string sql = $"UPDATE Adoptante SET Nombre=@Nombre,Direccion=@Direccion,Telefono=@Telefono";
                sql += " WHERE DNI= @DNI";
                comando.CommandText = sql;
                int filasAfectadas = comando.ExecuteNonQuery();
                if (filasAfectadas == 0)
                {
                    rta = false;
                }

            }
            catch (Exception)
            {

                rta = false;
            }
            finally
            {
                if (conexion.State == System.Data.ConnectionState.Open)
                {
                    conexion.Close();
                }
            }
            return rta;

        }
        public static bool Agregar(this Adoptante a)
        {
            bool rta = true;
            try
            {

                comando.Parameters.Clear();
                
                comando.Parameters.AddWithValue("@Nombre", a.Nombre);
                comando.Parameters.AddWithValue("@Direccion", a.Direccion);
                comando.Parameters.AddWithValue("@Telefono",a.Telefono);
                comando.Parameters.AddWithValue("@DNI", a.Dni);
            
                string sql = $"INSERT INTO Adoptante (DNI,Nombre,Direccion,Telefono)";
                sql += $" VALUES (@DNI,@Nombre,@Direccion,@Telefono)";
                comando.CommandText = sql;
                conexion.Open();

                int filasAfectadas = comando.ExecuteNonQuery();
                if (filasAfectadas == 0)
                {
                    rta = false;
                }

            }
            catch (Exception)
            {
                rta = false;
            }
            finally
            {
                if (AdoptanteDAO.conexion.State == System.Data.ConnectionState.Open)
                {
                    AdoptanteDAO.conexion.Close();
                }
            }
            return rta;
        }
        public static bool Eliminar(this Adoptante a)
        {
            bool rta = true;
            try
            {
                comando.Parameters.Clear();
                comando.Parameters.AddWithValue("@DNI", a.Dni);

                string sql = $" DELETE FROM Adoptante WHERE DNI= @DNI";
                conexion.Open();
                comando.CommandText = sql;
                int filasAfectadas = comando.ExecuteNonQuery();
                if (filasAfectadas == 0)
                {
                    rta = false;
                }
            }
            catch (Exception)
            {
                rta = false;

            }
            finally
            {
                if (conexion.State == System.Data.ConnectionState.Open)
                {
                    conexion.Close();
                }
            }
            return rta;


        }
    }


}
